namespace WinFormsApp
{
    partial class MainWindow
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutXamlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.structureContainer = new System.Windows.Forms.Panel();
            this.toolBoxContainer = new System.Windows.Forms.Panel();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.mainContainer = new System.Windows.Forms.SplitContainer();
            this.leftContainer = new System.Windows.Forms.SplitContainer();
            this.leftInnerContainer = new System.Windows.Forms.SplitContainer();
            this.toolBoxListBox = new System.Windows.Forms.ListBox();
            this.toolboxPanelCaption = new System.Windows.Forms.Panel();
            this.toolboxPanelLabel = new System.Windows.Forms.Label();
            this.objectsPanel = new System.Windows.Forms.Panel();
            this.objectsTreeView = new System.Windows.Forms.TreeView();
            this.objectsPanelCaption = new System.Windows.Forms.Panel();
            this.objectsPanelLabel = new System.Windows.Forms.Label();
            this.toolboxPanel = new System.Windows.Forms.Panel();
            this.centerContainer = new System.Windows.Forms.SplitContainer();
            this.documentsTabControl = new System.Windows.Forms.TabControl();
            this.systemTabControl = new System.Windows.Forms.TabControl();
            this.errorsTabPage = new System.Windows.Forms.TabPage();
            this.outputTabPage = new System.Windows.Forms.TabPage();
            this.rightContainer = new System.Windows.Forms.SplitContainer();
            this.explorerPanel = new System.Windows.Forms.Panel();
            this.explorerPanelCaption = new System.Windows.Forms.Panel();
            this.explorerPanelLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tabControlProperties = new System.Windows.Forms.TabControl();
            this.tabPagePropertiesAll = new System.Windows.Forms.TabPage();
            this.tableLayoutProperties = new System.Windows.Forms.TableLayoutPanel();
            this.tabPagePropertiesAssigned = new System.Windows.Forms.TabPage();
            this.propertiesPanelToolbox = new System.Windows.Forms.Panel();
            this.propertiesPanelCaption = new System.Windows.Forms.Panel();
            this.propertiesPanelLabel = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainContainer)).BeginInit();
            this.mainContainer.Panel1.SuspendLayout();
            this.mainContainer.Panel2.SuspendLayout();
            this.mainContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leftContainer)).BeginInit();
            this.leftContainer.Panel1.SuspendLayout();
            this.leftContainer.Panel2.SuspendLayout();
            this.leftContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leftInnerContainer)).BeginInit();
            this.leftInnerContainer.Panel1.SuspendLayout();
            this.leftInnerContainer.Panel2.SuspendLayout();
            this.leftInnerContainer.SuspendLayout();
            this.toolboxPanelCaption.SuspendLayout();
            this.objectsPanel.SuspendLayout();
            this.objectsPanelCaption.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.centerContainer)).BeginInit();
            this.centerContainer.Panel1.SuspendLayout();
            this.centerContainer.Panel2.SuspendLayout();
            this.centerContainer.SuspendLayout();
            this.systemTabControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rightContainer)).BeginInit();
            this.rightContainer.Panel1.SuspendLayout();
            this.rightContainer.Panel2.SuspendLayout();
            this.rightContainer.SuspendLayout();
            this.explorerPanelCaption.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabControlProperties.SuspendLayout();
            this.tabPagePropertiesAll.SuspendLayout();
            this.propertiesPanelCaption.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(933, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(137, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutXamlerToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutXamlerToolStripMenuItem
            // 
            this.aboutXamlerToolStripMenuItem.Name = "aboutXamlerToolStripMenuItem";
            this.aboutXamlerToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.aboutXamlerToolStripMenuItem.Text = "About Xamler";
            this.aboutXamlerToolStripMenuItem.Click += new System.EventHandler(this.aboutXamlerToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 0;
            // 
            // structureContainer
            // 
            this.structureContainer.BackColor = System.Drawing.SystemColors.Highlight;
            this.structureContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.structureContainer.Location = new System.Drawing.Point(0, 166);
            this.structureContainer.Name = "structureContainer";
            this.structureContainer.Size = new System.Drawing.Size(200, 260);
            this.structureContainer.TabIndex = 1;
            // 
            // toolBoxContainer
            // 
            this.toolBoxContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolBoxContainer.Location = new System.Drawing.Point(0, 0);
            this.toolBoxContainer.Name = "toolBoxContainer";
            this.toolBoxContainer.Size = new System.Drawing.Size(200, 157);
            this.toolBoxContainer.TabIndex = 2;
            // 
            // statusStrip
            // 
            this.statusStrip.Location = new System.Drawing.Point(0, 521);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(933, 22);
            this.statusStrip.TabIndex = 6;
            this.statusStrip.Text = "statusStrip1";
            // 
            // mainContainer
            // 
            this.mainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContainer.Location = new System.Drawing.Point(0, 24);
            this.mainContainer.Name = "mainContainer";
            // 
            // mainContainer.Panel1
            // 
            this.mainContainer.Panel1.Controls.Add(this.leftContainer);
            // 
            // mainContainer.Panel2
            // 
            this.mainContainer.Panel2.Controls.Add(this.rightContainer);
            this.mainContainer.Size = new System.Drawing.Size(933, 497);
            this.mainContainer.SplitterDistance = 658;
            this.mainContainer.TabIndex = 9;
            // 
            // leftContainer
            // 
            this.leftContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftContainer.Location = new System.Drawing.Point(0, 0);
            this.leftContainer.Name = "leftContainer";
            // 
            // leftContainer.Panel1
            // 
            this.leftContainer.Panel1.Controls.Add(this.leftInnerContainer);
            this.leftContainer.Panel1.Controls.Add(this.toolboxPanel);
            this.leftContainer.Panel1.Click += new System.EventHandler(this.toolWindowClick);
            // 
            // leftContainer.Panel2
            // 
            this.leftContainer.Panel2.Controls.Add(this.centerContainer);
            this.leftContainer.Panel2.Click += new System.EventHandler(this.toolWindowClick);
            this.leftContainer.Size = new System.Drawing.Size(658, 497);
            this.leftContainer.SplitterDistance = 217;
            this.leftContainer.TabIndex = 8;
            // 
            // leftInnerContainer
            // 
            this.leftInnerContainer.BackColor = System.Drawing.SystemColors.ControlDark;
            this.leftInnerContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftInnerContainer.Location = new System.Drawing.Point(0, 0);
            this.leftInnerContainer.Name = "leftInnerContainer";
            this.leftInnerContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // leftInnerContainer.Panel1
            // 
            this.leftInnerContainer.Panel1.Controls.Add(this.toolBoxListBox);
            this.leftInnerContainer.Panel1.Controls.Add(this.toolboxPanelCaption);
            this.leftInnerContainer.Panel1.Click += new System.EventHandler(this.toolWindowClick);
            // 
            // leftInnerContainer.Panel2
            // 
            this.leftInnerContainer.Panel2.Controls.Add(this.objectsPanel);
            this.leftInnerContainer.Panel2.Controls.Add(this.objectsPanelCaption);
            this.leftInnerContainer.Size = new System.Drawing.Size(217, 497);
            this.leftInnerContainer.SplitterDistance = 198;
            this.leftInnerContainer.TabIndex = 4;
            // 
            // toolBoxListBox
            // 
            this.toolBoxListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolBoxListBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolBoxListBox.FormattingEnabled = true;
            this.toolBoxListBox.Location = new System.Drawing.Point(0, 23);
            this.toolBoxListBox.Name = "toolBoxListBox";
            this.toolBoxListBox.Size = new System.Drawing.Size(217, 175);
            this.toolBoxListBox.TabIndex = 2;
            this.toolBoxListBox.Click += new System.EventHandler(this.toolWindowClick);
            // 
            // toolboxPanelCaption
            // 
            this.toolboxPanelCaption.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.toolboxPanelCaption.Controls.Add(this.toolboxPanelLabel);
            this.toolboxPanelCaption.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolboxPanelCaption.Location = new System.Drawing.Point(0, 0);
            this.toolboxPanelCaption.Name = "toolboxPanelCaption";
            this.toolboxPanelCaption.Size = new System.Drawing.Size(217, 23);
            this.toolboxPanelCaption.TabIndex = 1;
            this.toolboxPanelCaption.Click += new System.EventHandler(this.toolWindowClick);
            // 
            // toolboxPanelLabel
            // 
            this.toolboxPanelLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.toolboxPanelLabel.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolboxPanelLabel.Location = new System.Drawing.Point(9, 4);
            this.toolboxPanelLabel.Margin = new System.Windows.Forms.Padding(0);
            this.toolboxPanelLabel.Name = "toolboxPanelLabel";
            this.toolboxPanelLabel.Size = new System.Drawing.Size(85, 15);
            this.toolboxPanelLabel.TabIndex = 1;
            this.toolboxPanelLabel.Text = "Toolbox";
            // 
            // objectsPanel
            // 
            this.objectsPanel.Controls.Add(this.objectsTreeView);
            this.objectsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.objectsPanel.Location = new System.Drawing.Point(0, 23);
            this.objectsPanel.Name = "objectsPanel";
            this.objectsPanel.Size = new System.Drawing.Size(217, 272);
            this.objectsPanel.TabIndex = 4;
            // 
            // objectsTreeView
            // 
            this.objectsTreeView.AllowDrop = true;
            this.objectsTreeView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.objectsTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.objectsTreeView.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.objectsTreeView.FullRowSelect = true;
            this.objectsTreeView.HotTracking = true;
            this.objectsTreeView.Location = new System.Drawing.Point(0, 0);
            this.objectsTreeView.Name = "objectsTreeView";
            this.objectsTreeView.Size = new System.Drawing.Size(217, 272);
            this.objectsTreeView.TabIndex = 2;
            this.objectsTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.objectsTreeView_AfterSelect);
            this.objectsTreeView.Click += new System.EventHandler(this.toolWindowClick);
            // 
            // objectsPanelCaption
            // 
            this.objectsPanelCaption.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.objectsPanelCaption.Controls.Add(this.objectsPanelLabel);
            this.objectsPanelCaption.Dock = System.Windows.Forms.DockStyle.Top;
            this.objectsPanelCaption.Location = new System.Drawing.Point(0, 0);
            this.objectsPanelCaption.Name = "objectsPanelCaption";
            this.objectsPanelCaption.Size = new System.Drawing.Size(217, 23);
            this.objectsPanelCaption.TabIndex = 2;
            this.objectsPanelCaption.Click += new System.EventHandler(this.toolWindowClick);
            // 
            // objectsPanelLabel
            // 
            this.objectsPanelLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.objectsPanelLabel.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.objectsPanelLabel.Location = new System.Drawing.Point(9, 4);
            this.objectsPanelLabel.Margin = new System.Windows.Forms.Padding(0);
            this.objectsPanelLabel.Name = "objectsPanelLabel";
            this.objectsPanelLabel.Size = new System.Drawing.Size(85, 15);
            this.objectsPanelLabel.TabIndex = 1;
            this.objectsPanelLabel.Text = "Objects";
            // 
            // toolboxPanel
            // 
            this.toolboxPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolboxPanel.Location = new System.Drawing.Point(0, 0);
            this.toolboxPanel.Name = "toolboxPanel";
            this.toolboxPanel.Size = new System.Drawing.Size(217, 497);
            this.toolboxPanel.TabIndex = 3;
            this.toolboxPanel.Click += new System.EventHandler(this.toolWindowClick);
            // 
            // centerContainer
            // 
            this.centerContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.centerContainer.Location = new System.Drawing.Point(0, 0);
            this.centerContainer.Name = "centerContainer";
            this.centerContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // centerContainer.Panel1
            // 
            this.centerContainer.Panel1.Controls.Add(this.documentsTabControl);
            // 
            // centerContainer.Panel2
            // 
            this.centerContainer.Panel2.Controls.Add(this.systemTabControl);
            this.centerContainer.Size = new System.Drawing.Size(437, 497);
            this.centerContainer.SplitterDistance = 398;
            this.centerContainer.TabIndex = 0;
            // 
            // documentsTabControl
            // 
            this.documentsTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.documentsTabControl.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.documentsTabControl.HotTrack = true;
            this.documentsTabControl.Location = new System.Drawing.Point(0, 0);
            this.documentsTabControl.Name = "documentsTabControl";
            this.documentsTabControl.SelectedIndex = 0;
            this.documentsTabControl.ShowToolTips = true;
            this.documentsTabControl.Size = new System.Drawing.Size(437, 398);
            this.documentsTabControl.TabIndex = 0;
            this.documentsTabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.documentsTabControl_Selected);
            // 
            // systemTabControl
            // 
            this.systemTabControl.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.systemTabControl.Controls.Add(this.errorsTabPage);
            this.systemTabControl.Controls.Add(this.outputTabPage);
            this.systemTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.systemTabControl.HotTrack = true;
            this.systemTabControl.Location = new System.Drawing.Point(0, 0);
            this.systemTabControl.Name = "systemTabControl";
            this.systemTabControl.SelectedIndex = 0;
            this.systemTabControl.Size = new System.Drawing.Size(437, 95);
            this.systemTabControl.TabIndex = 0;
            // 
            // errorsTabPage
            // 
            this.errorsTabPage.Location = new System.Drawing.Point(4, 4);
            this.errorsTabPage.Name = "errorsTabPage";
            this.errorsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.errorsTabPage.Size = new System.Drawing.Size(429, 69);
            this.errorsTabPage.TabIndex = 1;
            this.errorsTabPage.Text = "Error List";
            this.errorsTabPage.UseVisualStyleBackColor = true;
            // 
            // outputTabPage
            // 
            this.outputTabPage.Location = new System.Drawing.Point(4, 4);
            this.outputTabPage.Name = "outputTabPage";
            this.outputTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.outputTabPage.Size = new System.Drawing.Size(429, 69);
            this.outputTabPage.TabIndex = 2;
            this.outputTabPage.Text = "Output";
            this.outputTabPage.UseVisualStyleBackColor = true;
            // 
            // rightContainer
            // 
            this.rightContainer.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.rightContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightContainer.Location = new System.Drawing.Point(0, 0);
            this.rightContainer.Name = "rightContainer";
            this.rightContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // rightContainer.Panel1
            // 
            this.rightContainer.Panel1.Controls.Add(this.explorerPanel);
            this.rightContainer.Panel1.Controls.Add(this.explorerPanelCaption);
            this.rightContainer.Panel1.Click += new System.EventHandler(this.toolWindowClick);
            // 
            // rightContainer.Panel2
            // 
            this.rightContainer.Panel2.Controls.Add(this.panel3);
            this.rightContainer.Panel2.Controls.Add(this.propertiesPanelToolbox);
            this.rightContainer.Panel2.Controls.Add(this.propertiesPanelCaption);
            this.rightContainer.Panel2.Click += new System.EventHandler(this.toolWindowClick);
            this.rightContainer.Size = new System.Drawing.Size(271, 497);
            this.rightContainer.SplitterDistance = 321;
            this.rightContainer.TabIndex = 9;
            // 
            // explorerPanel
            // 
            this.explorerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.explorerPanel.Location = new System.Drawing.Point(0, 23);
            this.explorerPanel.Name = "explorerPanel";
            this.explorerPanel.Size = new System.Drawing.Size(271, 298);
            this.explorerPanel.TabIndex = 2;
            this.explorerPanel.Click += new System.EventHandler(this.toolWindowClick);
            // 
            // explorerPanelCaption
            // 
            this.explorerPanelCaption.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.explorerPanelCaption.Controls.Add(this.explorerPanelLabel);
            this.explorerPanelCaption.Dock = System.Windows.Forms.DockStyle.Top;
            this.explorerPanelCaption.Location = new System.Drawing.Point(0, 0);
            this.explorerPanelCaption.Name = "explorerPanelCaption";
            this.explorerPanelCaption.Size = new System.Drawing.Size(271, 23);
            this.explorerPanelCaption.TabIndex = 1;
            this.explorerPanelCaption.Click += new System.EventHandler(this.toolWindowClick);
            // 
            // explorerPanelLabel
            // 
            this.explorerPanelLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.explorerPanelLabel.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.explorerPanelLabel.Location = new System.Drawing.Point(3, 4);
            this.explorerPanelLabel.Margin = new System.Windows.Forms.Padding(0);
            this.explorerPanelLabel.Name = "explorerPanelLabel";
            this.explorerPanelLabel.Size = new System.Drawing.Size(85, 15);
            this.explorerPanelLabel.TabIndex = 0;
            this.explorerPanelLabel.Text = "Solution explorer";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tabControlProperties);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 45);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(271, 127);
            this.panel3.TabIndex = 5;
            // 
            // tabControlProperties
            // 
            this.tabControlProperties.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlProperties.Controls.Add(this.tabPagePropertiesAll);
            this.tabControlProperties.Controls.Add(this.tabPagePropertiesAssigned);
            this.tabControlProperties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlProperties.Location = new System.Drawing.Point(0, 0);
            this.tabControlProperties.Margin = new System.Windows.Forms.Padding(1);
            this.tabControlProperties.Name = "tabControlProperties";
            this.tabControlProperties.Padding = new System.Drawing.Point(2, 1);
            this.tabControlProperties.SelectedIndex = 0;
            this.tabControlProperties.Size = new System.Drawing.Size(271, 127);
            this.tabControlProperties.TabIndex = 3;
            this.tabControlProperties.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControlProperties_Selected);
            // 
            // tabPagePropertiesAll
            // 
            this.tabPagePropertiesAll.BackColor = System.Drawing.SystemColors.Window;
            this.tabPagePropertiesAll.Controls.Add(this.tableLayoutProperties);
            this.tabPagePropertiesAll.Location = new System.Drawing.Point(4, 4);
            this.tabPagePropertiesAll.Name = "tabPagePropertiesAll";
            this.tabPagePropertiesAll.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePropertiesAll.Size = new System.Drawing.Size(263, 103);
            this.tabPagePropertiesAll.TabIndex = 0;
            this.tabPagePropertiesAll.Text = "All";
            // 
            // tableLayoutProperties
            // 
            this.tableLayoutProperties.AutoScroll = true;
            this.tableLayoutProperties.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutProperties.ColumnCount = 2;
            this.tableLayoutProperties.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutProperties.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutProperties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutProperties.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutProperties.Name = "tableLayoutProperties";
            this.tableLayoutProperties.RowCount = 1;
            this.tableLayoutProperties.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutProperties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutProperties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutProperties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutProperties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutProperties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutProperties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutProperties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutProperties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutProperties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutProperties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutProperties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutProperties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutProperties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutProperties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutProperties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutProperties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutProperties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutProperties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutProperties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutProperties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutProperties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutProperties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutProperties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutProperties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutProperties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutProperties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutProperties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutProperties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutProperties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutProperties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutProperties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutProperties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutProperties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutProperties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutProperties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutProperties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutProperties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutProperties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutProperties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutProperties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutProperties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutProperties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutProperties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutProperties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutProperties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutProperties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutProperties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutProperties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutProperties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutProperties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutProperties.Size = new System.Drawing.Size(257, 97);
            this.tableLayoutProperties.TabIndex = 0;
            // 
            // tabPagePropertiesAssigned
            // 
            this.tabPagePropertiesAssigned.BackColor = System.Drawing.SystemColors.Window;
            this.tabPagePropertiesAssigned.Location = new System.Drawing.Point(4, 4);
            this.tabPagePropertiesAssigned.Name = "tabPagePropertiesAssigned";
            this.tabPagePropertiesAssigned.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePropertiesAssigned.Size = new System.Drawing.Size(263, 103);
            this.tabPagePropertiesAssigned.TabIndex = 1;
            this.tabPagePropertiesAssigned.Text = "Assigned";
            // 
            // propertiesPanelToolbox
            // 
            this.propertiesPanelToolbox.Dock = System.Windows.Forms.DockStyle.Top;
            this.propertiesPanelToolbox.Location = new System.Drawing.Point(0, 23);
            this.propertiesPanelToolbox.Name = "propertiesPanelToolbox";
            this.propertiesPanelToolbox.Size = new System.Drawing.Size(271, 22);
            this.propertiesPanelToolbox.TabIndex = 4;
            // 
            // propertiesPanelCaption
            // 
            this.propertiesPanelCaption.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.propertiesPanelCaption.Controls.Add(this.propertiesPanelLabel);
            this.propertiesPanelCaption.Dock = System.Windows.Forms.DockStyle.Top;
            this.propertiesPanelCaption.Location = new System.Drawing.Point(0, 0);
            this.propertiesPanelCaption.Name = "propertiesPanelCaption";
            this.propertiesPanelCaption.Size = new System.Drawing.Size(271, 23);
            this.propertiesPanelCaption.TabIndex = 1;
            this.propertiesPanelCaption.Click += new System.EventHandler(this.toolWindowClick);
            // 
            // propertiesPanelLabel
            // 
            this.propertiesPanelLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.propertiesPanelLabel.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.propertiesPanelLabel.Location = new System.Drawing.Point(3, 4);
            this.propertiesPanelLabel.Margin = new System.Windows.Forms.Padding(0);
            this.propertiesPanelLabel.Name = "propertiesPanelLabel";
            this.propertiesPanelLabel.Size = new System.Drawing.Size(85, 15);
            this.propertiesPanelLabel.TabIndex = 1;
            this.propertiesPanelLabel.Text = "Properties";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.optionsToolStripMenuItem.Text = "Options...";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 543);
            this.Controls.Add(this.mainContainer);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainWindow";
            this.Text = "Xamler";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.mainContainer.Panel1.ResumeLayout(false);
            this.mainContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainContainer)).EndInit();
            this.mainContainer.ResumeLayout(false);
            this.leftContainer.Panel1.ResumeLayout(false);
            this.leftContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.leftContainer)).EndInit();
            this.leftContainer.ResumeLayout(false);
            this.leftInnerContainer.Panel1.ResumeLayout(false);
            this.leftInnerContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.leftInnerContainer)).EndInit();
            this.leftInnerContainer.ResumeLayout(false);
            this.toolboxPanelCaption.ResumeLayout(false);
            this.objectsPanel.ResumeLayout(false);
            this.objectsPanelCaption.ResumeLayout(false);
            this.centerContainer.Panel1.ResumeLayout(false);
            this.centerContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.centerContainer)).EndInit();
            this.centerContainer.ResumeLayout(false);
            this.systemTabControl.ResumeLayout(false);
            this.rightContainer.Panel1.ResumeLayout(false);
            this.rightContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rightContainer)).EndInit();
            this.rightContainer.ResumeLayout(false);
            this.explorerPanelCaption.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tabControlProperties.ResumeLayout(false);
            this.tabPagePropertiesAll.ResumeLayout(false);
            this.propertiesPanelCaption.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel toolBoxContainer;
        private System.Windows.Forms.Panel structureContainer;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.SplitContainer mainContainer;
        private System.Windows.Forms.SplitContainer leftContainer;
        private System.Windows.Forms.SplitContainer leftInnerContainer;
        private System.Windows.Forms.SplitContainer rightContainer;
        private System.Windows.Forms.Panel explorerPanelCaption;
        private System.Windows.Forms.Label explorerPanelLabel;
        private System.Windows.Forms.Panel propertiesPanelCaption;
        private System.Windows.Forms.Label propertiesPanelLabel;
        private System.Windows.Forms.SplitContainer centerContainer;
        private System.Windows.Forms.TabControl systemTabControl;
        private System.Windows.Forms.TabPage errorsTabPage;
        private System.Windows.Forms.TabControl documentsTabControl;
        private System.Windows.Forms.Panel explorerPanel;
        private System.Windows.Forms.Panel toolboxPanel;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutXamlerToolStripMenuItem;
        private System.Windows.Forms.Panel toolboxPanelCaption;
        private System.Windows.Forms.Label toolboxPanelLabel;
        private System.Windows.Forms.Panel objectsPanelCaption;
        private System.Windows.Forms.Label objectsPanelLabel;
        private System.Windows.Forms.Panel objectsPanel;
        private System.Windows.Forms.TreeView objectsTreeView;
        private System.Windows.Forms.ListBox toolBoxListBox;
        private System.Windows.Forms.TabPage outputTabPage;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TabControl tabControlProperties;
        private System.Windows.Forms.TabPage tabPagePropertiesAll;
        private System.Windows.Forms.TableLayoutPanel tableLayoutProperties;
        private System.Windows.Forms.TabPage tabPagePropertiesAssigned;
        private System.Windows.Forms.Panel propertiesPanelToolbox;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
    }
}

