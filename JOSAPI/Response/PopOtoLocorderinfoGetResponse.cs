using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class PopOtoLocorderinfoGetResponse : JdResponse{


         [XmlElement("loccodeinfo_result")]
public  		string
  loccodeinfoResult { get; set; }


}
}
