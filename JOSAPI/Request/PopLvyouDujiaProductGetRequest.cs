using System;
using System.Collections.Generic;
using Jd.Api.Response;
using Jd.Api.Util;

namespace Jd.Api.Request
{
public class PopLvyouDujiaProductGetRequest : IJdRequest<PopLvyouDujiaProductGetResponse>
{
		                                                                                                                                  
public   		string
   productId  { get; set; }

                  
                                                            
                                                                                           
public   		string
   hasCostContain  { get; set; }

                  
                                                            
                                                          
public   		string
   hasCostNoContain  { get; set; }

                  
                                                            
                                                          
public   		string
   hasReserveRead  { get; set; }

                  
                                                            
                                                          
public   		string
   hasProductDesc  { get; set; }

                  
                                                            
                                                          
public   		string
   hasProductTripDesc  { get; set; }

                  
                                                            
                                                          
public   		string
   hasSelfReturnRule  { get; set; }

                  
                                                            
                                                          
public   		string
   hasPictureUrlList  { get; set; }

                  
                                                            
                                                          
public   		string
   hasPriceList  { get; set; }

                  
                                                            
                                 
		private IDictionary<string, string> otherParameters;

		public string GetApiName()
        {
			return "jingdong.pop.lvyou.dujia.product.get";
        }

		public IDictionary<string, string> GetParameters()
        {
            JdDictionary parameters = new JdDictionary();
			parameters.Add("productId", this.productId);
			parameters.Add("hasCostContain", this.hasCostContain);
			parameters.Add("hasCostNoContain", this.hasCostNoContain);
			parameters.Add("hasReserveRead", this.hasReserveRead);
			parameters.Add("hasProductDesc", this.hasProductDesc);
			parameters.Add("hasProductTripDesc", this.hasProductTripDesc);
			parameters.Add("hasSelfReturnRule", this.hasSelfReturnRule);
			parameters.Add("hasPictureUrlList", this.hasPictureUrlList);
			parameters.Add("hasPriceList", this.hasPriceList);
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








        
 

