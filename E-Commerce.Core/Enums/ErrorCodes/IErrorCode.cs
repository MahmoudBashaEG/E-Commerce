using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Core.Enums.ErrorCodes
{
    public interface ISystemError
    {
        public string ErrorMessage { get; set; }
        public SystemErrorNumbers ErrorNumber { get; set; }
    }
}
