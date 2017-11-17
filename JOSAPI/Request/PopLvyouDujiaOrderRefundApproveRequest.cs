using System;
using System.Collections.Generic;
using Jd.Api.Response;
using Jd.Api.Util;

namespace Jd.Api.Request
{
public class PopLvyouDujiaOrderRefundApproveRequest : IJdRequest<PopLvyouDujiaOrderRefundApproveResponse>
{
		                                                                                                                                  
public   		Nullable<int>
   refundId  { get; set; }

                  
                                                            
                                                                                           
public   		Nullable<bool>
   approveFlag  { get; set; }

                  
                                                            
                                                          
public   		Nullable<int>
   refundValue  { get; set; }

                  
                                                            
                                                          
public   		string
   approveDesc  { get; set; }

                  
                                                            
                                 
		private IDictionary<string, string> otherParameters;

		public string GetApiName()
        {
			return "jingdong.pop.lvyou.dujia.order.refund.approve";
        }

		public IDictionary<string, string> GetParameters()
        {
            JdDictionary parameters = new JdDictionary();
			parameters.Add("refundId", this.refundId);
			parameters.Add("approveFlag", this.approveFlag);
			parameters.Add("refundValue", this.refundValue);
			parameters.Add("approveDesc", this.approveDesc);
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








        
 

