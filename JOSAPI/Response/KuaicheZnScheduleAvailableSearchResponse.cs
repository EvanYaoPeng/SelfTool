using System;
using System.Xml.Serialization;
using System.Collections.Generic;

				namespace Jd.Api.Response
{





public class KuaicheZnScheduleAvailableSearchResponse : JdResponse{


         [XmlElement("schedule_day_list")]
public  		int
  scheduleDayList { get; set; }


}
}
