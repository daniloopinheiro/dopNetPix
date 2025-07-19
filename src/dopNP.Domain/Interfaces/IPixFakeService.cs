using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dopNP.Domain.Interfaces
{
    public interface IPixFakeService
    {
        Task<string> GerarPixFakeAsync(string PayName, decimal Qtd);
    }
}
