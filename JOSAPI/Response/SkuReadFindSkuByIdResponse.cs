using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class SkuReadFindSkuByIdResponse : JdResponse{


         [XmlElement("sku")]
public  		string
  sku { get; set; }


}
}
