using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace health_declaration_app
{
    class classMisc
    {
        public void frmNavigate(Form frmSource, Form frmDestination)
        {
            frmSource.Close();
            frmDestination.Show();
            frmDestination.Closed += (s, args) => frmSource.Close();
        }

    }
}
