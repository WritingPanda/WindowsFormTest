using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (FileStream fstream = File.Create(textBox1.Text))
                {
                    Byte[] text = new UTF8Encoding(true).GetBytes(richTextBox1.Text);
                    fstream.Write(text, 0, text.Length);
                } 
            }
            catch (Exception ex)
            {
                label1.Text = ex.ToString();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (StreamReader sreader = File.OpenText(textBox2.Text))
                {
                    string linestoprint;
                    while ((linestoprint = sreader.ReadLine()) != null)
                    {
                        richTextBox2.Text += linestoprint + "\n";
                    }
                }
            }
            catch (Exception ex)
            {
                label1.Text = ex.ToString();
            }
        }
    }
}
