using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyArchive.Util
{
    class LabelDisplay : ITextDisplay
    {
        ToolStripStatusLabel _label;
        public LabelDisplay(ToolStripStatusLabel label)
        {
            _label = label;
        }

        public void Show(string msg)
        {
            _label.Text = msg;
        }
    }
}
