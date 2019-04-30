using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Conizi.Model.Shared.Interfaces
{
    public interface IAddress
    {

        [DisplayName("Name of the address")]
        string Name { get; set; }
        [DisplayName("Street of the address")]
        string Street { get; set; }
        [DisplayName("House number of the address")]
        string HouseNumber { get; set; }
        [DisplayName("Zip code of the Address")]
        string ZipCode { get; set; }
        [DisplayName("City of the address")]
        string City { get; set; }
        [DisplayName("Town area address")]
        string TownArea { get; set; }
        [DisplayName("Country code of the address")]
        string CountryCode { get; set; }
        [DisplayName("Email of the address")]
        [EmailAddress]
        string EmailAddress { get; set; }
        [Phone]
        [DisplayName("Phone number of the address")]
        string PhoneNumber { get; set; }
        [DisplayName("Additional address lines of the address")]
        List<string> AdditionalAddressLines { get; set; }
        [DisplayName("Reference number of the consignment")]
        string ReferenceNumber { get; set; }
        [DisplayName("The contact person")]
        string ContactPerson { get; set; }
        [Phone]
        [DisplayName("The Fax number")]
        string FaxNumber { get; set; }

    }
}
