using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class EptFeightOutapiQueryResponse : JdResponse{


         [XmlElement("querytemplate_result")]
public  		string
  querytemplateResult { get; set; }


}
}
