using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class EclpGoodsQueryGoodsInfoResponse : JdResponse{


         [XmlElement("goodsInfoList")]
public  		List<string>
  goodsInfoList { get; set; }


}
}
