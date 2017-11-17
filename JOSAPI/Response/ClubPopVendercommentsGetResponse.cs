using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class ClubPopVendercommentsGetResponse : JdResponse{


         [XmlElement("comments")]
public  		List<string>
  comments { get; set; }


         [XmlElement("totalItem")]
public  		string
  totalItem { get; set; }


         [XmlElement("page")]
public  		string
  page { get; set; }


         [XmlElement("resultCode")]
public  		string
  resultCode { get; set; }


         [XmlElement("resultMsg")]
public  		string
  resultMsg { get; set; }


}
}
