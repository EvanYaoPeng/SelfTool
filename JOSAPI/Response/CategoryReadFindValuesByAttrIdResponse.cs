using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class CategoryReadFindValuesByAttrIdResponse : JdResponse{


         [XmlElement("categoryAttrValues")]
public  		List<string>
  categoryAttrValues { get; set; }


}
}
