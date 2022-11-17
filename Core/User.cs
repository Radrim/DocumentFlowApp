namespace Core
{
    public class User
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Role { get; set; }

       /* public User(string Login, string Password, string Name, string Surname, string Email, string Phone, string Role) 
        {
            this.Login = Login;
            this.Password = Password;
            this.Name = Name;
            this.Surname = Surname;
            this.Email = Email;
            this.Phone = Phone;
            this.Role = Role;
        }*/
    }   
}
