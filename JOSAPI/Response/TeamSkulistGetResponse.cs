using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class TeamSkulistGetResponse : JdResponse{


         [XmlElement("sku_list_for_jos")]
public  		string
  skuListForJos { get; set; }


}
}
