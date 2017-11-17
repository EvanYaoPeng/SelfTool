using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class KuaicheZnPlanSearchKeywordGetResponse : JdResponse{


         [XmlElement("keywords_info")]
public  		List<string>
  keywordsInfo { get; set; }


}
}
