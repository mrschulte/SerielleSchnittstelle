using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SerielleSchnittstelle_Projekte
{
    public class P_Regler : Regler
    {
        public int Kp { get; set; }

        public P_Regler(int _Kp, int _sollwert, string _displayName, Color _displayColor)
        {
            this.Kp = _Kp;
            this.sollwert = _sollwert;
            this.displayName = _displayName;
            this.displayColor = _displayColor;
        }

    }
}
