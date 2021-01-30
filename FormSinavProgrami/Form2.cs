using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormSinavProgrami
{
    public partial class FormAdSoyad : Form
    {
        int sayac = 20;
        int dogru = 0,yanlis = 0;

         public void sonuclar(RadioButton seciliolan)
        {
            if (seciliolan.Checked == true)
            {
                dogru++;
                seciliolan.BackColor = Color.Green;
            }
            else
            {   
                yanlis++;
            }
            labelDogruSayiSonuc.Text = dogru.ToString();
            labelYanlisSayiSonuc.Text = yanlis.ToString();
         

        }

        public void grupFalse()
        {
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
            groupBox3.Enabled = false;
            groupBox4.Enabled = false;
            
        }
        public void grupTrue()
        {
            groupBox1.Enabled = true;
            groupBox2.Enabled = true;
            groupBox3.Enabled = true;
            groupBox4.Enabled = true;
            
        }

        public FormAdSoyad()
        {
            InitializeComponent();
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac--;
            labelSayac.Text = sayac.ToString();
            
            
            if (sayac == 0)
            {
                timer1.Enabled = false;
                grupFalse();
                MessageBox.Show("Süreniz dolmuştur");
                
                btnbasla.Enabled = false;
                btnbitir.Enabled = false;

                sonuclar(radioButton4);
                sonuclar(radioButton5);
                sonuclar(radioButton11);
                sonuclar(radioButton16);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {        }

        private void label1_Click(object sender, EventArgs e)
        {        }

        private void FormAdSoyad_Load(object sender, EventArgs e)
        {
            grupFalse();
        }

        private void btnbasla_Click(object sender, EventArgs e)
        {

            if ((textBoxNo.Text == "") || (textBoxAdSoyad.Text == ""))
            {
                MessageBox.Show("Lütfen gerekli bölümleri doldurunuz");
            } 
            else
            {
                timer1.Enabled = true;
                grupTrue();
                labelTCNoSonuc2.Text = textBoxNo.Text; ;
                labelAdSoyadSonuc2.Text = textBoxAdSoyad.Text;
                btnbasla.Enabled = false;
            }
        }

        private void btnbitir_Click(object sender, EventArgs e)
        {
            grupFalse();
            btnbitir.Enabled = false;
            timer1.Enabled = false;
            sonuclar(radioButton4);
            sonuclar(radioButton5);
            sonuclar(radioButton11);
            sonuclar(radioButton16);
        } 
    }
}
