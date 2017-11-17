using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class KuaicheZnMaterialLabelsSearchResponse : JdResponse{


         [XmlElement("material_label_list")]
public  		List<string>
  materialLabelList { get; set; }


}
}
