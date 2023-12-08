﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18052
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MathTutorXML.ServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Equation", Namespace="http://schemas.datacontract.org/2004/07/")]
    [System.SerializableAttribute()]
    public partial class Equation : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int LeftField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LeftHandSideField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string OperationField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ResultField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int RightField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RightHandSideField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Left {
            get {
                return this.LeftField;
            }
            set {
                if ((this.LeftField.Equals(value) != true)) {
                    this.LeftField = value;
                    this.RaisePropertyChanged("Left");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LeftHandSide {
            get {
                return this.LeftHandSideField;
            }
            set {
                if ((object.ReferenceEquals(this.LeftHandSideField, value) != true)) {
                    this.LeftHandSideField = value;
                    this.RaisePropertyChanged("LeftHandSide");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Operation {
            get {
                return this.OperationField;
            }
            set {
                if ((object.ReferenceEquals(this.OperationField, value) != true)) {
                    this.OperationField = value;
                    this.RaisePropertyChanged("Operation");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Result {
            get {
                return this.ResultField;
            }
            set {
                if ((this.ResultField.Equals(value) != true)) {
                    this.ResultField = value;
                    this.RaisePropertyChanged("Result");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Right {
            get {
                return this.RightField;
            }
            set {
                if ((this.RightField.Equals(value) != true)) {
                    this.RightField = value;
                    this.RaisePropertyChanged("Right");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string RightHandSide {
            get {
                return this.RightHandSideField;
            }
            set {
                if ((object.ReferenceEquals(this.RightHandSideField, value) != true)) {
                    this.RightHandSideField = value;
                    this.RaisePropertyChanged("RightHandSide");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference.IEquationGeneratorService")]
    public interface IEquationGeneratorService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEquationGeneratorService/GenerateEquation", ReplyAction="http://tempuri.org/IEquationGeneratorService/GenerateEquationResponse")]
        MathTutorXML.ServiceReference.Equation GenerateEquation(string operation, string level);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IEquationGeneratorServiceChannel : MathTutorXML.ServiceReference.IEquationGeneratorService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EquationGeneratorServiceClient : System.ServiceModel.ClientBase<MathTutorXML.ServiceReference.IEquationGeneratorService>, MathTutorXML.ServiceReference.IEquationGeneratorService {
        
        public EquationGeneratorServiceClient() {
        }
        
        public EquationGeneratorServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EquationGeneratorServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EquationGeneratorServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EquationGeneratorServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public MathTutorXML.ServiceReference.Equation GenerateEquation(string operation, string level) {
            return base.Channel.GenerateEquation(operation, level);
        }
    }
}
