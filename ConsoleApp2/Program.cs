
Console.WriteLine("Hello, World!");
Employee employee = new Employee
{
    EmployeeId = "E001",
    FirstName = "John",
    LastName = "Deo",
    Designation = "Software Engineer"
};
Console.WriteLine(employee);
Collectionhelper Collectionhelperobj = new Collectionhelper();
Collectionhelperobj.DirectoryPrint();

const string constantAttribute = "awesome";
const string constantMessage = $"Code maze is {constantAttribute}.";
Console.WriteLine(constantMessage);
Console.ReadKey();