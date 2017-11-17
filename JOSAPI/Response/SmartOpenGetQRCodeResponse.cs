using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class SmartOpenGetQRCodeResponse : JdResponse{


         [XmlElement("data")]
public  		string
  data { get; set; }


}
}
