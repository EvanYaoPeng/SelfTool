using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class VcItemApplyListResponse : JdResponse{


         [XmlElement("searchResult")]
public  		string
  searchResult { get; set; }


}
}
