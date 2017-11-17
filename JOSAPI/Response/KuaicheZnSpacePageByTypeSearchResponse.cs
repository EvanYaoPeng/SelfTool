using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class KuaicheZnSpacePageByTypeSearchResponse : JdResponse{


         [XmlElement("space_page_info_list")]
public  		List<string>
  spacePageInfoList { get; set; }


}
}
