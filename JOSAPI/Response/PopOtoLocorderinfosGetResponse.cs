using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class PopOtoLocorderinfosGetResponse : JdResponse{


         [XmlElement("loccodeinfo_result")]
public  		string
  loccodeinfoResult { get; set; }


}
}
