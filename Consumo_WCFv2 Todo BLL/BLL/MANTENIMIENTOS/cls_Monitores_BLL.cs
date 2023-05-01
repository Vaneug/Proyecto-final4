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
    public class cls_Monitores_BLL
    {
        public void Actualizar_Monitor(ref cls_Monitores_DAL Obj_Monitores_DAL)
        {
            WCF.BDClient Obj_WCF = new BDClient();

            Obj_Monitores_DAL.dtParametros = Obj_WCF.Get_DT_Param(Obj_Monitores_DAL.dtParametros);

            Obj_Monitores_DAL.dtParametros.Rows.Add("@id_Monitor", "1", Obj_Monitores_DAL.iId_Monitor);
            Obj_Monitores_DAL.dtParametros.Rows.Add("@tipo_Monitor", "7", Obj_Monitores_DAL.sTipo_Monitor);
            Obj_Monitores_DAL.dtParametros.Rows.Add("@marca_Monitor", "7", Obj_Monitores_DAL.sMarca_Monitor);
            Obj_Monitores_DAL.dtParametros.Rows.Add("@modelo_Monitor", "7", Obj_Monitores_DAL.sModelo_Monitor);

            Obj_Monitores_DAL.sMsjError = Obj_WCF.Ins_Upd_Delete(ConfigurationManager.AppSettings["ACTUALIZAR_MONITOR"],
                "NORMAL", Obj_Monitores_DAL.dtParametros);
        }

        public void Borrar_Monitor(ref cls_Monitores_DAL Obj_Monitores_DAL)
        {
            WCF.BDClient Obj_WCF = new BDClient();

            Obj_Monitores_DAL.dtParametros = Obj_WCF.Get_DT_Param(Obj_Monitores_DAL.dtParametros);

            Obj_Monitores_DAL.dtParametros.Rows.Add("@id_Monitor", "1", Obj_Monitores_DAL.iId_Monitor);

            Obj_Monitores_DAL.sMsjError = Obj_WCF.Ins_Upd_Delete(ConfigurationManager.AppSettings["BORRAR_MONITOR"],
                "NORMAL", Obj_Monitores_DAL.dtParametros);
        }

        public void List_Filt_Monitor(ref cls_Monitores_DAL Obj_Monitores_DAL)
        {
            WCF.BDClient Obj_WCF = new BDClient();

            if (Obj_Monitores_DAL.iId_Monitor == 0)
            {
                Obj_Monitores_DAL.dtParametros = null;
                Obj_Monitores_DAL.dtDatos = Obj_WCF.ListarFiltrar("monitores", ConfigurationManager.AppSettings["LISTAR_MONITOR"], null);
            }
            else
            {
                Obj_Monitores_DAL.dtParametros = Obj_WCF.Get_DT_Param(Obj_Monitores_DAL.dtParametros);

                Obj_Monitores_DAL.dtParametros.Rows.Add("@filtro", "1", Obj_Monitores_DAL.iId_Monitor);

                Obj_Monitores_DAL.dtDatos = Obj_WCF.ListarFiltrar("monitores", ConfigurationManager.AppSettings["FILTRAR_MONITOR"],
                    Obj_Monitores_DAL.dtParametros);
            }
        }

        public void Insertar_Monitor(ref cls_Monitores_DAL Obj_Monitores_DAL)
        {
            WCF.BDClient Obj_WCF = new BDClient();

            Obj_Monitores_DAL.dtParametros = Obj_WCF.Get_DT_Param(Obj_Monitores_DAL.dtParametros);

            Obj_Monitores_DAL.dtParametros.Rows.Add("@id_Monitor", "1", Obj_Monitores_DAL.iId_Monitor);
            Obj_Monitores_DAL.dtParametros.Rows.Add("@tipo_Monitor", "7", Obj_Monitores_DAL.sTipo_Monitor);
            Obj_Monitores_DAL.dtParametros.Rows.Add("@marca_Monitor", "7", Obj_Monitores_DAL.sMarca_Monitor);
            Obj_Monitores_DAL.dtParametros.Rows.Add("@modelo_Monitor", "7", Obj_Monitores_DAL.sModelo_Monitor);


            Obj_Monitores_DAL.sMsjError = Obj_WCF.Ins_Upd_Delete(ConfigurationManager.AppSettings["INSERTAR_MONITOR"],
                "NORMAL", Obj_Monitores_DAL.dtParametros);
        }
    }
    
}        

