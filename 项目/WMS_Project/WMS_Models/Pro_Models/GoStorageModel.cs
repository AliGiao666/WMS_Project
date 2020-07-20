using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace WMS_Models.Pro_Models
{
	 public class GoStorageModel
	 {
		 public Guid  Goid { get; set; }
		 public string  GoName { get; set; }
		 public string  Prid { get; set; }
		 public string  GoBatch { get; set; }
		 public string  Spid { get; set; }
		 public int  GoNumber { get; set; }
		 public string  Stid { get; set; }
		 public string  Glid { get; set; }
		 public string  GoSupplierName { get; set; }
		 public string  GoPrepared { get; set; }
		 public string  Sid { get; set; }
		 public string  GoAudit { get; set; }
		 public DateTime  GoAuditTime { get; set; }
		 public string  GoAuditNum { get; set; }
		 public string  GoAuditPeople { get; set; }
		 public string  GoAuditPhone { get; set; }
		 public string  GoRelevance { get; set; }
		 public DateTime  GoPreparedTime { get; set; }
		 public string  GoAddres { get; set; }
		 public int  GoTotalPrice { get; set; }
	 }
}
