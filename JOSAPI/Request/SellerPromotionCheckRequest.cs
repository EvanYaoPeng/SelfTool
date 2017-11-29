using System;
using System.Collections.Generic;
using Jd.Api.Response;
using Jd.Api.Util;

namespace Jd.Api.Request
{
public class SellerPromotionCheckRequest : IJdRequest<SellerPromotionCheckResponse>
{
		                                                                                                                                  
public   		Nullable<long>
   promoId  { get; set; }

                  
                                                                                                                                    
                                                          
public   		Nullable<int>
   status  { get; set; }

                  
                                                            
                                                                                                   
		private IDictionary<string, string> otherParameters;

		public string GetApiName()
        {
			return "jingdong.seller.promotion.check";
        }

		public IDictionary<string, string> GetParameters()
        {
            JdDictionary parameters = new JdDictionary();
			parameters.Add("promo_id", this.promoId);
			parameters.Add("status", this.status);
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








        
 

