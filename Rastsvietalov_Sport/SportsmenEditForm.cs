using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rastsvietalov_Sport
{
    public partial class SportsmenEditForm : Form
    {
        public SportsmenEditForm()
        {
            InitializeComponent();
        }

        private void SportsmenEditForm_Load(object sender, EventArgs e)
        {

        }

        private void SportsmenEditFormAcceptButton_Click(object sender, EventArgs e)
        {

            if(_edit)


            else
            {
                
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void SportsmenEditFormEscapeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
