using System;
using System.Collections.Generic;
using Jd.Api.Response;
using Jd.Api.Util;

namespace Jd.Api.Request
{
public class LogisticsPdjOrdercancelUpdateRequest : IJdRequest<LogisticsPdjOrdercancelUpdateResponse>
{
		                                                                                                       
public   		string
   orderId  { get; set; }

                  
                                                            
                                                          
public   		string
   operator  { get; set; }

                  
                                                            
                                                          
public   		string
   orderCancelRemark  { get; set; }

                  
                                                            

		private IDictionary<string, string> otherParameters;

		public string GetApiName()
        {
			return "jingdong.logistics.pdj.ordercancel.update";
        }

		public IDictionary<string, string> GetParameters()
        {
            JdDictionary parameters = new JdDictionary();
			parameters.Add("orderId", this.orderId);
			parameters.Add("operator", this.operator);
			parameters.Add("orderCancelRemark", this.orderCancelRemark);
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








        
 

