namespace midterm_trungthanh
{
    partial class FormkeyDownPressUp
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
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1023, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "- Key Down, Key Press :Xảy ra khi người dùng nhấn một phím trong khi label đang đ" +
    "ược lấy nét.";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1023, 37);
            this.label3.TabIndex = 4;
            this.label3.Text = "- Key Up: Xảy ra khi người dùng nhả một phím trong khi nhãn đang có tiêu điểm.";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(500, 33);
            this.label7.TabIndex = 5;
            this.label7.Text = "Code Key Press/Down/Up";
            // 
            // pictureBox1
            // 
            //this.pictureBox1.Image = global::midterm_trungthanh.Properties.Resources.key_img;
            this.pictureBox1.Location = new System.Drawing.Point(34, 239);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(892, 415);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // FormkeyDownPressUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 846);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "FormkeyDownPressUp";
            this.Text = "FormkeyDownPressUp";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}