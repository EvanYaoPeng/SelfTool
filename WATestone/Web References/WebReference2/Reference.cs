﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

// 
// 此源代码是由 Microsoft.VSDesigner 4.0.30319.42000 版自动生成。
// 
#pragma warning disable 1591

namespace WATestone.WebReference2 {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1087.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="cardServiceSoap11Binding", Namespace="http://webservice.cardservice.rich.com")]
    public partial class cardService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback getCardInfoFromKsqOperationCompleted;
        
        private System.Threading.SendOrPostCallback getOkOperationCompleted;
        
        private System.Threading.SendOrPostCallback getCardTypeOperationCompleted;
        
        private System.Threading.SendOrPostCallback getCardApplyInfoFromSaleManOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public cardService() {
            this.Url = global::WATestone.Properties.Settings.Default.WATestone_WebReference2_cardService;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event getCardInfoFromKsqCompletedEventHandler getCardInfoFromKsqCompleted;
        
        /// <remarks/>
        public event getOkCompletedEventHandler getOkCompleted;
        
        /// <remarks/>
        public event getCardTypeCompletedEventHandler getCardTypeCompleted;
        
        /// <remarks/>
        public event getCardApplyInfoFromSaleManCompletedEventHandler getCardApplyInfoFromSaleManCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:getCardInfoFromKsq", RequestNamespace="http://webservice.cardservice.rich.com", ResponseNamespace="http://webservice.cardservice.rich.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", IsNullable=true)]
        public string getCardInfoFromKsq([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string flownum) {
            object[] results = this.Invoke("getCardInfoFromKsq", new object[] {
                        flownum});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void getCardInfoFromKsqAsync(string flownum) {
            this.getCardInfoFromKsqAsync(flownum, null);
        }
        
        /// <remarks/>
        public void getCardInfoFromKsqAsync(string flownum, object userState) {
            if ((this.getCardInfoFromKsqOperationCompleted == null)) {
                this.getCardInfoFromKsqOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetCardInfoFromKsqOperationCompleted);
            }
            this.InvokeAsync("getCardInfoFromKsq", new object[] {
                        flownum}, this.getCardInfoFromKsqOperationCompleted, userState);
        }
        
        private void OngetCardInfoFromKsqOperationCompleted(object arg) {
            if ((this.getCardInfoFromKsqCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getCardInfoFromKsqCompleted(this, new getCardInfoFromKsqCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:getOk", RequestNamespace="http://webservice.cardservice.rich.com", ResponseNamespace="http://webservice.cardservice.rich.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", IsNullable=true)]
        public string getOk([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string ok) {
            object[] results = this.Invoke("getOk", new object[] {
                        ok});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void getOkAsync(string ok) {
            this.getOkAsync(ok, null);
        }
        
        /// <remarks/>
        public void getOkAsync(string ok, object userState) {
            if ((this.getOkOperationCompleted == null)) {
                this.getOkOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetOkOperationCompleted);
            }
            this.InvokeAsync("getOk", new object[] {
                        ok}, this.getOkOperationCompleted, userState);
        }
        
        private void OngetOkOperationCompleted(object arg) {
            if ((this.getOkCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getOkCompleted(this, new getOkCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:getCardType", RequestNamespace="http://webservice.cardservice.rich.com", ResponseNamespace="http://webservice.cardservice.rich.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", IsNullable=true)]
        public string getCardType([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string cardnum) {
            object[] results = this.Invoke("getCardType", new object[] {
                        cardnum});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void getCardTypeAsync(string cardnum) {
            this.getCardTypeAsync(cardnum, null);
        }
        
        /// <remarks/>
        public void getCardTypeAsync(string cardnum, object userState) {
            if ((this.getCardTypeOperationCompleted == null)) {
                this.getCardTypeOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetCardTypeOperationCompleted);
            }
            this.InvokeAsync("getCardType", new object[] {
                        cardnum}, this.getCardTypeOperationCompleted, userState);
        }
        
        private void OngetCardTypeOperationCompleted(object arg) {
            if ((this.getCardTypeCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getCardTypeCompleted(this, new getCardTypeCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:getCardApplyInfoFromSaleMan", RequestNamespace="http://webservice.cardservice.rich.com", ResponseNamespace="http://webservice.cardservice.rich.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", IsNullable=true)]
        public string getCardApplyInfoFromSaleMan([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string ldid, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string saleCode, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string startTime, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string endTime) {
            object[] results = this.Invoke("getCardApplyInfoFromSaleMan", new object[] {
                        ldid,
                        saleCode,
                        startTime,
                        endTime});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void getCardApplyInfoFromSaleManAsync(string ldid, string saleCode, string startTime, string endTime) {
            this.getCardApplyInfoFromSaleManAsync(ldid, saleCode, startTime, endTime, null);
        }
        
        /// <remarks/>
        public void getCardApplyInfoFromSaleManAsync(string ldid, string saleCode, string startTime, string endTime, object userState) {
            if ((this.getCardApplyInfoFromSaleManOperationCompleted == null)) {
                this.getCardApplyInfoFromSaleManOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetCardApplyInfoFromSaleManOperationCompleted);
            }
            this.InvokeAsync("getCardApplyInfoFromSaleMan", new object[] {
                        ldid,
                        saleCode,
                        startTime,
                        endTime}, this.getCardApplyInfoFromSaleManOperationCompleted, userState);
        }
        
        private void OngetCardApplyInfoFromSaleManOperationCompleted(object arg) {
            if ((this.getCardApplyInfoFromSaleManCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getCardApplyInfoFromSaleManCompleted(this, new getCardApplyInfoFromSaleManCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1087.0")]
    public delegate void getCardInfoFromKsqCompletedEventHandler(object sender, getCardInfoFromKsqCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1087.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getCardInfoFromKsqCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getCardInfoFromKsqCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1087.0")]
    public delegate void getOkCompletedEventHandler(object sender, getOkCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1087.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getOkCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getOkCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1087.0")]
    public delegate void getCardTypeCompletedEventHandler(object sender, getCardTypeCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1087.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getCardTypeCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getCardTypeCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1087.0")]
    public delegate void getCardApplyInfoFromSaleManCompletedEventHandler(object sender, getCardApplyInfoFromSaleManCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1087.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getCardApplyInfoFromSaleManCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getCardApplyInfoFromSaleManCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591