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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.inputSplitContainer = new System.Windows.Forms.SplitContainer();
            this.panelInputPatternSubPanel = new System.Windows.Forms.TableLayoutPanel();
            this.patternInputTextBox = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.comboBoxInputPatternSaver = new System.Windows.Forms.ToolStripComboBox();
            this.inputPatternSaveButton = new System.Windows.Forms.ToolStripButton();
            this.inputPanelDeleteButton = new System.Windows.Forms.ToolStripButton();
            this.replacementInputTextBox = new System.Windows.Forms.TextBox();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveOutputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeFontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patternPanelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patternPanelWordWrapToolStripMenuItem = new ManipulativeReplacer.BindableToolStripMenuItem();
            this.inputPanelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inputPanelWordWrapToolStripMenuItem = new ManipulativeReplacer.BindableToolStripMenuItem();
            this.outputPanelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outputPanelWordWrapToolStripMenuItem = new ManipulativeReplacer.BindableToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.saveSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainWindowStatusStrip = new System.Windows.Forms.StatusStrip();
            this.mainWindowStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).BeginInit();
            this.mainSplitContainer.Panel1.SuspendLayout();
            this.mainSplitContainer.Panel2.SuspendLayout();
            this.mainSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputSplitContainer)).BeginInit();
            this.inputSplitContainer.Panel1.SuspendLayout();
            this.inputSplitContainer.Panel2.SuspendLayout();
            this.inputSplitContainer.SuspendLayout();
            this.panelInputPatternSubPanel.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.mainWindowStatusStrip.SuspendLayout();
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
            this.inputSplitContainer.Panel1.Controls.Add(this.panelInputPatternSubPanel);
            // 
            // inputSplitContainer.Panel2
            // 
            this.inputSplitContainer.Panel2.Controls.Add(this.replacementInputTextBox);
            this.inputSplitContainer.Size = new System.Drawing.Size(784, 218);
            this.inputSplitContainer.SplitterDistance = 392;
            this.inputSplitContainer.TabIndex = 0;
            this.inputSplitContainer.TabStop = false;
            // 
            // panelInputPatternSubPanel
            // 
            this.panelInputPatternSubPanel.AutoSize = true;
            this.panelInputPatternSubPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelInputPatternSubPanel.ColumnCount = 1;
            this.panelInputPatternSubPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.panelInputPatternSubPanel.Controls.Add(this.patternInputTextBox, 0, 1);
            this.panelInputPatternSubPanel.Controls.Add(this.toolStrip1, 0, 0);
            this.panelInputPatternSubPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInputPatternSubPanel.Location = new System.Drawing.Point(0, 0);
            this.panelInputPatternSubPanel.Margin = new System.Windows.Forms.Padding(0);
            this.panelInputPatternSubPanel.Name = "panelInputPatternSubPanel";
            this.panelInputPatternSubPanel.RowCount = 2;
            this.panelInputPatternSubPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelInputPatternSubPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelInputPatternSubPanel.Size = new System.Drawing.Size(392, 218);
            this.panelInputPatternSubPanel.TabIndex = 1;
            // 
            // patternInputTextBox
            // 
            this.patternInputTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.patternInputTextBox.Location = new System.Drawing.Point(3, 28);
            this.patternInputTextBox.Multiline = true;
            this.patternInputTextBox.Name = "patternInputTextBox";
            this.patternInputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.patternInputTextBox.Size = new System.Drawing.Size(392, 187);
            this.patternInputTextBox.TabIndex = 0;
            this.patternInputTextBox.WordWrap = false;
            this.patternInputTextBox.TextChanged += new System.EventHandler(this.OnInputsChanged);
            this.patternInputTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProcessHotkeys);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comboBoxInputPatternSaver,
            this.inputPatternSaveButton,
            this.inputPanelDeleteButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(398, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // comboBoxInputPatternSaver
            // 
            this.comboBoxInputPatternSaver.Name = "comboBoxInputPatternSaver";
            this.comboBoxInputPatternSaver.Size = new System.Drawing.Size(200, 25);
            this.comboBoxInputPatternSaver.SelectedIndexChanged += new System.EventHandler(this.comboBoxInputPatternSaver_SelectedIndexChanged);
            // 
            // inputPatternSaveButton
            // 
            this.inputPatternSaveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.inputPatternSaveButton.Image = ((System.Drawing.Image)(resources.GetObject("inputPatternSaveButton.Image")));
            this.inputPatternSaveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.inputPatternSaveButton.Name = "inputPatternSaveButton";
            this.inputPatternSaveButton.Size = new System.Drawing.Size(34, 22);
            this.inputPatternSaveButton.Text = "Save";
            this.inputPatternSaveButton.Click += new System.EventHandler(this.inputPatternSaveButton_Click);
            // 
            // inputPanelDeleteButton
            // 
            this.inputPanelDeleteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.inputPanelDeleteButton.Image = ((System.Drawing.Image)(resources.GetObject("inputPanelDeleteButton.Image")));
            this.inputPanelDeleteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.inputPanelDeleteButton.Name = "inputPanelDeleteButton";
            this.inputPanelDeleteButton.Size = new System.Drawing.Size(44, 22);
            this.inputPanelDeleteButton.Text = "Delete";
            this.inputPanelDeleteButton.Click += new System.EventHandler(this.inputPanelDeleteButton_Click);
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
            this.replacementInputTextBox.WordWrap = false;
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
            this.outputTextBox.WordWrap = false;
            this.outputTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProcessHotkeys);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveOutputToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveOutputToolStripMenuItem
            // 
            this.saveOutputToolStripMenuItem.Name = "saveOutputToolStripMenuItem";
            this.saveOutputToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.saveOutputToolStripMenuItem.Text = "Save Output";
            this.saveOutputToolStripMenuItem.Click += new System.EventHandler(this.saveOutputToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(135, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeFontToolStripMenuItem,
            this.patternPanelToolStripMenuItem,
            this.inputPanelToolStripMenuItem,
            this.outputPanelToolStripMenuItem,
            this.toolStripSeparator2,
            this.saveSettingsToolStripMenuItem,
            this.resetSettingsToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // changeFontToolStripMenuItem
            // 
            this.changeFontToolStripMenuItem.Name = "changeFontToolStripMenuItem";
            this.changeFontToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.changeFontToolStripMenuItem.Text = "Change Font (All)";
            this.changeFontToolStripMenuItem.Click += new System.EventHandler(this.changeFontToolStripMenuItem_Click);
            // 
            // patternPanelToolStripMenuItem
            // 
            this.patternPanelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.patternPanelWordWrapToolStripMenuItem});
            this.patternPanelToolStripMenuItem.Name = "patternPanelToolStripMenuItem";
            this.patternPanelToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.patternPanelToolStripMenuItem.Text = "Pattern Panel";
            // 
            // patternPanelWordWrapToolStripMenuItem
            // 
            this.patternPanelWordWrapToolStripMenuItem.CheckOnClick = true;
            this.patternPanelWordWrapToolStripMenuItem.Name = "patternPanelWordWrapToolStripMenuItem";
            this.patternPanelWordWrapToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.patternPanelWordWrapToolStripMenuItem.Text = "Word Wrap";
            this.patternPanelWordWrapToolStripMenuItem.CheckedChanged += new System.EventHandler(this.patternPanelWordWrapToolStripMenuItem_CheckedChanged);
            // 
            // inputPanelToolStripMenuItem
            // 
            this.inputPanelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inputPanelWordWrapToolStripMenuItem});
            this.inputPanelToolStripMenuItem.Name = "inputPanelToolStripMenuItem";
            this.inputPanelToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.inputPanelToolStripMenuItem.Text = "Input Panel";
            // 
            // inputPanelWordWrapToolStripMenuItem
            // 
            this.inputPanelWordWrapToolStripMenuItem.CheckOnClick = true;
            this.inputPanelWordWrapToolStripMenuItem.Name = "inputPanelWordWrapToolStripMenuItem";
            this.inputPanelWordWrapToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.inputPanelWordWrapToolStripMenuItem.Text = "Word Wrap";
            this.inputPanelWordWrapToolStripMenuItem.CheckedChanged += new System.EventHandler(this.inputPanelWordWrapToolStripMenuItem_CheckedChanged);
            // 
            // outputPanelToolStripMenuItem
            // 
            this.outputPanelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.outputPanelWordWrapToolStripMenuItem});
            this.outputPanelToolStripMenuItem.Name = "outputPanelToolStripMenuItem";
            this.outputPanelToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.outputPanelToolStripMenuItem.Text = "Output Panel";
            // 
            // outputPanelWordWrapToolStripMenuItem
            // 
            this.outputPanelWordWrapToolStripMenuItem.CheckOnClick = true;
            this.outputPanelWordWrapToolStripMenuItem.Name = "outputPanelWordWrapToolStripMenuItem";
            this.outputPanelWordWrapToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.outputPanelWordWrapToolStripMenuItem.Text = "Word Wrap";
            this.outputPanelWordWrapToolStripMenuItem.CheckedChanged += new System.EventHandler(this.outputPanelWordWrapToolStripMenuItem_CheckedChanged);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(160, 6);
            // 
            // saveSettingsToolStripMenuItem
            // 
            this.saveSettingsToolStripMenuItem.Name = "saveSettingsToolStripMenuItem";
            this.saveSettingsToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.saveSettingsToolStripMenuItem.Text = "Save Settings";
            this.saveSettingsToolStripMenuItem.Click += new System.EventHandler(this.saveSettingsToolStripMenuItem_Click);
            // 
            // resetSettingsToolStripMenuItem
            // 
            this.resetSettingsToolStripMenuItem.Name = "resetSettingsToolStripMenuItem";
            this.resetSettingsToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.resetSettingsToolStripMenuItem.Text = "Reset Settings";
            this.resetSettingsToolStripMenuItem.Click += new System.EventHandler(this.resetSettingsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // mainWindowStatusStrip
            // 
            this.mainWindowStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainWindowStatusLabel});
            this.mainWindowStatusStrip.Location = new System.Drawing.Point(0, 443);
            this.mainWindowStatusStrip.Name = "mainWindowStatusStrip";
            this.mainWindowStatusStrip.Size = new System.Drawing.Size(784, 22);
            this.mainWindowStatusStrip.TabIndex = 2;
            this.mainWindowStatusStrip.Text = "statusStrip1";
            // 
            // mainWindowStatusLabel
            // 
            this.mainWindowStatusLabel.Name = "mainWindowStatusLabel";
            this.mainWindowStatusLabel.Size = new System.Drawing.Size(38, 17);
            this.mainWindowStatusLabel.Text = "Ready";
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
            this.Controls.Add(this.mainWindowStatusStrip);
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
            this.panelInputPatternSubPanel.ResumeLayout(false);
            this.panelInputPatternSubPanel.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.mainWindowStatusStrip.ResumeLayout(false);
            this.mainWindowStatusStrip.PerformLayout();
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
        private System.Windows.Forms.StatusStrip mainWindowStatusStrip;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeFontToolStripMenuItem;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.ToolStripStatusLabel mainWindowStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem saveOutputToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem patternPanelToolStripMenuItem;
        private ManipulativeReplacer.BindableToolStripMenuItem patternPanelWordWrapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inputPanelToolStripMenuItem;
        private ManipulativeReplacer.BindableToolStripMenuItem inputPanelWordWrapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outputPanelToolStripMenuItem;
        private ManipulativeReplacer.BindableToolStripMenuItem outputPanelWordWrapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel panelInputPatternSubPanel;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripComboBox comboBoxInputPatternSaver;
        private System.Windows.Forms.ToolStripButton inputPatternSaveButton;
        private System.Windows.Forms.ToolStripButton inputPanelDeleteButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem saveSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetSettingsToolStripMenuItem;
    }
}

