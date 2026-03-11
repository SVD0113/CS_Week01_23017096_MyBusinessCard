namespace _2_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(45, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(415, 521);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            pictureBox1.MouseEnter += pictureBox1_MouseEnter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label1.ForeColor = Color.PaleVioletRed;
            label1.Location = new Point(586, 232);
            label1.Name = "label1";
            label1.Size = new Size(133, 50);
            label1.TabIndex = 1;
            label1.Text = "최인성";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("맑은 고딕", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label2.ForeColor = Color.ForestGreen;
            label2.Location = new Point(602, 294);
            label2.Name = "label2";
            label2.Size = new Size(107, 25);
            label2.TabIndex = 2;
            label2.Text = "컴퓨터학부";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("맑은 고딕", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label3.ForeColor = Color.IndianRed;
            label3.Location = new Point(731, 508);
            label3.Name = "label3";
            label3.Size = new Size(109, 20);
            label3.TabIndex = 3;
            label3.Text = "010-2647-9391";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("맑은 고딕", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label4.ForeColor = Color.Blue;
            label4.Location = new Point(661, 528);
            label4.Name = "label4";
            label4.Size = new Size(179, 20);
            label4.TabIndex = 4;
            label4.Text = "inseong9391@naver.com";
            label4.Click += label4_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.HotTrack;
            button1.ForeColor = SystemColors.ControlLight;
            button1.Location = new Point(360, 513);
            button1.Name = "button1";
            button1.Size = new Size(100, 35);
            button1.TabIndex = 5;
            button1.Text = "GitHub";
            button1.UseVisualStyleBackColor = false;
            button1.TabStopChanged += False;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.ForeColor = Color.White;
            button2.Location = new Point(156, 65);
            button2.Name = "button2";
            button2.Size = new Size(100, 35);
            button2.TabIndex = 6;
            button2.Text = "배경색상 변경";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.LightPink;
            button3.ForeColor = Color.Red;
            button3.Location = new Point(764, 1);
            button3.Name = "button3";
            button3.Size = new Size(100, 35);
            button3.TabIndex = 7;
            button3.Text = "사진 변경";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            button3.MouseLeave += button3_MouseLeave;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(866, 575);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}
