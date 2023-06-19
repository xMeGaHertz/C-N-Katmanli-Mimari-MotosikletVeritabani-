using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotoBikeDealer
{
    public partial class Segmentler : Form
    {
        public Segmentler()
        {
            InitializeComponent();
        }

        public string Segment_Adi
        {
            get => textBox1.Text;
            set => textBox1.Text = value;
        }

        private void Tamam(object sender, EventArgs e)
        {
            errorProvider1.BlinkRate = 0;
            errorProvider1.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;

            bool hatalı = false;

            if (textBox1.Text == "")

                hatalı = true;

            errorProvider1.SetError(textBox1, textBox1.Text == "" ? "'Segment Adı' kısmı boş bırakılamaz" : "");

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
