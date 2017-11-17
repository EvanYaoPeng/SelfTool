using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class DspKcAdQuerySkuInfoResponse : JdResponse{


         [XmlElement("queryskuinfo_result")]
public  		string
  queryskuinfoResult { get; set; }


}
}
