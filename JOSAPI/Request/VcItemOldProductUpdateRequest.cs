using System;
using System.Collections.Generic;
using Jd.Api.Response;
using Jd.Api.Util;

namespace Jd.Api.Request
{
public class VcItemOldProductUpdateRequest : IJdRequest<VcItemOldProductUpdateResponse>
{
		                                                                                                       
public   		string
   applyId  { get; set; }

                  
                                                                                                                                    
                                                                                                                                                       
public   		string
   wareId  { get; set; }

                  
                                                                                                                                    
                                                          
public   		Nullable<int>
   brandId  { get; set; }

                  
                                                                                                                                    
                                                          
public   		string
   zhBrand  { get; set; }

                  
                                                                                                                                    
                                                          
public   		string
   enBrand  { get; set; }

                  
                                                                                                                                    
                                                          
public   		string
   tel  { get; set; }

                  
                                                            
                                                          
public   		string
   webSite  { get; set; }

                  
                                                                                                                                    
                                                          
public   		string
   originalPlace  { get; set; }

                  
                                                                                                                                    
                                                          
public   		string
   warranty  { get; set; }

                  
                                                            
                                                          
public   		string
   weight  { get; set; }

                  
                                                            
                                                          
public   		Nullable<int>
   length  { get; set; }

                  
                                                            
                                                          
public   		Nullable<int>
   width  { get; set; }

                  
                                                            
                                                          
public   		Nullable<int>
   height  { get; set; }

                  
                                                            
                                                          
public   		string
   salerCode  { get; set; }

                  
                                                                                                                                    
                                                          
public   		string
   purchaserCode  { get; set; }

                  
                                                                                                                                    
                                                          
public   		string
   pkgInfo  { get; set; }

                  
                                                                                                                                    
                                                          
public   		string
   itemNum  { get; set; }

                  
                                                                                                                                    
                                                          
public   		string
   introHtml  { get; set; }

                  
                                                                                                                                    
                                                          
public   		string
   introMobile  { get; set; }

                  
                                                                                                                                    
                                                          
public   		Nullable<long>
   videoId  { get; set; }

                  
                                                                                                                                    
                                                                                                                                                       
public   		string
   wreadme  { get; set; }

                  
                                                            
                                                                                                                                                                                                                                                                                                                                                            		public  		string
   pid  { get; set; }
                                                                                                                                                                                                                                                                                                                         		public  		string
   vid  { get; set; }
                                                                                                                                                                                                                                                                                                                         		public  		string
   remark  { get; set; }
                                                                                                                                                                                                                                                                                                                         		public  		string
   vname  { get; set; }
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           		public  		string
   attId  { get; set; }
                                                                                                                                                                                                                                                                                                                         		public  		string
   values  { get; set; }
                                                                                                                                      
		private IDictionary<string, string> otherParameters;

		public string GetApiName()
        {
			return "jingdong.vc.item.oldProduct.update";
        }

		public IDictionary<string, string> GetParameters()
        {
            JdDictionary parameters = new JdDictionary();
			parameters.Add("apply_id", this.applyId);
			parameters.Add("ware_id", this.wareId);
			parameters.Add("brand_id", this.brandId);
			parameters.Add("zh_brand", this.zhBrand);
			parameters.Add("en_brand", this.enBrand);
			parameters.Add("tel", this.tel);
			parameters.Add("web_site", this.webSite);
			parameters.Add("original_place", this.originalPlace);
			parameters.Add("warranty", this.warranty);
			parameters.Add("weight", this.weight);
			parameters.Add("length", this.length);
			parameters.Add("width", this.width);
			parameters.Add("height", this.height);
			parameters.Add("saler_code", this.salerCode);
			parameters.Add("purchaser_code", this.purchaserCode);
			parameters.Add("pkg_info", this.pkgInfo);
			parameters.Add("item_num", this.itemNum);
			parameters.Add("intro_html", this.introHtml);
			parameters.Add("intro_mobile", this.introMobile);
			parameters.Add("video_id", this.videoId);
			parameters.Add("wreadme", this.wreadme);
			parameters.Add("pid", this.pid);
			parameters.Add("vid", this.vid);
			parameters.Add("remark", this.remark);
			parameters.Add("vname", this.vname);
			parameters.Add("att_id", this.attId);
			parameters.Add("values", this.values);
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








        
 

