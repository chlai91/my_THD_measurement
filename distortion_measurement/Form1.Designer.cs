namespace distortion_measurement
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.InputChannelComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rms_label = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.SpectrumGraph = new NationalInstruments.UI.WindowsForms.WaveformGraph();
            this.waveformPlot1 = new NationalInstruments.UI.WaveformPlot();
            this.xAxis1 = new NationalInstruments.UI.XAxis();
            this.yAxis1 = new NationalInstruments.UI.YAxis();
            this.label2 = new System.Windows.Forms.Label();
            this.v1_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.frequency_label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.THDn_label = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpectrumGraph)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(92, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "measurement";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(197, 45);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "fresh";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // InputChannelComboBox
            // 
            this.InputChannelComboBox.FormattingEnabled = true;
            this.InputChannelComboBox.Location = new System.Drawing.Point(56, 46);
            this.InputChannelComboBox.Name = "InputChannelComboBox";
            this.InputChannelComboBox.Size = new System.Drawing.Size(121, 23);
            this.InputChannelComboBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "volt (RMS V) = ";
            // 
            // rms_label
            // 
            this.rms_label.AutoSize = true;
            this.rms_label.Location = new System.Drawing.Point(163, 88);
            this.rms_label.Name = "rms_label";
            this.rms_label.Size = new System.Drawing.Size(14, 15);
            this.rms_label.TabIndex = 4;
            this.rms_label.Text = "0";
            // 
            // SpectrumGraph
            // 
            this.SpectrumGraph.Location = new System.Drawing.Point(332, 45);
            this.SpectrumGraph.Name = "SpectrumGraph";
            this.SpectrumGraph.Plots.AddRange(new NationalInstruments.UI.WaveformPlot[] {
            this.waveformPlot1});
            this.SpectrumGraph.Size = new System.Drawing.Size(272, 168);
            this.SpectrumGraph.TabIndex = 5;
            this.SpectrumGraph.UseColorGenerator = true;
            this.SpectrumGraph.XAxes.AddRange(new NationalInstruments.UI.XAxis[] {
            this.xAxis1});
            this.SpectrumGraph.YAxes.AddRange(new NationalInstruments.UI.YAxis[] {
            this.yAxis1});
            // 
            // waveformPlot1
            // 
            this.waveformPlot1.XAxis = this.xAxis1;
            this.waveformPlot1.YAxis = this.yAxis1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "v1 =";
            // 
            // v1_label
            // 
            this.v1_label.AutoSize = true;
            this.v1_label.Location = new System.Drawing.Point(163, 117);
            this.v1_label.Name = "v1_label";
            this.v1_label.Size = new System.Drawing.Size(14, 15);
            this.v1_label.TabIndex = 7;
            this.v1_label.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "frequency =";
            // 
            // frequency_label
            // 
            this.frequency_label.AutoSize = true;
            this.frequency_label.Location = new System.Drawing.Point(162, 146);
            this.frequency_label.Name = "frequency_label";
            this.frequency_label.Size = new System.Drawing.Size(14, 15);
            this.frequency_label.TabIndex = 9;
            this.frequency_label.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "THD+n =";
            // 
            // THDn_label
            // 
            this.THDn_label.AutoSize = true;
            this.THDn_label.Location = new System.Drawing.Point(162, 180);
            this.THDn_label.Name = "THDn_label";
            this.THDn_label.Size = new System.Drawing.Size(14, 15);
            this.THDn_label.TabIndex = 11;
            this.THDn_label.Text = "0";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(517, 284);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "test signal";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 362);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.THDn_label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.frequency_label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.v1_label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SpectrumGraph);
            this.Controls.Add(this.rms_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InputChannelComboBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpectrumGraph)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox InputChannelComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label rms_label;
        private System.Windows.Forms.BindingSource bindingSource1;
        private NationalInstruments.UI.WindowsForms.WaveformGraph SpectrumGraph;
        private NationalInstruments.UI.WaveformPlot waveformPlot1;
        private NationalInstruments.UI.XAxis xAxis1;
        private NationalInstruments.UI.YAxis yAxis1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label v1_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label frequency_label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label THDn_label;
        private System.Windows.Forms.Button button3;
    }
}

