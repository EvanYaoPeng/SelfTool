using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class VcItemListResponse : JdResponse{


         [XmlElement("search_result")]
public  		string
  searchResult { get; set; }


}
}
