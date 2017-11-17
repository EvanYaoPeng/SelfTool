using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class CategoryReadFindValuesByIdResponse : JdResponse{


         [XmlElement("categoryAttrValue")]
public  		string
  categoryAttrValue { get; set; }


}
}
