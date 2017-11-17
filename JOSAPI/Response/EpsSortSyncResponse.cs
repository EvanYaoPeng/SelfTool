using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class EpsSortSyncResponse : JdResponse{


         [XmlElement("sortsync_result")]
public  		string
  sortsyncResult { get; set; }


}
}
