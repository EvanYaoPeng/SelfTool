using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class EpsSiteSyncResponse : JdResponse{


         [XmlElement("sitesync_result")]
public  		string
  sitesyncResult { get; set; }


}
}
