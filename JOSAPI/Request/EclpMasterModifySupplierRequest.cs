using System;
using System.Collections.Generic;
using Jd.Api.Response;
using Jd.Api.Util;

namespace Jd.Api.Request
{
public class EclpMasterModifySupplierRequest : IJdRequest<EclpMasterModifySupplierResponse>
{
		                                                                                                                                  
public   		string
   eclpSupplierNo  { get; set; }

                  
                                                            
                                                          
public   		string
   supplierName  { get; set; }

                  
                                                            
                                                          
public   		string
   status  { get; set; }

                  
                                                            
                                                          
public   		string
   contacts  { get; set; }

                  
                                                            
                                                          
public   		string
   phone  { get; set; }

                  
                                                            
                                                          
public   		string
   fax  { get; set; }

                  
                                                            
                                                          
public   		string
   email  { get; set; }

                  
                                                            
                                                          
public   		string
   province  { get; set; }

                  
                                                            
                                                          
public   		string
   city  { get; set; }

                  
                                                            
                                                          
public   		string
   county  { get; set; }

                  
                                                            
                                                          
public   		string
   town  { get; set; }

                  
                                                            
                                                          
public   		string
   address  { get; set; }

                  
                                                            
                                                          
public   		string
   ext1  { get; set; }

                  
                                                            
                                                          
public   		string
   ext2  { get; set; }

                  
                                                            
                                                          
public   		string
   ext3  { get; set; }

                  
                                                            
                                                          
public   		string
   ext4  { get; set; }

                  
                                                            
                                                          
public   		string
   ext5  { get; set; }

                  
                                                            
                                                                  
		private IDictionary<string, string> otherParameters;

		public string GetApiName()
        {
			return "jingdong.eclp.master.modifySupplier";
        }

		public IDictionary<string, string> GetParameters()
        {
            JdDictionary parameters = new JdDictionary();
			parameters.Add("eclpSupplierNo", this.eclpSupplierNo);
			parameters.Add("supplierName", this.supplierName);
			parameters.Add("status", this.status);
			parameters.Add("contacts", this.contacts);
			parameters.Add("phone", this.phone);
			parameters.Add("fax", this.fax);
			parameters.Add("email", this.email);
			parameters.Add("province", this.province);
			parameters.Add("city", this.city);
			parameters.Add("county", this.county);
			parameters.Add("town", this.town);
			parameters.Add("address", this.address);
			parameters.Add("ext1", this.ext1);
			parameters.Add("ext2", this.ext2);
			parameters.Add("ext3", this.ext3);
			parameters.Add("ext4", this.ext4);
			parameters.Add("ext5", this.ext5);
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








        
 

