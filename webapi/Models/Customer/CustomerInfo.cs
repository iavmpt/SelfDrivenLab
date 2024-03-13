using System;

class Program
{
  static void Main(string[] args)
  {
    using System;

class Customer
  {
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }

    public Customer(string firstName, string lastName, string phoneNumber, string Email)
    {
      FirstName = firstName;
      LastName = lastName;
      PhoneNumber = phoneNumber;
      CustEmail = Email;
    }

    public void DisplayInfo()
    {
      Console.WriteLine($"Customer: {FirstName} {LastName}");
      Console.WriteLine($"Phone Number: {PhoneNumber}");
      Console.WriteLine($"Email: {CustEmail}"); 
    }
  }

  class Program
  {
    static void Main(string[] args )
    {
      // Creating an instance of the Customer class
      Customer customer1 = new Customer("Isaac", "Madrigal", "123-456-7890", "isaac.madrigal03@gmail.com");

      // Displaying customer information
      customer1.DisplayInfo();
    }
  }

}
public class DbContext : DbContext
{
  public DbSet<Customer> FirstName { get; set; }
  public DbSet<Customer> LastName { get; set; }
  public DbSet<Customer> PhoneNumber { get; set; }
  public DbSet<Customer> CustEmail { get; set; }
}

}

