using System;
using System.Collections.Generic;
using Jd.Api.Response;
using Jd.Api.Util;

namespace Jd.Api.Request
{
public class DspAdkcunitAdvanceduserinterestsUpdateRequest : IJdRequest<DspAdkcunitAdvanceduserinterestsUpdateResponse>
{
		                                                                                                                                  
public   		Nullable<int>
   actionCycle  { get; set; }

                  
                                                            
                                                          
public   		Nullable<int>
   actionCycleBuy  { get; set; }

                  
                                                            
                                                          
public   		Nullable<int>
   actionBrowse  { get; set; }

                  
                                                            
                                                          
public   		Nullable<int>
   actionBuy  { get; set; }

                  
                                                            
                                                                                           
public   		Nullable<int>
   priceBegin  { get; set; }

                  
                                                            
                                                          
public   		Nullable<int>
   priceEnd  { get; set; }

                  
                                                            
                                                          
public   		Nullable<long>
   adGroupId  { get; set; }

                  
                                                            
                                                                  
		private IDictionary<string, string> otherParameters;

		public string GetApiName()
        {
			return "jingdong.dsp.adkcunit.advanceduserinterests.update";
        }

		public IDictionary<string, string> GetParameters()
        {
            JdDictionary parameters = new JdDictionary();
			parameters.Add("actionCycle", this.actionCycle);
			parameters.Add("actionCycleBuy", this.actionCycleBuy);
			parameters.Add("actionBrowse", this.actionBrowse);
			parameters.Add("actionBuy", this.actionBuy);
			parameters.Add("priceBegin", this.priceBegin);
			parameters.Add("priceEnd", this.priceEnd);
			parameters.Add("adGroupId", this.adGroupId);
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








        
 

