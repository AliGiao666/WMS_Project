using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace WMS_Models.Pro_Models
{
	 public class MarketIncreaseTBModel
	 {
		 public Guid  Id { get; set; }
		 public DateTime  MarketTimeId { get; set; }
		 public decimal  Margin { get; set; }
		 public decimal  MarketTotal { get; set; }
	 }
}
