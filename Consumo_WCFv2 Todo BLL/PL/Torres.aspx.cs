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
    public partial class Torres : System.Web.UI.Page
    {
        #region VARIABLES GLOBALES 

        cls_Torres_DAL Obj_Torres_DAL = new cls_Torres_DAL();
        cls_Torres_BLL Obj_Torres_BLL = new cls_Torres_BLL();

        #endregion
        protected void Page_Load(object sender, EventArgs e)
        {
            CargarDatosTorres();
        }

        private void CargarDatosTorres()
        {
            if (txt_Filtrar_Torre.Text == string.Empty)
            {
                Obj_Torres_DAL.iId_Torre = 0;
            }
            else
            {
                Obj_Torres_DAL.iId_Torre = Convert.ToInt32(txt_Filtrar_Torre.Text.Trim());
            }
            Obj_Torres_BLL.List_Filt_Torre(ref Obj_Torres_DAL);
            
            dgv_Torres.DataSource = null;
            dgv_Torres.DataSource = Obj_Torres_DAL.dtDatos;
            dgv_Torres.DataBind();
        }

        protected void btnFiltrar_Click(object sender, ImageClickEventArgs e)
        {
            CargarDatosTorres();
        }

        protected void btn_Guardar_Click(object sender, EventArgs e)
        {
            Obj_Torres_DAL.iId_Torre = Convert.ToInt32(txt_Filtrar_Torre.Text.Trim());
            Obj_Torres_DAL.sMarca_Torre = txt_Filtrar_Torre.Text.Trim();
            Obj_Torres_DAL.sModelo_Torre = txt_Filtrar_Torre.Text.Trim();


            Obj_Torres_BLL.Actualizar_Torre(ref Obj_Torres_DAL);

            txt_Filtrar_Torre.Text = string.Empty;
            txt_IdTorre.Text = string.Empty;
            txt_MarcaTorre.Text = string.Empty;
            txt_ModeloTorre.Text = string.Empty;
            txt_TipoTorre.Text = string.Empty;
            CargarDatosTorres();
        }

        protected void txt_Eliminar_Click(object sender, EventArgs e)
        {
            Obj_Torres_DAL.iId_Torre = Convert.ToInt32(txt_Filtrar_Torre.Text.Trim());

            Obj_Torres_BLL.Borrar_Torre(ref Obj_Torres_DAL);

            txt_Filtrar_Torre.Text = string.Empty;
            CargarDatosTorres();
        }

        protected void btn_Insertar_Click(object sender, EventArgs e)
        {
            Obj_Torres_DAL.iId_Torre = Convert.ToInt32(txt_Filtrar_Torre.Text.Trim());
            
            Obj_Torres_DAL.sMarca_Torre = txt_Filtrar_Torre.Text.Trim();
            Obj_Torres_DAL.sModelo_Torre = txt_Filtrar_Torre.Text.Trim();
          
            Obj_Torres_BLL.Insertar_Torre(ref Obj_Torres_DAL);

            txt_Filtrar_Torre.Text = string.Empty;
            txt_IdTorre.Text = string.Empty;
            txt_MarcaTorre.Text = string.Empty;
            txt_ModeloTorre.Text = string.Empty;
            txt_TipoTorre.Text = string.Empty;
            CargarDatosTorres();
        }
    }
}