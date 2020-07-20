using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace WMS_Models.Pro_Models
{
	 public class FinanceDetailTBModel
	 {
		 public Guid  Id { get; set; }
		 public string  Serial { get; set; }
		 public string  ProductId { get; set; }
		 public string  Payee { get; set; }
		 public string  Receivable { get; set; }
		 public decimal  PaymentMoney { get; set; }
		 public string  PaymentWay { get; set; }
		 public string  PaymentOrgan { get; set; }
		 public DateTime  PaymentTime { get; set; }
	 }
}
