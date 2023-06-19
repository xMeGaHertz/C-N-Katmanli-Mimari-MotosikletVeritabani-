using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using static BusinessLogicLayer.Entity;

namespace BusinessLogicLayer
{
    public static class BL
    {
        public static List<Marka> Markalar { get; set; } = new List<Marka>();

        public static string error = "";

        public static bool BusinessMarkaEkle(string marka_adi)
        {
            Marka m = new Marka()
            {
                Marka_ID = Guid.NewGuid().ToString(),
                Marka_Adi = marka_adi,
            };

            int res = DL.MarkaEkle(m.Marka_ID, m.Marka_Adi, out error);
            if (res > 0)
            {
                Markalar.Add(m);
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool BusinessMarkaDüzenle(string marka_id, string marka_adi)
        {
            Marka m = Markalar.Find(o => o.Marka_ID == marka_id);
            if (m != null)
            {
                int res = DL.MarkaDüzenle(m.Marka_ID, marka_adi, out error);
                if (res > 0)
                {
                    m.Marka_Adi = marka_adi;

                    return true;
                }
                else
                    return false;
            }
            return true;
        }

        public static bool BusinessMarkaSil(string marka_id)
        {
            int res = DL.MarkaSil(marka_id, out error);
            if (res > 0)
            {
                Marka m = Markalar.Find(o => o.Marka_ID == marka_id);
                Markalar.Remove(m);

                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool BusinessSegmentEkle(string segmentmarka_id, string segment_adi)
        {
            Marka m = Markalar.Find(o => o.Marka_ID == segmentmarka_id);
            Segment s = new Segment()
            {
                Segment_ID = Guid.NewGuid().ToString(),
                SegmentMarka_ID = segmentmarka_id,
                Segment_Adi = segment_adi
            };

            int res = DL.SegmentEkle(s.Segment_ID, segmentmarka_id, segment_adi, out error);
            if (res > 0)
                m.Segmentler.Add(s);
            return true;
        }

        public static bool BusinessSegmentDüzenle(string segmentmarka_id, string segment_id, string segment_adi)
        {
            Marka m = Markalar.Find(o => o.Marka_ID == segmentmarka_id);
            int res = DL.SegmentDüzenle(segment_id, segment_adi, out error);
            if (res > 0)
            {

                Segment s = m.Segmentler.Find(o => o.Segment_ID == segment_id);
                s.Segment_Adi = segment_adi;

                return true;

            }
            else return false;
        }

        public static bool BusinessSegmentSil(string segmentmarka_id, string segment_id)
        {
            Marka m = Markalar.Find(o => o.Marka_ID == segmentmarka_id);
            int res = DL.SegmentSil(segment_id, out error);
            if (res > 0)
            {
                Segment mo = m.Segmentler.Find(o => o.Segment_ID == segment_id);
                m.Segmentler.Remove(mo);

                return true;
            }
            else return false;

        }

        public static bool BusinessModelEkle(string marka_id, string modelsegment_id, string model_adi, int model_yil, int model_beygir, int model_hacim, string model_renk, float model_fiyat, string model_stok, string model_aciklama)
        {
            Marka marka = Markalar.Find(o => o.Marka_ID == marka_id);

            Segment s = marka.Segmentler.Find(o => o.Segment_ID == modelsegment_id);
            Model mo = new Model()
            {
                Model_ID = Guid.NewGuid().ToString(),
                ModelSegment_ID = modelsegment_id,
                Model_Adi = model_adi,
                Model_Yil = model_yil,
                Model_Beygir = model_beygir,
                Model_Hacim = model_hacim,
                Model_Renk = model_renk,
                Model_Fiyat = model_fiyat,
                Model_Stok = model_stok,
                Model_Aciklama = model_aciklama
            };

            int res = DL.ModelEkle(mo.Model_ID, modelsegment_id, model_adi, model_yil, model_beygir, model_hacim, model_renk, model_fiyat, model_stok, model_aciklama, out error);
            if (res > 0)
                s.Modeller.Add(mo);
            return true;
        }

        public static bool BusinessModelDüzenle(string marka_id, string modelsegment_id, string model_id, string model_adi, int model_yil, int model_beygir, int model_hacim, string model_renk, float model_fiyat, string model_stok, string model_aciklama)
        {
            Marka marka = Markalar.Find(o => o.Marka_ID == marka_id);

            Segment s = marka.Segmentler.Find(o => o.Segment_ID == modelsegment_id);
            int res = DL.ModelDüzenle(model_id, model_adi, model_yil, model_beygir, model_hacim, model_renk, model_fiyat, model_stok, model_aciklama, out error);
            if (res > 0)
            {

                Model mo = s.Modeller.Find(o => o.Model_ID == model_id);
                mo.Model_Adi = model_adi;
                mo.Model_Yil = model_yil;
                mo.Model_Beygir = model_beygir;
                mo.Model_Hacim = model_hacim;
                mo.Model_Renk = model_renk;
                mo.Model_Fiyat = model_fiyat;
                mo.Model_Stok = model_stok;
                mo.Model_Aciklama = model_aciklama;

                return true;

            }
            else return false;
        }

        public static bool BusinessModelSil(string marka_id, string modelsegment_id, string model_id)
        {
            Marka marka = Markalar.Find(o => o.Marka_ID == marka_id);

            Segment s = marka.Segmentler.Find(o => o.Segment_ID == modelsegment_id);
            int res = DL.ModelSil(model_id, out error);
            if (res > 0)
            {
                Model mo = s.Modeller.Find(o => o.Model_ID == model_id);
                s.Modeller.Remove(mo);

                return true;
            }
            else return false;

        }

        public static bool BusinessMarkaListele()
        {
            var list = DL.MarkaListele(out string error);
            if (list == null)
                return false;

            Markalar = new List<Marka>();
            foreach (var e in list)
            {
                Markalar.Add(new Marka()
                {
                    Marka_ID = e.marka_id,
                    Marka_Adi = e.marka_adi,
                });

            }
            return true;
        }

        public static bool BusinessMarkanınSegmentiniListele(string segmentmarka_id)
        {
            var list = DL.MarkanınSegmentiniListele(segmentmarka_id, out error);
            if (list == null)
                return false;

            var marka = Markalar.Find(o => o.Marka_ID == segmentmarka_id);
            marka.Segmentler = new List<Segment>();

            foreach (var e in list)
            {
                marka.Segmentler.Add(new Segment()
                {
                    Segment_ID = e.segment_id,
                    SegmentMarka_ID = segmentmarka_id,
                    Segment_Adi = e.segment_adi,
                });

            }
            return true;
        }

        public static bool BusinessSegmentinModeliniListele(string marka_id, string modelsegment_id)
        {
            var list = DL.SegmentinModeliniListele(modelsegment_id, out error);
            if (list == null || list.Count == 0)
                return false;

            Marka marka = Markalar.Find(o => o.Marka_ID == marka_id);

            var segment = marka.Segmentler.Find(o => o.Segment_ID == modelsegment_id);
            segment.Modeller = new List<Model>();

            foreach (var e in list)
            {

                segment.Modeller.Add(new Model()
                {
                    Model_ID = e.model_id,
                    ModelSegment_ID = modelsegment_id,
                    Model_Adi = e.model_adi,
                    Model_Yil = e.model_yil,
                    Model_Hacim = e.model_hacim,
                    Model_Beygir = e.model_beygir,
                    Model_Renk = e.model_renk,
                    Model_Fiyat = e.model_fiyat,
                    Model_Stok = e.model_stok,
                    Model_Aciklama = e.model_aciklama,
                });

            }
            return true;
        }
    }
}
