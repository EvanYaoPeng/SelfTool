using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class WareBookbigfieldGetResponse : JdResponse{


         [XmlElement("BookBigFieldEntity")]
public  		List<string>
  BookBigFieldEntity { get; set; }


}
}
