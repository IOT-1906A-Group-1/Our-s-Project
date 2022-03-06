using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.InputModels
{
    public class InputAssetApModel:BaseModels
    {
        /// <summary>
        /// 基础信息
        /// </summary>
        public string AssetFoundation { get; set; }
        /// <summary>
        /// 详细信息
        /// </summary>
        public string AssetDetailed { get; set; }
        /// <summary>
        /// 附件详细信息
        /// </summary>
        public string AssetAnnex { get; set; }
    }
}
