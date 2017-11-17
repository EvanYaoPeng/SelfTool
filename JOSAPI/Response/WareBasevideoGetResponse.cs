using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class WareBasevideoGetResponse : JdResponse{


         [XmlElement("videoEntitys")]
public  		List<string>
  videoEntitys { get; set; }


}
}
