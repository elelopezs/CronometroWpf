
using System.Windows;
using System;
using System.Windows.Media.Animation;

namespace CronometroWpf.Modelo
{


    public class Crono
    {
        


        public AnimationClock objCrono { get; set; }

        public string TiempoActual { get; set; }

        public int Pausas { get; set; }

        public void Stop(Crono crono)
        {
            crono.objCrono.Controller.Stop();
            crono.Pausas = 0;
        }


        public void Iniciar(Crono crono)
        {
            SingleAnimation animacion =
               new SingleAnimation(100, 500, new Duration(TimeSpan.FromSeconds(60)));
            crono.objCrono = animacion.CreateClock();
            crono.objCrono.Controller.Stop();

        }


        public void Start(Crono crono)
        {

            if (crono.TiempoActual == string.Empty || crono.TiempoActual is null)
            {
                crono.objCrono.Controller.Begin();
            }
            crono.objCrono.Controller.Resume();

        }
        public void Pause(Crono crono)
        {

            crono.objCrono.Controller.Pause();
            if (crono.TiempoActual != string.Empty && crono.TiempoActual is not null)
                crono.Pausas += 1;
        }
    }





}




