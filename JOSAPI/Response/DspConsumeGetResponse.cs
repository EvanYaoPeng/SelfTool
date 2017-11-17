using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class DspConsumeGetResponse : JdResponse{


         [XmlElement("getconsumeinfos_result")]
public  		string
  getconsumeinfosResult { get; set; }


}
}
