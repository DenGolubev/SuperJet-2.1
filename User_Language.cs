using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Forms;

namespace SuperJet_2._1
{
    class User_Language
    {
        protected InputLanguage user_RU_language = InputLanguage.FromCulture(new CultureInfo("ru-RU"));
        protected InputLanguage user_US_language = InputLanguage.FromCulture(new CultureInfo("en-US"));
        

       
        public void input_RU_language()
        {
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("ru-RU"));
               
        }

        public void input_US_language()
        {
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("en-US"));
        }

    }
}
