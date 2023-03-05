namespace ByteBank.Employees;

public class AccountManager : AuthenticatedEmployee {

    public AccountManager(string name, string cpf, double salary, string password)
        : base(name, cpf, salary, password)
    {
    }

    public override double GetBonus() => Salary * 0.25;

    public override void RaiseSalary() => Salary *= 1.05;

}
