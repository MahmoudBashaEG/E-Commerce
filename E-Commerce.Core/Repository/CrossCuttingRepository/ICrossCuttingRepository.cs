using E_Commerce.Core.Repository.EFRespository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Core.Repository.CrossCuttingRepository
{
    public interface ICrossCuttingRepository<T> : IBaseRepository<T> where T : class
    {
    }
}
