﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROG1_PROYECTO_FINAL
{
    public partial class Reporte_Producto_Nombre : Form
    {
        public Reporte_Producto_Nombre()
        {
            InitializeComponent();
        }

        private void Reporte_Producto_Nombre_Load(object sender, EventArgs e)
        {
            string nombre = Search_Productos._textbox;

            // TODO: This line of code loads data into the 'Filtro_Producto_Nombre.FiltroProductos' table. You can move, or remove it, as needed.
            this.FiltroProductosTableAdapter.Fill(this.Filtro_Producto_Nombre.FiltroProductos, nombre);

            this.reportViewer1.RefreshReport();
        }
    }
}
