// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ManagedNetworkFabric;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    /// <summary> List of NetworkInterfaces. </summary>
    internal partial class NetworkInterfacesList
    {
        /// <summary> Initializes a new instance of NetworkInterfacesList. </summary>
        internal NetworkInterfacesList()
        {
            Value = new ChangeTrackingList<NetworkInterfaceData>();
        }

        /// <summary> Initializes a new instance of NetworkInterfacesList. </summary>
        /// <param name="value"> List of NetworkInterfaces resources. </param>
        /// <param name="nextLink"> Url to follow for getting next page of resources. </param>
        internal NetworkInterfacesList(IReadOnlyList<NetworkInterfaceData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> List of NetworkInterfaces resources. </summary>
        public IReadOnlyList<NetworkInterfaceData> Value { get; }
        /// <summary> Url to follow for getting next page of resources. </summary>
        public string NextLink { get; }
    }
}
