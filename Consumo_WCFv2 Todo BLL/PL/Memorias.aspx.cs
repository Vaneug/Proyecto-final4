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
    public partial class Memorias : System.Web.UI.Page
    {
        #region VARIABLES GLOBALES 

        cls_Memorias_DAL Obj_Memoria_DAL = new cls_Memorias_DAL();
        cls_Memorias_BLL Obj_Memoria_BLL = new cls_Memorias_BLL();

        #endregion
        protected void Page_Load(object sender, EventArgs e)
        {
            CargarDatosMemorias();
        }

        private void CargarDatosMemorias()
        {
            if (txt_filtrar.Text == string.Empty)
            {
                Obj_Memoria_DAL.iId_Memoria = 0;
            }
            else
            {
                Obj_Memoria_DAL.iId_Memoria = Convert.ToInt32(txt_filtrar.Text.Trim());
            }
            Obj_Memoria_BLL.List_Filt_Memoria(ref Obj_Memoria_DAL);

            dgv_Memoria.DataSource = null;
            dgv_Memoria.DataSource = Obj_Memoria_DAL.dtDatos;
            dgv_Memoria.DataBind();
        }


        protected void btn_Eliminar_Click(object sender, ImageClickEventArgs e)
        {
            Obj_Memoria_DAL.iId_Memoria = Convert.ToInt32(txt_IdMemoria.Text.Trim());

            Obj_Memoria_BLL.Borrar_Memoria(ref Obj_Memoria_DAL);

            txt_IdMemoria.Text = string.Empty;
            txt_filtrar.Text = string.Empty;
            CargarDatosMemorias();
        }

        protected void btn_Guardar_Click(object sender, ImageClickEventArgs e)
        {
            Obj_Memoria_DAL.iId_Memoria = Convert.ToInt32(txt_IdMemoria.Text.Trim());
            Obj_Memoria_DAL.sTipo_Memoria = txt_TipoMemoria.Text.Trim();

            Obj_Memoria_BLL.Actualizar_Memoria(ref Obj_Memoria_DAL);

            txt_IdMemoria.Text = string.Empty;
            txt_filtrar.Text = string.Empty;
            txt_TipoMemoria.Text = string.Empty;
            CargarDatosMemorias();
        }

        protected void btnFiltrar_Click(object sender, ImageClickEventArgs e)
        {
            CargarDatosMemorias();

        }

        protected void btn_Insertar_Click(object sender, ImageClickEventArgs e)
        {
            Obj_Memoria_DAL.iId_Memoria = Convert.ToInt32(txt_IdMemoria.Text.Trim());
            Obj_Memoria_DAL.sTipo_Memoria = txt_TipoMemoria.Text.Trim();

            Obj_Memoria_BLL.Insertar_Memoria(ref Obj_Memoria_DAL);

            txt_IdMemoria.Text = string.Empty;
            txt_filtrar.Text = string.Empty;
            txt_TipoMemoria.Text = string.Empty;
            CargarDatosMemorias();
        }
    }
}