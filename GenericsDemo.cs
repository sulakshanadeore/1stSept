using System;
using System.Collections.Generic;
using InheritancePolyDemo;
using OOPsLibrary;
using CollectionsLibDemo;
namespace CollectionsDemo
{
    class GenericsDemo
    {
        static void Main(string[] args)
        {

            EmployeeDataAccessLayer dal = new EmployeeDataAccessLayer();
            List<EmpBusinessLogicLayer> empBusinessLogics =dal.GetList();
            foreach (var item  in empBusinessLogics)
            {
                Console.WriteLine(item.EmpNo);
                Console.WriteLine(item.Empname);
                Console.WriteLine(item.DepartmentNo);
                Console.WriteLine(item.Salary);
            }
        //    List<int> list = new List<int>();
        //    list.Add(13);
        //    list.Add(1333);
        //    list.Add(2213);
        //    list.Add(1223);

        //    List<Employee> emplist = new List<Employee>();
        //    //collection---- list
        //    emplist.Add(new Employee
        //    { Empid = 1, Deptno = 10, JoiningDate = new DateTime(2021, 09, 08), Salary = 23423f }
        //    );


        //    Employee emp = new Employee();
        //    emp.Empid = 2;
        //    emp.Deptno = 20;
        //    emp.JoiningDate = new DateTime(1998, 09, 07);

        //    emplist.Add(emp);


        //    emplist.Add(new Employee());

        //    foreach (var item in emplist)
        //    {
        //        Console.WriteLine(item.Empid);
        //        Console.WriteLine(item.Deptno);
        //        Console.WriteLine(item.JoiningDate);
        //        Console.WriteLine(item.Salary);
        //        Console.WriteLine("-------------");
        //    }
            
        //    List<Student> people = new List<Student>();
        //    people.Add(new Student("Jack", "First"));
        //people.Add(new Student());


        //    List<OOPsLibrary.Products> p = new List<Products>();
        //    Products p1 = new Products();
        //    p1.ProductID = 1;
        //    p1.ProductName = "ABC";
        //    p1.SupplierID = 1;
        //    p1.UnitPrice = 3345;

        //    p.Add(p1);


        //    Dictionary<int, Employee> dict = new Dictionary<int, Employee>();
        //    dict.Add(1, new Employee { Salary = 23423f,Empid = 1, Deptno = 10, JoiningDate = new DateTime(2021, 09, 08)} );


        //    dict.Add(2, emp);
        //    Dictionary<int,Employee>.Enumerator idict=dict.GetEnumerator();
        //    while (idict.MoveNext())
        //    {
        //        Console.WriteLine(idict.Current.Key);
        //        Console.WriteLine(idict.Current.Value.Empid);
        //        Console.WriteLine(idict.Current.Value.JoiningDate);
        //        Console.WriteLine(idict.Current.Value.Deptno);
        //        Console.WriteLine(idict.Current.Value.Salary);
        //        Console.WriteLine();
        //    }
        //    foreach (KeyValuePair<int, Employee> item in dict)
        //    {
        //        Console.WriteLine(item.Key);
                
        //        Console.WriteLine(item.Value.Empid);
        //        Console.WriteLine(item.Value.JoiningDate);
        //        Console.WriteLine(item.Value.Deptno);
        //        Console.WriteLine(item.Value.Salary);
        //        Console.WriteLine();
        //    }

        //    //SortedList----data in sorted format
        //    //    SortedDictionary---Data is in unsorted format

            Console.Read();


        }
    }
}
