using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class ArealimitReadFindAreaLimitsByWareIdResponse : JdResponse{


         [XmlElement("wareAreaLimitList")]
public  		List<string>
  wareAreaLimitList { get; set; }


}
}
