using System;
using System.Xml.Serialization;
using System.Collections.Generic;

												using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class LogisticsPoGetreturnbacodeResponse : JdResponse{


         [XmlElement("inboundNo")]
public  		string
  inboundNo { get; set; }


         [XmlElement("poNo")]
public  		string
  poNo { get; set; }


         [XmlElement("receivingStatus")]
public  		string
  receivingStatus { get; set; }


         [XmlElement("task_details")]
public  		List<string>
  taskDetails { get; set; }


}
}
