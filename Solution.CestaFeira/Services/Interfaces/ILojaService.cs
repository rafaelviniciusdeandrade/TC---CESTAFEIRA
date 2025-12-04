using CestaFeira.Web.Models.Loja;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CestaFeira.Web.Services.Interfaces
{
    public interface ILojaService
    {
        Task<IEnumerable<LojaModel>> ConsultarLojas();
        Task<LojaModel> ConsultarLojaPorId(Guid id);
    }
}
