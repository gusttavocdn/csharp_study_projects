namespace ByteBank.Employees; 

public class Designer : Employee {

    public Designer(string name, string cpf) : base(name, cpf, 3000) {}

    public override double GetBonus() => Salary * 0.17;
    
    public override void RaiseSalary() => Salary *= 1.11;
}
