using System;
using System.Collections.Generic;
using Jd.Api.Response;
using Jd.Api.Util;

namespace Jd.Api.Request
{
public class SellerPromotionActivitymodeAddRequest : IJdRequest<SellerPromotionActivitymodeAddResponse>
{
		                                                                                                                                  
public   		Nullable<long>
   promoId  { get; set; }

                  
                                                                                                                                    
                                                          
public   		Nullable<int>
   numBound  { get; set; }

                  
                                                                                                                                    
                                                          
public   		Nullable<int>
   freqBound  { get; set; }

                  
                                                                                                                                    
                                                          
public   		Nullable<int>
   perMaxNum  { get; set; }

                  
                                                                                                                                                            
                                                          
public   		Nullable<int>
   perMinNum  { get; set; }

                  
                                                                                                                                                            
                                                                  
		private IDictionary<string, string> otherParameters;

		public string GetApiName()
        {
			return "jingdong.seller.promotion.activitymode.add";
        }

		public IDictionary<string, string> GetParameters()
        {
            JdDictionary parameters = new JdDictionary();
			parameters.Add("promo_id", this.promoId);
			parameters.Add("num_bound", this.numBound);
			parameters.Add("freq_bound", this.freqBound);
			parameters.Add("per_max_num", this.perMaxNum);
			parameters.Add("per_min_num", this.perMinNum);
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








        
 

