using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using System.Linq;

namespace WebApp.TestEfecty.BackEnd.DAL.Repositories
{
    public class TipoDocRepository
    {
        Cnx cnx = new Cnx();
        public List<TipoDocDAO> GetAll() {
            List<TipoDocDAO> tipoDocs = new List<TipoDocDAO>();
            DataTable tab = cnx.ExecuteReader("select * from TipoDoc");
            foreach (DataRow row in tab.Rows)
            {
                TipoDocDAO tipoDoc = new TipoDocDAO {
                    IdTipoDoc = row["idTipoDoc"].ToString(),
                    Descripcion = row["Descripcion"].ToString()
                };
                tipoDocs.Add(tipoDoc);
            }
            return tipoDocs;
        }
    }
}
