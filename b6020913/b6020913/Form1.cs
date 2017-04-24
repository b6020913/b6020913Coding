namespace b6020913
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using MyDialogs; // This is for the configure box so the delay can be set
    using System.IO; // Calls the System Input Output functionality

    public partial class Frm_Main : Form
    {
        string Str_KeyStrokes;
        bool Bool_First_Visit = true;
        bool[] Bool_IsButtonPressed = new bool[0x13];
        bool Boolean_Requires_Saving = false;
        int Int_My_List_Index;
        ListBox Lst_Global_Listbox = new ListBox();
        int Int_Interval_Required = 500;
        bool[] boolsButtonPressed = new bool[19];
        string Str_Present_File_Path_Name = "";
        public Frm_Main()
        {
            InitializeComponent(); // Initializes the form
        }

        private void btn_Previous_Click(object sender, EventArgs e) // If the 'Previous' button is clicked then;
        {
            if (this.txt_Mode.Text == "Multi-Press") // If the Mode text says Multi-Press then;
            {
                if (this.txt_Word.Text.Length > 0) // If the word length is more than 0 then;
                {
                    try // Tries this code then passes any errors to the catch
                    {
                        this.txt_Word.Text = this.txt_Word.Text.Remove(this.txt_Word.Text.Length - 1); // Removes 1 from then length of txt_Word
                        this.Str_KeyStrokes = this.Str_KeyStrokes.Remove(this.Str_KeyStrokes.Length - 1); // Removes 1 from then length of Str_KeyStrokes
                        this.txt_KeysPressed.Text = this.Str_KeyStrokes; // Assigns the KeysPressed variable to Str_KeyStrokes
                    }
                    catch { } // Catches any exceptions occurring
                }
            

            }
        }

        private void btn_0_Click(object sender, EventArgs e) // If the '0' button is clicked then;
        {
            this.Boolean_Requires_Saving = true; // This sets the boolean value of Boolean_Requires_Saving to true
            if (this.txt_Word.Text.Length > 0) // If the word length is more than 0 then;
            {
                    this.txt_Writing_Pad.AppendText(this.txt_Word.Text + " ");
                    for (int i = 0; i == (this.txt_Word.Text.Length); i++)
                    {
                        this.txt_Writing_Pad.AppendText(Convert.ToString(this.txt_Word.Text[i])); //Converts the input box to a string and assigns it to the txt_Writing_Pad
                    }
                    
                    this.txt_Word.Clear(); // Clears the txt_Word input box
                    this.Str_KeyStrokes = ""; // Sets the Str_KeyStrokes varaible as nothing
                    this.txt_KeysPressed.Text = this.Str_KeyStrokes; // Assigns the KeysPressed variable to Str_KeyStrokes
                }
            }

        private bool Different_Button_Pressed(int Button_Pressed) // Checks to see if another button is pressed
        {
            return (!this.Bool_First_Visit && !this.Bool_IsButtonPressed[Button_Pressed]); // Returns if the Bool_First_Visit and Bool_IsButtonPressed both equat to true
        }

        private void Which_Button(object sender, EventArgs e, Button which_button, ListBox which_listBox, ListBox which_Dictionary, int which_Button_Number) // This checks to see which button was pressed
        {
            if (this.Different_Button_Pressed(which_button.TabIndex)) // If the Different_Button_Pressed returns something then;
            {
                this.Within_Timer_Tick(sender, e); // Ticks the Timer named Within_Timer
            }
            if (!(this.txt_Mode.Text == "Multi-Press")) // If the Mode text reads 'Multi-Press' then;
            {
                switch (which_Button_Number) // Which button was pressed
                {
                    case 10:
                        this.Str_KeyStrokes = this.Str_KeyStrokes + "*"; // Adds a asterisk to Str_KeyStrokes
                        goto Label_Test;

                    case 11:
                        this.Str_KeyStrokes = this.Str_KeyStrokes + "#"; // Adds a hashtag to Str_KeyStrokes
                        goto Label_Test;
                }
                this.Str_KeyStrokes = this.Str_KeyStrokes + Convert.ToString(which_Button_Number); //Converts Str_KeyStrokes to string
            }
            else
            {
                if (!this.Bool_First_Visit) //If Bool_First_Visit is true then;
                {
                    this.Within_Timer.Enabled = false; // Does not enable the timer
                    this.Int_My_List_Index++; // Adds to Int_My_List_Index
                    if (this.Int_My_List_Index > (which_listBox.Items.Count - 1)) // If Int_My_List_Index is bigger than which_listBox items - 1 then;
                    {
                        this.Int_My_List_Index = 0; // Sets Int_My_List_Index to 0
                    }
                    try // Tries code and catch any errors
                    {
                        this.txt_Word.Text = this.txt_Word.Text.Remove(this.txt_Word.Text.Length - 1); // Removes the txt_Word text and minuses 1 from the length
                        this.txt_Word.AppendText(Convert.ToString(which_listBox.Items[this.Int_My_List_Index])); //Converts which_listBox to a string
                        this.Within_Timer.Enabled = true; //Enables the timer
                        return;
                    }
                    catch { } // Catches any exceptions
                }
                    this.Bool_First_Visit = false; // Sets Bool_First_Visit to false
                    this.Within_Timer.Enabled = true;
                    this.txt_Word.AppendText(Convert.ToString(which_listBox.Items[this.Int_My_List_Index]));

                for (int i = 0; i <= (which_listBox.Items.Count - 1); i++)
                {
                    this.Lst_Global_Listbox.Items.Add(Convert.ToString(which_listBox.Items[i])); //Adds which_listBox to Lst_Global_Listbox
                }
                this.Bool_IsButtonPressed[which_button.TabIndex] = true; //Sets Bool_IsButtonPressed to true
                switch (which_Button_Number)
                {
                    case 10:
                        this.Str_KeyStrokes = this.Str_KeyStrokes + "*";
                        break;

                    case 11:
                        this.Str_KeyStrokes = this.Str_KeyStrokes + "#";
                        break;

                    default:
                        this.Str_KeyStrokes = this.Str_KeyStrokes + Convert.ToString(which_Button_Number);
                        break;
                }
                this.txt_KeysPressed.Text = this.Str_KeyStrokes;
                return;
            }
            Label_Test:
            this.txt_KeysPressed.Text = this.Str_KeyStrokes;
            this.txt_KeysPressed.Text.Substring(0, 1);
        }

        private void Within_Timer_Tick(object sender, EventArgs e) // Method for the Timer Tick
        {
            try
            {
                this.Within_Timer.Enabled = false;
                this.Bool_First_Visit = true;
                this.txt_Word.Text = this.txt_Word.Text.Remove(this.txt_Word.Text.Length - 1);


            if (Convert.ToString(this.Lst_Global_Listbox.Items[this.Int_My_List_Index]) == "~")
            {
                this.txt_Word.AppendText(",");
            }
            else
            {
                this.txt_Word.AppendText(Convert.ToString(this.Lst_Global_Listbox.Items[this.Int_My_List_Index]));
            }
            this.txt_Word.Focus(); //Focuses on the txt_Word box so it can be typed into
            this.Int_My_List_Index = 0; //Sets Int_My_List_Index to 0
            this.Lst_Global_Listbox.Items.Clear(); // Clears Lst_Global_Listbox items
            for (int i = 0; i <= 0x12; i++)
            {
                this.Bool_IsButtonPressed[i] = false;
            }
            }
            catch { }

        }

        private void btn_2_Click(object sender, EventArgs e) // If button 2 is clicked then;
        {
            this.Which_Button(sender, e, this.btn_2, this.listBox_2, this.listBox_Dictionary_Key_2, 2);
        }

        private void btn_1_Click(object sender, EventArgs e) // If button 1 is clicked then;
        {
            this.Which_Button(sender, e, this.btn_1, this.listBox_1, this.listBox_Dictionary_Key_1, 1);
        }
        private void btn_3_Click(object sender, EventArgs e) // If button 3 is clicked then;
        {
            this.Which_Button(sender, e, this.btn_3, this.listBox_3, this.listBox_Dictionary_Key_3, 3);
        }

        private void btn_4_Click(object sender, EventArgs e) // If button 4 is clicked then;
        {
            this.Which_Button(sender, e, this.btn_4, this.listBox_4, this.listBox_Dictionary_Key_4, 4);
        }

        private void btn_5_Click(object sender, EventArgs e) // If button 5 is clicked then;
        {
            this.Which_Button(sender, e, this.btn_5, this.listBox_5, this.listBox_Dictionary_Key_5, 5);
        }

        private void btn_6_Click(object sender, EventArgs e) // If button 6 is clicked then;
        {
            this.Which_Button(sender, e, this.btn_6, this.listBox_6, this.listBox_Dictionary_Key_6, 6);
        }

        private void btn_7_Click(object sender, EventArgs e) // If button 7 is clicked then;
        {
            this.Which_Button(sender, e, this.btn_7, this.listBox_7, this.listBox_Dictionary_Key_7, 7);
        }

        private void btn_8_Click(object sender, EventArgs e) // If button 8 is clicked then;
        {
            this.Which_Button(sender, e, this.btn_8, this.listBox_8, this.listBox_Dictionary_Key_8, 8);
        }

        private void btn_9_Click(object sender, EventArgs e) // If button 9 is clicked then;
        {
            this.Which_Button(sender, e, this.btn_9, this.listBox_9, this.listBox_Dictionary_Key_9, 9);
        }

        private void btn_Hashtag_Click(object sender, EventArgs e) // If button hashtag is clicked then;
        {
            this.Which_Button(sender, e, this.btn_Hashtag, this.listBox_Hashtag, this.listBox_Dictionary_Key_Hash, 11);
        }

        private void btn_Punctuation_Click(object sender, EventArgs e) // If button punctuation is clicked then;
        {
            this.Which_Button(sender, e, this.btn_Punctuation, this.listBox_Punctuation, this.listBox_Dictionary_Key_Quote, 10);
        }

        private void btn_Mode_Click(object sender, EventArgs e) // If button mode is clicked then;
        {
            if (this.txt_Mode.Text == "Multi-Press") //If the text says Multi-Press then;
            {
                this.txt_Mode.Text = "Prediction"; //Changes the text to Prediction
            }
            else
            {
                this.txt_Mode.Text = "Multi-Press"; //Changes the text to Multi-Press
            }
        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            Within_Timer.Interval = Int_Interval_Required; //Sets Within_Timer.Interval as Int_Interval_Required
            for (int intWhichButton = 0; intWhichButton <= 18; intWhichButton++)
                boolsButtonPressed[intWhichButton] = false; // boolsButtonPressed is set to false
        }

        private void btn_Enter_Click(object sender, EventArgs e) // If button Enter is clicked then;
        {
            this.Boolean_Requires_Saving = true;
            this.txt_Writing_Pad.AppendText(Environment.NewLine);
        }

        private void strip_New_Click(object sender, EventArgs e) // If the menu strip New is clicked then;
        {
            if (this.Boolean_Requires_Saving == true); // If Boolean_Requires_Saving is true;
            {
                this.strip_Save_Click(sender, e); // Goes to the strip_Save_CLick method
            }
            this.txt_Writing_Pad.Clear(); // Clears the writing pad
        }

        private void strip_Save_Click(object sender, EventArgs e) // If the menu strip Save is clicked then;
        {
            if (this.txt_Writing_Pad.Text != "")
            {
                this.SaveFile.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"; // Filter for the file type
                this.SaveFile.FilterIndex = 2; // Sets the filter index as 2

                if (SaveFile.ShowDialog() == System.Windows.Forms.DialogResult.OK) // If the Save dialog goes OK then;
                {
                    File.WriteAllText(SaveFile.FileName, txt_Writing_Pad.Text); // Saves the writing pad text to a file
                }
            }
        }

        private void strip_SaveAs_Click(object sender, EventArgs e) // If the menu strip Save As is clicked then;
        {
            if (this.txt_Writing_Pad.Text != "")
            {
                this.SaveFile.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                this.SaveFile.FilterIndex = 2;

                if (SaveFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    File.WriteAllText(SaveFile.FileName, txt_Writing_Pad.Text);
                }
            }
            Boolean_Requires_Saving = false;
        }

        private void strip_Open_Click(object sender, EventArgs e) // If the menu strip Open is clicked then;
        {
            try
            {
                if (Boolean_Requires_Saving == true) ; // If Boolean_Requires_Saving is true then;
                {
                    this.strip_Save_Click(sender, e); // Goes to the strip_Save_Click method
                }
                Boolean_Requires_Saving = false;
                this.openFileDialog.ShowDialog(); // Initializes the openFileDialog dialog box
                this.Str_Present_File_Path_Name = this.openFileDialog.FileName; // Assigns Str_Present_File_Path_Name to openFileDialog.FileName
                if (this.Str_Present_File_Path_Name != "")
                {
                    txt_Writing_Pad.Text = File.ReadAllText(openFileDialog.FileName); // Reads all the text from the opened file and puts it in the Writing Pad
                }
            }
            catch { }
        }

        private void strip_Configure_Click(object sender, EventArgs e) // If the menu strip Open is clicked then;
        {
            try
            {
                int delay = Convert.ToInt16(My_Dialogs.InputBox("Enter a delay value you require, 1000 is equal to 1 second meaning 5000 is 5 seconds. The current delay value is " + this.Int_Interval_Required + ".")); // Opens the dialog for the delay set
            if (delay < 500) // If the delay is less than 500
            {
                delay = 500; //Sets the delay to 500
            }
            this.Within_Timer.Interval = delay; // Sets Within_Timer.Interval as delay
            this.Int_Interval_Required = delay; // Sets Int_Interval_Required as delay
            }
            catch { }
        }

        private void strip_Exit_Click(object sender, EventArgs e) //If the menu strip Exit is clicked then;
        {
            base.Close(); //Closes the form
        }
    }
}

