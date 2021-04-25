using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminUI.Models
{
    public class BrandListViewModel
    {
        public IDataResult<List<Brand>> Brands { get; internal set; }
    }
}
