
using System.Windows;
using System;
using System.Windows.Media.Animation;
using CronometroWpf.Modelo;

namespace CronometroWpf.Data
{
    public class CronometroData
    {


        public void Iniciar(Crono crono)
        {
            SingleAnimation animacion =
               new SingleAnimation(100, 500, new Duration(TimeSpan.FromSeconds(60)));
            crono.objCrono = animacion.CreateClock();
            crono.objCrono.Controller.Stop();

        }


        public void Start(Crono crono)
        {

            if (crono.TiempoActual == string.Empty || crono.TiempoActual is null )
            {
                crono.objCrono.Controller.Begin();
            }
            crono.objCrono.Controller.Resume();

        }
        public void Pause(Crono crono)
        {

            crono.objCrono.Controller.Pause();
            if (crono.TiempoActual !=  string.Empty && crono.TiempoActual is not null)
                crono.Pausas += 1;
        }

        public void Stop(Crono crono)
        {
            crono.objCrono.Controller.Stop();
            crono.Pausas = 0;
        }

        public void miCrono_CurrentTime(Crono crono)
        {

        }
    }
}
