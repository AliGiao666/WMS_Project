using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace WMS_Models.Pro_Models
{
	 public class WLocationModel
	 {
		 public Guid  WLocation_ID { get; set; }
		 public string  WLocation_Num { get; set; }
		 public string  WLocation_Name { get; set; }
		 public string  WLocation_TypeID { get; set; }
		 public string  WLocation_WID { get; set; }
		 public string  WLocation_IsUse { get; set; }
		 public DateTime  WLocation_Ctime { get; set; }
	 }
}
