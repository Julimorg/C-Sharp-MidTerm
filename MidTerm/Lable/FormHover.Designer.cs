namespace midterm_trungthanh
{
    partial class FormHover
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
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel_demo_click = new System.Windows.Forms.Panel();
            this.demo_label = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(407, 1381);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(759, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "- Click là sự kiện nhấn chuột vào label.";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 386);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(759, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "  Nháy đúp vào label để tạo nhanh event click.";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 639);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 65);
            this.label5.TabIndex = 0;
            this.label5.Text = "CODE function";
            // 
            // panel_demo_click
            // 
            this.panel_demo_click.Location = new System.Drawing.Point(227, 68);
            this.panel_demo_click.Name = "panel_demo_click";
            this.panel_demo_click.Size = new System.Drawing.Size(563, 285);
            this.panel_demo_click.TabIndex = 6;
            // 
            // demo_label
            // 
            this.demo_label.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.demo_label.Location = new System.Drawing.Point(49, 68);
            this.demo_label.Name = "demo_label";
            this.demo_label.Size = new System.Drawing.Size(172, 48);
            this.demo_label.TabIndex = 0;
            this.demo_label.Text = "Demo label";
            this.demo_label.Click += new System.EventHandler(this.demo_label_Click);
            // 
            // pictureBox2
            // 
            //this.pictureBox2.Image = global::midterm_trungthanh.Properties.Resources.clikc_demo;
            this.pictureBox2.Location = new System.Drawing.Point(246, 433);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(840, 207);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            //this.pictureBox1.BackgroundImage = global::midterm_trungthanh.Properties.Resources.code;
            //this.pictureBox1.Image = global::midterm_trungthanh.Properties.Resources.openform_demo;
            this.pictureBox1.Location = new System.Drawing.Point(246, 646);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(934, 498);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FormHover
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1292, 639);
            this.Controls.Add(this.demo_label);
            this.Controls.Add(this.panel_demo_click);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Name = "FormHover";
            this.Text = "FormHover";
            this.Load += new System.EventHandler(this.FormHover_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel_demo_click;
        private System.Windows.Forms.Label demo_label;
    }
}