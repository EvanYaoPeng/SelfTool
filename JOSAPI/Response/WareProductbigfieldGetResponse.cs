using System;
using System.Xml.Serialization;
using System.Collections.Generic;

													namespace Jd.Api.Response
{





public class WareProductbigfieldGetResponse : JdResponse{


         [XmlElement("shou_hou")]
public  		string
  shouHou { get; set; }


         [XmlElement("wdis")]
public  		string
  wdis { get; set; }


         [XmlElement("prop_code")]
public  		string
  propCode { get; set; }


         [XmlElement("ware_qd")]
public  		string
  wareQd { get; set; }


}
}
