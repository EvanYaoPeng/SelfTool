using System;
using System.Xml.Serialization;
using System.Collections.Generic;

													namespace Jd.Api.Response
{





public class LogisticsSkuQueryResponse : JdResponse{


         [XmlElement("process_code")]
public  		string
  processCode { get; set; }


         [XmlElement("process_status")]
public  		string
  processStatus { get; set; }


         [XmlElement("error_message")]
public  		string
  errorMessage { get; set; }


         [XmlElement("result_no")]
public  		string
  resultNo { get; set; }


}
}
