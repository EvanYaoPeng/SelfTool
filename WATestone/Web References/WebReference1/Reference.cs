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

namespace WATestone.WebReference1 {
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
    [System.Web.Services.WebServiceBindingAttribute(Name="cardServiceSOAP11Binding", Namespace="http://webservice.cardservice.rich.com")]
    public partial class cardService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback getOkOperationCompleted;
        
        private System.Threading.SendOrPostCallback getCardTypeOperationCompleted;
        
        private System.Threading.SendOrPostCallback getCardApplyInfoFromSaleManOperationCompleted;
        
        private System.Threading.SendOrPostCallback getCardInfoFromKsqOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public cardService() {
            this.Url = global::WATestone.Properties.Settings.Default.WATestone_WebReference1_cardService;
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
        public event getOkCompletedEventHandler getOkCompleted;
        
        /// <remarks/>
        public event getCardTypeCompletedEventHandler getCardTypeCompleted;
        
        /// <remarks/>
        public event getCardApplyInfoFromSaleManCompletedEventHandler getCardApplyInfoFromSaleManCompleted;
        
        /// <remarks/>
        public event getCardInfoFromKsqCompletedEventHandler getCardInfoFromKsqCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:getOk", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Bare)]
        [return: System.Xml.Serialization.XmlElementAttribute("getOkResponse", Namespace="http://webservice.cardservice.rich.com/xsd")]
        public getOkResponse getOk([System.Xml.Serialization.XmlElementAttribute("getOk", Namespace="http://webservice.cardservice.rich.com/xsd")] getOk getOk1) {
            object[] results = this.Invoke("getOk", new object[] {
                        getOk1});
            return ((getOkResponse)(results[0]));
        }
        
        /// <remarks/>
        public void getOkAsync(getOk getOk1) {
            this.getOkAsync(getOk1, null);
        }
        
        /// <remarks/>
        public void getOkAsync(getOk getOk1, object userState) {
            if ((this.getOkOperationCompleted == null)) {
                this.getOkOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetOkOperationCompleted);
            }
            this.InvokeAsync("getOk", new object[] {
                        getOk1}, this.getOkOperationCompleted, userState);
        }
        
        private void OngetOkOperationCompleted(object arg) {
            if ((this.getOkCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getOkCompleted(this, new getOkCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:getCardType", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Bare)]
        [return: System.Xml.Serialization.XmlElementAttribute("getCardTypeResponse", Namespace="http://webservice.cardservice.rich.com/xsd")]
        public getCardTypeResponse getCardType([System.Xml.Serialization.XmlElementAttribute("getCardType", Namespace="http://webservice.cardservice.rich.com/xsd")] getCardType getCardType1) {
            object[] results = this.Invoke("getCardType", new object[] {
                        getCardType1});
            return ((getCardTypeResponse)(results[0]));
        }
        
        /// <remarks/>
        public void getCardTypeAsync(getCardType getCardType1) {
            this.getCardTypeAsync(getCardType1, null);
        }
        
        /// <remarks/>
        public void getCardTypeAsync(getCardType getCardType1, object userState) {
            if ((this.getCardTypeOperationCompleted == null)) {
                this.getCardTypeOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetCardTypeOperationCompleted);
            }
            this.InvokeAsync("getCardType", new object[] {
                        getCardType1}, this.getCardTypeOperationCompleted, userState);
        }
        
        private void OngetCardTypeOperationCompleted(object arg) {
            if ((this.getCardTypeCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getCardTypeCompleted(this, new getCardTypeCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:getCardApplyInfoFromSaleMan", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Bare)]
        [return: System.Xml.Serialization.XmlElementAttribute("getCardApplyInfoFromSaleManResponse", Namespace="http://webservice.cardservice.rich.com/xsd")]
        public getCardApplyInfoFromSaleManResponse getCardApplyInfoFromSaleMan([System.Xml.Serialization.XmlElementAttribute("getCardApplyInfoFromSaleMan", Namespace="http://webservice.cardservice.rich.com/xsd")] getCardApplyInfoFromSaleMan getCardApplyInfoFromSaleMan1) {
            object[] results = this.Invoke("getCardApplyInfoFromSaleMan", new object[] {
                        getCardApplyInfoFromSaleMan1});
            return ((getCardApplyInfoFromSaleManResponse)(results[0]));
        }
        
        /// <remarks/>
        public void getCardApplyInfoFromSaleManAsync(getCardApplyInfoFromSaleMan getCardApplyInfoFromSaleMan1) {
            this.getCardApplyInfoFromSaleManAsync(getCardApplyInfoFromSaleMan1, null);
        }
        
        /// <remarks/>
        public void getCardApplyInfoFromSaleManAsync(getCardApplyInfoFromSaleMan getCardApplyInfoFromSaleMan1, object userState) {
            if ((this.getCardApplyInfoFromSaleManOperationCompleted == null)) {
                this.getCardApplyInfoFromSaleManOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetCardApplyInfoFromSaleManOperationCompleted);
            }
            this.InvokeAsync("getCardApplyInfoFromSaleMan", new object[] {
                        getCardApplyInfoFromSaleMan1}, this.getCardApplyInfoFromSaleManOperationCompleted, userState);
        }
        
        private void OngetCardApplyInfoFromSaleManOperationCompleted(object arg) {
            if ((this.getCardApplyInfoFromSaleManCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getCardApplyInfoFromSaleManCompleted(this, new getCardApplyInfoFromSaleManCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:getCardInfoFromKsq", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Bare)]
        [return: System.Xml.Serialization.XmlElementAttribute("getCardInfoFromKsqResponse", Namespace="http://webservice.cardservice.rich.com/xsd")]
        public getCardInfoFromKsqResponse getCardInfoFromKsq([System.Xml.Serialization.XmlElementAttribute("getCardInfoFromKsq", Namespace="http://webservice.cardservice.rich.com/xsd")] getCardInfoFromKsq getCardInfoFromKsq1) {
            object[] results = this.Invoke("getCardInfoFromKsq", new object[] {
                        getCardInfoFromKsq1});
            return ((getCardInfoFromKsqResponse)(results[0]));
        }
        
        /// <remarks/>
        public void getCardInfoFromKsqAsync(getCardInfoFromKsq getCardInfoFromKsq1) {
            this.getCardInfoFromKsqAsync(getCardInfoFromKsq1, null);
        }
        
        /// <remarks/>
        public void getCardInfoFromKsqAsync(getCardInfoFromKsq getCardInfoFromKsq1, object userState) {
            if ((this.getCardInfoFromKsqOperationCompleted == null)) {
                this.getCardInfoFromKsqOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetCardInfoFromKsqOperationCompleted);
            }
            this.InvokeAsync("getCardInfoFromKsq", new object[] {
                        getCardInfoFromKsq1}, this.getCardInfoFromKsqOperationCompleted, userState);
        }
        
        private void OngetCardInfoFromKsqOperationCompleted(object arg) {
            if ((this.getCardInfoFromKsqCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getCardInfoFromKsqCompleted(this, new getCardInfoFromKsqCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1087.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://webservice.cardservice.rich.com/xsd")]
    public partial class getOk {
        
        private string okField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string ok {
            get {
                return this.okField;
            }
            set {
                this.okField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1087.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://webservice.cardservice.rich.com/xsd")]
    public partial class getOkResponse {
        
        private string returnField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string @return {
            get {
                return this.returnField;
            }
            set {
                this.returnField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1087.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://webservice.cardservice.rich.com/xsd")]
    public partial class getCardType {
        
        private string cardnumField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string cardnum {
            get {
                return this.cardnumField;
            }
            set {
                this.cardnumField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1087.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://webservice.cardservice.rich.com/xsd")]
    public partial class getCardTypeResponse {
        
        private string returnField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string @return {
            get {
                return this.returnField;
            }
            set {
                this.returnField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1087.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://webservice.cardservice.rich.com/xsd")]
    public partial class getCardApplyInfoFromSaleMan {
        
        private string ldidField;
        
        private string saleCodeField;
        
        private string startTimeField;
        
        private string endTimeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string ldid {
            get {
                return this.ldidField;
            }
            set {
                this.ldidField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string saleCode {
            get {
                return this.saleCodeField;
            }
            set {
                this.saleCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string startTime {
            get {
                return this.startTimeField;
            }
            set {
                this.startTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string endTime {
            get {
                return this.endTimeField;
            }
            set {
                this.endTimeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1087.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://webservice.cardservice.rich.com/xsd")]
    public partial class getCardApplyInfoFromSaleManResponse {
        
        private string returnField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string @return {
            get {
                return this.returnField;
            }
            set {
                this.returnField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1087.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://webservice.cardservice.rich.com/xsd")]
    public partial class getCardInfoFromKsq {
        
        private string flownumField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string flownum {
            get {
                return this.flownumField;
            }
            set {
                this.flownumField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1087.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://webservice.cardservice.rich.com/xsd")]
    public partial class getCardInfoFromKsqResponse {
        
        private string returnField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string @return {
            get {
                return this.returnField;
            }
            set {
                this.returnField = value;
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
        public getOkResponse Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((getOkResponse)(this.results[0]));
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
        public getCardTypeResponse Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((getCardTypeResponse)(this.results[0]));
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
        public getCardApplyInfoFromSaleManResponse Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((getCardApplyInfoFromSaleManResponse)(this.results[0]));
            }
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
        public getCardInfoFromKsqResponse Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((getCardInfoFromKsqResponse)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591