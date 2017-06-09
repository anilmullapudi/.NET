

namespace OdeToFood.Entities
{
	public enum CuisineType
	{
		None,
		Italian,
		French
	}

    public class Restaurant
    {
		public int Id { get; set; }
		public string Name { get; set; }
		public CuisineType cusine { get; set; }

	}
}
