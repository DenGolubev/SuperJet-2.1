using System.Windows.Forms;
using System.Drawing;

namespace SuperJet_2._1.Toolbox
{
    class My_Button: Button
    {
        
        public Button Create_MyButton(int height, int widgth, int x, int y, string text)
        {
            Size = new Size(widgth, height);
            Location = new Point(x, y);
            Font = new Font("Arial", 16);
            Text = text;
            return this;
        }
    }
}
