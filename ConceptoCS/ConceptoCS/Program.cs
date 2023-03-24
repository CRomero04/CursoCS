// See https://aka.ms/new-console-template for more information
using ConceptoCS;

Console.WriteLine("Hello, World!");

Employee employee1 = new SalaryEmployee()
{
    Id = 1010,
    FirstName = "Cesar",
    LastName = "Romero",
    BirthDate = new Date(2000, 5, 4),
    HiringDate = new Date(2023, 3, 20),
    IsActive = true,
    Salary = 3000.45M
};

//Console.WriteLine(employee1);

Employee employee2 = new CommissionEmployee()
{
    Id = 2020,
    FirstName = "Alejandra",
    LastName = "Hernandez",
    BirthDate = new Date(2000, 5, 4),
    HiringDate = new Date(2023, 3, 20),
    IsActive = true,
    Sales = 32000,
    CommissionPercentaje = 0.03F
};

Employee employee3 = new HourlyEmployee()
{
    Id = 2020,
    FirstName = "Alejandra",
    LastName = "Hernandez",
    BirthDate = new Date(2000, 5, 4),
    HiringDate = new Date(2023, 3, 20),
    IsActive = true,
    HourValue = 250,
    Hours = 45
};

Employee employee4 = new BaseCommissionEmployee()
{
    Id = 2020,
    FirstName = "Alejandra",
    LastName = "Hernandez",
    BirthDate = new Date(2000, 5, 4),
    HiringDate = new Date(2023, 3, 20),
    IsActive = true,
    Base = 7500,
    Sales = 32000,
    CommissionPercentaje = 0.03F
};

ICollection<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3, employee4
};

decimal payroll = 0;

foreach (Employee employee in employees)
{
    Console.WriteLine(employee);
    payroll += employee.GetValueToPay();
}

Console.WriteLine($"Total del Payroll: {payroll:C2}", 18);

Invoice invoice = new Invoice()
{
    Description = "IPhone 13",
    Id = 1,
    Price = 20000M,
    Quantity = 2
};

Invoice invoice2 = new Invoice()
{
    Description = "IPhone 11",
    Id = 2,
    Price = 15000M,
    Quantity = 1
};