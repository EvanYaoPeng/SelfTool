using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class AreaProvinceGetResponse : JdResponse{


         [XmlElement("province_areas")]
public  		string
  provinceAreas { get; set; }


         [XmlElement("success")]
public  		bool
  success { get; set; }


}
}
