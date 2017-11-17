using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class KuaicheZnPlanListSearchResponse : JdResponse{


         [XmlElement("plan_list_info")]
public  		string
  planListInfo { get; set; }


}
}
