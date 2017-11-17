using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class EclpOrderQueryOrderStatusResponse : JdResponse{


         [XmlElement("queryorderstatus_result")]
public  		string
  queryorderstatusResult { get; set; }


}
}
