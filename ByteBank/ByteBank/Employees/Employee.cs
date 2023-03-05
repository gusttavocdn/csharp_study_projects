namespace ByteBank.Employees;

public abstract class Employee {
    public string Name { get; private set; }
    public string Cpf { get; private set; }
    public double Salary { get; protected set; }

    public static int TotalEmployees { get; private set; }

    public Employee(string name, string cpf, double salary)
    {
        Name = name;
        Cpf = cpf;
        Salary = salary;
        TotalEmployees++;
    }

    public abstract double GetBonus();

    public abstract void RaiseSalary();
}
