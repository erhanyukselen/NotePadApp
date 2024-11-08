using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace NotepadApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = new DialogResult();
            sonuc = MessageBox.Show("Çalışmanızı kaydetmek ister misiniz?","Yeni",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (sonuc == DialogResult.Yes)
            {
                saveToolStripMenuItem_Click(sender, e);

            }
            else
            {
                richTextBox1.Clear();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Metin Dosyasını Kaydet";
            saveFileDialog1.Filter= "Text dosyalar(*.txt)|*.txt|Tüm Dosyalar(*.*)|*.*";
            if (saveFileDialog1.ShowDialog()==DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, richTextBox1.Text, Encoding.UTF8);
                this.Close();
            }

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Metin Dosyasını Aç";
            openFileDialog1.Filter = "Text dosyalar(*.txt)|*.txt|Tüm Dosyalar(*.*)|*.*";
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                richTextBox1.Text = File.ReadAllText(openFileDialog1.FileName, Encoding.UTF8);
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Metin Dosyasını Kaydet";
            saveFileDialog1.Filter = "Text dosyalar(*.txt)|*.txt|Tüm Dosyalar(*.*)|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, richTextBox1.Text, Encoding.UTF8);
                this.Close();
            }
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void customizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            richTextBox1.SelectionFont = fontDialog1.Font;
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void cutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }
    }
}
