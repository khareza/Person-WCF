﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     //
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WcfServiceProvider
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WcfServiceProvider.IPerson")]
    public interface IPerson
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPerson/CreatePerson", ReplyAction="http://tempuri.org/IPerson/CreatePersonResponse")]
        System.Threading.Tasks.Task CreatePersonAsync(int id, string FirstName, string LastName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPerson/GetPersonById", ReplyAction="http://tempuri.org/IPerson/GetPersonByIdResponse")]
        System.Threading.Tasks.Task<PersonWcfService.Models.Person> GetPersonByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPerson/GetAllPersons", ReplyAction="http://tempuri.org/IPerson/GetAllPersonsResponse")]
        System.Threading.Tasks.Task<PersonWcfService.Models.Person[]> GetAllPersonsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPerson/DeletePerson", ReplyAction="http://tempuri.org/IPerson/DeletePersonResponse")]
        System.Threading.Tasks.Task DeletePersonAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPerson/UpdatePerson", ReplyAction="http://tempuri.org/IPerson/UpdatePersonResponse")]
        System.Threading.Tasks.Task UpdatePersonAsync(int id, string FirstName, string LastName);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public interface IPersonChannel : WcfServiceProvider.IPerson, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public partial class PersonClient : System.ServiceModel.ClientBase<WcfServiceProvider.IPerson>, WcfServiceProvider.IPerson
    {
        
    /// <summary>
    /// Implement this partial method to configure the service endpoint.
    /// </summary>
    /// <param name="serviceEndpoint">The endpoint to configure</param>
    /// <param name="clientCredentials">The client credentials</param>
    static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public PersonClient() : 
                base(PersonClient.GetDefaultBinding(), PersonClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IPerson.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public PersonClient(EndpointConfiguration endpointConfiguration) : 
                base(PersonClient.GetBindingForEndpoint(endpointConfiguration), PersonClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public PersonClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(PersonClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public PersonClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(PersonClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public PersonClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task CreatePersonAsync(int id, string FirstName, string LastName)
        {
            return base.Channel.CreatePersonAsync(id, FirstName, LastName);
        }
        
        public System.Threading.Tasks.Task<PersonWcfService.Models.Person> GetPersonByIdAsync(int id)
        {
            return base.Channel.GetPersonByIdAsync(id);
        }
        
        public System.Threading.Tasks.Task<PersonWcfService.Models.Person[]> GetAllPersonsAsync()
        {
            return base.Channel.GetAllPersonsAsync();
        }
        
        public System.Threading.Tasks.Task DeletePersonAsync(int id)
        {
            return base.Channel.DeletePersonAsync(id);
        }
        
        public System.Threading.Tasks.Task UpdatePersonAsync(int id, string FirstName, string LastName)
        {
            return base.Channel.UpdatePersonAsync(id, FirstName, LastName);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IPerson))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IPerson))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:49981/PersonService.svc");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return PersonClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IPerson);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return PersonClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IPerson);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IPerson,
        }
    }
}