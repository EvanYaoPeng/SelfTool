using System;
using System.Collections.Generic;
using Jd.Api.Response;
using Jd.Api.Util;

namespace Jd.Api.Request
{
public class LogisticsPdjOrderdeliveryUpdateRequest : IJdRequest<LogisticsPdjOrderdeliveryUpdateResponse>
{
		                                                                                                       
public   		string
   orderId  { get; set; }

                  
                                                            
                                                          
public   		string
   operator  { get; set; }

                  
                                                            
                                                          
public   		string
   carrierNo  { get; set; }

                  
                                                            
                                                          
public   		string
   deliverNo  { get; set; }

                  
                                                            

		private IDictionary<string, string> otherParameters;

		public string GetApiName()
        {
			return "jingdong.logistics.pdj.orderdelivery.update";
        }

		public IDictionary<string, string> GetParameters()
        {
            JdDictionary parameters = new JdDictionary();
			parameters.Add("orderId", this.orderId);
			parameters.Add("operator", this.operator);
			parameters.Add("carrierNo", this.carrierNo);
			parameters.Add("deliverNo", this.deliverNo);
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








        
 

