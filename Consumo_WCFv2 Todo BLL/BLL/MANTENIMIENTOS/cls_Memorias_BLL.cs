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
    public class cls_Memorias_BLL
    {
        public void Actualizar_Memoria(ref cls_Memorias_DAL Obj_Memorias_DAL)
        {
            WCF.BDClient Obj_WCF = new BDClient();

            Obj_Memorias_DAL.dtParametros = Obj_WCF.Get_DT_Param(Obj_Memorias_DAL.dtParametros);

            Obj_Memorias_DAL.dtParametros.Rows.Add("@id_Memoria", "1", Obj_Memorias_DAL.iId_Memoria);
            Obj_Memorias_DAL.dtParametros.Rows.Add("@tipo_Memoria", "7", Obj_Memorias_DAL.sTipo_Memoria);
           

            Obj_Memorias_DAL.sMsjError = Obj_WCF.Ins_Upd_Delete(ConfigurationManager.AppSettings["ACTUALIZAR_MEMORIA"],
                "NORMAL", Obj_Memorias_DAL.dtParametros);
        }

        public void Borrar_Memoria(ref cls_Memorias_DAL Obj_Memorias_DAL)
        {
            WCF.BDClient Obj_WCF = new BDClient();

            Obj_Memorias_DAL.dtParametros = Obj_WCF.Get_DT_Param(Obj_Memorias_DAL.dtParametros);

            Obj_Memorias_DAL.dtParametros.Rows.Add("@id_Memoria", "1", Obj_Memorias_DAL.iId_Memoria);

            Obj_Memorias_DAL.sMsjError = Obj_WCF.Ins_Upd_Delete(ConfigurationManager.AppSettings["BORRAR_MEMORIA"],
                "NORMAL", Obj_Memorias_DAL.dtParametros);
        }

        public void List_Filt_Memoria(ref cls_Memorias_DAL Obj_Memorias_DAL)
        {
            WCF.BDClient Obj_WCF = new BDClient();

            if (Obj_Memorias_DAL.iId_Memoria == 0)
            {
                Obj_Memorias_DAL.dtParametros = null;
                Obj_Memorias_DAL.dtDatos = Obj_WCF.ListarFiltrar("memorias", ConfigurationManager.AppSettings["LISTAR_MEMORIA"], null);
            }
            else
            {
                Obj_Memorias_DAL.dtParametros = Obj_WCF.Get_DT_Param(Obj_Memorias_DAL.dtParametros);

                Obj_Memorias_DAL.dtParametros.Rows.Add("@filtro", "1", Obj_Memorias_DAL.iId_Memoria);

                Obj_Memorias_DAL.dtDatos = Obj_WCF.ListarFiltrar("memorias", ConfigurationManager.AppSettings["FILTRAR_MEMORIA"],
                    Obj_Memorias_DAL.dtParametros);
            }
        }

        public void Insertar_Memoria(ref cls_Memorias_DAL Obj_Memorias_DAL)
        {
            WCF.BDClient Obj_WCF = new BDClient();

            Obj_Memorias_DAL.dtParametros = Obj_WCF.Get_DT_Param(Obj_Memorias_DAL.dtParametros);

            Obj_Memorias_DAL.dtParametros.Rows.Add("@id_Memoria", "1", Obj_Memorias_DAL.iId_Memoria);
            Obj_Memorias_DAL.dtParametros.Rows.Add("@tipo_Memoria", "7", Obj_Memorias_DAL.sTipo_Memoria);


            Obj_Memorias_DAL.sMsjError = Obj_WCF.Ins_Upd_Delete(ConfigurationManager.AppSettings["INSERTAR_MEMORIA"],
                "NORMAL", Obj_Memorias_DAL.dtParametros);
        }
    }
    
}        

