using System;

namespace VisitorPattern
{
    public class PaidTimeOffVisitor : IVisitor
    {
        public void Visit(Element element)
        {
            Employee employee = element as Employee;

            // And because you all helped have such a great year, 
            // all my employees get three extra paid time off days each!
            employee.PaidTimeOffDays += 3;
            Console.WriteLine("{0} {1}'s new vacation days: {2}", employee.GetType().Name, employee.Name, employee.PaidTimeOffDays);
        }
    }
}
