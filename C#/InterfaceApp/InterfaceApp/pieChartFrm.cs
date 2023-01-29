using DevExpress.XtraCharts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfaceApp {
    public partial class pieChartFrm : Form {
        public pieChartFrm() {
            InitializeComponent();
        }



        static DataTable GetTable() {
            DataTable table = new DataTable();
            table.Columns.Add("Argument", typeof(string));
            table.Columns.Add("Value", typeof(int));


            table.Rows.Add("A birimi", 0);
            table.Rows.Add("B birimi", 33);
            table.Rows.Add("C birimi", 20);
            table.Rows.Add("D birimi", 80);
            table.Rows.Add("E birimi", 50);
            return table;
        }

        private void pieChartFrm_Load(object sender, EventArgs e) {
            FillGrid();
            Grafik_3();

            // Create an empty chart
            pieChart.Titles.Add(new ChartTitle() { Text = "Standart Görevlerin Tamamlanma Yüzdeleri" });

            // Create a pie series. 
            Series series1 = new Series("Standartlar", ViewType.Bar);

            // Bind the series to data. 
            series1.DataSource = GetTable();
            //                DataPoint.GetDataPoints();
            series1.ArgumentDataMember = "Argument";
            series1.ValueDataMembers.AddRange(new string[] { "Value" });

            // Add the series to the chart. 
            pieChart.Series.Add(series1);

            // Format the the series labels. 
            series1.Label.TextPattern = "{VP:p0} ({V:.##}M km²)";

            // Format the series legend items. 
            series1.LegendTextPattern = "{A}";

            // Adjust the position of series labels.  
            //((PieSeriesLabel)series1.Label).Position = PieSeriesLabelPosition.TwoColumns;

            // Detect overlapping of series labels. 
            //((PieSeriesLabel)series1.Label).ResolveOverlappingMode = ResolveOverlappingMode.Default;

            // Access the view-type-specific options of the series. 
            //PieSeriesView myView = (PieSeriesView)series1.View;

            //// Specify a data filter to explode points. 
            //myView.ExplodedPointsFilters.Add(new SeriesPointFilter(SeriesPointKey.Value_1,
            //    DataFilterCondition.GreaterThanOrEqual, 9));
            //myView.ExplodedPointsFilters.Add(new SeriesPointFilter(SeriesPointKey.Argument,
            //    DataFilterCondition.NotEqual, "Others"));
            //myView.ExplodeMode = PieExplodeMode.UseFilters;
            //myView.ExplodedDistancePercentage = 30;
            //myView.RuntimeExploding = true;

            // Customize the legend. 
            pieChart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True;
        }

        public class DataPoint {
            public string Argument { get; set; }
            public double Value { get; set; }

            public static List<DataPoint> GetDataPoints() {
                return new List<DataPoint> {
                    new DataPoint { Argument = "1KOS1.1",    Value =10},
                    new DataPoint { Argument = "2BİS15.4",    Value = 33},
                    new DataPoint { Argument = "3ISI3.2",       Value = 0},
                    new DataPoint { Argument = "4China",     Value = 100},
                    new DataPoint { Argument = "5Brazil",    Value = 50},
                    new DataPoint { Argument = "6KOS1.1",    Value =10},
                    new DataPoint { Argument = "7BİS15.4",    Value = 33},
                    new DataPoint { Argument = "8ISI3.2",       Value = 0},
                    new DataPoint { Argument = "9China",     Value = 100},
                    new DataPoint { Argument = "10Brazil",    Value = 50},
                    new DataPoint { Argument = "11KOS1.1",    Value =10},
                    new DataPoint { Argument = "12BİS15.4",    Value = 33},
                    new DataPoint { Argument = "13ISI3.2",       Value = 0},
                    new DataPoint { Argument = "14China",     Value = 100},
                    new DataPoint { Argument = "15Brazil",    Value = 50}
                };
            }
        }

        private void pieChart_DoubleClick(object sender, EventArgs e) {

            if (((System.Windows.Forms.Control)(sender)).Dock == DockStyle.Fill) {
                ((System.Windows.Forms.Control)(sender)).Dock = DockStyle.None;
            }
            else {
                ((System.Windows.Forms.Control)(sender)).Dock = DockStyle.Fill;
            }

        }


        void FillGrid() {
            //Create an empty chart.
            
            // Create a pie series.
            Series series1 = new Series("Pie Series 1", ViewType.Pie3D);

            // Populate the series with points.
            series1.Points.Add(new SeriesPoint("Russia", 17.0752));
            series1.Points.Add(new SeriesPoint("Canada", 9.98467));
            series1.Points.Add(new SeriesPoint("USA", 9.63142));
            series1.Points.Add(new SeriesPoint("China", 9.59696));
            series1.Points.Add(new SeriesPoint("Brazil", 8.511965));
            series1.Points.Add(new SeriesPoint("Australia", 7.68685));
            series1.Points.Add(new SeriesPoint("India", 3.28759));
            series1.Points.Add(new SeriesPoint("Others", 81.2));

            // Add the series to the chart.
            grafik_1.Series.Add(series1);

            // Adjust the value numeric options of the series.
            series1.PointOptions.ValueNumericOptions.Format = NumericFormat.Percent;
            series1.PointOptions.ValueNumericOptions.Precision = 0;

            // Adjust the view-type-specific options of the series.
            ((Pie3DSeriesView)series1.View).Depth = 30;
            ((Pie3DSeriesView)series1.View).ExplodedPoints.Add(series1.Points[0]);
            ((Pie3DSeriesView)series1.View).ExplodedDistancePercentage = 30;

            // Access the diagram's options.
            ((SimpleDiagram3D)grafik_1.Diagram).RotationType = RotationType.UseAngles;
            ((SimpleDiagram3D)grafik_1.Diagram).RotationAngleX = -35;

            // Add a title to the chart and hide the legend.
            ChartTitle chartTitle1 = new ChartTitle();
            chartTitle1.Text = "3D Pie Chart";
            grafik_1.Titles.Add(chartTitle1);
            grafik_1.Legend.Visible = false;

            // Add the chart to the form.
            //grafik_1.Dock = DockStyle.Fill;
            //this.Controls.Add(grafik_1);
        }


        void Grafik_3() {

            // Create a new chart.
            

            // Create two Gantt series.
            Series series1 = new Series("Estimation", ViewType.SideBySideGantt);
            Series series2 = new Series("Implementation", ViewType.SideBySideGantt);

            // Specify the date-time value scale type,
            // because it is qualitative by default.
            series1.ValueScaleType = ScaleType.DateTime;
            series2.ValueScaleType = ScaleType.DateTime;

            // Add points to them.
            series1.Points.Add(new SeriesPoint("Task 1", new DateTime[] { 
    new DateTime(2006, 8, 16), new DateTime(2006, 8, 31) }));
            series1.Points.Add(new SeriesPoint("Task 2", new DateTime[] { 
    new DateTime(2006, 8, 31), new DateTime(2006, 9, 15) }));
            series1.Points.Add(new SeriesPoint("Task 3", new DateTime[] { 
    new DateTime(2006, 9, 15), new DateTime(2006, 9, 30) }));
            series1.Points.Add(new SeriesPoint("Task 4", new DateTime[] { 
    new DateTime(2006, 9, 30), new DateTime(2006, 10, 15) }));

            series2.Points.Add(new SeriesPoint("Task 1", new DateTime[] { 
    new DateTime(2006, 8, 16), new DateTime(2006, 9, 5) }));
            series2.Points.Add(new SeriesPoint("Task 2", new DateTime[] { 
    new DateTime(2006, 9, 5), new DateTime(2006, 9, 22) }));
            series2.Points.Add(new SeriesPoint("Task 3", new DateTime[] { 
    new DateTime(2006, 9, 22), new DateTime(2006, 10, 10) }));
            series2.Points.Add(new SeriesPoint("Task 4", new DateTime[] { 
    new DateTime(2006, 10, 10), new DateTime(2006, 10, 23) }));

            // Add both series to the chart.
            ganttChart.Series.AddRange(new Series[] { series1, series2 });

            // Access the view-type-specific options of the second series.
            SideBySideGanttSeriesView myView2 = (SideBySideGanttSeriesView)series2.View;

            myView2.MaxValueMarker.Visible = true;
            myView2.MaxValueMarker.Kind = MarkerKind.Star;
            myView2.MaxValueMarker.StarPointCount = 5;
            myView2.MaxValueMarker.Size = 10;

            myView2.MinValueMarker.Visible = true;
            myView2.MinValueMarker.Kind = MarkerKind.Circle;
            myView2.MinValueMarker.Size = 10;

            myView2.BarWidth = 0.5;

            // Customize the chart (if necessary).
            GanttDiagram myDiagram = (GanttDiagram)ganttChart.Diagram;

            myDiagram.AxisX.Title.Visible = true;
            myDiagram.AxisX.Title.Text = "Tasks";
            myDiagram.AxisY.Interlaced = true;
            myDiagram.AxisY.GridSpacing = 10;
            myDiagram.AxisY.Label.Angle = -30;
            myDiagram.AxisY.DateTimeOptions.Format = DateTimeFormat.MonthAndDay;

            // Customize the legend (if necessary).
            ganttChart.Legend.AlignmentHorizontal = LegendAlignmentHorizontal.Right;
            ganttChart.Legend.AlignmentVertical = LegendAlignmentVertical.TopOutside;
            ganttChart.Legend.Direction = LegendDirection.LeftToRight;

            // Add a constant line.
            ConstantLine deadline = new ConstantLine("Deadline", new DateTime(2006, 10, 15));
            deadline.ShowInLegend = false;
            deadline.Title.Alignment = ConstantLineTitleAlignment.Far;
            deadline.Color = Color.Red;
            myDiagram.AxisY.ConstantLines.Add(deadline);

            // Add a title to the chart (if necessary).
            ganttChart.Titles.Add(new ChartTitle());
            ganttChart.Titles[0].Text = "A Side-by-Side Gantt Chart";

            // Add the chart to the form.
            //ganttChart.Dock = DockStyle.Fill;
            //this.Controls.Add(ganttChart);
        }
    }
}
