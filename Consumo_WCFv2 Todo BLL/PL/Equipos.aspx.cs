using System;
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
            if (!Page.IsPostBack)
            {
                CargarDatosEquipos();
                CargarComboDisco();
                CargarComboMemoria();
                CargarComboRaton();
                CargarCombostorre();
                CargarComboOtro();
                CargarCombosMonitor();
                CargarComboteclado();
                CargarCombosEstado();
            }

        }
        protected void btn_Eliminar_Click(object sender, ImageClickEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_IdEquipo.Text))
            {
                MessageBox.Show("El campo 'ID_Equipo' no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Opcional: detiene el procesamiento adicional del código si se encuentra un error
            }
            else
            {
                MessageBox.Show("No tiene equipos para poder eliminar.",
                                "alerta",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }

            Obj_Equipo_DAL.iId_Equipo = Convert.ToInt32(txt_IdEquipo.Text.Trim());

            Obj_Equipo_BLL.Borrar_Equipo(ref Obj_Equipo_DAL);

            txt_IdEquipo.Text = string.Empty;
           
            CargarDatosEquipos();
        }
        protected void btn_Guardar_Click(object sender, ImageClickEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_IdEquipo.Text))
            {
                MessageBox.Show("El campo 'ID_Equipo' no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Opcional: detiene el procesamiento adicional del código si se encuentra un error
            }
            else
            {
                MessageBox.Show("Equipo modificad0.",
                                "Access",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            Obj_Equipo_DAL.iId_Equipo = Convert.ToInt32(txt_IdEquipo.Text.Trim());
            Obj_Equipo_DAL.iEstado_Id = Convert.ToInt32(ddlEstado.SelectedValue.Trim());
            Obj_Equipo_DAL.iTorre_Id = Convert.ToInt32(ddltipotorre.SelectedValue.Trim());
            Obj_Equipo_DAL.iTeclado_Id = Convert.ToInt32(ddltipoteclado.SelectedValue.Trim());
            Obj_Equipo_DAL.iRaton_Id = Convert.ToInt32(ddlTipoRaton.SelectedValue.Trim());
            Obj_Equipo_DAL.iOtro_Id = Convert.ToInt32(ddlTipoOtro.SelectedValue.Trim());
            Obj_Equipo_DAL.iDisco_Id = Convert.ToInt32(ddltipodisco.SelectedValue.Trim());
            Obj_Equipo_DAL.iMemoria_Id = Convert.ToInt32(ddlmarcamemoria.SelectedValue.Trim());
            Obj_Equipo_DAL.iMonitor_Id = Convert.ToInt32(ddlmarcamonitor.SelectedValue.Trim());

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
            if (string.IsNullOrEmpty(txt_IdEquipo.Text))
            {
                MessageBox.Show("El campo 'ID_Equipo' no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Opcional: detiene el procesamiento adicional del código si se encuentra un error
            }
            else
            {
                MessageBox.Show("Equipo guardado.",
                                "success",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            Obj_Equipo_DAL.iId_Equipo = Convert.ToInt32(txt_IdEquipo.Text.Trim());
            Obj_Equipo_DAL.iEstado_Id = Convert.ToInt32(ddlEstado.SelectedValue.Trim());
            Obj_Equipo_DAL.iTorre_Id = Convert.ToInt32(ddltipotorre.SelectedValue.Trim());
            Obj_Equipo_DAL.iTeclado_Id = Convert.ToInt32(ddltipoteclado.SelectedValue.Trim());
            Obj_Equipo_DAL.iRaton_Id = Convert.ToInt32(ddlTipoRaton.SelectedValue.Trim());
            Obj_Equipo_DAL.iOtro_Id = Convert.ToInt32(ddlTipoOtro.SelectedValue.Trim());
            Obj_Equipo_DAL.iDisco_Id = Convert.ToInt32(ddltipodisco.SelectedValue.Trim());
            Obj_Equipo_DAL.iMemoria_Id = Convert.ToInt32(ddlmarcamemoria.SelectedValue.Trim());
            Obj_Equipo_DAL.iMonitor_Id = Convert.ToInt32(ddlmarcamonitor.SelectedValue.Trim());

            Obj_Equipo_BLL.Insertar_Equipo(ref Obj_Equipo_DAL);

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
            Obj_Estados_DAL.iId_Estado = 0;

            Obj_Estados_BLL.List_Filt_Estado(ref Obj_Estados_DAL);

            Obj_Estados_DAL.dtDatos.Rows.Add("0", "--- SELECCIONE UN ESTADO ---");

            ddlEstado.DataSource = null;
            ddlEstado.DataTextField = "Tipo Estado";
            ddlEstado.DataValueField = "Identificacion Estado";
            ddlEstado.DataSource = Obj_Estados_DAL.dtDatos;
            ddlEstado.DataBind();

            ddlEstado.SelectedValue = "0";
        }

        private void CargarCombostorre()
        {
            //ddl Torre
            Obj_Torres_DAL.iId_Torre = 0;

            Obj_Torres_BLL.List_Filt_Torre(ref Obj_Torres_DAL);

            Obj_Torres_DAL.dtDatos.Rows.Add("0", "--- SELECCIONE UNA TORRE ---");

            ddltipotorre.DataSource = null;
            ddltipotorre.DataTextField = "Marca";
            ddltipotorre.DataValueField = "Identificacion Torre";
            ddltipotorre.DataSource = Obj_Torres_DAL.dtDatos;
            ddltipotorre.DataBind();

            ddltipotorre.SelectedValue = "0";
        }
        private void CargarComboteclado()
        {
            //ddl teclado
            Obj_Teclados_DAL.iId_Teclado = 0;

            Obj_Teclados_BLL.List_Filt_Teclado(ref Obj_Teclados_DAL);

            Obj_Teclados_DAL.dtDatos.Rows.Add("0", "--- SELECCIONE UN TECLADO ---");

            ddltipoteclado.DataSource = null;
            ddltipoteclado.DataTextField = "Tipo teclado";
            ddltipoteclado.DataValueField = "Identificacion Teclado";
            ddltipoteclado.DataSource = Obj_Teclados_DAL.dtDatos;
            ddltipoteclado.DataBind();

            ddltipoteclado.SelectedValue = "0";
        }
        private void CargarComboRaton()
        {
            //ddl raton 
            Obj_Raton_DAL.iId_Raton = 0;

            Obj_Raton_BLL.List_Filt_Ratones(ref Obj_Raton_DAL);

            Obj_Raton_DAL.dtDatos.Rows.Add("0", "--- SELECCIONE UN RATON ---");

            ddlTipoRaton.DataSource = null;
            ddlTipoRaton.DataTextField = "Tipo Raton";
            ddlTipoRaton.DataValueField = "Identificacion Raton";
            ddlTipoRaton.DataSource = Obj_Raton_DAL.dtDatos;
            ddlTipoRaton.DataBind();

            ddlTipoRaton.SelectedValue = "0";
        }
        private void CargarComboOtro()
        {
            //ddl Otro
            Obj_Otros_DAL.iId_Otro = 0;

            Obj_Otros_BLL.List_Filt_Otro(ref Obj_Otros_DAL);

            Obj_Otros_DAL.dtDatos.Rows.Add("0", "--- SELECCIONE OTRO ---");

            ddlTipoOtro.DataSource = null;
            ddlTipoOtro.DataTextField = "Tipo Otro";
            ddlTipoOtro.DataValueField = "Identificacion Otro";
            ddlTipoOtro.DataSource = Obj_Otros_DAL.dtDatos;
            ddlTipoOtro.DataBind();

            ddlTipoOtro.SelectedValue = "0";
        }
        private void CargarComboDisco()
        {
            //ddl disco
            Obj_Discos_DAL.iId_Disco = 0;

            Obj_Discos_BLL.List_Filt_Discos(ref Obj_Discos_DAL);

            Obj_Discos_DAL.dtDatos.Rows.Add("0", "--- SELECCIONE UN DISCO ---");

            ddltipodisco.DataSource = null;
            ddltipodisco.DataTextField = "Tipo Disco";
            ddltipodisco.DataValueField = "Identificacion Disco";
            ddltipodisco.DataSource = Obj_Discos_DAL.dtDatos;
            ddltipodisco.DataBind();

            ddltipodisco.SelectedValue = "0";
        }
        private void CargarComboMemoria()
        {
            //ddl memoria
            Obj_memoria_DAL.iId_Memoria = 0;

            Obj_memoria_BLL.List_Filt_Memoria(ref Obj_memoria_DAL);

            Obj_memoria_DAL.dtDatos.Rows.Add("0", "--- SELECCIONE UNA MEMORIA ---");

            ddlmarcamemoria.DataSource = null;
            ddlmarcamemoria.DataTextField = "Tipo de memoria";
            ddlmarcamemoria.DataValueField = "Identificacion memoria";
            ddlmarcamemoria.DataSource = Obj_memoria_DAL.dtDatos;
            ddlmarcamemoria.DataBind();

            ddlmarcamemoria.SelectedValue = "0";
        }
        private void CargarCombosMonitor()
        {
            //ddl monitor
            Obj_Monitor_DAL.iId_Monitor = 0;

            Obj_Monitor_BLL.List_Filt_Monitor(ref Obj_Monitor_DAL);

            Obj_Monitor_DAL.dtDatos.Rows.Add("0", "--- SELECCIONE UN MONITOR ---");

            ddlmarcamonitor.DataSource = null;
            ddlmarcamonitor.DataTextField = "Marca";
            ddlmarcamonitor.DataValueField = "ID";
            ddlmarcamonitor.DataSource = Obj_Monitor_DAL.dtDatos;
            ddlmarcamonitor.DataBind();

            ddlmarcamonitor.SelectedValue = "0";
        }
    }
   
}