using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class EptWarecenterWareGetResponse : JdResponse{


         [XmlElement("getwareinfobyid_result")]
public  		string
  getwareinfobyidResult { get; set; }


}
}
