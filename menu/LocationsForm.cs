using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menu
{
    public partial class LocationsForm : Form
    {
        public LocationsForm()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            //if (currencyManager.Position > 0)
            // {
            // --currencyManager.Position;
            //}
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            //if (currencyManager.Position < currencyManager.Count - 1)
            //{
            //   ++currencyManager.Position;
            //}
        }
    }
}
