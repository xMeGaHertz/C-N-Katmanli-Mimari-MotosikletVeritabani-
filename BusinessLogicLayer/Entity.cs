using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public static class Entity
    {
        public class Marka
        {
            public string Marka_ID { get; set; }

            public string Marka_Adi { get; set; }

            public List<Segment> Segmentler = new List<Segment>();
        }

        public class Segment
        {
            public string SegmentMarka_ID { get; set; }

            public string Segment_ID { get; set; }

            public string Segment_Adi { get; set; }

            public List<Model> Modeller = new List<Model>();
        }

        public class Model
        {
            public string Model_ID { get; set; }

            public string ModelSegment_ID { get; set; }

            public string Model_Adi { get; set; }

            public int Model_Yil { get; set; }

            public int Model_Beygir { get; set; }

            public int Model_Hacim { get; set; }

            public string Model_Renk { get; set; }

            public float Model_Fiyat { get; set; }

            public string Model_Stok { get; set; }

            public string Model_Aciklama { get; set; }
        }
    }
}
