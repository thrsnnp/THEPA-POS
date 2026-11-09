using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace THEPA_POS.Domain.Entities
{
    public class Product
    {
        public int ProductId { get; set; }

        public string Sku { get; set; }

        public string Barcode { get; set; }

        public string Name { get; set; }

        public int CategoryId { get; set; }

        public decimal Price { get; set; }

        public decimal Cost { get; set; }

        public int StockQty { get; set; }

        public int ReorderLevel { get; set; }

        public byte[] Image { get; set; }

        public bool IsActive { get; set; }

        public System.DateTime CreatedAt { get; set; }

        public System.DateTime UpdatedAt { get; set; }
    }
}

