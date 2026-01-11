using citiesapi.Model;

namespace citiesapi.Data
{
    public static class DataSource
    {
        //public static List<Employee> EmployeeData()
        //{
        //    return new List<Employee>
        //    {
        //        new Employee{EmpId=1,EmpName="Ram"},
        //        new Employee{EmpId=2,EmpName="Rahim"},
        //        new Employee{EmpId=3,EmpName="Akbar"},
        //        new Employee{EmpId=4,EmpName="Lakshman"}
        //    };
        //}

        public static List<Employee> Employees = new List<Employee>
        {
            new Employee { EmpId = 1, EmpName = "Ram", DepartmentId = 02, Role ="audit"},
            new Employee { EmpId = 2, EmpName = "Rahim", DepartmentId = 02, Role ="audit"},
            new Employee { EmpId = 3, EmpName = "Akbar", DepartmentId = 03, Role ="HR"},
            new Employee { EmpId = 4, EmpName = "Lakshman", DepartmentId = 04, Role ="network admin"}
        };

        public static List<Department> Departments = new List<Department>
        {
            new Department { DepartmentId = 01, DepartmentName = "IT"},
            new Department { DepartmentId = 02, DepartmentName = "FINANCE"},
            new Department { DepartmentId = 03, DepartmentName = "HR"},
            new Department { DepartmentId = 04, DepartmentName = "ADMIN"}
        };

        public static List<User> usersData = new List<User>
        {
            new User { UserId = 1, UserName = "Ram" ,Email = "xyz@mail.com", IsActive = true},
            new User { UserId = 2, UserName = "Rahim" ,Email = "xyz@mail.com", IsActive = false},
            new User { UserId = 3, UserName = "Ramzy" ,Email = "xyz@mail.com", IsActive = true},
            new User { UserId = 4, UserName = "Rahul" ,Email = "xyz@mail.com", IsActive = false}
        };

        public static List<Customer> custData = new List<Customer>
        {
            new Customer { CustomerId = 1, CustomerName = "Ram" },
            new Customer { CustomerId = 2, CustomerName = "Rahim" }
        };

        public static List<Order> OrderData = new List<Order>
        {
            new Order { OrderId = 1, ProductName = "Phone", Quantity = 2 },
            new Order { OrderId = 2, ProductName = "EarPhone", Quantity = 1}
        };
    }
}
