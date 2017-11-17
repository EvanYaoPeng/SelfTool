using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class VcItemPurchaserGetResponse : JdResponse{


         [XmlElement("purchaser")]
public  		string
  purchaser { get; set; }


}
}
