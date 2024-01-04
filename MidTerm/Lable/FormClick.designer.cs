namespace midterm_trungthanh
{
    partial class FormClick
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClick));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.hover_demo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1582, 118);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1038, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "- Hover là khi di chuyển con chuột vào label hoặc button,.. nào đó mà không click" +
    ", label hoặc button,... đó sẽ thay đổi thuộc tính";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1023, 70);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.hover_demo);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 133);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1582, 720);
            this.panel2.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(67, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(500, 33);
            this.label4.TabIndex = 2;
            this.label4.Text = "Code Hover hiển thị submenu";
            // 
            // pictureBox3
            // 
            //this.pictureBox3.Image = global::midterm_trungthanh.Properties.Resources.hover;
            this.pictureBox3.Location = new System.Drawing.Point(71, 177);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1053, 306);
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // hover_demo
            // 
            this.hover_demo.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.hover_demo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hover_demo.Location = new System.Drawing.Point(67, 35);
            this.hover_demo.Name = "hover_demo";
            this.hover_demo.Size = new System.Drawing.Size(168, 49);
            this.hover_demo.TabIndex = 5;
            this.hover_demo.Text = "Hover_demo";
            this.hover_demo.MouseEnter += new System.EventHandler(this.hover_demo_MouseHover);
            this.hover_demo.MouseLeave += new System.EventHandler(this.hover_demo_MouseLeave);
            // 
            // FormClick
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1582, 853);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormClick";
            this.Text = "FormClick";
            this.Load += new System.EventHandler(this.FormClick_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label hover_demo;
    }
}