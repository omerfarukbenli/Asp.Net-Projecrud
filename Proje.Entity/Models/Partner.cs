using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Entity.Models
{
    public class Partner
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int SparepartId { get; set; }
        public Sparepart Sparepart { get; set; }
    }
}
