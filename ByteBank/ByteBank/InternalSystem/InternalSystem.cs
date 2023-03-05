namespace ByteBank.InternalSystem; 

public class InternalSystem {
   public bool Login(IAuthenticable employee, string password)
   {
      var authenticatedUser = employee.Authenticate(password);

      if (!authenticatedUser)
      {
         Console.WriteLine("Authentication failed");
         return false;
      }

      Console.WriteLine("Welcome to the System");
      return true;
   } 
}
