using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL.MANTENIMIENTOS;
using DAL.MANTENIMIENTOS;

namespace PL
{
    public partial class Otros : System.Web.UI.Page
    {
        #region VARIABLES GLOBALES 

        cls_Otros_DAL Obj_Otro_DAL = new cls_Otros_DAL();
        cls_Otros_BLL Obj_Otro_BLL = new cls_Otros_BLL();

        #endregion
        protected void Page_Load(object sender, EventArgs e)
        {
            CargarDatosOtros();
        }

        private void CargarDatosOtros()
        {
            if (txt_filtrar.Text == string.Empty)
            {
                Obj_Otro_DAL.iId_Otro = 0;
            }
            else
            {
                Obj_Otro_DAL.iId_Otro = Convert.ToInt32(txt_filtrar.Text.Trim());
            }
            Obj_Otro_BLL.List_Filt_Otro(ref Obj_Otro_DAL);

            dgv_Otro.DataSource = null;
            dgv_Otro.DataSource = Obj_Otro_DAL.dtDatos;
            dgv_Otro.DataBind();
        }

        protected void btn_Eliminar_Click(object sender, ImageClickEventArgs e)
        {
            Obj_Otro_DAL.iId_Otro = Convert.ToInt32(txt_IdOtro.Text.Trim());

            Obj_Otro_BLL.Borrar_Otro(ref Obj_Otro_DAL);

            txt_IdOtro.Text = string.Empty;
            txt_filtrar.Text = string.Empty;
            CargarDatosOtros();
        }

        protected void btn_Guardar_Click(object sender, ImageClickEventArgs e)
        {
            Obj_Otro_DAL.iId_Otro = Convert.ToInt32(txt_IdOtro.Text.Trim());
            Obj_Otro_DAL.sMarca_Otro = txt_MarcaOtro.Text.Trim();
            Obj_Otro_DAL.sModelo_Otro = txt_ModeloOtro.Text.Trim();
            Obj_Otro_DAL.sTipo_Otro = txt_TipoOtro.Text.Trim();

            Obj_Otro_BLL.Insertar_Otro(ref Obj_Otro_DAL);

            txt_IdOtro.Text = string.Empty;
            txt_filtrar.Text = string.Empty;
            txt_MarcaOtro.Text = string.Empty;
            txt_ModeloOtro.Text = string.Empty;
            txt_TipoOtro.Text = string.Empty;
            CargarDatosOtros();
        }

        protected void btnFiltrar_Click(object sender, ImageClickEventArgs e)
        {

            CargarDatosOtros();
        }

        protected void btn_Insertar_Click(object sender, ImageClickEventArgs e)
        {
            Obj_Otro_DAL.iId_Otro = Convert.ToInt32(txt_IdOtro.Text.Trim());
            Obj_Otro_DAL.sMarca_Otro = txt_MarcaOtro.Text.Trim();
            Obj_Otro_DAL.sModelo_Otro = txt_ModeloOtro.Text.Trim();
            Obj_Otro_DAL.sTipo_Otro = txt_TipoOtro.Text.Trim();

            Obj_Otro_BLL.Actualizar_Otro(ref Obj_Otro_DAL);

            txt_IdOtro.Text = string.Empty;
            txt_filtrar.Text = string.Empty;
            txt_MarcaOtro.Text = string.Empty;
            txt_ModeloOtro.Text = string.Empty;
            txt_TipoOtro.Text = string.Empty;
            CargarDatosOtros();
        }
    }
}