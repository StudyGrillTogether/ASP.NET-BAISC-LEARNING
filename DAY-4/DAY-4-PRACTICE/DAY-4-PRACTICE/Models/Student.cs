namespace DAY_4_PRACTICE.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age {  get; set; }
        public string Email { get; set; }

        public bool IsAdult(int age)
        {
            if (Age < 18)
            {
                return false;
            }
            return true;
        }
    }
}
