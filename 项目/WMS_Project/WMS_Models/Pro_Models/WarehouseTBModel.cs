using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace WMS_Models.Pro_Models
{
	 public class WarehouseTBModel
	 {
		 public Guid  Warehouse_ID { get; set; }
		 public string  Warehouse_Num { get; set; }
		 public string  Warehouse_Name { get; set; }
		 public string  Warehouse_TypeID { get; set; }
		 public string  Warehouse_IsUse { get; set; }
		 public string  Warehouse_Address { get; set; }
		 public string  Warehouse_Area { get; set; }
		 public DateTime  Warehouse_Ctime { get; set; }
		 public string  Warehouse_Manager { get; set; }
		 public string  Warehouse_ManagerPhone { get; set; }
		 public DateTime  Warehouse_Etime { get; set; }
		 public string  Warehouse_Time { get; set; }
		 public string  Warehouse_DepartID { get; set; }
		 public DateTime  Warehouse_Btime { get; set; }
	 }
}
