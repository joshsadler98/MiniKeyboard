﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyDialogs;
using System.IO;

namespace MiniKeyboard
{
    public partial class Form1 : Form
    {
        private bool Bool_user_first_click = true; //Boolean created for user first click of button
        private bool[] Bool_is_button_pressed = new bool[0x100]; //Arrary created for if the button is pressed by user
        private ListBox Global_Listbox = new ListBox(); //Creates a private listBox with the variable name Global_Listbox
        private int int_ListBox_Index; //Used for selecting a character from listBox
        private string Str_KeyStrokes; //String variable created for 
        private int Int_Interval_Required = 700; //Sets the variable which can be changed by user and used for the timer interval 
        private string StrFilePath = ""; // Used for changing to the file path when saving, opening a file
        private bool Bool_Saving; //Used to check if the program needs saving or not

        public Form1()
        {
            InitializeComponent();
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
                if (!this.Bool_user_first_click) //If users first click
                {
                    this.ButtonPressTimer.Enabled = false;
                    this.int_ListBox_Index++; //Creates a count
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

        #region Other Button Click Methods
        private void btn0_Click(object sender, EventArgs e)
        {
            this.Bool_Saving = true; //Sets the bool to true as it needs to be saved 
            if (this.txtBoxWordView.Text.Length > 0)
            {
                if (this.ModeTxt.Text == "Multi-Press" | this.ModeTxt.Text == "Prediction")
                {
                    this.txtOutput.AppendText(this.txtBoxWordView.Text + " "); 
                    for (int i = 0; i == (this.txtBoxWordView.Text.Length - 1); i++)
                        try //Try and catch method to stop exception from crashing program
                        {
                            {
                                this.txtBoxWordView.Clear(); 
                                this.txtOutput.AppendText(Convert.ToString(this.txtBoxWordView.Text[i])); //Sets the txt of text box txtOutput
                                break;
                            }
                        }
                        catch { }
                    this.txtBoxWordView.Clear(); 
                    this.Str_KeyStrokes = "";
                    this.txtBoxKeyStrokes.Text = this.Str_KeyStrokes; //Clears the varaible Str_KeyStrokes
                    
                }
            }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            this.txtOutput.AppendText(Environment.NewLine); //Used to create a new line in the tex box txtOutput 
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

        #endregion

        #region Menu Button Click Methods
        private void configureMenu_Click(object sender, EventArgs e)
        {
            try //Try and catch method to catch exception from crashing program
            {
                int userInput = Convert.ToInt16(My_Dialogs.InputBox("Please enter the interval delay value for the timer! 1000 is equal to a 1 second delay. Cannot be below 700. The current delay value is" + this.Int_Interval_Required + "."));
                if (userInput < 700)  //Method used to allow user to change the interval of the timer
                {
                    userInput = 700; //Does not allow the user to change it below 700
                }
                this.ButtonPressTimer.Interval = userInput; //Changes the button interval timer to that of which the user changes it too
                this.Int_Interval_Required = userInput;
            }
            catch { }
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            base.Close(); //Closes the program
        }

        private void menuSave_Click(object sender, EventArgs e)
        {
            if (this.txtOutput.Text != "")
            {
                if (this.StrFilePath == "") 
                {
                    this.menuSaveAs_Click(sender, e); //Opens the save as click event
                }
                else
                {
                    StreamWriter streamWriter = File.CreateText(this.StrFilePath); //Creates the file with the file path name
                    streamWriter.Write(this.txtOutput.Text);
                    streamWriter.Close();
                    this.Bool_Saving = false;
                }
            }
        }

        private void menuSaveAs_Click(object sender, EventArgs e)
        {
            if (this.txtOutput.Text != "")
            {
                this.saveFileD.Filter = "txt files (*.txt)|*.txt|All files (*.*|*.*"; //Sets the filter for saving a file
                this.saveFileD.FilterIndex = 2; //Sets the current filter index
                this.saveFileD.RestoreDirectory = true;
                if(this.saveFileD.ShowDialog() == DialogResult.OK) //Shows the user the dialog
                {
                    this.StrFilePath = this.saveFileD.FileName;
                    StreamWriter streamWriter = File.CreateText(this.StrFilePath); //Creates the file with the file path and the file name
                    
                        streamWriter.Write(this.txtOutput.Text);
                        streamWriter.Close();
                        this.Bool_Saving = false;
                    
                }
            }
        }
        private void menuOpen_Click(object sender, EventArgs e)
        {
            if (this.Bool_Saving)
            {
                this.menuSave_Click(sender, e); //Opens the save click event
            }
            this.openFileD.ShowDialog(); //Shows the open file diaglog
            this.StrFilePath = this.openFileD.FileName;
            if(this.StrFilePath != "")
            {
                StreamReader streamReader = File.OpenText(this.StrFilePath); //Opens the file using the file path
                try
                {
                    for (string strReader = streamReader.ReadLine(); strReader != "\0"; strReader = streamReader.ReadLine()) //strReader is set to the text of the file it is opening
                    {

                        this.txtOutput.AppendText(strReader); //changes the text of text box txtOut depending on the text from the file opened using the variable strReader
                    }
                }
                catch { }
                streamReader.Close();
            }
        }

        private void menuNew_Click(object sender, EventArgs e)
        {
            if (this.Bool_Saving)
            {
                this.menuSave_Click(sender, e); //Opens the save click event
            }
            this.txtOutput.Clear(); //Clears all the text from the text box
        }
        #endregion
    }
}
