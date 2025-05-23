// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.Extensions;

    /// <summary>Reservation refund details</summary>
    public partial class ReservationToExchange :
        Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationToExchange,
        Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationToExchangeInternal
    {

        /// <summary>Backing field for <see cref="BillingInformation" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IBillingInformation _billingInformation;

        /// <summary>billing information</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Origin(Microsoft.Azure.PowerShell.Cmdlets.Reservations.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IBillingInformation BillingInformation { get => (this._billingInformation = this._billingInformation ?? new Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.BillingInformation()); set => this._billingInformation = value; }

        /// <summary>Backing field for <see cref="BillingRefundAmount" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IPrice _billingRefundAmount;

        /// <summary>Pricing information containing the amount and the currency code</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Origin(Microsoft.Azure.PowerShell.Cmdlets.Reservations.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IPrice BillingRefundAmount { get => (this._billingRefundAmount = this._billingRefundAmount ?? new Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Price()); set => this._billingRefundAmount = value; }

        /// <summary>Backing field for <see cref="Quantity" /> property.</summary>
        private int? _quantity;

        /// <summary>Quantity to be returned</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Origin(Microsoft.Azure.PowerShell.Cmdlets.Reservations.PropertyOrigin.Owned)]
        public int? Quantity { get => this._quantity; set => this._quantity = value; }

        /// <summary>Backing field for <see cref="ReservationId" /> property.</summary>
        private string _reservationId;

        /// <summary>Fully qualified id of the reservation being returned.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Origin(Microsoft.Azure.PowerShell.Cmdlets.Reservations.PropertyOrigin.Owned)]
        public string ReservationId { get => this._reservationId; set => this._reservationId = value; }

        /// <summary>Creates an new <see cref="ReservationToExchange" /> instance.</summary>
        public ReservationToExchange()
        {

        }
    }
    /// Reservation refund details
    public partial interface IReservationToExchange :
        Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.IJsonSerializable
    {
        /// <summary>billing information</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"billing information",
        SerializedName = @"billingInformation",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IBillingInformation) })]
        Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IBillingInformation BillingInformation { get; set; }
        /// <summary>Pricing information containing the amount and the currency code</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Pricing information containing the amount and the currency code",
        SerializedName = @"billingRefundAmount",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IPrice) })]
        Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IPrice BillingRefundAmount { get; set; }
        /// <summary>Quantity to be returned</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Quantity to be returned",
        SerializedName = @"quantity",
        PossibleTypes = new [] { typeof(int) })]
        int? Quantity { get; set; }
        /// <summary>Fully qualified id of the reservation being returned.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Fully qualified id of the reservation being returned.",
        SerializedName = @"reservationId",
        PossibleTypes = new [] { typeof(string) })]
        string ReservationId { get; set; }

    }
    /// Reservation refund details
    internal partial interface IReservationToExchangeInternal

    {
        /// <summary>billing information</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IBillingInformation BillingInformation { get; set; }
        /// <summary>Pricing information containing the amount and the currency code</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IPrice BillingRefundAmount { get; set; }
        /// <summary>Quantity to be returned</summary>
        int? Quantity { get; set; }
        /// <summary>Fully qualified id of the reservation being returned.</summary>
        string ReservationId { get; set; }

    }
}