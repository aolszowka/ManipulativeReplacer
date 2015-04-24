// -----------------------------------------------------------------------
// <copyright file="MainForm.cs" company="Ace Olszowka">
// Copyright (c) Ace Olszowka 2014-2015. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace ManipulativeReplacer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Drawing;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using ManipulativeReplacer.Properties;

    /// <summary>
    /// A simple application to generate output that conforms to a given pattern.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// A private store for available patterns.
        /// </summary>
        private BindingList<Pattern> avaliablePatterns = new BindingList<Pattern>();

        public MainForm()
        {
            InitializeComponent();

            // Set our default font (Consolas)
            this.fontDialog.Font =
                new Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetTextBoxFont(this.fontDialog.Font);

            // Bind the Advanced Pattern Saver
            this.comboBoxInputPatternSaver.ComboBox.DataSource = this.avaliablePatterns;
            this.comboBoxInputPatternSaver.ComboBox.DisplayMember = "Name";
            this.comboBoxInputPatternSaver.ComboBox.ValueMember = "Value";

            // Bind the Additional Program Settings
            BindProgramSettings();
        }

        /// <summary>
        /// EventHander for when the Input TextBoxes Change.
        /// </summary>
        /// <param name="sender">The object that invoked this event.</param>
        /// <param name="e">The arguments to this event.</param>
        private async void OnInputsChanged(object sender, EventArgs e)
        {
            mainWindowStatusLabel.Text = "Processing...";
            outputTextBox.Text = "Processing...";

            // Because the processing is performed on a background thread
            // we must make a copy of the inputs, otherwise we'll run into
            // threading issues because we're using a RichTextBox control.
            string pattern = patternInputTextBox.Text;
            string input = replacementInputTextBox.Text;
            bool singleLineOutput = outputPanelSingleLineToolStripMenuItem.Checked;

            string processedReplacement = await Task.Run(() => _PerformReplacement(pattern, input, singleLineOutput));

            // Alert the user all is not well if the length is too long
            if (processedReplacement.Length > outputTextBox.MaxLength)
            {
                mainWindowStatusLabel.Text = "WARNING: Output Exceeds Max Length, Results Are Truncated!!";
                mainWindowStatusLabel.ForeColor = Color.Red;
            }
            else
            {
                mainWindowStatusLabel.Text = "Ready";
                mainWindowStatusLabel.ForeColor = Color.Black;
            }

            // Set our text
            outputTextBox.Text = processedReplacement;
        }

        /// <summary>
        /// EventHandler for when a Key is pressed down.
        /// </summary>
        /// <param name="sender">The object that invoked the ProcessHotkeys EventHandler.</param>
        /// <param name="e">The KeyEventArgs from that control.</param>
        private void ProcessHotkeys(object sender, KeyEventArgs e)
        {
            // Select All
            if (e.Control && e.KeyCode == Keys.A)
            {
                // Check to see if we were in a textbox control
                TextBoxBase textBoxControl = sender as TextBoxBase;
                if (textBoxControl != null)
                {
                    textBoxControl.SelectAll();
                }
            }
        }

        #region Business Logic

        /// <summary>
        /// Performs the Replacement of all {EXT} values in the input string with the replacements.
        /// </summary>
        /// <param name="inputPattern">The pattern that will be duplicated.</param>
        /// <param name="inputReplacement">The replacement string; separated by NewLine characters (Either \n or \r\n).</param>
        /// <param name="singleLine">Specifies whether or not the return value should be returned as a single line or not.</param>
        /// <returns>A string that has all of the replacements performed.</returns>
        /// <remarks>
        ///     The Input Pattern is repeated for every replacement string from
        /// the Replacement Pattern which is separated by a NewLine character.
        /// </remarks>
        private static string _PerformReplacement(string inputPattern, string inputReplacement, bool singleLine)
        {
            StringBuilder sb = new StringBuilder();
            IEnumerable<string> replacedValues = _PerformReplacement(inputPattern, inputReplacement);

            foreach (string replacedValue in replacedValues)
            {
                if (singleLine)
                {
                    sb.Append(replacedValue);
                }
                else
                {
                    sb.AppendLine(replacedValue);
                }
            }

            return sb.ToString();
        }

        /// <summary>
        /// Performs the Replacement of all {EXT} values in the input string with the replacements.
        /// </summary>
        /// <param name="inputPattern">The pattern that will be duplicated.</param>
        /// <param name="inputReplacement">The replacement string; separated by NewLine characters (Either \n or \r\n).</param>
        /// <returns>An Enumerable that contains each of the replacements.</returns>
        /// <remarks>
        ///     This method is implemented by using deferred execution. The
        /// immediate return value is an object that stores all the information
        /// that is required to perform the action. The query represented by
        /// this method is not executed until the object is enumerated either
        /// by calling its <c>GetEnumerator</c> method directly or by using
        /// <c>foreach</c> in Visual C# or <c>For Each</c> in Visual Basic.
        /// </remarks>
        private static IEnumerable<string> _PerformReplacement(string inputPattern, string inputReplacement)
        {
            // Split the input string on the new line character
            var replacementEntries =
                inputReplacement.Split(new string[] { Environment.NewLine, "\n" }, StringSplitOptions.RemoveEmptyEntries);

            // Perform the replacement
            foreach (string replacementEntry in replacementEntries)
            {
                yield return inputPattern.Replace("{EXT}", replacementEntry);
            }
        }

        #endregion

        #region Font Control

        /// <summary>
        /// Method to reset all of the fonts
        /// </summary>
        /// <param name="font">The font to set the text boxes to</param>
        private void SetTextBoxFont(Font font)
        {
            this.patternInputTextBox.Font = font;
            this.replacementInputTextBox.Font = font;
            this.outputTextBox.Font = font;
        }

        /// <summary>
        /// EventHandler for when the FontDialog Apply Button is pressed.
        /// </summary>
        /// <param name="sender">The object that invoked this EventHandler.</param>
        /// <param name="e">The arguments to the EventHandler.</param>
        private void fontDialog_Apply(object sender, EventArgs e)
        {
            this.SetTextBoxFont(this.fontDialog.Font);
        }

        #endregion

        #region Toolbar Actions

        /// <summary>
        /// EventHandler for when the 'Change Font' dialog is selected.
        /// </summary>
        /// <param name="sender">The object that invoked this EventHandler.</param>
        /// <param name="e">The arguments to the EventHandler.</param>
        private void changeFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Save off the previous font
            Font previousFontValue = this.fontDialog.Font;

            if (this.fontDialog.ShowDialog() == DialogResult.Cancel)
            {
                this.fontDialog.Font = previousFontValue;
            }

            this.SetTextBoxFont(this.fontDialog.Font);
        }

        /// <summary>
        /// Closes the Form
        /// </summary>
        /// <param name="sender">The object that sent this command.</param>
        /// <param name="e">The arguments to this event.</param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Save the Result of the Replace to a File.
        /// </summary>
        /// <param name="sender">The object that sent this command.</param>
        /// <param name="e">The arguments to this event.</param>
        /// <remarks>
        ///     This is unique in the fact that instead of saving the contents
        /// of the TextBox the file should be reprocessed (or the original
        /// results saved) so that the result is not truncated.
        /// </remarks>
        private void saveOutputToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not Supported At This Time");
        }

        /// <summary>
        /// EventHandler for when the 'Word Wrap' option is clicked on the Pattern Panel Menu.
        /// </summary>
        /// <param name="sender">The object that sent this command.</param>
        /// <param name="e">The arguments to this event.</param>
        private void patternPanelWordWrapToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.PatternPanelWordWrap = ((ToolStripMenuItem)sender).Checked;
        }

        /// <summary>
        /// EventHandler for when the 'Word Wrap' option is clicked on the Input Panel Menu.
        /// </summary>
        /// <param name="sender">The object that sent this command.</param>
        /// <param name="e">The arguments to this event.</param>
        private void inputPanelWordWrapToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.InputPanelWordWrap = ((ToolStripMenuItem)sender).Checked;
        }

        /// <summary>
        /// EventHandler for when the 'Word Wrap' option is clicked on the Output Panel Menu.
        /// </summary>
        /// <param name="sender">The object that sent this command.</param>
        /// <param name="e">The arguments to this event.</param>
        private void outputPanelWordWrapToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.OutputPanelWordWrap = ((ToolStripMenuItem)sender).Checked;
        }

        /// <summary>
        /// EventHandler for when the 'Single Line' option is clicked on the Output Panel Menu.
        /// </summary>
        /// <param name="sender">The object that sent this command.</param>
        /// <param name="e">The arguments to this event.</param>
        private void outputPanelSingleLineToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.OutputPanelSingleLine = ((ToolStripMenuItem)sender).Checked;
            this.OnInputsChanged(sender, e);
        }

        /// <summary>
        /// EventHandler for when the 'About' option is selected from the main toolbar.
        /// </summary>
        /// <param name="sender">The object that sent this command.</param>
        /// <param name="e">The arguments to this event.</param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (AboutManipulativeReplacerBox box = new AboutManipulativeReplacerBox())
            {
                box.ShowDialog(this);
            }
        }

        /// <summary>
        /// EventHandler for when the 'Save Settings' option is selected from the main toolbar.
        /// </summary>
        /// <param name="sender">The object that sent this command.</param>
        /// <param name="e">The arguments to this event.</param>
        private void saveSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings.Default.Save();
        }

        /// <summary>
        /// Resets all of the program settings back to their default value.
        /// </summary>
        /// <param name="sender">The object that sent this command.</param>
        /// <param name="e">The arguments to this event.</param>
        private void resetSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings.Default.Reset();
        }

        #endregion

        #region Input Pattern Saver

        /// <summary>
        /// EventHandler for when the Input Pattern Saver Delete Button is clicked.
        /// </summary>
        /// <param name="sender">The object that invoked this event.</param>
        /// <param name="e">The arguments to this event.</param>
        private void inputPanelDeleteButton_Click(object sender, EventArgs e)
        {
            this.avaliablePatterns.RemoveAt(this.comboBoxInputPatternSaver.ComboBox.SelectedIndex);
        }

        /// <summary>
        /// EventHandler for when the Input Pattern Save Button is clicked.
        /// </summary>
        /// <param name="sender">The object that invoked this event.</param>
        /// <param name="e">The arguments to this event.</param>
        private void inputPatternSaveButton_Click(object sender, EventArgs e)
        {
            string patternName = this.comboBoxInputPatternSaver.ComboBox.Text;
            string patternValue = this.patternInputTextBox.Text;

            // Save the Pattern
            Pattern newPattern = new Pattern(patternName, patternValue);
            this.avaliablePatterns.Add(newPattern);
            this.comboBoxInputPatternSaver.ComboBox.SelectedIndex =
                this.avaliablePatterns.IndexOf(newPattern);
        }

        /// <summary>
        /// EventHandler for when the Input Pattern Saver Comobox is changed.
        /// </summary>
        /// <param name="sender">The object that invoked this event.</param>
        /// <param name="e">The arguments to this event.</param>
        private void comboBoxInputPatternSaver_SelectedIndexChanged(object sender, EventArgs e)
        {
            Pattern selectedPattern =
                this.avaliablePatterns[this.comboBoxInputPatternSaver.ComboBox.SelectedIndex];
            this.patternInputTextBox.Text = selectedPattern.Value;
        }

        #endregion

        #region Program Settings Saver

        /// <summary>
        ///     Binds various program settings to the settings file, so that
        /// changes can be persisted from different executions of this program.
        /// </summary>
        private void BindProgramSettings()
        {
            this.patternPanelWordWrapToolStripMenuItem.DataBindings.Add("Checked", Settings.Default, "PatternPanelWordWrap");
            this.patternInputTextBox.DataBindings.Add("WordWrap", Settings.Default, "PatternPanelWordWrap");

            this.inputPanelWordWrapToolStripMenuItem.DataBindings.Add("Checked", Settings.Default, "InputPanelWordWrap");
            this.replacementInputTextBox.DataBindings.Add("WordWrap", Settings.Default, "InputPanelWordWrap");

            this.outputPanelWordWrapToolStripMenuItem.DataBindings.Add("Checked", Settings.Default, "OutputPanelWordWrap");
            this.outputTextBox.DataBindings.Add("WordWrap", Settings.Default, "OutputPanelWordWrap");

            this.outputPanelSingleLineToolStripMenuItem.DataBindings.Add("Checked", Settings.Default, "OutputPanelSingleLine");
        }

        #endregion

    }
}
