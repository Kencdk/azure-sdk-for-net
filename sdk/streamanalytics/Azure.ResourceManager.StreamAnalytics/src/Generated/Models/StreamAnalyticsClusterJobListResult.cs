// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    /// <summary> A list of streaming jobs. Populated by a List operation. </summary>
    internal partial class StreamAnalyticsClusterJobListResult
    {
        /// <summary> Initializes a new instance of StreamAnalyticsClusterJobListResult. </summary>
        internal StreamAnalyticsClusterJobListResult()
        {
            Value = new ChangeTrackingList<StreamAnalyticsClusterJob>();
        }

        /// <summary> Initializes a new instance of StreamAnalyticsClusterJobListResult. </summary>
        /// <param name="value"> A list of streaming jobs. </param>
        /// <param name="nextLink"> The URL to fetch the next set of streaming jobs. </param>
        internal StreamAnalyticsClusterJobListResult(IReadOnlyList<StreamAnalyticsClusterJob> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> A list of streaming jobs. </summary>
        public IReadOnlyList<StreamAnalyticsClusterJob> Value { get; }
        /// <summary> The URL to fetch the next set of streaming jobs. </summary>
        public string NextLink { get; }
    }
}
