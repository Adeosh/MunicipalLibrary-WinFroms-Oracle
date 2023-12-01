using System;
using System.Windows.Forms;

namespace MunicipalLibrary.Options.Elements
{
    public class CustomRender : ToolStripProfessionalRenderer
    {
        public CustomRender() : base(new CustomColors()) { }
    }
}
