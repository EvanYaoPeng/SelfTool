using System;
using System.Collections.Generic;
using Jd.Api.Response;
using Jd.Api.Util;

namespace Jd.Api.Request
{
public class PopLvyouJingdianProductUpdateRequest : IJdRequest<PopLvyouJingdianProductUpdateResponse>
{
		                                                                                                                                  
public   		string
   supplierProductId  { get; set; }

                  
                                                            
                                                          
public   		string
   productName  { get; set; }

                  
                                                            
                                                          
public   		Nullable<int>
   stockCountType  { get; set; }

                  
                                                            
                                                          
public   		string
   productPriceListJson  { get; set; }

                  
                                                            
                                                          
public   		string
   productDesc  { get; set; }

                  
                                                            
                                                          
public   		Nullable<int>
   beforeReserveMinutes  { get; set; }

                  
                                                            
                                                                                           
public   		Nullable<int>
   refundRuleType  { get; set; }

                  
                                                            
                                                          
public   		Nullable<int>
   changeRuleType  { get; set; }

                  
                                                            
                                                          
public   		string
   refundRuleDesc  { get; set; }

                  
                                                            
                                                          
public   		string
   changeRuleDesc  { get; set; }

                  
                                                            
                                                          
public   		string
   bookingInfo  { get; set; }

                  
                                                            
                                 
		private IDictionary<string, string> otherParameters;

		public string GetApiName()
        {
			return "jingdong.pop.lvyou.jingdian.product.update";
        }

		public IDictionary<string, string> GetParameters()
        {
            JdDictionary parameters = new JdDictionary();
			parameters.Add("supplierProductId", this.supplierProductId);
			parameters.Add("productName", this.productName);
			parameters.Add("stockCountType", this.stockCountType);
			parameters.Add("productPriceListJson", this.productPriceListJson);
			parameters.Add("productDesc", this.productDesc);
			parameters.Add("beforeReserveMinutes", this.beforeReserveMinutes);
			parameters.Add("refundRuleType", this.refundRuleType);
			parameters.Add("changeRuleType", this.changeRuleType);
			parameters.Add("refundRuleDesc", this.refundRuleDesc);
			parameters.Add("changeRuleDesc", this.changeRuleDesc);
			parameters.Add("bookingInfo", this.bookingInfo);
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








        
 

