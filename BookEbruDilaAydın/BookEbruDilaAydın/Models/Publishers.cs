using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookEbruDilaAydın.Models
{
    internal class Publishers
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string books { get; set; }
    }
}
