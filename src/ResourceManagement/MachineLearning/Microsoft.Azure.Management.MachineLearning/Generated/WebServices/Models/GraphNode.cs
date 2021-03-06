// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.MachineLearning.WebServices.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Specifies a node in the web service graph. The node can either be an
    /// input, output or asset node, so only one of the corresponding id
    /// properties is populated at any given time.
    /// </summary>
    public partial class GraphNode
    {
        /// <summary>
        /// Initializes a new instance of the GraphNode class.
        /// </summary>
        public GraphNode() { }

        /// <summary>
        /// Initializes a new instance of the GraphNode class.
        /// </summary>
        public GraphNode(string assetId = default(string), string inputId = default(string), string outputId = default(string), IDictionary<string, string> parameters = default(IDictionary<string, string>))
        {
            AssetId = assetId;
            InputId = inputId;
            OutputId = outputId;
            Parameters = parameters;
        }

        /// <summary>
        /// The id of the asset represented by this node.
        /// </summary>
        [JsonProperty(PropertyName = "assetId")]
        public string AssetId { get; set; }

        /// <summary>
        /// The id of the input element represented by this node.
        /// </summary>
        [JsonProperty(PropertyName = "inputId")]
        public string InputId { get; set; }

        /// <summary>
        /// The id of the output element represented by this node.
        /// </summary>
        [JsonProperty(PropertyName = "outputId")]
        public string OutputId { get; set; }

        /// <summary>
        /// If applicable, parameters of the node. Global graph parameters map
        /// into these, with values set at runtime.
        /// </summary>
        [JsonProperty(PropertyName = "parameters")]
        public IDictionary<string, string> Parameters { get; set; }

    }
}
