using System;
using System.Collections.Generic;
using Jd.Api.Response;
using Jd.Api.Util;

namespace Jd.Api.Request
{
public class SmartOpenSetDeviceStatusRequest : IJdRequest<SmartOpenSetDeviceStatusResponse>
{
		                                                                      
public   		Nullable<long>
   feedId  { get; set; }

                  
                                                                                                                                    
                                                          
public   		string
   accessKey  { get; set; }

                  
                                                                                                                                    
                                                          
public   		string
   data  { get; set; }

                  
                                                            
                                 
		private IDictionary<string, string> otherParameters;

		public string GetApiName()
        {
			return "jingdong.smart.open.setDeviceStatus";
        }

		public IDictionary<string, string> GetParameters()
        {
            JdDictionary parameters = new JdDictionary();
			parameters.Add("feed_id", this.feedId);
			parameters.Add("access_key", this.accessKey);
			parameters.Add("data", this.data);
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








        
 

