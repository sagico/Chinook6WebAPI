﻿using Chinook.Domain.ApiModels;
using Chinook.Domain.Converters;

namespace Chinook.Domain.Entities;

public sealed class Invoice : BaseEntity, IConvertModel<InvoiceApiModel>
{
    public Invoice()
    {
        InvoiceLines = new HashSet<InvoiceLine>();
    }

    public int CustomerId { get; set; }
    public DateTime InvoiceDate { get; set; }
    public string? BillingAddress { get; set; }
    public string? BillingCity { get; set; }
    public string? BillingState { get; set; }
    public string? BillingCountry { get; set; }
    public string? BillingPostalCode { get; set; }
    public decimal Total { get; set; }
    public Customer? Customer { get; set; }
    public ICollection<InvoiceLine>? InvoiceLines { get; set; }

    public InvoiceApiModel Convert() =>
        new()
        {
            Id = Id,
            CustomerId = CustomerId,
            InvoiceDate = InvoiceDate,
            BillingAddress = BillingAddress,
            BillingCity = BillingCity,
            BillingState = BillingState,
            BillingCountry = BillingCountry,
            BillingPostalCode = BillingPostalCode,
            Total = Total
        };
}