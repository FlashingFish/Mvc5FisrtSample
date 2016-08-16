namespace Mvc5FisrtSample.Migrations
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Mvc5FisrtSample.Models.Mvc5FisrtSampleContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Mvc5FisrtSample.Models.Mvc5FisrtSampleContext context)
        {
            var sexes = new List<Sex>
            {
                new Sex { Name = "男" },
                new Sex { Name = "女" }
            };
            sexes.ForEach(s => context.Sexes.AddOrUpdate(p => p.Name, s));
            context.SaveChanges();

            var parents = new List<Parent>
            {
                new Parent { Name = "青木篤志", SexId =  sexes.Single(s => s.Name == "男").Id, Email = "aoki.atsushi@example.com" },
                new Parent { Name = "井上郁夫", SexId =  sexes.Single(s => s.Name == "男").Id, Email = "inoue.ikuo@example.com", Children = new List<Child>
                    {
                        new Child { Name = "井上恵美子", SexId =  sexes.Single(s => s.Name == "女").Id, Birthday = DateTime.Parse("2015-01-16") }
                    }
                },
                new Parent { Name = "宇佐美景子", SexId =  sexes.Single(s => s.Name == "女").Id, Email = "usami.keiko@example.com", Children = new List<Child>
                    {
                        new Child { Name = "宇佐美涼介", SexId =  sexes.Single(s => s.Name == "男").Id, Birthday = DateTime.Parse("2010-02-01") },
                        new Child { Name = "宇佐美信介", SexId =  sexes.Single(s => s.Name == "男").Id, Birthday = DateTime.Parse("2013-11-08") },
                        new Child { Name = "宇佐美純", SexId =  sexes.Single(s => s.Name == "男").Id, Birthday = DateTime.Parse("2015-04-05") }
                    }
                }
            };
            parents.ForEach(s => context.Parents.AddOrUpdate(p => p.Name, s));
            context.SaveChanges();
        }
    }
}
