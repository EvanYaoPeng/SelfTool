using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class VcItemApplyGetResponse : JdResponse{


         [XmlElement("apply_info")]
public  		string
  applyInfo { get; set; }


}
}
