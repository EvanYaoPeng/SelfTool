using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class DropshipDpsPrerefundResponse : JdResponse{


         [XmlElement("prerefundResult")]
public  		string
  prerefundResult { get; set; }


}
}
