using MVCTestProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCTestProject.Domain.Abstract
{
    public interface IGamesRepository
    {
        IEnumerable<Game> Games { get; }
    }
}
