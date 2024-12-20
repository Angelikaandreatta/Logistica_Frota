﻿using Application.Services.Interfaces;
using Domain.Entities;
using Domain.Repositories;

namespace Application.Services
{
    public class EnderecoEntregaService : IEnderecoEntregaService
    {
        private readonly IEnderecoEntregaRepository _enderecoEntregaRepository;

        public EnderecoEntregaService(IEnderecoEntregaRepository enderecoEntregaRepository)
        {
            _enderecoEntregaRepository = enderecoEntregaRepository;
        }

        public async Task<IEnumerable<Endereco_Entrega>> GetAllAsync()
        {
            return await _enderecoEntregaRepository.GetAllAsync();
        }

        public async Task AddAsync(Endereco_Entrega enderecoEntrega)
        {
            await _enderecoEntregaRepository.AddAsync(enderecoEntrega);
        }

        public async Task UpdateAsync(Endereco_Entrega enderecoEntrega)
        {
            await _enderecoEntregaRepository.UpdateAsync(enderecoEntrega);
        }

        public async Task DeleteAsync(Endereco_Entrega enderecoEntrega)
        {
            await _enderecoEntregaRepository.DeleteAsync(enderecoEntrega);
        }
    }
}
