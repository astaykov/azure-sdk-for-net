// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.HybridContainerService
{
    /// <summary>
    /// A class representing a collection of <see cref="HybridIdentityMetadataResource" /> and their operations.
    /// Each <see cref="HybridIdentityMetadataResource" /> in the collection will belong to the same instance of <see cref="ProvisionedClusterResource" />.
    /// To get a <see cref="HybridIdentityMetadataCollection" /> instance call the GetHybridIdentityMetadata method from an instance of <see cref="ProvisionedClusterResource" />.
    /// </summary>
    public partial class HybridIdentityMetadataCollection : ArmCollection, IEnumerable<HybridIdentityMetadataResource>, IAsyncEnumerable<HybridIdentityMetadataResource>
    {
        private readonly ClientDiagnostics _hybridIdentityMetadataHybridIdentityMetadataClientDiagnostics;
        private readonly HybridIdentityMetadataRestOperations _hybridIdentityMetadataHybridIdentityMetadataRestClient;

        /// <summary> Initializes a new instance of the <see cref="HybridIdentityMetadataCollection"/> class for mocking. </summary>
        protected HybridIdentityMetadataCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="HybridIdentityMetadataCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal HybridIdentityMetadataCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _hybridIdentityMetadataHybridIdentityMetadataClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.HybridContainerService", HybridIdentityMetadataResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(HybridIdentityMetadataResource.ResourceType, out string hybridIdentityMetadataHybridIdentityMetadataApiVersion);
            _hybridIdentityMetadataHybridIdentityMetadataRestClient = new HybridIdentityMetadataRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, hybridIdentityMetadataHybridIdentityMetadataApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ProvisionedClusterResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ProvisionedClusterResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates the hybrid identity metadata proxy resource that facilitates the managed identity provisioning.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridContainerService/provisionedClusters/{provisionedClustersName}/hybridIdentityMetadata/{hybridIdentityMetadataResourceName}
        /// Operation Id: HybridIdentityMetadata_Put
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="hybridIdentityMetadataResourceName"> Parameter for the name of the hybrid identity metadata resource. </param>
        /// <param name="data"> The HybridIdentityMetadata to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hybridIdentityMetadataResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="hybridIdentityMetadataResourceName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<HybridIdentityMetadataResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string hybridIdentityMetadataResourceName, HybridIdentityMetadataData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(hybridIdentityMetadataResourceName, nameof(hybridIdentityMetadataResourceName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _hybridIdentityMetadataHybridIdentityMetadataClientDiagnostics.CreateScope("HybridIdentityMetadataCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _hybridIdentityMetadataHybridIdentityMetadataRestClient.PutAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, hybridIdentityMetadataResourceName, data, cancellationToken).ConfigureAwait(false);
                var operation = new HybridContainerServiceArmOperation<HybridIdentityMetadataResource>(Response.FromValue(new HybridIdentityMetadataResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates the hybrid identity metadata proxy resource that facilitates the managed identity provisioning.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridContainerService/provisionedClusters/{provisionedClustersName}/hybridIdentityMetadata/{hybridIdentityMetadataResourceName}
        /// Operation Id: HybridIdentityMetadata_Put
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="hybridIdentityMetadataResourceName"> Parameter for the name of the hybrid identity metadata resource. </param>
        /// <param name="data"> The HybridIdentityMetadata to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hybridIdentityMetadataResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="hybridIdentityMetadataResourceName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<HybridIdentityMetadataResource> CreateOrUpdate(WaitUntil waitUntil, string hybridIdentityMetadataResourceName, HybridIdentityMetadataData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(hybridIdentityMetadataResourceName, nameof(hybridIdentityMetadataResourceName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _hybridIdentityMetadataHybridIdentityMetadataClientDiagnostics.CreateScope("HybridIdentityMetadataCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _hybridIdentityMetadataHybridIdentityMetadataRestClient.Put(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, hybridIdentityMetadataResourceName, data, cancellationToken);
                var operation = new HybridContainerServiceArmOperation<HybridIdentityMetadataResource>(Response.FromValue(new HybridIdentityMetadataResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the hybrid identity metadata proxy resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridContainerService/provisionedClusters/{provisionedClustersName}/hybridIdentityMetadata/{hybridIdentityMetadataResourceName}
        /// Operation Id: HybridIdentityMetadata_Get
        /// </summary>
        /// <param name="hybridIdentityMetadataResourceName"> Parameter for the name of the hybrid identity metadata resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hybridIdentityMetadataResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="hybridIdentityMetadataResourceName"/> is null. </exception>
        public virtual async Task<Response<HybridIdentityMetadataResource>> GetAsync(string hybridIdentityMetadataResourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(hybridIdentityMetadataResourceName, nameof(hybridIdentityMetadataResourceName));

            using var scope = _hybridIdentityMetadataHybridIdentityMetadataClientDiagnostics.CreateScope("HybridIdentityMetadataCollection.Get");
            scope.Start();
            try
            {
                var response = await _hybridIdentityMetadataHybridIdentityMetadataRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, hybridIdentityMetadataResourceName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new HybridIdentityMetadataResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the hybrid identity metadata proxy resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridContainerService/provisionedClusters/{provisionedClustersName}/hybridIdentityMetadata/{hybridIdentityMetadataResourceName}
        /// Operation Id: HybridIdentityMetadata_Get
        /// </summary>
        /// <param name="hybridIdentityMetadataResourceName"> Parameter for the name of the hybrid identity metadata resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hybridIdentityMetadataResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="hybridIdentityMetadataResourceName"/> is null. </exception>
        public virtual Response<HybridIdentityMetadataResource> Get(string hybridIdentityMetadataResourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(hybridIdentityMetadataResourceName, nameof(hybridIdentityMetadataResourceName));

            using var scope = _hybridIdentityMetadataHybridIdentityMetadataClientDiagnostics.CreateScope("HybridIdentityMetadataCollection.Get");
            scope.Start();
            try
            {
                var response = _hybridIdentityMetadataHybridIdentityMetadataRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, hybridIdentityMetadataResourceName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new HybridIdentityMetadataResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists the hybrid identity metadata proxy resource in a cluster.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridContainerService/provisionedClusters/{provisionedClustersName}/hybridIdentityMetadata
        /// Operation Id: HybridIdentityMetadata_ListByCluster
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="HybridIdentityMetadataResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<HybridIdentityMetadataResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<HybridIdentityMetadataResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _hybridIdentityMetadataHybridIdentityMetadataClientDiagnostics.CreateScope("HybridIdentityMetadataCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _hybridIdentityMetadataHybridIdentityMetadataRestClient.ListByClusterAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new HybridIdentityMetadataResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<HybridIdentityMetadataResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _hybridIdentityMetadataHybridIdentityMetadataClientDiagnostics.CreateScope("HybridIdentityMetadataCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _hybridIdentityMetadataHybridIdentityMetadataRestClient.ListByClusterNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new HybridIdentityMetadataResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Lists the hybrid identity metadata proxy resource in a cluster.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridContainerService/provisionedClusters/{provisionedClustersName}/hybridIdentityMetadata
        /// Operation Id: HybridIdentityMetadata_ListByCluster
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="HybridIdentityMetadataResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<HybridIdentityMetadataResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<HybridIdentityMetadataResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _hybridIdentityMetadataHybridIdentityMetadataClientDiagnostics.CreateScope("HybridIdentityMetadataCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _hybridIdentityMetadataHybridIdentityMetadataRestClient.ListByCluster(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new HybridIdentityMetadataResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<HybridIdentityMetadataResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _hybridIdentityMetadataHybridIdentityMetadataClientDiagnostics.CreateScope("HybridIdentityMetadataCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _hybridIdentityMetadataHybridIdentityMetadataRestClient.ListByClusterNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new HybridIdentityMetadataResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridContainerService/provisionedClusters/{provisionedClustersName}/hybridIdentityMetadata/{hybridIdentityMetadataResourceName}
        /// Operation Id: HybridIdentityMetadata_Get
        /// </summary>
        /// <param name="hybridIdentityMetadataResourceName"> Parameter for the name of the hybrid identity metadata resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hybridIdentityMetadataResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="hybridIdentityMetadataResourceName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string hybridIdentityMetadataResourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(hybridIdentityMetadataResourceName, nameof(hybridIdentityMetadataResourceName));

            using var scope = _hybridIdentityMetadataHybridIdentityMetadataClientDiagnostics.CreateScope("HybridIdentityMetadataCollection.Exists");
            scope.Start();
            try
            {
                var response = await _hybridIdentityMetadataHybridIdentityMetadataRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, hybridIdentityMetadataResourceName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridContainerService/provisionedClusters/{provisionedClustersName}/hybridIdentityMetadata/{hybridIdentityMetadataResourceName}
        /// Operation Id: HybridIdentityMetadata_Get
        /// </summary>
        /// <param name="hybridIdentityMetadataResourceName"> Parameter for the name of the hybrid identity metadata resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hybridIdentityMetadataResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="hybridIdentityMetadataResourceName"/> is null. </exception>
        public virtual Response<bool> Exists(string hybridIdentityMetadataResourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(hybridIdentityMetadataResourceName, nameof(hybridIdentityMetadataResourceName));

            using var scope = _hybridIdentityMetadataHybridIdentityMetadataClientDiagnostics.CreateScope("HybridIdentityMetadataCollection.Exists");
            scope.Start();
            try
            {
                var response = _hybridIdentityMetadataHybridIdentityMetadataRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, hybridIdentityMetadataResourceName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<HybridIdentityMetadataResource> IEnumerable<HybridIdentityMetadataResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<HybridIdentityMetadataResource> IAsyncEnumerable<HybridIdentityMetadataResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
