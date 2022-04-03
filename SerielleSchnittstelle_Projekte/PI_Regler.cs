using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SerielleSchnittstelle_Projekte
{
    public class PI_Regler : Regler
    {
        public int Kr { get; set; }
        public int Tn { get; set; }

        public PI_Regler(int _Kr, int _Tn, int _sollwert, string _displayName, Color _displayColor)
        {
            this.Kr = _Kr;
            this.Tn = _Tn;
            this.sollwert = _sollwert;
            this.displayName = _displayName;
            this.displayColor = _displayColor;
        }
        

    }
}
