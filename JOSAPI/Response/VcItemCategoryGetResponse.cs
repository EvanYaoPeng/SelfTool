using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class VcItemCategoryGetResponse : JdResponse{


         [XmlElement("category")]
public  		string
  category { get; set; }


}
}
