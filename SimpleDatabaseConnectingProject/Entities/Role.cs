namespace SimpleDatabaseConnectingProject.Entities
{
    public class Role
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public UserRole UniqueName { get; set; }

        public ICollection<UserSelectedRoles> UserSelectedRoles { get; set; }
    }
    
    public enum UserRole
    {
        admin,
        customer,
        anonymouse
    }
}
