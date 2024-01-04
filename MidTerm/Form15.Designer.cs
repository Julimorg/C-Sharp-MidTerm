namespace MidTerm
{
    partial class Form15
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form15));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.rTB = new System.Windows.Forms.RichTextBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.txtData = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnReset = new Guna.UI2.WinForms.Guna2Button();
            this.lbExRs = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnCp2 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.richTextBox1.ForeColor = System.Drawing.Color.Black;
            this.richTextBox1.Location = new System.Drawing.Point(378, 139);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(329, 81);
            this.richTextBox1.TabIndex = 13;
            this.richTextBox1.Text = "1. Người dùng input bất kì data\n\n2. Nhấn nút reset";
            // 
            // rTB
            // 
            this.rTB.BackColor = System.Drawing.Color.White;
            this.rTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rTB.Font = new System.Drawing.Font("Inconsolata Expanded", 10.15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(170)))));
            this.rTB.Location = new System.Drawing.Point(20, 15);
            this.rTB.Name = "rTB";
            this.rTB.Size = new System.Drawing.Size(462, 124);
            this.rTB.TabIndex = 9;
            this.rTB.Text = "private void btnReset_Click(object sender, EventArgs e)\n{\n    txtData.Text = \"\";\n" +
    "    txtData.Focus();\n}";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.Black;
            this.guna2Panel1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.guna2Panel1.BorderThickness = 3;
            this.guna2Panel1.Controls.Add(this.txtData);
            this.guna2Panel1.Controls.Add(this.btnReset);
            this.guna2Panel1.Location = new System.Drawing.Point(354, 28);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(413, 94);
            this.guna2Panel1.TabIndex = 15;
            // 
            // txtData
            // 
            this.txtData.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtData.DefaultText = "";
            this.txtData.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtData.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtData.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtData.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtData.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtData.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtData.Location = new System.Drawing.Point(24, 23);
            this.txtData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtData.Name = "txtData";
            this.txtData.PasswordChar = '\0';
            this.txtData.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtData.PlaceholderText = "Your input";
            this.txtData.SelectedText = "";
            this.txtData.Size = new System.Drawing.Size(229, 48);
            this.txtData.TabIndex = 1;
            // 
            // btnReset
            // 
            this.btnReset.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReset.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReset.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReset.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReset.Font = new System.Drawing.Font("Montserrat Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(292, 28);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(95, 38);
            this.btnReset.TabIndex = 0;
            this.btnReset.Text = "Reset";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lbExRs
            // 
            this.lbExRs.AutoSize = true;
            this.lbExRs.Font = new System.Drawing.Font("Montserrat Medium", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbExRs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lbExRs.Location = new System.Drawing.Point(337, 231);
            this.lbExRs.Name = "lbExRs";
            this.lbExRs.Size = new System.Drawing.Size(153, 25);
            this.lbExRs.TabIndex = 14;
            this.lbExRs.Text = "Example code";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BorderColor = System.Drawing.Color.Black;
            this.guna2Panel2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.guna2Panel2.BorderThickness = 3;
            this.guna2Panel2.Controls.Add(this.btnCp2);
            this.guna2Panel2.Controls.Add(this.rTB);
            this.guna2Panel2.Location = new System.Drawing.Point(322, 261);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(500, 145);
            this.guna2Panel2.TabIndex = 16;
            // 
            // btnCp2
            // 
            this.btnCp2.BackColor = System.Drawing.Color.Transparent;
            this.btnCp2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCp2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCp2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCp2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCp2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCp2.ForeColor = System.Drawing.Color.White;
            this.btnCp2.Image = ((System.Drawing.Image)(resources.GetObject("btnCp2.Image")));
            this.btnCp2.ImageSize = new System.Drawing.Size(13, 13);
            this.btnCp2.Location = new System.Drawing.Point(452, 101);
            this.btnCp2.Name = "btnCp2";
            this.btnCp2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnCp2.Size = new System.Drawing.Size(38, 35);
            this.btnCp2.TabIndex = 11;
            this.btnCp2.UseTransparentBackground = true;
            this.btnCp2.Click += new System.EventHandler(this.btnCp2_Click);
            // 
            // Form15
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1067, 757);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.lbExRs);
            this.Controls.Add(this.guna2Panel2);
            this.Name = "Form15";
            this.Text = "Form15";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox rTB;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2TextBox txtData;
        private Guna.UI2.WinForms.Guna2Button btnReset;
        private System.Windows.Forms.Label lbExRs;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2CircleButton btnCp2;
    }
}