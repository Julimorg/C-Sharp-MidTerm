namespace MidTerm
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.DropContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.HoverDropBtn = new Guna.UI2.WinForms.Guna2Button();
            this.Content = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.CopyBtnCode1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.Code = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.MenuDrop = new System.Windows.Forms.Timer(this.components);
            this.DropContainer.SuspendLayout();
            this.Content.SuspendLayout();
            this.Code.SuspendLayout();
            this.SuspendLayout();
            // 
            // DropContainer
            // 
            this.DropContainer.Controls.Add(this.guna2Button3);
            this.DropContainer.Controls.Add(this.guna2Button2);
            this.DropContainer.Controls.Add(this.HoverDropBtn);
            resources.ApplyResources(this.DropContainer, "DropContainer");
            this.DropContainer.Name = "DropContainer";
            // 
            // guna2Button3
            // 
            this.guna2Button3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button3.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Button3.BorderThickness = 2;
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(167)))), ((int)(((byte)(240)))));
            resources.ApplyResources(this.guna2Button3, "guna2Button3");
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button3.UseTransparentBackground = true;
            // 
            // guna2Button2
            // 
            this.guna2Button2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button2.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Button2.BorderThickness = 2;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(167)))), ((int)(((byte)(240)))));
            resources.ApplyResources(this.guna2Button2, "guna2Button2");
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button2.UseTransparentBackground = true;
            // 
            // HoverDropBtn
            // 
            this.HoverDropBtn.BackColor = System.Drawing.Color.Transparent;
            this.HoverDropBtn.BorderColor = System.Drawing.Color.Transparent;
            this.HoverDropBtn.BorderThickness = 2;
            this.HoverDropBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.HoverDropBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.HoverDropBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.HoverDropBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            resources.ApplyResources(this.HoverDropBtn, "HoverDropBtn");
            this.HoverDropBtn.ForeColor = System.Drawing.Color.White;
            this.HoverDropBtn.Name = "HoverDropBtn";
            this.HoverDropBtn.UseTransparentBackground = true;
            this.HoverDropBtn.Click += new System.EventHandler(this.HoverDropBtn_Click);
            // 
            // Content
            // 
            resources.ApplyResources(this.Content, "Content");
            this.Content.Controls.Add(this.guna2TextBox1);
            this.Content.Name = "Content";
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.BorderThickness = 0;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = resources.GetString("guna2TextBox1.DefaultText");
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.guna2TextBox1, "guna2TextBox1");
            this.guna2TextBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Multiline = true;
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.ReadOnly = true;
            this.guna2TextBox1.SelectedText = "";
            // 
            // CopyBtnCode1
            // 
            this.CopyBtnCode1.BackColor = System.Drawing.Color.Transparent;
            this.CopyBtnCode1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CopyBtnCode1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CopyBtnCode1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CopyBtnCode1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            resources.ApplyResources(this.CopyBtnCode1, "CopyBtnCode1");
            this.CopyBtnCode1.ForeColor = System.Drawing.Color.White;
            this.CopyBtnCode1.Image = ((System.Drawing.Image)(resources.GetObject("CopyBtnCode1.Image")));
            this.CopyBtnCode1.ImageSize = new System.Drawing.Size(13, 13);
            this.CopyBtnCode1.Name = "CopyBtnCode1";
            this.CopyBtnCode1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.CopyBtnCode1.UseTransparentBackground = true;
            this.CopyBtnCode1.Click += new System.EventHandler(this.CopyCode);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Name = "label1";
            // 
            // Code
            // 
            this.Code.BorderColor = System.Drawing.Color.Black;
            this.Code.BorderRadius = 5;
            this.Code.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.Code.BorderThickness = 3;
            this.Code.Controls.Add(this.richTextBox1);
            this.Code.FillColor = System.Drawing.Color.White;
            this.Code.FillColor2 = System.Drawing.Color.White;
            resources.ApplyResources(this.Code, "Code");
            this.Code.Name = "Code";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.White;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.richTextBox1, "richTextBox1");
            this.richTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(170)))));
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            // 
            // MenuDrop
            // 
            this.MenuDrop.Tick += new System.EventHandler(this.MenuDrop_Tick);
            // 
            // Form4
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.CopyBtnCode1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Code);
            this.Controls.Add(this.Content);
            this.Controls.Add(this.DropContainer);
            this.Name = "Form4";
            this.DropContainer.ResumeLayout(false);
            this.Content.ResumeLayout(false);
            this.Code.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel DropContainer;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button HoverDropBtn;
        private Guna.UI2.WinForms.Guna2GradientPanel Content;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2CircleButton CopyBtnCode1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2GradientPanel Code;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Timer MenuDrop;
    }
}