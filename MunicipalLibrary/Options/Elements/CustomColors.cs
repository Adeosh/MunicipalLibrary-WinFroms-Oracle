using System;
using System.Drawing;
using System.Windows.Forms;

namespace MunicipalLibrary.Options.Elements
{
    public class CustomColors : ProfessionalColorTable
    {
        public override Color MenuItemSelected
        {
            get { return Color.FromArgb(107, 203, 203); }
        }
        public override Color MenuItemSelectedGradientBegin
        {
            get { return Color.FromArgb(76, 84, 84); }
        }
        public override Color MenuItemSelectedGradientEnd
        {
            get { return Color.FromArgb(156, 156, 164); }
        }
    }
}
