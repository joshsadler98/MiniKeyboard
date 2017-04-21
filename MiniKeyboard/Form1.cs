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
        private bool Bool_user_first_click = true; //Boolean created for user first click of button
        private bool[] Bool_is_button_pressed = new bool[0x100]; //Arrary created for if the button is pressed by user
        private ListBox Global_Listbox = new ListBox(); //Creates a private listBox with the variable name Global_Listbox
        private int int_ListBox_Index;
        private string Str_KeyStrokes; //String variable created for 
        private int Int_Interval_Required = 700;
        private int Int_NumberOfCharacters;
        public Form1()
        {
            InitializeComponent();
        }

        private void ModeClick_Click(object sender, EventArgs e)
        {
            if (this.ModeTxt.Text == "Multi-Press") //Method created to change text between multi-press and prediction when user clicks button
            {
                this.ModeTxt.Text = "Prediction";
            }
            else
            {
                this.ModeTxt.Text = "Multi-Press";
            }
        }

        private void Button_Reponse(object sender, EventArgs e, Button button_clicked, ListBox which_listbox, int button_case_number)
        {
            if (this.Was_A_Different_Button_Pressed(button_clicked.TabIndex))//Calls method to check to see if another button has been pressed by user
            {
                this.ButtonPressTimer_Tick(sender, e);
            }
            if (!(this.ModeTxt.Text == "Multi-Press" | this.ModeTxt.Text == "Prediction")) //Allows characters to be displayed in both modes
            {
                this.Str_KeyStrokes = this.Str_KeyStrokes + Convert.ToString(button_case_number); //Uses the variable Str_KeyStrokes for when the user clicks one of the character buttons the key number will be appeneded to this variable
            }
            else
            {
                if (!this.Bool_user_first_click)
                {
                    this.ButtonPressTimer.Enabled = false;
                    this.int_ListBox_Index++;
                    if (this.int_ListBox_Index > (which_listbox.Items.Count - 1))
                    {
                        this.int_ListBox_Index = 0;
                    }
                    this.txtBoxWordView.Text = this.txtBoxWordView.Text.Remove(this.txtBoxWordView.Text.Length - 1); //Changes the text of the rich text box
                    this.txtBoxWordView.AppendText(Convert.ToString(which_listbox.Items[this.int_ListBox_Index])); //Changes the text depending on which list character
                    this.ButtonPressTimer.Enabled = true; //Enables the timer
                    return;
                }
                this.Bool_user_first_click = false;
                this.ButtonPressTimer.Enabled = true;
                this.txtBoxWordView.AppendText(Convert.ToString(which_listbox.Items[this.int_ListBox_Index])); //Changes the text in the wordView textbox to the first character in the list
                for (int i = 0; i <= (which_listbox.Items.Count - 1); i++)
                {
                    this.Global_Listbox.Items.Add(Convert.ToString(which_listbox.Items[i])); //Gets how many times the user clicks the button and matches it to the correct character in the list
                }
                this.Bool_is_button_pressed[button_clicked.TabIndex] = true;
                this.Str_KeyStrokes = this.Str_KeyStrokes + Convert.ToString(button_case_number); //sets the variable Str_KeyStrokes to the specific key number 
                return;
            }
        }
        private bool Was_A_Different_Button_Pressed(int Button_Pressed)
        {
            return (!this.Bool_user_first_click && !this.Bool_is_button_pressed[Button_Pressed]);//Method created to check if another button has been pressed by the user
        }

        private void ButtonPressTimer_Tick(object sender, EventArgs e)
        {
            this.ButtonPressTimer.Enabled = false; //Sets the timer to false so that it is not running
            this.Bool_user_first_click = true; //Sets the boolean variable to true
            try
            {
                this.txtBoxWordView.Text = this.txtBoxWordView.Text.Remove(this.txtBoxWordView.Text.Length - 1);
            }
            catch { }
            if (Convert.ToString(this.Global_Listbox.Items[this.int_ListBox_Index]) == "~")
            {
                this.txtBoxWordView.AppendText(",");//Changes the text to output "," instead of ~
            }
            else
            {
                this.txtBoxWordView.AppendText(Convert.ToString(this.Global_Listbox.Items[this.int_ListBox_Index]));
            }
            this.int_ListBox_Index = 0; //Sets the value to 0 to reset it
            this.Global_Listbox.Items.Clear(); //Clears the items out of the listbox to reset it
            this.txtBoxWordView.Focus(); //Sets input to focus so it can get an input from the user from a mouse click
            for (int i = 0; i <= 0x20; i++)//Creates a count for the timer 
            {
                this.Bool_is_button_pressed[i] = false;//Sets variable to false
            }
        }

        #region Character Button Click Methods
        private void btn1_Click(object sender, EventArgs e)
        {
            this.Button_Reponse(sender, e, this.btn1, this.listBoxKey1, 1);//Passes variables (to button response method) for clicking button 1 to get a specfiic response for that button
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            this.Button_Reponse(sender, e, this.btn2, this.listBoxKey2, 2);//Passes variables (to button response method) for clicking button 2 to get a specfiic response for that button
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            this.Button_Reponse(sender, e, this.btn3, this.listBoxKey3, 3);//Passes variables (to button response method) for clicking button 3 to get a specfiic response for that button
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            this.Button_Reponse(sender, e, this.btn4, this.listBoxKey4, 4);//Passes variables (to button response method) for clicking button 4 to get a specfiic response for that button
        }
        private void btn5_Click(object sender, EventArgs e)
        {
            this.Button_Reponse(sender, e, this.btn5, this.listBoxKey5, 5);//Passes variables (to button response method) for clicking button 5 to get a specfiic response for that button
        }
        private void btn6_Click(object sender, EventArgs e)
        {
            this.Button_Reponse(sender, e, this.btn6, this.listBoxKey6, 6);//Passes variables (to button response method) for clicking button 6 to get a specfiic response for that button
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            this.Button_Reponse(sender, e, this.btn7, this.listBoxKey7, 7); //Passes variables (to button response method) for clicking button 7 to get a specfiic response for that button
        }
        private void btn8_Click(object sender, EventArgs e)
        {
            this.Button_Reponse(sender, e, this.btn8, this.listBoxKey8, 8);//Passes variables (to button response method) for clicking button 8 to get a specfiic response for that button
        }
        private void btn9_Click(object sender, EventArgs e)
        {
            this.Button_Reponse(sender, e, this.btn9, this.listBoxKey9, 9);//Passes variables (to button response method) for clicking button 9 to get a specfiic response for that button
        }
        private void btnAsterisk_Click(object sender, EventArgs e)
        {
            this.Button_Reponse(sender, e, this.btnAsterisk, this.listBoxKeyAsterisk, 10);//Passes variables (to button response method) for clicking the asterisk button to get a specfiic response for that button
        }

        private void btnHashTag_Click(object sender, EventArgs e)
        {
            this.Button_Reponse(sender, e, this.btnHashTag, this.listBoxKeyHashTag, 11);//Passes variables (to button response method) for clicking the hashtag button to get a specfiic response for that button
        }
        #endregion
        private void btn0_Click(object sender, EventArgs e)
        {
            if (this.txtBoxWordView.Text.Length > 0)
            {
                if (this.ModeTxt.Text == "Multi-Press")
                {
                    this.txtOutput.AppendText(this.txtBoxWordView.Text + " ");
                    for (int i = 0; i == (this.txtBoxWordView.Text.Length - 1); i++)
                        try
                        {
                            {
                                this.txtBoxWordView.Clear();
                                this.txtOutput.AppendText(Convert.ToString(this.txtBoxWordView.Text[i]));
                                break;
                            }
                        }
                        catch { }
                    this.txtBoxWordView.Clear();
                    this.Str_KeyStrokes = "";
                }
            }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            this.txtOutput.AppendText(Environment.NewLine);
        }
    }
}
