namespace WinFormsApp.Controls
{
    partial class XamlDocumentEditor
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
            this.mainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.numbers = new System.Windows.Forms.TextBox();
            this.codeStatusStrip = new System.Windows.Forms.StatusStrip();
            this.codeTopPanel = new System.Windows.Forms.Panel();
            this.toolsPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.previewStatusStrip = new System.Windows.Forms.StatusStrip();
            this.previewBox = new System.Windows.Forms.PictureBox();
            this.codeEditor = new WinFormsApp.Controls.SyncTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).BeginInit();
            this.mainSplitContainer.Panel1.SuspendLayout();
            this.mainSplitContainer.Panel2.SuspendLayout();
            this.mainSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.previewBox)).BeginInit();
            this.SuspendLayout();
            // 
            // mainSplitContainer
            // 
            this.mainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.mainSplitContainer.Name = "mainSplitContainer";
            // 
            // mainSplitContainer.Panel1
            // 
            this.mainSplitContainer.Panel1.Controls.Add(this.splitContainer1);
            this.mainSplitContainer.Panel1.Controls.Add(this.codeStatusStrip);
            this.mainSplitContainer.Panel1.Controls.Add(this.codeTopPanel);
            // 
            // mainSplitContainer.Panel2
            // 
            this.mainSplitContainer.Panel2.Controls.Add(this.toolsPanel);
            this.mainSplitContainer.Panel2.Controls.Add(this.previewStatusStrip);
            this.mainSplitContainer.Panel2.Controls.Add(this.previewBox);
            this.mainSplitContainer.Size = new System.Drawing.Size(718, 452);
            this.mainSplitContainer.SplitterDistance = 371;
            this.mainSplitContainer.SplitterWidth = 14;
            this.mainSplitContainer.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 26);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.numbers);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.codeEditor);
            this.splitContainer1.Size = new System.Drawing.Size(371, 404);
            this.splitContainer1.SplitterDistance = 25;
            this.splitContainer1.TabIndex = 2;
            // 
            // numbers
            // 
            this.numbers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numbers.Location = new System.Drawing.Point(0, 0);
            this.numbers.Multiline = true;
            this.numbers.Name = "numbers";
            this.numbers.ReadOnly = true;
            this.numbers.Size = new System.Drawing.Size(25, 404);
            this.numbers.TabIndex = 6;
            this.numbers.WordWrap = false;
            // 
            // codeStatusStrip
            // 
            this.codeStatusStrip.Location = new System.Drawing.Point(0, 430);
            this.codeStatusStrip.Name = "codeStatusStrip";
            this.codeStatusStrip.Size = new System.Drawing.Size(371, 22);
            this.codeStatusStrip.TabIndex = 1;
            this.codeStatusStrip.Text = "statusStrip1";
            // 
            // codeTopPanel
            // 
            this.codeTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.codeTopPanel.Location = new System.Drawing.Point(0, 0);
            this.codeTopPanel.Name = "codeTopPanel";
            this.codeTopPanel.Size = new System.Drawing.Size(371, 26);
            this.codeTopPanel.TabIndex = 0;
            // 
            // toolsPanel
            // 
            this.toolsPanel.Controls.Add(this.button1);
            this.toolsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolsPanel.Location = new System.Drawing.Point(0, 0);
            this.toolsPanel.Name = "toolsPanel";
            this.toolsPanel.Size = new System.Drawing.Size(21, 430);
            this.toolsPanel.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 386);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(18, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // previewStatusStrip
            // 
            this.previewStatusStrip.Location = new System.Drawing.Point(0, 430);
            this.previewStatusStrip.Name = "previewStatusStrip";
            this.previewStatusStrip.Size = new System.Drawing.Size(333, 22);
            this.previewStatusStrip.TabIndex = 2;
            this.previewStatusStrip.Text = "statusStrip1";
            // 
            // previewBox
            // 
            this.previewBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.previewBox.Location = new System.Drawing.Point(0, 0);
            this.previewBox.Name = "previewBox";
            this.previewBox.Size = new System.Drawing.Size(333, 452);
            this.previewBox.TabIndex = 0;
            this.previewBox.TabStop = false;
            // 
            // codeEditor
            // 
            this.codeEditor.Buddy = null;
            this.codeEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.codeEditor.Location = new System.Drawing.Point(0, 0);
            this.codeEditor.Multiline = true;
            this.codeEditor.Name = "codeEditor";
            this.codeEditor.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.codeEditor.Size = new System.Drawing.Size(342, 404);
            this.codeEditor.TabIndex = 4;
            this.codeEditor.WordWrap = false;
            // 
            // XamlDocumentEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainSplitContainer);
            this.Name = "XamlDocumentEditor";
            this.Size = new System.Drawing.Size(718, 452);
            this.mainSplitContainer.Panel1.ResumeLayout(false);
            this.mainSplitContainer.Panel1.PerformLayout();
            this.mainSplitContainer.Panel2.ResumeLayout(false);
            this.mainSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).EndInit();
            this.mainSplitContainer.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.toolsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.previewBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer mainSplitContainer;
        private System.Windows.Forms.StatusStrip codeStatusStrip;
        private System.Windows.Forms.Panel codeTopPanel;
        private System.Windows.Forms.Panel toolsPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.StatusStrip previewStatusStrip;
        private System.Windows.Forms.PictureBox previewBox;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox numbers;
        private SyncTextBox codeEditor;
    }
}
