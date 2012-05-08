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
using System.Windows.Threading;
using System.Windows.Forms;

namespace MultiDisplayVideoViewer
{
	/// <summary>
	/// Lógica de interacción para MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
        FullScreen full;
        DispatcherTimer reloj;

		public MainWindow()
		{
			this.InitializeComponent();

			// A partir de este punto se requiere la inserción de código para la creación del objeto.
            reloj = new DispatcherTimer();
            reloj.Tick += new EventHandler(reloj_Tick);
            reloj.Interval = new TimeSpan(0, 0, 1);
            btnStopList.IsEnabled = false;
            btnAvanzar.IsEnabled = false;
            btnRetroceder.IsEnabled = false;
		}

        private void reloj_Tick(object sender, EventArgs e)
        {
            lstListaReproducción.SelectedIndex = Guardador.code;
        }

        private void DisableOnPlay(bool state)
        {
            txtArchivos.IsEnabled = state;
            btnAddList.IsEnabled = state;
            lstListaReproducción.IsEnabled = state;
            btnBorrar.IsEnabled = state;
            btnLimpiar.IsEnabled = state;
        }

        private void txtArchivos_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Title = "Cargar videos";
            openfile.Filter = "Archivos de video (*.wmv,*.avi,*.mkv,*.mp4,*.m4v)|*.wmv;*.avi;*.mkv;*.mp4;*.m4v|Todos los archivos (*.*)|*.*";
            openfile.FileName = String.Empty;
            openfile.ShowDialog();
            txtArchivos.Text = openfile.FileName;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (txtArchivos.Text.Equals(String.Empty))
                System.Windows.MessageBox.Show("No hay datos para agregar a la lista de reproducción", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            else
                lstListaReproducción.Items.Add(txtArchivos.Text);
            txtArchivos.Text = String.Empty;
        }

        private void btnLimpiar_Click(object sender, RoutedEventArgs e)
        {
            if (System.Windows.MessageBox.Show("¿Desea borrar la lista?", "Advertencia", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                lstListaReproducción.Items.Clear();
            btnStopList.IsEnabled = false;
        }

        private void btnBorrar_Click(object sender, RoutedEventArgs e)
        {
            lstListaReproducción.Items.RemoveAt(lstListaReproducción.SelectedIndex);
        }

        private void btnPlayList_Click(object sender, RoutedEventArgs e)
        {
            List<string> lista = new List<string>();
            foreach (string item in lstListaReproducción.Items)
                lista.Add(item);
            full = new FullScreen(lista);
            full.WindowStartupLocation = System.Windows.WindowStartupLocation.Manual;
            
            if (System.Windows.Forms.SystemInformation.MonitorCount.Equals(1))
                System.Windows.MessageBox.Show("No cuenta con 2 monitores.\nDebe conectar un segundo y colocarlo en Expandir Escritorio", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            else
            {
                System.Drawing.Rectangle workingArea = System.Windows.Forms.Screen.AllScreens[1].WorkingArea;
                full.Left = workingArea.Left;
                full.Top = workingArea.Top;
                full.Width = workingArea.Width;
                full.Height = workingArea.Height;
                full.WindowStyle = System.Windows.WindowStyle.None;
                full.Topmost = true;
                full.Show();
                reloj.Start();
                btnStopList.IsEnabled = true;
                btnAvanzar.IsEnabled = true;
                btnRetroceder.IsEnabled = true;
                DisableOnPlay(false);
            }
        }

        private void btnStopList_Click(object sender, RoutedEventArgs e)
        {
            full.Close();
            DisableOnPlay(true);
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton.Equals(MouseButtonState.Pressed))
            {
                About about = new About();
                about.ShowDialog();
            }
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnRetroceder_Click(object sender, RoutedEventArgs e)
        {
            full.Avanzar(Guardador.code - 1);
            lstListaReproducción.SelectedIndex = Guardador.code;
        }

        private void btnAvanzar_Click(object sender, RoutedEventArgs e)
        {
            full.Avanzar(Guardador.code + 1);
            lstListaReproducción.SelectedIndex = Guardador.code;
        }
	}
}