using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace WMS_Models.Pro_Models
{
	 public class EquipmentModel
	 {
		 public Guid  Equipment { get; set; }
		 public string  Equipment_Num { get; set; }
		 public string  Equipment_Name { get; set; }
		 public string  Equipment_IsAuthor { get; set; }
		 public string  Equipment_AuthorNum { get; set; }
		 public string  Equipment_State { get; set; }
		 public string  Equipment_Description { get; set; }
	 }
}
