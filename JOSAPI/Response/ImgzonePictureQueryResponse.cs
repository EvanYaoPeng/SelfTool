using System;
using System.Xml.Serialization;
using System.Collections.Generic;

												using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class ImgzonePictureQueryResponse : JdResponse{


         [XmlElement("return_code")]
public  		int
  returnCode { get; set; }


         [XmlElement("desc")]
public  		string
  desc { get; set; }


         [XmlElement("total_num")]
public  		int
  totalNum { get; set; }


         [XmlElement("imgList")]
public  		List<string>
  imgList { get; set; }


}
}
