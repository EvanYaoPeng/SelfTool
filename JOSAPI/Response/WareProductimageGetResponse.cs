using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class WareProductimageGetResponse : JdResponse{


         [XmlElement("image_path_list")]
public  		List<string>
  imagePathList { get; set; }


}
}
