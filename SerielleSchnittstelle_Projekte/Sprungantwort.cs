using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerielleSchnittstelle_Projekte
{
    public class Sprungantwort : Regler
    {
        public Sprungantwort(string _displayName, Color _displayColor)
        {
            this.displayColor = _displayColor;
            this.displayName = _displayName;
        }
    }
}
