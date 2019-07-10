namespace Caterpillar.TpemDesktopSc
{
    partial class frmConnect
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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraBars.BarAndDockingController barAndDockingController1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConnect));
            this.GridGateways = new DevExpress.XtraGrid.GridControl();
            this.gvGateways = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.gcConnectedUser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcActions = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.customToolbar1 = new Caterpillar.RemoteClient.UserControl.ucCustomToolbar();
            barAndDockingController1 = new DevExpress.XtraBars.BarAndDockingController(this.components);
            ((System.ComponentModel.ISupportInitialize)(barAndDockingController1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridGateways)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvGateways)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            this.SuspendLayout();
            // 
            // barAndDockingController1
            // 
            barAndDockingController1.AppearancesBar.BarAppearance.Normal.Font = new System.Drawing.Font("Arial Narrow", 8.25F);
            barAndDockingController1.AppearancesBar.BarAppearance.Normal.Options.UseFont = true;
            barAndDockingController1.AppearancesBar.ItemsFont = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            barAndDockingController1.AppearancesBar.MainMenuAppearance.Normal.BorderColor = System.Drawing.Color.Black;
            barAndDockingController1.AppearancesBar.MainMenuAppearance.Normal.Options.UseBorderColor = true;
            barAndDockingController1.AppearancesRibbon.PageHeader.BorderColor = System.Drawing.Color.Black;
            barAndDockingController1.AppearancesRibbon.PageHeader.Font = new System.Drawing.Font("Arial Narrow", 8.25F);
            barAndDockingController1.AppearancesRibbon.PageHeader.Options.UseBorderColor = true;
            barAndDockingController1.AppearancesRibbon.PageHeader.Options.UseFont = true;
            barAndDockingController1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            barAndDockingController1.PropertiesBar.AllowLinkLighting = false;
            barAndDockingController1.PropertiesBar.DefaultGlyphSize = new System.Drawing.Size(32, 16);
            barAndDockingController1.PropertiesBar.DefaultLargeGlyphSize = new System.Drawing.Size(32, 32);
            // 
            // GridGateways
            // 
            this.GridGateways.AllowRestoreSelectionAndFocusedRow = DevExpress.Utils.DefaultBoolean.False;
            this.GridGateways.Cursor = System.Windows.Forms.Cursors.Default;
            this.GridGateways.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridGateways.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GridGateways.Font = new System.Drawing.Font("Arial Narrow", 8.25F);
            this.GridGateways.Location = new System.Drawing.Point(0, 39);
            this.GridGateways.LookAndFeel.SkinMaskColor = System.Drawing.Color.LightGray;
            this.GridGateways.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.GridGateways.LookAndFeel.UseDefaultLookAndFeel = false;
            this.GridGateways.MainView = this.gvGateways;
            this.GridGateways.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GridGateways.Name = "GridGateways";
            this.GridGateways.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit1,
            this.repositoryItemTextEdit1});
            this.GridGateways.Size = new System.Drawing.Size(933, 597);
            this.GridGateways.TabIndex = 14;
            this.GridGateways.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvGateways});
            // 
            // gvGateways
            // 
            this.gvGateways.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold);
            this.gvGateways.Appearance.ColumnFilterButton.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gvGateways.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.gvGateways.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gvGateways.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.gvGateways.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvGateways.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvGateways.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvGateways.Appearance.CustomizationFormHint.ForeColor = System.Drawing.Color.Black;
            this.gvGateways.Appearance.CustomizationFormHint.Options.UseForeColor = true;
            this.gvGateways.Appearance.DetailTip.Font = new System.Drawing.Font("Arial Narrow", 8.25F);
            this.gvGateways.Appearance.DetailTip.Options.UseFont = true;
            this.gvGateways.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.gvGateways.Appearance.Empty.BorderColor = System.Drawing.Color.White;
            this.gvGateways.Appearance.Empty.Options.UseBackColor = true;
            this.gvGateways.Appearance.Empty.Options.UseBorderColor = true;
            this.gvGateways.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.White;
            this.gvGateways.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.gvGateways.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvGateways.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvGateways.Appearance.FilterPanel.BorderColor = System.Drawing.Color.White;
            this.gvGateways.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gvGateways.Appearance.FilterPanel.Options.UseBorderColor = true;
            this.gvGateways.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvGateways.Appearance.FixedLine.BorderColor = System.Drawing.Color.White;
            this.gvGateways.Appearance.FixedLine.ForeColor = System.Drawing.Color.Black;
            this.gvGateways.Appearance.FixedLine.Options.UseBorderColor = true;
            this.gvGateways.Appearance.FixedLine.Options.UseForeColor = true;
            this.gvGateways.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Transparent;
            this.gvGateways.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvGateways.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Transparent;
            this.gvGateways.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvGateways.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Transparent;
            this.gvGateways.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvGateways.Appearance.GroupButton.ForeColor = System.Drawing.Color.Transparent;
            this.gvGateways.Appearance.GroupButton.Options.UseForeColor = true;
            this.gvGateways.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Transparent;
            this.gvGateways.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvGateways.Appearance.GroupRow.BorderColor = System.Drawing.Color.White;
            this.gvGateways.Appearance.GroupRow.Options.UseBorderColor = true;
            this.gvGateways.Appearance.HeaderPanel.BackColor = System.Drawing.Color.DarkGray;
            this.gvGateways.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.DarkGray;
            this.gvGateways.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.LightGray;
            this.gvGateways.Appearance.HeaderPanel.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold);
            this.gvGateways.Appearance.HeaderPanel.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gvGateways.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.White;
            this.gvGateways.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvGateways.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvGateways.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvGateways.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.gvGateways.Appearance.Row.BorderColor = System.Drawing.Color.Black;
            this.gvGateways.Appearance.Row.Font = new System.Drawing.Font("Arial", 8.25F);
            this.gvGateways.Appearance.Row.Options.UseBackColor = true;
            this.gvGateways.Appearance.Row.Options.UseBorderColor = true;
            this.gvGateways.Appearance.Row.Options.UseFont = true;
            this.gvGateways.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.gvGateways.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.Black;
            this.gvGateways.Appearance.RowSeparator.BorderColor = System.Drawing.Color.Black;
            this.gvGateways.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvGateways.Appearance.RowSeparator.Options.UseBorderColor = true;
            this.gvGateways.AppearancePrint.Lines.BorderColor = System.Drawing.Color.White;
            this.gvGateways.AppearancePrint.Lines.Font = new System.Drawing.Font("Arial Narrow", 8.25F);
            this.gvGateways.AppearancePrint.Lines.Options.UseBorderColor = true;
            this.gvGateways.AppearancePrint.Lines.Options.UseFont = true;
            this.gvGateways.AppearancePrint.Row.Font = new System.Drawing.Font("Arial", 8.25F);
            this.gvGateways.AppearancePrint.Row.Options.UseFont = true;
            this.gvGateways.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.gvGateways.ColumnPanelRowHeight = 6;
            this.gvGateways.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcId,
            this.gcName,
            this.gcDescription,
            this.gcConnectedUser,
            this.gcStatus,
            this.gcActions});
            this.gvGateways.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvGateways.GridControl = this.GridGateways;
            this.gvGateways.GroupRowHeight = 1;
            this.gvGateways.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never;
            this.gvGateways.Name = "gvGateways";
            this.gvGateways.OptionsCustomization.AllowColumnResizing = false;
            this.gvGateways.OptionsDetail.EnableMasterViewMode = false;
            this.gvGateways.OptionsPrint.AutoWidth = false;
            this.gvGateways.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvGateways.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.gvGateways.OptionsView.ShowGroupPanel = false;
            this.gvGateways.PaintStyleName = "MixedXP";
            this.gvGateways.RowHeight = 25;
            this.gvGateways.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gvGateways_CustomDrawCell);
            this.gvGateways.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.gvGateways_PopupMenuShowing);
            this.gvGateways.ShownEditor += new System.EventHandler(this.gvGateways_ShownEditor);
            this.gvGateways.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.gvGateways_CustomUnboundColumnData);
            // 
            // gcId
            // 
            this.gcId.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.gcId.AppearanceCell.Options.UseForeColor = true;
            this.gcId.AppearanceCell.Options.UseTextOptions = true;
            this.gcId.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gcId.AppearanceHeader.BorderColor = System.Drawing.Color.DarkGray;
            this.gcId.AppearanceHeader.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.gcId.AppearanceHeader.ForeColor = System.Drawing.Color.White;
            this.gcId.AppearanceHeader.Options.UseBorderColor = true;
            this.gcId.AppearanceHeader.Options.UseFont = true;
            this.gcId.AppearanceHeader.Options.UseForeColor = true;
            this.gcId.FieldName = "GatewayName";
            this.gcId.Name = "gcId";
            this.gcId.OptionsColumn.AllowEdit = false;
            this.gcId.OptionsColumn.AllowMove = false;
            this.gcId.OptionsEditForm.UseEditorColRowSpan = false;
            this.gcId.Visible = true;
            this.gcId.VisibleIndex = 0;
            this.gcId.Width = 88;
            // 
            // gcName
            // 
            this.gcName.AppearanceCell.BorderColor = System.Drawing.Color.Black;
            this.gcName.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.gcName.AppearanceCell.Options.UseBorderColor = true;
            this.gcName.AppearanceCell.Options.UseForeColor = true;
            this.gcName.AppearanceHeader.BorderColor = System.Drawing.Color.Silver;
            this.gcName.AppearanceHeader.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.gcName.AppearanceHeader.ForeColor = System.Drawing.Color.White;
            this.gcName.AppearanceHeader.Options.UseBorderColor = true;
            this.gcName.AppearanceHeader.Options.UseFont = true;
            this.gcName.AppearanceHeader.Options.UseForeColor = true;
            this.gcName.FieldName = "PlantDescription";
            this.gcName.Name = "gcName";
            this.gcName.OptionsColumn.AllowEdit = false;
            this.gcName.OptionsColumn.AllowIncrementalSearch = false;
            this.gcName.OptionsColumn.AllowMove = false;
            this.gcName.OptionsEditForm.RowSpan = 3;
            this.gcName.Visible = true;
            this.gcName.VisibleIndex = 1;
            this.gcName.Width = 119;
            // 
            // gcDescription
            // 
            this.gcDescription.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.gcDescription.AppearanceCell.Options.UseForeColor = true;
            this.gcDescription.AppearanceHeader.BackColor = System.Drawing.Color.DarkGray;
            this.gcDescription.AppearanceHeader.BorderColor = System.Drawing.Color.Silver;
            this.gcDescription.AppearanceHeader.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.gcDescription.AppearanceHeader.ForeColor = System.Drawing.Color.White;
            this.gcDescription.AppearanceHeader.Options.UseBackColor = true;
            this.gcDescription.AppearanceHeader.Options.UseBorderColor = true;
            this.gcDescription.AppearanceHeader.Options.UseFont = true;
            this.gcDescription.AppearanceHeader.Options.UseForeColor = true;
            this.gcDescription.AppearanceHeader.Options.UseTextOptions = true;
            this.gcDescription.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gcDescription.ColumnEdit = this.repositoryItemTextEdit1;
            this.gcDescription.FieldName = "Remark";
            this.gcDescription.Name = "gcDescription";
            this.gcDescription.OptionsColumn.AllowMove = false;
            this.gcDescription.OptionsEditForm.UseEditorColRowSpan = false;
            this.gcDescription.Visible = true;
            this.gcDescription.VisibleIndex = 2;
            this.gcDescription.Width = 88;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.MaxLength = 255;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // gcConnectedUser
            // 
            this.gcConnectedUser.AppearanceCell.Options.UseTextOptions = true;
            this.gcConnectedUser.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.None;
            this.gcConnectedUser.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gcConnectedUser.AppearanceHeader.BorderColor = System.Drawing.Color.Silver;
            this.gcConnectedUser.AppearanceHeader.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.gcConnectedUser.AppearanceHeader.ForeColor = System.Drawing.Color.White;
            this.gcConnectedUser.AppearanceHeader.Options.UseBorderColor = true;
            this.gcConnectedUser.AppearanceHeader.Options.UseFont = true;
            this.gcConnectedUser.AppearanceHeader.Options.UseForeColor = true;
            this.gcConnectedUser.AppearanceHeader.Options.UseTextOptions = true;
            this.gcConnectedUser.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gcConnectedUser.FieldName = "ConnectedUser";
            this.gcConnectedUser.Name = "gcConnectedUser";
            this.gcConnectedUser.OptionsColumn.AllowEdit = false;
            this.gcConnectedUser.OptionsColumn.AllowMove = false;
            this.gcConnectedUser.OptionsEditForm.VisibleIndex = 3;
            this.gcConnectedUser.Visible = true;
            this.gcConnectedUser.VisibleIndex = 3;
            this.gcConnectedUser.Width = 109;
            // 
            // gcStatus
            // 
            this.gcStatus.AppearanceCell.BorderColor = System.Drawing.Color.Black;
            this.gcStatus.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.gcStatus.AppearanceCell.Options.UseBorderColor = true;
            this.gcStatus.AppearanceCell.Options.UseForeColor = true;
            this.gcStatus.AppearanceHeader.BorderColor = System.Drawing.Color.Silver;
            this.gcStatus.AppearanceHeader.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.gcStatus.AppearanceHeader.ForeColor = System.Drawing.Color.White;
            this.gcStatus.AppearanceHeader.Options.UseBorderColor = true;
            this.gcStatus.AppearanceHeader.Options.UseFont = true;
            this.gcStatus.AppearanceHeader.Options.UseForeColor = true;
            this.gcStatus.FieldName = "Status";
            this.gcStatus.Name = "gcStatus";
            this.gcStatus.OptionsColumn.AllowEdit = false;
            this.gcStatus.OptionsColumn.AllowMove = false;
            this.gcStatus.Visible = true;
            this.gcStatus.VisibleIndex = 4;
            this.gcStatus.Width = 79;
            // 
            // gcActions
            // 
            this.gcActions.AppearanceHeader.BorderColor = System.Drawing.Color.Silver;
            this.gcActions.AppearanceHeader.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.gcActions.AppearanceHeader.ForeColor = System.Drawing.Color.White;
            this.gcActions.AppearanceHeader.Options.UseBorderColor = true;
            this.gcActions.AppearanceHeader.Options.UseFont = true;
            this.gcActions.AppearanceHeader.Options.UseForeColor = true;
            this.gcActions.ColumnEdit = this.repositoryItemButtonEdit1;
            this.gcActions.FieldName = "Action";
            this.gcActions.Name = "gcActions";
            this.gcActions.OptionsEditForm.RowSpan = 2;
            this.gcActions.OptionsFilter.AllowAutoFilter = false;
            this.gcActions.OptionsFilter.AllowFilter = false;
            this.gcActions.Visible = true;
            this.gcActions.VisibleIndex = 5;
            this.gcActions.Width = 124;
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)});
            this.repositoryItemButtonEdit1.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            this.repositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // imgList
            // 
            this.imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList.ImageStream")));
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList.Images.SetKeyName(0, "refresh.png");
            this.imgList.Images.SetKeyName(1, "ClearFilter.gif");
            this.imgList.Images.SetKeyName(2, "Filter2HS.png");
            this.imgList.Images.SetKeyName(3, "printer.png");
            this.imgList.Images.SetKeyName(4, "application_side_expand.png");
            // 
            // popupMenu1
            // 
            this.popupMenu1.Name = "popupMenu1";
            // 
            // customToolbar1
            // 
            this.customToolbar1.AllowDrop = true;
            this.customToolbar1.Appearance.Options.UseFont = true;
            this.customToolbar1.ColorScheme = Caterpillar.RemoteClient.UserControl.ColorScheme.Black;
            this.customToolbar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.customToolbar1.Location = new System.Drawing.Point(0, 0);
            this.customToolbar1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.customToolbar1.Name = "customToolbar1";
            this.customToolbar1.Size = new System.Drawing.Size(933, 39);
            this.customToolbar1.TabIndex = 19;
            // 
            // frmConnect
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseTextOptions = true;
            this.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 636);
            this.Controls.Add(this.GridGateways);
            this.Controls.Add(this.customToolbar1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmConnect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmConnect_FormClosing);
            this.Load += new System.EventHandler(this.frmConnect_Load);
            ((System.ComponentModel.ISupportInitialize)(barAndDockingController1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridGateways)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvGateways)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl GridGateways;
        private DevExpress.XtraGrid.Views.Grid.GridView gvGateways;
        private DevExpress.XtraGrid.Columns.GridColumn gcName;
        private DevExpress.XtraGrid.Columns.GridColumn gcStatus;
        private DevExpress.XtraGrid.Columns.GridColumn gcDescription;
        private System.Windows.Forms.ImageList imgList;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private RemoteClient.UserControl.ucCustomToolbar customToolbar1;
        private DevExpress.XtraGrid.Columns.GridColumn gcActions;
        private DevExpress.XtraGrid.Columns.GridColumn gcConnectedUser;
        private DevExpress.XtraGrid.Columns.GridColumn gcId;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
    }
}