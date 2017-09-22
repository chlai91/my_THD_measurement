using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using NationalInstruments;
//using NationalInstruments.Examples;
using NationalInstruments.DAQmx;
using NationalInstruments.UI;
using NationalInstruments.UI.WindowsForms;
using NationalInstruments.Analysis.Dsp;      //使用FFt
using NationalInstruments.Analysis.Math;


namespace distortion_measurement
{
    public partial class Form1 : Form
    {
        AIChannel aiCh1;
        int rates = 100000;
        int samples = 100000;
        
        private NationalInstruments.DAQmx.Task InputTask;
        private NationalInstruments.DAQmx.Task InputRunningTask;
        private AnalogMultiChannelReader analogInReader;
        private AnalogWaveform<double>[] input_data;
        ComplexDouble[] zdata;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double rms=0;
            double[] raw_data = null;
            double v1 = 0;
            double ft = 0;

            try
            {

                InputTask = new NationalInstruments.DAQmx.Task();

                aiCh1 = InputTask.AIChannels.CreateVoltageChannel(InputChannelComboBox.Text, "",
                    (AITerminalConfiguration)(-1), -3.5, 3.5, AIVoltageUnits.Volts);
                aiCh1.Coupling = AICoupling.AC;
                //Configure the timing parameters
                InputTask.Timing.ConfigureSampleClock("", rates,
                SampleClockActiveEdge.Rising, SampleQuantityMode.FiniteSamples, samples);

                //Verify the Task
                InputTask.Control(TaskAction.Verify);
                InputRunningTask = InputTask;
                analogInReader = new AnalogMultiChannelReader(InputTask.Stream);
                input_data = analogInReader.ReadWaveform(samples);
                raw_data = input_data[0].GetRawData();

                zdata = Transforms.RealFft(raw_data);
                double[] mag;
                mag = ComplexDouble.GetMagnitudes(zdata);
                SpectrumGraph.PlotY(mag);

                rms = Statistics.RootMeanSquared(raw_data);
                rms_label.Text = rms.ToString();

                ft = mag.Sum();
                frequency_label.Text = ft.ToString();

                v1 = find_v1(raw_data) ;
                v1_label.Text = v1.ToString() ;

                THDn_label.Text = ((ft - v1 ) / ft).ToString();


                MessageBox.Show(rms.ToString());
            }
            catch (DaqException exception)
            {
                //Display Errors
                MessageBox.Show(exception.Message);
                InputRunningTask = null;
                InputTask.Dispose();
                MessageBox.Show("input error!");
            }
                
            }

        private double find_v1(double[] data)
        {
            double v1=0;

            v1 = data.Max();

            return v1;
        } 

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            InputChannelComboBox.Items.AddRange(DaqSystem.Local.GetPhysicalChannels(PhysicalChannelTypes.AI, PhysicalChannelAccess.External));
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
