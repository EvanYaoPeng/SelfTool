using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class PoDetailPageGetResponse : JdResponse{


         [XmlElement("detailResultDto")]
public  		string
  detailResultDto { get; set; }


}
}
