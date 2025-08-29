using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ToysCompany.Context;
using ToysCompany.DTO;
using ToysCompany.Models;

namespace ToysCompany.Services
{

    public class BrinquedoService
    {
        private readonly BrinquedoDbContext _context;

        public BrinquedoService(BrinquedoDbContext context)
        {
            _context = context;
        }

        public async Task<List<Brinquedo>> ListarBrinquedosAsync() 
        { 
            return await _context.Brinquedos.ToListAsync();
        }

        public async Task<BrinquedoDTO> AdicionarBrinquedo(BrinquedoDTO dto)
        {
            var result = new Brinquedo
            {
                Nome = dto.Nome,
                Tipo = dto.Tipo,
                Classificacao = dto.Classificacao,
                Tamanho = dto.Tamanho,
                Preco = dto.Preco
            };
            _context.Brinquedos.Add(result);
            await _context.SaveChangesAsync();
            return new BrinquedoDTO 
            { 
                Nome = result.Nome,
                Tipo = result.Tipo,
                Classificacao = result.Classificacao,
                Tamanho = result.Tamanho,
                Preco = result.Preco
            };
        }
   
        public async Task<BrinquedoDTO> EditarBrinquedo(int id, [FromBody] BrinquedoDTO dto)
        {
            var brinquedo = await _context.Brinquedos.FindAsync(id);

            if (brinquedo == null) return null;

            brinquedo.Nome = dto.Nome;
            brinquedo.Tipo = dto.Tipo;
            brinquedo.Classificacao = dto.Classificacao;
            brinquedo.Tamanho = dto.Tamanho;
            brinquedo.Preco = dto.Preco;

            await _context.SaveChangesAsync();

            return new BrinquedoDTO
            {
                Nome = brinquedo.Nome,
                Tipo = brinquedo.Tipo,
                Classificacao = brinquedo.Classificacao,
                Tamanho = brinquedo.Tamanho,
                Preco = brinquedo.Preco
            };
        }

        public async Task DeletarBrinquedo(int id)
        {
            var brinquedo = await _context.Brinquedos.FindAsync(id);

            if (brinquedo != null)
            {
                _context.Brinquedos.Remove(brinquedo);

                await _context.SaveChangesAsync();
            }

        }

        internal async Task<Brinquedo> EncontrarBrinquedoPorId(int id)
        {
            var brinquedo = await _context.Brinquedos.FindAsync(id);
            return brinquedo;
        }
    }
}
