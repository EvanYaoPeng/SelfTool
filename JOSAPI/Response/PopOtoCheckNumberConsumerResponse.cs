using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class PopOtoCheckNumberConsumerResponse : JdResponse{


         [XmlElement("consume_result")]
public  		string
  consumeResult { get; set; }


}
}
