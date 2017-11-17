using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class LogisticsWarehouseListResponse : JdResponse{


         [XmlElement("warehouse_details")]
public  		List<string>
  warehouseDetails { get; set; }


}
}
