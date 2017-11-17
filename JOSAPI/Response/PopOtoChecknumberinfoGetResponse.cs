using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class PopOtoChecknumberinfoGetResponse : JdResponse{


         [XmlElement("cknumber_result")]
public  		string
  cknumberResult { get; set; }


}
}
