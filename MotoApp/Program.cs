using MotoApp.Data;
using MotoApp.Enities;
using MotoApp.Repositories;


var EmployeeRepository = new SqlRepositor<Employee>(new MotoAppDbContext());
AddEmployees(EmployeeRepository);
AddMenagers(EmployeeRepository);
WriteAllConsole(EmployeeRepository);

static void AddEmployees(IReposytory<Employee>EmployeeRepository)
{
    EmployeeRepository.Add(new Employee { Name = "Piotr" });
    EmployeeRepository.Add(new Employee { Name = "Adam" });
    EmployeeRepository.Add(new Employee { Name = "Zuza" });
    EmployeeRepository.Add(new Employee { Name = "Damian" });
    EmployeeRepository.Save();
}

static void AddMenagers(IWriteRepository<Menager> MenagerRepository)
{
    MenagerRepository.Add(new Menager { Name = "Karol" });
    MenagerRepository.Add(new Menager { Name = "Alicja" });
    MenagerRepository.Add(new Menager { Name = "Klara" });
    MenagerRepository.Add(new Menager { Name = "Antoni" });
    MenagerRepository.Save();
}

static void WriteAllConsole(IReadRepository<IEntitis> repository)
{
    var items = repository.GetAll();
    foreach (var item in items)
    {
        Console.WriteLine(item);
    }
}