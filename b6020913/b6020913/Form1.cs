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
        bool[] Bool_IsButtonPresssed = new bool[0x13];
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
            return (!this.Bool_First_Visit && !this.Bool_IsButtonPresssed[Button_Pressed]); // Returns if the Bool_First_Visit and Bool_IsButtonPressed both equat to true
        }

        private void Which_Button(object sender, EventArgs e, Button which_button, ListBox which_listBox, ListBox which_Dictionary, int which_Button_Number)
        {
            if (this.Different_Button_Pressed(which_button.TabIndex))
            {
                this.Within_Timer_Tick(sender, e);
            }
            if (!(this.txt_Mode.Text == "Multi-Press"))
            {
                switch (which_Button_Number)
                {
                    case 10:
                        this.Str_KeyStrokes = this.Str_KeyStrokes + "*";
                        goto Label_Test;

                    case 11:
                        this.Str_KeyStrokes = this.Str_KeyStrokes + "#";
                        goto Label_Test;
                }
                this.Str_KeyStrokes = this.Str_KeyStrokes + Convert.ToString(which_Button_Number);
            }
            else
            {
                if (!this.Bool_First_Visit)
                {
                    this.Within_Timer.Enabled = false;
                    this.Int_My_List_Index++;
                    if (this.Int_My_List_Index > (which_listBox.Items.Count - 1))
                    {
                        this.Int_My_List_Index = 0;
                    }
                    try
                    {
                        this.txt_Word.Text = this.txt_Word.Text.Remove(this.txt_Word.Text.Length - 1);
                        this.txt_Word.AppendText(Convert.ToString(which_listBox.Items[this.Int_My_List_Index]));
                        this.Within_Timer.Enabled = true;
                        return;
                    }
                    catch { }
                }
                    this.Bool_First_Visit = false;
                    this.Within_Timer.Enabled = true;
                    this.txt_Word.AppendText(Convert.ToString(which_listBox.Items[this.Int_My_List_Index]));

                for (int i = 0; i <= (which_listBox.Items.Count - 1); i++)
                {
                    this.Lst_Global_Listbox.Items.Add(Convert.ToString(which_listBox.Items[i]));
                }
                this.Bool_IsButtonPresssed[which_button.TabIndex] = true;
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

        private void Within_Timer_Tick(object sender, EventArgs e)
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
            this.txt_Word.Focus();
            this.Int_My_List_Index = 0;
            this.Lst_Global_Listbox.Items.Clear();
            for (int i = 0; i <= 0x12; i++)
            {
                this.Bool_IsButtonPresssed[i] = false;
            }
            }
            catch { }

        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            this.Which_Button(sender, e, this.btn_2, this.listBox_2, this.listBox_Dictionary_Key_2, 2);
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            this.Which_Button(sender, e, this.btn_1, this.listBox_1, this.listBox_Dictionary_Key_1, 1);
        }
        private void btn_3_Click(object sender, EventArgs e)
        {
            this.Which_Button(sender, e, this.btn_3, this.listBox_3, this.listBox_Dictionary_Key_3, 3);
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            this.Which_Button(sender, e, this.btn_4, this.listBox_4, this.listBox_Dictionary_Key_4, 4);
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            this.Which_Button(sender, e, this.btn_5, this.listBox_5, this.listBox_Dictionary_Key_5, 5);
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            this.Which_Button(sender, e, this.btn_6, this.listBox_6, this.listBox_Dictionary_Key_6, 6);
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            this.Which_Button(sender, e, this.btn_7, this.listBox_7, this.listBox_Dictionary_Key_7, 7);
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            this.Which_Button(sender, e, this.btn_8, this.listBox_8, this.listBox_Dictionary_Key_8, 8);
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            this.Which_Button(sender, e, this.btn_9, this.listBox_9, this.listBox_Dictionary_Key_9, 9);
        }

        private void btn_Hashtag_Click(object sender, EventArgs e)
        {
            this.Which_Button(sender, e, this.btn_Hashtag, this.listBox_Hashtag, this.listBox_Dictionary_Key_Hash, 11);
        }

        private void btn_Punctuation_Click(object sender, EventArgs e)
        {
            this.Which_Button(sender, e, this.btn_Punctuation, this.listBox_Punctuation, this.listBox_Dictionary_Key_Quote, 10);
        }

        private void btn_Mode_Click(object sender, EventArgs e)
        {
            if (this.txt_Mode.Text == "Multi-Press")
            {
                this.txt_Mode.Text = "Prediction";
            }
            else
            {
                this.txt_Mode.Text = "Multi-Press";
            }
        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            Within_Timer.Interval = Int_Interval_Required;
            for (int intWhichButton = 0; intWhichButton <= 18; intWhichButton++)
                boolsButtonPressed[intWhichButton] = false;
        }

        private void btn_Enter_Click(object sender, EventArgs e)
        {
            this.Boolean_Requires_Saving = true;
            this.txt_Writing_Pad.AppendText(Environment.NewLine);
        }

        private void strip_New_Click(object sender, EventArgs e)
        {
            if (this.Boolean_Requires_Saving == true);
            {
                this.strip_Save_Click(sender, e);
            }
            this.txt_Writing_Pad.Clear();
        }

        private void strip_Save_Click(object sender, EventArgs e)
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
        }

        private void strip_SaveAs_Click(object sender, EventArgs e)
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

        private void strip_Open_Click(object sender, EventArgs e)
        {
            try
            {
                if (Boolean_Requires_Saving == true);
                {
                    this.strip_Save_Click(sender, e);
                }
                Boolean_Requires_Saving = false;
                this.openFileDialog.ShowDialog();
                this.Str_Present_File_Path_Name = this.openFileDialog.FileName;
                if (this.Str_Present_File_Path_Name != "")
                {
                    txt_Writing_Pad.Text = File.ReadAllText(openFileDialog.FileName);
                }
            }
            catch { }
        }

        private void strip_Configure_Click(object sender, EventArgs e)
        {
            try
            {
                int delay = Convert.ToInt16(My_Dialogs.InputBox("Enter a delay value you require, 1000 is equal to 1 second meaning 5000 is 5 seconds. The current delay value is " + this.Int_Interval_Required + "."));
            if (delay < 500)
            {
                delay = 500;
            }
            this.Within_Timer.Interval = delay;
            this.Int_Interval_Required = delay;
            }
            catch { }
        }

        private void strip_Exit_Click(object sender, EventArgs e)
        {
            base.Close();
        }
    }
}

