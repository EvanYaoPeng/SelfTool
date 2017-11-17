using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class VcItemUserBrandsGetResponse : JdResponse{


         [XmlElement("userBrands")]
public  		List<string>
  userBrands { get; set; }


}
}
