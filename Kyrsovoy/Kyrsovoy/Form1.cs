using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kyrsovoy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void openImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "*.BMP|*.bmp";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }            
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
        }

        private void generateAKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            Random rand = new Random();
            Int32 len = textBox1.Text.Length;
            int[] m = new int[len];
            for (int i = 0; i < len; i++)
            {
                m[i] = rand.Next(0,53);
            }
            for (int i = 0; i < len; i++)
            {
                textBox2.Text += m[i]+" ";
            }
        }

        private void encryptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.ContextMenuStrip = contextMenuStrip2;
            MetodStatus.Text = encryptionToolStripMenuItem.Text;

            
        }

        private void decryptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.ContextMenuStrip = contextMenuStrip3;
            MetodStatus.Text = decryptionToolStripMenuItem.Text;
        }

        private void metod1E_Click(object sender, EventArgs e)
        {
            if (metod1E.Checked == true)
                MetodStatus.Text += " Metod 1";
            else {
                MetodStatus.Text = encryptionToolStripMenuItem.Text;
            };
        }

        private void metod2E_Click(object sender, EventArgs e)
        {
            if (metod2E.Checked == true)
                MetodStatus.Text += " Metod 2";
            else
            {
                MetodStatus.Text = encryptionToolStripMenuItem.Text;
            };
        }

        private void metod3E_Click(object sender, EventArgs e)
        {
            if (metod3E.Checked == true)
                MetodStatus.Text += " Metod 3";
            else
            {
                MetodStatus.Text = encryptionToolStripMenuItem.Text;
            };
        }

        private void metod1D_Click(object sender, EventArgs e)
        {
            if (metod1D.Checked == true)
                MetodStatus.Text += " Metod 1";
            else
            {
                MetodStatus.Text = encryptionToolStripMenuItem.Text;
            };
        }

        private void metod2D_Click(object sender, EventArgs e)
        {
            if (metod2D.Checked == true)
                MetodStatus.Text += " Metod 2";
            else
            {
                MetodStatus.Text = encryptionToolStripMenuItem.Text;
            };
        }

        private void metod3D_Click(object sender, EventArgs e)
        {
            if (metod3D.Checked == true)
                MetodStatus.Text += " Metod 3";
            else
            {
                MetodStatus.Text = encryptionToolStripMenuItem.Text;
            };
        }

        private void encrypriontext()
        {
            long maxlentext = 52;
            char[] mastext = new char[] { 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п',
                'р', 'с', 'т','у','ф','х','ц','ч','ш','щ','ъ','ы','ь','э','ю','я','*','/','+','-','.',',','?','!',' ','0','1','2',
                '3','4','5','6','7','8','9'};
            long lenmastext = mastext.Length;
            string texted = textBox1.Text.ToLower();
            char[] maschartext;
            maschartext = texted.ToCharArray();
            string[] ttext = textBox2.Text.Split(',');
            long[] maskey = new long[ttext.Length];
            for (int i = 0; i < ttext.Length; i++)
                maskey[i] = long.Parse(ttext[i]);
            long key;
            long lenkey;
            long[] num = new long[maskey.Length];
            for (int i = 0; i < maschartext.Length; i++)
            {
                
                for (long k = 0; k < mastext.Length; k++)
                {
                    if (maschartext[i] == mastext[k])
                    {
                        num[i] = k;
                    }
                }
                    key = 0;
                for (int j = 0; j < maskey.Length; j++)
                    key = num[j] - maskey[j];
                if (key < 0)
                {
                    lenkey = maxlentext - Math.Abs(key);
                }
                else {
                    lenkey = key;
                }
                textBox3.Text += mastext[lenkey]+" ";
            }
        }

        private void encryption_Click(object sender, EventArgs e)
        {
            encrypriontext();
        }

    }
}
