using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace WMS_Models.Pro_Models
{
	 public class AlterStorageModel
	 {
		 public Guid  Alid { get; set; }
		 public string  AlName { get; set; }
		 public string  Prid { get; set; }
		 public string  AlBatch { get; set; }
		 public string  Spid { get; set; }
		 public int  AlNumber { get; set; }
		 public string  Stid { get; set; }
		 public string  Glid { get; set; }
		 public string  AlPrepared { get; set; }
		 public string  Sid { get; set; }
		 public string  AlAudit { get; set; }
		 public DateTime  AlAuditTime { get; set; }
		 public string  AlRelevance { get; set; }
		 public DateTime  AlPreparedTime { get; set; }
		 public string  AlAddres { get; set; }
	 }
}
