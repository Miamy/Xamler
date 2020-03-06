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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.structureContainer = new System.Windows.Forms.Panel();
            this.toolBoxContainer = new System.Windows.Forms.Panel();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.mainContainer = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.leftContainer = new System.Windows.Forms.SplitContainer();
            this.toolboxPanel = new System.Windows.Forms.Panel();
            this.toolboxPanelCaption = new System.Windows.Forms.Panel();
            this.toolboxPanelLabel = new System.Windows.Forms.Label();
            this.objectsPanel = new System.Windows.Forms.Panel();
            this.objectsTreeView = new System.Windows.Forms.TreeView();
            this.objectsPanelCaption = new System.Windows.Forms.Panel();
            this.objectsPanelLabel = new System.Windows.Forms.Label();
            this.centerContainer = new System.Windows.Forms.SplitContainer();
            this.documentsTabControl = new System.Windows.Forms.TabControl();
            this.systemTabControl = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.rightContainer = new System.Windows.Forms.SplitContainer();
            this.explorerPanel = new System.Windows.Forms.Panel();
            this.explorerPanelCaption = new System.Windows.Forms.Panel();
            this.explorerPanelLabel = new System.Windows.Forms.Label();
            this.propertiesPanel = new System.Windows.Forms.Panel();
            this.propertiesPanelCaption = new System.Windows.Forms.Panel();
            this.propertiesPanelLabel = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutXamlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainContainer)).BeginInit();
            this.mainContainer.Panel1.SuspendLayout();
            this.mainContainer.Panel2.SuspendLayout();
            this.mainContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leftContainer)).BeginInit();
            this.leftContainer.Panel1.SuspendLayout();
            this.leftContainer.Panel2.SuspendLayout();
            this.leftContainer.SuspendLayout();
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
            this.propertiesPanelCaption.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
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
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
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
            this.statusStrip.Location = new System.Drawing.Point(0, 428);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(800, 22);
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
            this.mainContainer.Panel1.Controls.Add(this.splitContainer2);
            // 
            // mainContainer.Panel2
            // 
            this.mainContainer.Panel2.Controls.Add(this.rightContainer);
            this.mainContainer.Size = new System.Drawing.Size(800, 404);
            this.mainContainer.SplitterDistance = 565;
            this.mainContainer.TabIndex = 9;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.leftContainer);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.centerContainer);
            this.splitContainer2.Size = new System.Drawing.Size(565, 404);
            this.splitContainer2.SplitterDistance = 187;
            this.splitContainer2.TabIndex = 8;
            // 
            // leftContainer
            // 
            this.leftContainer.BackColor = System.Drawing.SystemColors.ControlDark;
            this.leftContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftContainer.Location = new System.Drawing.Point(0, 0);
            this.leftContainer.Name = "leftContainer";
            this.leftContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // leftContainer.Panel1
            // 
            this.leftContainer.Panel1.Controls.Add(this.toolboxPanel);
            this.leftContainer.Panel1.Controls.Add(this.toolboxPanelCaption);
            this.leftContainer.Panel1.Click += new System.EventHandler(this.toolWindowClick);
            // 
            // leftContainer.Panel2
            // 
            this.leftContainer.Panel2.Controls.Add(this.objectsPanel);
            this.leftContainer.Panel2.Controls.Add(this.objectsPanelCaption);
            this.leftContainer.Panel2.Click += new System.EventHandler(this.toolWindowClick);
            this.leftContainer.Size = new System.Drawing.Size(187, 404);
            this.leftContainer.SplitterDistance = 161;
            this.leftContainer.TabIndex = 4;
            // 
            // toolboxPanel
            // 
            this.toolboxPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolboxPanel.Location = new System.Drawing.Point(0, 23);
            this.toolboxPanel.Name = "toolboxPanel";
            this.toolboxPanel.Size = new System.Drawing.Size(187, 138);
            this.toolboxPanel.TabIndex = 3;
            // 
            // toolboxPanelCaption
            // 
            this.toolboxPanelCaption.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.toolboxPanelCaption.Controls.Add(this.toolboxPanelLabel);
            this.toolboxPanelCaption.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolboxPanelCaption.Location = new System.Drawing.Point(0, 0);
            this.toolboxPanelCaption.Name = "toolboxPanelCaption";
            this.toolboxPanelCaption.Size = new System.Drawing.Size(187, 23);
            this.toolboxPanelCaption.TabIndex = 0;
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
            this.objectsPanel.Size = new System.Drawing.Size(187, 216);
            this.objectsPanel.TabIndex = 3;
            // 
            // objectsTreeView
            // 
            this.objectsTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.objectsTreeView.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.objectsTreeView.Location = new System.Drawing.Point(0, 0);
            this.objectsTreeView.Name = "objectsTreeView";
            this.objectsTreeView.Size = new System.Drawing.Size(187, 216);
            this.objectsTreeView.TabIndex = 2;
            this.objectsTreeView.Click += new System.EventHandler(this.toolWindowClick);
            // 
            // objectsPanelCaption
            // 
            this.objectsPanelCaption.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.objectsPanelCaption.Controls.Add(this.objectsPanelLabel);
            this.objectsPanelCaption.Dock = System.Windows.Forms.DockStyle.Top;
            this.objectsPanelCaption.Location = new System.Drawing.Point(0, 0);
            this.objectsPanelCaption.Name = "objectsPanelCaption";
            this.objectsPanelCaption.Size = new System.Drawing.Size(187, 23);
            this.objectsPanelCaption.TabIndex = 1;
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
            this.centerContainer.Size = new System.Drawing.Size(374, 404);
            this.centerContainer.SplitterDistance = 324;
            this.centerContainer.TabIndex = 0;
            // 
            // documentsTabControl
            // 
            this.documentsTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.documentsTabControl.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.documentsTabControl.Location = new System.Drawing.Point(0, 0);
            this.documentsTabControl.Name = "documentsTabControl";
            this.documentsTabControl.SelectedIndex = 0;
            this.documentsTabControl.Size = new System.Drawing.Size(374, 324);
            this.documentsTabControl.TabIndex = 0;
            this.documentsTabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.documentsTabControl_Selected);
            // 
            // systemTabControl
            // 
            this.systemTabControl.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.systemTabControl.Controls.Add(this.tabPage2);
            this.systemTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.systemTabControl.HotTrack = true;
            this.systemTabControl.Location = new System.Drawing.Point(0, 0);
            this.systemTabControl.Name = "systemTabControl";
            this.systemTabControl.SelectedIndex = 0;
            this.systemTabControl.Size = new System.Drawing.Size(374, 76);
            this.systemTabControl.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(366, 50);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Error List";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            this.rightContainer.Panel2.Controls.Add(this.propertiesPanel);
            this.rightContainer.Panel2.Controls.Add(this.propertiesPanelCaption);
            this.rightContainer.Panel2.Click += new System.EventHandler(this.toolWindowClick);
            this.rightContainer.Size = new System.Drawing.Size(231, 404);
            this.rightContainer.SplitterDistance = 261;
            this.rightContainer.TabIndex = 9;
            // 
            // explorerPanel
            // 
            this.explorerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.explorerPanel.Location = new System.Drawing.Point(0, 23);
            this.explorerPanel.Name = "explorerPanel";
            this.explorerPanel.Size = new System.Drawing.Size(231, 238);
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
            this.explorerPanelCaption.Size = new System.Drawing.Size(231, 23);
            this.explorerPanelCaption.TabIndex = 1;
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
            // propertiesPanel
            // 
            this.propertiesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertiesPanel.Location = new System.Drawing.Point(0, 23);
            this.propertiesPanel.Name = "propertiesPanel";
            this.propertiesPanel.Size = new System.Drawing.Size(231, 116);
            this.propertiesPanel.TabIndex = 3;
            this.propertiesPanel.Click += new System.EventHandler(this.toolWindowClick);
            // 
            // propertiesPanelCaption
            // 
            this.propertiesPanelCaption.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.propertiesPanelCaption.Controls.Add(this.propertiesPanelLabel);
            this.propertiesPanelCaption.Dock = System.Windows.Forms.DockStyle.Top;
            this.propertiesPanelCaption.Location = new System.Drawing.Point(0, 0);
            this.propertiesPanelCaption.Name = "propertiesPanelCaption";
            this.propertiesPanelCaption.Size = new System.Drawing.Size(231, 23);
            this.propertiesPanelCaption.TabIndex = 1;
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
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutXamlerToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutXamlerToolStripMenuItem
            // 
            this.aboutXamlerToolStripMenuItem.Name = "aboutXamlerToolStripMenuItem";
            this.aboutXamlerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutXamlerToolStripMenuItem.Text = "About Xamler";
            this.aboutXamlerToolStripMenuItem.Click += new System.EventHandler(this.aboutXamlerToolStripMenuItem_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainContainer);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainWindow";
            this.Text = "Xamler";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.mainContainer.Panel1.ResumeLayout(false);
            this.mainContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainContainer)).EndInit();
            this.mainContainer.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.leftContainer.Panel1.ResumeLayout(false);
            this.leftContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.leftContainer)).EndInit();
            this.leftContainer.ResumeLayout(false);
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
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer leftContainer;
        private System.Windows.Forms.Panel toolboxPanelCaption;
        private System.Windows.Forms.Label toolboxPanelLabel;
        private System.Windows.Forms.Panel objectsPanelCaption;
        private System.Windows.Forms.Label objectsPanelLabel;
        private System.Windows.Forms.SplitContainer rightContainer;
        private System.Windows.Forms.Panel explorerPanelCaption;
        private System.Windows.Forms.Label explorerPanelLabel;
        private System.Windows.Forms.Panel propertiesPanelCaption;
        private System.Windows.Forms.Label propertiesPanelLabel;
        private System.Windows.Forms.SplitContainer centerContainer;
        private System.Windows.Forms.TabControl systemTabControl;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl documentsTabControl;
        private System.Windows.Forms.Panel explorerPanel;
        private System.Windows.Forms.Panel toolboxPanel;
        private System.Windows.Forms.Panel objectsPanel;
        private System.Windows.Forms.Panel propertiesPanel;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TreeView objectsTreeView;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutXamlerToolStripMenuItem;
    }
}

