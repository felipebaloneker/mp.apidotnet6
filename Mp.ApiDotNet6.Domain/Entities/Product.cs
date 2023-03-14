using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mp.ApiDotNet6.Domain.Validations;

namespace Mp.ApiDotNet6.Domain.Entities
{
    public sealed class Product
    {
        public int Id { get; private set; }
        public string Name { get; private set; }

        public string CodErp { get; private set; }
        public decimal Price { get; private set; }
        public ICollection<Purchase> Purchases { get; private set; }
        public Product(string name, string codErp, decimal price)
        {
            Validation(name, codErp, price);
        }

        public Product(int id, string name, string codErp, decimal price) {
            DomainValidationException.When(id < 0, "Id do produto deve ser infomado");
            Id = id;
            Validation(name, codErp, price);
        }

        private void Validation(string name, string codErp, decimal price)
        {
            DomainValidationException.When(string.IsNullOrEmpty(name), "Nome deve ser infomado");
            DomainValidationException.When(string.IsNullOrEmpty(codErp), "Codigo Erp deve ser infomado");
            DomainValidationException.When(price <0, "Preço deve ser infomado");

            Name = name;
            CodErp = codErp;
            Price = price;
        }
    }
}
