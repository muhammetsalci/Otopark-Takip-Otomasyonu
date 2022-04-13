using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtoparkTakipProgramı
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            for (int j = 0; j < 21; j++) //dosyadaki plakaları gerekli konumlarına yerleştiriyoruz.
            {
                if (button1.Text == Form1.konum1[j])
                {
                    button1.Text = Form1.plaka1[j];
                    button1.BackColor = Color.Red;
                }
                else if (button2.Text == Form1.konum1[j])
                {
                    button2.Text = Form1.plaka1[j];
                    button2.BackColor = Color.Red;
                }
                else if (button3.Text == Form1.konum1[j])
                {
                    button3.Text = Form1.plaka1[j];
                    button3.BackColor = Color.Red;
                }
                else if (button4.Text == Form1.konum1[j])
                {
                    button4.Text = Form1.plaka1[j];
                    button4.BackColor = Color.Red;
                }
                else if (button5.Text == Form1.konum1[j])
                {
                    button5.Text = Form1.plaka1[j];
                    button5.BackColor = Color.Red;
                }
                else if (button6.Text == Form1.konum1[j])
                {
                    button6.Text = Form1.plaka1[j];
                    button6.BackColor = Color.Red;
                }
                else if (button7.Text == Form1.konum1[j])
                {
                    button7.Text = Form1.plaka1[j];
                    button7.BackColor = Color.Red;
                }
                else if (button8.Text == Form1.konum1[j])
                {
                    button8.Text = Form1.plaka1[j];
                    button8.BackColor = Color.Red;
                }
                else if (button9.Text == Form1.konum1[j])
                {
                    button9.Text = Form1.plaka1[j];
                    button9.BackColor = Color.Red;
                }
                else if (button10.Text == Form1.konum1[j])
                {
                    button10.Text = Form1.plaka1[j];
                    button10.BackColor = Color.Red;
                }
                else if (button11.Text == Form1.konum1[j])
                {
                    button11.Text = Form1.plaka1[j];
                    button11.BackColor = Color.Red;
                }
                else if (button12.Text == Form1.konum1[j])
                {
                    button12.Text = Form1.plaka1[j];
                    button12.BackColor = Color.Red;
                }
                else if (button13.Text == Form1.konum1[j])
                {
                    button13.Text = Form1.plaka1[j];
                    button13.BackColor = Color.Red;
                }
                else if (button14.Text == Form1.konum1[j])
                {
                    button14.Text = Form1.plaka1[j];
                    button14.BackColor = Color.Red;
                }
                else if (button15.Text == Form1.konum1[j])
                {
                    button15.Text = Form1.plaka1[j];
                    button15.BackColor = Color.Red;
                }
                else if (button16.Text == Form1.konum1[j])
                {
                    button16.Text = Form1.plaka1[j];
                    button16.BackColor = Color.Red;
                }
                else if (button17.Text == Form1.konum1[j])
                {
                    button17.Text = Form1.plaka1[j];
                    button17.BackColor = Color.Red;
                }
                else if (button18.Text == Form1.konum1[j])
                {
                    button18.Text = Form1.plaka1[j];
                    button18.BackColor = Color.Red;
                }
                else if (button19.Text == Form1.konum1[j])
                {
                    button19.Text = Form1.plaka1[j];
                    button19.BackColor = Color.Red;
                }
                else if (button20.Text == Form1.konum1[j])
                {
                    button20.Text = Form1.plaka1[j];
                    button20.BackColor = Color.Red;
                }

            }
        }
    }
}
