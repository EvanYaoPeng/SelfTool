using System;
using System.Xml.Serialization;
using System.Collections.Generic;

				namespace Jd.Api.Response
{





public class SellerPromotionAddResponse : JdResponse{


         [XmlElement("promo_id")]
public  		long
  promoId { get; set; }


}
}
