using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class TemplateReadFindTemplateByIdResponse : JdResponse{


         [XmlElement("wareTemplate")]
public  		string
  wareTemplate { get; set; }


}
}
