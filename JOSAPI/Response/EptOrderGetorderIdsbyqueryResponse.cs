using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class EptOrderGetorderIdsbyqueryResponse : JdResponse{


         [XmlElement("getorderidsbyquery_result")]
public  		string
  getorderidsbyqueryResult { get; set; }


}
}
