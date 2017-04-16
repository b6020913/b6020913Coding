using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private bool Bool_First_Visit = true;
        private bool[] Bool_IsButtonPresssed = new bool[0x13];
        private bool Boolean_Requires_Saving;
        private Button btn_Previous;
        private Button btn_0;
        private Button btn_1;
        private Button btn_2;
        private Button btn_3;
        private Button btn_4;
        private Button btn_5;
        private Button btn_6;
        private Button btn_7;
        private Button btn_8;
        private Button btn_9;
        private Button btn_Punctuation;
        private Button btn_Enter;
        private Button btn_Hashtag;
        private Button btn_Mode;
        private Button btn_Next;
        private Button btn_Predict;
        private ToolStripMenuItem fileToolStripMenuItem;
        private int Int_Interval_Required = 500;
        private int Int_My_List_Index;
        private int Int_NumberOfCharacters;
        private IContainer components;
        private ToolStripMenuItem strip_Configure;
        private ToolStripMenuItem strip_Exit;
        private MenuStrip strip;
        private ToolStripMenuItem strip_New;
        private ToolStripMenuItem strip_Open;
        private ToolStripMenuItem strip_Save;
        private ToolStripMenuItem strip_SaveAs;
        private OpenFileDialog openFileDialog;
        private Panel panel1;
        private Panel panel2;
        private SaveFileDialog SaveFile;
        private string Str_KeyStrokes;
        private string Str_Present_File_Path_Name = "";
        private TextBox txt_Mode;
        private RichTextBox txt_Word;
        private TextBox txt_Writing_Pad;
        private Timer Within_Timer;

        public Form1()
        {
            InitializeComponent();
        }
    }
}
