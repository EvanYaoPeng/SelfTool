using System;
using System.Collections.Generic;
using Jd.Api.Response;
using Jd.Api.Util;

namespace Jd.Api.Request
{
public class DspConsumeGetRequest : IJdRequest<DspConsumeGetResponse>
{
		                                                                                                                                                                   
public   		Nullable<DateTime>
   beginDate  { get; set; }

                  
                                                            
                                                          
public   		Nullable<DateTime>
   endDate  { get; set; }

                  
                                                            
                                                          
public   		string
   pageOffset  { get; set; }

                  
                                                            
                                                          
public   		string
   type  { get; set; }

                  
                                                            
                                                                  
		private IDictionary<string, string> otherParameters;

		public string GetApiName()
        {
			return "jingdong.dsp.consume.get";
        }

		public IDictionary<string, string> GetParameters()
        {
            JdDictionary parameters = new JdDictionary();
			parameters.Add("beginDate", this.beginDate);
			parameters.Add("endDate", this.endDate);
			parameters.Add("pageOffset", this.pageOffset);
			parameters.Add("type", this.type);
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








        
 

