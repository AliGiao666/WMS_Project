using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace WMS_Models.Pro_Models
{
	 public class UserInfoModel
	 {
		 public Guid  Id { get; set; }
		 public string  UserName { get; set; }
		 public string  UserNumber { get; set; }
		 public string  Name { get; set; }
		 public string  E_Mail { get; set; }
		 public string  Phone { get; set; }
		 public string  Telephone { get; set; }
		 public DateTime  CreateTime { get; set; }
		 public int  Department { get; set; }
		 public int  role { get; set; }
		 public string  Remark { get; set; }
	 }
}
