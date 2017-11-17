using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class StoreGetPartitionWarehouseTypeResponse : JdResponse{


         [XmlElement("find_Partition_Warehouse_Result")]
public  		string
  findPartitionWarehouseResult { get; set; }


}
}
