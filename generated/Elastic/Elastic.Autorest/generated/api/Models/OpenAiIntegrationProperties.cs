// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.Extensions;

    /// <summary>Open AI Integration details.</summary>
    public partial class OpenAiIntegrationProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IOpenAiIntegrationProperties,
        Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IOpenAiIntegrationPropertiesInternal
    {

        /// <summary>Backing field for <see cref="Key" /> property.</summary>
        private string _key;

        /// <summary>Value of API key for Open AI resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Elastic.Origin(Microsoft.Azure.PowerShell.Cmdlets.Elastic.PropertyOrigin.Owned)]
        public string Key { get => this._key; set => this._key = value; }

        /// <summary>Backing field for <see cref="LastRefreshAt" /> property.</summary>
        private global::System.DateTime? _lastRefreshAt;

        /// <summary>Last Update Timestamp for key updation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Elastic.Origin(Microsoft.Azure.PowerShell.Cmdlets.Elastic.PropertyOrigin.Owned)]
        public global::System.DateTime? LastRefreshAt { get => this._lastRefreshAt; }

        /// <summary>Internal Acessors for LastRefreshAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IOpenAiIntegrationPropertiesInternal.LastRefreshAt { get => this._lastRefreshAt; set { {_lastRefreshAt = value;} } }

        /// <summary>Backing field for <see cref="OpenAiResourceEndpoint" /> property.</summary>
        private string _openAiResourceEndpoint;

        /// <summary>The API endpoint for Open AI resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Elastic.Origin(Microsoft.Azure.PowerShell.Cmdlets.Elastic.PropertyOrigin.Owned)]
        public string OpenAiResourceEndpoint { get => this._openAiResourceEndpoint; set => this._openAiResourceEndpoint = value; }

        /// <summary>Backing field for <see cref="OpenAiResourceId" /> property.</summary>
        private string _openAiResourceId;

        /// <summary>The resource name of Open AI resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Elastic.Origin(Microsoft.Azure.PowerShell.Cmdlets.Elastic.PropertyOrigin.Owned)]
        public string OpenAiResourceId { get => this._openAiResourceId; set => this._openAiResourceId = value; }

        /// <summary>Creates an new <see cref="OpenAiIntegrationProperties" /> instance.</summary>
        public OpenAiIntegrationProperties()
        {

        }
    }
    /// Open AI Integration details.
    public partial interface IOpenAiIntegrationProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.IJsonSerializable
    {
        /// <summary>Value of API key for Open AI resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Value of API key for Open AI resource",
        SerializedName = @"key",
        PossibleTypes = new [] { typeof(string) })]
        string Key { get; set; }
        /// <summary>Last Update Timestamp for key updation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Last Update Timestamp for key updation",
        SerializedName = @"lastRefreshAt",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? LastRefreshAt { get;  }
        /// <summary>The API endpoint for Open AI resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The API endpoint for Open AI resource",
        SerializedName = @"openAIResourceEndpoint",
        PossibleTypes = new [] { typeof(string) })]
        string OpenAiResourceEndpoint { get; set; }
        /// <summary>The resource name of Open AI resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The resource name of Open AI resource",
        SerializedName = @"openAIResourceId",
        PossibleTypes = new [] { typeof(string) })]
        string OpenAiResourceId { get; set; }

    }
    /// Open AI Integration details.
    internal partial interface IOpenAiIntegrationPropertiesInternal

    {
        /// <summary>Value of API key for Open AI resource</summary>
        string Key { get; set; }
        /// <summary>Last Update Timestamp for key updation</summary>
        global::System.DateTime? LastRefreshAt { get; set; }
        /// <summary>The API endpoint for Open AI resource</summary>
        string OpenAiResourceEndpoint { get; set; }
        /// <summary>The resource name of Open AI resource</summary>
        string OpenAiResourceId { get; set; }

    }
}