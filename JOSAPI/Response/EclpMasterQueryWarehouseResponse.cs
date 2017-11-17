using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class EclpMasterQueryWarehouseResponse : JdResponse{


         [XmlElement("querywarehouse_result")]
public  		List<string>
  querywarehouseResult { get; set; }


}
}
