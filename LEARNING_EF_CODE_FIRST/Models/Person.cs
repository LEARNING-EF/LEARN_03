namespace Models
{
	public class Person : object
	{
		public Person() : base()
		{
		}

		public int Id { get; set; }

		public int Age { get; set; }

		public string FullName { get; set; }

		public bool IsSupervisor { get; set; }
	}
}
