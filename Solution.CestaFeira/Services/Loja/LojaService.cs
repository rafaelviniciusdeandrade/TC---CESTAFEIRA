using CestaFeira.Web.Models.Loja;
using CestaFeira.Web.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CestaFeira.Web.Services.Loja
{
    public class LojaService : ILojaService
    {
        public async Task<IEnumerable<LojaModel>> ConsultarLojas()
        {
            // Exemplo: simulação de dados (você pode trocar por busca real no banco)
            var lojas = new List<LojaModel>
            {
                new LojaModel { Id = Guid.NewGuid(), Nome = "Feira da Praça", Responsavel = "João Silva", Endereco = "Rua das Flores, 123", Telefone = "(35) 99999-1111" },
                new LojaModel { Id = Guid.NewGuid(), Nome = "Horta Natural", Responsavel = "Maria Oliveira", Endereco = "Av. Central, 456", Telefone = "(35) 98888-2222" }
            };

            return await Task.FromResult(lojas);
        }

        public async Task<LojaModel> ConsultarLojaPorId(Guid id)
        {
            var loja = new LojaModel { Id = id, Nome = "Feira da Praça", Responsavel = "João Silva", Endereco = "Rua das Flores, 123", Telefone = "(35) 99999-1111" };
            return await Task.FromResult(loja);
        }
    }
}
