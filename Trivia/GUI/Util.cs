using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    class Util
    {
        public static void OpenNewForm(Form newForm, Form currForm)
        {
            newForm.Location = currForm.Location;
            newForm.StartPosition = FormStartPosition.Manual;
            newForm.Closing += delegate { currForm.Close(); };
            newForm.Show();
            currForm.Hide();
        }
    }
}
