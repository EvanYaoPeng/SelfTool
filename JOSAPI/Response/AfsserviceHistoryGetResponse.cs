using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class AfsserviceHistoryGetResponse : JdResponse{


         [XmlElement("publicResultList")]
public  		string
  publicResultList { get; set; }


}
}
