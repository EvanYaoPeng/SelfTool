using System;
using System.Collections.Generic;
using Jd.Api.Response;
using Jd.Api.Util;

namespace Jd.Api.Request
{
public class PopOtoChecknumberinfoGetRequest : IJdRequest<PopOtoChecknumberinfoGetResponse>
{
		                                                                                                       
public   		Nullable<long>
   orderId  { get; set; }

                  
                                                                                                                                    
                                                          
public   		string
   cardNumber  { get; set; }

                  
                                                                                                                                    
                                                          
public   		string
   pwdNumber  { get; set; }

                  
                                                                                                                                    

		private IDictionary<string, string> otherParameters;

		public string GetApiName()
        {
			return "jingdong.pop.oto.checknumberinfo.get";
        }

		public IDictionary<string, string> GetParameters()
        {
            JdDictionary parameters = new JdDictionary();
			parameters.Add("order_id", this.orderId);
			parameters.Add("card_number", this.cardNumber);
			parameters.Add("pwd_number", this.pwdNumber);
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








        
 

