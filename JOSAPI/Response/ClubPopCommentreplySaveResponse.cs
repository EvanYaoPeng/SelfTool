using System;
using System.Xml.Serialization;
using System.Collections.Generic;

							namespace Jd.Api.Response
{





public class ClubPopCommentreplySaveResponse : JdResponse{


         [XmlElement("resultCode")]
public  		string
  resultCode { get; set; }


         [XmlElement("resultMsg")]
public  		string
  resultMsg { get; set; }


}
}
