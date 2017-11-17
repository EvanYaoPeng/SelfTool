using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class EclpGoodsQueryGoodsSerialResponse : JdResponse{


         [XmlElement("goodsSerialList")]
public  		List<string>
  goodsSerialList { get; set; }


}
}
