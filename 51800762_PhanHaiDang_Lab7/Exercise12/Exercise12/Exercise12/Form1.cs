using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise12
{
    public partial class Form1 : Form
    {
        private string filepath;
        CommandBase disableSave, enableSave;
        CommandBase disableCopy, enableCopy;
        CommandBase disableDelete, enableDelete;
        CommandBase disablePaste, enablePaste;
        public Form1()
        {
            InitializeComponent();
            disableSave = new DisableCommand(saveToolStripMenuItem, saveToolStripMenuItem1);
            enableSave = new EnableCommand(saveToolStripMenuItem, saveToolStripMenuItem1);

            enableCopy = new EnableCommand(copyToolStripMenuItem1, copyToolStripMenuItem);
            disableCopy = new DisableCommand(copyToolStripMenuItem1, copyToolStripMenuItem);

            disableDelete = new DisableCommand(deleteToolStripMenuItem);
            enableDelete = new EnableCommand(deleteToolStripMenuItem);

            disablePaste = new DisableCommand(pasteToolStripMenuItem, pasteToolStripMenuItem1);
            enablePaste = new EnableCommand(pasteToolStripMenuItem, pasteToolStripMenuItem1);

            disableCopy.execute();
            disableSave.execute();
            disableDelete.execute();
           
        }

        private void menuToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            openFile();
        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            saveClick();
        }

        private void copyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            copyText();
        }

        private void pasteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            pasteText();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFile();
        }


        private void openFile()
        {
            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                filepath = openFileDialog1.FileName;
                txtContent.Text = File.ReadAllText(filepath);
                this.Text = filepath + " - Notepad";
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveClick();
        }

        private void saveClick()
        {
            if (string.IsNullOrEmpty(filepath))
            {
                if (saveFileDialog1.ShowDialog(this) == DialogResult.OK)
                {
                    filepath = saveFileDialog1.FileName;
                    this.Text = filepath + " - Notepad";
                }
                else
                {
                    return;
                }

            }
            File.WriteAllText(filepath, txtContent.Text);
            disableSave.execute();
        }

        private void copyText()
        {
            txtContent.Copy();
        }

        private void pasteText()
        {
            txtContent.Paste();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            copyText();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pasteText();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            undoText();
        }
        private void undoText()
        {
            txtContent.Undo();
        }

        private void redoText()
        {
            txtContent.Redo();
        }
        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            redoText();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newFile();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtContent.SelectedText))
            {
                disableCopy.execute();
                disableDelete.execute();
            }
            else
            {
                enableCopy.execute();
                enableDelete.execute();
            }


            if (Clipboard.ContainsText())
            {
                enablePaste.execute();
            }
            else
            {
                disablePaste.execute();
            }

        }

        private void boldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var currentStyle = txtContent.SelectionFont.Style;
            var newStyle =
                txtContent.SelectionFont.Bold ?
                currentStyle ^ FontStyle.Bold :
                currentStyle | FontStyle.Bold;

            txtContent.SelectionFont =
                new Font(
                    txtContent.SelectionFont.FontFamily,
                    txtContent.SelectionFont.Size,
                    newStyle);
        }

        private void underlineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var currentStyle = txtContent.SelectionFont.Style;
            var newStyle =
                txtContent.SelectionFont.Underline ?
                currentStyle ^ FontStyle.Underline :
                currentStyle | FontStyle.Underline;

            txtContent.SelectionFont =
                new Font(
                    txtContent.SelectionFont.FontFamily,
                    txtContent.SelectionFont.Size,
                    newStyle);
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {


            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                var colorpicker = colorDialog1.Color;
                colorToolStripMenuItem.ForeColor = colorpicker;
                txtContent.SelectionColor = colorpicker;
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(fontDialog1.ShowDialog() == DialogResult.OK)
            {
                txtContent.Font = fontDialog1.Font;
            }
        }

        private void italicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var currentStyle = txtContent.SelectionFont.Style;
            var newStyle =
                txtContent.SelectionFont.Italic ?
                currentStyle ^ FontStyle.Italic :
                currentStyle | FontStyle.Italic;

            txtContent.SelectionFont =
                new Font(
                    txtContent.SelectionFont.FontFamily,
                    txtContent.SelectionFont.Size,
                    newStyle);
        }


        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var lengthRemove = txtContent.SelectionLength;
            var start = txtContent.SelectionStart;
            txtContent.Text = txtContent.Text.Remove(txtContent.SelectionStart, lengthRemove);
            txtContent.SelectionStart = start;
        }

        private void txtContent_TextChanged(object sender, EventArgs e)
        {
            enableSave.execute();
        }

        private void newToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            newFile();
        }
        private void newFile()
        {
            txtContent.Text = "";
            this.Text = "Notepad";
            disableCopy.execute();
            disableSave.execute();
            disableDelete.execute();
        }
    }
}
