// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Extensions;

    /// <summary>Request body of Stop protection when MUA is Enabled</summary>
    public partial class StopProtectionRequest :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IStopProtectionRequest,
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IStopProtectionRequestInternal
    {

        /// <summary>Backing field for <see cref="ResourceGuardOperationRequest" /> property.</summary>
        private string[] _resourceGuardOperationRequest;

        /// <summary>ResourceGuardOperationRequests on which LAC check will be performed</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Owned)]
        public string[] ResourceGuardOperationRequest { get => this._resourceGuardOperationRequest; set => this._resourceGuardOperationRequest = value; }

        /// <summary>Creates an new <see cref="StopProtectionRequest" /> instance.</summary>
        public StopProtectionRequest()
        {

        }
    }
    /// Request body of Stop protection when MUA is Enabled
    public partial interface IStopProtectionRequest :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.IJsonSerializable
    {
        /// <summary>ResourceGuardOperationRequests on which LAC check will be performed</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"ResourceGuardOperationRequests on which LAC check will be performed",
        SerializedName = @"resourceGuardOperationRequests",
        PossibleTypes = new [] { typeof(string) })]
        string[] ResourceGuardOperationRequest { get; set; }

    }
    /// Request body of Stop protection when MUA is Enabled
    internal partial interface IStopProtectionRequestInternal

    {
        /// <summary>ResourceGuardOperationRequests on which LAC check will be performed</summary>
        string[] ResourceGuardOperationRequest { get; set; }

    }
}