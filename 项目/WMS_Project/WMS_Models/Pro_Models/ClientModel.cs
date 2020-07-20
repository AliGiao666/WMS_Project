using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace WMS_Models.Pro_Models
{
	 public class ClientModel
	 {
		 public Guid  Client_ID { get; set; }
		 public string  Client_Num { get; set; }
		 public string  Client_Name { get; set; }
		 public string  Client_Address { get; set; }
		 public string  Client_Phone { get; set; }
		 public string  Client_Person { get; set; }
		 public string  Client_Email { get; set; }
		 public DateTime  Client_Ctime { get; set; }
		 public string  Client_TypeID { get; set; }
	 }
}
