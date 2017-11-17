using System;
using System.Xml.Serialization;
using System.Collections.Generic;

				namespace Jd.Api.Response
{





public class DropshipDpsCurrenttimeResponse : JdResponse{


         [XmlElement("currentTime")]
public  		DateTime
  currentTime { get; set; }


}
}
