using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace WMS_Models.Pro_Models
{
	 public class SupplierModel
	 {
		 public Guid  Supplier_ID { get; set; }
		 public string  Supplier_Num { get; set; }
		 public string  Supplier_Name { get; set; }
		 public string  Supplier_TypeID { get; set; }
		 public string  Supplier_Phone { get; set; }
		 public string  Supplier_Email { get; set; }
		 public string  Supplier_Person { get; set; }
		 public string  Supplier_Address { get; set; }
		 public DateTime  Supplier_Ctime { get; set; }
	 }
}
