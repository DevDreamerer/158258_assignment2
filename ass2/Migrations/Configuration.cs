namespace ass2.Migrations
{
    using ass2.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ass2.Data.ass2Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "ass2.Data.ass2Context";
        }

        protected override void Seed(ass2.Data.ass2Context context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            var continents = new List<Continent>
            {
                new Continent {Name = "Europe" },
                new Continent {Name = "Africa" },
                new Continent {Name = "Asia" },
                new Continent {Name = "Oceania" },
                new Continent {Name = "Antarctica" },
                new Continent {Name = "North America" },
                new Continent {Name = "Sourth America" }
            };
            continents.ForEach(c => context.Continents.AddOrUpdate(p => p.Name, c));
            context.SaveChanges();

            var endangereds = new List<Endangered>
            {
                new Endangered {Name = "Rhinoceros Sondaicus", Description = "The Rhinoceros Sondaicus is the rarest large mammal and is on the brink of extinction due to excessive human hunting and environmental damage.", Number =40, ContinentID= continents.Single(c=>c.Name == "Asia").ID},
                new Endangered {Name = "Gorilla", Description = "Armed conflict and excessive natural resource exploitation are the main factors threatening the gorilla population.", Number =600, ContinentID= continents.Single(c=>c.Name == "Africa").ID},
                new Endangered {Name = "Sumatran Orangutan", Description = "In Sumatra Island, Indonesia, orangutans are considered a threat to human agriculture and habitation. A survey has found that residents of Borneo have killed at least 750 endangered Sumatran orangutans within a year.", Number =7500, ContinentID= continents.Single(c=>c.Name == "Asia").ID},
                new Endangered {Name = "Leatherback Turtle", Description = "The widespread geographical distribution and activity of leatherback turtles in shallow waters pose a threat to them from fishermen.", Number =36300, ContinentID= continents.Single(c=>c.Name == "Sourth America").ID},
                new Endangered {Name = "Orcaella brevirostris", Description = "The mercury and other pollutants in the river water are too high. Since 2003, 88 Irrawaddy finless porpoises have died, with over 60% of the young porpoises less than two weeks old. Most young dolphins die from bacterial infections.", Number =85, ContinentID= continents.Single(c=>c.Name == "Asia").ID},
                new Endangered {Name = "Phocoena sinus", Description = "The high value of the Phocoena sinus has led to rampant illegal fishing activities, and the damage caused to the Phocoena sinus remains enormous.", Number =30, ContinentID= continents.Single(c=>c.Name == "Sourth America").ID},
                new Endangered {Name = "Lasiorhinus krefftii", Description = "Due to the invasion of wild dogs and other predatory species, it has almost become extinct.", Number =100, ContinentID= continents.Single(c=>c.Name == "Oceania").ID},
                new Endangered {Name = "emperor penguin", Description = "In the late 19th and early 20th centuries, a large number of emperor penguins were slaughtered by humans in order to obtain oil from their bodies, and their numbers continued to decrease.", Number =1600000, ContinentID= continents.Single(c=>c.Name == "Oceania").ID},
                new Endangered {Name = "Enhydra lutris", Description = "Threatened by fishing nets and oil spills from the central coast of California.", Number =1700, ContinentID= continents.Single(c=>c.Name == "North America").ID},
                new Endangered {Name = "Prionailurus viverrinus", Description = "Due to the gradual reduction of wetlands where fishing cats rely and overfishing by humans in Southeast Asia, the number of Prionailurus viverrinus has sharply decreased.", Number =72, ContinentID= continents.Single(c=>c.Name == "Asia").ID},
                new Endangered {Name = "Panthera pardus orientalis", Description = "Habitat destruction, poaching, and extensive hunting of herbivores pose a threat to the survival of Panthera pardus orientalis.", Number =100, ContinentID= continents.Single(c=>c.Name == "Europe").ID},
               
                new Endangered {Name = "Lycaon pictus", Description = "In the past few decades, due to their hunting of livestock, they have been subjected to large-scale retaliatory hunting, while their traditional habitats have been significantly reduced with the pace of human exploitation,", Number =3000,ContinentID= continents.Single(c=>c.Name == "Africa").ID},
                new Endangered {Name = "Panthera tigris jacksoni", Description = "The widespread disappearance of local forests in Malaysia.", Number =800, ContinentID= continents.Single(c=>c.Name == "Asia").ID},
                new Endangered {Name = "Pharomachrus mocinno", Description = "Habitat reduction: Many of the forests they inhabit have been cut down, and the cleared land has been used for grazing or coffee cultivation.", Number =1700000, ContinentID= continents.Single(c=>c.Name == "Sourth America").ID},
                new Endangered {Name = "Scinaxboulengeri", Description = "Due to fungal infection, the number of lemur leaf frogs suffering from kettle fungus disease has sharply decreased.", Number =200, ContinentID= continents.Single(c=>c.Name == "North America").ID},
                new Endangered {Name = "Mustela nigripes", Description = "The number of main food sources is constantly decreasing; In order to eliminate these rodents that have a destructive effect on the ranch, ranchers have put in a large amount of poison bait.", Number =300, ContinentID= continents.Single(c=>c.Name == "North America").ID},
                new Endangered {Name = "Bradypus tridactylus", Description = "Bradypus tridactylus inhabits the forests along the eastern coast of Brazil. Due to severe deforestation and damage to its living environment, it is in danger of extinction.", Number =800, ContinentID= continents.Single(c=>c.Name == "Sourth America").ID},
                new Endangered {Name = "Hapalemur simus", Description = "The living environment is severely threatened by the cultivation of land, the cutting and burning of plants, and the scarcity of their main food, bamboo.", Number =1000, ContinentID= continents.Single(c=>c.Name == "Africa").ID},
                new Endangered {Name = "Gymnogyps caliornianus", Description = "Lead poisoning occurs due to poaching and habitat destruction, as well as when these creatures unintentionally consume bullets left in the body.", Number =275, ContinentID= continents.Single(c=>c.Name == "North America").ID},
                new Endangered {Name = "Canis rufus", Description = "Some large animals come to hunt it because of its small size, and many carnivorous animals use it as food. For example, large birds, crocodiles, lions.", Number =175, ContinentID= continents.Single(c=>c.Name == "North America").ID},
                new Endangered {Name = "Sphaeropteris lepifera", Description = "Sphaeropteris lepifera originally grew during the Jurassic period of the Mesozoic era and was the main food for dinosaurs at that time; The Quaternary glacial period was basically extinct. Only a small number of plants remain in southern China and parts of Southeast Asian countries.", Number =4, ContinentID= continents.Single(c=>c.Name == "Asia").ID},
                new Endangered {Name = "Adélie Penguin", Description = "Climate change and habitat loss have led to a decrease in population.", Number =40000000, ContinentID= continents.Single(c=>c.Name == "Antarctica").ID},
                new Endangered {Name = "Yellow-eyed Penguin", Description = "Habitat loss and illegal hunting have led to a decrease in population.", Number =4000, ContinentID= continents.Single(c=>c.Name == "Oceania").ID},
                new Endangered {Name = "Red Panda", Description = "Habitat loss and illegal hunting have led to a decrease in population.", Number =10000, ContinentID= continents.Single(c=>c.Name == "Asia").ID},
                new Endangered {Name = "Mediterranean Monk Seal", Description = "Habitat loss and illegal hunting have led to a decrease in population..", Number =500, ContinentID= continents.Single(c=>c.Name == "Europe").ID},
                new Endangered {Name = "Vaquita", Description = "Illegal fishing and fishing have led to a sharp decline in numbers.", Number =15, ContinentID= continents.Single(c=>c.Name == "North America").ID},
                new Endangered { Name = "Vaquita", Description = "Illegal fishing and fishing have led to a sharp decline in numbers.", Number = 15, ContinentID = continents.Single(c => c.Name == "North America").ID },
    new Endangered { Name = "Javan Rhino", Description = "Habitat loss and poaching are major threats.", Number = 27, ContinentID = continents.Single(c => c.Name == "Asia").ID },
    new Endangered { Name = "Amur Leopard", Description = "Habitat loss and poaching have critically endangered this species.", Number = 84, ContinentID = continents.Single(c => c.Name == "Asia").ID },
    new Endangered { Name = "Sumatran Elephant", Description = "Habitat loss and conflict with humans are endangering their population.", Number = 2400, ContinentID = continents.Single(c => c.Name == "Asia").ID },
    new Endangered { Name = "Black Rhino", Description = "Poaching for their horns has severely impacted their numbers.", Number = 5500, ContinentID = continents.Single(c => c.Name == "Africa").ID },
    new Endangered { Name = "Mountain Gorilla", Description = "Habitat loss and poaching are major threats to their survival.", Number = 1000, ContinentID = continents.Single(c => c.Name == "Africa").ID },
    new Endangered { Name = "Bengal Tiger", Description = "Habitat loss and poaching have led to a decline in their population.", Number = 2500, ContinentID = continents.Single(c => c.Name == "Asia").ID },
    new Endangered { Name = "African Wild Dog", Description = "Habitat loss and diseases have caused a decline in their population.", Number = 6000, ContinentID = continents.Single(c => c.Name == "Africa").ID },
    new Endangered { Name = "Kakapo", Description = "Habitat loss and predation have critically endangered this parrot species.", Number = 213, ContinentID = continents.Single(c => c.Name == "Oceania").ID },
    new Endangered { Name = "Red Panda", Description = "Habitat loss and poaching are major threats to their population.", Number = 10000, ContinentID = continents.Single(c => c.Name == "Asia").ID },
    new Endangered { Name = "Snow Leopard", Description = "Poaching and habitat loss have led to their endangerment.", Number = 4000, ContinentID = continents.Single(c => c.Name == "Asia").ID },
    new Endangered { Name = "Philippine Eagle", Description = "Habitat loss and hunting are major threats to this eagle species.", Number = 400, ContinentID = continents.Single(c => c.Name == "Asia").ID },
    new Endangered { Name = "Irrawaddy Dolphin", Description = "Habitat degradation and bycatch are endangering their population.", Number = 8000, ContinentID = continents.Single(c => c.Name == "Asia").ID },
    new Endangered { Name = "Southern White Rhinoceros", Description = "Poaching for their horns has severely impacted their numbers.", Number = 18000, ContinentID = continents.Single(c => c.Name == "Africa").ID },
    new Endangered { Name = "Philippine Tarsier", Description = "Habitat loss and the pet trade have critically endangered this primate species.", Number = 1500, ContinentID = continents.Single(c => c.Name == "Asia").ID },
    new Endangered { Name = "Giant Panda", Description = "Habitat loss and low reproduction rates have endangered this iconic species.", Number = 1800, ContinentID = continents.Single(c => c.Name == "Asia").ID },
    new Endangered { Name = "Indri", Description = "Habitat loss and hunting have critically endangered this lemur species.", Number = 1000, ContinentID = continents.Single(c => c.Name == "Africa").ID },
    new Endangered { Name = "Vaquita", Description = "Illegal fishing and fishing have led to a sharp decline in numbers.", Number = 15, ContinentID = continents.Single(c => c.Name == "North America").ID },
    new Endangered { Name = "Javan Rhino", Description = "Poaching and habitat loss threaten the survival of this rhinoceros species.", Number = 10, ContinentID = continents.Single(c => c.Name == "Asia").ID },
    new Endangered { Name = "Amur Leopard", Description = "Habitat loss and poaching have pushed this leopard to the brink of extinction.", Number = 8, ContinentID = continents.Single(c => c.Name == "Asia").ID },
    new Endangered { Name = "Sumatran Elephant", Description = "Habitat loss and human-elephant conflict are major threats to this species.", Number = 12, ContinentID = continents.Single(c => c.Name == "Asia").ID },
    new Endangered { Name = "Mountain Gorilla", Description = "Conservation efforts have helped stabilize the population, but it remains endangered.", Number = 15, ContinentID = continents.Single(c => c.Name == "Africa").ID },
     new Endangered { Name = "Black Rhino", Description = "Poaching for their horns has severely reduced the population of these rhinoceroses.", Number = 7, ContinentID = continents.Single(c => c.Name == "Africa").ID },
    new Endangered { Name = "Bornean Orangutan", Description = "Habitat destruction due to logging and palm oil plantations threatens this species.", Number = 9, ContinentID = continents.Single(c => c.Name == "Asia").ID },
    new Endangered { Name = "Pangolin", Description = "Illegal wildlife trade has made pangolins the most trafficked mammals in the world.", Number = 4, ContinentID = continents.Single(c => c.Name == "Asia").ID },
    new Endangered { Name = "African Lion", Description = "Habitat loss and human-wildlife conflict have led to a decline in lion populations.", Number = 10, ContinentID = continents.Single(c => c.Name == "Africa").ID },

            };
            endangereds.ForEach(c => context.Endangereds.AddOrUpdate(p => p.Name, c));
            context.SaveChanges();
        }
    }
}
