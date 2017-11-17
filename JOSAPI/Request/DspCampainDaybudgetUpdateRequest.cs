using System;
using System.Collections.Generic;
using Jd.Api.Response;
using Jd.Api.Util;

namespace Jd.Api.Request
{
public class DspCampainDaybudgetUpdateRequest : IJdRequest<DspCampainDaybudgetUpdateResponse>
{
		                                                                                                                                  
public   		Nullable<long>
   id  { get; set; }

                  
                                                            
                                                          
public   		Nullable<long>
   dayBudget  { get; set; }

                  
                                                            
                                                                                                                                    
		private IDictionary<string, string> otherParameters;

		public string GetApiName()
        {
			return "jingdong.dsp.campain.daybudget.update";
        }

		public IDictionary<string, string> GetParameters()
        {
            JdDictionary parameters = new JdDictionary();
			parameters.Add("id", this.id);
			parameters.Add("dayBudget", this.dayBudget);
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








        
 

