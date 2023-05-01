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
    public class cls_Teclados_BLL
    {
        public void Actualizar_Teclado(ref cls_Teclados_DAL Obj_Teclados_DAL)
        {
            WCF.BDClient Obj_WCF = new BDClient();

            Obj_Teclados_DAL.dtParametros = Obj_WCF.Get_DT_Param(Obj_Teclados_DAL.dtParametros);

            Obj_Teclados_DAL.dtParametros.Rows.Add("@teclado", "1", Obj_Teclados_DAL.iId_Teclado);
            Obj_Teclados_DAL.dtParametros.Rows.Add("@tipo_Teclado", "7", Obj_Teclados_DAL.sTipo_Teclado);
            Obj_Teclados_DAL.dtParametros.Rows.Add("@marca_Teclado", "7", Obj_Teclados_DAL.sMarca_Teclado);
            Obj_Teclados_DAL.dtParametros.Rows.Add("@modelo_Teclado", "7", Obj_Teclados_DAL.sModelo_Teclado);
          
            Obj_Teclados_DAL.sMsjError = Obj_WCF.Ins_Upd_Delete(ConfigurationManager.AppSettings["ACTUALIZAR_TECLADO"],
                "NORMAL", Obj_Teclados_DAL.dtParametros);
        }

        public void Borrar_Teclado(ref cls_Teclados_DAL Obj_Teclados_DAL)
        {
            WCF.BDClient Obj_WCF = new BDClient();

            Obj_Teclados_DAL.dtParametros = Obj_WCF.Get_DT_Param(Obj_Teclados_DAL.dtParametros);

            Obj_Teclados_DAL.dtParametros.Rows.Add("@teclado", "1", Obj_Teclados_DAL.iId_Teclado);

            Obj_Teclados_DAL.sMsjError = Obj_WCF.Ins_Upd_Delete(ConfigurationManager.AppSettings["BORRAR_TECLADO"], "NORMAL", Obj_Teclados_DAL.dtParametros);

        }

        public void List_Filt_Teclado(ref cls_Teclados_DAL Obj_Teclados_DAL)
        {
            WCF.BDClient Obj_WCF = new BDClient();

            if (Obj_Teclados_DAL.iId_Teclado == 0)
            {
                Obj_Teclados_DAL.dtParametros = null;
                Obj_Teclados_DAL.dtDatos = Obj_WCF.ListarFiltrar("teclados", ConfigurationManager.AppSettings["LISTAR_TECLADOS"], null);
            }
            else
            {
                Obj_Teclados_DAL.dtParametros = Obj_WCF.Get_DT_Param(Obj_Teclados_DAL.dtParametros);

                Obj_Teclados_DAL.dtParametros.Rows.Add("@filtro", "1", Obj_Teclados_DAL.iId_Teclado);

                Obj_Teclados_DAL.dtDatos = Obj_WCF.ListarFiltrar("teclados", ConfigurationManager.AppSettings["FILTRAR_TECLADOS"],
                    Obj_Teclados_DAL.dtParametros);
            }
        }

        public void Insertar_Teclados(ref cls_Teclados_DAL Obj_Teclados_DAL)
        {
            WCF.BDClient Obj_WCF = new BDClient();

            Obj_Teclados_DAL.dtParametros = Obj_WCF.Get_DT_Param(Obj_Teclados_DAL.dtParametros);

            Obj_Teclados_DAL.dtParametros.Rows.Add("@teclado", "1", Obj_Teclados_DAL.iId_Teclado);
            Obj_Teclados_DAL.dtParametros.Rows.Add("@tipo_Teclado", "7", Obj_Teclados_DAL.sTipo_Teclado);
            Obj_Teclados_DAL.dtParametros.Rows.Add("@marca_Teclado", "7", Obj_Teclados_DAL.sMarca_Teclado);
            Obj_Teclados_DAL.dtParametros.Rows.Add("@modelo_Teclado", "7", Obj_Teclados_DAL.sModelo_Teclado);

            Obj_Teclados_DAL.sMsjError = Obj_WCF.Ins_Upd_Delete(ConfigurationManager.AppSettings["INSERTAR_TECLADO"],
                "NORMAL", Obj_Teclados_DAL.dtParametros);
        }
    }
    
}        

