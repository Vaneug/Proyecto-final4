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
    public partial class Discos : System.Web.UI.Page
    {
        #region VARIABLES GLOBALES 

        cls_discos_DAL Obj_Disco_DAL = new cls_discos_DAL();
        cls_discos_BLL Obj_Disco_BLL = new cls_discos_BLL();

        #endregion
        protected void Page_Load(object sender, EventArgs e)
        {
            CargarDatosDiscos();
        }

        private void CargarDatosDiscos()
        {
            if (txt_filtrar.Text == string.Empty)
            {
                Obj_Disco_DAL.iId_Disco = 0;
            }
            else
            {
                Obj_Disco_DAL.iId_Disco = Convert.ToInt32(txt_filtrar.Text.Trim());
            }
            
            Obj_Disco_BLL.List_Filt_Discos(ref Obj_Disco_DAL);

            dgv_Disco.DataSource = null;
            dgv_Disco.DataSource = Obj_Disco_DAL.dtDatos;
            dgv_Disco.DataBind();
        }
        protected void btnFiltrar_Click(object sender, ImageClickEventArgs e)
        {
            CargarDatosDiscos();
        }

        protected void btn_Eliminar_Click(object sender, ImageClickEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_IdDisco.Text))
            {
                MessageBox.Show("El campo 'ID_Disco' no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Opcional: detiene el procesamiento adicional del código si se encuentra un error
            }
            else
            {
                MessageBox.Show("Disco eliminado.",
                                "alerta",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }

            Obj_Disco_DAL.iId_Disco = Convert.ToInt32(txt_IdDisco.Text.Trim());

            Obj_Disco_BLL.Borrar_Discos(ref Obj_Disco_DAL);

            txt_IdDisco.Text = string.Empty;
            txt_filtrar.Text = string.Empty;
            CargarDatosDiscos();
            
        }
        
        protected void btn_Guardar_Click(object sender, ImageClickEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_IdDisco.Text))
            {
                MessageBox.Show("El campo 'ID_Disco' no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Opcional: detiene el procesamiento adicional del código si se encuentra un error
            }

            if (string.IsNullOrEmpty(txt_TipoDisco.Text))
            {
                MessageBox.Show("El campo 'Tipo Disco' no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Opcional: detiene el procesamiento adicional del código si se encuentra un error
            }
            else
            {
                MessageBox.Show("Disco modificado.",
                                "Access",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            Obj_Disco_DAL.iId_Disco = Convert.ToInt32(txt_IdDisco.Text.Trim());
            Obj_Disco_DAL.sTipo_Disco = txt_TipoDisco.Text.Trim();

            Obj_Disco_BLL.Actualizar_Discos(ref Obj_Disco_DAL);

            txt_IdDisco.Text = string.Empty;
            txt_filtrar.Text = string.Empty;
            txt_TipoDisco.Text = string.Empty;
            CargarDatosDiscos();
        }

        protected void btn_Insertar_Click(object sender, ImageClickEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_IdDisco.Text))
            {
                MessageBox.Show("El campo 'ID_Disco' no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Opcional: detiene el procesamiento adicional del código si se encuentra un error
            }

            if (string.IsNullOrEmpty(txt_TipoDisco.Text))
            {
                MessageBox.Show("El campo 'Tipo Disco' no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Opcional: detiene el procesamiento adicional del código si se encuentra un error
            }
            else
            {
                MessageBox.Show("Disco guardado.",
                                "success",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            Obj_Disco_DAL.iId_Disco = Convert.ToInt32(txt_IdDisco.Text.Trim());
            Obj_Disco_DAL.sTipo_Disco = txt_TipoDisco.Text.Trim();

            Obj_Disco_BLL.Insertar_Discos(ref Obj_Disco_DAL);

            txt_IdDisco.Text = string.Empty;
            txt_filtrar.Text = string.Empty;
            txt_TipoDisco.Text = string.Empty;
            CargarDatosDiscos();
        }
    }
}