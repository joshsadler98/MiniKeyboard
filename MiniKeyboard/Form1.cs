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
        private bool Bool_user_first_click; //Boolean created for user first click of button
        private bool[] Bool_is_button_pressed = new bool[0x13]; //Boolean created for if the button is pressed by user
        private ListBox Global_Listbox = new ListBox();
        private int int_ListBox_Index;
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
            if (this.Was_A_Different_Button_Pressed(button_clicked.TabIndex))//Calls method to check to see if another button has been pressed by user
            {

            }
        }
        private bool Was_A_Different_Button_Pressed(int button_pressed)
        {
            return (!this.Bool_user_first_click && !this.Bool_is_button_pressed[button_pressed]);//Method created to check if another button has been pressed by the user
        }

        private void ButtonPressTimer_Tick(object sender, EventArgs e)
        {
            this.ButtonPressTimer.Enabled = false; //Sets the timer to false so that it is not running
            this.Bool_user_first_click = true; //Sets the boolean variable to true
            this.txtBoxWordView.Text = this.txtBoxWordView.Text.Remove(this.txtBoxWordView.Text.Length - 1);
            if (Convert.ToString(this.Global_Listbox.Items[this.int_ListBox_Index]) == "~")
            {
                this.txtBoxWordView.AppendText(",");
            }
            else
            {
                this.txtBoxWordView.AppendText(Convert.ToString(this.Global_Listbox.Items[this.int_ListBox_Index]));
            }
            this.int_ListBox_Index = 0; //Sets the value to 0 to reset it
            this.Global_Listbox.Items.Clear(); //Clears the items out of the listbox to reset it
            this.txtBoxWordView.Focus(); //Sets input to focus so it can get an input from the user from a mouse click
            for (int i = 0; i <= 0x10; i++)//Creates a count for the timer 
            {
                this.Bool_is_button_pressed[i] = false;//Sets variable to false
            }
        }   
    }
}
