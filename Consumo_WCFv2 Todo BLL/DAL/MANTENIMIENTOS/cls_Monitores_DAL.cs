using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace DAL.MANTENIMIENTOS
{
    public class cls_Monitores_DAL
    {
        #region VARIABLES PRIVADAS
        private int _iId_Monitor;
        private string _sTipo_Monitor, _sMarca_Monitor, _sModelo_Monitor, _sTipo_Memoria, _sMsjError;
        private DataTable _dtDatos, _dtParametros;
        #endregion

        #region VARIABLES PUBLICAS 
        public int iId_Monitor { get => _iId_Monitor; set => _iId_Monitor = value; }
        public string sTipo_Monitor { get => _sTipo_Monitor; set => _sTipo_Monitor = value; }
        public string sMarca_Monitor { get => _sMarca_Monitor; set => _sMarca_Monitor = value; }
        public string sModelo_Monitor { get => _sModelo_Monitor; set => _sModelo_Monitor = value; }
        public string sTipo_Memoria { get => _sTipo_Memoria; set => _sTipo_Memoria = value; }
        public string sMsjError { get => _sMsjError; set => _sMsjError = value; }
        public DataTable dtDatos { get => _dtDatos; set => _dtDatos = value; }
        public DataTable dtParametros { get => _dtParametros; set => _dtParametros = value; }
        #endregion


    }
}
