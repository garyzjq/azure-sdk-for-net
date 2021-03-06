// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Cdn
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// Extension methods for OriginsOperations.
    /// </summary>
    public static partial class OriginsOperationsExtensions
    {
            /// <summary>
            /// Lists the existing CDN origins within an endpoint.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='endpointName'>
            /// Name of the endpoint within the CDN profile.
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile within the resource group.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the Azure subscription.
            /// </param>
            public static IEnumerable<Origin> ListByEndpoint(this IOriginsOperations operations, string endpointName, string profileName, string resourceGroupName)
            {
                return Task.Factory.StartNew(s => ((IOriginsOperations)s).ListByEndpointAsync(endpointName, profileName, resourceGroupName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the existing CDN origins within an endpoint.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='endpointName'>
            /// Name of the endpoint within the CDN profile.
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile within the resource group.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the Azure subscription.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<Origin>> ListByEndpointAsync(this IOriginsOperations operations, string endpointName, string profileName, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByEndpointWithHttpMessagesAsync(endpointName, profileName, resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets an existing CDN origin within an endpoint.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='originName'>
            /// Name of the origin, an arbitrary value but it needs to be unique under
            /// endpoint
            /// </param>
            /// <param name='endpointName'>
            /// Name of the endpoint within the CDN profile.
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile within the resource group.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the Azure subscription.
            /// </param>
            public static Origin Get(this IOriginsOperations operations, string originName, string endpointName, string profileName, string resourceGroupName)
            {
                return Task.Factory.StartNew(s => ((IOriginsOperations)s).GetAsync(originName, endpointName, profileName, resourceGroupName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets an existing CDN origin within an endpoint.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='originName'>
            /// Name of the origin, an arbitrary value but it needs to be unique under
            /// endpoint
            /// </param>
            /// <param name='endpointName'>
            /// Name of the endpoint within the CDN profile.
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile within the resource group.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the Azure subscription.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Origin> GetAsync(this IOriginsOperations operations, string originName, string endpointName, string profileName, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(originName, endpointName, profileName, resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a new CDN origin within an endpoint.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='originName'>
            /// Name of the origin, an arbitrary value but it needs to be unique under
            /// endpoint
            /// </param>
            /// <param name='originProperties'>
            /// Origin properties
            /// </param>
            /// <param name='endpointName'>
            /// Name of the endpoint within the CDN profile.
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile within the resource group.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the Azure subscription.
            /// </param>
            public static Origin Create(this IOriginsOperations operations, string originName, OriginParameters originProperties, string endpointName, string profileName, string resourceGroupName)
            {
                return Task.Factory.StartNew(s => ((IOriginsOperations)s).CreateAsync(originName, originProperties, endpointName, profileName, resourceGroupName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a new CDN origin within an endpoint.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='originName'>
            /// Name of the origin, an arbitrary value but it needs to be unique under
            /// endpoint
            /// </param>
            /// <param name='originProperties'>
            /// Origin properties
            /// </param>
            /// <param name='endpointName'>
            /// Name of the endpoint within the CDN profile.
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile within the resource group.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the Azure subscription.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Origin> CreateAsync(this IOriginsOperations operations, string originName, OriginParameters originProperties, string endpointName, string profileName, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(originName, originProperties, endpointName, profileName, resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a new CDN origin within an endpoint.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='originName'>
            /// Name of the origin, an arbitrary value but it needs to be unique under
            /// endpoint
            /// </param>
            /// <param name='originProperties'>
            /// Origin properties
            /// </param>
            /// <param name='endpointName'>
            /// Name of the endpoint within the CDN profile.
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile within the resource group.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the Azure subscription.
            /// </param>
            public static Origin BeginCreate(this IOriginsOperations operations, string originName, OriginParameters originProperties, string endpointName, string profileName, string resourceGroupName)
            {
                return Task.Factory.StartNew(s => ((IOriginsOperations)s).BeginCreateAsync(originName, originProperties, endpointName, profileName, resourceGroupName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a new CDN origin within an endpoint.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='originName'>
            /// Name of the origin, an arbitrary value but it needs to be unique under
            /// endpoint
            /// </param>
            /// <param name='originProperties'>
            /// Origin properties
            /// </param>
            /// <param name='endpointName'>
            /// Name of the endpoint within the CDN profile.
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile within the resource group.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the Azure subscription.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Origin> BeginCreateAsync(this IOriginsOperations operations, string originName, OriginParameters originProperties, string endpointName, string profileName, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateWithHttpMessagesAsync(originName, originProperties, endpointName, profileName, resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates an existing CDN origin within an endpoint.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='originName'>
            /// Name of the origin. Must be unique within endpoint.
            /// </param>
            /// <param name='originProperties'>
            /// Origin properties
            /// </param>
            /// <param name='endpointName'>
            /// Name of the endpoint within the CDN profile.
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile within the resource group.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the Azure subscription.
            /// </param>
            public static Origin Update(this IOriginsOperations operations, string originName, OriginParameters originProperties, string endpointName, string profileName, string resourceGroupName)
            {
                return Task.Factory.StartNew(s => ((IOriginsOperations)s).UpdateAsync(originName, originProperties, endpointName, profileName, resourceGroupName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates an existing CDN origin within an endpoint.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='originName'>
            /// Name of the origin. Must be unique within endpoint.
            /// </param>
            /// <param name='originProperties'>
            /// Origin properties
            /// </param>
            /// <param name='endpointName'>
            /// Name of the endpoint within the CDN profile.
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile within the resource group.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the Azure subscription.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Origin> UpdateAsync(this IOriginsOperations operations, string originName, OriginParameters originProperties, string endpointName, string profileName, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(originName, originProperties, endpointName, profileName, resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates an existing CDN origin within an endpoint.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='originName'>
            /// Name of the origin. Must be unique within endpoint.
            /// </param>
            /// <param name='originProperties'>
            /// Origin properties
            /// </param>
            /// <param name='endpointName'>
            /// Name of the endpoint within the CDN profile.
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile within the resource group.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the Azure subscription.
            /// </param>
            public static Origin BeginUpdate(this IOriginsOperations operations, string originName, OriginParameters originProperties, string endpointName, string profileName, string resourceGroupName)
            {
                return Task.Factory.StartNew(s => ((IOriginsOperations)s).BeginUpdateAsync(originName, originProperties, endpointName, profileName, resourceGroupName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates an existing CDN origin within an endpoint.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='originName'>
            /// Name of the origin. Must be unique within endpoint.
            /// </param>
            /// <param name='originProperties'>
            /// Origin properties
            /// </param>
            /// <param name='endpointName'>
            /// Name of the endpoint within the CDN profile.
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile within the resource group.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the Azure subscription.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Origin> BeginUpdateAsync(this IOriginsOperations operations, string originName, OriginParameters originProperties, string endpointName, string profileName, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginUpdateWithHttpMessagesAsync(originName, originProperties, endpointName, profileName, resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes an existing CDN origin within an endpoint.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='originName'>
            /// Name of the origin. Must be unique within endpoint.
            /// </param>
            /// <param name='endpointName'>
            /// Name of the endpoint within the CDN profile.
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile within the resource group.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the Azure subscription.
            /// </param>
            public static Origin DeleteIfExists(this IOriginsOperations operations, string originName, string endpointName, string profileName, string resourceGroupName)
            {
                return Task.Factory.StartNew(s => ((IOriginsOperations)s).DeleteIfExistsAsync(originName, endpointName, profileName, resourceGroupName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes an existing CDN origin within an endpoint.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='originName'>
            /// Name of the origin. Must be unique within endpoint.
            /// </param>
            /// <param name='endpointName'>
            /// Name of the endpoint within the CDN profile.
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile within the resource group.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the Azure subscription.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Origin> DeleteIfExistsAsync(this IOriginsOperations operations, string originName, string endpointName, string profileName, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DeleteIfExistsWithHttpMessagesAsync(originName, endpointName, profileName, resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes an existing CDN origin within an endpoint.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='originName'>
            /// Name of the origin. Must be unique within endpoint.
            /// </param>
            /// <param name='endpointName'>
            /// Name of the endpoint within the CDN profile.
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile within the resource group.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the Azure subscription.
            /// </param>
            public static Origin BeginDeleteIfExists(this IOriginsOperations operations, string originName, string endpointName, string profileName, string resourceGroupName)
            {
                return Task.Factory.StartNew(s => ((IOriginsOperations)s).BeginDeleteIfExistsAsync(originName, endpointName, profileName, resourceGroupName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes an existing CDN origin within an endpoint.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='originName'>
            /// Name of the origin. Must be unique within endpoint.
            /// </param>
            /// <param name='endpointName'>
            /// Name of the endpoint within the CDN profile.
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile within the resource group.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the Azure subscription.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Origin> BeginDeleteIfExistsAsync(this IOriginsOperations operations, string originName, string endpointName, string profileName, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginDeleteIfExistsWithHttpMessagesAsync(originName, endpointName, profileName, resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
