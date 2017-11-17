using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class AreasGetResponse : JdResponse{


         [XmlElement("code_areas")]
public  		string
  codeAreas { get; set; }


         [XmlElement("success")]
public  		bool
  success { get; set; }


}
}
