using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace WMS_Models.Pro_Models
{
	 public class BreakageStorageModel
	 {
		 public Guid  Brid { get; set; }
		 public string  BrName { get; set; }
		 public string  Prid { get; set; }
		 public string  BrBatch { get; set; }
		 public string  Spid { get; set; }
		 public int  BrNumber { get; set; }
		 public string  Stid { get; set; }
		 public string  Blid { get; set; }
		 public string  BrPrepared { get; set; }
		 public string  Sid { get; set; }
		 public string  BrAudit { get; set; }
		 public DateTime  BrAuditTime { get; set; }
		 public string  BrRelevance { get; set; }
		 public DateTime  BrPreparedTime { get; set; }
		 public string  BrAddres { get; set; }
	 }
}
