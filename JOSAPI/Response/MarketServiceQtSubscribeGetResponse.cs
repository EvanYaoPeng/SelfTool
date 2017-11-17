using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class MarketServiceQtSubscribeGetResponse : JdResponse{


         [XmlElement("qtArticleResult")]
public  		string
  qtArticleResult { get; set; }


}
}
