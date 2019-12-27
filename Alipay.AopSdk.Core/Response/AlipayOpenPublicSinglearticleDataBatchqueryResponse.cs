using System.Collections.Generic;
using System.Xml.Serialization;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// AlipayOpenPublicSinglearticleDataBatchqueryResponse.
    /// </summary>
    public class AlipayOpenPublicSinglearticleDataBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 单篇文章分析数据列表
        /// </summary>
        [XmlArray("data_list")]
        [XmlArrayItem("single_article_analysis_data")]
        public List<SingleArticleAnalysisData> DataList { get; set; }
    }
}
