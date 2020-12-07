using System.Windows.Forms;
using System.Drawing;


namespace SuperJet_2._1.Toolbox
{
    class My_Label: Label
    {
        public Label Create_MyLabel(int height, int widgth, int x, int y, string text)
        {
            Size = new Size(widgth, height);
            Location = new Point(x, y);
            Text = text;
            return this;
        }
    }
}
