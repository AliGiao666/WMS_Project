using System;
using System.Collections.Generic;
using System.Text;
using WMS_Models.Pro_Models;

namespace WMS_Business.Hanna_Buniness
{
    public interface IBLL
    {
        /// <summary>
        /// 仓库管理信息全部展示
        /// </summary>
        /// <returns></returns>
        public List<WarehouseTBModel> WarehousePageShow();
    }
}
