using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class AreaTownGetResponse : JdResponse{


         [XmlElement("town_areas")]
public  		string
  townAreas { get; set; }


         [XmlElement("success")]
public  		bool
  success { get; set; }


}
}
