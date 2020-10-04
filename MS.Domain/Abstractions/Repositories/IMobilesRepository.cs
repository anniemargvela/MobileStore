using MS.Domain.CommonModels;
using MS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MS.Domain.Abstractions.Repositories
{
    public interface IMobilesRepository
    {
        Task<Page<Mobile>> GetMobilesList(MobilesFilter filter);
        Task<Mobile> GetDetails(int id);
    }
}
