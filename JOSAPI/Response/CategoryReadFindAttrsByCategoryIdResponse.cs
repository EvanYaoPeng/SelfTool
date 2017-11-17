using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class CategoryReadFindAttrsByCategoryIdResponse : JdResponse{


         [XmlElement("categoryAttrs")]
public  		List<string>
  categoryAttrs { get; set; }


}
}
