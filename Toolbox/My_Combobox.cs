using System.Windows.Forms;
using System.Drawing;

namespace SuperJet_2._1.Toolbox
{
    class My_Combobox: ComboBox
    {
        public ComboBox Create_MyCombobox(int height, int widgth, int x, int y)
        {
            Size = new Size(widgth, height);
            Location = new Point(x, y);
            return this;
        }
    }
}
