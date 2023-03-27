using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookEbruDilaAydın.Models
{
    public class Books
    {
       public int Id { get; set; }
        public string Name { get; set; }
        public DateTime PublishingTime { get; set; }
         public int Publisher { get; set; }
       // ForeignKeyConstraint keyConstraint { get; set; }
    }
}
