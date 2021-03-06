// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Response to a ComputeNodeOperation.GetRemoteLoginSettings request.
    /// </summary>
    public partial class ComputeNodeGetRemoteLoginSettingsResult
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ComputeNodeGetRemoteLoginSettingsResult class.
        /// </summary>
        public ComputeNodeGetRemoteLoginSettingsResult() { }

        /// <summary>
        /// Initializes a new instance of the
        /// ComputeNodeGetRemoteLoginSettingsResult class.
        /// </summary>
        /// <param name="remoteLoginIPAddress">The IP address used for remote login to the compute node.</param>
        /// <param name="remoteLoginPort">The port used for remote login to the compute node.</param>
        public ComputeNodeGetRemoteLoginSettingsResult(string remoteLoginIPAddress, int remoteLoginPort)
        {
            RemoteLoginIPAddress = remoteLoginIPAddress;
            RemoteLoginPort = remoteLoginPort;
        }

        /// <summary>
        /// Gets or sets the IP address used for remote login to the compute
        /// node.
        /// </summary>
        [JsonProperty(PropertyName = "remoteLoginIPAddress")]
        public string RemoteLoginIPAddress { get; set; }

        /// <summary>
        /// Gets or sets the port used for remote login to the compute node.
        /// </summary>
        [JsonProperty(PropertyName = "remoteLoginPort")]
        public int RemoteLoginPort { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (RemoteLoginIPAddress == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "RemoteLoginIPAddress");
            }
        }
    }
}
