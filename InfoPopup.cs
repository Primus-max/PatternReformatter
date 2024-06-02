using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatternReformatter
{
    public partial class InfoPopup : Form
    {
        public InfoPopup()
        {
            InitializeComponent();
        }

        private void CloseInfoPopup_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
