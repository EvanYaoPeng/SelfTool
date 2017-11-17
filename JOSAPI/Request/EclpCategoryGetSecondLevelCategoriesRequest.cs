using System;
using System.Collections.Generic;
using Jd.Api.Response;
using Jd.Api.Util;

namespace Jd.Api.Request
{
public class EclpCategoryGetSecondLevelCategoriesRequest : IJdRequest<EclpCategoryGetSecondLevelCategoriesResponse>
{
		                                                                                                                                  
public   		Nullable<long>
   firstCategoryNo  { get; set; }

                  
                                                            
                                                          
public   		Nullable<long>
   secondCategoryNo  { get; set; }

                  
                                                            
                                                                  
		private IDictionary<string, string> otherParameters;

		public string GetApiName()
        {
			return "jingdong.eclp.category.getSecondLevelCategories";
        }

		public IDictionary<string, string> GetParameters()
        {
            JdDictionary parameters = new JdDictionary();
			parameters.Add("firstCategoryNo", this.firstCategoryNo);
			parameters.Add("secondCategoryNo", this.secondCategoryNo);
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








        
 

