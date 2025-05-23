// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ImportExport.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ImportExport.Runtime.Extensions;

    /// <summary>Locations response</summary>
    public partial class LocationsResponse :
        Microsoft.Azure.PowerShell.Cmdlets.ImportExport.Models.ILocationsResponse,
        Microsoft.Azure.PowerShell.Cmdlets.ImportExport.Models.ILocationsResponseInternal
    {

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ImportExport.Models.ILocation> _value;

        /// <summary>locations</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ImportExport.Origin(Microsoft.Azure.PowerShell.Cmdlets.ImportExport.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ImportExport.Models.ILocation> Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="LocationsResponse" /> instance.</summary>
        public LocationsResponse()
        {

        }
    }
    /// Locations response
    public partial interface ILocationsResponse :
        Microsoft.Azure.PowerShell.Cmdlets.ImportExport.Runtime.IJsonSerializable
    {
        /// <summary>locations</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ImportExport.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"locations",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ImportExport.Models.ILocation) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ImportExport.Models.ILocation> Value { get; set; }

    }
    /// Locations response
    internal partial interface ILocationsResponseInternal

    {
        /// <summary>locations</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ImportExport.Models.ILocation> Value { get; set; }

    }
}