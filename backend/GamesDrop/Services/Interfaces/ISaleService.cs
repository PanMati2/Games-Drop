using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GamesDrop.Dtos;
using GamesDrop.Results;

namespace GamesDrop.Services.Interfaces
{
    public interface ISaleService
    {
        Task<bool> SaleExistsAsync(int gameId, DateTime validFrom, DateTime validTo);
        Task<ServiceResult> CreateSaleAsync(SaleDto saleDto);
        Task<IEnumerable<GameDto>> GetAllGameDtosOnSaleAsync();
    }
}