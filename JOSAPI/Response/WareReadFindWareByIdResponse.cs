using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class WareReadFindWareByIdResponse : JdResponse{


         [XmlElement("ware")]
public  		string
  ware { get; set; }


}
}
