using citiesapi.Data;
using citiesapi.Model;
using Microsoft.AspNetCore.Mvc;

namespace citiesapi.Controllers
{
    [ApiController]
    [Route("api/Cities")] //Base route for the controller

    public class CitiesController : ControllerBase
    {
        //[HttpGet] // Specific method route + HTTP verb

        ////1. Returning One Value (int premetive type returning)
        //public int sum()
        //{
        //    int a = 4;
        //    int b = 1;
        //    return a + b; // automatically converts to JSON Output: 5
        //}

        //[HttpGet("username")] // Specific method route + HTTP verb

        ////2. Returning One Value (string premetive type returning)
        //public string name()
        //{
        //    return "Welcome Pervez"; // automatically converts to JSON Output: Pervez
        //}

        //[HttpGet("checkachar")] // Specific method route + HTTP verb

        ////3. Returning One Value (boolean premetive type returning)
        //public bool checkachar()
        //{
        //    string a = "John";
        //    return a.Contains("o"); // automatically converts to JSON Output: true
        //}

        //// returning an object
        //[HttpGet("employee")]
        //public object Employee()
        //{
        //    return new { id = 1, name = "Rubina", salary = 1000000 };
        //}

        //// returning multiple record
        //[HttpGet("records")]
        //public List<object> EmployeeRecords()
        //{
        //    var list = new List<object>
        //    {
        //        "text",
        //        10,
        //        99.9,
        //        true,
        //        new { id = 1, name = "Rubina" },
        //        new List<int> {1, 2, 3}
        //    };

        //    return list;
        //}

        //[HttpGet("recordss")]
        //public List<string> EmployeeRecords1()
        //{
        //    var records = new List<string>
        //    {
        //        "Rubina",
        //        "Sayed",
        //        "Hello"
        //    };

        //    return records;
        //}

        ////“Return country name and list of cities”
        //// country = Single value
        //// cities = Multiple values
        //// combined = Object

        ////Different data types → Object
        ////Same data types → List
        ////One thing → Single value

        //[HttpGet("citylist1")]
        //public object citylist1()
        //{
        //    var list = new
        //    {
        //        Country = "India",
        //        Cities = new List<string> {"delhi","mumbai","bangalore"}
        //    };
        //    return list;
        //}

        ////“Return employee id and employee name”
        //[HttpGet("EmployeeDetails")]
        //public object empdetails()
        //{
        //    return new { employeeId = 10, employeeName= "sayed" };
        //}
        ////“Return list of employees, where each employee has id and name”
        //[HttpGet("EmployeeList")]
        //public List<object> EmployeeList()
        //{
        //    var employees = new List<object>
        //    {
        //        new { employeeId = 1, employeeName= "sayed" },
        //        new { employeeId = 2, employeeName= "ram" },
        //        new { employeeId = 3, employeeName= "sita" }

        //    };
        //    return employees;
        //}

        ////“Return department name and list of employees”
        //[HttpGet("department")]
        //public object department()
        //{
        //    var dept = new
        //    {
        //        deptName = "IT",
        //        employees = new List<object>
        //        {
        //            new  {employeeId = 1, employeeName= "sita" },
        //            new  {employeeId = 2, employeeName= "ram" }
        //        }
        //    };
        //    return dept;
        //}

        ////“Return order id, customer name, and list of purchased product names”
        //[HttpGet("Purchase")]
        //public object Purchase()
        //{
        //    var purchaseDetails = new
        //    {
        //        order_id = 10,
        //        customer_name = "sayedPervez",
        //        products = new List<string>
        //        {
        //           "kajal","blush","suit"
        //        }
        //    };

        //    return purchaseDetails;
        //}
        ////“Return order id and total amount”
        //[HttpGet("order")]
        //public object order()
        //{
        //    var obj = new
        //    {
        //        OrderId = 10,
        //        TotalAmount = 123 
        //    };
        //    return obj;
        //}

        ////“Return list of product prices”
        //[HttpGet("productprice")]
        //public List<int> productprice()
        //{

        //    var productPrice = new List<int> { 100,200,300,232,234};
        //    return productPrice;
        //}

        ////“Return employee name, age, and department”
        //[HttpGet("empinfo")]
        //public object empinfo()
        //{
        //    var employee = new
        //    {
        //        emp_name = "sayed",
        //        age = 10,
        //        department = "computers"
        //    };
        //    return employee;
        //}

        ////“Return list of students, where each student has name and marks”
        //[HttpGet("studentinfo")]
        //public List<object> studentinfo()
        //{
        //    var studentList = new List<object>
        //    {
        //        new { name = "sayed", marks = new List<int>{10,20,30} },
        //        new { name = "ruby", marks = new List<int>{10,20,30} }
        //    };
        //    return studentList;
        //}

        ////“Return country name and for each city, its name and population”
        //[HttpGet("countryinfo")]
        //public object countryinfo()
        //{
        //    var country = new
        //    {
        //        Name = "India",
        //        Cities = new List<object>
        //        {
        //            new { Name = "Bangalore", Population = 10000 },
        //            new { Name = "Mumbai", Population = 20000 },
        //            new { Name = "Hyderabad", Population = 15000 }
        //        }
        //    };
        //    return country;
        //}

        //[HttpGet("Orderdetails")]

        //public ActionResult<List<object>> OrderDetails()
        //{
        //    var orderDetails = new List<object>
        //    {
        //        new {order_Id = 1, customer_Name= "SayedPervez"},
        //        new {order_Id = 2, customer_Name= "Ram"}
        //    };

        //    if (orderDetails is null || orderDetails.Count == 0)
        //    {
        //        return NotFound("no orders found");
        //    }

        //    return orderDetails;
        //}

        //[HttpGet]
        //public ActionResult<List<string>> GetNames()
        //{
        //    return Ok(new List<string>{"sayed","rubina","pervez"});
        //}


        ////[HttpPost("CreateEmployee")]

        ////public ActionResult<Employee> CreateEmployee(Employee emp)
        ////{
        ////    var employees = new List<Employee>();

        ////    if(emp == null)
        ////    {
        ////        return BadRequest("Employee data is required");
        ////    }

        ////    employees.Add(emp);

        ////    return Ok(emp);
        ////}


        //[HttpPost("CreateEmployees")]
        //public ActionResult<List<Employee>> CreateEmployees(List<Employee> emp)
        //{
        //    if (emp == null)
        //    {
        //        return BadRequest("Employee data is required");
        //    }
        //    else if (!emp.Any())
        //    {
        //        return BadRequest("Employee list cannot be empty");
        //    }

        //    foreach (var e in emp)
        //    {
        //        if (e.EmpId <= 0)
        //        {
        //            return BadRequest("Employee Id must be greater than zero");
        //        }

        //        if (string.IsNullOrWhiteSpace(e.EmpName))
        //        {
        //            return BadRequest("Employee Name is required");
        //        }
        //    }

        //    DataSource.Employees.AddRange(emp);

        //    return Ok(emp);
        //}

        //[HttpPost("CreateEmployee")]

        //public ActionResult<Employee> CreateEmployee(Employee emp)
        //{

        //    if (emp == null)
        //    {
        //        return BadRequest("Employee data is required");
        //    }

        //    var checkNameExist = DataSource.Employees.Exists(e => e.EmpName.Equals(emp.EmpName, StringComparison.OrdinalIgnoreCase));

        //    if(checkNameExist)
        //    {
        //        return Conflict("Employee Name already exist");
        //    }

        //    DataSource.Employees.Add(emp);

        //    return Ok(emp);
        //}

        //[HttpPost("Departments/{department}/employees")]

        //public ActionResult<Employee> CreateEmployee(string department, Employee emp)
        //{

        //    if (emp == null)
        //    {
        //        return BadRequest("Employee data is required");
        //    }

        //    if (string.IsNullOrWhiteSpace(department))
        //    {
        //        return BadRequest("Department data is required");
        //    }

        //    var checkNameExist = DataSource.Employees.Any(e => e.EmpName.Equals(emp.EmpName, StringComparison.OrdinalIgnoreCase));

        //    if (checkNameExist)
        //    {
        //        return Conflict("Employee Name already exist");
        //    }

        //    var empId = DataSource.Employees.Any() ? DataSource.Employees.Max(e=>e.EmpId) +1 : 1 ;
        //    emp.EmpId = empId;
        //    emp.DepartmentName = department;
        //    DataSource.Employees.Add(emp);

        //    return Ok(emp);
        //}
        [HttpPut("departments/{departmentid}/employees/{employeeid}")]

        public IActionResult UpdateEmployee([FromRoute] int departmentid, [FromRoute] int employeeid, [FromBody] Employee emp)
        {

            if (emp == null)
            {
                return BadRequest("Employee data is required");
            }

            if (departmentid < 0)
            {
                return BadRequest("Invalid departmentid");
            }

            if (employeeid < 0)
            {
                return BadRequest("Invalid employeeid");
            }

            if (employeeid != emp.EmpId)
            {
                return BadRequest("Invalid employeeid mismatch");
            }

            var checkDeptExist = DataSource.Departments.FirstOrDefault(e => e.DepartmentId == departmentid);

            if (checkDeptExist == null)
            {
                return NotFound($"Department with Id {departmentid} doesn't exist");
            }

            var checkEmpExist = DataSource.Employees.FirstOrDefault(e => e.EmpId == employeeid);

            if (checkEmpExist == null)
            {
                return NotFound($"Employee with Id {employeeid} doesn't exist");
            }

            if(checkEmpExist.DepartmentId != departmentid)
            {
                return NotFound($"Employee with Id {employeeid} doesn't belong to Department {departmentid}");
            }
            

            checkEmpExist.EmpName = emp.EmpName;
            checkEmpExist.Role = emp.Role;

            return NoContent();
            //return Ok(emp);
        }
    }
}
