using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Entity.Models
{
    public class Sparepart
    {
        public int SparePartId { get; set; }
        public string SparepartName { get; set; }
        public int SparepartBarcode { get; set; }
        public string SparepartCountry { get; set; }
        public ICollection<Partner> Partners { get; set; }
    }
}
