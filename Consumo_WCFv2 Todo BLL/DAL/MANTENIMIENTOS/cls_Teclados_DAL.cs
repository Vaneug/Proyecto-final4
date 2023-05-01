using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL.MANTENIMIENTOS
{
    public class cls_Teclados_DAL
    {
        #region VARIABLES PRIVADAS 
        private int _iId_Teclado;
        private string _sTipo_Teclado, _sMarca_Teclado, _sModelo_Teclado, _sMsjError;
        private DataTable _dtDatos, _dtParametros;

        #endregion

        #region VARIABLES PUBLICAS
        public int iId_Teclado { get => _iId_Teclado; set => _iId_Teclado = value; }
        public string sTipo_Teclado { get => _sTipo_Teclado; set => _sTipo_Teclado = value; }
        public string sMarca_Teclado { get => _sMarca_Teclado; set => _sMarca_Teclado = value; }
        public string sModelo_Teclado { get => _sModelo_Teclado; set => _sModelo_Teclado = value; }
        public string sMsjError { get => _sMsjError; set => _sMsjError = value; }
        public DataTable dtDatos { get => _dtDatos; set => _dtDatos = value; }
        public DataTable dtParametros { get => _dtParametros; set => _dtParametros = value; }

        #endregion

    }
}
