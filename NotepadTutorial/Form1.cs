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
    }
}
