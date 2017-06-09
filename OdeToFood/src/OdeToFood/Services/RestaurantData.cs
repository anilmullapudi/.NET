using OdeToFood.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace OdeToFood.Services
{

	public interface IRestaurantData
	{
		IEnumerable<Restaurant> GetAll();
		Restaurant Get(int id);
	}
	public class InMemoryRestaurantData : IRestaurantData
	{
		List<Restaurant> _restaurants;

		public InMemoryRestaurantData()
		{
			_restaurants = new List<Restaurant>
			{
				new Restaurant { Id=1, Name="JackInTheBox"},
				new Restaurant { Id=2, Name="TacoBell" },
				new Restaurant { Id=3, Name="McDonalds" }
			};
		}

		public Restaurant Get(int id)
		{
			//foreach( Restaurant rs in _restaurants) {
			//	if(id == rs.Id)
			//	{
			//		return rs;
			//	}
			//}
			//return null;
			return _restaurants.FirstOrDefault(r=> r.Id == id);
		}

		public IEnumerable<Restaurant> GetAll()
		{
			return _restaurants;
		}
	}
}
