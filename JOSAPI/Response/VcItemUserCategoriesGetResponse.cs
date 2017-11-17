using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class VcItemUserCategoriesGetResponse : JdResponse{


         [XmlElement("userCategories")]
public  		List<string>
  userCategories { get; set; }


}
}
