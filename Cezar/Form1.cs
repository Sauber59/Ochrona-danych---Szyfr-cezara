using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cezar
{
    public partial class Form1 : Form
    {
        char[] alphabet = new char[] { 'A', 'Ą', 'B', 'C', 'Ć', 'D', 'E', 'Ę', 
            'F', 'G', 'H', 'I', 'J', 'K', 'L', 'Ł', 'M', 'N', 'Ń', 'O', 'Ó', 'P', 
            'R', 'S', 'Ś', 'T', 'U', 'W', 'Y', 'Z', 'Ź', 'Ż', 'a', 'ą', 'b', 'c', 
            'ć', 'd', 'e', 'ę', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'ł', 'm', 'n', 
            'ń', 'o', 'ó', 'p', 'r', 's', 'ś', 't', 'u', 'w', 'y', 'z', 'ź', 'ż', 
            '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Clear();

            char[] chars = textBox1.Text.ToArray();
            string encodeText = "";

            for (int i = 0; i < chars.Length; i++)
            {
                for (int j = 0; j < alphabet.Length; j++)
                {
                    if (char.Equals(chars[i], alphabet[j]))
                    {
                        if (j + (int)numericUpDown1.Value >= alphabet.Length)
                            j = j - alphabet.Length;

                        encodeText = encodeText + alphabet[j + (int)numericUpDown1.Value].ToString();
                        break;
                    }
                }
            }

            textBox2.Paste(encodeText);
        }


        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();

            char[] chars = textBox1.Text.ToArray();
            string dencodeText = "";

            for (int i = 0; i < chars.Length; i++)
            {
                for (int j = 0; j < alphabet.Length; j++)
                {
                    if (char.Equals(chars[i], alphabet[j]))
                    {
                        if (j - (int)numericUpDown1.Value < 0)
                        j = j + alphabet.Length;

                        dencodeText = dencodeText + alphabet[j - (int)numericUpDown1.Value].ToString();
                        break;
                    }
                }
            }

            textBox2.Paste(dencodeText);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            textBox2.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox2.Clear();
        }
    }
}
