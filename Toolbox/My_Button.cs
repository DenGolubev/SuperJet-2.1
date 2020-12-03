using System.Windows.Forms;
using System.Drawing;

namespace SuperJet_2._1.Toolbox
{
    class My_Button: Button
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int MyWidgth { get; set; }
        public int MyHeight { get; set; }

        public Button Create_MyButton()
        {
            Size = new Size(MyWidgth, MyHeight);
            Location = new Point(X, Y);
            Font = new Font("Arial", 16);
            return this;
        }
    }
}
