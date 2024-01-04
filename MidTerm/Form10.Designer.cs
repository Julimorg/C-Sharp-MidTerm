namespace MidTerm
{
    partial class Form10
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form10));
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnChangeColor = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.AllowDrop = true;
            this.guna2GradientPanel1.BorderColor = System.Drawing.Color.Black;
            this.guna2GradientPanel1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.guna2GradientPanel1.BorderThickness = 3;
            this.guna2GradientPanel1.Controls.Add(this.richTextBox1);
            this.guna2GradientPanel1.Location = new System.Drawing.Point(61, 254);
            this.guna2GradientPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(944, 319);
            this.guna2GradientPanel1.TabIndex = 12;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.White;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Inconsolata Expanded", 10.15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.richTextBox1.Location = new System.Drawing.Point(20, 18);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(907, 285);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Montserrat Medium", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(60, 220);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 33);
            this.label3.TabIndex = 11;
            this.label3.Text = "Example Code:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 130);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(944, 70);
            this.label2.TabIndex = 10;
            this.label2.Text = "Cách sử dụng: Chúng ta cần một biến để đếm số lần người dùng click vào nếu:\r\n-số " +
    "lần click vào là số lẻ thì màu sẽ thay đổi theo bạn đặt \r\n-số lần click vào là s" +
    "ố chẵn thì màu sẽ trả về ban đầu";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 103);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(944, 27);
            this.label1.TabIndex = 9;
            this.label1.Text = "Giới Thiệu: Button sẽ đổi màu khi người dùng ấn vào và trả về màu ban đầu khi ngư" +
    "ời dùng ấn thêm cái nữa\r\n";
            // 
            // guna2CircleButton1
            // 
            this.guna2CircleButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2CircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton1.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CircleButton1.Image")));
            this.guna2CircleButton1.ImageSize = new System.Drawing.Size(13, 13);
            this.guna2CircleButton1.Location = new System.Drawing.Point(967, 581);
            this.guna2CircleButton1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2CircleButton1.Name = "guna2CircleButton1";
            this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton1.Size = new System.Drawing.Size(38, 35);
            this.guna2CircleButton1.TabIndex = 13;
            this.guna2CircleButton1.Click += new System.EventHandler(this.guna2CircleButton1_Click);
            // 
            // btnChangeColor
            // 
            this.btnChangeColor.AutoRoundedCorners = true;
            this.btnChangeColor.BackColor = System.Drawing.Color.Transparent;
            this.btnChangeColor.BorderColor = System.Drawing.Color.Transparent;
            this.btnChangeColor.BorderRadius = 5;
            this.btnChangeColor.BorderThickness = 2;
            this.btnChangeColor.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChangeColor.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChangeColor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChangeColor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChangeColor.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnChangeColor.ForeColor = System.Drawing.Color.White;
            this.btnChangeColor.Location = new System.Drawing.Point(451, 31);
            this.btnChangeColor.Name = "btnChangeColor";
            this.btnChangeColor.Size = new System.Drawing.Size(193, 57);
            this.btnChangeColor.TabIndex = 1;
            this.btnChangeColor.Text = "Click vào đây";
            this.btnChangeColor.UseTransparentBackground = true;
            this.btnChangeColor.Click += new System.EventHandler(this.btnChangeColor_Click);
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1067, 772);
            this.Controls.Add(this.btnChangeColor);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2CircleButton1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form10";
            this.Text = "Form10";
            this.guna2GradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private Guna.UI2.WinForms.Guna2Button btnChangeColor;
    }
}