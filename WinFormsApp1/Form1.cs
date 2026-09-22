using WMPLib;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        // Objeto que se encargará de reproducir el audio
        private WindowsMediaPlayer reproductor;
        
        // Variable para almacenar la ruta del archivo MP3
        private string rutaArchivo = "";


        public Form1()
        {
            InitializeComponent();
            // Inicializamos la instancia del reproductor
            reproductor = new WindowsMediaPlayer();
        }

        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void lblArchivo_Click(object sender, EventArgs e) { }


        private void btnPlay_Click(object sender, EventArgs e)
        {
            try
            {
                // Requisito 3: Si no hay un archivo seleccionado, abre el explorador
                if (string.IsNullOrEmpty(rutaArchivo))
                {
                    openFileDialog1.Filter = "Archivos MP3 (*.mp3)|*.mp3|Todos los archivos (*.*)|*.*";
                    openFileDialog1.Title = "Seleccionar archivo MP3";

                    // Muestra la ventana para elegir el archivo
                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        rutaArchivo = openFileDialog1.FileName;
                        // Requisito 5: Muestra solo el nombre del archivo en el Label
                        lblArchivo.Text = openFileDialog1.SafeFileName;
                    }
                    else
                    {
                        // Requisito 8: Si el usuario cancela la selección, salimos sin hacer nada
                        return;
                    }
                }

                // Requisito 4: Reproduce el archivo
                reproductor.URL = rutaArchivo;
                reproductor.controls.play();
            }
            catch (Exception ex)
            {
                // Requisito 8: Manejo de errores
                MessageBox.Show("No se pudo reproducir el archivo: " + ex.Message,
                                "Error de reproducción", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblArchivo_Click_1(object sender, EventArgs e)
        {

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            try
            {
                // Requisito 6: Detiene la reproducción
                if (reproductor != null)
                {
                    reproductor.controls.stop();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al detener la reproducción: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
