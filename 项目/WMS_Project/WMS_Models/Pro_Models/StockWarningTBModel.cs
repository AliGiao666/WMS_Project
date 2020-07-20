using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace WMS_Models.Pro_Models
{
	 public class StockWarningTBModel
	 {
		 public Guid  Id { get; set; }
		 public string  ProductId { get; set; }
		 public int  StockUpper { get; set; }
		 public int  StockFloor { get; set; }
		 public int  StockShu { get; set; }
	 }
}
