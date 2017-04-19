namespace AnalizTrep
{
    partial class Form_regist
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
            this.metroButton_ready = new MetroFramework.Controls.MetroButton();
            this.metroTextBox_login = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox_psswrd = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroComboBox_dolzhnost = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox_direct = new System.Windows.Forms.GroupBox();
            this.metroTextBox_companyname = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.groupBox_vet = new System.Windows.Forms.GroupBox();
            this.metroComboBox_companys = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox_direct.SuspendLayout();
            this.groupBox_vet.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroButton_ready
            // 
            this.metroButton_ready.Location = new System.Drawing.Point(370, 358);
            this.metroButton_ready.Name = "metroButton_ready";
            this.metroButton_ready.Size = new System.Drawing.Size(110, 39);
            this.metroButton_ready.TabIndex = 0;
            this.metroButton_ready.Text = "Готово!";
            // 
            // metroTextBox_login
            // 
            this.metroTextBox_login.Location = new System.Drawing.Point(15, 38);
            this.metroTextBox_login.Name = "metroTextBox_login";
            this.metroTextBox_login.Size = new System.Drawing.Size(110, 23);
            this.metroTextBox_login.TabIndex = 1;
            // 
            // metroTextBox_psswrd
            // 
            this.metroTextBox_psswrd.Location = new System.Drawing.Point(15, 86);
            this.metroTextBox_psswrd.Name = "metroTextBox_psswrd";
            this.metroTextBox_psswrd.Size = new System.Drawing.Size(110, 23);
            this.metroTextBox_psswrd.TabIndex = 2;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(6, 16);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(172, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Выберите вашу должность";
            // 
            // metroComboBox_dolzhnost
            // 
            this.metroComboBox_dolzhnost.FormattingEnabled = true;
            this.metroComboBox_dolzhnost.ItemHeight = 23;
            this.metroComboBox_dolzhnost.Location = new System.Drawing.Point(8, 38);
            this.metroComboBox_dolzhnost.Name = "metroComboBox_dolzhnost";
            this.metroComboBox_dolzhnost.Size = new System.Drawing.Size(121, 29);
            this.metroComboBox_dolzhnost.TabIndex = 4;
            this.metroComboBox_dolzhnost.TextChanged += new System.EventHandler(this.metroComboBox_dolzhnost_TextChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(15, 16);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(123, 19);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "Придумайте логин";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(15, 64);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(131, 19);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "Придумайте пароль";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.metroComboBox_dolzhnost);
            this.groupBox1.Location = new System.Drawing.Point(23, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(195, 81);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Общее";
            // 
            // groupBox_direct
            // 
            this.groupBox_direct.Controls.Add(this.metroTextBox_companyname);
            this.groupBox_direct.Controls.Add(this.metroLabel4);
            this.groupBox_direct.Location = new System.Drawing.Point(5, 26);
            this.groupBox_direct.Name = "groupBox_direct";
            this.groupBox_direct.Size = new System.Drawing.Size(195, 124);
            this.groupBox_direct.TabIndex = 8;
            this.groupBox_direct.TabStop = false;
            this.groupBox_direct.Text = "Директор/Поставщик";
            // 
            // metroTextBox_companyname
            // 
            this.metroTextBox_companyname.Location = new System.Drawing.Point(8, 59);
            this.metroTextBox_companyname.Name = "metroTextBox_companyname";
            this.metroTextBox_companyname.Size = new System.Drawing.Size(110, 23);
            this.metroTextBox_companyname.TabIndex = 6;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(8, 27);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(186, 19);
            this.metroLabel4.TabIndex = 5;
            this.metroLabel4.Text = "Введите название компании";
            // 
            // groupBox_vet
            // 
            this.groupBox_vet.Controls.Add(this.metroComboBox_companys);
            this.groupBox_vet.Controls.Add(this.metroLabel5);
            this.groupBox_vet.Location = new System.Drawing.Point(228, 26);
            this.groupBox_vet.Name = "groupBox_vet";
            this.groupBox_vet.Size = new System.Drawing.Size(234, 124);
            this.groupBox_vet.TabIndex = 9;
            this.groupBox_vet.TabStop = false;
            this.groupBox_vet.Text = "Вет врач";
            // 
            // metroComboBox_companys
            // 
            this.metroComboBox_companys.FormattingEnabled = true;
            this.metroComboBox_companys.ItemHeight = 23;
            this.metroComboBox_companys.Location = new System.Drawing.Point(6, 49);
            this.metroComboBox_companys.Name = "metroComboBox_companys";
            this.metroComboBox_companys.Size = new System.Drawing.Size(121, 29);
            this.metroComboBox_companys.TabIndex = 5;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(6, 16);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(218, 19);
            this.metroLabel5.TabIndex = 7;
            this.metroLabel5.Text = "К какой компании вы относитесь?";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.metroLabel2);
            this.groupBox3.Controls.Add(this.metroTextBox_login);
            this.groupBox3.Controls.Add(this.metroTextBox_psswrd);
            this.groupBox3.Controls.Add(this.metroLabel3);
            this.groupBox3.Location = new System.Drawing.Point(23, 312);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(195, 130);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox_vet);
            this.groupBox2.Controls.Add(this.groupBox_direct);
            this.groupBox2.Location = new System.Drawing.Point(23, 150);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(478, 156);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // Form_regist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 454);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.metroButton_ready);
            this.Name = "Form_regist";
            this.Text = "Регистрация";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox_direct.ResumeLayout(false);
            this.groupBox_direct.PerformLayout();
            this.groupBox_vet.ResumeLayout(false);
            this.groupBox_vet.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButton_ready;
        private MetroFramework.Controls.MetroTextBox metroTextBox_login;
        private MetroFramework.Controls.MetroTextBox metroTextBox_psswrd;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox metroComboBox_dolzhnost;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox_direct;
        private MetroFramework.Controls.MetroTextBox metroTextBox_companyname;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.GroupBox groupBox_vet;
        private MetroFramework.Controls.MetroComboBox metroComboBox_companys;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}