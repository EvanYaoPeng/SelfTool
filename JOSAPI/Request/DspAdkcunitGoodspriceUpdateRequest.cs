using System;
using System.Collections.Generic;
using Jd.Api.Response;
using Jd.Api.Util;

namespace Jd.Api.Request
{
public class DspAdkcunitGoodspriceUpdateRequest : IJdRequest<DspAdkcunitGoodspriceUpdateResponse>
{
		                                                                      
public   		Nullable<long>
   id  { get; set; }

                  
                                                            
                                                          
public   		Nullable<double>
   inFee  { get; set; }

                  
                                                            
                                                          
public   		Nullable<double>
   searchFee  { get; set; }

                  
                                                            
                                                                                                                            
public   		Nullable<double>
   mobilePriceCoef  { get; set; }

                  
                                                            

		private IDictionary<string, string> otherParameters;

		public string GetApiName()
        {
			return "jingdong.dsp.adkcunit.goodsprice.update";
        }

		public IDictionary<string, string> GetParameters()
        {
            JdDictionary parameters = new JdDictionary();
			parameters.Add("id", this.id);
			parameters.Add("inFee", this.inFee);
			parameters.Add("searchFee", this.searchFee);
			parameters.Add("mobilePriceCoef", this.mobilePriceCoef);
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








        
 

