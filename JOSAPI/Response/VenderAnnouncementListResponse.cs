using System;
using System.Xml.Serialization;
using System.Collections.Generic;

						using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class VenderAnnouncementListResponse : JdResponse{


         [XmlElement("total_count")]
public  		int
  totalCount { get; set; }


         [XmlElement("announcement_v_o_s")]
public  		List<string>
  announcementVOS { get; set; }


}
}
