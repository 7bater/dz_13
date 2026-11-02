namespace dz_13.models
{
    public record Employee(string FullName, string Position, string Phone, string Email, decimal Salary)
    {
        public override string ToString()
        {
            return $"{FullName} | Посада: {Position} | Тел: {Phone} | Email: {Email} | ЗП: {Salary} грн";
        }
    }
}