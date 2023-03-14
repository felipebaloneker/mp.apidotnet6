using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Mp.ApiDotNet6.Domain.Validations;

namespace Mp.ApiDotNet6.Domain.Entities
{
    
    public class Purchase
    {
       public int Id { get; private set; }
        public int ProductId { get; private set; }
        public int PersonId { get; private set; }
        public DateTime Date { get; private set; }
        public Person Person { get; set; }
        public Product Product { get; set; }
        public Purchase(int productId, int personId, DateTime? date) {
            Validation(productId, personId, date);
        }
        public Purchase(int id,int productId, int personId, DateTime? date) {
            DomainValidationException.When(id < 0, "Id deve ser Informado");
            Validation(productId, personId, date);
        }

        private void Validation(int productId, int personId, DateTime? date)
        {
            DomainValidationException.When(productId < 0, "Id produto deve ser informado");
            DomainValidationException.When(personId < 0, "Id pessoa deve ser informado");
            DomainValidationException.When(!date.HasValue, "data da compra deve ser informada");

            PersonId = personId;
            ProductId = productId;
            Date = date.Value;
        }

    }
}
