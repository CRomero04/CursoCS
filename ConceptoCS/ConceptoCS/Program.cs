// See https://aka.ms/new-console-template for more information
using ConceptoCS;

Console.WriteLine("Hello, World!");

Employee employee1=new SalaryEmployee() {
    Id = 1010,
    FirstName = "Cesar",
    LastName = "Romero",
    BirthDate = new Date(2000, 5, 4),
    HiringDate = new Date(2023, 3, 20),
    IsActive = true,
    Salary = 3000.45M
};

Console.WriteLine(employee1);