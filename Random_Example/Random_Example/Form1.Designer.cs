namespace Random_Example
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
            this.lblRand = new System.Windows.Forms.Label();
            this.lblKatse = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pilt1 = new System.Windows.Forms.PictureBox();
            this.pilt2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pilt1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pilt2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRand
            // 
            this.lblRand.AutoSize = true;
            this.lblRand.BackColor = System.Drawing.Color.White;
            this.lblRand.Location = new System.Drawing.Point(73, 106);
            this.lblRand.Name = "lblRand";
            this.lblRand.Size = new System.Drawing.Size(0, 13);
            this.lblRand.TabIndex = 0;
            // 
            // lblKatse
            // 
            this.lblKatse.BackColor = System.Drawing.Color.Transparent;
            this.lblKatse.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblKatse.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblKatse.Location = new System.Drawing.Point(488, 161);
            this.lblKatse.Name = "lblKatse";
            this.lblKatse.Size = new System.Drawing.Size(171, 66);
            this.lblKatse.TabIndex = 1;
            this.lblKatse.Text = "0";
            this.lblKatse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonOk
            // 
            this.buttonOk.Enabled = false;
            this.buttonOk.Location = new System.Drawing.Point(312, 129);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(130, 93);
            this.buttonOk.TabIndex = 2;
            this.buttonOk.Text = "Ок";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(259, 245);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(159, 41);
            this.buttonStart.TabIndex = 3;
            this.buttonStart.Text = "Начнем игру";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(151, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(508, 75);
            this.label1.TabIndex = 4;
            this.label1.Text = "Следи,сколько раз делаешь клик - чтобы\r\nполучить 0 или 10. Помни, каждый клик - 1" +
    "0 евро\r\n\r\n";
            // 
            // pilt1
            // 
            this.pilt1.Image = global::Random_Example.Properties.Resources.Sad;
            this.pilt1.Location = new System.Drawing.Point(105, 363);
            this.pilt1.Name = "pilt1";
            this.pilt1.Size = new System.Drawing.Size(121, 111);
            this.pilt1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pilt1.TabIndex = 5;
            this.pilt1.TabStop = false;
            this.pilt1.Visible = false;
            // 
            // pilt2
            // 
            this.pilt2.Image = global::Random_Example.Properties.Resources.Happy;
            this.pilt2.Location = new System.Drawing.Point(259, 363);
            this.pilt2.Name = "pilt2";
            this.pilt2.Size = new System.Drawing.Size(121, 111);
            this.pilt2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pilt2.TabIndex = 6;
            this.pilt2.TabStop = false;
            this.pilt2.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(569, 312);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 50);
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 532);
            this.splitter1.TabIndex = 8;
            this.splitter1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(523, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Попытки";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 532);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pilt2);
            this.Controls.Add(this.pilt1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.lblKatse);
            this.Controls.Add(this.lblRand);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pilt1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pilt2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRand;
        private System.Windows.Forms.Label lblKatse;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pilt1;
        private System.Windows.Forms.PictureBox pilt2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label label2;
    }
}

