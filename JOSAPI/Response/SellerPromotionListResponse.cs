using System;
using System.Xml.Serialization;
using System.Collections.Generic;

						using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class SellerPromotionListResponse : JdResponse{


         [XmlElement("total_count")]
public  		int
  totalCount { get; set; }


         [XmlElement("promotion_v_o_s")]
public  		List<string>
  promotionVOS { get; set; }


}
}
