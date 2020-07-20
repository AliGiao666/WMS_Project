using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace WMS_Models.Pro_Models
{
	 public class ProductsTBModel
	 {
		 public Guid  Prid { get; set; }
		 public string  PrName { get; set; }
		 public string  PrNumber { get; set; }
		 public string  PrSpid { get; set; }
		 public string  PrPtid { get; set; }
		 public string  Paid { get; set; }
		 public string  PrShowName { get; set; }
		 public string  PrUsid { get; set; }
		 public string  PrPrice { get; set; }
		 public string  PrWeight { get; set; }
	 }
}
