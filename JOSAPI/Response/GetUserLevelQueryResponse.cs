using System;
using System.Xml.Serialization;
using System.Collections.Generic;

				namespace Jd.Api.Response
{





public class GetUserLevelQueryResponse : JdResponse{


         [XmlElement("userLevel")]
public  		string
  userLevel { get; set; }


}
}
