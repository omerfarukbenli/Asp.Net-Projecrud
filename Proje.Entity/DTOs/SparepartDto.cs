using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Entity.DTOs
{
    public class SparepartDto
    {
        public int SparePartId { get; set; }
        public string SparepartName { get; set; }
        public int SparepartBarcode { get; set; }
        public string SparepartCountry { get; set; }
    }
}
