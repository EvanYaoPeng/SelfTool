using System;
using System.Collections.Generic;
using Jd.Api.Response;
using Jd.Api.Util;

namespace Jd.Api.Request
{
public class DspReportQueryDailySumRequest : IJdRequest<DspReportQueryDailySumResponse>
{
		                                                                                                                                  
public   		Nullable<DateTime>
   startDay  { get; set; }

                  
                                                            
                                                          
public   		Nullable<DateTime>
   endDay  { get; set; }

                  
                                                            
                                                          
public   		string
   dimension  { get; set; }

                  
                                                            
                                                                                                                                                                                                                                                                                                                                                            		public  		string
   id  { get; set; }
                                                                                                                                                                                                                                                                                                                         		public  		string
   putType  { get; set; }
                                                                                                                                                                                                                                                                                                                         		public  		string
   platform  { get; set; }
                                                                                                                                                                                                                                         
		private IDictionary<string, string> otherParameters;

		public string GetApiName()
        {
			return "jingdong.dsp.report.queryDailySum";
        }

		public IDictionary<string, string> GetParameters()
        {
            JdDictionary parameters = new JdDictionary();
			parameters.Add("startDay", this.startDay);
			parameters.Add("endDay", this.endDay);
			parameters.Add("dimension", this.dimension);
			parameters.Add("id", this.id);
			parameters.Add("putType", this.putType);
			parameters.Add("platform", this.platform);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
        }

        public void AddOtherParameter(string key, string value)
        {
            if (this.otherParameters == null)
            {
                this.otherParameters = new JdDictionary();
            }
            this.otherParameters.Add(key, value);
        }

}
}








        
 

