using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment.Migrations
{
    /// <inheritdoc />
    public partial class RenamingTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Departments_DepartmentId",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_CrsResults_Courses_CourseId",
                table: "CrsResults");

            migrationBuilder.DropForeignKey(
                name: "FK_CrsResults_Trainees_TraineeId",
                table: "CrsResults");

            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_Courses_CourseId",
                table: "Instructors");

            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_Departments_DepartmentId",
                table: "Instructors");

            migrationBuilder.DropForeignKey(
                name: "FK_Trainees_Departments_DepartmentId",
                table: "Trainees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Trainees",
                table: "Trainees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Instructors",
                table: "Instructors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Departments",
                table: "Departments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CrsResults",
                table: "CrsResults");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Courses",
                table: "Courses");

            migrationBuilder.RenameTable(
                name: "Trainees",
                newName: "Trainee");

            migrationBuilder.RenameTable(
                name: "Instructors",
                newName: "Instructor");

            migrationBuilder.RenameTable(
                name: "Departments",
                newName: "Department");

            migrationBuilder.RenameTable(
                name: "CrsResults",
                newName: "CrsResult");

            migrationBuilder.RenameTable(
                name: "Courses",
                newName: "Course");

            migrationBuilder.RenameIndex(
                name: "IX_Trainees_DepartmentId",
                table: "Trainee",
                newName: "IX_Trainee_DepartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_Instructors_DepartmentId",
                table: "Instructor",
                newName: "IX_Instructor_DepartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_Instructors_CourseId",
                table: "Instructor",
                newName: "IX_Instructor_CourseId");

            migrationBuilder.RenameIndex(
                name: "IX_CrsResults_TraineeId",
                table: "CrsResult",
                newName: "IX_CrsResult_TraineeId");

            migrationBuilder.RenameIndex(
                name: "IX_CrsResults_CourseId",
                table: "CrsResult",
                newName: "IX_CrsResult_CourseId");

            migrationBuilder.RenameIndex(
                name: "IX_Courses_DepartmentId",
                table: "Course",
                newName: "IX_Course_DepartmentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Trainee",
                table: "Trainee",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Instructor",
                table: "Instructor",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Department",
                table: "Department",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CrsResult",
                table: "CrsResult",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Course",
                table: "Course",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Department_DepartmentId",
                table: "Course",
                column: "DepartmentId",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_CrsResult_Course_CourseId",
                table: "CrsResult",
                column: "CourseId",
                principalTable: "Course",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_CrsResult_Trainee_TraineeId",
                table: "CrsResult",
                column: "TraineeId",
                principalTable: "Trainee",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Instructor_Course_CourseId",
                table: "Instructor",
                column: "CourseId",
                principalTable: "Course",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Instructor_Department_DepartmentId",
                table: "Instructor",
                column: "DepartmentId",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Trainee_Department_DepartmentId",
                table: "Trainee",
                column: "DepartmentId",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Course_Department_DepartmentId",
                table: "Course");

            migrationBuilder.DropForeignKey(
                name: "FK_CrsResult_Course_CourseId",
                table: "CrsResult");

            migrationBuilder.DropForeignKey(
                name: "FK_CrsResult_Trainee_TraineeId",
                table: "CrsResult");

            migrationBuilder.DropForeignKey(
                name: "FK_Instructor_Course_CourseId",
                table: "Instructor");

            migrationBuilder.DropForeignKey(
                name: "FK_Instructor_Department_DepartmentId",
                table: "Instructor");

            migrationBuilder.DropForeignKey(
                name: "FK_Trainee_Department_DepartmentId",
                table: "Trainee");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Trainee",
                table: "Trainee");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Instructor",
                table: "Instructor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Department",
                table: "Department");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CrsResult",
                table: "CrsResult");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Course",
                table: "Course");

            migrationBuilder.RenameTable(
                name: "Trainee",
                newName: "Trainees");

            migrationBuilder.RenameTable(
                name: "Instructor",
                newName: "Instructors");

            migrationBuilder.RenameTable(
                name: "Department",
                newName: "Departments");

            migrationBuilder.RenameTable(
                name: "CrsResult",
                newName: "CrsResults");

            migrationBuilder.RenameTable(
                name: "Course",
                newName: "Courses");

            migrationBuilder.RenameIndex(
                name: "IX_Trainee_DepartmentId",
                table: "Trainees",
                newName: "IX_Trainees_DepartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_Instructor_DepartmentId",
                table: "Instructors",
                newName: "IX_Instructors_DepartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_Instructor_CourseId",
                table: "Instructors",
                newName: "IX_Instructors_CourseId");

            migrationBuilder.RenameIndex(
                name: "IX_CrsResult_TraineeId",
                table: "CrsResults",
                newName: "IX_CrsResults_TraineeId");

            migrationBuilder.RenameIndex(
                name: "IX_CrsResult_CourseId",
                table: "CrsResults",
                newName: "IX_CrsResults_CourseId");

            migrationBuilder.RenameIndex(
                name: "IX_Course_DepartmentId",
                table: "Courses",
                newName: "IX_Courses_DepartmentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Trainees",
                table: "Trainees",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Instructors",
                table: "Instructors",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Departments",
                table: "Departments",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CrsResults",
                table: "CrsResults",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Courses",
                table: "Courses",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Departments_DepartmentId",
                table: "Courses",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_CrsResults_Courses_CourseId",
                table: "CrsResults",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_CrsResults_Trainees_TraineeId",
                table: "CrsResults",
                column: "TraineeId",
                principalTable: "Trainees",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Instructors_Courses_CourseId",
                table: "Instructors",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Instructors_Departments_DepartmentId",
                table: "Instructors",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Trainees_Departments_DepartmentId",
                table: "Trainees",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }
    }
}
