namespace InterfaceApp {
    partial class pieChartFrm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.pieChart = new DevExpress.XtraCharts.ChartControl();
            this.grafik_1 = new DevExpress.XtraCharts.ChartControl();
            this.ganttChart = new DevExpress.XtraCharts.ChartControl();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            ((System.ComponentModel.ISupportInitialize)(this.pieChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafik_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ganttChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // pieChart
            // 
            this.pieChart.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.pieChart.DataBindings = null;
            this.pieChart.Legend.Name = "Default Legend";
            this.pieChart.Location = new System.Drawing.Point(14, 12);
            this.pieChart.Name = "pieChart";
            this.pieChart.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.pieChart.Size = new System.Drawing.Size(372, 330);
            this.pieChart.TabIndex = 0;
            this.pieChart.DoubleClick += new System.EventHandler(this.pieChart_DoubleClick);
            // 
            // grafik_1
            // 
            this.grafik_1.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.grafik_1.DataBindings = null;
            this.grafik_1.Legend.Name = "Default Legend";
            this.grafik_1.Location = new System.Drawing.Point(423, 12);
            this.grafik_1.Name = "grafik_1";
            this.grafik_1.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.grafik_1.Size = new System.Drawing.Size(372, 330);
            this.grafik_1.TabIndex = 1;
            this.grafik_1.DoubleClick += new System.EventHandler(this.pieChart_DoubleClick);
            // 
            // ganttChart
            // 
            this.ganttChart.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.ganttChart.DataBindings = null;
            this.ganttChart.Legend.Name = "Default Legend";
            this.ganttChart.Location = new System.Drawing.Point(16, 349);
            this.ganttChart.Name = "ganttChart";
            this.ganttChart.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.ganttChart.Size = new System.Drawing.Size(372, 330);
            this.ganttChart.TabIndex = 2;
            this.ganttChart.DoubleClick += new System.EventHandler(this.pieChart_DoubleClick);
            // 
            // chartControl1
            // 
            this.chartControl1.DataBindings = null;
            this.chartControl1.Legend.Name = "Default Legend";
            this.chartControl1.Location = new System.Drawing.Point(476, 389);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartControl1.Size = new System.Drawing.Size(300, 200);
            this.chartControl1.TabIndex = 3;
            // 
            // pieChartFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(771, 695);
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.ganttChart);
            this.Controls.Add(this.grafik_1);
            this.Controls.Add(this.pieChart);
            this.Name = "pieChartFrm";
            this.Text = "pieChartFrm";
            this.Load += new System.EventHandler(this.pieChartFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pieChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafik_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ganttChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraCharts.ChartControl pieChart;
        private DevExpress.XtraCharts.ChartControl grafik_1;
        private DevExpress.XtraCharts.ChartControl ganttChart;
        private DevExpress.XtraCharts.ChartControl chartControl1;
    }
}