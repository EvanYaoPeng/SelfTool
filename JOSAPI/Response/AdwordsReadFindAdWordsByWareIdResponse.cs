using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class AdwordsReadFindAdWordsByWareIdResponse : JdResponse{


         [XmlElement("adWords")]
public  		string
  adWords { get; set; }


}
}
