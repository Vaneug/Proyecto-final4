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
    public partial class Equipos : System.Web.UI.Page
    {
        #region VARIABLES GLOBALES 

        cls_Equipos_DAL Obj_Equipo_DAL = new cls_Equipos_DAL();
        cls_Equipos_BLL Obj_Equipo_BLL = new cls_Equipos_BLL();
        cls_Estados_DAL Obj_Estados_DAL = new cls_Estados_DAL();
        cls_Estados_BLL Obj_Estados_BLL = new cls_Estados_BLL();
        cls_Torres_DAL Obj_Torres_DAL = new cls_Torres_DAL();
        cls_Torres_BLL Obj_Torres_BLL = new cls_Torres_BLL();
        cls_Teclados_DAL Obj_Teclados_DAL = new cls_Teclados_DAL();
        cls_Teclados_BLL Obj_Teclados_BLL = new cls_Teclados_BLL();
        cls_Ratones_DAL Obj_Raton_DAL = new cls_Ratones_DAL();
        cls_Ratones_BLL Obj_Raton_BLL = new cls_Ratones_BLL();
        cls_Otros_DAL Obj_Otros_DAL = new cls_Otros_DAL();
        cls_Otros_BLL Obj_Otros_BLL = new cls_Otros_BLL();
        cls_discos_DAL Obj_Discos_DAL = new cls_discos_DAL();
        cls_discos_BLL Obj_Discos_BLL = new cls_discos_BLL();
        cls_Memorias_DAL Obj_memoria_DAL = new cls_Memorias_DAL();
        cls_Memorias_BLL Obj_memoria_BLL = new cls_Memorias_BLL();
        cls_Monitores_DAL Obj_Monitor_DAL = new cls_Monitores_DAL();
        cls_Monitores_BLL Obj_Monitor_BLL = new cls_Monitores_BLL();
        #endregion
        protected void Page_Load(object sender, EventArgs e)
        {

            CargarDatosEquipos();
        }

        protected void btn_Eliminar_Click(object sender, ImageClickEventArgs e)
        {
            Obj_Equipo_DAL.iId_Equipo = Convert.ToInt32(txt_IdEquipo.Text.Trim());

            Obj_Equipo_BLL.Borrar_Equipo(ref Obj_Equipo_DAL);

            txt_IdEquipo.Text = string.Empty;
            txt_filtrar.Text = string.Empty;
            CargarDatosEquipos();
        }

        protected void btn_Guardar_Click(object sender, ImageClickEventArgs e)
        {
            Obj_Equipo_DAL.iId_Equipo = Convert.ToInt32(txt_IdEquipo.Text.Trim());
            Obj_Equipo_DAL.sEstado = ddlEstado.Text.Trim();
            Obj_Equipo_DAL.sTipoTorre = ddltipotorre.Text.Trim();
            Obj_Equipo_DAL.sTipoTeclado = ddltipoteclado.Text.Trim();
            Obj_Equipo_DAL.sTipoRaton = ddlTipoRaton.Text.Trim();
            Obj_Equipo_DAL.sTipoOtro = ddlTipoOtro.Text.Trim();
            Obj_Equipo_DAL.sTipoDisco = ddltipodisco.Text.Trim();
            Obj_Equipo_DAL.sMarcaMemoria = ddlmarcamemoria.Text.Trim();
            Obj_Equipo_DAL.sMarcaMonitor = ddlmarcamonitor.Text.Trim();

            Obj_Equipo_BLL.Actualizar_Equipo(ref Obj_Equipo_DAL);

            txt_IdEquipo.Text = string.Empty;
            txt_filtrar.Text = string.Empty;
            ddlEstado.Text.Trim();
            ddltipotorre.Text.Trim();
            ddltipoteclado.Text.Trim();
            ddlTipoRaton.Text.Trim();
            ddlTipoOtro.Text.Trim();
            ddltipodisco.Text.Trim();
            ddlmarcamemoria.Text.Trim();
            ddlmarcamonitor.Text.Trim();
            CargarDatosEquipos();
        }

        protected void btnFiltrar_Click(object sender, ImageClickEventArgs e)
        {
            CargarDatosEquipos();
        }

        protected void btn_Insertar_Click(object sender, ImageClickEventArgs e)
        {
            Obj_Equipo_DAL.iId_Equipo = Convert.ToInt32(txt_IdEquipo.Text.Trim());
            Obj_Equipo_DAL.sEstado = ddlEstado.Text.Trim();
            Obj_Equipo_DAL.sTipoTorre = ddltipotorre.Text.Trim();
            Obj_Equipo_DAL.sTipoTeclado = ddltipoteclado.Text.Trim();
            Obj_Equipo_DAL.sTipoRaton = ddlTipoRaton.Text.Trim();
            Obj_Equipo_DAL.sTipoOtro = ddlTipoOtro.Text.Trim();
            Obj_Equipo_DAL.sTipoDisco = ddltipodisco.Text.Trim();
            Obj_Equipo_DAL.sMarcaMemoria = ddlmarcamemoria.Text.Trim();
            Obj_Equipo_DAL.sMarcaMonitor = ddlmarcamonitor.Text.Trim();

            Obj_Equipo_BLL.Actualizar_Equipo(ref Obj_Equipo_DAL);

            txt_IdEquipo.Text = string.Empty;
            txt_filtrar.Text = string.Empty;
            ddlEstado.Text.Trim();
            ddltipotorre.Text.Trim();
            ddltipoteclado.Text.Trim();
            ddlTipoRaton.Text.Trim();
            ddlTipoOtro.Text.Trim();
            ddltipodisco.Text.Trim();
            ddlmarcamemoria.Text.Trim();
            ddlmarcamonitor.Text.Trim();
            CargarDatosEquipos();
        }
        private void CargarDatosEquipos()
        {
            if (txt_filtrar.Text == string.Empty)
            {
                Obj_Equipo_DAL.iId_Equipo = 0;
            }
            else
            {
                Obj_Equipo_DAL.iId_Equipo = Convert.ToInt32(txt_filtrar.Text.Trim());
            }
            Obj_Equipo_BLL.List_Filt_Equipo(ref Obj_Equipo_DAL);

            dgv_Equipo.DataSource = null;
            dgv_Equipo.DataSource = Obj_Equipo_DAL.dtDatos;
            dgv_Equipo.DataBind();
        }

        private void CargarCombosEstado()
        {
            //ddl Estado
            Obj_Equipo_DAL.iEstado_Id = 0;

            Obj_Equipo_BLL.List_Filt_Equipo(ref Obj_Equipo_DAL);

            Obj_Equipo_DAL.dtDatos.Rows.Add("0", "--- SELECCIONE UN ESTADO ---");

            ddlEstado.DataSource = null;
            ddlEstado.DataTextField = "Nombre Usuario";
            ddlEstado.DataValueField = "Identificacion Usuario";
            ddlEstado.DataSource = Obj_Equipo_DAL.dtDatos;
            ddlEstado.DataBind();

            ddlEstado.SelectedValue = "0";
        }

        private void CargarCombostorre()
        {
            //ddl Torre
            Obj_Equipo_DAL.iTorre_Id = 0;

            Obj_Equipo_BLL.List_Filt_Equipo(ref Obj_Equipo_DAL);

            Obj_Equipo_DAL.dtDatos.Rows.Add("0", "--- SELECCIONE UNA TORRE ---");

            ddltipotorre.DataSource = null;
            ddltipotorre.DataTextField = "Nombre Usuario";
            ddltipotorre.DataValueField = "Identificacion Usuario";
            ddltipotorre.DataSource = Obj_Equipo_DAL.dtDatos;
            ddltipotorre.DataBind();

            ddltipotorre.SelectedValue = "0";
        }
        private void Cargarteclado()
        {
            //ddl teclado
            Obj_Equipo_DAL.iTeclado_Id = 0;

            Obj_Equipo_BLL.List_Filt_Equipo(ref Obj_Equipo_DAL);

            Obj_Equipo_DAL.dtDatos.Rows.Add("0", "--- SELECCIONE UN TECLADO ---");

            ddltipoteclado.DataSource = null;
            ddltipoteclado.DataTextField = "Nombre Usuario";
            ddltipoteclado.DataValueField = "Identificacion Usuario";
            ddltipoteclado.DataSource = Obj_Equipo_DAL.dtDatos;
            ddltipoteclado.DataBind();

            ddltipoteclado.SelectedValue = "0";
        }
        private void CargarComboRaton()
        {
            //ddl raton 
            Obj_Equipo_DAL.iRaton_Id = 0;

            Obj_Equipo_BLL.List_Filt_Equipo(ref Obj_Equipo_DAL);

            Obj_Equipo_DAL.dtDatos.Rows.Add("0", "--- SELECCIONE UN RATON ---");

            ddlTipoRaton.DataSource = null;
            ddlTipoRaton.DataTextField = "Nombre Usuario";
            ddlTipoRaton.DataValueField = "Identificacion Usuario";
            ddlTipoRaton.DataSource = Obj_Equipo_DAL.dtDatos;
            ddlTipoRaton.DataBind();

            ddlTipoRaton.SelectedValue = "0";
        }
        private void CargarComboOtro()
        {
            //ddl Otro
            Obj_Equipo_DAL.iOtro_Id = 0;

            Obj_Equipo_BLL.List_Filt_Equipo(ref Obj_Equipo_DAL);

            Obj_Equipo_DAL.dtDatos.Rows.Add("0", "--- SELECCIONE UNA TORRE ---");

            ddlTipoOtro.DataSource = null;
            ddlTipoOtro.DataTextField = "Nombre Usuario";
            ddlTipoOtro.DataValueField = "Identificacion Usuario";
            ddlTipoOtro.DataSource = Obj_Equipo_DAL.dtDatos;
            ddlTipoOtro.DataBind();

            ddlTipoOtro.SelectedValue = "0";
        }
        private void CargarComboDisco()
        {
            //ddl disco
            Obj_Equipo_DAL.iDisco_Id = 0;

            Obj_Equipo_BLL.List_Filt_Equipo(ref Obj_Equipo_DAL);

            Obj_Equipo_DAL.dtDatos.Rows.Add("0", "--- SELECCIONE UNA TORRE ---");

            ddltipodisco.DataSource = null;
            ddltipodisco.DataTextField = "Nombre Usuario";
            ddltipodisco.DataValueField = "Identificacion Usuario";
            ddltipodisco.DataSource = Obj_Equipo_DAL.dtDatos;
            ddltipodisco.DataBind();

            ddltipodisco.SelectedValue = "0";
        }
        private void CargarComboMemoria()
        {
            //ddl memoria
            Obj_Equipo_DAL.iMemoria_Id = 0;

            Obj_Equipo_BLL.List_Filt_Equipo(ref Obj_Equipo_DAL);

            Obj_Equipo_DAL.dtDatos.Rows.Add("0", "--- SELECCIONE UNA TORRE ---");

            ddlmarcamemoria.DataSource = null;
            ddlmarcamemoria.DataTextField = "Nombre Usuario";
            ddlmarcamemoria.DataValueField = "Identificacion Usuario";
            ddlmarcamemoria.DataSource = Obj_Equipo_DAL.dtDatos;
            ddlmarcamemoria.DataBind();

            ddlmarcamemoria.SelectedValue = "0";
        }
        private void CargarCombosMonitor()
        {
            //ddl monitor
            Obj_Equipo_DAL.iMonitor_Id = 0;

            Obj_Equipo_BLL.List_Filt_Equipo(ref Obj_Equipo_DAL);

            Obj_Equipo_DAL.dtDatos.Rows.Add("0", "--- SELECCIONE UNA TORRE ---");

            ddlmarcamonitor.DataSource = null;
            ddlmarcamonitor.DataTextField = "Nombre Usuario";
            ddlmarcamonitor.DataValueField = "Identificacion Usuario";
            ddlmarcamonitor.DataSource = Obj_Equipo_DAL.dtDatos;
            ddlmarcamonitor.DataBind();

            ddlmarcamonitor.SelectedValue = "0";
        }
    }
   
}