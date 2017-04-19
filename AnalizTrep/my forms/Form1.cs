using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AnalizTrep
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {


        StreamReader Myreader;
        Form_avtoriz f_avtoriz;
        Form_regist  f_registr;

        Company[] all_compan=new Company[0];//информация о всех компаниях

        Ambry avtor_ambry;//ссылка на авториз.компанию(если склад)
        Pharmasy avtor_pharm;//ссылка на авториз.компанию(если аптека)


       
        public Form1()
        {
            InitializeComponent();
            
        }



        //события
        //загрузка формы
        private void Form1_Load(object sender, EventArgs e)
        {
           method_read_from_file();
        }
        //авторизация
        private void metroButton_avtoriz_Click(object sender, EventArgs e)
        {
            f_avtoriz = new Form_avtoriz(this);
            f_avtoriz.ShowDialog();
            
        }
        //регистрация
        private void metroButton_reg_Click(object sender, EventArgs e)
        {
            f_registr = new Form_regist(this);
            f_registr.ShowDialog();
        }

        //метод
       /* bool method_avtoriz(string login,string password)
        {


        }*/
        void method_read_from_file()//считывание с файла данных об клиниках,поставщиках,персонале и вещах
        {
            Myreader = new StreamReader("My_file.txt");
            string s_help;
            string login_password;

            Array.Resize(ref all_compan,0);//обнуляем данные

            while((s_help=Myreader.ReadLine())!=null)
            {
                Array.Resize(ref all_compan, all_compan.Length + 1);

                if(s_help=="Pharmasy")
                {
                    add_Pharm();


                }
                if(s_help=="Ambry")
                {

                    add_Ambry();


                }


            }

        }
        //метод-добавление вет клиники
        void add_Pharm()
        {
            
            string login_password;
            int kolvo_vet;
            string name_company;
            int kolvo_Some;

            name_company = Myreader.ReadLine();//считываем название 
            login_password = Myreader.ReadLine();//считываем логин пароль
            kolvo_vet = int.Parse(Myreader.ReadLine());//считываем кол-во ветеринаров

            

            //инициализируем клинику-создаем диреектора,имя клиники
            all_compan[all_compan.Length - 1] = new Pharmasy(kolvo_vet, login_password, name_company);


            //записуем ветврачей
            for (int i = 0; i < kolvo_vet; i++)
            {
                login_password = Myreader.ReadLine();//считываем логин-пароль ветврача

                Pharmasy ph_farm = (Pharmasy)all_compan[all_compan.Length - 1];
                Vet hlp_vet = new Vet(login_password);

                ph_farm.Personal[i] = hlp_vet;

            }

            //считываем проверочный символ
            if (Myreader.ReadLine() != "%") MessageBox.Show("отсутсвует проверочный символ после списка врачей");

            kolvo_Some= int.Parse(Myreader.ReadLine());//считываем колво вещей

           
            Array.Resize(ref all_compan[all_compan.Length - 1].SOME, kolvo_Some);
            //записуем инструменты и лекарства на складе
            for (int i = 0; i < kolvo_Some; i++)
            { 
                string s = Myreader.ReadLine();
                string[] splitt = s.Split(' ');


                Pharmasy ph_farm = (Pharmasy)all_compan[all_compan.Length - 1];
                Something S_help = new Something(splitt[0], splitt[1], splitt[2], int.Parse(splitt[3]));


               
                ph_farm.SOME[i] = S_help;
               

            }

            if (Myreader.ReadLine() != "/////") MessageBox.Show("отсутсвует проверочный символ после списка вещей");



        }
        void add_Ambry()
        {
            string login_password;
            string name_company;
            int kolvo_Some;

            int kolvo_zayav;

            name_company = Myreader.ReadLine();//считываем название 
            login_password = Myreader.ReadLine();//считываем логин пароль

            //инициализируем хранилище-создаем диреектора,имя клиники
            all_compan[all_compan.Length - 1] = new Ambry(login_password, name_company);


            

            //считываем проверочный символ
            if (Myreader.ReadLine() != "%") MessageBox.Show("отсутсвует проверочный в хранилище");

            kolvo_Some = int.Parse(Myreader.ReadLine());//считываем кол-во вещей

            
            Array.Resize(ref all_compan[all_compan.Length - 1].SOME, kolvo_Some);
            //записуем инструменты и лекарства на складе
            for (int i = 0; i < kolvo_Some; i++)
            {
                string s = Myreader.ReadLine();
                string[] splitt = s.Split(' ');


                Ambry ph_ambry=(Ambry)all_compan[all_compan.Length - 1];
                Something S_help = new Something(splitt[0], splitt[1], splitt[2], int.Parse(splitt[3]));



                ph_ambry.SOME[i] = S_help;


            }

            if (Myreader.ReadLine() != "%") MessageBox.Show("отсутсвует проверочный в хранилище");
           
            //записуем заявки
            kolvo_zayav = int.Parse(Myreader.ReadLine());//считываем кол-во вещей
            Ambry ph_ambry1 = (Ambry)all_compan[all_compan.Length - 1];

            
            Array.Resize(ref ph_ambry1.Zakaz,kolvo_zayav);
            //записуем инструменты и лекарства в заявках
            for (int i = 0; i < kolvo_zayav; i++)
            {
                string s = Myreader.ReadLine();
                string[] splitt = s.Split(' ');


                Ambry ph_ambry = (Ambry)all_compan[all_compan.Length - 1];
                Something S_help = new Something(int.Parse(splitt[0]), splitt[1], splitt[2], splitt[3]);



                ph_ambry.Zakaz[i] = S_help;


            }
            if (Myreader.ReadLine() != "/////") MessageBox.Show("отсутсвует проверочный символ после списка вещей");





        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("В системе зарегистрированно " + (all_compan.Length+1)+ " компания(-ий)");
        }
    }
}
