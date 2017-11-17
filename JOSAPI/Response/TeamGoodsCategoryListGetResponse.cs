using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class TeamGoodsCategoryListGetResponse : JdResponse{


         [XmlElement("goods_category_list_for_jos")]
public  		string
  goodsCategoryListForJos { get; set; }


}
}
