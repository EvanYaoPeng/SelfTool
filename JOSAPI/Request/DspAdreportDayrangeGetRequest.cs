using System;
using System.Collections.Generic;
using Jd.Api.Response;
using Jd.Api.Util;

namespace Jd.Api.Request
{
public class DspAdreportDayrangeGetRequest : IJdRequest<DspAdreportDayrangeGetResponse>
{
		                                                                      
public   		string
   dimension  { get; set; }

                  
                                                            
                                                                                                                                                                                                                                                                                                                                                           		public  		string
   id  { get; set; }
                                                                                                                                                                                                
public   		Nullable<int>
   putType  { get; set; }

                  
                                                            
                                                          
public   		Nullable<DateTime>
   startDay  { get; set; }

                  
                                                            
                                                          
public   		Nullable<DateTime>
   endDay  { get; set; }

                  
                                                            
                                                                  
		private IDictionary<string, string> otherParameters;

		public string GetApiName()
        {
			return "jingdong.dsp.adreport.dayrange.get";
        }

		public IDictionary<string, string> GetParameters()
        {
            JdDictionary parameters = new JdDictionary();
			parameters.Add("dimension", this.dimension);
			parameters.Add("id", this.id);
			parameters.Add("putType", this.putType);
			parameters.Add("startDay", this.startDay);
			parameters.Add("endDay", this.endDay);
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








        
 

