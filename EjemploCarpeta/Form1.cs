using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploCarpeta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Directory.CreateDirectory("temporal");
            //para generar una carpeta en una ruta especifica
            //se usa @"ubicacion"
            DirectoryInfo dir = new DirectoryInfo(@"C:\tempora 2");
            dir.Create();
            MessageBox.Show("se creo la carpeta");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Directory.Move("temporal", @"C:\temporal");
            MessageBox.Show("se movio la carpeta");
        }
    }
}
