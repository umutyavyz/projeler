using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaYönetim
{
    public class Film
    {
        public string Ad { get; set; }
        public string Yönetmen { get; set; }
        public string Tür { get; set; }
        public string ResimYolu { get; set; }

        public override string ToString()
        {
            return Ad;
        }
    }

}
