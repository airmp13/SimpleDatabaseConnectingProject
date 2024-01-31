namespace SimpleDatabaseConnectingProject.Entities
{
    public class UserSelectedRoles
    {
        public int ID { get; set; }

        public int RoleID { get; set; }

        public int UserID { get; set; }

        public User user { get; set; }
        public Role role { get; set; }

    }
}
