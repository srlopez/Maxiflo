using System;
using System.Collections.Generic;

namespace Maxiflo
{
    public class Sistema
    {
       
       public string Sumar(int n1, int d1, int n2, int d2){
           var nr= n1*d2 + n2*d1;
           var dr= d2*d1;
           return $"{nr}/{dr}";
       }


    }
}
