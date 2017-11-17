using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class DspFeaturedareaQuerycityResponse : JdResponse{


         [XmlElement("querycity_result")]
public  		string
  querycityResult { get; set; }


}
}
