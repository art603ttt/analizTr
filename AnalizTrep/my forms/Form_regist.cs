using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnalizTrep
{
    public partial class Form_regist : MetroFramework.Forms.MetroForm
    {
        public Form_regist()
        {
            InitializeComponent();
        }
        Form1 f_help;
        public Form_regist(Form1 f)
        {
            f_help = f;
            InitializeComponent();
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox_vet.Visible = false;
            groupBox_direct.Visible = false;
            metroButton_ready.Enabled = false;

            metroComboBox_dolzhnost.Items.Add("ветеринар");
            metroComboBox_dolzhnost.Items.Add("Директор");
            metroComboBox_dolzhnost.Items.Add("Поставщик");
        }

        //событие-выбрана должность
        private void metroComboBox_dolzhnost_TextChanged(object sender, EventArgs e)
        {
            metroComboBox_dolzhnost.Enabled = false;
            if (metroComboBox_dolzhnost.Text== "Директор"|| metroComboBox_dolzhnost.Text == "Поставщик")
            {
                groupBox2.Visible = true;
                groupBox_direct.Visible =true;

            }
            else
            {
                groupBox_vet.Visible = true;
                groupBox2.Visible = true;


            }

            
        }
    }
}
