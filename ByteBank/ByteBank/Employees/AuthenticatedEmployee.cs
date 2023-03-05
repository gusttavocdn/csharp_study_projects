namespace ByteBank.Employees;

using InternalSystem;

public abstract class AuthenticatedEmployee: Employee, IAuthenticable {
    public string Password { get; set; }

    protected AuthenticatedEmployee(string name, string cpf, double salary, string password)
        : base(name, cpf, salary)
    {
        Password = password;
    }

    public bool Authenticate(string password) => Password.Equals(password);
}
