using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class ImageReadFindImagesByWareIdResponse : JdResponse{


         [XmlElement("images")]
public  		List<string>
  images { get; set; }


}
}
