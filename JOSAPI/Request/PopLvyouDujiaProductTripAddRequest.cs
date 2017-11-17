using System;
using System.Collections.Generic;
using Jd.Api.Response;
using Jd.Api.Util;

namespace Jd.Api.Request
{
public class PopLvyouDujiaProductTripAddRequest : IJdRequest<PopLvyouDujiaProductTripAddResponse>
{
		                                                                                                                                  
public   		string
   productId  { get; set; }

                  
                                                            
                                                                                           
public   		string
   tripName  { get; set; }

                  
                                                            
                                                          
public   		Nullable<int>
   tripDayNum  { get; set; }

                  
                                                            
                                                          
public   		string
   trafficTypeList  { get; set; }

                  
                                                            
                                                          
public   		string
   trafficOtherDesc  { get; set; }

                  
                                                            
                                                          
public   		string
   trafficDesc  { get; set; }

                  
                                                            
                                                          
public   		string
   breakfastDesc  { get; set; }

                  
                                                            
                                                          
public   		string
   noonDesc  { get; set; }

                  
                                                            
                                                          
public   		string
   dinnerDesc  { get; set; }

                  
                                                            
                                                          
public   		string
   hotelDesc  { get; set; }

                  
                                                            
                                                          
public   		string
   tripDesc  { get; set; }

                  
                                                            
                                 
		private IDictionary<string, string> otherParameters;

		public string GetApiName()
        {
			return "jingdong.pop.lvyou.dujia.product.trip.add";
        }

		public IDictionary<string, string> GetParameters()
        {
            JdDictionary parameters = new JdDictionary();
			parameters.Add("productId", this.productId);
			parameters.Add("tripName", this.tripName);
			parameters.Add("tripDayNum", this.tripDayNum);
			parameters.Add("trafficTypeList", this.trafficTypeList);
			parameters.Add("trafficOtherDesc", this.trafficOtherDesc);
			parameters.Add("trafficDesc", this.trafficDesc);
			parameters.Add("breakfastDesc", this.breakfastDesc);
			parameters.Add("noonDesc", this.noonDesc);
			parameters.Add("dinnerDesc", this.dinnerDesc);
			parameters.Add("hotelDesc", this.hotelDesc);
			parameters.Add("tripDesc", this.tripDesc);
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








        
 

