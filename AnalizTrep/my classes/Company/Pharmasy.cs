using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalizTrep
{
   public class Pharmasy:Company
    {
      public  Vet[] Personal=new Vet[0];
      public  directory Direc;


       public Pharmasy(int N,string log_pass_direct,string name_company)
        {
            Array.Resize(ref Personal, N);
            Direc = new directory(log_pass_direct);
            this.name_company = name_company;
          



        }
        

    }
}
