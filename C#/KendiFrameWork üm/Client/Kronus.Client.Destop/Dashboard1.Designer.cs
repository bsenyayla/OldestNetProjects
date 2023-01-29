namespace Kronus.Client.Destop
{
    partial class Dashboard1
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.DashboardCommon.DashboardLayoutGroup dashboardLayoutGroup1 = new DevExpress.DashboardCommon.DashboardLayoutGroup();
            DevExpress.DashboardCommon.DashboardLayoutItem dashboardLayoutItem1 = new DevExpress.DashboardCommon.DashboardLayoutItem();
            DevExpress.DashboardCommon.DashboardLayoutItem dashboardLayoutItem2 = new DevExpress.DashboardCommon.DashboardLayoutItem();
            DevExpress.DashboardCommon.DashboardLayoutItem dashboardLayoutItem3 = new DevExpress.DashboardCommon.DashboardLayoutItem();
            this.gridDashboardItem1 = new DevExpress.DashboardCommon.GridDashboardItem();
            this.gaugeDashboardItem1 = new DevExpress.DashboardCommon.GaugeDashboardItem();
            this.pieMapDashboardItem1 = new DevExpress.DashboardCommon.PieMapDashboardItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridDashboardItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gaugeDashboardItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieMapDashboardItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // gridDashboardItem1
            // 
            this.gridDashboardItem1.ComponentName = "gridDashboardItem1";
            this.gridDashboardItem1.DataItemRepository.Clear();
            this.gridDashboardItem1.InteractivityOptions.IgnoreMasterFilters = false;
            this.gridDashboardItem1.Name = "Grid 1";
            this.gridDashboardItem1.ShowCaption = true;
            // 
            // gaugeDashboardItem1
            // 
            this.gaugeDashboardItem1.ComponentName = "gaugeDashboardItem1";
            this.gaugeDashboardItem1.DataItemRepository.Clear();
            this.gaugeDashboardItem1.InteractivityOptions.IgnoreMasterFilters = false;
            this.gaugeDashboardItem1.Name = "Gauges 1";
            this.gaugeDashboardItem1.ShowCaption = true;
            // 
            // pieMapDashboardItem1
            // 
            this.pieMapDashboardItem1.ComponentName = "pieMapDashboardItem1";
            this.pieMapDashboardItem1.DataItemRepository.Clear();
            this.pieMapDashboardItem1.InteractivityOptions.IgnoreMasterFilters = false;
            this.pieMapDashboardItem1.Name = "Map 1";
            this.pieMapDashboardItem1.ShowCaption = true;
            this.pieMapDashboardItem1.Viewport.BottomLatitude = -55.611829999999962D;
            this.pieMapDashboardItem1.Viewport.CenterPointLatitude = 44.089080744803773D;
            this.pieMapDashboardItem1.Viewport.CenterPointLongitude = 1.4210854715202004E-13D;
            this.pieMapDashboardItem1.Viewport.LeftLongitude = -179.99999999999997D;
            this.pieMapDashboardItem1.Viewport.TopLatitude = 83.645130000000009D;
            // 
            // Dashboard1
            // 
            this.Items.AddRange(new DevExpress.DashboardCommon.DashboardItem[] {
            this.gridDashboardItem1,
            this.gaugeDashboardItem1,
            this.pieMapDashboardItem1});
            dashboardLayoutItem1.DashboardItem = this.gaugeDashboardItem1;
            dashboardLayoutItem1.Weight = 50D;
            dashboardLayoutItem2.DashboardItem = this.pieMapDashboardItem1;
            dashboardLayoutItem2.Weight = 25D;
            dashboardLayoutItem3.DashboardItem = this.gridDashboardItem1;
            dashboardLayoutItem3.Weight = 25D;
            dashboardLayoutGroup1.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {
            dashboardLayoutItem1,
            dashboardLayoutItem2,
            dashboardLayoutItem3});
            dashboardLayoutGroup1.DashboardItem = null;
            this.LayoutRoot = dashboardLayoutGroup1;
            this.Title.ImageDataSerializable = "";
            this.Title.Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.gridDashboardItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gaugeDashboardItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieMapDashboardItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.DashboardCommon.GridDashboardItem gridDashboardItem1;
        private DevExpress.DashboardCommon.GaugeDashboardItem gaugeDashboardItem1;
        private DevExpress.DashboardCommon.PieMapDashboardItem pieMapDashboardItem1;
    }
}
