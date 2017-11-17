using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class WareAssemblePromotionInfoGetResponse : JdResponse{


         [XmlElement("promoInfoResponseList")]
public  		List<string>
  promoInfoResponseList { get; set; }


}
}
