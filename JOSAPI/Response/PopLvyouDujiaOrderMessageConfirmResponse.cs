using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class PopLvyouDujiaOrderMessageConfirmResponse : JdResponse{


         [XmlElement("messageconfirm_result")]
public  		string
  messageconfirmResult { get; set; }


}
}
