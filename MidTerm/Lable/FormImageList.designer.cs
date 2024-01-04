namespace midterm_trungthanh
{
    partial class FormImageList
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
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1023, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "-Định nghĩa: Lấy hoặc đặt ImageList chứa hình ảnh để hiển thị trong điều khiển Nh" +
    "ãn(label control)";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(500, 33);
            this.label7.TabIndex = 4;
            this.label7.Text = "Ex:";
            // 
            // pictureBox2
            // 
            //this.pictureBox2.Image = global::midterm_trungthanh.Properties.Resources.exgt_img;
            this.pictureBox2.Location = new System.Drawing.Point(25, 210);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1198, 624);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            //this.pictureBox1.Image = global::midterm_trungthanh.Properties.Resources.gt_img;
            this.pictureBox1.Location = new System.Drawing.Point(25, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(766, 135);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // FormImageList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 846);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "FormImageList";
            this.Text = "FormImageList";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}