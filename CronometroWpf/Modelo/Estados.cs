using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CronometroWpf.Modelo
{
    public abstract class Estados
    {
        

        public Estados(string nombre) {
            nombre = nombre.Trim();
     
        }

        public enum  Nombre
        {
            Start,Pause,Stop
        }


    }
}
