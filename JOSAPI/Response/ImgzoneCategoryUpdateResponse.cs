using System;
using System.Xml.Serialization;
using System.Collections.Generic;

							namespace Jd.Api.Response
{





public class ImgzoneCategoryUpdateResponse : JdResponse{


         [XmlElement("return_code")]
public  		int
  returnCode { get; set; }


         [XmlElement("desc")]
public  		string
  desc { get; set; }


}
}
