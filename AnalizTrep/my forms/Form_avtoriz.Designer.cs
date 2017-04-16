namespace AnalizTrep
{
    partial class Form_avtoriz
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox_login = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox_pswrd = new MetroFramework.Controls.MetroTextBox();
            this.metroTile_vhod = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(131, 97);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(97, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "введите логин";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(131, 170);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(105, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "введите пароль";
            // 
            // metroTextBox_login
            // 
            this.metroTextBox_login.Location = new System.Drawing.Point(123, 130);
            this.metroTextBox_login.Name = "metroTextBox_login";
            this.metroTextBox_login.Size = new System.Drawing.Size(114, 23);
            this.metroTextBox_login.TabIndex = 2;
            // 
            // metroTextBox_pswrd
            // 
            this.metroTextBox_pswrd.Location = new System.Drawing.Point(123, 206);
            this.metroTextBox_pswrd.Name = "metroTextBox_pswrd";
            this.metroTextBox_pswrd.Size = new System.Drawing.Size(114, 23);
            this.metroTextBox_pswrd.TabIndex = 3;
            // 
            // metroTile_vhod
            // 
            this.metroTile_vhod.Location = new System.Drawing.Point(240, 274);
            this.metroTile_vhod.Name = "metroTile_vhod";
            this.metroTile_vhod.Size = new System.Drawing.Size(149, 57);
            this.metroTile_vhod.TabIndex = 4;
            this.metroTile_vhod.Text = "Войти";
            // 
            // Form_avtoriz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 354);
            this.Controls.Add(this.metroTile_vhod);
            this.Controls.Add(this.metroTextBox_pswrd);
            this.Controls.Add(this.metroTextBox_login);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "Form_avtoriz";
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox metroTextBox_login;
        private MetroFramework.Controls.MetroTextBox metroTextBox_pswrd;
        private MetroFramework.Controls.MetroTile metroTile_vhod;
    }
}