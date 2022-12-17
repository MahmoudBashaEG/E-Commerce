using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_Commerce.Core.Entities.BaseEntity;
using E_Commerce.Core.Enums;

namespace E_Commerce.Core.Entities.CompanyEntity
{
    public class Company : Base
    {
        public string CompanyName { get; set; } = "";
        public CompanyApproveStatus CompanyStatus { get; set; }
        public short StartingHour { get; set; }
        public short EndingHour { get; set; }

    }
}
