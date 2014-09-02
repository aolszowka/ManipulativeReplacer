namespace ManipulativeReplacer
{
    partial class MainForm
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
            this.mainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.inputSplitContainer = new System.Windows.Forms.SplitContainer();
            this.patternInputTextBox = new System.Windows.Forms.TextBox();
            this.replacementInputTextBox = new System.Windows.Forms.TextBox();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeFontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).BeginInit();
            this.mainSplitContainer.Panel1.SuspendLayout();
            this.mainSplitContainer.Panel2.SuspendLayout();
            this.mainSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputSplitContainer)).BeginInit();
            this.inputSplitContainer.Panel1.SuspendLayout();
            this.inputSplitContainer.Panel2.SuspendLayout();
            this.inputSplitContainer.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainSplitContainer
            // 
            this.mainSplitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainSplitContainer.Location = new System.Drawing.Point(0, 24);
            this.mainSplitContainer.Name = "mainSplitContainer";
            this.mainSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // mainSplitContainer.Panel1
            // 
            this.mainSplitContainer.Panel1.Controls.Add(this.inputSplitContainer);
            // 
            // mainSplitContainer.Panel2
            // 
            this.mainSplitContainer.Panel2.Controls.Add(this.outputTextBox);
            this.mainSplitContainer.Size = new System.Drawing.Size(784, 416);
            this.mainSplitContainer.SplitterDistance = 218;
            this.mainSplitContainer.TabIndex = 0;
            this.mainSplitContainer.TabStop = false;
            // 
            // inputSplitContainer
            // 
            this.inputSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.inputSplitContainer.Name = "inputSplitContainer";
            // 
            // inputSplitContainer.Panel1
            // 
            this.inputSplitContainer.Panel1.Controls.Add(this.patternInputTextBox);
            // 
            // inputSplitContainer.Panel2
            // 
            this.inputSplitContainer.Panel2.Controls.Add(this.replacementInputTextBox);
            this.inputSplitContainer.Size = new System.Drawing.Size(784, 218);
            this.inputSplitContainer.SplitterDistance = 392;
            this.inputSplitContainer.TabIndex = 0;
            this.inputSplitContainer.TabStop = false;
            // 
            // patternInputTextBox
            // 
            this.patternInputTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.patternInputTextBox.Location = new System.Drawing.Point(0, 0);
            this.patternInputTextBox.Multiline = true;
            this.patternInputTextBox.Name = "patternInputTextBox";
            this.patternInputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.patternInputTextBox.Size = new System.Drawing.Size(392, 218);
            this.patternInputTextBox.TabIndex = 0;
            this.patternInputTextBox.TextChanged += new System.EventHandler(this.OnInputsChanged);
            this.patternInputTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProcessHotkeys);
            // 
            // replacementInputTextBox
            // 
            this.replacementInputTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.replacementInputTextBox.Location = new System.Drawing.Point(0, 0);
            this.replacementInputTextBox.Multiline = true;
            this.replacementInputTextBox.Name = "replacementInputTextBox";
            this.replacementInputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.replacementInputTextBox.Size = new System.Drawing.Size(388, 218);
            this.replacementInputTextBox.TabIndex = 0;
            this.replacementInputTextBox.TextChanged += new System.EventHandler(this.OnInputsChanged);
            this.replacementInputTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProcessHotkeys);
            // 
            // outputTextBox
            // 
            this.outputTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputTextBox.Location = new System.Drawing.Point(0, 0);
            this.outputTextBox.Multiline = true;
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputTextBox.Size = new System.Drawing.Size(784, 194);
            this.outputTextBox.TabIndex = 0;
            this.outputTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProcessHotkeys);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeFontToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // changeFontToolStripMenuItem
            // 
            this.changeFontToolStripMenuItem.Name = "changeFontToolStripMenuItem";
            this.changeFontToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.changeFontToolStripMenuItem.Text = "Change Font";
            this.changeFontToolStripMenuItem.Click += new System.EventHandler(this.changeFontToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 443);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(784, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // fontDialog
            // 
            this.fontDialog.ShowApply = true;
            this.fontDialog.Apply += new System.EventHandler(this.fontDialog_Apply);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 465);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.mainSplitContainer);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Manipulative Replacer";
            this.mainSplitContainer.Panel1.ResumeLayout(false);
            this.mainSplitContainer.Panel2.ResumeLayout(false);
            this.mainSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).EndInit();
            this.mainSplitContainer.ResumeLayout(false);
            this.inputSplitContainer.Panel1.ResumeLayout(false);
            this.inputSplitContainer.Panel1.PerformLayout();
            this.inputSplitContainer.Panel2.ResumeLayout(false);
            this.inputSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputSplitContainer)).EndInit();
            this.inputSplitContainer.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer mainSplitContainer;
        private System.Windows.Forms.SplitContainer inputSplitContainer;
        private System.Windows.Forms.TextBox patternInputTextBox;
        private System.Windows.Forms.TextBox replacementInputTextBox;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeFontToolStripMenuItem;
        private System.Windows.Forms.FontDialog fontDialog;
    }
}

