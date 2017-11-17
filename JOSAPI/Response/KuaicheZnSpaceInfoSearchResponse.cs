using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class KuaicheZnSpaceInfoSearchResponse : JdResponse{


         [XmlElement("space_info_list")]
public  		List<string>
  spaceInfoList { get; set; }


}
}
