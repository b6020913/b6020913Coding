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
    using MyDialogs;
    using System.IO;

    public partial class Frm_Main : Form
    {
        private string Str_KeyStrokes;
        private bool Bool_First_Visit = true;
        private bool[] Bool_IsButtonPresssed = new bool[0x13];
        private bool Boolean_Requires_Saving;
        private int Int_NumberOfCharacters;
        private int Int_My_List_Index;
        private ListBox Lst_Global_Listbox = new ListBox();
        public Frm_Main()
        {
            InitializeComponent();
        }
        private void AddToList(ListBox which_Dictionary_ListBox)
        {
            string[] source = new string[100];
            int index = -1;
            TextBox box = new TextBox();
            if (this.txt_Word.Text[this.txt_Word.Text.Length - 1] == ',')
            {
                this.txt_Word.Text = this.txt_Word.Text.Remove(this.txt_Word.Text.Length - 1);
                this.txt_Word.AppendText("~");
            }
            for (int i = 0; i == (which_Dictionary_ListBox.Items.Count - 1); i++)
            {
                source = Convert.ToString(which_Dictionary_ListBox.Items[i]).Split(new char[] { ',' });
                if (this.txt_KeysPressed.Text == source[0])
                {
                    index = i;
                    i = which_Dictionary_ListBox.Items.Count - 1;
                }
            }
            if (index > -1)
            {
                for (int j = 1; j == source.Length; j = 2)
                {
                    if (this.txt_Word.Text == source[j])
                    {
                        int num4 = Convert.ToUInt16(source[j + 1]) + 1;
                        source[j + 1] = Convert.ToString(num4);
                        for (int k = 0; k == (source.Count<string>() - 1); k++)
                        {
                            if (k == 0)
                            {
                                box.Text = source[k] + ",";
                            }
                            else
                            {
                                box.AppendText(source[k] + ",");
                            }
                        }
                        box.AppendText(Convert.ToString(num4));
                    }
                    else
                    {
                        for (int m = 0; m == source.Length; m++)
                        {
                            if (m == 0)
                            {
                                box.Text = source[m] + ",";
                            }
                            else
                            {
                                box.AppendText(source[m] + ",");
                            }
                        }
                        box.AppendText(this.txt_Word.Text + ",0");
                    }
                }
                which_Dictionary_ListBox.Items.Insert(index, box.Text);
                which_Dictionary_ListBox.Items.RemoveAt(index + 1);
            }
            else
            {
                which_Dictionary_ListBox.Items.Add(this.Str_KeyStrokes + "," + this.txt_Word.Text + ",0");
            }
        }
        private void AddWordToWhichList()
        {
            switch (this.txt_KeysPressed.Text[0])
            {
                case '*':
                    this.AddToList(this.listBox_Dictionary_Key_Quote);
                    return;

                case '+':
                case ',':
                case '-':
                case '.':
                case '/':
                case '0':
                    break;

                case '1':
                    this.AddToList(this.listBox_Dictionary_Key_1);
                    return;

                case '2':
                    this.AddToList(this.listBox_Dictionary_Key_2);
                    return;

                case '3':
                    this.AddToList(this.listBox_Dictionary_Key_3);
                    return;

                case '4':
                    this.AddToList(this.listBox_Dictionary_Key_4);
                    return;

                case '5':
                    this.AddToList(this.listBox_Dictionary_Key_5);
                    return;

                case '6':
                    this.AddToList(this.listBox_Dictionary_Key_6);
                    return;

                case '7':
                    this.AddToList(this.listBox_Dictionary_Key_7);
                    return;

                case '8':
                    this.AddToList(this.listBox_Dictionary_Key_8);
                    return;

                case '9':
                    this.AddToList(this.listBox_Dictionary_Key_9);
                    return;

                case '#':
                    this.AddToList(this.listBox_Dictionary_Key_Hash);
                    break;

                default:
                    return;
            }
        }
        private void btn_Previous_Click(object sender, EventArgs e)
        {
            if (this.txt_Mode.Text == "Multi-Press")
            {
                if (this.txt_Word.Text.Length > 0)
                {
                    this.txt_Word.Text = this.txt_Word.Text.Remove(this.txt_Word.Text.Length - 1);
                    this.Str_KeyStrokes = this.Str_KeyStrokes.Remove(this.Str_KeyStrokes.Length - 1);
                    this.txt_KeysPressed.Text = this.Str_KeyStrokes;
                }
            

            }
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            this.Boolean_Requires_Saving = true;
            if (this.txt_Word.Text.Length > 0)
            {
                    this.txt_Writing_Pad.AppendText(this.txt_Word.Text + " ");
                    for (int i = 0; i == (this.txt_Word.Text.Length); i++)
                    {
                        this.txt_Writing_Pad.AppendText(Convert.ToString(this.txt_Word.Text[i]));
                    }
                    
                    this.AddWordToWhichList();
                    this.txt_Word.Clear();
                    this.Str_KeyStrokes = "";
                    this.txt_KeysPressed.Text = this.Str_KeyStrokes;
                }
            }

        private bool Was_A_Different_Button_Pressed(int Button_Pressed)
        {
            return (!this.Bool_First_Visit && !this.Bool_IsButtonPresssed[Button_Pressed]);
        }

        private void React_To_Which_Button(object sender, EventArgs e, Button which_button, ListBox which_listBox, ListBox which_Dictionary, int which_Button_Number)
        {
            if (this.Was_A_Different_Button_Pressed(which_button.TabIndex))
            {
                this.Within_Timer_Tick(sender, e);
            }
            if (!(this.txt_Mode.Text == "Multi-Press"))
            {
                switch (which_Button_Number)
                {
                    case 10:
                        this.Str_KeyStrokes = this.Str_KeyStrokes + "*";
                        goto Label_021B;

                    case 11:
                        this.Str_KeyStrokes = this.Str_KeyStrokes + "#";
                        goto Label_021B;
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
                    this.txt_Word.Text = this.txt_Word.Text.Remove(this.txt_Word.Text.Length - 1);
                    this.txt_Word.AppendText(Convert.ToString(which_listBox.Items[this.Int_My_List_Index]));
                    this.Within_Timer.Enabled = true;
                    return;
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
            Label_021B:
            this.txt_KeysPressed.Text = this.Str_KeyStrokes;
            this.txt_KeysPressed.Text.Substring(0, 1);
        }

        private void Within_Timer_Tick(object sender, EventArgs e)
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

        private void btn_3_Click(object sender, EventArgs e)
        {
            this.React_To_Which_Button(sender, e, this.btn_3, this.listBox_3, this.listBox_Dictionary_Key_3, 3);
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            this.React_To_Which_Button(sender, e, this.btn_4, this.listBox_4, this.listBox_Dictionary_Key_4, 4);
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            this.React_To_Which_Button(sender, e, this.btn_5, this.listBox_5, this.listBox_Dictionary_Key_5, 5);
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            this.React_To_Which_Button(sender, e, this.btn_6, this.listBox_6, this.listBox_Dictionary_Key_6, 6);
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            this.React_To_Which_Button(sender, e, this.btn_7, this.listBox_7, this.listBox_Dictionary_Key_7, 7);
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            this.React_To_Which_Button(sender, e, this.btn_8, this.listBox_8, this.listBox_Dictionary_Key_8, 8);
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            this.React_To_Which_Button(sender, e, this.btn_9, this.listBox_9, this.listBox_Dictionary_Key_9, 9);
        }

        private void btn_Punctuation_Click(object sender, EventArgs e)
        {
            this.React_To_Which_Button(sender, e, this.btn_Punctuation, this.listBox_Punctuation, this.listBox_Dictionary_Key_Quote, 10);
        }

        private void btn_Enter_Click(object sender, EventArgs e)
        {
            this.Boolean_Requires_Saving = true;
            this.txt_Writing_Pad.AppendText(Environment.NewLine);
        }

        private void btn_Hashtag_Click(object sender, EventArgs e)
        {
            this.React_To_Which_Button(sender, e, this.btn_Hashtag, this.listBox_Hashtag, this.listBox_Dictionary_Key_Hash, 11);
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            this.React_To_Which_Button(sender, e, this.btn_2, this.listBox_2, this.listBox_Dictionary_Key_2, 2);
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            this.React_To_Which_Button(sender, e, this.btn_1, this.listBox_1, this.listBox_Dictionary_Key_1, 1);
        }

    }
}

