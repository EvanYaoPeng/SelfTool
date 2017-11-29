using System;
using System.Xml.Serialization;
using System.Collections.Generic;

																								using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class LogisticsOtherOutstoreQueryreturnbarcodeResponse : JdResponse{


         [XmlElement("process_code")]
public  		string
  processCode { get; set; }


         [XmlElement("process_status")]
public  		string
  processStatus { get; set; }


         [XmlElement("error_message")]
public  		string
  errorMessage { get; set; }


         [XmlElement("josl_outbound_no")]
public  		string
  joslOutboundNo { get; set; }


         [XmlElement("isv_outbound_no")]
public  		string
  isvOutboundNo { get; set; }


         [XmlElement("josl_status")]
public  		string
  joslStatus { get; set; }


         [XmlElement("complete_time")]
public  		DateTime
  completeTime { get; set; }


         [XmlElement("order_details")]
public  		List<string>
  orderDetails { get; set; }


         [XmlElement("carriers_id")]
public  		string
  carriersId { get; set; }


         [XmlElement("carriers_name")]
public  		string
  carriersName { get; set; }


         [XmlElement("delivery_no_list")]
public  		List<string>
  deliveryNoList { get; set; }


}
}
