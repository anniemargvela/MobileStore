using MS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MS.Domain.CommonModels
{
    public class Page<T>
    {
        public IEnumerable<T> Data { get; set; }
        public int PageCount { get; set; }

    }
}
