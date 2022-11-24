using NewL.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewL.Entities.Concrete
{
    public class Comment : EntityBase, IEntity
    {
        public string Text { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
