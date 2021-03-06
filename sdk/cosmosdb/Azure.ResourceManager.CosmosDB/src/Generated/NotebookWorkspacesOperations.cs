// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.CosmosDB.Models;

namespace Azure.ResourceManager.CosmosDB
{
    /// <summary> The NotebookWorkspaces service client. </summary>
    public partial class NotebookWorkspacesOperations
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal NotebookWorkspacesRestOperations RestClient { get; }
        /// <summary> Initializes a new instance of NotebookWorkspacesOperations for mocking. </summary>
        protected NotebookWorkspacesOperations()
        {
        }
        /// <summary> Initializes a new instance of NotebookWorkspacesOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="endpoint"> server parameter. </param>
        internal NotebookWorkspacesOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null)
        {
            RestClient = new NotebookWorkspacesRestOperations(clientDiagnostics, pipeline, subscriptionId, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Gets the notebook workspace for a Cosmos DB account. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="accountName"> Cosmos DB database account name. </param>
        /// <param name="notebookWorkspaceName"> The name of the notebook workspace resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<NotebookWorkspace>> GetAsync(string resourceGroupName, string accountName, NotebookWorkspaceName notebookWorkspaceName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("NotebookWorkspacesOperations.Get");
            scope.Start();
            try
            {
                return await RestClient.GetAsync(resourceGroupName, accountName, notebookWorkspaceName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the notebook workspace for a Cosmos DB account. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="accountName"> Cosmos DB database account name. </param>
        /// <param name="notebookWorkspaceName"> The name of the notebook workspace resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<NotebookWorkspace> Get(string resourceGroupName, string accountName, NotebookWorkspaceName notebookWorkspaceName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("NotebookWorkspacesOperations.Get");
            scope.Start();
            try
            {
                return RestClient.Get(resourceGroupName, accountName, notebookWorkspaceName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Retrieves the connection info for the notebook workspace. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="accountName"> Cosmos DB database account name. </param>
        /// <param name="notebookWorkspaceName"> The name of the notebook workspace resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<NotebookWorkspaceConnectionInfoResult>> ListConnectionInfoAsync(string resourceGroupName, string accountName, NotebookWorkspaceName notebookWorkspaceName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("NotebookWorkspacesOperations.ListConnectionInfo");
            scope.Start();
            try
            {
                return await RestClient.ListConnectionInfoAsync(resourceGroupName, accountName, notebookWorkspaceName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Retrieves the connection info for the notebook workspace. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="accountName"> Cosmos DB database account name. </param>
        /// <param name="notebookWorkspaceName"> The name of the notebook workspace resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<NotebookWorkspaceConnectionInfoResult> ListConnectionInfo(string resourceGroupName, string accountName, NotebookWorkspaceName notebookWorkspaceName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("NotebookWorkspacesOperations.ListConnectionInfo");
            scope.Start();
            try
            {
                return RestClient.ListConnectionInfo(resourceGroupName, accountName, notebookWorkspaceName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the notebook workspace resources of an existing Cosmos DB account. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="accountName"> Cosmos DB database account name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="accountName"/> is null. </exception>
        public virtual AsyncPageable<NotebookWorkspace> ListByDatabaseAccountAsync(string resourceGroupName, string accountName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (accountName == null)
            {
                throw new ArgumentNullException(nameof(accountName));
            }

            async Task<Page<NotebookWorkspace>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("NotebookWorkspacesOperations.ListByDatabaseAccount");
                scope.Start();
                try
                {
                    var response = await RestClient.ListByDatabaseAccountAsync(resourceGroupName, accountName, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// <summary> Gets the notebook workspace resources of an existing Cosmos DB account. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="accountName"> Cosmos DB database account name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="accountName"/> is null. </exception>
        public virtual Pageable<NotebookWorkspace> ListByDatabaseAccount(string resourceGroupName, string accountName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (accountName == null)
            {
                throw new ArgumentNullException(nameof(accountName));
            }

            Page<NotebookWorkspace> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("NotebookWorkspacesOperations.ListByDatabaseAccount");
                scope.Start();
                try
                {
                    var response = RestClient.ListByDatabaseAccount(resourceGroupName, accountName, cancellationToken);
                    return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// <summary> Creates the notebook workspace for a Cosmos DB account. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="accountName"> Cosmos DB database account name. </param>
        /// <param name="notebookWorkspaceName"> The name of the notebook workspace resource. </param>
        /// <param name="notebookCreateUpdateParameters"> The notebook workspace to create for the current database account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="accountName"/>, or <paramref name="notebookCreateUpdateParameters"/> is null. </exception>
        public virtual async Task<NotebookWorkspacesCreateOrUpdateOperation> StartCreateOrUpdateAsync(string resourceGroupName, string accountName, NotebookWorkspaceName notebookWorkspaceName, ARMProxyResource notebookCreateUpdateParameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (accountName == null)
            {
                throw new ArgumentNullException(nameof(accountName));
            }
            if (notebookCreateUpdateParameters == null)
            {
                throw new ArgumentNullException(nameof(notebookCreateUpdateParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("NotebookWorkspacesOperations.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.CreateOrUpdateAsync(resourceGroupName, accountName, notebookWorkspaceName, notebookCreateUpdateParameters, cancellationToken).ConfigureAwait(false);
                return new NotebookWorkspacesCreateOrUpdateOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateOrUpdateRequest(resourceGroupName, accountName, notebookWorkspaceName, notebookCreateUpdateParameters).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates the notebook workspace for a Cosmos DB account. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="accountName"> Cosmos DB database account name. </param>
        /// <param name="notebookWorkspaceName"> The name of the notebook workspace resource. </param>
        /// <param name="notebookCreateUpdateParameters"> The notebook workspace to create for the current database account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="accountName"/>, or <paramref name="notebookCreateUpdateParameters"/> is null. </exception>
        public virtual NotebookWorkspacesCreateOrUpdateOperation StartCreateOrUpdate(string resourceGroupName, string accountName, NotebookWorkspaceName notebookWorkspaceName, ARMProxyResource notebookCreateUpdateParameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (accountName == null)
            {
                throw new ArgumentNullException(nameof(accountName));
            }
            if (notebookCreateUpdateParameters == null)
            {
                throw new ArgumentNullException(nameof(notebookCreateUpdateParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("NotebookWorkspacesOperations.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var originalResponse = RestClient.CreateOrUpdate(resourceGroupName, accountName, notebookWorkspaceName, notebookCreateUpdateParameters, cancellationToken);
                return new NotebookWorkspacesCreateOrUpdateOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateOrUpdateRequest(resourceGroupName, accountName, notebookWorkspaceName, notebookCreateUpdateParameters).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes the notebook workspace for a Cosmos DB account. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="accountName"> Cosmos DB database account name. </param>
        /// <param name="notebookWorkspaceName"> The name of the notebook workspace resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="accountName"/> is null. </exception>
        public virtual async Task<NotebookWorkspacesDeleteOperation> StartDeleteAsync(string resourceGroupName, string accountName, NotebookWorkspaceName notebookWorkspaceName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (accountName == null)
            {
                throw new ArgumentNullException(nameof(accountName));
            }

            using var scope = _clientDiagnostics.CreateScope("NotebookWorkspacesOperations.StartDelete");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.DeleteAsync(resourceGroupName, accountName, notebookWorkspaceName, cancellationToken).ConfigureAwait(false);
                return new NotebookWorkspacesDeleteOperation(_clientDiagnostics, _pipeline, RestClient.CreateDeleteRequest(resourceGroupName, accountName, notebookWorkspaceName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes the notebook workspace for a Cosmos DB account. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="accountName"> Cosmos DB database account name. </param>
        /// <param name="notebookWorkspaceName"> The name of the notebook workspace resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="accountName"/> is null. </exception>
        public virtual NotebookWorkspacesDeleteOperation StartDelete(string resourceGroupName, string accountName, NotebookWorkspaceName notebookWorkspaceName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (accountName == null)
            {
                throw new ArgumentNullException(nameof(accountName));
            }

            using var scope = _clientDiagnostics.CreateScope("NotebookWorkspacesOperations.StartDelete");
            scope.Start();
            try
            {
                var originalResponse = RestClient.Delete(resourceGroupName, accountName, notebookWorkspaceName, cancellationToken);
                return new NotebookWorkspacesDeleteOperation(_clientDiagnostics, _pipeline, RestClient.CreateDeleteRequest(resourceGroupName, accountName, notebookWorkspaceName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Regenerates the auth token for the notebook workspace. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="accountName"> Cosmos DB database account name. </param>
        /// <param name="notebookWorkspaceName"> The name of the notebook workspace resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="accountName"/> is null. </exception>
        public virtual async Task<NotebookWorkspacesRegenerateAuthTokenOperation> StartRegenerateAuthTokenAsync(string resourceGroupName, string accountName, NotebookWorkspaceName notebookWorkspaceName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (accountName == null)
            {
                throw new ArgumentNullException(nameof(accountName));
            }

            using var scope = _clientDiagnostics.CreateScope("NotebookWorkspacesOperations.StartRegenerateAuthToken");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.RegenerateAuthTokenAsync(resourceGroupName, accountName, notebookWorkspaceName, cancellationToken).ConfigureAwait(false);
                return new NotebookWorkspacesRegenerateAuthTokenOperation(_clientDiagnostics, _pipeline, RestClient.CreateRegenerateAuthTokenRequest(resourceGroupName, accountName, notebookWorkspaceName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Regenerates the auth token for the notebook workspace. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="accountName"> Cosmos DB database account name. </param>
        /// <param name="notebookWorkspaceName"> The name of the notebook workspace resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="accountName"/> is null. </exception>
        public virtual NotebookWorkspacesRegenerateAuthTokenOperation StartRegenerateAuthToken(string resourceGroupName, string accountName, NotebookWorkspaceName notebookWorkspaceName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (accountName == null)
            {
                throw new ArgumentNullException(nameof(accountName));
            }

            using var scope = _clientDiagnostics.CreateScope("NotebookWorkspacesOperations.StartRegenerateAuthToken");
            scope.Start();
            try
            {
                var originalResponse = RestClient.RegenerateAuthToken(resourceGroupName, accountName, notebookWorkspaceName, cancellationToken);
                return new NotebookWorkspacesRegenerateAuthTokenOperation(_clientDiagnostics, _pipeline, RestClient.CreateRegenerateAuthTokenRequest(resourceGroupName, accountName, notebookWorkspaceName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Starts the notebook workspace. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="accountName"> Cosmos DB database account name. </param>
        /// <param name="notebookWorkspaceName"> The name of the notebook workspace resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="accountName"/> is null. </exception>
        public virtual async Task<NotebookWorkspacesStartOperation> StartStartAsync(string resourceGroupName, string accountName, NotebookWorkspaceName notebookWorkspaceName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (accountName == null)
            {
                throw new ArgumentNullException(nameof(accountName));
            }

            using var scope = _clientDiagnostics.CreateScope("NotebookWorkspacesOperations.StartStart");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.StartAsync(resourceGroupName, accountName, notebookWorkspaceName, cancellationToken).ConfigureAwait(false);
                return new NotebookWorkspacesStartOperation(_clientDiagnostics, _pipeline, RestClient.CreateStartRequest(resourceGroupName, accountName, notebookWorkspaceName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Starts the notebook workspace. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="accountName"> Cosmos DB database account name. </param>
        /// <param name="notebookWorkspaceName"> The name of the notebook workspace resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="accountName"/> is null. </exception>
        public virtual NotebookWorkspacesStartOperation StartStart(string resourceGroupName, string accountName, NotebookWorkspaceName notebookWorkspaceName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (accountName == null)
            {
                throw new ArgumentNullException(nameof(accountName));
            }

            using var scope = _clientDiagnostics.CreateScope("NotebookWorkspacesOperations.StartStart");
            scope.Start();
            try
            {
                var originalResponse = RestClient.Start(resourceGroupName, accountName, notebookWorkspaceName, cancellationToken);
                return new NotebookWorkspacesStartOperation(_clientDiagnostics, _pipeline, RestClient.CreateStartRequest(resourceGroupName, accountName, notebookWorkspaceName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
