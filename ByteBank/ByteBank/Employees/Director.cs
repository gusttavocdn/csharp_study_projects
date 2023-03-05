namespace ByteBank.Employees;

public class Director : AuthenticatedEmployee {

    public Director(string name, string cpf, string password)
        : base(name, cpf, 5000, password)
    {
    }

    public override double GetBonus() => Salary * 0.5;

    public override void RaiseSalary() => Salary *= 1.15;
}
