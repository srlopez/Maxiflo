using System;
using System.Collections.Generic;


namespace Maxiflo
{
    public class Sistema
    {
       
       public Fraccion Sumar(Fraccion frac1,Fraccion frac2 ){
           var dr=frac1.denom*frac2.denom;
           var nr= (frac1.num * frac2.denom) + (frac1.denom * frac2.num);
           Fraccion fracReslt = new Fraccion(nr, dr);
           return fracReslt;
       }



    }
}
