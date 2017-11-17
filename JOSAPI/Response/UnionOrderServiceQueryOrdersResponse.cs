using System;
using System.Xml.Serialization;
using System.Collections.Generic;

				namespace Jd.Api.Response
{





public class UnionOrderServiceQueryOrdersResponse : JdResponse{


         [XmlElement("queryorders_result")]
public  		string
  queryordersResult { get; set; }


}
}
