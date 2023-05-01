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
    public partial class Distribución : System.Web.UI.Page
    {
        #region VARIABLES GLOBALES 

        cls_Distribucion_DAL Obj_Distribucion_DAL = new cls_Distribucion_DAL();
        cls_Distribucion_BLL obj_Distribucion_BLL = new cls_Distribucion_BLL();
        cls_Empleados_BLL obj_Empleados_BLL = new cls_Empleados_BLL();
        cls_Empleados_DAL obj_Empleados_DAL = new cls_Empleados_DAL();
        cls_Equipos_BLL Obj_Equipos_BLL = new cls_Equipos_BLL();
        cls_Equipos_DAL Obj_Equipos_DAL = new cls_Equipos_DAL();

        #endregion
        protected void Page_Load(object sender, EventArgs e)
        {
            CargarDatosDistribucion();
            CargarCombos();
        }

        private void CargarDatosDistribucion()
        {
            if (txt_filtrar.Text == string.Empty)
            {
                Obj_Distribucion_DAL.iID_Dsitribucion = 0;
            }
            else
            {
                Obj_Distribucion_DAL.iID_Dsitribucion = Convert.ToInt32(txt_filtrar.Text.Trim());
            }
            obj_Distribucion_BLL.List_Filt_Distribucion(ref Obj_Distribucion_DAL);

            dgv_Distribucion.DataSource = null;
            dgv_Distribucion.DataSource = Obj_Distribucion_DAL.dtDatos;
            dgv_Distribucion.DataBind();
        }

        private void CargarCombos()
        {
            //ddl empleados
            obj_Empleados_DAL.iID_Empelado = 0;

            obj_Empleados_BLL.List_Filt_Empleado(ref obj_Empleados_DAL);

            obj_Empleados_DAL.dtDatos.Rows.Add("0", "--- SELECCIONE UN EMPLEADO ---");

            ddl_IdEmpleado.DataSource = null;
            ddl_IdEmpleado.DataTextField = "Nombre Empleado";
            ddl_IdEmpleado.DataValueField = "Identificacion Empleado";
            ddl_IdEmpleado.DataSource = obj_Empleados_DAL.dtDatos;
            ddl_IdEmpleado.DataBind();

            ddl_IdEmpleado.SelectedValue = "0";

            //ddl equipos
            Obj_Equipos_DAL.iId_Equipo = 0;

            Obj_Equipos_BLL.List_Filt_Equipo(ref Obj_Equipos_DAL);

            //Obj_Equipos_DAL.dtDatos.Rows.Add("0", "--- SELECCIONE UN EQUIPO ---");

            ddl_IdEquipo.DataSource = null;
            ddl_IdEquipo.DataTextField = "Identificacion equipo";
            ddl_IdEquipo.DataValueField = "Identificacion equipo";
            ddl_IdEquipo.DataSource = Obj_Equipos_DAL.dtDatos;
            ddl_IdEquipo.DataBind();

            ddl_IdEquipo.SelectedValue = "1";
        }

        protected void btnFiltrar_Click(object sender, ImageClickEventArgs e)
        {
            CargarDatosDistribucion();
        }

        protected void btn_Guardar_Click(object sender, ImageClickEventArgs e)
        {
            Obj_Distribucion_DAL.iID_Dsitribucion = Convert.ToInt32(txt_IdDistribucion.Text.Trim());
            Obj_Distribucion_DAL.iID_Empleado = Convert.ToInt32(ddl_IdEmpleado.SelectedValue.Trim());
            Obj_Distribucion_DAL.iID_Equipo = Convert.ToInt32(ddl_IdEquipo.SelectedValue.Trim());

            obj_Distribucion_BLL.Actualizar_Distribucion(ref Obj_Distribucion_DAL);

            txt_IdDistribucion.Text = string.Empty;
            txt_filtrar.Text = string.Empty;
            ddl_IdEmpleado.SelectedValue = "0";
            ddl_IdEquipo.SelectedValue = "1";
            CargarDatosDistribucion();
        }

        protected void btn_Eliminar_Click(object sender, ImageClickEventArgs e)
        {

            Obj_Distribucion_DAL.iID_Dsitribucion = Convert.ToInt32(txt_IdDistribucion.Text.Trim());

            obj_Distribucion_BLL.Borrar_Distribucion(ref Obj_Distribucion_DAL);

            txt_IdDistribucion.Text = string.Empty;
            txt_filtrar.Text = string.Empty;
            ddl_IdEmpleado.SelectedValue = "0";
            ddl_IdEquipo.SelectedValue = "1";
            CargarDatosDistribucion();
        }

        protected void btn_Insertar_Click(object sender, ImageClickEventArgs e)
        {
            Obj_Distribucion_DAL.iID_Dsitribucion = Convert.ToInt32(txt_IdDistribucion.Text.Trim());
            Obj_Distribucion_DAL.iID_Empleado = Convert.ToInt32(ddl_IdEmpleado.SelectedValue.Trim());
            Obj_Distribucion_DAL.iID_Equipo = Convert.ToInt32(ddl_IdEquipo.SelectedValue.Trim());

            obj_Distribucion_BLL.Insertar_Distribucion(ref Obj_Distribucion_DAL);

            txt_IdDistribucion.Text = string.Empty;
            txt_filtrar.Text = string.Empty;
            ddl_IdEmpleado.SelectedValue ="0";
            ddl_IdEquipo.SelectedValue = "1";
            CargarDatosDistribucion();
        }

       
    }
}