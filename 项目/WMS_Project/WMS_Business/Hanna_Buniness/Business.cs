using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using WMS_Models.Pro_Models;
using System.Linq;
using Dapper;
using WMS_DataAccess;

namespace WMS_Business.Hanna_Buniness
{
    public class Business : IBLL
    {
        public string con = "Data Source=.;Initial Catalog=WMSDB;Integrated Security=True";
        WMS_DataAccess.Hanna_DataAccess.DataAccess dal = new WMS_DataAccess.Hanna_DataAccess.DataAccess();
        /// <summary>
        /// 仓库管理信息全部展示具体方法
        /// </summary>
        /// <returns></returns>
        public List<WarehouseTBModel> WarehousePageShow()
        {
            using (SqlConnection connection=new SqlConnection(con))
            {
                string sql = $"select a.Warehouse_Num,a.Warehouse_Name,a.Warehouse_Ctime,b.WarehouseType_Name,c.DepartmentName,a.Warehouse_IsUse,a.Warehouse_Address,a.Warehouse_Area,a.Warehouse_Manager,a.Warehouse_ManagerPhone from WarehouseTB a join WarehouseType b on a.Warehouse_TypeID = b.WarehouseType_ID join DepartmentTB c on a.Warehouse_DepartID = c.Id";
                return connection.Query<WarehouseTBModel>(sql).ToList();
            }
        }
    }
}
