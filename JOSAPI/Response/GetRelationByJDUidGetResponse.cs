using System;
using System.Xml.Serialization;
using System.Collections.Generic;

							namespace Jd.Api.Response
{





public class GetRelationByJDUidGetResponse : JdResponse{


         [XmlElement("JDuid")]
public  		string
  JDuid { get; set; }


         [XmlElement("thirdPartUid")]
public  		string
  thirdPartUid { get; set; }


}
}
