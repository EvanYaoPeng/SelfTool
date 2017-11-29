using System;
using System.Collections.Generic;
using Jd.Api.Response;
using Jd.Api.Util;

namespace Jd.Api.Request
{
public class VcItemPropsFindRequest : IJdRequest<VcItemPropsFindResponse>
{
		                                                                                                       
public   		string
   cid3  { get; set; }

                  
                                                            

		private IDictionary<string, string> otherParameters;

		public string GetApiName()
        {
			return "jingdong.vc.item.props.find";
        }

		public IDictionary<string, string> GetParameters()
        {
            JdDictionary parameters = new JdDictionary();
			parameters.Add("cid3", this.cid3);
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








        
 

