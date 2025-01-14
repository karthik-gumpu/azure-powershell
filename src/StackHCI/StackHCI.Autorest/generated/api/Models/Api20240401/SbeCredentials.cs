// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Extensions;

    /// <summary>secrets used for solution builder extension (SBE) partner extensibility.</summary>
    public partial class SbeCredentials :
        Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.ISbeCredentials,
        Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.ISbeCredentialsInternal
    {

        /// <summary>Backing field for <see cref="EceSecretName" /> property.</summary>
        private string _eceSecretName;

        /// <summary>secret name expected for Enterprise Cloud Engine (ECE).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Origin(Microsoft.Azure.PowerShell.Cmdlets.StackHCI.PropertyOrigin.Owned)]
        public string EceSecretName { get => this._eceSecretName; set => this._eceSecretName = value; }

        /// <summary>Backing field for <see cref="SecretLocation" /> property.</summary>
        private string _secretLocation;

        /// <summary>secret URI stored in keyvault.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Origin(Microsoft.Azure.PowerShell.Cmdlets.StackHCI.PropertyOrigin.Owned)]
        public string SecretLocation { get => this._secretLocation; set => this._secretLocation = value; }

        /// <summary>Backing field for <see cref="SecretName" /> property.</summary>
        private string _secretName;

        /// <summary>secret name stored in keyvault.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Origin(Microsoft.Azure.PowerShell.Cmdlets.StackHCI.PropertyOrigin.Owned)]
        public string SecretName { get => this._secretName; set => this._secretName = value; }

        /// <summary>Creates an new <see cref="SbeCredentials" /> instance.</summary>
        public SbeCredentials()
        {

        }
    }
    /// secrets used for solution builder extension (SBE) partner extensibility.
    public partial interface ISbeCredentials :
        Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.IJsonSerializable
    {
        /// <summary>secret name expected for Enterprise Cloud Engine (ECE).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"secret name expected for Enterprise Cloud Engine (ECE).",
        SerializedName = @"eceSecretName",
        PossibleTypes = new [] { typeof(string) })]
        string EceSecretName { get; set; }
        /// <summary>secret URI stored in keyvault.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"secret URI stored in keyvault.",
        SerializedName = @"secretLocation",
        PossibleTypes = new [] { typeof(string) })]
        string SecretLocation { get; set; }
        /// <summary>secret name stored in keyvault.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"secret name stored in keyvault.",
        SerializedName = @"secretName",
        PossibleTypes = new [] { typeof(string) })]
        string SecretName { get; set; }

    }
    /// secrets used for solution builder extension (SBE) partner extensibility.
    internal partial interface ISbeCredentialsInternal

    {
        /// <summary>secret name expected for Enterprise Cloud Engine (ECE).</summary>
        string EceSecretName { get; set; }
        /// <summary>secret URI stored in keyvault.</summary>
        string SecretLocation { get; set; }
        /// <summary>secret name stored in keyvault.</summary>
        string SecretName { get; set; }

    }
}