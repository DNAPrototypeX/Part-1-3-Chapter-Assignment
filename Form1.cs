using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part_1_3_Chapter_Assignment
{
    public partial class Main : Form
    {
        int height = 0;
        string name = "";
        decimal age = 0;
        string lifeExpectancyMsg = "";
        string heightDifferenceMsg = "";

        public Main()
        {
            InitializeComponent();         
        }

        private void tkbrHeight_ValueChanged(object sender, EventArgs e)
        {
            height = tkbrHeight.Value;
            lblHeight.Text = $"Height: {height / 100.0}m";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            height = tkbrHeight.Value;
            name = txtName.Text;
            age = nudAge.Value;
            
            if (age >= 82)
                lifeExpectancyMsg = $"you have already surpassed the average life expectancy in Canada by {age - 82} years";
            else
                lifeExpectancyMsg = $"you have {82 - age} years until you reach the average life expectancy in Canada";
            
            if (height == 251)
                heightDifferenceMsg = "you are the same height as the tallest person alive at 2.51m";
            else
                heightDifferenceMsg = $"you are {(251 - height) / 100.0}m shorter than the tallest person alive";

            lblMessage.Text = $"Hello {name}, {lifeExpectancyMsg}, and {heightDifferenceMsg}.";
            tkbrHeight.Enabled = false;
            nudAge.Enabled = false;
            txtName.Enabled = false;
            btnSubmit.Enabled = false;
        }
    }
}
