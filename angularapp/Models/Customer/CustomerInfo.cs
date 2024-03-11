using System;

class Program
{
  static void Main()
  {
    using System;

class Customer
  {
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }

    public Customer(string firstName, string lastName, string phoneNumber)
    {
      FirstName = firstName;
      LastName = lastName;
      PhoneNumber = phoneNumber;
    }

    public void DisplayInfo()
    {
      Console.WriteLine($"Customer: {FirstName} {LastName}");
      Console.WriteLine($"Phone Number: {PhoneNumber}");
    }
  }

  class Program
  {
    static void Main()
    {
      // Creating an instance of the Customer class
      Customer customer1 = new Customer("Isaac", "Madrigal", "123-456-7890");

      // Displaying customer information
      customer1.DisplayInfo();
    }
  }

}
}

