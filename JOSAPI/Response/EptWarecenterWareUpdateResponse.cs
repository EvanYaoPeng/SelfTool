using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class EptWarecenterWareUpdateResponse : JdResponse{


         [XmlElement("modifyware_result")]
public  		string
  modifywareResult { get; set; }


}
}
