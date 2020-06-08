using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.TestEfecty.BackEnd.DAL;
using WebApp.TestEfecty.BackEnd.DAL.Repositories;
using WebApp.TestEfecty.BackEnd.Util.DTO;

namespace WebApp.TestEfecty.BackEnd.BL
{
    public class TipoDocBL
    {
        public List<TipoDocDTO> GetAll() {
            List<TipoDocDTO> docDTOs = new List<TipoDocDTO>();
            List<TipoDocDAO> docDAOs = new TipoDocRepository().GetAll();
            foreach (var tipoDoc in docDAOs)
            {
                TipoDocDTO tipoDocDTO = new TipoDocDTO {
                    IdTipoDoc = tipoDoc.IdTipoDoc,
                    Descripcion = tipoDoc.Descripcion
                };
                docDTOs.Add(tipoDocDTO);
            }
            return docDTOs;
        } 
    }
}
