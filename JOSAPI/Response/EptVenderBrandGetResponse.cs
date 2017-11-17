using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class EptVenderBrandGetResponse : JdResponse{


         [XmlElement("getvenderbrand_result")]
public  		string
  getvenderbrandResult { get; set; }


}
}
