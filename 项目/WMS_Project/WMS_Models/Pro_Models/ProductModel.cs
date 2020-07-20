using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace WMS_Models.Pro_Models
{
	 public class ProductModel
	 {
		 public Guid  Product_ID { get; set; }
		 public string  Product_Num { get; set; }
		 public string  Product_Name { get; set; }
		 public string  Product_SupplierID { get; set; }
		 public string  Product_UnitID { get; set; }
		 public string  Product_Type { get; set; }
		 public string  Product_PackType { get; set; }
		 public decimal  Product_Price { get; set; }
		 public int  Product_Snumber { get; set; }
		 public int  Product_Lnumber { get; set; }
		 public decimal  Product_Heavy { get; set; }
	 }
}
