using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Animation;
using System.Windows;
using CronometroWpf.Modelo;

namespace CronometroWpf.Interface
{
    //interface ICrono
    //{
    //    void Iniciar();
    //}


    //public class Crono : ICrono
    //{
    //    public void Iniciar();
    //}

    //class Cronometro
    //{
    //    private ICrono _crono;
    //    public Cronometro(ICrono crono)
    //    {

    //        _crono = crono;
    //    }

    //    public void Inicio()
    //    {
    //        _crono.Iniciar();


    //    }






    //    public static void Iniciar()
    //    {

    //    }
    //}

    public interface IIniciarCronometro
    {
        void Iniciar(Crono crono);
    }
    public interface IEncenderCronometro
    {
        void Encender(Crono crono);
    }

    public interface IPausarCronometro
    {
        void Pausar(Crono crono);
    }

    public interface IDetenerCronometro
    {
        void Detener(Crono crono);
         
    }


    public class AcciomesCronometro : IIniciarCronometro, IEncenderCronometro, IPausarCronometro, IDetenerCronometro 
    {

        
        public void Iniciar(Crono crono)
        {
            SingleAnimation animacion =
                     new SingleAnimation(100, 500, new Duration(TimeSpan.FromSeconds(60)));
            crono.objCrono = animacion.CreateClock();
            crono.objCrono.Controller.Stop();

        }

        public void Encender(Crono crono)
        {


            if (crono.TiempoActual == string.Empty || crono.TiempoActual is null)
            {
                crono.objCrono.Controller.Begin();
            }
            crono.objCrono.Controller.Resume();

        }

        public void Pausar(Crono crono)
        {

            crono.objCrono.Controller.Pause();
            if (crono.TiempoActual != string.Empty && crono.TiempoActual is not null)
                crono.Pausas += 1;
        }

        public void Detener(Crono crono)
        {
            crono.objCrono.Controller.Stop();
            crono.Pausas = 0;
        }

    }


}