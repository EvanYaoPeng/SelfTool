using System;
using System.Collections.Generic;
using Jd.Api.Response;
using Jd.Api.Util;

namespace Jd.Api.Request
{
public class IsvAddisvlogRequest : IJdRequest<IsvAddisvlogResponse>
{
		                                                                                                                                  
public   		string
   account  { get; set; }

                  
                                                            
                                                          
public   		string
   clientIp  { get; set; }

                  
                                                            
                                                          
public   		string
   operationTime  { get; set; }

                  
                                                            
                                                          
public   		string
   operationContent  { get; set; }

                  
                                                            
                                                          
public   		string
   useIsvAppkey  { get; set; }

                  
                                                            
                                                          
public   		string
   reqjosUrl  { get; set; }

                  
                                                            
                                                          
public   		string
   touchNumber  { get; set; }

                  
                                                            
                                                          
public   		string
   touchFiles  { get; set; }

                  
                                                            
                                 
		private IDictionary<string, string> otherParameters;

		public string GetApiName()
        {
			return "jingdong.isv.addisvlog";
        }

		public IDictionary<string, string> GetParameters()
        {
            JdDictionary parameters = new JdDictionary();
			parameters.Add("account", this.account);
			parameters.Add("clientIp", this.clientIp);
			parameters.Add("operationTime", this.operationTime);
			parameters.Add("operationContent", this.operationContent);
			parameters.Add("useIsvAppkey", this.useIsvAppkey);
			parameters.Add("reqjosUrl", this.reqjosUrl);
			parameters.Add("touchNumber", this.touchNumber);
			parameters.Add("touchFiles", this.touchFiles);
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








        
 

