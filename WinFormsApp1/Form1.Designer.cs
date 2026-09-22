namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            lblTitulo = new Label();
            btnPlay = new Button();
            btnStop = new Button();
            pictureBox1 = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            panel1 = new Panel();
            lblArchivo = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 18);
            label1.Name = "label1";
            label1.Size = new Size(100, 15);
            label1.TabIndex = 0;
            label1.Text = "Reproductor MP3";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(29, 43);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(123, 15);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Archivo seleccionado:";
            // 
            // btnPlay
            // 
            btnPlay.BackColor = Color.Lime;
            btnPlay.Font = new Font("Microsoft Sans Serif", 11F);
            btnPlay.ForeColor = SystemColors.ControlLightLight;
            btnPlay.Location = new Point(93, 293);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(95, 46);
            btnPlay.TabIndex = 3;
            btnPlay.Text = "▶   Play";
            btnPlay.UseVisualStyleBackColor = false;
            btnPlay.Click += btnPlay_Click;
            // 
            // btnStop
            // 
            btnStop.BackColor = Color.Red;
            btnStop.Font = new Font("Microsoft Sans Serif", 11F);
            btnStop.ForeColor = SystemColors.ControlLightLight;
            btnStop.Location = new Point(268, 293);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(95, 46);
            btnStop.TabIndex = 4;
            btnStop.Text = "■   Stop";
            btnStop.UseVisualStyleBackColor = false;
            btnStop.Click += btnStop_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Control;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(115, 128);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(223, 141);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "Archivos MP3 (*.mp3)|*.mp3|Todos los archivos (*.*)|*.*";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lblArchivo);
            panel1.Location = new Point(29, 61);
            panel1.Name = "panel1";
            panel1.Size = new Size(402, 37);
            panel1.TabIndex = 6;
            // 
            // lblArchivo
            // 
            lblArchivo.AutoSize = true;
            lblArchivo.Location = new Point(3, 11);
            lblArchivo.Name = "lblArchivo";
            lblArchivo.Size = new Size(200, 15);
            lblArchivo.TabIndex = 0;
            lblArchivo.Text = "No hay ningún archivo seleccionado";
            lblArchivo.Click += lblArchivo_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(463, 376);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(btnStop);
            Controls.Add(btnPlay);
            Controls.Add(lblTitulo);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblTitulo;
        private Button btnPlay;
        private Button btnStop;
        private PictureBox pictureBox1;
        private OpenFileDialog openFileDialog1;
        private Panel panel1;
        private Label lblArchivo;
    }
}
