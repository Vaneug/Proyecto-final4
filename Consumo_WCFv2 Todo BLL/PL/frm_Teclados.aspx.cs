using BLL.MANTENIMIENTOS;
using DAL.MANTENIMIENTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PL
{
    public partial class frm_Teclados : System.Web.UI.Page
    {
        #region VARIABLES GLOBALES 

        cls_Teclados_DAL Obj_Teclados_DAL = new cls_Teclados_DAL();
        cls_Teclados_BLL Obj_Teclados_BLL = new cls_Teclados_BLL();

        #endregion
        protected void Page_Load(object sender, EventArgs e)
        {
            CargarDatosTeclados();
        }

        private void CargarDatosTeclados()
        {
            if (txtaFiltProd.Text == string.Empty)
            {
                Obj_Teclados_DAL.iId_Teclado = 0;
            }
            else
            {
                Obj_Teclados_DAL.iId_Teclado = Convert.ToInt32(txtaFiltProd.Text.Trim());
            }
            Obj_Teclados_BLL.List_Filt_Teclado(ref Obj_Teclados_DAL);

            dgv_Teclados.DataSource = null;
            dgv_Teclados.DataSource = Obj_Teclados_DAL.dtDatos;
            dgv_Teclados.DataBind();
        }

        protected void btnFiltrar_Click(object sender, ImageClickEventArgs e)
        {
            CargarDatosTeclados();
        }

        protected void btn_Guardar_Click(object sender, EventArgs e)
        {
            Obj_Teclados_DAL.iId_Teclado = Convert.ToInt32(txtaFiltProd.Text.Trim());
            Obj_Teclados_DAL.sMarca_Teclado = txt_MarcaTeclado.Text.Trim();
            Obj_Teclados_DAL.sModelo_Teclado = txt_ModeloTeclado.Text.Trim();
            Obj_Teclados_DAL.sTipo_Teclado = txt_TipoTeclado.Text.Trim();

            Obj_Teclados_BLL.Actualizar_Teclado(ref Obj_Teclados_DAL);

            txtaFiltProd.Text = string.Empty;
            txt_IdTeclado.Text = string.Empty;
            txt_MarcaTeclado.Text = string.Empty;
            txt_ModeloTeclado.Text = string.Empty;
            txt_TipoTeclado.Text = string.Empty;
            CargarDatosTeclados();
        }

        protected void txt_Eliminar_Click(object sender, EventArgs e)
        {
            Obj_Teclados_DAL.iId_Teclado = Convert.ToInt32(txt_IdTeclado.Text.Trim());

            Obj_Teclados_BLL.Borrar_Teclado(ref Obj_Teclados_DAL);

            txt_IdTeclado.Text = string.Empty;
            CargarDatosTeclados();
        }

        protected void btn_Insertar_Click(object sender, EventArgs e)
        {
            Obj_Teclados_DAL.iId_Teclado = Convert.ToInt32(txt_IdTeclado.Text.Trim());
            Obj_Teclados_DAL.sTipo_Teclado = txt_TipoTeclado.Text.Trim();
            Obj_Teclados_DAL.sMarca_Teclado = txt_MarcaTeclado.Text.Trim();
            Obj_Teclados_DAL.sModelo_Teclado = txt_ModeloTeclado.Text.Trim();

            Obj_Teclados_BLL.Insertar_Teclados(ref Obj_Teclados_DAL);

            txtaFiltProd.Text = string.Empty;
            txt_IdTeclado.Text = string.Empty;
            txt_MarcaTeclado.Text = string.Empty;
            txt_ModeloTeclado.Text = string.Empty;
            txt_TipoTeclado.Text = string.Empty;
            CargarDatosTeclados();
        }
    }
}