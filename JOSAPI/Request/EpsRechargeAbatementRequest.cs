using System;
using System.Collections.Generic;
using Jd.Api.Response;
using Jd.Api.Util;

namespace Jd.Api.Request
{
public class EpsRechargeAbatementRequest : IJdRequest<EpsRechargeAbatementResponse>
{
		                                                                                                                                  
public   		Nullable<int>
   deliveryNo  { get; set; }

                  
                                                            
                                                          
public   		string
   siteNo  { get; set; }

                  
                                                            
                                                                                           
public   		string
   rechargeUUID  { get; set; }

                  
                                                            
                                                          
public   		Nullable<long>
   rechargeNum  { get; set; }

                  
                                                            
                                                          
public   		Nullable<int>
   rechargeType  { get; set; }

                  
                                                            
                                                          
public   		string
   remark  { get; set; }

                  
                                                            
                                                          
public   		string
   operator  { get; set; }

                  
                                                            
                                                          
public   		string
   operateTime  { get; set; }

                  
                                                            
                                 
		private IDictionary<string, string> otherParameters;

		public string GetApiName()
        {
			return "jingdong.eps.rechargeAbatement";
        }

		public IDictionary<string, string> GetParameters()
        {
            JdDictionary parameters = new JdDictionary();
			parameters.Add("deliveryNo", this.deliveryNo);
			parameters.Add("siteNo", this.siteNo);
			parameters.Add("rechargeUUID", this.rechargeUUID);
			parameters.Add("rechargeNum", this.rechargeNum);
			parameters.Add("rechargeType", this.rechargeType);
			parameters.Add("remark", this.remark);
			parameters.Add("operator", this.operator);
			parameters.Add("operateTime", this.operateTime);
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








        
 

