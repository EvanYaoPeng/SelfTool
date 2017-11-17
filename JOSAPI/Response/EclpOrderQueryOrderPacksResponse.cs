using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class EclpOrderQueryOrderPacksResponse : JdResponse{


         [XmlElement("queryorderpacks_result")]
public  		List<string>
  queryorderpacksResult { get; set; }


}
}
