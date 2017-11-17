using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class WarelangQueryResponse : JdResponse{


         [XmlElement("querywarelang_result")]
public  		string
  querywarelangResult { get; set; }


}
}
