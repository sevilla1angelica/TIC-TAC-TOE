namespace Tic_tac_toe
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn10 = new System.Windows.Forms.Button();
            this.btn11 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.Silver;
            this.btn1.Location = new System.Drawing.Point(84, 121);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(70, 74);
            this.btn1.TabIndex = 0;
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.TextChanged += new System.EventHandler(this.btnclick);
            this.btn1.Click += new System.EventHandler(this.btnclick);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.Silver;
            this.btn2.Location = new System.Drawing.Point(160, 121);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(70, 74);
            this.btn2.TabIndex = 1;
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.TextChanged += new System.EventHandler(this.btnclick);
            this.btn2.Click += new System.EventHandler(this.btnclick);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.Silver;
            this.btn3.Location = new System.Drawing.Point(236, 121);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(70, 75);
            this.btn3.TabIndex = 2;
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.TextChanged += new System.EventHandler(this.btnclick);
            this.btn3.Click += new System.EventHandler(this.btnclick);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.Silver;
            this.btn4.Location = new System.Drawing.Point(84, 199);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(70, 70);
            this.btn4.TabIndex = 3;
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.TextChanged += new System.EventHandler(this.btnclick);
            this.btn4.Click += new System.EventHandler(this.btnclick);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.Silver;
            this.btn5.Location = new System.Drawing.Point(160, 199);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(70, 70);
            this.btn5.TabIndex = 4;
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.TextChanged += new System.EventHandler(this.btnclick);
            this.btn5.Click += new System.EventHandler(this.btnclick);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.Silver;
            this.btn6.Location = new System.Drawing.Point(236, 199);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(70, 70);
            this.btn6.TabIndex = 5;
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.TextChanged += new System.EventHandler(this.btnclick);
            this.btn6.Click += new System.EventHandler(this.btnclick);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.Silver;
            this.btn7.Location = new System.Drawing.Point(84, 275);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(70, 70);
            this.btn7.TabIndex = 6;
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.TextChanged += new System.EventHandler(this.btnclick);
            this.btn7.Click += new System.EventHandler(this.btnclick);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.Silver;
            this.btn8.Location = new System.Drawing.Point(160, 275);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(70, 70);
            this.btn8.TabIndex = 7;
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.TextChanged += new System.EventHandler(this.btnclick);
            this.btn8.Click += new System.EventHandler(this.btnclick);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.Silver;
            this.btn9.Location = new System.Drawing.Point(236, 275);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(70, 70);
            this.btn9.TabIndex = 8;
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.TextChanged += new System.EventHandler(this.btnclick);
            this.btn9.Click += new System.EventHandler(this.btnclick);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Thistle;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(84, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(222, 27);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = "Player X \'s turn now";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn10
            // 
            this.btn10.BackColor = System.Drawing.Color.RosyBrown;
            this.btn10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn10.Location = new System.Drawing.Point(27, 407);
            this.btn10.Name = "btn10";
            this.btn10.Size = new System.Drawing.Size(88, 31);
            this.btn10.TabIndex = 10;
            this.btn10.Text = "Restart";
            this.btn10.UseVisualStyleBackColor = false;
            this.btn10.Click += new System.EventHandler(this.btn10_Click);
            // 
            // btn11
            // 
            this.btn11.BackColor = System.Drawing.Color.RosyBrown;
            this.btn11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn11.Location = new System.Drawing.Point(280, 407);
            this.btn11.Name = "btn11";
            this.btn11.Size = new System.Drawing.Size(88, 31);
            this.btn11.TabIndex = 11;
            this.btn11.Text = "Home";
            this.btn11.UseVisualStyleBackColor = false;
            this.btn11.Click += new System.EventHandler(this.btn11_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(398, 467);
            this.Controls.Add(this.btn11);
            this.Controls.Add(this.btn10);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic-tac-toe...Running";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private TextBox textBox1;
        private Button btn10;
        private Button btn11;
    }
}