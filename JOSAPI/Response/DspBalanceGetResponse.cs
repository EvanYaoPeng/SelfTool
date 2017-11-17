using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class DspBalanceGetResponse : JdResponse{


         [XmlElement("getaccountbalance_result")]
public  		string
  getaccountbalanceResult { get; set; }


}
}
