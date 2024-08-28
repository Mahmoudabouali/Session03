using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Session03.Migrations
{
    /// <inheritdoc />
    public partial class addView : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"create View DepartmentEmployeesView
As
select e.id EmployeeId, e.name EmployeeName, d.id DepartmentId, d.name DepartmentName
from Employees e , Departments d
where e.Id = d.Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"drop View DepartmentEmployeesView");
        }
    }
}
