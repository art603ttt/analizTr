namespace AnalizTrep
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
            this.metroButton_avtoriz = new MetroFramework.Controls.MetroButton();
            this.metroButton_reg = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroButton_avtoriz
            // 
            this.metroButton_avtoriz.Location = new System.Drawing.Point(162, 133);
            this.metroButton_avtoriz.Name = "metroButton_avtoriz";
            this.metroButton_avtoriz.Size = new System.Drawing.Size(126, 48);
            this.metroButton_avtoriz.TabIndex = 0;
            this.metroButton_avtoriz.Text = "Авторизация";
            // 
            // metroButton_reg
            // 
            this.metroButton_reg.Location = new System.Drawing.Point(162, 206);
            this.metroButton_reg.Name = "metroButton_reg";
            this.metroButton_reg.Size = new System.Drawing.Size(126, 48);
            this.metroButton_reg.TabIndex = 1;
            this.metroButton_reg.Text = "Регистрация";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(62, 87);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(330, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Войдите или зарегистрируйтесь чтобы продолжить..";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AnalizTrep.Properties.Resources.zagruzhennoe1;
            this.pictureBox1.Location = new System.Drawing.Point(298, 268);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 269);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 414);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroButton_reg);
            this.Controls.Add(this.metroButton_avtoriz);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButton_avtoriz;
        private MetroFramework.Controls.MetroButton metroButton_reg;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

