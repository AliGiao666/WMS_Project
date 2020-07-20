using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace WMS_Models.Pro_Models
{
	 public class CheckStorageModel
	 {
		 public Guid  Chid { get; set; }
		 public string  ChName { get; set; }
		 public string  Prid { get; set; }
		 public string  ChBatch { get; set; }
		 public string  Spid { get; set; }
		 public int  ChNumber { get; set; }
		 public string  Stid { get; set; }
		 public string  Clid { get; set; }
		 public string  ChPrepared { get; set; }
		 public string  Sid { get; set; }
		 public string  ChAudit { get; set; }
		 public DateTime  ChAuditTime { get; set; }
		 public string  ChRelevance { get; set; }
		 public DateTime  ChPreparedTime { get; set; }
		 public string  ChAddres { get; set; }
		 public int  ChTake { get; set; }
		 public int  ChProfit { get; set; }
	 }
}
