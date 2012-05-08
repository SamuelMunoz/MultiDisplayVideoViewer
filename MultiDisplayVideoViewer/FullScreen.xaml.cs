using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MultiDisplayVideoViewer
{
	/// <summary>
	/// Lógica de interacción para FullScreen.xaml
	/// </summary>
	public partial class FullScreen : Window
	{
        List<string> playlist;
        int i = 0;
        private static FullScreen Instance = null;

        public FullScreen()
        {

        }

        public static FullScreen getInstance()
        {
            if (Instance == null)
                Instance = new FullScreen();
            return Instance;
        }

		public FullScreen(List<String> playlist)
		{
			this.InitializeComponent();
			
			// A partir de este punto se requiere la inserción de código para la creación del objeto.
            this.playlist = playlist;
		}

        public void Avanzar(int position)
        {
            this.i = position;
            LoadMedia();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            WindowState = System.Windows.WindowState.Maximized;
            LoadMedia();
        }

        private void LoadMedia()
        {
            if (i >= playlist.Count)
                Close();
            else
            {
                if (i < 0)
                {
                    i = 0;
                    Guardador g = new Guardador(i);
                    mediaElement1.Source = new Uri(playlist[i]);
                    mediaElement1.Play();
                }
                else
                {
                    Guardador g = new Guardador(i);
                    mediaElement1.Source = new Uri(playlist[i]);
                    mediaElement1.Play();
                }
            }
        }

        private void mediaElement1_MediaEnded(object sender, RoutedEventArgs e)
        {
            i++;
            LoadMedia();
        }
	}
}