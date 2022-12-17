using E_Commerce.Core.Repository.CrossCuttingRepository;
using E_Commerce.Repository.Repositories.EFBaseRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Repository.Repositories.CrossCuttingRepository
{
    public class CrossCuttingRepository<T> : EFBaseRepository<T>, ICrossCuttingRepository<T> where T : class
    {
        public CrossCuttingRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
