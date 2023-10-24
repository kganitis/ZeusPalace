using System.Drawing;

namespace ZeusPalace
{
    public class Employee : User
    {
        public override UserRole Role => UserRole.Employee;

        public Image Image { get; }

        public Employee(string name, Image image)
        {
            Name = name;
            Username = ExtractFirstLetters(Name);
            Password = ExtractFirstLetters(Name, 3);
            Image = image;
        }
    }
}
