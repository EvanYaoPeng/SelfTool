using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class SellerPromotionOrdermodeListResponse : JdResponse{


         [XmlElement("promo_order_mode_v_os")]
public  		List<string>
  promoOrderModeVOs { get; set; }


}
}
