using System;
using System.Xml.Serialization;
using System.Collections.Generic;

				namespace Jd.Api.Response
{





public class NewWareSameproductskuidsQueryResponse : JdResponse{


         [XmlElement("result")]
public  		List<string>
  result { get; set; }


}
}
