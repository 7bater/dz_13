namespace dz_13.models
{
    public record Student(string FirstName, string LastName, int Age, string University)
    {
        public override string ToString()
        {
            return $"{FirstName} {LastName} | Вік: {Age} | ВНЗ: {University}";
        }
    }
}