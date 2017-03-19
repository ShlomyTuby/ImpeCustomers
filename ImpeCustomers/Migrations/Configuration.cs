namespace ImpeCustomers.Migrations
{
    using ImpeCustomers.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ImpeCustomers.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "ImpeCustomers.Models.ApplicationDbContext";
        }

        protected override void Seed(ImpeCustomers.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            if (context.Navigations.Count() == 0)
            {
                context.Navigations.AddRange( new List<Navigation>
                {
                    new Navigation { IsRoot = true, Name = "Products", Index = 1, Url = "/Products",
                        Childrens = new List<Navigation> {
                            new Navigation { IsRoot = false, Name = "Web Application Sucurity", Index = 1, Url = "/Products/WebApplicationSucurity",
                                Childrens = new List<Navigation> {
                                    new Navigation { IsRoot = false, Name = "Web Application Firewall", Index = 1, Url = "/Products/WebApplicationSucurity/WebApplicationFirewall" },
                                    new Navigation { IsRoot = false, Name = "ThreatRadar Subscriptions", Index = 2, Url = "/Products/WebApplicationSucurity/ThreatRadarSubscriptions" }
                                }
                            },
                            new Navigation { IsRoot = false, Name = "DDos Protection", Index = 2, Url = "/Products/DDosProtection",
                                Childrens = new List<Navigation> {
                                    new Navigation { IsRoot = false, Name = "Website DDoS Protection", Index = 1, Url = "/Products/DDosProtection/WebsiteDDoSProtection" },
                                    new Navigation { IsRoot = false, Name = "Infrastructure DDoS Protection", Index = 2, Url = "/Products/DDosProtection/WebsiteDDoSProtection" },
                                    new Navigation { IsRoot = false, Name = "Website DDoS Protection", Index = 3, Url = "/Products/DDosProtection/WebsiteDDoSProtection" },
                                    new Navigation { IsRoot = false, Name = "Name Server DDoS Protection", Index = 1, Url = "/Products/DDosProtection/NameServerDDoSProtection" }
                                }
                            },
                            new Navigation { IsRoot = false, Name = "Breach Prevention", Index = 3, Url = "/Products/BreachPrevention",
                                Childrens = new List<Navigation> {
                                    new Navigation { IsRoot = false, Name = "Counter Breach", Index = 1, Url = "/Products/DDosProtection/CounterBreach" },
                                }
                            },
                            new Navigation { IsRoot = false, Name = "Sharepoint Security", Index = 4, Url = "/Products/Sharepoint Security" },
                            new Navigation { IsRoot = false, Name = "File Security", Index = 5, Url = "/Products/File Security",
                                Childrens = new List<Navigation> {
                                    new Navigation { IsRoot = false, Name = "File Firewall", Index = 1, Url = "/Products/File Security/File Firewall" },
                                }
                            },
                        }
                    },
                    ///Products/DDosProtection
                    new Navigation { IsRoot = true, Name = "Services", Index = 2, Url = "/Services",
                        Childrens = new List<Navigation> {
                            new Navigation { IsRoot = false, Name = "Professional Services", Index = 1, Url = "/Services/ProfessionalServices"
                            }
                        }
                    },
                    new Navigation { IsRoot = true, Name = "Partners", Index = 3, Url = "/Partners",
                        Childrens = new List<Navigation> {
                            new Navigation { IsRoot = false, Name = "Channel Partners", Index = 1, Url = "/Partners/ChannelPartners"
                            }
                        }
                    }
                });
            }
        }

       

    }
}
