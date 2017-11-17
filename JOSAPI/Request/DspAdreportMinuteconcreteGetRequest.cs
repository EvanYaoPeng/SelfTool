using System;
using System.Collections.Generic;
using Jd.Api.Response;
using Jd.Api.Util;

namespace Jd.Api.Request
{
public class DspAdreportMinuteconcreteGetRequest : IJdRequest<DspAdreportMinuteconcreteGetResponse>
{
		                                                                      
public   		string
   dimension  { get; set; }

                  
                                                            
                                                          
public   		Nullable<long>
   id  { get; set; }

                  
                                                            
                                                          
public   		Nullable<int>
   putType  { get; set; }

                  
                                                            
                                                          
public   		Nullable<int>
   startMinute  { get; set; }

                  
                                                            
                                                          
public   		Nullable<int>
   endMinute  { get; set; }

                  
                                                            
                                                          
public   		Nullable<DateTime>
   day  { get; set; }

                  
                                                            
                                                                  
		private IDictionary<string, string> otherParameters;

		public string GetApiName()
        {
			return "jingdong.dsp.adreport.minuteconcrete.get";
        }

		public IDictionary<string, string> GetParameters()
        {
            JdDictionary parameters = new JdDictionary();
			parameters.Add("dimension", this.dimension);
			parameters.Add("id", this.id);
			parameters.Add("putType", this.putType);
			parameters.Add("startMinute", this.startMinute);
			parameters.Add("endMinute", this.endMinute);
			parameters.Add("day", this.day);
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








        
 

