namespace ConsoleApp.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string? FullName { get; set; }
        public int Age { get; set; }
        public Player(string fullName, int age)
        {
            FullName = fullName;
            Age = age;
        }
        public override string ToString()
        {
            return $"{FullName}: {Age}";
        }
    }
}
