﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This code was auto-generated by Microsoft.Silverlight.Phone.ServiceReference, version 3.7.0.0
// 
namespace PhoneApp2.KPS {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://tckimlik.nvi.gov.tr/WS", ConfigurationName="KPS.KPSPublicSoap")]
    public interface KPSPublicSoap {
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tckimlik.nvi.gov.tr/WS/TCKimlikNoDogrula", ReplyAction="*")]
        System.IAsyncResult BeginTCKimlikNoDogrula(PhoneApp2.KPS.TCKimlikNoDogrulaRequest request, System.AsyncCallback callback, object asyncState);
        
        PhoneApp2.KPS.TCKimlikNoDogrulaResponse EndTCKimlikNoDogrula(System.IAsyncResult result);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class TCKimlikNoDogrulaRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="TCKimlikNoDogrula", Namespace="http://tckimlik.nvi.gov.tr/WS", Order=0)]
        public PhoneApp2.KPS.TCKimlikNoDogrulaRequestBody Body;
        
        public TCKimlikNoDogrulaRequest() {
        }
        
        public TCKimlikNoDogrulaRequest(PhoneApp2.KPS.TCKimlikNoDogrulaRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tckimlik.nvi.gov.tr/WS")]
    public partial class TCKimlikNoDogrulaRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public long TCKimlikNo;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string Ad;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string Soyad;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=3)]
        public int DogumYili;
        
        public TCKimlikNoDogrulaRequestBody() {
        }
        
        public TCKimlikNoDogrulaRequestBody(long TCKimlikNo, string Ad, string Soyad, int DogumYili) {
            this.TCKimlikNo = TCKimlikNo;
            this.Ad = Ad;
            this.Soyad = Soyad;
            this.DogumYili = DogumYili;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class TCKimlikNoDogrulaResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="TCKimlikNoDogrulaResponse", Namespace="http://tckimlik.nvi.gov.tr/WS", Order=0)]
        public PhoneApp2.KPS.TCKimlikNoDogrulaResponseBody Body;
        
        public TCKimlikNoDogrulaResponse() {
        }
        
        public TCKimlikNoDogrulaResponse(PhoneApp2.KPS.TCKimlikNoDogrulaResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tckimlik.nvi.gov.tr/WS")]
    public partial class TCKimlikNoDogrulaResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool TCKimlikNoDogrulaResult;
        
        public TCKimlikNoDogrulaResponseBody() {
        }
        
        public TCKimlikNoDogrulaResponseBody(bool TCKimlikNoDogrulaResult) {
            this.TCKimlikNoDogrulaResult = TCKimlikNoDogrulaResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface KPSPublicSoapChannel : PhoneApp2.KPS.KPSPublicSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TCKimlikNoDogrulaCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public TCKimlikNoDogrulaCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public bool Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class KPSPublicSoapClient : System.ServiceModel.ClientBase<PhoneApp2.KPS.KPSPublicSoap>, PhoneApp2.KPS.KPSPublicSoap {
        
        private BeginOperationDelegate onBeginTCKimlikNoDogrulaDelegate;
        
        private EndOperationDelegate onEndTCKimlikNoDogrulaDelegate;
        
        private System.Threading.SendOrPostCallback onTCKimlikNoDogrulaCompletedDelegate;
        
        private BeginOperationDelegate onBeginOpenDelegate;
        
        private EndOperationDelegate onEndOpenDelegate;
        
        private System.Threading.SendOrPostCallback onOpenCompletedDelegate;
        
        private BeginOperationDelegate onBeginCloseDelegate;
        
        private EndOperationDelegate onEndCloseDelegate;
        
        private System.Threading.SendOrPostCallback onCloseCompletedDelegate;
        
        public KPSPublicSoapClient() {
        }
        
        public KPSPublicSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public KPSPublicSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public KPSPublicSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public KPSPublicSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Net.CookieContainer CookieContainer {
            get {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    return httpCookieContainerManager.CookieContainer;
                }
                else {
                    return null;
                }
            }
            set {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    httpCookieContainerManager.CookieContainer = value;
                }
                else {
                    throw new System.InvalidOperationException("Unable to set the CookieContainer. Please make sure the binding contains an HttpC" +
                            "ookieContainerBindingElement.");
                }
            }
        }
        
        public event System.EventHandler<TCKimlikNoDogrulaCompletedEventArgs> TCKimlikNoDogrulaCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> OpenCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> CloseCompleted;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult PhoneApp2.KPS.KPSPublicSoap.BeginTCKimlikNoDogrula(PhoneApp2.KPS.TCKimlikNoDogrulaRequest request, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginTCKimlikNoDogrula(request, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        private System.IAsyncResult BeginTCKimlikNoDogrula(long TCKimlikNo, string Ad, string Soyad, int DogumYili, System.AsyncCallback callback, object asyncState) {
            PhoneApp2.KPS.TCKimlikNoDogrulaRequest inValue = new PhoneApp2.KPS.TCKimlikNoDogrulaRequest();
            inValue.Body = new PhoneApp2.KPS.TCKimlikNoDogrulaRequestBody();
            inValue.Body.TCKimlikNo = TCKimlikNo;
            inValue.Body.Ad = Ad;
            inValue.Body.Soyad = Soyad;
            inValue.Body.DogumYili = DogumYili;
            return ((PhoneApp2.KPS.KPSPublicSoap)(this)).BeginTCKimlikNoDogrula(inValue, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        PhoneApp2.KPS.TCKimlikNoDogrulaResponse PhoneApp2.KPS.KPSPublicSoap.EndTCKimlikNoDogrula(System.IAsyncResult result) {
            return base.Channel.EndTCKimlikNoDogrula(result);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        private bool EndTCKimlikNoDogrula(System.IAsyncResult result) {
            PhoneApp2.KPS.TCKimlikNoDogrulaResponse retVal = ((PhoneApp2.KPS.KPSPublicSoap)(this)).EndTCKimlikNoDogrula(result);
            return retVal.Body.TCKimlikNoDogrulaResult;
        }
        
        private System.IAsyncResult OnBeginTCKimlikNoDogrula(object[] inValues, System.AsyncCallback callback, object asyncState) {
            long TCKimlikNo = ((long)(inValues[0]));
            string Ad = ((string)(inValues[1]));
            string Soyad = ((string)(inValues[2]));
            int DogumYili = ((int)(inValues[3]));
            return this.BeginTCKimlikNoDogrula(TCKimlikNo, Ad, Soyad, DogumYili, callback, asyncState);
        }
        
        private object[] OnEndTCKimlikNoDogrula(System.IAsyncResult result) {
            bool retVal = this.EndTCKimlikNoDogrula(result);
            return new object[] {
                    retVal};
        }
        
        private void OnTCKimlikNoDogrulaCompleted(object state) {
            if ((this.TCKimlikNoDogrulaCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.TCKimlikNoDogrulaCompleted(this, new TCKimlikNoDogrulaCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void TCKimlikNoDogrulaAsync(long TCKimlikNo, string Ad, string Soyad, int DogumYili) {
            this.TCKimlikNoDogrulaAsync(TCKimlikNo, Ad, Soyad, DogumYili, null);
        }
        
        public void TCKimlikNoDogrulaAsync(long TCKimlikNo, string Ad, string Soyad, int DogumYili, object userState) {
            if ((this.onBeginTCKimlikNoDogrulaDelegate == null)) {
                this.onBeginTCKimlikNoDogrulaDelegate = new BeginOperationDelegate(this.OnBeginTCKimlikNoDogrula);
            }
            if ((this.onEndTCKimlikNoDogrulaDelegate == null)) {
                this.onEndTCKimlikNoDogrulaDelegate = new EndOperationDelegate(this.OnEndTCKimlikNoDogrula);
            }
            if ((this.onTCKimlikNoDogrulaCompletedDelegate == null)) {
                this.onTCKimlikNoDogrulaCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnTCKimlikNoDogrulaCompleted);
            }
            base.InvokeAsync(this.onBeginTCKimlikNoDogrulaDelegate, new object[] {
                        TCKimlikNo,
                        Ad,
                        Soyad,
                        DogumYili}, this.onEndTCKimlikNoDogrulaDelegate, this.onTCKimlikNoDogrulaCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginOpen(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(callback, asyncState);
        }
        
        private object[] OnEndOpen(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndOpen(result);
            return null;
        }
        
        private void OnOpenCompleted(object state) {
            if ((this.OpenCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.OpenCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void OpenAsync() {
            this.OpenAsync(null);
        }
        
        public void OpenAsync(object userState) {
            if ((this.onBeginOpenDelegate == null)) {
                this.onBeginOpenDelegate = new BeginOperationDelegate(this.OnBeginOpen);
            }
            if ((this.onEndOpenDelegate == null)) {
                this.onEndOpenDelegate = new EndOperationDelegate(this.OnEndOpen);
            }
            if ((this.onOpenCompletedDelegate == null)) {
                this.onOpenCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnOpenCompleted);
            }
            base.InvokeAsync(this.onBeginOpenDelegate, null, this.onEndOpenDelegate, this.onOpenCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginClose(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginClose(callback, asyncState);
        }
        
        private object[] OnEndClose(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndClose(result);
            return null;
        }
        
        private void OnCloseCompleted(object state) {
            if ((this.CloseCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.CloseCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void CloseAsync() {
            this.CloseAsync(null);
        }
        
        public void CloseAsync(object userState) {
            if ((this.onBeginCloseDelegate == null)) {
                this.onBeginCloseDelegate = new BeginOperationDelegate(this.OnBeginClose);
            }
            if ((this.onEndCloseDelegate == null)) {
                this.onEndCloseDelegate = new EndOperationDelegate(this.OnEndClose);
            }
            if ((this.onCloseCompletedDelegate == null)) {
                this.onCloseCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnCloseCompleted);
            }
            base.InvokeAsync(this.onBeginCloseDelegate, null, this.onEndCloseDelegate, this.onCloseCompletedDelegate, userState);
        }
        
        protected override PhoneApp2.KPS.KPSPublicSoap CreateChannel() {
            return new KPSPublicSoapClientChannel(this);
        }
        
        private class KPSPublicSoapClientChannel : ChannelBase<PhoneApp2.KPS.KPSPublicSoap>, PhoneApp2.KPS.KPSPublicSoap {
            
            public KPSPublicSoapClientChannel(System.ServiceModel.ClientBase<PhoneApp2.KPS.KPSPublicSoap> client) : 
                    base(client) {
            }
            
            public System.IAsyncResult BeginTCKimlikNoDogrula(PhoneApp2.KPS.TCKimlikNoDogrulaRequest request, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[1];
                _args[0] = request;
                System.IAsyncResult _result = base.BeginInvoke("TCKimlikNoDogrula", _args, callback, asyncState);
                return _result;
            }
            
            public PhoneApp2.KPS.TCKimlikNoDogrulaResponse EndTCKimlikNoDogrula(System.IAsyncResult result) {
                object[] _args = new object[0];
                PhoneApp2.KPS.TCKimlikNoDogrulaResponse _result = ((PhoneApp2.KPS.TCKimlikNoDogrulaResponse)(base.EndInvoke("TCKimlikNoDogrula", _args, result)));
                return _result;
            }
        }
    }
}