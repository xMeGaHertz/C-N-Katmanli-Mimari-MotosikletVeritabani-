using BusinessLogicLayer;
using static BusinessLogicLayer.Entity;

namespace MotoBikeDealer
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        void HataG�ster()
        {
            if (!string.IsNullOrEmpty(BL.error))
                MessageBox.Show("Hata Ayr�nt�lar�: \n" + BL.error, "Hata Olu�tu", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Marka
        private void MarkaEkle(object sender, EventArgs e)
        {
            Markalar frm = new Markalar()
            {
                Text = "Marka Ekle",
                StartPosition = FormStartPosition.CenterParent,
                FormBorderStyle = FormBorderStyle.FixedToolWindow
            };

            if (frm.ShowDialog() == DialogResult.OK)
            {
                var res = BL.BusinessMarkaEkle(frm.Marka_Adi);
                if (res == false)
                    HataG�ster();
                else
                    Markay�ListeyeEkle(BL.Markalar[BL.Markalar.Count - 1]);
            }

        }

        private void MarkaD�zenle(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
                return;

            var marka = listView1.SelectedItems[0];

            var m = marka.Tag as Marka;

            Markalar frm = new Markalar()
            {
                Text = "Marka D�zenle",
                StartPosition = FormStartPosition.CenterParent,
                FormBorderStyle = FormBorderStyle.FixedToolWindow,

                Marka_Adi = m.Marka_Adi
            };

            if (frm.ShowDialog() != DialogResult.OK)
                return;

            var res = BL.BusinessMarkaD�zenle(m.Marka_ID, frm.Marka_Adi);

            if (res == false)
                HataG�ster();
            else
            {
                marka.SubItems[0].Text = frm.Marka_Adi;
            }
        }

        private void MarkaSil(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
                return;

            var sonuc = MessageBox.Show("Se�ilen Marka Silinsin Mi?", "Silmeyi Onayla", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (sonuc != DialogResult.Yes)
                return;

            var marka = listView1.SelectedItems[0];
            var m = marka.Tag as Marka;

            var res = BL.BusinessMarkaSil(m.Marka_ID);
            if (res == false)
                HataG�ster();
            else
                listView1.Items.Remove(marka);
        }

        void Markay�ListeyeEkle(Marka m)
        {
            ListViewItem marka = new ListViewItem(new string[]

                {
                    m.Marka_Adi
                });

            marka.Tag = m;

            listView1.Items.Add(marka);
        }

        void Markay�Listele()
        {
            foreach (var m in BL.Markalar)
            {
                Markay�ListeyeEkle(m);
            }
        }

        private void Markalar�Listele(object sender, EventArgs e)
        {
            {
                BL.BusinessMarkaListele();

                Markay�Listele();
            };
        }

        //Segment
        private void SegmentEkle(object sender, EventArgs e)
        {

            if (listView1.SelectedItems.Count == 0)
                return;

            var marka = listView1.SelectedItems[0].Tag as Marka;

            Segmentler frm = new Segmentler()
            {
                Text = "Segment Ekle",
                StartPosition = FormStartPosition.CenterParent,
                FormBorderStyle = FormBorderStyle.FixedToolWindow
            };

            if (frm.ShowDialog() == DialogResult.OK)
            {
                var res = BL.BusinessSegmentEkle(marka.Marka_ID, frm.Segment_Adi);
                if (res == false)
                    HataG�ster();
                else
                    SegmentiListeyeEkle(marka.Segmentler[marka.Segmentler.Count - 1]);
            }
        }

        private void SegmentD�zenle(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count == 0)
                return;

            var segment = listView2.SelectedItems[0];

            var mo = segment.Tag as Segment;

            Segmentler frm = new Segmentler()
            {
                Text = "Segment D�zenle",
                StartPosition = FormStartPosition.CenterParent,
                FormBorderStyle = FormBorderStyle.FixedToolWindow,

                Segment_Adi = mo.Segment_Adi
            };

            if (frm.ShowDialog() != DialogResult.OK)
                return;

            var res = BL.BusinessSegmentD�zenle(mo.SegmentMarka_ID, mo.Segment_ID, frm.Segment_Adi);

            if (res == false)
                HataG�ster();
            else
            {
                segment.SubItems[0].Text = frm.Segment_Adi;
            }
        }

        private void SegmentSil(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count == 0)
                return;

            var sonuc = MessageBox.Show("Se�ilen Segment Silinsin Mi?", "Silmeyi Onayla", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (sonuc != DialogResult.Yes)
                return;

            var segment = listView2.SelectedItems[0];
            var mo = segment.Tag as Segment;

            var res = BL.BusinessSegmentSil(mo.SegmentMarka_ID, mo.Segment_ID);
            if (res == false)
                HataG�ster();
            else
                listView2.Items.Remove(segment);
        }

        void SegmentiListeyeEkle(Segment s)
        {

            ListViewItem segment = new ListViewItem(new string[]
                {

                s.Segment_Adi

                });

            segment.Tag = s;

            listView2.Items.Add(segment);

        }

        void SegmentiListele(Marka m)
        {
            listView2.Items.Clear();
            foreach (var e in m.Segmentler)
                SegmentiListeyeEkle(e);
        }

        private void SegmentleriListele(object sender, EventArgs e)
        {
            listView3.Items.Clear();

            listView2.Items.Clear();
            if (listView1.SelectedItems.Count == 0)
            {
                return;
            }

            var marka = listView1.SelectedItems[0].Tag as Marka;

            var res = BL.BusinessMarkan�nSegmentiniListele(marka.Marka_ID);

            if (res == false)
                HataG�ster();
            else
            {
                SegmentiListele(marka);
            }
        }

        //Model
        private void ModelEkle(object sender, EventArgs e)
        {
            listView3.Items.Clear();

            if (listView2.SelectedItems.Count == 0)
                return;

            var segment = listView2.SelectedItems[0].Tag as Segment;

            Modeller frm = new Modeller()
            {
                Text = "Model Ekle",
                StartPosition = FormStartPosition.CenterParent,
                FormBorderStyle = FormBorderStyle.FixedToolWindow,
            };

            if (frm.ShowDialog() == DialogResult.OK)
            {
                var marka = listView1.SelectedItems[0].Tag as Marka;

                var res = BL.BusinessModelEkle(marka.Marka_ID, segment.Segment_ID, frm.Model_Adi, frm.Model_Yil, frm.Model_Beygir, frm.Model_Hacim, frm.Model_Renk, frm.Model_Fiyat, frm.Model_Stok, frm.Model_Aciklama);
                if (res == false)
                    HataG�ster();
                else
                    ModeliListeyeEkle(segment.Modeller[segment.Modeller.Count - 1]);
            }
        }

        private void ModelD�zenle(object sender, EventArgs e)
        {
            if (listView3.SelectedItems.Count == 0)
                return;

            var model = listView3.SelectedItems[0];

            var mo = model.Tag as Model;


            Modeller frm = new Modeller()
            {
                Text = "Model D�zenle",
                StartPosition = FormStartPosition.CenterParent,
                FormBorderStyle = FormBorderStyle.FixedToolWindow,

                Model_Adi = mo.Model_Adi,
                Model_Yil = mo.Model_Yil,
                Model_Beygir = mo.Model_Beygir,
                Model_Hacim = mo.Model_Hacim,
                Model_Renk = mo.Model_Renk,
                Model_Fiyat = mo.Model_Fiyat,
                Model_Stok = mo.Model_Stok,
                Model_Aciklama = mo.Model_Aciklama

            };

            if (frm.ShowDialog() != DialogResult.OK)
                return;

            var marka = listView1.SelectedItems[0].Tag as Marka;

            var res = BL.BusinessModelD�zenle(marka.Marka_ID, mo.ModelSegment_ID, mo.Model_ID, frm.Model_Adi, frm.Model_Yil, frm.Model_Beygir, frm.Model_Hacim, frm.Model_Renk, frm.Model_Fiyat, frm.Model_Stok, frm.Model_Aciklama);

            if (res == false)
                HataG�ster();
            else
            {
                model.SubItems[0].Text = frm.Model_Adi;
                model.SubItems[1].Text = frm.Model_Yil.ToString();
                model.SubItems[2].Text = frm.Model_Beygir.ToString();
                model.SubItems[3].Text = frm.Model_Hacim.ToString();
                model.SubItems[4].Text = frm.Model_Renk;
                model.SubItems[5].Text = frm.Model_Fiyat.ToString();
                model.SubItems[6].Text = frm.Model_Stok;
                model.SubItems[7].Text = frm.Model_Aciklama;

            }
        }

        private void ModelSil(object sender, EventArgs e)
        {
            if (listView3.SelectedItems.Count == 0)
                return;

            var sonuc = MessageBox.Show("Se�ilen Model Silinsin Mi?", "Silmeyi Onayla", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (sonuc != DialogResult.Yes)
                return;

            var model = listView3.SelectedItems[0];
            var s = model.Tag as Model;

            var marka = listView1.SelectedItems[0].Tag as Marka;

            var res = BL.BusinessModelSil(marka.Marka_ID, s.ModelSegment_ID, s.Model_ID);
            if (res == false)
                HataG�ster();
            else
                listView3.Items.Remove(model);
        }

        void ModeliListeyeEkle(Model mo)
        {

            ListViewItem model = new ListViewItem(new string[]
            {

                mo.Model_Adi,
                mo.Model_Yil.ToString(),
                mo.Model_Hacim.ToString(),
                mo.Model_Beygir.ToString(),
                mo.Model_Renk,
                mo.Model_Fiyat.ToString(),
                mo.Model_Stok,
                mo.Model_Aciklama

            });

            model.Tag = mo;

            listView3.Items.Add(model);
        }

        void ModeliListele(Segment s)
        {
            listView3.Items.Clear();
            foreach (var e in s.Modeller)
                ModeliListeyeEkle(e);
        }

        private void ModelleriListele(object sender, EventArgs e)
        {
            listView3.Items.Clear();
            if (listView2.SelectedItems.Count == 0)
            {
                return;
            }

            var marka = listView1.SelectedItems[0].Tag as Marka;
            var segment = listView2.SelectedItems[0].Tag as Segment;

            var res = BL.BusinessSegmentinModeliniListele(marka.Marka_ID, segment.Segment_ID);

            if (res == false)
                HataG�ster();
            else
            {
                ModeliListele(segment);
            }
        }
    }
}