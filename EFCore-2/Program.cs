using Castle.Components.DictionaryAdapter.Xml;
using EFCore_2.contexts;
using EFCore_2.Entities;
using EFCore_2.session3;
using System.Net;

namespace EFCore_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Inhertance Mapping
            //FullTimeEmployee fullTimeEmployee = new FullTimeEmployee()
            //    {

            //        Name = "ali",
            //        address = "Cairo",
            //        age = 25,
            //        salary = 5000,
            //        startdate=DateTime.Now
            //    };
            //    PartTimeEmployee partTimeEmployee = new PartTimeEmployee()
            //    {

            //        Name = "hamada",
            //        address = "Cairo",
            //        age = 25,
            //        countOfHour = 200,
            //        hourRate = 300
            //    };

            //    schemaDBcontext dBcontext = new schemaDBcontext();

            //    dBcontext.FullTimeEmployees.Add(fullTimeEmployee);
            //    dBcontext.PartTimeEmployees.Add(partTimeEmployee);

            //    dBcontext.SaveChanges();




            //    foreach (var item in dBcontext.FullTimeEmployees)
            //    {
            //        Console.WriteLine(item.Name);
            //    }


            //    foreach (var item in dBcontext.PartTimeEmployees)
            //    {
            //        Console.WriteLine(item.Name);
            //    }
            #endregion


            #region Egar and lazy loading

            //using schemaDBcontext context = new schemaDBcontext();

            //var Department = (from D in context.Department
            //                  where D.ID == 1
            //                  select D).FirstOrDefault();


            //Console.WriteLine($"{Department.ID} ::: {Department.Name}");





            //context.Entry(Department).Collection(D => D.Instractors).Load();



            //var Employee = (from E in context.PartTimeEmployees
            //                where E.ID == 1
            //                select E).FirstOrDefault();

            //Console.WriteLine($"{Employee.Name}");




            //foreach (var Emp in Department Emp)
            //        {

            //    Console.WriteLine(Emp);

            //};



            #endregion



            #region Linq Operators [Join]

            //using schemaDBcontext context = new schemaDBcontext();

            //var Result = from E in context.FullTimeEmployees
            //             join D in context.Department
            //             on E.DepartmentId equals D.ID
            //             where E.Address == "Cairo"
            //             select new
            //             {
            //                 EmpName = E.Name,
            //                 DeptName = D.Name


            //             };




            //         var Result = context.FullTimeEmployees.Join(context.Department,
            //E => E.DepartmentId,
            //D => D.ID,
            //(E, D) => new
            //{
            //    EmpName = E.Name,
            //    DeptName = D.Name,
            //    EmpAddress = E.address
            //}).Where(E => E.EmpAddress == "Cairo");
            #endregion


        }


    }
    
}
