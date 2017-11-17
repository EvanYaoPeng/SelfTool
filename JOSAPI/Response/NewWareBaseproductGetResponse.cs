using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class NewWareBaseproductGetResponse : JdResponse{


         [XmlElement("listproductbase_result")]
public  		List<string>
  listproductbaseResult { get; set; }


}
}
