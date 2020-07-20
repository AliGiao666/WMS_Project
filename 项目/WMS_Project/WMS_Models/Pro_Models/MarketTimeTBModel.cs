using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace WMS_Models.Pro_Models
{
	 public class MarketTimeTBModel
	 {
		 public Guid  Id { get; set; }
		 public DateTime  MarketTime { get; set; }
		 public string  MarketTimeId { get; set; }
		 public string  BusinessId { get; set; }
		 public string  ProductId { get; set; }
		 public int  MarketNum { get; set; }
		 public string  WarehouseId { get; set; }
		 public string  ProductTypeId { get; set; }
		 public string  BrandId { get; set; }
		 public decimal  MarketTotal { get; set; }
		 public decimal  Margin { get; set; }
	 }
}
