using System.Windows.Forms;

namespace TextVault
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = string.Empty;
        }

        private void replaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            findToolStripMenuItem_Click(sender, e);
            Prompt p1 = new Prompt();
            p1.ShowDialog();
            if (p1.i == 0)
            {
                richTextBox1.SelectedText= p1.a;
            }
            else 
            {
                MessageBox.Show("Replace was not executed.", "Find Text", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }


        }

        private void timeDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = DateTime.Now.ToString();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.ShowDialog();

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to save before closing?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (result == DialogResult.Yes)
            {
                if (richTextBox1 != null)
                {
                    saveToolStripMenuItem_Click(sender, e);
                    richTextBox1.Text = "";
                }
                else
                {
                    Close();
                }
            }
            else
                richTextBox1.Text = richTextBox1.Text;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.Filter = "Text Files(*.txt)|*.txt|All files(*.*)|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.Yes)
            {
                string fn = saveFileDialog1.FileName;
                StreamWriter sw = new StreamWriter(fn);
                sw.Write(richTextBox1.Text);
                sw.Flush();
                sw.Close();
            }

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() == DialogResult.Yes)
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                string s = sr.ReadLine();
                while (s != null)
                {
                    richTextBox1.Text = s;
                    s = sr.ReadLine();
                }
            }

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != null)
            {
                DialogResult result = MessageBox.Show("Do you want to save?", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    saveToolStripMenuItem_Click(sender, e);
                    richTextBox1.Text = "";
                }
                else
                {
                    richTextBox1.Text = "";
                }
            }
        }

        private void zoomInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.ZoomFactor += 0.1f;
        }

        private void zoomOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.ZoomFactor -= 0.1f;
        }

        private void restoreDefaultZoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.ZoomFactor = 1;
        }

        private void statusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (statusBarToolStripMenuItem.Checked)
            {
                statusBarToolStripMenuItem.Checked = false;
                statusStrip1.Visible = false;
            }
            else
            {
                statusBarToolStripMenuItem.Checked = true;
                statusStrip1.Visible = true;
            }
        }

        private void wordWrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (wordWrapToolStripMenuItem.Checked)
            {
                wordWrapToolStripMenuItem.Checked = false;
                richTextBox1.WordWrap = false;
            }
            else
            {
                wordWrapToolStripMenuItem.Checked = true;
                richTextBox1.WordWrap = true;
            }
        }

        private void goToToolStripMenuItem_Click(object sender, EventArgs e)
        {
            findToolStripMenuItem_Click(sender, e);
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() != DialogResult.Cancel)
            {
                richTextBox1.Font = fontDialog1.Font;
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.Yes)
            {
                richTextBox1.ForeColor = colorDialog1.Color;
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (richTextBox1.Text != string.Empty)
            {
                undoToolStripMenuItem.Enabled = true;
                cutToolStripMenuItem.Enabled = true;
                copyToolStripMenuItem.Enabled = true;
                deleteToolStripMenuItem.Enabled = true;
                findToolStripMenuItem.Enabled = true;
                findNextToolStripMenuItem.Enabled = true;
                findPreviousToolStripMenuItem.Enabled = true;
                replaceToolStripMenuItem.Enabled = true;
            }
            else
            {
                undoToolStripMenuItem.Enabled = false;
                cutToolStripMenuItem.Enabled = false;
                copyToolStripMenuItem.Enabled = false;
                deleteToolStripMenuItem.Enabled = false;
                findToolStripMenuItem.Enabled = false;
                findNextToolStripMenuItem.Enabled = false;
                findPreviousToolStripMenuItem.Enabled = false;
                replaceToolStripMenuItem.Enabled = false;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutMe am = new AboutMe();
            am.Show();
        }

        private void pageSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printToolStripMenuItem_Click(sender,e);
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Prompt p = new Prompt();
            p.ShowDialog();
            if (p.i == 0)
            {
                int startIndex = richTextBox1.Find(p.a, 0, (RichTextBoxFinds)richTextBox1.TextLength);

                if (startIndex != -1)
                {

                    richTextBox1.Select(startIndex, p.a.Length);
                    richTextBox1.Focus();

                }
                else
                {
                    MessageBox.Show("Text not found.", "Find Text", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
            else
            {
                MessageBox.Show("Find was not executed.", "Find Text", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void findNextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Prompt p = new Prompt();
            p.ShowDialog();
            if (p.i == 0)
            {
                int startIndex = richTextBox1.Find(p.a, richTextBox1.SelectionStart, (RichTextBoxFinds)richTextBox1.TextLength);

                if (startIndex != -1)
                {

                    richTextBox1.Select(startIndex, p.a.Length);
                    richTextBox1.Focus();

                }
                else
                {
                    MessageBox.Show("Text not found.", "Find Text", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
            else
            {
                MessageBox.Show("Find was not executed.", "Find Text", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
       

        private void findPreviousToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Prompt p = new Prompt();
            p.ShowDialog();
            if (p.i==0)
            {
                int startIndex = richTextBox1.Find(p.a, 0, richTextBox1.SelectionStart, (RichTextBoxFinds)richTextBox1.TextLength);

                if (startIndex != -1)
                {

                    richTextBox1.Select(startIndex, p.a.Length);
                    richTextBox1.Focus();

                }
                else
                {
                    MessageBox.Show("Text not found.", "Find Text", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
            else
            {
                MessageBox.Show("Find was not executed.", "Find Text", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
