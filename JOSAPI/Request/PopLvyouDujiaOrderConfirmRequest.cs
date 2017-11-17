using System;
using System.Collections.Generic;
using Jd.Api.Response;
using Jd.Api.Util;

namespace Jd.Api.Request
{
public class PopLvyouDujiaOrderConfirmRequest : IJdRequest<PopLvyouDujiaOrderConfirmResponse>
{
		                                                                                                                                  
public   		Nullable<int>
   orderId  { get; set; }

                  
                                                            
                                                                                           
public   		Nullable<int>
   confirmType  { get; set; }

                  
                                                            
                                                          
public   		Nullable<int>
   totalFee  { get; set; }

                  
                                                            
                                                          
public   		string
   confirmDesc  { get; set; }

                  
                                                            
                                 
		private IDictionary<string, string> otherParameters;

		public string GetApiName()
        {
			return "jingdong.pop.lvyou.dujia.order.confirm";
        }

		public IDictionary<string, string> GetParameters()
        {
            JdDictionary parameters = new JdDictionary();
			parameters.Add("orderId", this.orderId);
			parameters.Add("confirmType", this.confirmType);
			parameters.Add("totalFee", this.totalFee);
			parameters.Add("confirmDesc", this.confirmDesc);
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








        
 

