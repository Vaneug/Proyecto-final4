﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using BLL.MANTENIMIENTOS;
using DAL.MANTENIMIENTOS;

namespace PL
{
    public partial class Monitores : System.Web.UI.Page
    {
        #region VARIABLES GLOBALES 

        cls_Monitores_DAL Obj_Monitor_DAL = new cls_Monitores_DAL();
        cls_Monitores_BLL Obj_Monitor_BLL = new cls_Monitores_BLL();

        #endregion
        protected void Page_Load(object sender, EventArgs e)
        {
            CargarDatosMonitores();
        }
        private void CargarDatosMonitores()
        {
            if (txt_filtrar.Text == string.Empty)
            {
                Obj_Monitor_DAL.iId_Monitor = 0;
            }
            else
            {
                Obj_Monitor_DAL.iId_Monitor = Convert.ToInt32(txt_filtrar.Text.Trim());
            }
            Obj_Monitor_BLL.List_Filt_Monitor(ref Obj_Monitor_DAL);

            dgv_Monitor.DataSource = null;
            dgv_Monitor.DataSource = Obj_Monitor_DAL.dtDatos;
            dgv_Monitor.DataBind();
        }

        protected void btnFiltrar_Click(object sender, ImageClickEventArgs e)
        {
            CargarDatosMonitores();
                      
        }
      
        protected void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_IdMonitor.Text))
            {
                MessageBox.Show("El campo 'ID_Memoria' no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Opcional: detiene el procesamiento adicional del código si se encuentra un error
            }
            else
            {
                MessageBox.Show("Monitor eliminado.",
                                "succes",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }

            Obj_Monitor_DAL.iId_Monitor = Convert.ToInt32(txt_IdMonitor.Text.Trim());

            Obj_Monitor_BLL.Borrar_Monitor(ref Obj_Monitor_DAL);

            txt_IdMonitor.Text = string.Empty;
            txt_filtrar.Text = string.Empty;
            CargarDatosMonitores();
        }

        protected void btn_Insertar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_IdMonitor.Text))
            {
                MessageBox.Show("El campo 'ID_Monitor' no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Opcional: detiene el procesamiento adicional del código si se encuentra un error
            }

            if (string.IsNullOrEmpty(txt_TipoMonitor.Text))
            {
                MessageBox.Show("El campo 'Tipo Monitor' no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Opcional: detiene el procesamiento adicional del código si se encuentra un error
            }
            if (string.IsNullOrEmpty(txt_MarcaMonitor.Text))
            {
                MessageBox.Show("El campo 'Marca Monitor' no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Opcional: detiene el procesamiento adicional del código si se encuentra un error
            }

            if (string.IsNullOrEmpty(txt_ModeloMonitor.Text))
            {
                MessageBox.Show("El campo 'Modelo Monitor' no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Opcional: detiene el procesamiento adicional del código si se encuentra un error
            }
            else
            {
                MessageBox.Show("Monitor guardado.",
                                "success",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            Obj_Monitor_DAL.iId_Monitor = Convert.ToInt32(txt_IdMonitor.Text.Trim());
            Obj_Monitor_DAL.sMarca_Monitor = txt_MarcaMonitor.Text.Trim();
            Obj_Monitor_DAL.sModelo_Monitor = txt_ModeloMonitor.Text.Trim();
            Obj_Monitor_DAL.sTipo_Monitor = txt_TipoMonitor.Text.Trim();

            Obj_Monitor_BLL.Insertar_Monitor(ref Obj_Monitor_DAL);

            txt_IdMonitor.Text = string.Empty;
            txt_filtrar.Text = string.Empty;
            txt_MarcaMonitor.Text = string.Empty;
            txt_ModeloMonitor.Text = string.Empty;
            txt_TipoMonitor.Text = string.Empty;
            CargarDatosMonitores();
        }

        protected void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_IdMonitor.Text))
            {
                MessageBox.Show("El campo 'ID_Monitor' no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Opcional: detiene el procesamiento adicional del código si se encuentra un error
            }

            if (string.IsNullOrEmpty(txt_TipoMonitor.Text))
            {
                MessageBox.Show("El campo 'Tipo Monitor' no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Opcional: detiene el procesamiento adicional del código si se encuentra un error
            }
            if (string.IsNullOrEmpty(txt_MarcaMonitor.Text))
            {
                MessageBox.Show("El campo 'Marca Monitor' no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Opcional: detiene el procesamiento adicional del código si se encuentra un error
            }

            if (string.IsNullOrEmpty(txt_ModeloMonitor.Text))
            {
                MessageBox.Show("El campo 'Modelo Monitor' no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Opcional: detiene el procesamiento adicional del código si se encuentra un error
            }
            else
            {
                MessageBox.Show("Monitor modificado.",
                                "Access",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }


            Obj_Monitor_DAL.iId_Monitor = Convert.ToInt32(txt_IdMonitor.Text.Trim());
            Obj_Monitor_DAL.sMarca_Monitor = txt_MarcaMonitor.Text.Trim();
            Obj_Monitor_DAL.sModelo_Monitor = txt_ModeloMonitor.Text.Trim();
            Obj_Monitor_DAL.sTipo_Monitor = txt_TipoMonitor.Text.Trim();

            Obj_Monitor_BLL.Actualizar_Monitor(ref Obj_Monitor_DAL);

            txt_IdMonitor.Text = string.Empty;
            txt_filtrar.Text = string.Empty;
            txt_MarcaMonitor.Text = string.Empty;
            txt_ModeloMonitor.Text = string.Empty;
            txt_TipoMonitor.Text = string.Empty;
            CargarDatosMonitores();
        }

    }
}