using Microsoft.EntityFrameworkCore;
using Session03.Context;

namespace Session03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using AppDbContext DbContext = new AppDbContext();

            #region MyRegion
            //foreach (var item in DbContext.DepartmentEmployee)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Sql
            //var result = DbContext.Employees.FromSqlRaw("select * from Employees e where e.id >3");

            //int id = 3;
            //var result = DbContext.Employees.FromSqlInterpolated($"select * from Employees e where e.id >{id}");

            //var rows = DbContext.Database.ExecuteSqlRaw(@"update Employees
            //                                      set Name = 'mohsen'
            //                                            where id = 4");
            //var rows = DbContext.Database.ExecuteSqlInterpolated($"update Employees
            //                                      set Name = 'mohsen'
            //                                            where id = {id}");
            //Console.WriteLine(rows);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.Name);
            //}
            #endregion
        }
    }
}
