using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniKeyboard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ModeClick_Click(object sender, EventArgs e)
        {
            if(this.ModeTxt.Text == "Multi-Press")
            {
                this.ModeTxt.Text = "Prediction";
            }
            else
            {
                this.ModeTxt.Text = "Multi-Press";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            this.Button_Reponse(sender, e, this.btn7, this.listBoxKey7, 7);
        }
        private void Button_Reponse(object sender, EventArgs e, Button button_clicked, ListBox which_listbox, int button_case_number)
        {
            
        }
      
    }
}
