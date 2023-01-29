namespace Kronus.Client.Common.Forms
{
    partial class Theme
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Theme));
            this.themeGrid = new DevExpress.XtraGrid.GridControl();
            this.themeGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Tema = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.themeGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.themeGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // themeGrid
            // 
            this.themeGrid.Cursor = System.Windows.Forms.Cursors.Default;
            this.themeGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.themeGrid.Location = new System.Drawing.Point(0, 0);
            this.themeGrid.MainView = this.themeGridView;
            this.themeGrid.Name = "themeGrid";
            this.themeGrid.Size = new System.Drawing.Size(439, 297);
            this.themeGrid.TabIndex = 0;
            this.themeGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.themeGridView});
            // 
            // themeGridView
            // 
            this.themeGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Tema});
            this.themeGridView.GridControl = this.themeGrid;
            this.themeGridView.Name = "themeGridView";
            this.themeGridView.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView1_RowCellClick);
            this.themeGridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // Tema
            // 
            this.Tema.Caption = "gridColumn1";
            this.Tema.FieldName = "SkinName";
            this.Tema.Name = "Tema";
            this.Tema.Visible = true;
            this.Tema.VisibleIndex = 0;
            // 
            // Theme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 297);
            this.Controls.Add(this.themeGrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.LookAndFeel.SkinName = "Caramel";
            this.LookAndFeel.TouchUI = true;
            this.Name = "Theme";
            this.Text = "Theme";
            this.Load += new System.EventHandler(this.Theme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.themeGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.themeGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl themeGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView themeGridView;
        private DevExpress.XtraGrid.Columns.GridColumn Tema;
    }
}