using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class SkuFareTemplateServiceGetTemplatesResponse : JdResponse{


         [XmlElement("query_skuFareTemplate_result")]
public  		string
  querySkuFareTemplateResult { get; set; }


}
}
