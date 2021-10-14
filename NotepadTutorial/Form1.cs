using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotepadTutorial
{
    public partial class MainNotepadFrm : Form
    {
        public MainNotepadFrm() {
            InitializeComponent();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e) {
            //MainRichBox.Text = "";
            MainRichBox.Clear();
            ContextMenu.MenuItems.Add("-");
        }


        private void openToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Close();
            //Application.Exit();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e) {
            MessageBox.Show("All rights reserved by the author\nIvan Sur", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MainRichBox_TextChanged(object sender, EventArgs e) {
            if (MainRichBox.TextLength > 0) {
                undoToolStripMenuItem.Enabled = true;
                cutToolStripMenuItem.Enabled = true;
                copyToolStripMenuItem.Enabled = true;
                selectAllToolStripMenuItem.Enabled = true;
                boldToolStripMenuItem.Enabled = true;
                italicToolStripMenuItem.Enabled = true;
                underlineToolStripMenuItem.Enabled = true;
                strikeThroughToolStripMenuItem.Enabled = true;
                normalToolStripMenuItem.Enabled = true;
            } else {
                undoToolStripMenuItem.Enabled = false;
                redoToolStripMenuItem.Enabled = false;
                cutToolStripMenuItem.Enabled = false;
                copyToolStripMenuItem.Enabled = false;
                selectAllToolStripMenuItem.Enabled = false;
                boldToolStripMenuItem.Enabled = false;
                italicToolStripMenuItem.Enabled = false;
                underlineToolStripMenuItem.Enabled = false;
                strikeThroughToolStripMenuItem.Enabled = false;
                normalToolStripMenuItem.Enabled = false;
            }
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e) {
            MainRichBox.Undo();
            undoToolStripMenuItem.Enabled = false;
            redoToolStripMenuItem.Enabled = true;
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e) {
            MainRichBox.Redo();
            redoToolStripMenuItem.Enabled = false;
            undoToolStripMenuItem.Enabled = true;
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e) {
            MainRichBox.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e) {
            MainRichBox.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e) {
            MainRichBox.Paste();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e) {
            MainRichBox.SelectedText = "";
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e) {
            MainRichBox.SelectAll();
        }

        private void dateTimeToolStripMenuItem_Click(object sender, EventArgs e) {
            MainRichBox.Text += DateTime.Now;
        }

        private void boldToolStripMenuItem_Click(object sender, EventArgs e) {
            MainRichBox.SelectionFont = new Font(MainRichBox.Font, FontStyle.Bold);
        }

        private void italicToolStripMenuItem_Click(object sender, EventArgs e) {
            MainRichBox.SelectionFont = new Font(MainRichBox.Font, FontStyle.Italic);
        }

        private void underlineToolStripMenuItem_Click(object sender, EventArgs e) {
            MainRichBox.SelectionFont = new Font(MainRichBox.Font, FontStyle.Underline);
        }

        private void strikeThroughToolStripMenuItem_Click(object sender, EventArgs e) {
            MainRichBox.SelectionFont = new Font(MainRichBox.Font, FontStyle.Strikeout);
        }

        private void normalToolStripMenuItem_Click(object sender, EventArgs e) {
            MainRichBox.SelectionFont = new Font(MainRichBox.Font, FontStyle.Regular);
        }
    }
}
