﻿using System;
using System.Runtime.Serialization;
using Lime.Protocol;

namespace Lime.Messaging.Contents
{
    /// <summary>
    /// Represents an invoice for requesting a payment.
    /// </summary>
    /// <seealso cref="Lime.Protocol.Document" />
    [DataContract(Namespace = "http://limeprotocol.org/2014")]
    public class Invoice : Document
    {
        public const string MIME_TYPE = "application/vnd.lime.invoice+json";
        public const string CREATED_KEY = "created";
        public const string METHODS_KEY = "methods";
        public const string DUE_TO_KEY = "dueTo";
        public const string CURRENCY_KEY = "currency";
        public const string TAXES_KEY = "taxes";
        public const string TOTAL_KEY = "total";        
        public const string ITEMS_KEY = "items";

        public static readonly MediaType MediaType = MediaType.Parse(MIME_TYPE);

        /// <summary>
        /// Initializes a new instance of the <see cref="Invoice"/> class.
        /// </summary>
        public Invoice() 
            : base(MediaType)
        {
        }

        /// <summary>
        /// Gets or sets the invoice creation date.
        /// </summary>
        /// <value>
        /// The creation date.
        /// </value>
        [DataMember(Name = CREATED_KEY)]
        public DateTimeOffset? Created { get; set; }

        /// <summary>
        /// Gets or sets the invoice expiration.
        /// </summary>
        /// <value>
        /// The expiration date.
        /// </value>
        [DataMember(Name = DUE_TO_KEY)]
        public DateTimeOffset? DueTo { get; set; }

        /// <summary>
        /// Gets or sets the seller supported methods for payment of the invoice.
        /// </summary>
        /// <value>
        /// The payment methods.
        /// </value>
        [DataMember(Name = METHODS_KEY)]
        public PaymentMethod[] Methods { get; set; }

        /// <summary>
        /// Gets or sets the invoice currency code related to the values.
        /// </summary>
        /// <value>
        /// The currency.
        /// </value>
        [DataMember(Name = CURRENCY_KEY)]
        public string Currency { get; set; }

        /// <summary>
        /// Gets or sets the invoice total taxes value.
        /// </summary>
        /// <value>
        /// The taxes.
        /// </value>
        [DataMember(Name = TAXES_KEY)]
        public decimal? Taxes { get; set; }

        /// <summary>
        /// Gets or sets the invoice total value, including taxes.
        /// </summary>
        /// <value>
        /// The total.
        /// </value>
        [DataMember(Name = TOTAL_KEY)]
        public decimal Total { get; set; }

        /// <summary>
        /// Gets or sets the invoice items.
        /// </summary>
        /// <value>
        /// The items.
        /// </value>
        [DataMember(Name = ITEMS_KEY)]
        public InvoiceItem[] Items { get; set; }
    }
}
