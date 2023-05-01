using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL.MANTENIMIENTOS
{
    public class cls_Torres_DAL
    {
        #region VARIABLES PRIVADAS

        private int _iId_Torre, _iId_Disco, _iId_Memoria;
        private string _sMarca_Torre, _sModelo_Torre, _sMsjError;
        private DataTable _dtDatos, _dtParametros;

        #endregion
        #region VARIABLES PUBLICAS 
        public int iId_Torre { get => _iId_Torre; set => _iId_Torre = value; }
        public int iId_Disco { get => _iId_Disco; set => _iId_Disco = value; }
        public int iId_Memoria { get => _iId_Memoria; set => _iId_Memoria = value; }
        public string sMarca_Torre { get => _sMarca_Torre; set => _sMarca_Torre = value; }
        public string sModelo_Torre { get => _sModelo_Torre; set => _sModelo_Torre = value; }
        public string sMsjError { get => _sMsjError; set => _sMsjError = value; }
        public DataTable dtDatos { get => _dtDatos; set => _dtDatos = value; }
        public DataTable dtParametros { get => _dtParametros; set => _dtParametros = value; }

        #endregion

    }
}
