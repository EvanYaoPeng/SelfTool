using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class EpsRechargeAbatementResponse : JdResponse{


         [XmlElement("rechargeabatement_result")]
public  		string
  rechargeabatementResult { get; set; }


}
}
