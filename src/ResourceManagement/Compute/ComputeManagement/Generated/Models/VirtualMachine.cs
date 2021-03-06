// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Azure;
using Microsoft.Azure.Management.Compute.Models;

namespace Microsoft.Azure.Management.Compute.Models
{
    /// <summary>
    /// Describes a Virtual Machine.
    /// </summary>
    public partial class VirtualMachine : ResourceBaseExtended
    {
        private AvailabilitySetReference _availabilitySetReference;
        
        /// <summary>
        /// Optional. Gets or sets the reference Id of the availailbity set to
        /// which this virtual machine belongs.
        /// </summary>
        public AvailabilitySetReference AvailabilitySetReference
        {
            get { return this._availabilitySetReference; }
            set { this._availabilitySetReference = value; }
        }
        
        private DiagnosticsProfile _diagnosticsProfile;
        
        /// <summary>
        /// Optional. Gets or sets the diagnostics profile.
        /// </summary>
        public DiagnosticsProfile DiagnosticsProfile
        {
            get { return this._diagnosticsProfile; }
            set { this._diagnosticsProfile = value; }
        }
        
        private IList<VirtualMachineExtension> _extensions;
        
        /// <summary>
        /// Optional. Gets the virtual machine child extension resources.
        /// </summary>
        public IList<VirtualMachineExtension> Extensions
        {
            get { return this._extensions; }
            set { this._extensions = value; }
        }
        
        private HardwareProfile _hardwareProfile;
        
        /// <summary>
        /// Optional. Gets or sets the hardware profile.
        /// </summary>
        public HardwareProfile HardwareProfile
        {
            get { return this._hardwareProfile; }
            set { this._hardwareProfile = value; }
        }
        
        private VirtualMachineInstanceView _instanceView;
        
        /// <summary>
        /// Optional. Gets the virtual machine instance view.
        /// </summary>
        public VirtualMachineInstanceView InstanceView
        {
            get { return this._instanceView; }
            set { this._instanceView = value; }
        }
        
        private NetworkProfile _networkProfile;
        
        /// <summary>
        /// Optional. Gets or sets the network profile.
        /// </summary>
        public NetworkProfile NetworkProfile
        {
            get { return this._networkProfile; }
            set { this._networkProfile = value; }
        }
        
        private OSProfile _oSProfile;
        
        /// <summary>
        /// Optional. Gets or sets the OS profile.
        /// </summary>
        public OSProfile OSProfile
        {
            get { return this._oSProfile; }
            set { this._oSProfile = value; }
        }
        
        private Plan _plan;
        
        /// <summary>
        /// Optional. Gets or sets the purchase plan when deploying virtual
        /// machine from VM Marketplace images.
        /// </summary>
        public Plan Plan
        {
            get { return this._plan; }
            set { this._plan = value; }
        }
        
        private string _provisioningState;
        
        /// <summary>
        /// Optional. Gets or sets the provisioning state, which only appears
        /// in the response.
        /// </summary>
        public string ProvisioningState
        {
            get { return this._provisioningState; }
            set { this._provisioningState = value; }
        }
        
        private StorageProfile _storageProfile;
        
        /// <summary>
        /// Optional. Gets or sets the storage profile.
        /// </summary>
        public StorageProfile StorageProfile
        {
            get { return this._storageProfile; }
            set { this._storageProfile = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the VirtualMachine class.
        /// </summary>
        public VirtualMachine()
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the VirtualMachine class with
        /// required arguments.
        /// </summary>
        public VirtualMachine(string location)
            : this()
        {
            if (location == null)
            {
                throw new ArgumentNullException("location");
            }
            this.Location = location;
        }
    }
}
