using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Core.Enums.ErrorCodes
{
    public class SystemErrors : ISystemError
    {
        public string ErrorMessage { get; set; } = "";
        public SystemErrorNumbers ErrorNumber { get; set; }

        public static SystemErrors INVALID_INPUT
        { 
            get {
                return new SystemErrors()
                {
                    ErrorMessage = nameof(INVALID_INPUT),
                    ErrorNumber = SystemErrorNumbers.INVALID_INPUT,
                };
            } 
        }
        public static SystemErrors NOT_FOUND
        {
            get
            {
                return new SystemErrors()
                {
                    ErrorMessage = nameof(NOT_FOUND),
                    ErrorNumber = SystemErrorNumbers.NOT_FOUND,
                };
            }
        }
        public static SystemErrors INTERNAL_SERVER_ERROR
        {
            get
            {
                return new SystemErrors()
                {
                    ErrorMessage = nameof(INTERNAL_SERVER_ERROR),
                    ErrorNumber = SystemErrorNumbers.INTERNAL_SERVER_ERROR,
                };
            }
        }
    }
    public enum SystemErrorNumbers
    {
        INVALID_INPUT = 1,
        INTERNAL_SERVER_ERROR = 2,
        NOT_FOUND = 3,
    }
}
