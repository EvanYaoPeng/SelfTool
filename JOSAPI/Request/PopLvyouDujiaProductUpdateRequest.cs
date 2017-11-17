using System;
using System.Collections.Generic;
using Jd.Api.Response;
using Jd.Api.Util;

namespace Jd.Api.Request
{
public class PopLvyouDujiaProductUpdateRequest : IJdRequest<PopLvyouDujiaProductUpdateResponse>
{
		                                                                                                                                  
public   		string
   productId  { get; set; }

                  
                                                            
                                                                                           
public   		string
   productName  { get; set; }

                  
                                                            
                                                          
public   		Nullable<int>
   productStatus  { get; set; }

                  
                                                            
                                                          
public   		Nullable<int>
   confirmType  { get; set; }

                  
                                                            
                                                          
public   		string
   departure  { get; set; }

                  
                                                            
                                                          
public   		string
   arrive  { get; set; }

                  
                                                            
                                                          
public   		Nullable<int>
   days  { get; set; }

                  
                                                            
                                                          
public   		Nullable<int>
   categoryOneId  { get; set; }

                  
                                                            
                                                          
public   		Nullable<int>
   categoryTwoId  { get; set; }

                  
                                                            
                                                          
public   		Nullable<int>
   categoryThreeId  { get; set; }

                  
                                                            
                                                          
public   		Nullable<int>
   categoryFourId  { get; set; }

                  
                                                            
                                                                                                                                                                                                                                                                                                                                                           		public  		string
   recommendDesc  { get; set; }
                                                                                                                                                                                                
public   		Nullable<int>
   marketPrice  { get; set; }

                  
                                                            
                                                          
public   		string
   childDesc  { get; set; }

                  
                                                            
                                                          
public   		Nullable<int>
   latestFormDays  { get; set; }

                  
                                                            
                                                          
public   		Nullable<int>
   stockCountType  { get; set; }

                  
                                                            
                                                          
public   		string
   costContain  { get; set; }

                  
                                                            
                                                          
public   		string
   costNoContain  { get; set; }

                  
                                                            
                                                          
public   		string
   reserveRead  { get; set; }

                  
                                                            
                                                          
public   		string
   productDesc  { get; set; }

                  
                                                            
                                                          
public   		string
   productTripDesc  { get; set; }

                  
                                                            
                                                          
public   		string
   selfReturnRule  { get; set; }

                  
                                                            
                                                          
public   		string
   priceListJson  { get; set; }

                  
                                                            
                                                                                                                                                                                                                                                                                                                                                           		public  		string
   deletePriceId  { get; set; }
                                                                                                                                                                       
		private IDictionary<string, string> otherParameters;

		public string GetApiName()
        {
			return "jingdong.pop.lvyou.dujia.product.update";
        }

		public IDictionary<string, string> GetParameters()
        {
            JdDictionary parameters = new JdDictionary();
			parameters.Add("productId", this.productId);
			parameters.Add("productName", this.productName);
			parameters.Add("productStatus", this.productStatus);
			parameters.Add("confirmType", this.confirmType);
			parameters.Add("departure", this.departure);
			parameters.Add("arrive", this.arrive);
			parameters.Add("days", this.days);
			parameters.Add("categoryOneId", this.categoryOneId);
			parameters.Add("categoryTwoId", this.categoryTwoId);
			parameters.Add("categoryThreeId", this.categoryThreeId);
			parameters.Add("categoryFourId", this.categoryFourId);
			parameters.Add("recommendDesc", this.recommendDesc);
			parameters.Add("marketPrice", this.marketPrice);
			parameters.Add("childDesc", this.childDesc);
			parameters.Add("latestFormDays", this.latestFormDays);
			parameters.Add("stockCountType", this.stockCountType);
			parameters.Add("costContain", this.costContain);
			parameters.Add("costNoContain", this.costNoContain);
			parameters.Add("reserveRead", this.reserveRead);
			parameters.Add("productDesc", this.productDesc);
			parameters.Add("productTripDesc", this.productTripDesc);
			parameters.Add("selfReturnRule", this.selfReturnRule);
			parameters.Add("priceListJson", this.priceListJson);
			parameters.Add("deletePriceId", this.deletePriceId);
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








        
 

