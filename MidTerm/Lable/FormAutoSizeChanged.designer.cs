namespace midterm_trungthanh
{
    partial class FormAutoSizeChanged
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1482, 106);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1023, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "- Xảy ra khi giá trị của thuộc tính AutoSize thay đổi.";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(500, 33);
            this.label7.TabIndex = 4;
            this.label7.Text = "Code AutoSize Changed";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(500, 33);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ex:";
            // 
            // pictureBox2
            // 
            //this.pictureBox2.Image = global::midterm_trungthanh.Properties.Resources.autosize_img;
            this.pictureBox2.Location = new System.Drawing.Point(28, 165);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(743, 163);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            //this.pictureBox1.Image = global::midterm_trungthanh.Properties.Resources.ex_autosize_IMG;
            this.pictureBox1.Location = new System.Drawing.Point(28, 414);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(959, 282);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1023, 37);
            this.label3.TabIndex = 3;
            this.label3.Text = "ví dụ: label sẽ dựa vào độ dài của text bên trong label để tạo ra frame phù hợp";
            // 
            // FormAutoSizeChanged
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 846);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Name = "FormAutoSizeChanged";
            this.Text = "FormAutoSizeChanged";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
    }
}