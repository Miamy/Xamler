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
            this.codeTopPanel = new System.Windows.Forms.Panel();
            this.codeStatusStrip = new System.Windows.Forms.StatusStrip();
            this.previewBox = new System.Windows.Forms.PictureBox();
            this.previewStatusStrip = new System.Windows.Forms.StatusStrip();
            this.toolsPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.codeEditor = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).BeginInit();
            this.mainSplitContainer.Panel1.SuspendLayout();
            this.mainSplitContainer.Panel2.SuspendLayout();
            this.mainSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.previewBox)).BeginInit();
            this.toolsPanel.SuspendLayout();
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
            this.mainSplitContainer.Panel1.Controls.Add(this.codeEditor);
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
            // codeTopPanel
            // 
            this.codeTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.codeTopPanel.Location = new System.Drawing.Point(0, 0);
            this.codeTopPanel.Name = "codeTopPanel";
            this.codeTopPanel.Size = new System.Drawing.Size(371, 26);
            this.codeTopPanel.TabIndex = 0;
            // 
            // codeStatusStrip
            // 
            this.codeStatusStrip.Location = new System.Drawing.Point(0, 430);
            this.codeStatusStrip.Name = "codeStatusStrip";
            this.codeStatusStrip.Size = new System.Drawing.Size(371, 22);
            this.codeStatusStrip.TabIndex = 1;
            this.codeStatusStrip.Text = "statusStrip1";
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
            // previewStatusStrip
            // 
            this.previewStatusStrip.Location = new System.Drawing.Point(0, 430);
            this.previewStatusStrip.Name = "previewStatusStrip";
            this.previewStatusStrip.Size = new System.Drawing.Size(333, 22);
            this.previewStatusStrip.TabIndex = 2;
            this.previewStatusStrip.Text = "statusStrip1";
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
            // codeEditor
            // 
            this.codeEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.codeEditor.Location = new System.Drawing.Point(0, 26);
            this.codeEditor.Multiline = true;
            this.codeEditor.Name = "codeEditor";
            this.codeEditor.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.codeEditor.Size = new System.Drawing.Size(371, 404);
            this.codeEditor.TabIndex = 2;
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
            ((System.ComponentModel.ISupportInitialize)(this.previewBox)).EndInit();
            this.toolsPanel.ResumeLayout(false);
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
        private System.Windows.Forms.TextBox codeEditor;
    }
}
