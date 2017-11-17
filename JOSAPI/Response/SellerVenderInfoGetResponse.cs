using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class SellerVenderInfoGetResponse : JdResponse{


         [XmlElement("vender_info_result")]
public  		string
  venderInfoResult { get; set; }


}
}
