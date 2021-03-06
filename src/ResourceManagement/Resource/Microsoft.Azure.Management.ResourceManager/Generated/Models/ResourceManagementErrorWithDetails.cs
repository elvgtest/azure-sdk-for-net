// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.14.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ResourceManager.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// </summary>
    public partial class ResourceManagementErrorWithDetails
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ResourceManagementErrorWithDetails class.
        /// </summary>
        public ResourceManagementErrorWithDetails() { }

        /// <summary>
        /// Initializes a new instance of the
        /// ResourceManagementErrorWithDetails class.
        /// </summary>
        public ResourceManagementErrorWithDetails(string code, string message, string target = default(string), IList<ResourceManagementErrorWithDetails> details = default(IList<ResourceManagementErrorWithDetails>))
        {
            Code = code;
            Message = message;
            Target = target;
            Details = details;
        }

        /// <summary>
        /// The error code returned from the server.
        /// </summary>
        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }

        /// <summary>
        /// The error message returned from the server.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        /// <summary>
        /// The target of the error.
        /// </summary>
        [JsonProperty(PropertyName = "target")]
        public string Target { get; set; }

        /// <summary>
        /// Validation error.
        /// </summary>
        [JsonProperty(PropertyName = "details")]
        public IList<ResourceManagementErrorWithDetails> Details { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (Code == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Code");
            }
            if (Message == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Message");
            }
            if (this.Details != null)
            {
                foreach (var element in this.Details)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
