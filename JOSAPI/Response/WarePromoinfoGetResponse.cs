using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class WarePromoinfoGetResponse : JdResponse{


         [XmlElement("promoInfoList")]
public  		List<string>
  promoInfoList { get; set; }


}
}
