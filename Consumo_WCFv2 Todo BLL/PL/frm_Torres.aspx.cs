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
    public partial class frm_Torres : System.Web.UI.Page
    {
        #region VARIABLES GLOBALES 
        cls_discos_DAL Obj_discos_DAL = new cls_discos_DAL();
        cls_Equipos_DAL Obj_equipos_DAL = new cls_Equipos_DAL();
        cls_Estados_DAL Obj_estados_DAL = new cls_Estados_DAL();
        cls_Memorias_DAL Obj_memorias_DAL = new cls_Memorias_DAL();
        cls_Monitores_DAL Obj_monitores_DAL = new cls_Monitores_DAL();
        cls_Otros_DAL Obj_otros_DAL = new cls_Otros_DAL();
        cls_Ratones_DAL Obj_ratones_DAL = new cls_Ratones_DAL();
        cls_Teclados_DAL Obj_teclados_DAL = new cls_Teclados_DAL();
        cls_Torres_DAL Obj_torres_DAL = new cls_Torres_DAL();
        cls_Empleados_DAL Obj_Empleados_DAL = new cls_Empleados_DAL();

        cls_discos_BLL Obj_discos_BLL = new cls_discos_BLL();
        cls_Equipos_BLL Obj_equipos_BLL = new cls_Equipos_BLL();
        cls_Estados_BLL Obj_estados_BLL = new cls_Estados_BLL();
        cls_Memorias_BLL Obj_memorias_BLL = new cls_Memorias_BLL();
        cls_Monitores_BLL Obj_monitores_BLL = new cls_Monitores_BLL();
        cls_Otros_BLL Obj_otros_BLL = new cls_Otros_BLL();
        cls_Ratones_BLL Obj_ratones_BLL = new cls_Ratones_BLL();
        cls_Teclados_BLL Obj_teclados_BLL = new cls_Teclados_BLL();
        cls_Torres_BLL Obj_torres_BLL = new cls_Torres_BLL();
        cls_Empleados_BLL Obj_Empleados_BLL = new cls_Empleados_BLL();
        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        protected void btnFiltrar_Click(object sender, ImageClickEventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {

            if (txtaFiltProd.Text == string.Empty)
            {
                Obj_torres_DAL.iId_Torre = 0;
            }
            else
            {
                Obj_torres_DAL.iId_Torre = Convert.ToInt32(txtaFiltProd.Text.Trim());

            }

            Obj_torres_BLL.List_Filt_Torre(ref Obj_torres_DAL);

            dgv_Productos.DataSource = null;
            dgv_Productos.DataSource = Obj_torres_DAL.dtDatos;
            dgv_Productos.DataBind();
        }

        protected void btn_Guardar_Click(object sender, EventArgs e)
        {

        }

        protected void btn_Eliminar_Click(object sender, EventArgs e)
        {
            Obj_torres_DAL.iId_Torre = Convert.ToInt32(txt_IdTorre.Text.Trim());

            Obj_torres_BLL.Borrar_Torre(ref Obj_torres_DAL);

            txt_IdTorre.Text = string.Empty;
            CargarDatos();
        }

        protected void btn_Insertar_Click(object sender, EventArgs e)
        {

        }
    }
}