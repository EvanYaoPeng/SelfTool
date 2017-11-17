using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class VenderPrivilegeQueryResponse : JdResponse{


         [XmlElement("vender_privilege_result")]
public  		string
  venderPrivilegeResult { get; set; }


}
}
