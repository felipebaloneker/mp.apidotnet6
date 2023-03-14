using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mp.ApiDotNet6.Domain.Entities
{
    
    public class Purchase
    {
       public int Id { get; private set; }
        public int ProductId { get; private set; }
        public string PersonId { get; private set; }
        public DateTime Date { get; private set; }
        public Person Person { get; set; }
        public Product Product { get; set; }
        public Purchase() { }

    }
}
