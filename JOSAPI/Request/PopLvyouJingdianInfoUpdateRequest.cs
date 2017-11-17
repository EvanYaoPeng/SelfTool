using System;
using System.Collections.Generic;
using Jd.Api.Response;
using Jd.Api.Util;

namespace Jd.Api.Request
{
public class PopLvyouJingdianInfoUpdateRequest : IJdRequest<PopLvyouJingdianInfoUpdateResponse>
{
		                                                                                                                                                                   
public   		Nullable<long>
   jingdianId  { get; set; }

                  
                                                            
                                                          
public   		string
   jingdianName  { get; set; }

                  
                                                            
                                                          
public   		string
   nameEntireEn  { get; set; }

                  
                                                            
                                                          
public   		string
   nameSimpleEn  { get; set; }

                  
                                                            
                                                          
public   		Nullable<int>
   jingdianSubject  { get; set; }

                  
                                                            
                                                          
public   		Nullable<int>
   jingdianGrade  { get; set; }

                  
                                                            
                                                          
public   		string
   jingdianOpentimeDesc  { get; set; }

                  
                                                            
                                                          
public   		string
   jingdianTelephone  { get; set; }

                  
                                                            
                                                          
public   		Nullable<int>
   jingdianOneCategoryId  { get; set; }

                  
                                                            
                                                          
public   		Nullable<int>
   jingdianTwoCategoryId  { get; set; }

                  
                                                            
                                                          
public   		Nullable<int>
   jingdianThreeCategoryId  { get; set; }

                  
                                                            
                                                          
public   		Nullable<int>
   jingdianFourCategoryId  { get; set; }

                  
                                                            
                                                          
public   		Nullable<int>
   countryId  { get; set; }

                  
                                                            
                                                          
public   		Nullable<int>
   provinceId  { get; set; }

                  
                                                            
                                                          
public   		Nullable<int>
   cityId  { get; set; }

                  
                                                            
                                                          
public   		Nullable<int>
   areaId  { get; set; }

                  
                                                            
                                                          
public   		string
   addressDesc  { get; set; }

                  
                                                            
                                                          
public   		string
   jingdianDesc  { get; set; }

                  
                                                            
                                 
		private IDictionary<string, string> otherParameters;

		public string GetApiName()
        {
			return "jingdong.pop.lvyou.jingdian.info.update";
        }

		public IDictionary<string, string> GetParameters()
        {
            JdDictionary parameters = new JdDictionary();
			parameters.Add("jingdianId", this.jingdianId);
			parameters.Add("jingdianName", this.jingdianName);
			parameters.Add("nameEntireEn", this.nameEntireEn);
			parameters.Add("nameSimpleEn", this.nameSimpleEn);
			parameters.Add("jingdianSubject", this.jingdianSubject);
			parameters.Add("jingdianGrade", this.jingdianGrade);
			parameters.Add("jingdianOpentimeDesc", this.jingdianOpentimeDesc);
			parameters.Add("jingdianTelephone", this.jingdianTelephone);
			parameters.Add("jingdianOneCategoryId", this.jingdianOneCategoryId);
			parameters.Add("jingdianTwoCategoryId", this.jingdianTwoCategoryId);
			parameters.Add("jingdianThreeCategoryId", this.jingdianThreeCategoryId);
			parameters.Add("jingdianFourCategoryId", this.jingdianFourCategoryId);
			parameters.Add("countryId", this.countryId);
			parameters.Add("provinceId", this.provinceId);
			parameters.Add("cityId", this.cityId);
			parameters.Add("areaId", this.areaId);
			parameters.Add("addressDesc", this.addressDesc);
			parameters.Add("jingdianDesc", this.jingdianDesc);
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








        
 

