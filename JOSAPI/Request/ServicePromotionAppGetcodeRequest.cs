using System;
using System.Collections.Generic;
using Jd.Api.Response;
using Jd.Api.Util;

namespace Jd.Api.Request
{
public class ServicePromotionAppGetcodeRequest : IJdRequest<ServicePromotionAppGetcodeResponse>
{
		                                                                                                                                                                   
public   		string
   jdurl  { get; set; }

                  
                                                            
                                                          
public   		string
   appId  { get; set; }

                  
                                                            
                                                          
public   		string
   subUnionId  { get; set; }

                  
                                                            
                                                          
public   		string
   positionId  { get; set; }

                  
                                                            
                                                          
public   		string
   ext  { get; set; }

                  
                                                            
                                 
		private IDictionary<string, string> otherParameters;

		public string GetApiName()
        {
			return "jingdong.service.promotion.app.getcode";
        }

		public IDictionary<string, string> GetParameters()
        {
            JdDictionary parameters = new JdDictionary();
			parameters.Add("jdurl", this.jdurl);
			parameters.Add("appId", this.appId);
			parameters.Add("subUnionId", this.subUnionId);
			parameters.Add("positionId", this.positionId);
			parameters.Add("ext", this.ext);
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








        
 

