namespace b6020913
{
    partial class Frm_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.strip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.strip_New = new System.Windows.Forms.ToolStripMenuItem();
            this.strip_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.strip_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.strip_SaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.strip_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.strip_Configure = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_Writing_Pad = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_Mode = new System.Windows.Forms.TextBox();
            this.txt_Word = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Hashtag = new System.Windows.Forms.Button();
            this.btn_0 = new System.Windows.Forms.Button();
            this.btn_Punctuation = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_9 = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_7 = new System.Windows.Forms.Button();
            this.btn_Enter = new System.Windows.Forms.Button();
            this.btn_Empty2 = new System.Windows.Forms.Button();
            this.btn_Empty = new System.Windows.Forms.Button();
            this.btn_Predict = new System.Windows.Forms.Button();
            this.btn_Previous = new System.Windows.Forms.Button();
            this.btn_Next = new System.Windows.Forms.Button();
            this.btn_Mode = new System.Windows.Forms.Button();
            this.txt_KeysPressed = new System.Windows.Forms.TextBox();
            this.strip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // strip
            // 
            this.strip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.strip_Configure});
            this.strip.Location = new System.Drawing.Point(0, 0);
            this.strip.Name = "strip";
            this.strip.Size = new System.Drawing.Size(891, 24);
            this.strip.TabIndex = 0;
            this.strip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.strip_New,
            this.strip_Open,
            this.strip_Save,
            this.strip_SaveAs,
            this.strip_Exit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // strip_New
            // 
            this.strip_New.Name = "strip_New";
            this.strip_New.Size = new System.Drawing.Size(114, 22);
            this.strip_New.Text = "New";
            // 
            // strip_Open
            // 
            this.strip_Open.Name = "strip_Open";
            this.strip_Open.Size = new System.Drawing.Size(114, 22);
            this.strip_Open.Text = "Open";
            // 
            // strip_Save
            // 
            this.strip_Save.Name = "strip_Save";
            this.strip_Save.Size = new System.Drawing.Size(114, 22);
            this.strip_Save.Text = "Save";
            // 
            // strip_SaveAs
            // 
            this.strip_SaveAs.Name = "strip_SaveAs";
            this.strip_SaveAs.Size = new System.Drawing.Size(114, 22);
            this.strip_SaveAs.Text = "Save As";
            // 
            // strip_Exit
            // 
            this.strip_Exit.Name = "strip_Exit";
            this.strip_Exit.Size = new System.Drawing.Size(114, 22);
            this.strip_Exit.Text = "Exit";
            // 
            // strip_Configure
            // 
            this.strip_Configure.Name = "strip_Configure";
            this.strip_Configure.Size = new System.Drawing.Size(72, 20);
            this.strip_Configure.Text = "Configure";
            // 
            // txt_Writing_Pad
            // 
            this.txt_Writing_Pad.Location = new System.Drawing.Point(12, 27);
            this.txt_Writing_Pad.Multiline = true;
            this.txt_Writing_Pad.Name = "txt_Writing_Pad";
            this.txt_Writing_Pad.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Writing_Pad.Size = new System.Drawing.Size(867, 269);
            this.txt_Writing_Pad.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txt_Mode);
            this.panel1.Controls.Add(this.txt_Word);
            this.panel1.Location = new System.Drawing.Point(276, 302);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(331, 42);
            this.panel1.TabIndex = 2;
            // 
            // txt_Mode
            // 
            this.txt_Mode.Location = new System.Drawing.Point(235, 8);
            this.txt_Mode.Name = "txt_Mode";
            this.txt_Mode.Size = new System.Drawing.Size(84, 20);
            this.txt_Mode.TabIndex = 1;
            this.txt_Mode.Text = "Multi-Press";
            this.txt_Mode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Word
            // 
            this.txt_Word.Location = new System.Drawing.Point(3, 3);
            this.txt_Word.Name = "txt_Word";
            this.txt_Word.Size = new System.Drawing.Size(222, 31);
            this.txt_Word.TabIndex = 0;
            this.txt_Word.Text = "";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btn_Hashtag);
            this.panel2.Controls.Add(this.btn_0);
            this.panel2.Controls.Add(this.btn_Punctuation);
            this.panel2.Controls.Add(this.btn_3);
            this.panel2.Controls.Add(this.btn_2);
            this.panel2.Controls.Add(this.btn_1);
            this.panel2.Controls.Add(this.btn_6);
            this.panel2.Controls.Add(this.btn_5);
            this.panel2.Controls.Add(this.btn_4);
            this.panel2.Controls.Add(this.btn_9);
            this.panel2.Controls.Add(this.btn_8);
            this.panel2.Controls.Add(this.btn_7);
            this.panel2.Controls.Add(this.btn_Enter);
            this.panel2.Controls.Add(this.btn_Empty2);
            this.panel2.Controls.Add(this.btn_Empty);
            this.panel2.Controls.Add(this.btn_Predict);
            this.panel2.Controls.Add(this.btn_Previous);
            this.panel2.Controls.Add(this.btn_Next);
            this.panel2.Controls.Add(this.btn_Mode);
            this.panel2.Location = new System.Drawing.Point(276, 351);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(330, 345);
            this.panel2.TabIndex = 3;
            // 
            // btn_Hashtag
            // 
            this.btn_Hashtag.BackColor = System.Drawing.Color.LightCoral;
            this.btn_Hashtag.Location = new System.Drawing.Point(163, 266);
            this.btn_Hashtag.Name = "btn_Hashtag";
            this.btn_Hashtag.Size = new System.Drawing.Size(66, 55);
            this.btn_Hashtag.TabIndex = 18;
            this.btn_Hashtag.Text = "     #       0.00";
            this.btn_Hashtag.UseVisualStyleBackColor = false;
            // 
            // btn_0
            // 
            this.btn_0.BackColor = System.Drawing.Color.LightGreen;
            this.btn_0.Location = new System.Drawing.Point(91, 265);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(66, 56);
            this.btn_0.TabIndex = 17;
            this.btn_0.Text = "     000       [ _ }";
            this.btn_0.UseVisualStyleBackColor = false;
            // 
            // btn_Punctuation
            // 
            this.btn_Punctuation.BackColor = System.Drawing.Color.LightCoral;
            this.btn_Punctuation.Location = new System.Drawing.Point(19, 265);
            this.btn_Punctuation.Name = "btn_Punctuation";
            this.btn_Punctuation.Size = new System.Drawing.Size(66, 56);
            this.btn_Punctuation.TabIndex = 16;
            this.btn_Punctuation.Text = "* - _";
            this.btn_Punctuation.UseVisualStyleBackColor = false;
            // 
            // btn_3
            // 
            this.btn_3.BackColor = System.Drawing.Color.LightCoral;
            this.btn_3.Location = new System.Drawing.Point(163, 204);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(66, 56);
            this.btn_3.TabIndex = 15;
            this.btn_3.Text = "      3        W X Y Z";
            this.btn_3.UseVisualStyleBackColor = false;
            // 
            // btn_2
            // 
            this.btn_2.BackColor = System.Drawing.Color.LightCoral;
            this.btn_2.Location = new System.Drawing.Point(91, 204);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(66, 56);
            this.btn_2.TabIndex = 14;
            this.btn_2.Text = "      2        T U V";
            this.btn_2.UseVisualStyleBackColor = false;
            // 
            // btn_1
            // 
            this.btn_1.BackColor = System.Drawing.Color.LightCoral;
            this.btn_1.Location = new System.Drawing.Point(19, 204);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(66, 55);
            this.btn_1.TabIndex = 13;
            this.btn_1.Text = "      1        P Q R S";
            this.btn_1.UseVisualStyleBackColor = false;
            // 
            // btn_6
            // 
            this.btn_6.BackColor = System.Drawing.Color.LightCoral;
            this.btn_6.Location = new System.Drawing.Point(163, 142);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(66, 56);
            this.btn_6.TabIndex = 12;
            this.btn_6.Text = "      6        M N O";
            this.btn_6.UseVisualStyleBackColor = false;
            // 
            // btn_5
            // 
            this.btn_5.BackColor = System.Drawing.Color.LightCoral;
            this.btn_5.Location = new System.Drawing.Point(91, 142);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(66, 56);
            this.btn_5.TabIndex = 11;
            this.btn_5.Text = "      5        J K L";
            this.btn_5.UseVisualStyleBackColor = false;
            // 
            // btn_4
            // 
            this.btn_4.BackColor = System.Drawing.Color.LightCoral;
            this.btn_4.Location = new System.Drawing.Point(19, 142);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(66, 56);
            this.btn_4.TabIndex = 10;
            this.btn_4.Text = "      4        G H I";
            this.btn_4.UseVisualStyleBackColor = false;
            // 
            // btn_9
            // 
            this.btn_9.BackColor = System.Drawing.Color.LightCoral;
            this.btn_9.Location = new System.Drawing.Point(163, 80);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(66, 54);
            this.btn_9.TabIndex = 9;
            this.btn_9.Text = "      9        D E F";
            this.btn_9.UseVisualStyleBackColor = false;
            // 
            // btn_8
            // 
            this.btn_8.BackColor = System.Drawing.Color.LightCoral;
            this.btn_8.Location = new System.Drawing.Point(91, 80);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(66, 56);
            this.btn_8.TabIndex = 8;
            this.btn_8.Text = "      8        A B C";
            this.btn_8.UseVisualStyleBackColor = false;
            // 
            // btn_7
            // 
            this.btn_7.BackColor = System.Drawing.Color.LightCoral;
            this.btn_7.Location = new System.Drawing.Point(19, 80);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(66, 56);
            this.btn_7.TabIndex = 7;
            this.btn_7.Text = "      7         .  ,  \"";
            this.btn_7.UseVisualStyleBackColor = false;
            // 
            // btn_Enter
            // 
            this.btn_Enter.BackColor = System.Drawing.Color.Yellow;
            this.btn_Enter.Location = new System.Drawing.Point(237, 200);
            this.btn_Enter.Name = "btn_Enter";
            this.btn_Enter.Size = new System.Drawing.Size(64, 121);
            this.btn_Enter.TabIndex = 6;
            this.btn_Enter.Text = "Enter";
            this.btn_Enter.UseVisualStyleBackColor = false;
            // 
            // btn_Empty2
            // 
            this.btn_Empty2.BackColor = System.Drawing.Color.Yellow;
            this.btn_Empty2.Location = new System.Drawing.Point(237, 140);
            this.btn_Empty2.Name = "btn_Empty2";
            this.btn_Empty2.Size = new System.Drawing.Size(64, 54);
            this.btn_Empty2.TabIndex = 5;
            this.btn_Empty2.UseVisualStyleBackColor = false;
            // 
            // btn_Empty
            // 
            this.btn_Empty.BackColor = System.Drawing.Color.Yellow;
            this.btn_Empty.Location = new System.Drawing.Point(237, 80);
            this.btn_Empty.Name = "btn_Empty";
            this.btn_Empty.Size = new System.Drawing.Size(64, 54);
            this.btn_Empty.TabIndex = 4;
            this.btn_Empty.UseVisualStyleBackColor = false;
            // 
            // btn_Predict
            // 
            this.btn_Predict.BackColor = System.Drawing.Color.Yellow;
            this.btn_Predict.Location = new System.Drawing.Point(235, 17);
            this.btn_Predict.Name = "btn_Predict";
            this.btn_Predict.Size = new System.Drawing.Size(66, 57);
            this.btn_Predict.TabIndex = 3;
            this.btn_Predict.Text = "Show Prediction";
            this.btn_Predict.UseVisualStyleBackColor = false;
            // 
            // btn_Previous
            // 
            this.btn_Previous.BackColor = System.Drawing.Color.Cyan;
            this.btn_Previous.Location = new System.Drawing.Point(163, 17);
            this.btn_Previous.Name = "btn_Previous";
            this.btn_Previous.Size = new System.Drawing.Size(66, 57);
            this.btn_Previous.TabIndex = 2;
            this.btn_Previous.Text = "Previous";
            this.btn_Previous.UseVisualStyleBackColor = false;
            this.btn_Previous.Click += new System.EventHandler(this.btn_Previous_Click);
            // 
            // btn_Next
            // 
            this.btn_Next.BackColor = System.Drawing.Color.Cyan;
            this.btn_Next.Location = new System.Drawing.Point(91, 16);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(66, 58);
            this.btn_Next.TabIndex = 1;
            this.btn_Next.Text = "Next";
            this.btn_Next.UseVisualStyleBackColor = false;
            // 
            // btn_Mode
            // 
            this.btn_Mode.BackColor = System.Drawing.Color.Cyan;
            this.btn_Mode.Location = new System.Drawing.Point(19, 15);
            this.btn_Mode.Name = "btn_Mode";
            this.btn_Mode.Size = new System.Drawing.Size(66, 59);
            this.btn_Mode.TabIndex = 0;
            this.btn_Mode.Text = "Mode";
            this.btn_Mode.UseVisualStyleBackColor = false;
            // 
            // txt_KeysPressed
            // 
            this.txt_KeysPressed.Location = new System.Drawing.Point(672, 319);
            this.txt_KeysPressed.Name = "txt_KeysPressed";
            this.txt_KeysPressed.Size = new System.Drawing.Size(144, 20);
            this.txt_KeysPressed.TabIndex = 4;
            this.txt_KeysPressed.Visible = false;
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 717);
            this.Controls.Add(this.txt_KeysPressed);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_Writing_Pad);
            this.Controls.Add(this.strip);
            this.MainMenuStrip = this.strip;
            this.Name = "Frm_Main";
            this.Text = "Mini Keyboard";
            this.strip.ResumeLayout(false);
            this.strip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip strip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem strip_New;
        private System.Windows.Forms.ToolStripMenuItem strip_Open;
        private System.Windows.Forms.ToolStripMenuItem strip_Save;
        private System.Windows.Forms.ToolStripMenuItem strip_SaveAs;
        private System.Windows.Forms.ToolStripMenuItem strip_Exit;
        private System.Windows.Forms.ToolStripMenuItem strip_Configure;
        private System.Windows.Forms.TextBox txt_Writing_Pad;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox txt_Word;
        private System.Windows.Forms.TextBox txt_Mode;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Enter;
        private System.Windows.Forms.Button btn_Empty2;
        private System.Windows.Forms.Button btn_Empty;
        private System.Windows.Forms.Button btn_Predict;
        private System.Windows.Forms.Button btn_Previous;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.Button btn_Mode;
        private System.Windows.Forms.Button btn_Hashtag;
        private System.Windows.Forms.Button btn_0;
        private System.Windows.Forms.Button btn_Punctuation;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_6;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_9;
        private System.Windows.Forms.Button btn_8;
        private System.Windows.Forms.Button btn_7;
        private System.Windows.Forms.TextBox txt_KeysPressed;
    }
}

