using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperJet_2._1.Toolbox
{
    class My_openfiledialog
    {
        

        public My_openfiledialog(string file_name)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if(openFile.ShowDialog() == DialogResult.OK)
            {
                file_name = openFile.FileName;
            }
        }
    }
}
