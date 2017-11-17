using System;
using System.Collections.Generic;
using Jd.Api.Response;
using Jd.Api.Util;

namespace Jd.Api.Request
{
public class AirplaneServiceApiJosJosBookFlightRequest : IJdRequest<AirplaneServiceApiJosJosBookFlightResponse>
{
		                                                                                                                                                                                              
public   		string
   orderPrice  { get; set; }

                  
                                                            
                                                          
public   		string
   userId  { get; set; }

                  
                                                            
                                                          
public   		string
   customerName  { get; set; }

                  
                                                            
                                                          
public   		string
   mobile  { get; set; }

                  
                                                            
                                                          
public   		string
   email  { get; set; }

                  
                                                            
                                                          
public   		string
   userLevel  { get; set; }

                  
                                                            
                                                          
public   		string
   clientIpAddress  { get; set; }

                  
                                                            
                                                          
public   		string
   venderId  { get; set; }

                  
                                                            
                                                          
public   		string
   venderName  { get; set; }

                  
                                                            
                                                                                           
public   		string
   isSafe  { get; set; }

                  
                                                            
                                                                                                                                                                                                                                                                                                                                                            		public  		string
   tripType  { get; set; }
                                                                                                                                                                                                                                                                                                                         		public  		string
   departure  { get; set; }
                                                                                                                                                                                                                                                                                                                         		public  		string
   arrival  { get; set; }
                                                                                                                                                                                                                                                                                                                         		public  		string
   depdate  { get; set; }
                                                                                                                                                                                                                                                                                                                         		public  		string
   arrdate  { get; set; }
                                                                                                                                                                                                                                                                                                                         		public  		string
   deptime  { get; set; }
                                                                                                                                                                                                                                                                                                                         		public  		string
   arrtime  { get; set; }
                                                                                                                                                                                                                                                                                                                         		public  		string
   seatcode  { get; set; }
                                                                                                                                                                                                                                                                                                                         		public  		string
   airways  { get; set; }
                                                                                                                                                                                                                                                                                                                         		public  		string
   flightNo  { get; set; }
                                                                                                                                                                                                                                                                                                                         		public  		string
   price  { get; set; }
                                                                                                                                                                                                                                                                                                                         		public  		string
   oiltax  { get; set; }
                                                                                                                                                                                                                                                                                                                         		public  		string
   buildfee  { get; set; }
                                                                                                                                                                                                                                                                                                                         		public  		string
   fareitemid  { get; set; }
                                                                                                                                                                                                                                                                                                                         		public  		string
   fullPrice  { get; set; }
                                                                                                                                                                                                                                                                                                                         		public  		string
   childOilTax  { get; set; }
                                                                                                                                                                                                                                                                                                                         		public  		string
   iOilTax  { get; set; }
                                                                                                                                                                                                                                                                                                                         		public  		string
   commisionPoint  { get; set; }
                                                                                                                                                                                                                                                                                                                         		public  		string
   policyId  { get; set; }
                                                                                                                                                                                                                                                                                                                         		public  		string
   venderPrice  { get; set; }
                                                                                                                                                                                                                                                                                                                         		public  		string
   childVenderPrice  { get; set; }
                                                                                                                                                                                                                                                                                                                         		public  		string
   childSalePrice  { get; set; }
                                                                                                                                                                                                                                                                                                                         		public  		string
   depCityCode  { get; set; }
                                                                                                                                                                                                                                                                                                                         		public  		string
   arrCityCode  { get; set; }
                                                                                                                                                                                                                                                                                                                         		public  		string
   depCityName  { get; set; }
                                                                                                                                                                                                                                                                                                                         		public  		string
   arrCityName  { get; set; }
                                                                                                                                                                                                                                                                                                                         		public  		string
   airwaysCn  { get; set; }
                                                                                                                                                                                                                                                                                                                         		public  		Nullable<long>
   isStop  { get; set; }
                                                                                                                                                                                                                                                                                                                         		public  		string
   stopCity  { get; set; }
                                                                                                                                                                                                                                                                                                                         		public  		string
   depairdrome  { get; set; }
                                                                                                                                                                                                                                                                                                                         		public  		string
   arrairdrome  { get; set; }
                                                                                                                                                                                                                                                                                                                         		public  		string
   discount  { get; set; }
                                                                                                                                                                                                                                                                                                                         		public  		string
   depTerminal  { get; set; }
                                                                                                                                                                                                                                                                                                                         		public  		string
   arrTerminal  { get; set; }
                                                                                                                                                                                                                                                                                                                         		public  		Nullable<long>
   total  { get; set; }
                                                                                                                                                                                                                                                                                                                         		public  		string
   ticketChange  { get; set; }
                                                                                                                                                                                                                                                                                                                         		public  		string
   ticketTurn  { get; set; }
                                                                                                                                                                                                                                                                                                                         		public  		string
   ticketBack  { get; set; }
                                                                                                                                                                                                                                                                                                                         		public  		string
   promotionId  { get; set; }
                                                                                                                                                                                                                                                                                                                         		public  		string
   originalPrice  { get; set; }
                                                                                                                                                                                                                                                                                                                         		public  		string
   discountId  { get; set; }
                                                                                                                                                                                                                                                                                                                         		public  		string
   saleDiscountType  { get; set; }
                                                                                                                                                                                                                                                                                                                         		public  		string
   productCode  { get; set; }
                                                                                                                                                                                                                                                                                                                         		public  		string
   beforeDiscount  { get; set; }
                                                                                                                                                                                                                                                                                                                         		public  		string
   afterDiscount  { get; set; }
                                                                                                                                                                                                                                                                                                                         		public  		string
   childSeatCode  { get; set; }
                                                                                                                                                                                                                                                                                                                         		public  		string
   childDiscount  { get; set; }
                                                                                                                                                                                                                                                                                                                         		public  		string
   flightinfo  { get; set; }
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  		public  		string
   certtype  { get; set; }
                                                                                                                                                                                                                                                                                                                         		public  		string
   certid  { get; set; }
                                                                                                                                                                                                                                                                                                                         		public  		string
   psgname  { get; set; }
                                                                                                                                                                                                                                                                                                                         		public  		string
   psgsex  { get; set; }
                                                                                                                                                                                                                                                                                                                         		public  		string
   psgtype  { get; set; }
                                                                                                                                                                                                                                                                                                                         		public  		string
   psgbirthdate  { get; set; }
                                                                                                                                                                                                                                                                                                                         		public  		string
   mobileNo  { get; set; }
                                                                                                                                                                                                                                                                                                                         		public  		string
   insureType  { get; set; }
                                                                                                                                                                                                                                                                                                                         		public  		string
   insurecount  { get; set; }
                                                                                                                                                                                                                                                                                                                         		public  		Nullable<double>
   ticketPrice  { get; set; }
                                                                                                                                                                                                                                                                                                                         		public  		Nullable<double>
   tax  { get; set; }
                                                                                                                                                                                                                                                                                                    
public   		string
   name  { get; set; }

                  
                                                            
                                                          
public   		string
   mobile  { get; set; }

                  
                                                            
                                                          
public   		string
   tele  { get; set; }

                  
                                                            
                                                          
public   		string
   email  { get; set; }

                  
                                                            
                                                          
public   		string
   fax  { get; set; }

                  
                                                            
                                                                                                                                                       
public   		string
   dispatchId  { get; set; }

                  
                                                            
                                                          
public   		string
   deliverytype  { get; set; }

                  
                                                            
                                                          
public   		string
   name  { get; set; }

                  
                                                            
                                                          
public   		string
   mobile  { get; set; }

                  
                                                            
                                                          
public   		string
   tele  { get; set; }

                  
                                                            
                                                          
public   		string
   email  { get; set; }

                  
                                                            
                                                          
public   		string
   fax  { get; set; }

                  
                                                            
                                                          
public   		string
   province  { get; set; }

                  
                                                            
                                                          
public   		string
   city  { get; set; }

                  
                                                            
                                                          
public   		string
   district  { get; set; }

                  
                                                            
                                                          
public   		string
   address  { get; set; }

                  
                                                            
                                                          
public   		string
   postcode  { get; set; }

                  
                                                            
                                                          
public   		string
   bookdelivdate  { get; set; }

                  
                                                            
                                                          
public   		string
   bookdelivtime  { get; set; }

                  
                                                            
                                                          
public   		string
   needinvoice  { get; set; }

                  
                                                            
                                                          
public   		Nullable<long>
   travelSkyId  { get; set; }

                  
                                                            
                                                          
public   		string
   insurInvoice  { get; set; }

                  
                                                            
                                                                                                                                                       
public   		string
   onlineMoney  { get; set; }

                  
                                                            
                                                          
public   		string
   isCouponJing  { get; set; }

                  
                                                            
                                                          
public   		string
   isCouponDong  { get; set; }

                  
                                                            
                                                          
public   		string
   couponJingIds  { get; set; }

                  
                                                            
                                                          
public   		string
   couponDongIds  { get; set; }

                  
                                                            
                                                          
public   		string
   couponJingMoney  { get; set; }

                  
                                                            
                                                          
public   		string
   couponDongMoney  { get; set; }

                  
                                                            
                                                          
public   		string
   balanceMoney  { get; set; }

                  
                                                            
                                                          
public   		string
   isBalance  { get; set; }

                  
                                                            
                                                          
public   		string
   paymentPassword  { get; set; }

                  
                                                            
                                                                                           
public   		string
   sourceId  { get; set; }

                  
                                                            
                                                          
public   		string
   sourceType  { get; set; }

                  
                                                            
                                                          
public   		string
   userName  { get; set; }

                  
                                                            
                                                          
public   		string
   ipAddress  { get; set; }

                  
                                                            
                                                          
public   		Nullable<double>
   orderPrice  { get; set; }

                  
                                                            
                                                          
public   		string
   orderCd  { get; set; }

                  
                                                            
                                                          
public   		string
   uuid  { get; set; }

                  
                                                            
                                                          
public   		string
   payType  { get; set; }

                  
                                                            
                                                          
public   		string
   paymentPassword  { get; set; }

                  
                                                            
                                 
		private IDictionary<string, string> otherParameters;

		public string GetApiName()
        {
			return "jingdong.airplane.service.api.jos.JosBookFlight";
        }

		public IDictionary<string, string> GetParameters()
        {
            JdDictionary parameters = new JdDictionary();
			parameters.Add("orderPrice", this.orderPrice);
			parameters.Add("userId", this.userId);
			parameters.Add("customerName", this.customerName);
			parameters.Add("mobile", this.mobile);
			parameters.Add("email", this.email);
			parameters.Add("userLevel", this.userLevel);
			parameters.Add("clientIpAddress", this.clientIpAddress);
			parameters.Add("venderId", this.venderId);
			parameters.Add("venderName", this.venderName);
			parameters.Add("isSafe", this.isSafe);
			parameters.Add("tripType", this.tripType);
			parameters.Add("departure", this.departure);
			parameters.Add("arrival", this.arrival);
			parameters.Add("depdate", this.depdate);
			parameters.Add("arrdate", this.arrdate);
			parameters.Add("deptime", this.deptime);
			parameters.Add("arrtime", this.arrtime);
			parameters.Add("seatcode", this.seatcode);
			parameters.Add("airways", this.airways);
			parameters.Add("flightNo", this.flightNo);
			parameters.Add("price", this.price);
			parameters.Add("oiltax", this.oiltax);
			parameters.Add("buildfee", this.buildfee);
			parameters.Add("fareitemid", this.fareitemid);
			parameters.Add("fullPrice", this.fullPrice);
			parameters.Add("childOilTax", this.childOilTax);
			parameters.Add("iOilTax", this.iOilTax);
			parameters.Add("commisionPoint", this.commisionPoint);
			parameters.Add("policyId", this.policyId);
			parameters.Add("venderPrice", this.venderPrice);
			parameters.Add("childVenderPrice", this.childVenderPrice);
			parameters.Add("childSalePrice", this.childSalePrice);
			parameters.Add("depCityCode", this.depCityCode);
			parameters.Add("arrCityCode", this.arrCityCode);
			parameters.Add("depCityName", this.depCityName);
			parameters.Add("arrCityName", this.arrCityName);
			parameters.Add("airwaysCn", this.airwaysCn);
			parameters.Add("isStop", this.isStop);
			parameters.Add("stopCity", this.stopCity);
			parameters.Add("depairdrome", this.depairdrome);
			parameters.Add("arrairdrome", this.arrairdrome);
			parameters.Add("discount", this.discount);
			parameters.Add("depTerminal", this.depTerminal);
			parameters.Add("arrTerminal", this.arrTerminal);
			parameters.Add("total", this.total);
			parameters.Add("ticketChange", this.ticketChange);
			parameters.Add("ticketTurn", this.ticketTurn);
			parameters.Add("ticketBack", this.ticketBack);
			parameters.Add("promotionId", this.promotionId);
			parameters.Add("originalPrice", this.originalPrice);
			parameters.Add("discountId", this.discountId);
			parameters.Add("saleDiscountType", this.saleDiscountType);
			parameters.Add("productCode", this.productCode);
			parameters.Add("beforeDiscount", this.beforeDiscount);
			parameters.Add("afterDiscount", this.afterDiscount);
			parameters.Add("childSeatCode", this.childSeatCode);
			parameters.Add("childDiscount", this.childDiscount);
			parameters.Add("flightinfo", this.flightinfo);
			parameters.Add("certtype", this.certtype);
			parameters.Add("certid", this.certid);
			parameters.Add("psgname", this.psgname);
			parameters.Add("psgsex", this.psgsex);
			parameters.Add("psgtype", this.psgtype);
			parameters.Add("psgbirthdate", this.psgbirthdate);
			parameters.Add("mobileNo", this.mobileNo);
			parameters.Add("insureType", this.insureType);
			parameters.Add("insurecount", this.insurecount);
			parameters.Add("ticketPrice", this.ticketPrice);
			parameters.Add("tax", this.tax);
			parameters.Add("productId", this.productId);
			parameters.Add("count", this.count);
			parameters.Add("name", this.name);
			parameters.Add("mobile", this.mobile);
			parameters.Add("tele", this.tele);
			parameters.Add("email", this.email);
			parameters.Add("fax", this.fax);
			parameters.Add("dispatchId", this.dispatchId);
			parameters.Add("deliverytype", this.deliverytype);
			parameters.Add("name", this.name);
			parameters.Add("mobile", this.mobile);
			parameters.Add("tele", this.tele);
			parameters.Add("email", this.email);
			parameters.Add("fax", this.fax);
			parameters.Add("province", this.province);
			parameters.Add("city", this.city);
			parameters.Add("district", this.district);
			parameters.Add("address", this.address);
			parameters.Add("postcode", this.postcode);
			parameters.Add("bookdelivdate", this.bookdelivdate);
			parameters.Add("bookdelivtime", this.bookdelivtime);
			parameters.Add("needinvoice", this.needinvoice);
			parameters.Add("travelSkyId", this.travelSkyId);
			parameters.Add("insurInvoice", this.insurInvoice);
			parameters.Add("onlineMoney", this.onlineMoney);
			parameters.Add("isCouponJing", this.isCouponJing);
			parameters.Add("isCouponDong", this.isCouponDong);
			parameters.Add("couponJingIds", this.couponJingIds);
			parameters.Add("couponDongIds", this.couponDongIds);
			parameters.Add("couponJingMoney", this.couponJingMoney);
			parameters.Add("couponDongMoney", this.couponDongMoney);
			parameters.Add("balanceMoney", this.balanceMoney);
			parameters.Add("isBalance", this.isBalance);
			parameters.Add("paymentPassword", this.paymentPassword);
			parameters.Add("sourceId", this.sourceId);
			parameters.Add("sourceType", this.sourceType);
			parameters.Add("userName", this.userName);
			parameters.Add("ipAddress", this.ipAddress);
			parameters.Add("orderPrice", this.orderPrice);
			parameters.Add("orderCd", this.orderCd);
			parameters.Add("uuid", this.uuid);
			parameters.Add("payType", this.payType);
			parameters.Add("paymentPassword", this.paymentPassword);
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








        
 

