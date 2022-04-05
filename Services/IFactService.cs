using NetwiseTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetwiseTest.Services
{
    public interface IFactService
    {
        bool GetFactError { get; }
        Task<Fact> GetFact();
    }
}
