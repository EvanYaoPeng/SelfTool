using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class EptWarecenterWarelistGetResponse : JdResponse{


         [XmlElement("querywarelist_result")]
public  		string
  querywarelistResult { get; set; }


}
}
