namespace 로또_프로그램
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.Lotto_num_form = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.num1 = new System.Windows.Forms.Label();
            this.num2 = new System.Windows.Forms.Label();
            this.num3 = new System.Windows.Forms.Label();
            this.num4 = new System.Windows.Forms.Label();
            this.num5 = new System.Windows.Forms.Label();
            this.num6 = new System.Windows.Forms.Label();
            this.bonus = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rr = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.user_save = new System.Windows.Forms.Button();
            this.user1 = new System.Windows.Forms.TextBox();
            this.user2 = new System.Windows.Forms.TextBox();
            this.user3 = new System.Windows.Forms.TextBox();
            this.user4 = new System.Windows.Forms.TextBox();
            this.user5 = new System.Windows.Forms.TextBox();
            this.user6 = new System.Windows.Forms.TextBox();
            this.user_num_save = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lotto_num_form
            // 
            this.Lotto_num_form.AutoSize = true;
            this.Lotto_num_form.BackColor = System.Drawing.Color.White;
            this.Lotto_num_form.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Lotto_num_form.Location = new System.Drawing.Point(127, 225);
            this.Lotto_num_form.Name = "Lotto_num_form";
            this.Lotto_num_form.Size = new System.Drawing.Size(119, 24);
            this.Lotto_num_form.TabIndex = 9;
            this.Lotto_num_form.Text = "추첨 번호";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(30, 213);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(310, 122);
            this.textBox1.TabIndex = 12;
            // 
            // num1
            // 
            this.num1.AutoSize = true;
            this.num1.BackColor = System.Drawing.Color.White;
            this.num1.Location = new System.Drawing.Point(42, 267);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(11, 12);
            this.num1.TabIndex = 13;
            this.num1.Text = "-";
            // 
            // num2
            // 
            this.num2.AutoSize = true;
            this.num2.BackColor = System.Drawing.Color.White;
            this.num2.Location = new System.Drawing.Point(74, 267);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(11, 12);
            this.num2.TabIndex = 14;
            this.num2.Text = "-";
            // 
            // num3
            // 
            this.num3.AutoSize = true;
            this.num3.BackColor = System.Drawing.Color.White;
            this.num3.Location = new System.Drawing.Point(108, 267);
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(11, 12);
            this.num3.TabIndex = 15;
            this.num3.Text = "-";
            // 
            // num4
            // 
            this.num4.AutoSize = true;
            this.num4.BackColor = System.Drawing.Color.White;
            this.num4.Location = new System.Drawing.Point(141, 267);
            this.num4.Name = "num4";
            this.num4.Size = new System.Drawing.Size(11, 12);
            this.num4.TabIndex = 16;
            this.num4.Text = "-";
            // 
            // num5
            // 
            this.num5.AutoSize = true;
            this.num5.BackColor = System.Drawing.Color.White;
            this.num5.Location = new System.Drawing.Point(178, 267);
            this.num5.Name = "num5";
            this.num5.Size = new System.Drawing.Size(11, 12);
            this.num5.TabIndex = 17;
            this.num5.Text = "-";
            // 
            // num6
            // 
            this.num6.AutoSize = true;
            this.num6.BackColor = System.Drawing.Color.White;
            this.num6.Location = new System.Drawing.Point(215, 267);
            this.num6.Name = "num6";
            this.num6.Size = new System.Drawing.Size(11, 12);
            this.num6.TabIndex = 18;
            this.num6.Text = "-";
            // 
            // bonus
            // 
            this.bonus.AutoSize = true;
            this.bonus.BackColor = System.Drawing.Color.White;
            this.bonus.Location = new System.Drawing.Point(311, 267);
            this.bonus.Name = "bonus";
            this.bonus.Size = new System.Drawing.Size(11, 12);
            this.bonus.TabIndex = 19;
            this.bonus.Text = "-";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 291);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 31);
            this.button1.TabIndex = 20;
            this.button1.Text = "번호 생성";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(250, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 21;
            this.label1.Text = "보너스";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(30, 12);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(310, 184);
            this.textBox2.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(76, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 24);
            this.label2.TabIndex = 23;
            this.label2.Text = "번호 입력(1~45)";
            // 
            // rr
            // 
            this.rr.Enabled = false;
            this.rr.Location = new System.Drawing.Point(30, 351);
            this.rr.Multiline = true;
            this.rr.Name = "rr";
            this.rr.Size = new System.Drawing.Size(310, 121);
            this.rr.TabIndex = 31;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(157, 367);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 24);
            this.label10.TabIndex = 32;
            this.label10.Text = "결과";
            // 
            // user_save
            // 
            this.user_save.Location = new System.Drawing.Point(143, 109);
            this.user_save.Name = "user_save";
            this.user_save.Size = new System.Drawing.Size(75, 32);
            this.user_save.TabIndex = 33;
            this.user_save.Text = "저장";
            this.user_save.UseVisualStyleBackColor = true;
            this.user_save.Click += new System.EventHandler(this.button2_Click);
            // 
            // user1
            // 
            this.user1.Location = new System.Drawing.Point(44, 66);
            this.user1.Name = "user1";
            this.user1.Size = new System.Drawing.Size(23, 21);
            this.user1.TabIndex = 34;
            this.user1.Tag = "1";
            // 
            // user2
            // 
            this.user2.Location = new System.Drawing.Point(96, 66);
            this.user2.Name = "user2";
            this.user2.Size = new System.Drawing.Size(23, 21);
            this.user2.TabIndex = 35;
            this.user2.Tag = "2";
            // 
            // user3
            // 
            this.user3.Location = new System.Drawing.Point(145, 66);
            this.user3.Name = "user3";
            this.user3.Size = new System.Drawing.Size(23, 21);
            this.user3.TabIndex = 36;
            this.user3.Tag = "3";
            // 
            // user4
            // 
            this.user4.Location = new System.Drawing.Point(195, 66);
            this.user4.Name = "user4";
            this.user4.Size = new System.Drawing.Size(23, 21);
            this.user4.TabIndex = 37;
            this.user4.Tag = "4";
            // 
            // user5
            // 
            this.user5.Location = new System.Drawing.Point(245, 66);
            this.user5.Name = "user5";
            this.user5.Size = new System.Drawing.Size(23, 21);
            this.user5.TabIndex = 38;
            this.user5.Tag = "5";
            // 
            // user6
            // 
            this.user6.Location = new System.Drawing.Point(298, 66);
            this.user6.Name = "user6";
            this.user6.Size = new System.Drawing.Size(23, 21);
            this.user6.TabIndex = 39;
            this.user6.Tag = "6";
            // 
            // user_num_save
            // 
            this.user_num_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.user_num_save.BackColor = System.Drawing.Color.White;
            this.user_num_save.Enabled = false;
            this.user_num_save.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.user_num_save.ForeColor = System.Drawing.Color.Black;
            this.user_num_save.Location = new System.Drawing.Point(44, 159);
            this.user_num_save.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.user_num_save.MaxLength = 0;
            this.user_num_save.Name = "user_num_save";
            this.user_num_save.Size = new System.Drawing.Size(280, 25);
            this.user_num_save.TabIndex = 41;
            this.user_num_save.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.BackColor = System.Drawing.Color.White;
            this.result.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.result.Location = new System.Drawing.Point(142, 427);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(81, 19);
            this.result.TabIndex = 42;
            this.result.Text = "결과는?";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(247, 291);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(77, 31);
            this.button3.TabIndex = 45;
            this.button3.Text = "결과 보기";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(378, 497);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.result);
            this.Controls.Add(this.user_num_save);
            this.Controls.Add(this.user6);
            this.Controls.Add(this.user5);
            this.Controls.Add(this.user4);
            this.Controls.Add(this.user3);
            this.Controls.Add(this.user2);
            this.Controls.Add(this.user1);
            this.Controls.Add(this.user_save);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.rr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bonus);
            this.Controls.Add(this.num6);
            this.Controls.Add(this.num5);
            this.Controls.Add(this.num4);
            this.Controls.Add(this.num3);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.Lotto_num_form);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "로또 프로그램";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Lotto_num_form;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label num1;
        private System.Windows.Forms.Label num2;
        private System.Windows.Forms.Label num3;
        private System.Windows.Forms.Label num4;
        private System.Windows.Forms.Label num5;
        private System.Windows.Forms.Label num6;
        private System.Windows.Forms.Label bonus;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox rr;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button user_save;
        private System.Windows.Forms.TextBox user1;
        private System.Windows.Forms.TextBox user2;
        private System.Windows.Forms.TextBox user3;
        private System.Windows.Forms.TextBox user4;
        private System.Windows.Forms.TextBox user5;
        private System.Windows.Forms.TextBox user6;
        private System.Windows.Forms.TextBox user_num_save;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Button button3;
    }
}

