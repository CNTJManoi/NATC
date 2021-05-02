namespace Kosti
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Player1_1 = new System.Windows.Forms.Label();
            this.Play1Player = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Play2Player = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Player1_2 = new System.Windows.Forms.Label();
            this.Player2_2 = new System.Windows.Forms.Label();
            this.Player2_1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.sumPl1 = new System.Windows.Forms.Label();
            this.sumPl2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(100, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "1 Игрок";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(531, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "2 Игрок";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(100, 137);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Баллы";
            // 
            // Player1_1
            // 
            this.Player1_1.BackColor = System.Drawing.SystemColors.Control;
            this.Player1_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Player1_1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Player1_1.Location = new System.Drawing.Point(79, 171);
            this.Player1_1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Player1_1.Name = "Player1_1";
            this.Player1_1.Size = new System.Drawing.Size(53, 48);
            this.Player1_1.TabIndex = 4;
            this.Player1_1.Text = "0";
            this.Player1_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Play1Player
            // 
            this.Play1Player.BackColor = System.Drawing.Color.Blue;
            this.Play1Player.Enabled = false;
            this.Play1Player.ForeColor = System.Drawing.Color.White;
            this.Play1Player.Location = new System.Drawing.Point(57, 256);
            this.Play1Player.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Play1Player.Name = "Play1Player";
            this.Play1Player.Size = new System.Drawing.Size(171, 39);
            this.Play1Player.TabIndex = 8;
            this.Play1Player.Text = "Играет 1 игрок";
            this.Play1Player.UseVisualStyleBackColor = false;
            this.Play1Player.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.ForestGreen;
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(229, 345);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(249, 47);
            this.button2.TabIndex = 9;
            this.button2.Text = "Начать новую игру";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Play2Player
            // 
            this.Play2Player.BackColor = System.Drawing.Color.Blue;
            this.Play2Player.Enabled = false;
            this.Play2Player.ForeColor = System.Drawing.Color.White;
            this.Play2Player.Location = new System.Drawing.Point(488, 256);
            this.Play2Player.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Play2Player.Name = "Play2Player";
            this.Play2Player.Size = new System.Drawing.Size(171, 39);
            this.Play2Player.TabIndex = 10;
            this.Play2Player.Text = "Играет 2 игрок";
            this.Play2Player.UseVisualStyleBackColor = false;
            this.Play2Player.Click += new System.EventHandler(this.Play2Player_Click);
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.result.Location = new System.Drawing.Point(228, 471);
            this.result.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(0, 23);
            this.result.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(136, 471);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 23);
            this.label10.TabIndex = 12;
            this.label10.Text = "Результат:";
            // 
            // Player1_2
            // 
            this.Player1_2.BackColor = System.Drawing.SystemColors.Control;
            this.Player1_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Player1_2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Player1_2.Location = new System.Drawing.Point(147, 171);
            this.Player1_2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Player1_2.Name = "Player1_2";
            this.Player1_2.Size = new System.Drawing.Size(53, 48);
            this.Player1_2.TabIndex = 13;
            this.Player1_2.Text = "0";
            this.Player1_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Player2_2
            // 
            this.Player2_2.BackColor = System.Drawing.SystemColors.Control;
            this.Player2_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Player2_2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Player2_2.Location = new System.Drawing.Point(580, 171);
            this.Player2_2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Player2_2.Name = "Player2_2";
            this.Player2_2.Size = new System.Drawing.Size(53, 48);
            this.Player2_2.TabIndex = 14;
            this.Player2_2.Text = "0";
            this.Player2_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Player2_1
            // 
            this.Player2_1.BackColor = System.Drawing.SystemColors.Control;
            this.Player2_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Player2_1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Player2_1.Location = new System.Drawing.Point(519, 171);
            this.Player2_1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Player2_1.Name = "Player2_1";
            this.Player2_1.Size = new System.Drawing.Size(53, 48);
            this.Player2_1.TabIndex = 15;
            this.Player2_1.Text = "0";
            this.Player2_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(534, 137);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 24);
            this.label5.TabIndex = 16;
            this.label5.Text = "Баллы";
            // 
            // sumPl1
            // 
            this.sumPl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sumPl1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sumPl1.Location = new System.Drawing.Point(71, 100);
            this.sumPl1.Name = "sumPl1";
            this.sumPl1.Size = new System.Drawing.Size(149, 37);
            this.sumPl1.TabIndex = 17;
            this.sumPl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sumPl2
            // 
            this.sumPl2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sumPl2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sumPl2.Location = new System.Drawing.Point(501, 100);
            this.sumPl2.Name = "sumPl2";
            this.sumPl2.Size = new System.Drawing.Size(149, 37);
            this.sumPl2.TabIndex = 19;
            this.sumPl2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 613);
            this.Controls.Add(this.sumPl2);
            this.Controls.Add(this.sumPl1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Player2_1);
            this.Controls.Add(this.Player2_2);
            this.Controls.Add(this.Player1_2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.result);
            this.Controls.Add(this.Play2Player);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Play1Player);
            this.Controls.Add(this.Player1_1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Player1_1;
        private System.Windows.Forms.Button Play1Player;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Play2Player;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label Player1_2;
        private System.Windows.Forms.Label Player2_2;
        private System.Windows.Forms.Label Player2_1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label sumPl1;
        private System.Windows.Forms.Label sumPl2;
    }
}

