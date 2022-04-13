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
    public partial class Form2 : Form
    {
        Form3 f3 = new Form3();

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
            f3.ShowDialog();
        }
        //bütün formlarda kullanabilmek için bu şekilde diziler oluşturuyoruz.
        public static string[] veri = new string[21];
        public static string[] konum = new string[21];
        public static string[] plaka = new string[21];
        public static int[] id = new int[21];
        public static string[] ad = new string[21];
        public static string[] soyad = new string[21];
        public static string[] cep = new string[21];
        public static string[] marka = new string[21];
        public static string[] model = new string[21];
        public static string[] renk = new string[21];
        public static string[] tc = new string[21];
        public static int i = Form1.i; //form1 deki i değerini atıyoruz.

        private void button6_Click(object sender, EventArgs e)
        {

            if (i < 20) //otopark 20 kişilik olduğu için koşula sokuyoruz.
            {
                id[i] = i + 1; //i nin ilk değeri 0 olduğu için id değerini 1 den başlatıyoruz.
                tc[i] = textBox1.Text;
                ad[i] = textBox2.Text;
                soyad[i] = textBox3.Text;
                cep[i] = textBox4.Text;
                plaka[i] = textBox5.Text;
                marka[i] = textBox6.Text;
                model[i] = textBox7.Text;
                renk[i] = textBox8.Text;
                konum[i] = comboBox2.Text;

                veri[i] = Convert.ToString(id[i]) + "#" + tc[i] + "#" + ad[i] + "#" + soyad[i] + "#" + cep[i] + "#" + plaka[i] + "#" + marka[i] + "#" + model[i] + "#" + renk[i] + "#" + konum[i];

                i++;


                for (int j = 0; j < 21; j++) //form3'teki araç yerlerine veri gönderiyoruz.
                {
                    if (f3.button1.Text == konum[j])
                    {
                        f3.button1.Text = plaka[j];
                        f3.button1.BackColor = Color.Red;
                    }
                    else if (f3.button2.Text == konum[j])
                    {
                        f3.button2.Text = plaka[j];
                        f3.button2.BackColor = Color.Red;
                    }
                    else if (f3.button3.Text == konum[j])
                    {
                        f3.button3.Text = plaka[j];
                        f3.button3.BackColor = Color.Red;
                    }
                    else if (f3.button4.Text == konum[j])
                    {
                        f3.button4.Text = plaka[j];
                        f3.button4.BackColor = Color.Red;
                    }
                    else if (f3.button5.Text == konum[j])
                    {
                        f3.button5.Text = plaka[j];
                        f3.button5.BackColor = Color.Red;
                    }
                    else if (f3.button6.Text == konum[j])
                    {
                        f3.button6.Text = plaka[j];
                        f3.button6.BackColor = Color.Red;
                    }
                    else if (f3.button7.Text == konum[j])
                    {
                        f3.button7.Text = plaka[j];
                        f3.button7.BackColor = Color.Red;
                    }
                    else if (f3.button8.Text == konum[j])
                    {
                        f3.button8.Text = plaka[j];
                        f3.button8.BackColor = Color.Red;
                    }
                    else if (f3.button9.Text == konum[j])
                    {
                        f3.button9.Text = plaka[j];
                        f3.button9.BackColor = Color.Red;
                    }
                    else if (f3.button10.Text == konum[j])
                    {
                        f3.button10.Text = plaka[j];
                        f3.button10.BackColor = Color.Red;
                    }
                    else if (f3.button11.Text == konum[j])
                    {
                        f3.button11.Text = plaka[j];
                        f3.button11.BackColor = Color.Red;
                    }
                    else if (f3.button12.Text == konum[j])
                    {
                        f3.button12.Text = plaka[j];
                        f3.button12.BackColor = Color.Red;
                    }
                    else if (f3.button13.Text == konum[j])
                    {
                        f3.button13.Text = plaka[j];
                        f3.button13.BackColor = Color.Red;
                    }
                    else if (f3.button14.Text == konum[j])
                    {
                        f3.button14.Text = plaka[j];
                        f3.button14.BackColor = Color.Red;
                    }
                    else if (f3.button15.Text == konum[j])
                    {
                        f3.button15.Text = plaka[j];
                        f3.button15.BackColor = Color.Red;
                    }
                    else if (f3.button16.Text == konum[j])
                    {
                        f3.button16.Text = plaka[j];
                        f3.button16.BackColor = Color.Red;
                    }
                    else if (f3.button17.Text == konum[j])
                    {
                        f3.button17.Text = plaka[j];
                        f3.button17.BackColor = Color.Red;
                    }
                    else if (f3.button18.Text == konum[j])
                    {
                        f3.button18.Text = plaka[j];
                        f3.button18.BackColor = Color.Red;
                    }
                    else if (f3.button19.Text == konum[j])
                    {
                        f3.button19.Text = plaka[j];
                        f3.button19.BackColor = Color.Red;
                    }
                    else if (f3.button20.Text == konum[j])
                    {
                        f3.button20.Text = plaka[j];
                        f3.button20.BackColor = Color.Red;
                    }

                }

            }

            else //20den fazla araç kaydı yapacağımız zaman hata verdiren koşul.
            {
                MessageBox.Show("Özür dileriz. Parkımızda yer yok. İlginiz için teşekkürler.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sure = 0, ic = 0, dis = 0, sonuc = 0;
            //verilen bilgilere göre koşulla sure değişkeninin değerini değiştiriyoruz.
            if (comboBox1.Text == "10dk")
            {
                sure = 0;
            }
            else if (comboBox1.Text == "30dk")
            {
                sure = 2;
            }
            else if (comboBox1.Text == "1 saat")
            {
                sure = 3;
            }
            else if (comboBox1.Text == "3 saat")
            {
                sure = 5;
            }
            else if (comboBox1.Text == "5 Saat")
            {
                sure = 10;
            }
            else if (comboBox1.Text == "10 saat")
            {
                sure = 15;
            }
            else if (comboBox1.Text == "1 gün")
            {
                sure = 25;
            }

            if (checkedListBox1.GetItemCheckState(0) == CheckState.Checked) //checkedlistbox içinde 1. satır seçili ise bu koşula gir.
            {
                ic = 10;
            }
            else
            {
                ic = 0;
            }

            if (checkedListBox1.GetItemCheckState(1) == CheckState.Checked) //checkedlistbox içinde 2. satır seçili ise bu koşula gir.
            {
                dis = 10;
            }
            else
            {
                dis = 0;
            }

            sonuc = sure + ic + dis; //bütün değerleri toplatıyoruz.

            MessageBox.Show(textBox5.Text + " " + sonuc + " TL ödeme için teşekkür ederiz." + "\n" + "Yine Bekleriz. Güle Güle.");

        }

        int a = 0;
        int k = 0;

        private void button5_Click(object sender, EventArgs e)
        {
            for (int j = 0; id[j] != 0; j++)
            {
                a = 0; //değeri her seferinde sıfırlıyoruz.
                a = id[j]; //id değerini a ya atıyoruz.
            }
            if (k < a) 
            {
                k++;
                textBox10.Text = Convert.ToString(k) + "/" + Convert.ToString(a); //k seçilen id oluyor a ise toplam kaç değer olduğunu gösteriyor.

            }

            for (int l = 0; l < 21; l++) //k değerine sahip diziyi ekrana yazdırıyoruz.
            {
                if (id[l] == k)
                {
                    textBox1.Text = tc[l];
                    textBox2.Text = ad[l];
                    textBox3.Text = soyad[l];
                    textBox4.Text = cep[l];
                    textBox5.Text = plaka[l];
                    textBox6.Text = marka[l];
                    textBox7.Text = model[l];
                    textBox8.Text = renk[l];
                    comboBox2.Text = konum[l];
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int j = 0; id[j] != 0; j++)
            {
                a = 0;
                a = id[j];
            }
            if (k > 1)
            {
                k--;
                textBox10.Text = Convert.ToString(k) + "/" + Convert.ToString(a);

            }

            for (int l = 0; l < 21; l++)
            {
                if (id[l] == k)
                {
                    textBox1.Text = tc[l];
                    textBox2.Text = ad[l];
                    textBox3.Text = soyad[l];
                    textBox4.Text = cep[l];
                    textBox5.Text = plaka[l];
                    textBox6.Text = marka[l];
                    textBox7.Text = model[l];
                    textBox8.Text = renk[l];
                    comboBox2.Text = konum[l];
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int m = 0; id[m] != 0; m++)
            {
                a = 0;
                a = id[m];
            }
            textBox10.Text = Convert.ToString(a) + "/" + Convert.ToString(a);

            if (a != 0)
            {
                textBox1.Text = tc[a - 1];
                textBox2.Text = ad[a - 1];
                textBox3.Text = soyad[a - 1];
                textBox4.Text = cep[a - 1];
                textBox5.Text = plaka[a - 1];
                textBox6.Text = marka[a - 1];
                textBox7.Text = model[a - 1];
                textBox8.Text = renk[a - 1];
                comboBox2.Text = konum[a - 1];
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int m = 0; id[m] != 0; m++)
            {
                a = 0;
                a = id[m];
            }
            textBox10.Text = "1/" + Convert.ToString(a);

            textBox1.Text = tc[0];
            textBox2.Text = ad[0];
            textBox3.Text = soyad[0];
            textBox4.Text = cep[0];
            textBox5.Text = plaka[0];
            textBox6.Text = marka[0];
            textBox7.Text = model[0];
            textBox8.Text = renk[0];
            comboBox2.Text = konum[0];
        }
    }
}
