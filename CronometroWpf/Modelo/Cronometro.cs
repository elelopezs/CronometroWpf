
using System.Windows;
using System;
using System.Windows.Media.Animation;
using System.Collections.Specialized;


namespace CronometroWpf.Modelo
{

    
    public abstract class Cronometro
    {

        public abstract AnimationClock? objCrono { get; set; }
    }


     
     public class Crono : Cronometro
        {
        public Crono(AnimationClock obj, string tiempo, int pausa, Estados? estado)
        {
            objCrono = obj;
            TiempoActual = tiempo;
            Pausas = pausa;
            Estado = estado;
        }

        public override AnimationClock? objCrono { get; set; }

        public string? TiempoActual { get; set; }

        public int Pausas { get; set; }
        public Estados? Estado { get; set; }
        
        public Crono() { }


     }





}




