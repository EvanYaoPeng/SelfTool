using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class VcItemBrandserviceGetResponse : JdResponse{


         [XmlElement("brand_service")]
public  		string
  brandService { get; set; }


}
}
