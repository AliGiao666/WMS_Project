using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace WMS_Models.Pro_Models
{
	 public class LedgerDetailTBModel
	 {
		 public Guid  Id { get; set; }
		 public string  ProductId { get; set; }
		 public string  ProductInt { get; set; }
		 public string  StockNum { get; set; }
		 public string  StockUnits { get; set; }
		 public DateTime  StockTime { get; set; }
	 }
}
