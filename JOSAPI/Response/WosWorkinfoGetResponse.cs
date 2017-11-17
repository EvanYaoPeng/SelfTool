using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class WosWorkinfoGetResponse : JdResponse{


         [XmlElement("result")]
public  		List<string>
  result { get; set; }


}
}
