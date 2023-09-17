using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        private string currentFilePath;
        public Form1()
        {
            InitializeComponent();
            saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Text Files|*.txt|All Files|*.*";
        }

        //private void NewDocumentToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    richTextBox.Text = "";
        //    currentFilePath = null;
        //}

        //private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    using (OpenFileDialog openFileDialog = new OpenFileDialog())
        //    {
        //        openFileDialog.Filter = "Text Files|*.txt|All Files|*.*";

        //        if (openFileDialog.ShowDialog() == DialogResult.OK)
        //        {
        //            currentFilePath = openFileDialog.FileName;
        //            richTextBox.Text = File.ReadAllText(currentFilePath);
        //        }
        //    }
        //}

        //private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    if (currentFilePath != null)
        //    {
        //        File.WriteAllText(currentFilePath, richTextBox.Text);
        //    }
        //    else
        //    {
        //        SaveAsToolStripMenuItem_Click(sender, e);
        //    }
        //}

        //private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    using (SaveFileDialog saveFileDialog = new SaveFileDialog())
        //    {
        //        saveFileDialog.Filter = "Text Files|*.txt|All Files|*.*";

        //        if (saveFileDialog.ShowDialog() == DialogResult.OK)
        //        {
        //            currentFilePath = saveFileDialog.FileName;
        //            File.WriteAllText(currentFilePath, richTextBox.Text);
        //        }
        //    }
        //}

        //private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    richTextBox.Cut();
        //}

        //private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    richTextBox.Copy();
        //}

        //private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    richTextBox.Paste();
        //}

        //private void UndoToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    richTextBox.Undo();
        //}

        //private void RedoToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    richTextBox.Redo();
        //}

        //private void BoldToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    richTextBox.SelectionFont = new System.Drawing.Font(richTextBox.Font, FontStyle.Bold);
        //}

        //private void ItalicToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    richTextBox.SelectionFont = new System.Drawing.Font(richTextBox.Font, FontStyle.Italic);
        //}

        //private void UnderlineToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    richTextBox.SelectionFont = new System.Drawing.Font(richTextBox.Font, FontStyle.Underline);
        //}


        private void openToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            //{
            //    saveFileDialog.Filter = "Text Files|*.txt|All Files|*.*";

            //    if (saveFileDialog.ShowDialog() == DialogResult.OK)
            //    {
            //        currentFilePath = saveFileDialog.FileName;
            //        File.WriteAllText(currentFilePath, richTextBox.Text);
            //    }
            //}
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Text Files|*.txt|All Files|*.*";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filename = openFileDialog1.FileName;
                string fileText = System.IO.File.ReadAllText(filename);
                richTextBox.Text = fileText;
                MessageBox.Show("File open");
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Text = "";
            currentFilePath = null;
        }

        private void saveToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            string filename = saveFileDialog1.FileName;

            System.IO.File.WriteAllText(filename, richTextBox.Text);
            MessageBox.Show("File save");
        }


        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Cut();
        }

        private void copyToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            richTextBox.Copy();
        }

        private void pasteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            richTextBox.Paste();
        }

        private void untoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Undo();
        }


        private void boldToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (richTextBox.SelectionFont != null)
            {
                FontStyle currentStyle = richTextBox.SelectionFont.Style;
                FontStyle newStyle = currentStyle | FontStyle.Bold;
                richTextBox.SelectionFont = new Font(richTextBox.SelectionFont, newStyle);
            }
        }

        private void italicToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (richTextBox.SelectionFont != null)
            {
                FontStyle currentStyle = richTextBox.SelectionFont.Style;
                FontStyle newStyle = currentStyle | FontStyle.Italic;
                richTextBox.SelectionFont = new Font(richTextBox.SelectionFont, newStyle);
            }
        }

        private void underlineToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (richTextBox.SelectionFont != null)
            {
                FontStyle currentStyle = richTextBox.SelectionFont.Style;
                FontStyle newStyle = currentStyle | FontStyle.Underline;
                richTextBox.SelectionFont = new Font(richTextBox.SelectionFont, newStyle);
            }
        }
    }
}
