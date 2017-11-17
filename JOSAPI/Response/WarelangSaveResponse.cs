using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class WarelangSaveResponse : JdResponse{


         [XmlElement("savewarelang_result")]
public  		string
  savewarelangResult { get; set; }


}
}
