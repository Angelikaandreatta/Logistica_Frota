﻿using Domain.Entities;

namespace Application.Services.Interfaces
{
    public interface IEnderecoEntregaService
    {
        Task<IEnumerable<Endereco_Entrega>> GetAllAsync();
        Task AddAsync(Endereco_Entrega enderecoEntrega);
        Task UpdateAsync(Endereco_Entrega enderecoEntrega);
        Task DeleteAsync(Endereco_Entrega enderecoEntrega);
    }
}
