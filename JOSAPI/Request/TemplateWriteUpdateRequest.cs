using System;
using System.Collections.Generic;
using Jd.Api.Response;
using Jd.Api.Util;

namespace Jd.Api.Request
{
public class TemplateWriteUpdateRequest : IJdRequest<TemplateWriteUpdateResponse>
{
		                                                                                                                                                                                                                                                                                                                                  
public   		string
   bottomContent  { get; set; }

                  
                                                            
                                                          
public   		string
   headContent  { get; set; }

                  
                                                            
                                                          
public   		Nullable<long>
   id  { get; set; }

                  
                                                            
                                                          
public   		string
   name  { get; set; }

                  
                                                            
                                                                  
		private IDictionary<string, string> otherParameters;

		public string GetApiName()
        {
			return "jingdong.template.write.update";
        }

		public IDictionary<string, string> GetParameters()
        {
            JdDictionary parameters = new JdDictionary();
			parameters.Add("bottomContent", this.bottomContent);
			parameters.Add("headContent", this.headContent);
			parameters.Add("id", this.id);
			parameters.Add("name", this.name);
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








        
 

