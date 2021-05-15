namespace VisitorPattern
{
    public class Employee : Element
    {
        public string Name { get; set; }
        public double AnnualSalary { get; set; }
        public int PaidTimeOffDays { get; set; }

        public Employee(string name, double annualSalary, int paidTimeOffDays)
        {
            Name = name;
            AnnualSalary = annualSalary;
            PaidTimeOffDays = paidTimeOffDays;
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
