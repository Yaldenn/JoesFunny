using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using static Org.BouncyCastle.Crypto.Engines.SM2Engine;

namespace JoesFunny.Models;

public class PersonalAddressViewModel
{
    public List<PersonalInformation>? Information { get; set; }
    public SelectList? Addresses { get; set; }
    public string? Address { get; set; }
    public string? SearchString { get; set; }
}