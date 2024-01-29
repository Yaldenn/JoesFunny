using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using JoesFunny.Data;
using System;
using System.Linq;

namespace JoesFunny.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new JoesFunnyContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<JoesFunnyContext>>()))
        {
            // Look for any PersonalInformations.
            if (context.PersonalInformation.Any())
            {
                return;   // DB has been seeded
            }
            context.PersonalInformation.AddRange(
                new PersonalInformation
                {
                    Name = "Joe",
                    DateOfBirth = DateTime.Parse("2001-9-11"),
                    SocialSecurityNumber = "618432783",
                    address = "180 Greenwich Street New York, NY 10281 United States"
                },
                new PersonalInformation
                {
                    Name = "Matt",
                    DateOfBirth = DateTime.Parse("0001-12-25"),
                    SocialSecurityNumber = "1",
                    address = "Bethlehem, Israel"
                },
                new PersonalInformation
                {
                    Name = "Sam",
                    DateOfBirth = DateTime.Parse("2024-2-21"),
                    SocialSecurityNumber = "521736429",
                    address = "Nuts, Deez"
                },
                new PersonalInformation
                {
                    Name = "Lebron James",
                    DateOfBirth = DateTime.Parse("2002-8-3"),
                    SocialSecurityNumber = "721468348",
                    address = "Somewhere, United States"
                }
            );
            context.SaveChanges();
        }
    }
}