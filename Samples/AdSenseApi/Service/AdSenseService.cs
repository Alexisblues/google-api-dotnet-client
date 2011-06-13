// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace Google.Apis.Samples.AdSenseApi.Service {
    using System;
    using System.IO;
    using System.Collections.Generic;
    using Google.Apis;
    using Google.Apis.Discovery;
    
    
    public class AdsensemgmtService : Google.Apis.Discovery.IRequestExecutor {
        
        private Google.Apis.Discovery.IService genericService;
        
        private Google.Apis.Authentication.IAuthenticator authenticator;
        
        private const string Version = "v1beta1";
        
        private const string Name = "adsense-mgmt";
        
        private const string BaseUri = "http://elephant.lon:9996/adsense-mgmt/v1beta1/";
        
        private const Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_0_2;
        
        private Adunits adunits;
        
        private Customchannels customchannels;
        
        private Reports reports;
        
        private Urlchannels urlchannels;
        
        private Webproperties webproperties;
        
        public AdsensemgmtService(Google.Apis.Discovery.IService genericService, Google.Apis.Authentication.IAuthenticator authenticator) {
            this.genericService = genericService;
            this.authenticator = authenticator;
            this.adunits = new Adunits(this);
            this.customchannels = new Customchannels(this);
            this.reports = new Reports(this);
            this.urlchannels = new Urlchannels(this);
            this.webproperties = new Webproperties(this);
        }
        
        public AdsensemgmtService() : 
                this(new Google.Apis.Discovery.DiscoveryService(new Google.Apis.Discovery.WebDiscoveryDevice(new System.Uri(("https://www.googleapis.com/discovery/0.1/describe?api=" + AdsensemgmtService.Name)))).GetService(AdsensemgmtService.Version, AdsensemgmtService.DiscoveryVersionUsed, new Google.Apis.Discovery.FactoryParameterV0_2(null, AdsensemgmtService.BaseUri)), Google.Apis.Authentication.AuthenticatorFactory.GetInstance().GetRegisteredAuthenticator()) {
        }
        
        public virtual Adunits Adunits {
            get {
                return this.adunits;
            }
        }
        
        public virtual Customchannels Customchannels {
            get {
                return this.customchannels;
            }
        }
        
        public virtual Reports Reports {
            get {
                return this.reports;
            }
        }
        
        public virtual Urlchannels Urlchannels {
            get {
                return this.urlchannels;
            }
        }
        
        public virtual Webproperties Webproperties {
            get {
                return this.webproperties;
            }
        }
        
        public virtual System.IO.Stream ExecuteRequest(string resource, string method, string body, System.Collections.Generic.IDictionary<string, object> parameters) {
            Google.Apis.Requests.IRequest request = this.genericService.CreateRequest(resource, method);
            return request.WithParameters(parameters).WithAuthentication(authenticator).WithBody(body).ExecuteRequest();
        }
    }
    
    public class Adunits {
        
        private Google.Apis.Discovery.IRequestExecutor service;
        
        private const string Resource = "adunits";
        
        private log4net.ILog logger = log4net.LogManager.GetLogger(typeof(Adunits));
        
        public Adunits(AdsensemgmtService service) {
            this.service = service;
        }
        
        public virtual System.IO.Stream List(string propertycodeParam1) {
            string body = null;
            System.Collections.Generic.Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();
            parameters["property_code"] = propertycodeParam1;
            logger.Debug("Executing adunits.list");
            System.IO.Stream ret = this.service.ExecuteRequest(Adunits.Resource, "list", body, parameters);
            logger.Debug("Done Executing adunits.list");
            return ret;
        }
    }
    
    public class Customchannels {
        
        private Google.Apis.Discovery.IRequestExecutor service;
        
        private const string Resource = "customchannels";
        
        private log4net.ILog logger = log4net.LogManager.GetLogger(typeof(Customchannels));
        
        public Customchannels(AdsensemgmtService service) {
            this.service = service;
        }
        
        public virtual System.IO.Stream List(string propertycodeParam1) {
            string body = null;
            System.Collections.Generic.Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();
            parameters["property_code"] = propertycodeParam1;
            logger.Debug("Executing customchannels.list");
            System.IO.Stream ret = this.service.ExecuteRequest(Customchannels.Resource, "list", body, parameters);
            logger.Debug("Done Executing customchannels.list");
            return ret;
        }
    }
    
    public class Reports {
        
        private Google.Apis.Discovery.IRequestExecutor service;
        
        private const string Resource = "reports";
        
        private log4net.ILog logger = log4net.LogManager.GetLogger(typeof(Reports));
        
        public Reports(AdsensemgmtService service) {
            this.service = service;
        }
        
        public virtual System.IO.Stream Generate(string body) {
            System.Collections.Generic.Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();
            logger.Debug("Executing reports.generate");
            System.IO.Stream ret = this.service.ExecuteRequest(Reports.Resource, "generate", body, parameters);
            logger.Debug("Done Executing reports.generate");
            return ret;
        }
    }
    
    public class Urlchannels {
        
        private Google.Apis.Discovery.IRequestExecutor service;
        
        private const string Resource = "urlchannels";
        
        private log4net.ILog logger = log4net.LogManager.GetLogger(typeof(Urlchannels));
        
        public Urlchannels(AdsensemgmtService service) {
            this.service = service;
        }
        
        public virtual System.IO.Stream List(string propertycodeParam1) {
            string body = null;
            System.Collections.Generic.Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();
            parameters["property_code"] = propertycodeParam1;
            logger.Debug("Executing urlchannels.list");
            System.IO.Stream ret = this.service.ExecuteRequest(Urlchannels.Resource, "list", body, parameters);
            logger.Debug("Done Executing urlchannels.list");
            return ret;
        }
    }
    
    public class Webproperties {
        
        private Google.Apis.Discovery.IRequestExecutor service;
        
        private const string Resource = "webproperties";
        
        private log4net.ILog logger = log4net.LogManager.GetLogger(typeof(Webproperties));
        
        public Webproperties(AdsensemgmtService service) {
            this.service = service;
        }
        
        public virtual System.IO.Stream List() {
            string body = null;
            System.Collections.Generic.Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();
            logger.Debug("Executing webproperties.list");
            System.IO.Stream ret = this.service.ExecuteRequest(Webproperties.Resource, "list", body, parameters);
            logger.Debug("Done Executing webproperties.list");
            return ret;
        }
    }
}
