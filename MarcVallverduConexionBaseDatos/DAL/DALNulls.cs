using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarcVallverduConexionBaseDatos.DAL
{
    public class DALNulls
    {
        public static object DBNullToNull(object val)
        {
            if (val == DBNull.Value)
                return null;
            else
                return val;
        }
        public static object NullToDBNull(object val)
        {
            if (val == null)
                return DBNull.Value;
            else
                return val;
        }
        public static decimal? DBNullToNullDecimal(object val)
        {
            if (val == DBNull.Value)
                return null;
            else
                return (decimal)val;
        }
        public static object NullToDBNullDecimal(decimal? val)
        {
            if (val == null)
                return DBNull.Value;
            else
                return val;
        }
        public static int? DBNullToNullInt(object val)
        {
            if (val == DBNull.Value)
                return null;
            else
                return (int)val;
        }
        public static object NullToDBNullInt(int? val)
        {
            if (val == null)
                return DBNull.Value;
            else
                return val;
        }
    }
}
