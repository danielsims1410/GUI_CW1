using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_CW1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent(); //Initialises Form2
        }

        private void btnClose_Click(object sender, EventArgs e) //If "Close" is clicked
        {
            Close(); //Closes the form 
        }

        private void KeepFocusMD(object sender, MouseEventArgs e) //Function to run when either 'demo' button is pressed
        {
            btnClose.Focus(); //Focus is redirected straight to the Close button
        }
    }
}
