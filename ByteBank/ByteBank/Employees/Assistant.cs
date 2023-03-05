namespace ByteBank.Employees; 

public class Assistant : Employee {
    public  Assistant(string name, string cpf) : base(name, cpf, 2000) {}

    public override double GetBonus() => Salary * 0.2;

    public override void RaiseSalary() => Salary *= 1.1;

}
