// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Monitor.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The resource management error response.
    /// </summary>
    public partial class ErrorResponseCommon : ErrorResponse
    {
        /// <summary>
        /// Initializes a new instance of the ErrorResponseCommon class.
        /// </summary>
        public ErrorResponseCommon()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ErrorResponseCommon class.
        /// </summary>
        /// <param name="code">Error code</param>
        /// <param name="message">Error message indicating why the operation
        /// failed.</param>
        /// <param name="details">The error details.</param>
        /// <param name="additionalInfo">The error additional info.</param>
        public ErrorResponseCommon(string code = default(string), string message = default(string), IList<ErrorResponseCommon> details = default(IList<ErrorResponseCommon>), IList<ErrorAdditionalInfo> additionalInfo = default(IList<ErrorAdditionalInfo>))
            : base(code, message)
        {
            Details = details;
            AdditionalInfo = additionalInfo;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the error details.
        /// </summary>
        [JsonProperty(PropertyName = "details")]
        public IList<ErrorResponseCommon> Details { get; private set; }

        /// <summary>
        /// Gets the error additional info.
        /// </summary>
        [JsonProperty(PropertyName = "additionalInfo")]
        public IList<ErrorAdditionalInfo> AdditionalInfo { get; private set; }

    }
}