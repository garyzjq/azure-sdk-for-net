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
using System.Linq;

namespace Microsoft.WindowsAzure.Management.SiteRecovery.Models
{
    /// <summary>
    /// The definition of a EnableProtectionInput object.
    /// </summary>
    public partial class EnableProtectionInput
    {
        private string _protectionProfileId;
        
        /// <summary>
        /// Optional. The ProtectionProfileId.
        /// </summary>
        public string ProtectionProfileId
        {
            get { return this._protectionProfileId; }
            set { this._protectionProfileId = value; }
        }
        
        private string _replicationProviderInput;
        
        /// <summary>
        /// Required. Gets or sets the ReplicationProviderInput. For
        /// HyperVReplicaAzure provider it will be serialized
        /// AzureEnableProtectionInput object. For San provider it will be
        /// serialized SanEnableProtectionInput object. For HyperVReplicaAzure
        /// it can be null
        /// </summary>
        public string ReplicationProviderInput
        {
            get { return this._replicationProviderInput; }
            set { this._replicationProviderInput = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the EnableProtectionInput class.
        /// </summary>
        public EnableProtectionInput()
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the EnableProtectionInput class with
        /// required arguments.
        /// </summary>
        public EnableProtectionInput(string replicationProviderInput)
            : this()
        {
            if (replicationProviderInput == null)
            {
                throw new ArgumentNullException("replicationProviderInput");
            }
            this.ReplicationProviderInput = replicationProviderInput;
        }
    }
}
