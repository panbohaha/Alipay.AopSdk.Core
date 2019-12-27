using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayDataDataserviceVerificationResultSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceVerificationResultSendModel : AopObject
    {
        /// <summary>
        /// 部署单记录id
        /// </summary>
        [XmlElement("record_id")]
        public long RecordId { get; set; }

        /// <summary>
        /// 验证结果列表
        /// </summary>
        [XmlArray("result_items")]
        [XmlArrayItem("dx_verify_result_item")]
        public List<DxVerifyResultItem> ResultItems { get; set; }
    }
}
