using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.MANTENIMIENTOS;
using BLL.WCF;
using System.Configuration;

namespace BLL.MANTENIMIENTOS
{
    public class cls_Distribucion_BLL
    {
        public void Actualizar_Distribucion(ref cls_Distribucion_DAL Obj_Distribucion_DAL)
        {
            WCF.BDClient Obj_WCF = new BDClient();

            Obj_Distribucion_DAL.dtParametros = Obj_WCF.Get_DT_Param(Obj_Distribucion_DAL.dtParametros);

            Obj_Distribucion_DAL.dtParametros.Rows.Add("@id_Disco", "1", Obj_Distribucion_DAL.iID_Dsitribucion);
            Obj_Distribucion_DAL.dtParametros.Rows.Add("@tipo_Disco", "7", Obj_Distribucion_DAL.iID_Dsitribucion);
            Obj_Distribucion_DAL.dtParametros.Rows.Add("@tipo_Disco", "7", Obj_Distribucion_DAL.iID_Dsitribucion);

            Obj_Distribucion_DAL.sMsjError = Obj_WCF.Ins_Upd_Delete(ConfigurationManager.AppSettings["ACTUALIZAR_DISTRIBUCION"],
                "NORMAL", Obj_Distribucion_DAL.dtParametros);
        }

        public void Borrar_Distribucion(ref cls_Distribucion_DAL Obj_Distribucion_DAL)
        {
            WCF.BDClient Obj_WCF = new BDClient();

            Obj_Distribucion_DAL.dtParametros = Obj_WCF.Get_DT_Param(Obj_Distribucion_DAL.dtParametros);

            Obj_Distribucion_DAL.dtParametros.Rows.Add("@id_distribucion", "1", Obj_Distribucion_DAL.iID_Dsitribucion);

            Obj_Distribucion_DAL.sMsjError = Obj_WCF.Ins_Upd_Delete(ConfigurationManager.AppSettings["BORRAR_DISTRIBUCION"],
                "NORMAL", Obj_Distribucion_DAL.dtParametros);
        }

        public void List_Filt_Distribucion(ref cls_Distribucion_DAL Obj_Distribucion_DAL)
        {
            WCF.BDClient Obj_WCF = new BDClient();

            if (Obj_Distribucion_DAL.iID_Dsitribucion == 0)
            {
                Obj_Distribucion_DAL.dtParametros = null;
                Obj_Distribucion_DAL.dtDatos = Obj_WCF.ListarFiltrar("Distribucion", ConfigurationManager.AppSettings["LISTAR_DISTRIBUCION"], null);
            }
            else
            {
                Obj_Distribucion_DAL.dtParametros = Obj_WCF.Get_DT_Param(Obj_Distribucion_DAL.dtParametros);

                Obj_Distribucion_DAL.dtParametros.Rows.Add("@filtro", "1", Obj_Distribucion_DAL.iID_Dsitribucion);

                Obj_Distribucion_DAL.dtDatos = Obj_WCF.ListarFiltrar("Distribucion", ConfigurationManager.AppSettings["FILTRAR_DISTRIBUCION"],
                    Obj_Distribucion_DAL.dtParametros);
            }
        }

        public void Insertar_Distribucion(ref cls_Distribucion_DAL Obj_Distribucion_DAL)
        {
            WCF.BDClient Obj_WCF = new BDClient();

            Obj_Distribucion_DAL.dtParametros = Obj_WCF.Get_DT_Param(Obj_Distribucion_DAL.dtParametros);

            Obj_Distribucion_DAL.dtParametros.Rows.Add("@id_Disco", "1", Obj_Distribucion_DAL.iID_Dsitribucion);
            Obj_Distribucion_DAL.dtParametros.Rows.Add("@id_Disco", "1", Obj_Distribucion_DAL.iID_Empleado);
            Obj_Distribucion_DAL.dtParametros.Rows.Add("@tipo_Disco", "7", Obj_Distribucion_DAL.iID_Equipo);

            Obj_Distribucion_DAL.sMsjError = Obj_WCF.Ins_Upd_Delete(ConfigurationManager.AppSettings["INSERTAR_DISTRIBUCION"],
                "NORMAL", Obj_Distribucion_DAL.dtParametros);
        }

        public void List_Filt_Empleados(ref cls_Empleados_DAL Obj_Empleados_DAL)
        {
            WCF.BDClient Obj_WCF = new BDClient();

            if (Obj_Empleados_DAL.iID_Empelado == 0)
            {
                Obj_Empleados_DAL.dtParametros = null;
                Obj_Empleados_DAL.dtDatos = Obj_WCF.ListarFiltrar("Empleados", ConfigurationManager.AppSettings["LISTAR_EMPLEADOS"], null);
            }
            else
            {
                Obj_Empleados_DAL.dtParametros = Obj_WCF.Get_DT_Param(Obj_Empleados_DAL.dtParametros);

                Obj_Empleados_DAL.dtParametros.Rows.Add("@filtro", "1", Obj_Empleados_DAL.iID_Empelado);

                Obj_Empleados_DAL.dtDatos = Obj_WCF.ListarFiltrar("Empleados", ConfigurationManager.AppSettings["FILTRAR_EMPLEADOS"], Obj_Empleados_DAL.dtParametros);
            }
        }
    }
}
