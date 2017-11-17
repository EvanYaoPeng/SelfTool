using System;
using System.Xml.Serialization;
using System.Collections.Generic;

						using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class SellerPromotionSkuListResponse : JdResponse{


         [XmlElement("total_count")]
public  		int
  totalCount { get; set; }


         [XmlElement("promo_sku_v_o_s")]
public  		List<string>
  promoSkuVOS { get; set; }


}
}
