using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace WMS_Models.Pro_Models
{
	 public class PutStorageModel
	 {
		 public Guid  Puid { get; set; }
		 public string  PuName { get; set; }
		 public string  Prid { get; set; }
		 public string  PuBatch { get; set; }
		 public string  Spid { get; set; }
		 public int  PuNumber { get; set; }
		 public string  Stid { get; set; }
		 public string  Jlid { get; set; }
		 public string  PuSupplierName { get; set; }
		 public string  PuPrepared { get; set; }
		 public string  Sid { get; set; }
		 public string  PuAudit { get; set; }
		 public DateTime  PuAuditTime { get; set; }
		 public string  PuAuditNum { get; set; }
		 public string  PuAuditPeople { get; set; }
		 public string  PuAuditPhone { get; set; }
		 public string  PuRelevance { get; set; }
		 public DateTime  PuPreparedTime { get; set; }
		 public string  PuAddres { get; set; }
		 public int  PuTotalPrice { get; set; }
	 }
}
