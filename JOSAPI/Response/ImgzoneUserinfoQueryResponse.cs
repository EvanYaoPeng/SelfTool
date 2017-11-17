using System;
using System.Xml.Serialization;
using System.Collections.Generic;

									using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class ImgzoneUserinfoQueryResponse : JdResponse{


         [XmlElement("return_code")]
public  		string
  returnCode { get; set; }


         [XmlElement("desc")]
public  		string
  desc { get; set; }


         [XmlElement("userInfo")]
public  		string
  userInfo { get; set; }


}
}
