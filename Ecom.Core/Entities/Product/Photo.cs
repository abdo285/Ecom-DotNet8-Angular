using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecom.Core.Entities.Product
{
    public class Photo : BaseEntity
    {
        public string Url { get; set; } = string.Empty;
        public string? Caption { get; set; }

        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}
