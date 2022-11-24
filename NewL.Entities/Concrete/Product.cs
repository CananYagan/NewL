using NewL.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace NewL.Entities.Concrete
{
    public class Product : EntityBase, IEntity
    {
        public string Name { get; set; }
        public string Content { get; set; }
        public string Thumnail { get; set; }
        public DateTime Date { get; set; }
        public int ViewsCount { get; set; }
        public int CommentCount  { get; set; }
        public string SeoName { get; set; }
        public string SeoDescription { get; set; }
        public string SeoTags { get; set; }
        public int CategorId { get; set; }
        public Category Category { get; set; } //Navigation Property
        public int UserId { get; set; }
        public User  User { get; set; }  
        public ICollection<Comment> Comments { get; set; } //Bir products birden fazla yoruma sahip olabilir.

    }
}
