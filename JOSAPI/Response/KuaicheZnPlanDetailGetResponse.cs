using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class KuaicheZnPlanDetailGetResponse : JdResponse{


         [XmlElement("plan_detail_info")]
public  		string
  planDetailInfo { get; set; }


}
}
