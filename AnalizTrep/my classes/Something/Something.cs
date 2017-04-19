using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalizTrep
{
  public  class Something
    {
      public string type_of_thing;
        public string name_thng;
        public string specificat_thng;
        public int count_thing;

        public string from_who;//переменная у постовщика-работа с заказами

        //для складов
        public Something(string type_of_thing, string name_thng, string specificat_thng, int count_thing)
        {

            this.type_of_thing = type_of_thing;
            this.name_thng = name_thng;
            this.specificat_thng = specificat_thng;
            this.count_thing = count_thing;

        }

        //для заказов
        public Something(int count_thing, string type_of_thing, string name_thng, string from_who)
        {

            this.type_of_thing = type_of_thing;
            this.name_thng = name_thng;
           
            this.count_thing = count_thing;
            this.from_who = from_who;

        }
    }
}
