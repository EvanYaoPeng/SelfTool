using System;
using System.Collections.Generic;
using Jd.Api.Response;
using Jd.Api.Util;

namespace Jd.Api.Request
{
public class AuditCustomerSendWareExportAuditCustomerSendWareRequest : IJdRequest<AuditCustomerSendWareExportAuditCustomerSendWareResponse>
{
		                                                                                                                                                                                                                                                                                                                                                                                                                                   		public  		string
   serviceId  { get; set; }
                                                                                                                                                                                                                                                                                                                        
public   		string
   province  { get; set; }

                  
                                                            
                                                          
public   		string
   city  { get; set; }

                  
                                                            
                                                          
public   		string
   county  { get; set; }

                  
                                                            
                                                          
public   		string
   village  { get; set; }

                  
                                                            
                                                          
public   		string
   detailAddress  { get; set; }

                  
                                                            
                                                                                           
public   		string
   contactsName  { get; set; }

                  
                                                            
                                                          
public   		string
   contactsTel  { get; set; }

                  
                                                            
                                                          
public   		string
   contactsPhone  { get; set; }

                  
                                                            
                                                          
public   		string
   contactsZipCode  { get; set; }

                  
                                                            
                                                                                                                                                                                                                   
public   		string
   province  { get; set; }

                  
                                                            
                                                          
public   		string
   city  { get; set; }

                  
                                                            
                                                          
public   		string
   county  { get; set; }

                  
                                                            
                                                          
public   		string
   village  { get; set; }

                  
                                                            
                                                          
public   		string
   detailAddress  { get; set; }

                  
                                                            
                                                                                           
public   		string
   contactsName  { get; set; }

                  
                                                            
                                                          
public   		string
   contactsTel  { get; set; }

                  
                                                            
                                                          
public   		string
   contactsPhone  { get; set; }

                  
                                                            
                                                          
public   		string
   contactsZipCode  { get; set; }

                  
                                                            
                                                                                                                                                       
public   		string
   operatorPin  { get; set; }

                  
                                                            
                                                          
public   		string
   operatorNick  { get; set; }

                  
                                                            
                                                          
public   		string
   operatorRemark  { get; set; }

                  
                                                            
                                                          
public   		Nullable<DateTime>
   operatorDate  { get; set; }

                  
                                                            
                                                          
public   		string
   platformSrc  { get; set; }

                  
                                                            
                                                                                                                                                       
public   		string
   approveNotes  { get; set; }

                  
                                                            
                                                                                                                            
public   		Nullable<int>
   customizedSmsType  { get; set; }

                  
                                                            
                                                          
public   		string
   platformSrc  { get; set; }

                  
                                                            
                                                                                                                                                                                                                                                                                                                                                                                             		public  		string
   afsApplyDetailId  { get; set; }
                                                                                                                                                                                                                                                                                                                         		public  		string
   wareId  { get; set; }
                                                                                                                                                                                                                                                                                                                         		public  		string
   wareName  { get; set; }
                                                                                                                                                                                                                                                                                                                         		public  		string
   wareDescribe  { get; set; }
                                                                                                                                                                                                                                                                                                                         		public  		string
   wareType  { get; set; }
                                                                                                                                                                                                
public   		Nullable<int>
   afterServiceProvider  { get; set; }

                  
                                                            
                                 
		private IDictionary<string, string> otherParameters;

		public string GetApiName()
        {
			return "jingdong.AuditCustomerSendWareExport.auditCustomerSendWare";
        }

		public IDictionary<string, string> GetParameters()
        {
            JdDictionary parameters = new JdDictionary();
			parameters.Add("serviceId", this.serviceId);
			parameters.Add("province", this.province);
			parameters.Add("city", this.city);
			parameters.Add("county", this.county);
			parameters.Add("village", this.village);
			parameters.Add("detailAddress", this.detailAddress);
			parameters.Add("contactsName", this.contactsName);
			parameters.Add("contactsTel", this.contactsTel);
			parameters.Add("contactsPhone", this.contactsPhone);
			parameters.Add("contactsZipCode", this.contactsZipCode);
			parameters.Add("province", this.province);
			parameters.Add("city", this.city);
			parameters.Add("county", this.county);
			parameters.Add("village", this.village);
			parameters.Add("detailAddress", this.detailAddress);
			parameters.Add("contactsName", this.contactsName);
			parameters.Add("contactsTel", this.contactsTel);
			parameters.Add("contactsPhone", this.contactsPhone);
			parameters.Add("contactsZipCode", this.contactsZipCode);
			parameters.Add("operatorPin", this.operatorPin);
			parameters.Add("operatorNick", this.operatorNick);
			parameters.Add("operatorRemark", this.operatorRemark);
			parameters.Add("operatorDate", this.operatorDate);
			parameters.Add("platformSrc", this.platformSrc);
			parameters.Add("approveNotes", this.approveNotes);
			parameters.Add("customizedSmsType", this.customizedSmsType);
			parameters.Add("platformSrc", this.platformSrc);
			parameters.Add("afsApplyDetailId", this.afsApplyDetailId);
			parameters.Add("wareId", this.wareId);
			parameters.Add("wareName", this.wareName);
			parameters.Add("wareDescribe", this.wareDescribe);
			parameters.Add("wareType", this.wareType);
			parameters.Add("afterServiceProvider", this.afterServiceProvider);
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








        
 

