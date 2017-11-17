using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class WareBasebookGetResponse : JdResponse{


         [XmlElement("BookEntity")]
public  		List<string>
  BookEntity { get; set; }


}
}
