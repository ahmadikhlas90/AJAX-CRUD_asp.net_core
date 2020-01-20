using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crud.Entities
{
    public interface IListable
    {
        int Id { get; set; }
        string Name { get; set; }
    }
}
