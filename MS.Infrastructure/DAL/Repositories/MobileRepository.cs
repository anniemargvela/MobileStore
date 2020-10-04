using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MS.Domain.Abstractions.Repositories;
using MS.Domain.CommonModels;
using MS.Domain.Entities;
using MS.Infrastructure.DAL.Context;
using MS.Infrastructure.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS.Infrastructure.DAL.Repositories
{
    class MobileRepository : IMobilesRepository
    {
        private const int ItemsPerPage = 6;
        private readonly MSContext _context;
        private readonly IMapper _mapper;

        public MobileRepository(MSContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<Mobile> GetDetails(int id)
        {
            var p = await _context
                .Mobiles
                .Include(a => a.Videos)
                .Include(a => a.Photos)
                .FirstOrDefaultAsync(i => i.ID == id);

            if (p == null) return null;

            return _mapper.Map<Mobile>(p);
        }

        public async Task<Page<Mobile>> GetMobilesList(MobilesFilter filter)
        {
            var result = _context.Mobiles
                .Include(a => a.Videos)
                .Include(a => a.Photos)
                .AsQueryable();

            if (!string.IsNullOrEmpty(filter.Name))
                result = result.Where(i => EF.Functions.Like(i.Name, $"%{filter.Name}%"));
            if (!string.IsNullOrEmpty(filter.Manufacturer))
                result = result.Where(i => EF.Functions.Like(i.Manufacturer, $"%{filter.Manufacturer}%"));
            if (filter.PriceFrom != null)
                result = result.Where(i => i.Price >= filter.PriceFrom);
            if (filter.PriceTo != null)
                result = result.Where(i => i.Price <= filter.PriceTo);

            var pageCount = result.Count();
            result = result.Skip((filter.Page-1) * ItemsPerPage);
            result = result.Take(ItemsPerPage);
            

            return new Page<Mobile> { Data = _mapper.Map<IEnumerable<Mobile>>(await result.ToListAsync()), PageCount = pageCount };
        }
    }
}
