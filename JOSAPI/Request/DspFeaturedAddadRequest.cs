using System;
using System.Collections.Generic;
using Jd.Api.Response;
using Jd.Api.Util;

namespace Jd.Api.Request
{
public class DspFeaturedAddadRequest : IJdRequest<DspFeaturedAddadResponse>
{
		                                                                                                                                                                   
public   		Nullable<long>
   adGroupId  { get; set; }

                  
                                                            
                                                                                                                                                                                                                                                                                                                                                                                             		public  		string
   name  { get; set; }
                                                                                                                                                                                                                                                                                                                         		public  		string
   url  { get; set; }
                                                                                                                                                                                                                                                                                                                         		public  		string
   imgUrl  { get; set; }
                                                                                                                                                                       
		private IDictionary<string, string> otherParameters;

		public string GetApiName()
        {
			return "jingdong.dsp.featured.addad";
        }

		public IDictionary<string, string> GetParameters()
        {
            JdDictionary parameters = new JdDictionary();
			parameters.Add("adGroupId", this.adGroupId);
			parameters.Add("name", this.name);
			parameters.Add("url", this.url);
			parameters.Add("imgUrl", this.imgUrl);
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








        
 

