using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace WMS_Models.Pro_Models
{
	 public class ProductTBModel
	 {
		 public Guid  Id { get; set; }
		 public string  ProductNo { get; set; }
		 public string  ProductName { get; set; }
		 public decimal  PurchasePrice { get; set; }
		 public decimal  MarketPrice { get; set; }
		 public string  ProductId { get; set; }
		 public string  ProductTypeId { get; set; }
		 public string  WarehouseId { get; set; }
		 public string  BrandId { get; set; }
		 public string  ProductBatch { get; set; }
	 }
}
