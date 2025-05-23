// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Storage
{
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// FileServicesOperations operations.
    /// </summary>
    public partial interface IFileServicesOperations
    {
        /// <summary>
        /// List all file services in storage accounts
        /// </summary>
        /// <remarks>
        /// List all file services in storage accounts
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the user&#39;s subscription. The name is
        /// case insensitive.
        /// </param>
        /// <param name='accountName'>
        /// The name of the storage account within the specified resource group.
        /// Storage account names must be between 3 and 24 characters in length and use
        /// numbers and lower-case letters only.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<FileServiceItems>> ListWithHttpMessagesAsync(string resourceGroupName, string accountName, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Sets the properties of file services in storage accounts, including CORS
        /// (Cross-Origin Resource Sharing) rules.
        /// </summary>
        /// <remarks>
        /// Sets the properties of file services in storage accounts, including CORS
        /// (Cross-Origin Resource Sharing) rules.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the user&#39;s subscription. The name is
        /// case insensitive.
        /// </param>
        /// <param name='accountName'>
        /// The name of the storage account within the specified resource group.
        /// Storage account names must be between 3 and 24 characters in length and use
        /// numbers and lower-case letters only.
        /// </param>
        /// <param name='parameters'>
        /// The properties of file services in storage accounts, including CORS
        /// (Cross-Origin Resource Sharing) rules.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<FileServiceProperties>> SetServicePropertiesWithHttpMessagesAsync(string resourceGroupName, string accountName, FileServiceProperties parameters, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Gets the properties of file services in storage accounts, including CORS
        /// (Cross-Origin Resource Sharing) rules.
        /// </summary>
        /// <remarks>
        /// Gets the properties of file services in storage accounts, including CORS
        /// (Cross-Origin Resource Sharing) rules.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the user&#39;s subscription. The name is
        /// case insensitive.
        /// </param>
        /// <param name='accountName'>
        /// The name of the storage account within the specified resource group.
        /// Storage account names must be between 3 and 24 characters in length and use
        /// numbers and lower-case letters only.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<FileServiceProperties>> GetServicePropertiesWithHttpMessagesAsync(string resourceGroupName, string accountName, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Gets the usages of file service in storage account.
        /// </summary>
        /// <remarks>
        /// Gets the usages of file service in storage account.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the user&#39;s subscription. The name is
        /// case insensitive.
        /// </param>
        /// <param name='accountName'>
        /// The name of the storage account within the specified resource group.
        /// Storage account names must be between 3 and 24 characters in length and use
        /// numbers and lower-case letters only.
        /// </param>
        /// <param name='maxpagesize'>
        /// Optional, specifies the maximum number of file service usages to be
        /// included in the list response.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<Microsoft.Rest.Azure.IPage<FileServiceUsage>>> ListServiceUsagesWithHttpMessagesAsync(string resourceGroupName, string accountName, int? maxpagesize = default(int?), System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Gets the usage of file service in storage account including account limits,
        /// file share limits and constants used in recommendations and bursting
        /// formula.
        /// </summary>
        /// <remarks>
        /// Gets the usage of file service in storage account including account limits,
        /// file share limits and constants used in recommendations and bursting
        /// formula.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the user&#39;s subscription. The name is
        /// case insensitive.
        /// </param>
        /// <param name='accountName'>
        /// The name of the storage account within the specified resource group.
        /// Storage account names must be between 3 and 24 characters in length and use
        /// numbers and lower-case letters only.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<FileServiceUsage>> GetServiceUsageWithHttpMessagesAsync(string resourceGroupName, string accountName, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Gets the usages of file service in storage account.
        /// </summary>
        /// <remarks>
        /// Gets the usages of file service in storage account.
        /// </remarks>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<Microsoft.Rest.Azure.IPage<FileServiceUsage>>> ListServiceUsagesNextWithHttpMessagesAsync(string nextPageLink, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

    }
}