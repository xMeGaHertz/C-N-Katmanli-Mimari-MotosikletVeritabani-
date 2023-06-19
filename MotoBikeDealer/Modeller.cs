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

namespace MotoBikeDealer
{
    public partial class Modeller : Form
    {
        public Modeller()
        {
            InitializeComponent();
        }

        public string Model_Adi
        {
            get => textBox1.Text;
            set => textBox1.Text = value;
        }

        public int Model_Yil
        {
            get => (int)numericUpDown1.Value;
            set => numericUpDown1.Value = value;
        }

        public int Model_Beygir
        {
            get => (int)numericUpDown2.Value;
            set => numericUpDown2.Value = value;
        }

        public int Model_Hacim
        {
            get => (int)numericUpDown3.Value;
            set => numericUpDown3.Value = value;
        }

        public string Model_Renk
        {
            get => textBox2.Text;
            set => textBox2.Text = value;
        }

        public float Model_Fiyat
        {
            get => (float)numericUpDown4.Value;
            set => numericUpDown4.Value = (decimal)value;
        }

        public string Model_Stok
        {
            get => textBox3.Text;
            set => textBox3.Text = value;
        }

        public string Model_Aciklama
        {
            get => textBox4.Text;
            set => textBox4.Text = value;
        }

        private void Tamam(object sender, EventArgs e)
        {
            errorProvider1.BlinkRate = 0;
            errorProvider1.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;

            bool hatalı = false;

            if (textBox1.Text == ""
                || numericUpDown1.Value == 0
                || numericUpDown2.Value == 0
                || numericUpDown3.Value == 0
                || textBox2.Text == ""
                || numericUpDown4.Value == 0
                || textBox3.Text == ""
                || textBox4.Text == "")

                hatalı = true;

            errorProvider1.SetError(textBox1, textBox1.Text == "" ? "'Model Adı' kısmı boş bırakılamaz!" : "");
            errorProvider1.SetError(numericUpDown1, numericUpDown1.Value == 0 ? "Lütfen değer giriniz!" : "");
            errorProvider1.SetError(numericUpDown2, numericUpDown2.Value == 0 ? "Lütfen değer giriniz!" : "");
            errorProvider1.SetError(numericUpDown3, numericUpDown3.Value == 0 ? "Lütfen değer giriniz!" : "");
            errorProvider1.SetError(textBox2, textBox2.Text == "" ? "'Renk' kısmı boş bırakılamaz" : "");
            errorProvider1.SetError(numericUpDown4, numericUpDown4.Value == 0 ? "Lütfen değer giriniz!" : "");
            errorProvider1.SetError(textBox3, textBox3.Text == "" ? "'Stok' kısmı boş bırakılamaz" : "");
            errorProvider1.SetError(textBox4, textBox4.Text == "" ? "'Açıklama' kısmı boş bırakılamaz" : "");


            if (hatalı)
                return;

            DialogResult = DialogResult.OK;
        }

        private void İptal(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
