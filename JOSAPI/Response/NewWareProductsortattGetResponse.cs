using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class NewWareProductsortattGetResponse : JdResponse{


         [XmlElement("resultset")]
public  		List<string>
  resultset { get; set; }


}
}
