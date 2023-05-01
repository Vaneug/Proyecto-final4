using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace DAL.MANTENIMIENTOS
{
    public class cls_Otros_DAL
    {
        #region VARIABLES PRIVADAS 
        private int _iId_Otro;
        private string _sTipo_Otro, _sMarca_Otro, _sModelo_Otro, _sMsjError;
        private DataTable _dtDatos, _dtParametros;

        #endregion

        #region VARIABLES PUBLICAS 
        public int iId_Otro { get => _iId_Otro; set => _iId_Otro = value; }
        public string sTipo_Otro { get => _sTipo_Otro; set => _sTipo_Otro = value; }
        public string sMarca_Otro { get => _sMarca_Otro; set => _sMarca_Otro = value; }
        public string sModelo_Otro { get => _sModelo_Otro; set => _sModelo_Otro = value; }
        public string sMsjError { get => _sMsjError; set => _sMsjError = value; }
        public DataTable dtDatos { get => _dtDatos; set => _dtDatos = value; }
        public DataTable dtParametros { get => _dtParametros; set => _dtParametros = value; }
        #endregion

    }
}
