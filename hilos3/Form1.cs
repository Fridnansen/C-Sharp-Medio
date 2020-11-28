using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hilos3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            Task<string> task = new Task<string>(Solicitud);
            task.Start();
            label1.Text = "En Solicitud";

            string resultado = await task;
            label1.Text = "Termino la Solicitud";
        }

        private string Solicitud()
        {
            Thread.Sleep(10000);
            return "Terminada la solicitud";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
