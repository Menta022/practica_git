using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace git_practica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Nombre");
            dt.Columns.Add("Apellido");
            dt.Columns.Add("Edad");
            dt.Rows.Add("pepa", "pig", 10);
            dt.Rows.Add("pepe", "pig", 35);
            dt.Rows.Add("tom", "perez", 21);
            dtg_persona.DataSource = dt;
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {

        }
    }
}
