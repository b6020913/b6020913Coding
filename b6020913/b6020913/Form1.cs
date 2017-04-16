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
        public Frm_Main()
        {
            InitializeComponent();
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
    }
}
