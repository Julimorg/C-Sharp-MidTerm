namespace MidTerm
{
    partial class Form8
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
            this.lightdarkmodebtn = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.txtbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DarkMode = new System.Windows.Forms.Label();
            this.DropdownInf = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.CopyBtnCode2 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.Code2 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.Code2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lightdarkmodebtn
            // 
            this.lightdarkmodebtn.Animated = true;
            this.lightdarkmodebtn.BackColor = System.Drawing.Color.Transparent;
            this.lightdarkmodebtn.CheckedState.BorderColor = System.Drawing.Color.Red;
            this.lightdarkmodebtn.CheckedState.FillColor = System.Drawing.Color.White;
            this.lightdarkmodebtn.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.lightdarkmodebtn.CheckedState.InnerColor = System.Drawing.Color.Black;
            this.lightdarkmodebtn.Location = new System.Drawing.Point(394, 110);
            this.lightdarkmodebtn.Name = "lightdarkmodebtn";
            this.lightdarkmodebtn.Size = new System.Drawing.Size(341, 93);
            this.lightdarkmodebtn.TabIndex = 28;
            this.lightdarkmodebtn.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.lightdarkmodebtn.UncheckedState.FillColor = System.Drawing.Color.Black;
            this.lightdarkmodebtn.UncheckedState.InnerBorderColor = System.Drawing.Color.Yellow;
            this.lightdarkmodebtn.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.lightdarkmodebtn.CheckedChanged += new System.EventHandler(this.lightdarkmodebtn_CheckedChanged);
            // 
            // txtbox
            // 
            this.txtbox.BorderThickness = 0;
            this.txtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbox.DefaultText = resources.GetString("txtbox.DefaultText");
            this.txtbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbox.Font = new System.Drawing.Font("Arial", 10.2F);
            this.txtbox.ForeColor = System.Drawing.Color.Black;
            this.txtbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbox.Location = new System.Drawing.Point(208, 289);
            this.txtbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbox.Multiline = true;
            this.txtbox.Name = "txtbox";
            this.txtbox.PasswordChar = '\0';
            this.txtbox.PlaceholderText = "";
            this.txtbox.ReadOnly = true;
            this.txtbox.SelectedText = "";
            this.txtbox.Size = new System.Drawing.Size(737, 204);
            this.txtbox.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(406, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 32);
            this.label1.TabIndex = 23;
            this.label1.Text = "The Text look like this!";
            // 
            // DarkMode
            // 
            this.DarkMode.AutoSize = true;
            this.DarkMode.BackColor = System.Drawing.Color.Transparent;
            this.DarkMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DarkMode.Location = new System.Drawing.Point(500, 66);
            this.DarkMode.Name = "DarkMode";
            this.DarkMode.Size = new System.Drawing.Size(140, 29);
            this.DarkMode.TabIndex = 22;
            this.DarkMode.Text = "Dark mode";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(72, 497);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 22);
            this.label2.TabIndex = 26;
            this.label2.Text = "Example Code:";
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.Color.White;
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(170)))));
            this.richTextBox2.Location = new System.Drawing.Point(15, 15);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(669, 219);
            this.richTextBox2.TabIndex = 0;
            this.richTextBox2.Text = resources.GetString("richTextBox2.Text");
            // 
            // CopyBtnCode2
            // 
            this.CopyBtnCode2.BackColor = System.Drawing.Color.Transparent;
            this.CopyBtnCode2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CopyBtnCode2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CopyBtnCode2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CopyBtnCode2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CopyBtnCode2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CopyBtnCode2.ForeColor = System.Drawing.Color.White;
            this.CopyBtnCode2.Image = ((System.Drawing.Image)(resources.GetObject("CopyBtnCode2.Image")));
            this.CopyBtnCode2.ImageSize = new System.Drawing.Size(13, 13);
            this.CopyBtnCode2.Location = new System.Drawing.Point(957, 737);
            this.CopyBtnCode2.Name = "CopyBtnCode2";
            this.CopyBtnCode2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.CopyBtnCode2.Size = new System.Drawing.Size(38, 35);
            this.CopyBtnCode2.TabIndex = 27;
            this.CopyBtnCode2.UseTransparentBackground = true;
            this.CopyBtnCode2.Click += new System.EventHandler(this.CopyBtnCode2_Click);
            // 
            // Code2
            // 
            this.Code2.BorderColor = System.Drawing.Color.Black;
            this.Code2.BorderRadius = 5;
            this.Code2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.Code2.BorderThickness = 3;
            this.Code2.Controls.Add(this.richTextBox2);
            this.Code2.FillColor = System.Drawing.Color.White;
            this.Code2.FillColor2 = System.Drawing.Color.White;
            this.Code2.Location = new System.Drawing.Point(226, 526);
            this.Code2.Name = "Code2";
            this.Code2.Size = new System.Drawing.Size(709, 259);
            this.Code2.TabIndex = 25;
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 850);
            this.Controls.Add(this.lightdarkmodebtn);
            this.Controls.Add(this.txtbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DarkMode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CopyBtnCode2);
            this.Controls.Add(this.Code2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form8";
            this.Text = "Form8";
            this.Code2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ToggleSwitch lightdarkmodebtn;
        private Guna.UI2.WinForms.Guna2TextBox txtbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label DarkMode;
        private System.Windows.Forms.Timer DropdownInf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private Guna.UI2.WinForms.Guna2CircleButton CopyBtnCode2;
        private Guna.UI2.WinForms.Guna2GradientPanel Code2;
    }
}