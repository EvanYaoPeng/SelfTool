using System;
using System.Xml.Serialization;
using System.Collections.Generic;

										namespace Jd.Api.Response
{





public class ImgzoneCategoryAddResponse : JdResponse{


         [XmlElement("return_code")]
public  		int
  returnCode { get; set; }


         [XmlElement("desc")]
public  		string
  desc { get; set; }


         [XmlElement("cate_id")]
public  		long
  cateId { get; set; }


}
}
