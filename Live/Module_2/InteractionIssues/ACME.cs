namespace InteractionIssues;

internal class ACME
{
    private List<IContract> employees = new List<IContract>();

    public void Hire(IContract employee)
    {
        employees.Add(employee);
    }

    public void Start()
    {
        Console.WriteLine("ACME starts producing stuff");
        foreach (IContract employee in employees)
        {
            employee.Work();
        }
    }
}
