using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class AfsserviceCustomerfeedbackTransferResponse : JdResponse{


         [XmlElement("customerFeedbackTransferResult")]
public  		string
  customerFeedbackTransferResult { get; set; }


}
}
