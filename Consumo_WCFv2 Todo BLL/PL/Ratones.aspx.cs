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
    public partial class Ratones : System.Web.UI.Page
    {
        #region VARIABLES GLOBALES 

        cls_Ratones_DAL Obj_Raton_DAL = new cls_Ratones_DAL();
        cls_Ratones_BLL Obj_Raton_BLL = new cls_Ratones_BLL();

        #endregion
        protected void Page_Load(object sender, EventArgs e)
        {
            CargarDatosRatones();
        }
        private void CargarDatosRatones()
        {
            if (txt_filtrar.Text == string.Empty)
            {
                Obj_Raton_DAL.iId_Raton = 0;
            }
            else
            {
                Obj_Raton_DAL.iId_Raton = Convert.ToInt32(txt_filtrar.Text.Trim());
            }
            Obj_Raton_BLL.List_Filt_Ratones(ref Obj_Raton_DAL);

            dgv_Raton.DataSource = null;
            dgv_Raton.DataSource = Obj_Raton_DAL.dtDatos;
            dgv_Raton.DataBind();
        }

        protected void btn_Eliminar_Click(object sender, ImageClickEventArgs e)
        {
            Obj_Raton_DAL.iId_Raton = Convert.ToInt32(txt_IdRaton.Text.Trim());

            Obj_Raton_BLL.Borrar_Raton(ref Obj_Raton_DAL);

            txt_IdRaton.Text = string.Empty;
            txt_filtrar.Text = string.Empty;
            CargarDatosRatones();
        }

        protected void btn_Guardar_Click(object sender, ImageClickEventArgs e)
        {
            Obj_Raton_DAL.iId_Raton = Convert.ToInt32(txt_IdRaton.Text.Trim());
            Obj_Raton_DAL.sTipo_Raton = txt_TipoRaton.Text.Trim();

            Obj_Raton_BLL.Actualizar_Raton(ref Obj_Raton_DAL);

            txt_IdRaton.Text = string.Empty;
            txt_filtrar.Text = string.Empty;
            txt_TipoRaton.Text = string.Empty;
            CargarDatosRatones();
        }

        protected void btnFiltrar_Click(object sender, ImageClickEventArgs e)
        {

            CargarDatosRatones();
        }

        protected void btn_Insertar_Click(object sender, ImageClickEventArgs e)
        {
            Obj_Raton_DAL.iId_Raton = Convert.ToInt32(txt_IdRaton.Text.Trim());
            Obj_Raton_DAL.sTipo_Raton = txt_TipoRaton.Text.Trim();

            Obj_Raton_BLL.Insertar_Raton(ref Obj_Raton_DAL);

            txt_IdRaton.Text = string.Empty;
            txt_filtrar.Text = string.Empty;
            txt_TipoRaton.Text = string.Empty;
            CargarDatosRatones();
        }
    }
}