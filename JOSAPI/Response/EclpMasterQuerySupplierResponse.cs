using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class EclpMasterQuerySupplierResponse : JdResponse{


         [XmlElement("querysupplier_result")]
public  		List<string>
  querysupplierResult { get; set; }


}
}
