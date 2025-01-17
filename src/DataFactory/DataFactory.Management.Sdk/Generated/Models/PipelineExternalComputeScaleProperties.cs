// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// PipelineExternalComputeScale properties for managed integration
    /// runtime.
    /// </summary>
    public partial class PipelineExternalComputeScaleProperties
    {
        /// <summary>
        /// Initializes a new instance of the
        /// PipelineExternalComputeScaleProperties class.
        /// </summary>
        public PipelineExternalComputeScaleProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// PipelineExternalComputeScaleProperties class.
        /// </summary>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="timeToLive">Time to live (in minutes) setting of
        /// integration runtime which will execute pipeline and external
        /// activity.</param>
        /// <param name="numberOfPipelineNodes">Number of the pipeline nodes,
        /// which should be greater than 0 and less than 11.</param>
        /// <param name="numberOfExternalNodes">Number of the the external
        /// nodes, which should be greater than 0 and less than 11.</param>
        public PipelineExternalComputeScaleProperties(IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), int? timeToLive = default(int?), int? numberOfPipelineNodes = default(int?), int? numberOfExternalNodes = default(int?))
        {
            AdditionalProperties = additionalProperties;
            TimeToLive = timeToLive;
            NumberOfPipelineNodes = numberOfPipelineNodes;
            NumberOfExternalNodes = numberOfExternalNodes;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets unmatched properties from the message are deserialized
        /// this collection
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; }

        /// <summary>
        /// Gets or sets time to live (in minutes) setting of integration
        /// runtime which will execute pipeline and external activity.
        /// </summary>
        [JsonProperty(PropertyName = "timeToLive")]
        public int? TimeToLive { get; set; }

        /// <summary>
        /// Gets or sets number of the pipeline nodes, which should be greater
        /// than 0 and less than 11.
        /// </summary>
        [JsonProperty(PropertyName = "numberOfPipelineNodes")]
        public int? NumberOfPipelineNodes { get; set; }

        /// <summary>
        /// Gets or sets number of the the external nodes, which should be
        /// greater than 0 and less than 11.
        /// </summary>
        [JsonProperty(PropertyName = "numberOfExternalNodes")]
        public int? NumberOfExternalNodes { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (TimeToLive != null)
            {
                if (TimeToLive < 5)
                {
                    throw new ValidationException(ValidationRules.InclusiveMinimum, "TimeToLive", 5);
                }
            }
            if (NumberOfPipelineNodes != null)
            {
                if (NumberOfPipelineNodes > 10)
                {
                    throw new ValidationException(ValidationRules.InclusiveMaximum, "NumberOfPipelineNodes", 10);
                }
                if (NumberOfPipelineNodes < 1)
                {
                    throw new ValidationException(ValidationRules.InclusiveMinimum, "NumberOfPipelineNodes", 1);
                }
            }
            if (NumberOfExternalNodes != null)
            {
                if (NumberOfExternalNodes > 10)
                {
                    throw new ValidationException(ValidationRules.InclusiveMaximum, "NumberOfExternalNodes", 10);
                }
                if (NumberOfExternalNodes < 1)
                {
                    throw new ValidationException(ValidationRules.InclusiveMinimum, "NumberOfExternalNodes", 1);
                }
            }
        }
    }
}
