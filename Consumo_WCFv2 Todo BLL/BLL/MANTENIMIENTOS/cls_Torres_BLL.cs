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
    public class cls_Torres_BLL
    {
        public void Actualizar_Torre(ref cls_Torres_DAL Obj_Torres_DAL)
        {
            WCF.BDClient Obj_WCF = new BDClient();

            Obj_Torres_DAL.dtParametros = Obj_WCF.Get_DT_Param(Obj_Torres_DAL.dtParametros);

            Obj_Torres_DAL.dtParametros.Rows.Add("@id_Torre", "1", Obj_Torres_DAL.iId_Torre);
            Obj_Torres_DAL.dtParametros.Rows.Add("@marca", "7", Obj_Torres_DAL.sMarca_Torre);
            Obj_Torres_DAL.dtParametros.Rows.Add("@modelo", "7", Obj_Torres_DAL.sModelo_Torre);
            Obj_Torres_DAL.dtParametros.Rows.Add("@id_Disco", "1", Obj_Torres_DAL.iId_Disco);
            Obj_Torres_DAL.dtParametros.Rows.Add("@id_Memoria", "1", Obj_Torres_DAL.iId_Memoria);
            

            Obj_Torres_DAL.sMsjError = Obj_WCF.Ins_Upd_Delete(ConfigurationManager.AppSettings["ACTUALIZAR_TORRE"],
                "NORMAL", Obj_Torres_DAL.dtParametros);
        }

        public void Borrar_Torre(ref cls_Torres_DAL Obj_Torres_DAL)
        {
            WCF.BDClient Obj_WCF = new BDClient();

            Obj_Torres_DAL.dtParametros = Obj_WCF.Get_DT_Param(Obj_Torres_DAL.dtParametros);

            Obj_Torres_DAL.dtParametros.Rows.Add("@id_Torre", "1", Obj_Torres_DAL.iId_Torre);

            Obj_Torres_DAL.sMsjError = Obj_WCF.Ins_Upd_Delete(ConfigurationManager.AppSettings["BORRAR_TORRE"],
                "NORMAL", Obj_Torres_DAL.dtParametros);
        }

        public void List_Filt_Torre(ref cls_Torres_DAL Obj_Torres_DAL)
        {
            WCF.BDClient Obj_WCF = new BDClient();

            if (Obj_Torres_DAL.iId_Torre == 0)
            {
                Obj_Torres_DAL.dtParametros = null;
                Obj_Torres_DAL.dtDatos = Obj_WCF.ListarFiltrar("torres", ConfigurationManager.AppSettings["LISTAR_TORRE"], null);
            }
            else
            {
                Obj_Torres_DAL.dtParametros = Obj_WCF.Get_DT_Param(Obj_Torres_DAL.dtParametros);

                Obj_Torres_DAL.dtParametros.Rows.Add("@filtro", "1", Obj_Torres_DAL.iId_Torre);

                Obj_Torres_DAL.dtDatos = Obj_WCF.ListarFiltrar("torres", ConfigurationManager.AppSettings["FILTRAR_TORRE"],
                    Obj_Torres_DAL.dtParametros);
            }
        }

        public void Insertar_Torre(ref cls_Torres_DAL Obj_Torres_DAL)
        {
            WCF.BDClient Obj_WCF = new BDClient();

            Obj_Torres_DAL.dtParametros = Obj_WCF.Get_DT_Param(Obj_Torres_DAL.dtParametros);

            Obj_Torres_DAL.dtParametros.Rows.Add("@id_torre", "1", Obj_Torres_DAL.iId_Torre);
            Obj_Torres_DAL.dtParametros.Rows.Add("@marca", "7", Obj_Torres_DAL.sMarca_Torre);
            Obj_Torres_DAL.dtParametros.Rows.Add("@modelo", "7", Obj_Torres_DAL.sModelo_Torre);
            Obj_Torres_DAL.dtParametros.Rows.Add("@id_Disco", "1", Obj_Torres_DAL.iId_Disco);
            Obj_Torres_DAL.dtParametros.Rows.Add("@id_Memoria", "1", Obj_Torres_DAL.iId_Memoria);

            Obj_Torres_DAL.sMsjError = Obj_WCF.Ins_Upd_Delete(ConfigurationManager.AppSettings["INSERTAR_TORRE"],
                "NORMAL", Obj_Torres_DAL.dtParametros);
        }
    }
    
}        

