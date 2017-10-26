namespace GreetSomeone.Models
{
    public class UserData
    {
        public string Name { get; set; }

        public UserData(string name) => Name = name;

        public UserData()
        {
        }
    }
}