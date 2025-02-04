// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.NetworkCloud;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    /// <summary> TrunkedNetworkList represents a list of trunked networks. </summary>
    internal partial class TrunkedNetworkList
    {
        /// <summary> Initializes a new instance of TrunkedNetworkList. </summary>
        internal TrunkedNetworkList()
        {
            Value = new ChangeTrackingList<TrunkedNetworkData>();
        }

        /// <summary> Initializes a new instance of TrunkedNetworkList. </summary>
        /// <param name="nextLink"> The link used to get the next page of operations. </param>
        /// <param name="value"> The list of trunked networks. </param>
        internal TrunkedNetworkList(string nextLink, IReadOnlyList<TrunkedNetworkData> value)
        {
            NextLink = nextLink;
            Value = value;
        }

        /// <summary> The link used to get the next page of operations. </summary>
        public string NextLink { get; }
        /// <summary> The list of trunked networks. </summary>
        public IReadOnlyList<TrunkedNetworkData> Value { get; }
    }
}
