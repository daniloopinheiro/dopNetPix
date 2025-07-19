using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dopNP.Domain.Entities
{
    public class Pix
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string? PayName { get; set; }
        public decimal Qtd { get; set; }
        public DateTime CriadoEm { get; set; } = DateTime.UtcNow;
    }
}
