using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class SmartTestResponse : JdResponse{


         [XmlElement("data")]
public  		string
  data { get; set; }


}
}
