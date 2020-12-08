using System;
using System.Drawing;
using System.Windows.Forms;

namespace SuperJet_2._1.Toolbox
{
    class My_DataGridView: DataGridView
    {
        public DataGridView Create_MyDataGridView(int height, int widgth, int x, int y)
        {
            Size = new Size(widgth, height);
            Location = new Point(x, y);
            Font = new Font("Arial", 14);
            return this;
        }
    }
}
