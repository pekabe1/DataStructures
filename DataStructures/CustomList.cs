using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
   public class CustomList<T>
   {
       private T[] dataHodler;

       public bool checkIfTypeIsValid(Type type)
       {
            if (!typeof(Type).IsAssignableFrom(type) )
            {
                throw new ArgumentException();
            }
            return true;
       }

   }
}
