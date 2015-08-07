namespace PluralsightMVC.Migrations
{
	using PluralsightMVC.Models;
	using System;
	using System.Collections.Generic;
	using System.Data.Entity;
	using System.Data.Entity.Migrations;
	using System.Linq;

	internal sealed class Configuration : DbMigrationsConfiguration<PluralsightMVC.Models.PluralsightMVCDb>
	{
		public Configuration()
		{
			AutomaticMigrationsEnabled = true;
		}

		protected override void Seed(PluralsightMVC.Models.PluralsightMVCDb context)
        {
			context.Restaurants.AddOrUpdate(r => r.Name,
				new Restaurant { Name = "Sabatino's", City = "Balitmore", Country = "USA" },
				new Restaurant { Name = "Great Lake", City = "Chicago", Country = "USA" },
				new Restaurant
				{
					Name = "Smaka",
					City = "Gothenburg",
					Country = "Sweden",
					Reviews =
						new List<RestaurantReview> {
							new RestaurantReview {Rating = 9, Body = "Great food!"}
						}
				}
				);
        }
	}
}
