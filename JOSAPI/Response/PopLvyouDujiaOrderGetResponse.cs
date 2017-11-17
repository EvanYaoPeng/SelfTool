using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class PopLvyouDujiaOrderGetResponse : JdResponse{


         [XmlElement("findorderbyorderid_result")]
public  		string
  findorderbyorderidResult { get; set; }


}
}
