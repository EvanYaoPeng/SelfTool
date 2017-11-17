using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class SellerPromotionGetResponse : JdResponse{


         [XmlElement("promotion_v_o")]
public  		string
  promotionVO { get; set; }


}
}
