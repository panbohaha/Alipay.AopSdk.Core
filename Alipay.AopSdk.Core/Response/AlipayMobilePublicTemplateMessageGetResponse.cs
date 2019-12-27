using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// AlipayMobilePublicTemplateMessageGetResponse.
    /// </summary>
    public class AlipayMobilePublicTemplateMessageGetResponse : AopResponse
    {
        /// <summary>
        /// 消息模板id--商户领取母版后生成的唯一模板id
        /// </summary>
        [XmlElement("msg_template_id")]
        public string MsgTemplateId { get; set; }

        /// <summary>
        /// 模板内容
        /// </summary>
        [XmlElement("template")]
        public string Template { get; set; }
    }
}
