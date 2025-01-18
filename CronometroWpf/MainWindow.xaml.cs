using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using CronometroWpf.Modelo;
using CronometroWpf.Data;


namespace CronometroWpf {
    public partial class PublicMain :  Window    {
        const int txtWidth = 200;
        const int btnWidth = 200;
        private TextBlock txtTiempo;
        private TextBlock txtUltimoTiempo;
        private TextBlock txtPausas;
        private CronometroData cronometroData = new CronometroData();
        private Crono miCrono;

        public PublicMain()
        {
            miCrono = new Crono();
            
            this.Background = Brushes.Blue;

            StackPanel panelPrincipal = new StackPanel();
            panelPrincipal.Margin = new Thickness(100);
     

            Label lblTitulo = new Label();
            lblTitulo.Content = "Prueba de cronómetro con principios SOLID.    Autor: Ing Eleazar López.";
            lblTitulo.Background = Brushes.Aqua;
            lblTitulo.FontSize = 18;
            lblTitulo.FontStyle = FontStyles.Italic ;
             
            StackPanel panelCrono = new StackPanel();
            panelCrono.Margin = new Thickness(10);

            //Tiempo actual....

            StackPanel aPanel = new StackPanel();
            Label aLabel = new Label();
            aPanel.Orientation = Orientation.Horizontal;
            aLabel.Content = "Tiempo: ";
            aLabel.Width = 100;
            aPanel.Children.Add(aLabel);
            txtTiempo = new TextBlock();
            txtTiempo.Background = Brushes.White;
            txtTiempo.Width = txtWidth;
            txtTiempo.VerticalAlignment = VerticalAlignment.Center;
            aPanel.Children.Add(txtTiempo);
            panelCrono.Children.Add(aPanel);

            //Pausas....

            aPanel = new StackPanel();
            aLabel = new Label();
            aPanel.Orientation = Orientation.Horizontal;
            aLabel.Content = "Pausas: ";
            aLabel.Width = 100;
            aPanel.Children.Add(aLabel);
            txtPausas = new TextBlock();
            txtPausas.Background = Brushes.White;
            txtPausas.Width = txtWidth ;
            txtPausas.VerticalAlignment = VerticalAlignment.Center;
            aPanel.Children.Add(txtPausas);
            panelCrono.Children.Add(aPanel);

            //Último tiempo....

            aPanel = new StackPanel();
            aLabel = new Label();
            aPanel.Orientation = Orientation.Horizontal;
            aLabel.Content = "Último tiempo: ";
            aLabel.Width = 100;
            aPanel.Children.Add(aLabel);
            txtUltimoTiempo = new TextBlock();
            txtUltimoTiempo.Background = Brushes.White;
            txtUltimoTiempo.Width = txtWidth;
            txtUltimoTiempo.VerticalAlignment = VerticalAlignment.Center;                    
            aPanel.Children.Add(txtUltimoTiempo);
            panelCrono.Children.Add(aPanel);


            StackPanel panelButton = new StackPanel();
            panelButton.Orientation = Orientation.Horizontal;

            Button btnStart = new Button();
            btnStart.Content = "Start";
            btnStart.Width = btnWidth;
            btnStart.Click += new RoutedEventHandler(btnStart_Clicked);
            panelButton.Children.Add(btnStart);

            Button btnPause = new Button();
            btnPause.Content = "Pause";
            btnPause.Width = btnWidth;
            btnPause.Click += new RoutedEventHandler(btnPausa_Clicked);
            panelButton.Children.Add(btnPause);

            Button btnStop = new Button();
            btnStop.Content = "Stop";
            btnStop.Width = btnWidth;
            btnStop.Click += new RoutedEventHandler(btnStop_Clicked);
            panelButton.Children.Add(btnStop);

            // Agrego los panel
            panelPrincipal.Children.Add(lblTitulo);
            panelPrincipal.Children.Add(panelCrono);
            panelPrincipal.Children.Add(panelButton);

            this.Content = panelPrincipal;

            cronometroData.Iniciar(miCrono);



            miCrono.objCrono.CurrentTimeInvalidated += new EventHandler(miCrono_CurrentTimeInvalidated);
        }




        // Eventos....

        // Iniciar crono...
        private void btnStart_Clicked(object sender, RoutedEventArgs args)
        {

            cronometroData.Start(miCrono);
    
        }


        
        // Parar el crono...
        private void btnPausa_Clicked(object sender, RoutedEventArgs args)
        {
            cronometroData.Pause(miCrono);
            ActualizarTxt();

        }


        // Detener el crono...
        private void btnStop_Clicked(object sender, RoutedEventArgs args)
        {
            txtUltimoTiempo.Text = txtTiempo.Text;
            
            cronometroData.Stop(miCrono);
            ActualizarTxt();

        }


        private void miCrono_CurrentTimeInvalidated(object sender, EventArgs e)
        {
          
            txtTiempo.Text = miCrono.objCrono.CurrentTime.ToString();
            miCrono.TiempoActual = txtTiempo.Text;

        }


        //Otros métodos o funciones
        private void ActualizarTxt()
        {
            txtPausas.Text = miCrono.Pausas.ToString();
        }


  

    }

}
