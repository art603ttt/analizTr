using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalizTrep
{
  public  class Ambry:Company
    {

      public  Provider Owner;
      public  Something[] Zakaz=new Something[0];//набор заказов 
      public  Ambry(string log_pass_owner, string name_company)
        {

            this.name_company = name_company;
            Owner = new Provider(log_pass_owner);


        }

    }
}
