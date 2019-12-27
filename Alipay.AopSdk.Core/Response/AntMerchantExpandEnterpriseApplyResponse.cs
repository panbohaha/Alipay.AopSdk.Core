using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// AntMerchantExpandEnterpriseApplyResponse.
    /// </summary>
    public class AntMerchantExpandEnterpriseApplyResponse : AopResponse
    {
        /// <summary>
        /// 支付宝端商户入驻申请单据号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 外部入驻申请单据号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
