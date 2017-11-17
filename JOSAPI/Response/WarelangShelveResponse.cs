using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class WarelangShelveResponse : JdResponse{


         [XmlElement("shelvewarelang_result")]
public  		string
  shelvewarelangResult { get; set; }


}
}
