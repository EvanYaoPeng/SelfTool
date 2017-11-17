using System;
using System.Collections.Generic;
using Jd.Api.Response;
using Jd.Api.Util;

namespace Jd.Api.Request
{
public class PopAfterSaleGetWaitOrderSumRequest : IJdRequest<PopAfterSaleGetWaitOrderSumResponse>
{
		                                             
		private IDictionary<string, string> otherParameters;

		public string GetApiName()
        {
			return "jingdong.pop.afterSale.getWaitOrderSum";
        }

		public IDictionary<string, string> GetParameters()
        {
            JdDictionary parameters = new JdDictionary();
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








        
 

