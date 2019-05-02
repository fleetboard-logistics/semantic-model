using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Entities;
using Conizi.Model.Transport.Truck.Groupage.Forwarding;


namespace Conizi.Model.Accounting.Material
{
    /// <summary>
    /// Transaction of material for accounting purpose
    /// </summary>
    [ConiziSchema("https://model.conizi.io/v1/accounting/material/transaction.json", "transaction.json")]
    [DisplayName("Material Accounting Transaction")]
    [Description("Transaction of material for accounting purpose")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class MaterialTransaction : EdiModel
    {
        /// <summary>
        /// The unique booking id
        /// </summary>
        [DisplayName("Unique booking id")]
        [Description("The unique booking id")]
        [Required]
        public string Id { get; set; }

        /// <summary>
        /// The booking item
        /// </summary>
        [DisplayName("Booking id")]
        [Description("The booking item")]
        [Required]
        public string Item { get; set; }

        /// <summary>
        /// The source account
        /// </summary>
        [DisplayName("Source Account")]
        [Description("The source account")]
        [Required]
        public string SourceAccount { get; set; }  
        
        /// <summary>
        /// The destination account
        /// </summary>
        [DisplayName("Destination Account")]
        [Description("The destiation account")]
        [Required]
        public string DestinationAccount { get; set; }

        /// <summary>
        /// The amount of the booking
        /// </summary>
        [DisplayName("Amount")]
        [Description("The amount of the booking")]
        [Required]
        public decimal Amount { get; set; }

        /// <summary>
        /// The booking date
        /// </summary>
        [DisplayName("Booking date")]
        [Description("The booking date")]
        [Required]
        public DateTime BookingDate { get; set; }

        /// <summary>
        /// The reference number
        /// </summary>
        [DisplayName("Reference number")]
        [Description("The reference number")]
        public string ReferenceNumber { get; set; }

        /// <summary>
        /// Booking comment
        /// </summary>
        [DisplayName("Booking Comment")]
        [Description("A booking comment")]
        public string Comment { get; set; }
    }
}
