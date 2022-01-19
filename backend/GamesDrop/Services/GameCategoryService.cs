using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using GamesDrop.Data;
using GamesDrop.Dtos;
using GamesDrop.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace GamesDrop.Services
{
    public class GameCategoryService : IGameCategoryService
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public GameCategoryService(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<GameCategoryDto>> GetGameCategoryDtosAsync()
        {
            var gameCategories = await _context.GameCategories
                .AsNoTracking()
                .ToArrayAsync();

            return gameCategories == null
                ? null
                : _mapper.Map<IEnumerable<GameCategoryDto>>(gameCategories);
        }

        public async Task<bool> CategoryExistsByIdAsync(int categoryId)
        {
            var category =
                await _context.GameCategories
                    .AsNoTracking()
                    .FirstOrDefaultAsync(gameCategory => gameCategory.Id == categoryId);

            return category != null;
        }
    }
}