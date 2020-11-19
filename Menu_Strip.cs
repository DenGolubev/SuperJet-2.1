using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperJet_2._1
{
    class my_Menu_Strip: MenuStrip
    {
        
        
        public ToolStripMenuItem My_Menu(string menu_point)
        {
            ToolStripMenuItem fileItem = new ToolStripMenuItem(menu_point);
            return fileItem;
        }
                       
    }
}
