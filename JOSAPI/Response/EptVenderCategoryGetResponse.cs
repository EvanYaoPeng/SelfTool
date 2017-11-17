using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class EptVenderCategoryGetResponse : JdResponse{


         [XmlElement("getvendercategory_result")]
public  		string
  getvendercategoryResult { get; set; }


}
}
