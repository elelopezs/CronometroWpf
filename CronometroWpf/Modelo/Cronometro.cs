
using System.Windows;
using System;
using System.Windows.Media.Animation;
using System.Collections.Specialized;


namespace CronometroWpf.Modelo
{

    
    public abstract class Cronometro
    {
        //public abstract Cronometro(AnimationClock obj)
        //{
        //    objCrono = obj;
        //    //TiempoActual = Tiempo;
        //    //Pausas = pausa;
        //}
        public abstract AnimationClock? objCrono { get; set; }
    }


     // Segundo principio Open --> close
     public class Crono : Cronometro
        {
        public Crono(AnimationClock obj, string tiempo, int pausa)//, Estados? estado)
        {
            objCrono = obj;
            TiempoActual = tiempo;
            Pausas = pausa;
            //Estado = estado;
        }

        public override AnimationClock? objCrono { get; set; }

        public string? TiempoActual { get; set; }

        public int Pausas { get; set; }
        
        public Crono() { }

       // public Estados? Estado;

       
     

        //public void Stop(Cronometro crono)
        //{
        //    crono.objCrono.Controller.Stop();
        //    crono.Pausas = 0;
        //}


        //public void Iniciar(Cronometro crono)
        //{
        //    //SingleAnimation animacion =
        //    //   new SingleAnimation(100, 500, new Duration(TimeSpan.FromSeconds(60)));
        //    //crono.objCrono = animacion.CreateClock();
        //    crono.objCrono.Controller.Stop();

        //}


        //public void Start(Cronometro crono)
        //{

        //    if (crono.TiempoActual == string.Empty || crono.TiempoActual is null)
        //    {
        //        crono.objCrono.Controller.Begin();
        //    }
        //    crono.objCrono.Controller.Resume();

        //}
        //public void Pause(Cronometro crono)
        //{

        //    crono.objCrono.Controller.Pause();
        //    if (crono.TiempoActual != string.Empty && crono.TiempoActual is not null)
        //        crono.Pausas += 1;
        //}
     }





}




