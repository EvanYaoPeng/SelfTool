using System;
using System.Collections.Generic;
using Jd.Api.Response;
using Jd.Api.Util;

namespace Jd.Api.Request
{
public class SmartOpenBindDeviceRequest : IJdRequest<SmartOpenBindDeviceResponse>
{
		                                                                      
public   		Nullable<long>
   feedId  { get; set; }

                  
                                                                                                                                    
                                                          
public   		string
   accessKey  { get; set; }

                  
                                                                                                                                    
                                                          
public   		string
   deviceName  { get; set; }

                  
                                                                                                                                    
                                                                                           
public   		string
   privateUserId  { get; set; }

                  
                                                                                                                                                            
                                                                  
		private IDictionary<string, string> otherParameters;

		public string GetApiName()
        {
			return "jingdong.smart.open.bindDevice";
        }

		public IDictionary<string, string> GetParameters()
        {
            JdDictionary parameters = new JdDictionary();
			parameters.Add("feed_id", this.feedId);
			parameters.Add("access_key", this.accessKey);
			parameters.Add("device_name", this.deviceName);
			parameters.Add("private_user_id", this.privateUserId);
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








        
 

