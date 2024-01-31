namespace SimpleDatabaseConnectingProject.Entities
{
	public class User
	{
        public int ID { get; set; }

		public string FullName { get; set; }

		public string Email { get; set; }

		public string Password { get; set; }

        public string PhoneNumber { get; set; }

        public ICollection<UserSelectedRoles> UserSelectedRoles { get; set; }
    }
}
