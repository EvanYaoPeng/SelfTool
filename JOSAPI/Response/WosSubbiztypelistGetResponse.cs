using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class WosSubbiztypelistGetResponse : JdResponse{


         [XmlElement("saf_biztype_Dtos")]
public  		List<string>
  safBiztypeDtos { get; set; }


}
}
