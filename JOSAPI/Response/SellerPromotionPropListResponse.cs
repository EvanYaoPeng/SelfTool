using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class SellerPromotionPropListResponse : JdResponse{


         [XmlElement("promo_prop_v_o_s")]
public  		List<string>
  promoPropVOS { get; set; }


}
}
