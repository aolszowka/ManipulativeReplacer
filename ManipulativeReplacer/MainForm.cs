﻿// -----------------------------------------------------------------------
// <copyright file="MainForm.cs" company="Computers Unlimited">
// Copyright (c) Computers Unlimited 2014. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace ManipulativeReplacer
{
    using System;
    using System.Drawing;
    using System.Text;
    using System.Threading.Tasks;

    using System.Windows.Forms;
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            // Set our default font (Consolas)
            this.fontDialog.Font =
                new Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetTextBoxFont(this.fontDialog.Font);
        }

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
        /// EventHander for when the Input TextBoxes Change.
        /// </summary>
        /// <param name="sender">The object that invoked this event.</param>
        /// <param name="e">The arguments to this event.</param>
        private async void OnInputsChanged(object sender, EventArgs e)
        {
            outputTextBox.Text = "Processing...";
            outputTextBox.Text = await Task.Run(() => _PerformReplacement(patternInputTextBox.Text, replacementInputTextBox.Text));
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
                TextBox textBoxControl = sender as TextBox;
                if (textBoxControl != null)
                {
                    textBoxControl.SelectAll();
                }
            }
        }

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
        /// EventHandler for when the FontDialog Apply Button is pressed.
        /// </summary>
        /// <param name="sender">The object that invoked this EventHandler.</param>
        /// <param name="e">The arguments to the EventHandler.</param>
        private void fontDialog_Apply(object sender, EventArgs e)
        {
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
        /// Performs the Replacement of all {EXT} values in the input string with the replacements.
        /// </summary>
        /// <param name="inputPattern">The pattern that will be duplicated.</param>
        /// <param name="inputReplacement">The replacement string; separated by NewLine characters.</param>
        /// <returns>A string that has all of the replacements performed.</returns>
        /// <remarks>
        ///     The Input Pattern is repeated for every replacement string from
        /// the Replacement Pattern which is separated by a NewLine character.
        /// </remarks>
        private static string _PerformReplacement(string inputPattern, string inputReplacement)
        {
            StringBuilder sb = new StringBuilder();

            // Split the input string on the new line character
            var replacementEntries =
                inputReplacement.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            // Perform the replacement
            foreach (string replacementEntry in replacementEntries)
            {
                sb.AppendLine(inputPattern.Replace("{EXT}", replacementEntry));
            }

            return sb.ToString();
        }

    }
}
