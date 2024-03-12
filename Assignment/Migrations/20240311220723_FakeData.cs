using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Assignment.Migrations
{
    /// <inheritdoc />
    public partial class FakeData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Crs_Id",
                table: "CrsResult");

            migrationBuilder.DropColumn(
                name: "Trianee_Id",
                table: "CrsResult");

            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "Id", "ManagerName", "Name" },
                values: new object[,]
                {
                    { 1, "Christien Zarief", "Web development" },
                    { 2, "Abanoub Nabiel", "UI/UX" },
                    { 3, "Josephine Poulas", "Open source" },
                    { 4, "Samantha Lin", "Mobile development" },
                    { 5, "Daniel Rodriguez", "Data Science" },
                    { 6, "Sophia Patel", "Quality Assurance" },
                    { 7, "Michael Johnson", "Project Management" },
                    { 8, "Liam Smith", "Network Engineering" },
                    { 9, "Emily Chen", "Cloud Computing" }
                });

            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "Id", "Degree", "DepartmentId", "Hours", "MinDegree", "Name" },
                values: new object[,]
                {
                    { 1, 100, 1, 40, 90, "Introduction to Web Development" },
                    { 2, 90, 2, 30, 80, "User Interface Design Fundamentals" },
                    { 3, 95, 3, 35, 85, "Open Source Technologies" },
                    { 4, 95, 4, 35, 85, "Mobile App Development" },
                    { 5, 90, 5, 30, 80, "Introduction to Data Science" },
                    { 6, 85, 6, 25, 75, "Software Quality Assurance" },
                    { 7, 80, 7, 20, 70, "Project Management Fundamentals" },
                    { 8, 85, 8, 25, 75, "Network Fundamentals" },
                    { 9, 90, 9, 30, 80, "Cloud Computing Essentials" },
                    { 10, 85, 1, 25, 75, "Database Management Systems" },
                    { 11, 90, 2, 30, 80, "Cybersecurity Fundamentals" },
                    { 12, 85, 3, 25, 75, "Artificial Intelligence Basics" },
                    { 13, 90, 4, 30, 80, "Machine Learning Essentials" },
                    { 14, 90, 5, 30, 80, "Big Data Analytics" },
                    { 15, 85, 6, 25, 75, "Software Engineering Principles" },
                    { 16, 85, 7, 25, 75, "Computer Graphics Fundamentals" },
                    { 17, 90, 8, 30, 80, "Internet of Things (IoT) Essentials" },
                    { 18, 85, 9, 25, 75, "Software Testing Techniques" },
                    { 19, 80, 1, 20, 70, "Web Design Fundamentals" },
                    { 20, 90, 2, 30, 80, "Agile Development Methodologies" },
                    { 21, 95, 3, 35, 85, "Advanced Web Development" },
                    { 22, 85, 4, 25, 75, "User Experience Design" },
                    { 23, 95, 5, 35, 85, "Software Architecture" },
                    { 24, 90, 6, 30, 80, "iOS App Development" },
                    { 25, 85, 7, 25, 75, "Data Mining Techniques" },
                    { 26, 80, 8, 20, 70, "Agile Project Management" },
                    { 27, 90, 9, 30, 80, "Network Security" },
                    { 28, 85, 1, 25, 75, "Cloud Infrastructure Management" },
                    { 29, 90, 2, 30, 80, "Relational Database Design" },
                    { 30, 85, 3, 25, 75, "Ethical Hacking" }
                });

            migrationBuilder.InsertData(
                table: "Trainee",
                columns: new[] { "Id", "Address", "DepartmentId", "Grade", "Image", "Name" },
                values: new object[,]
                {
                    { 1, "123 Main St", 1, 90, "emily_smith.jpg", "Emily Smith" },
                    { 2, "456 Elm St", 2, 85, "michael_johnson.jpg", "Michael Johnson" },
                    { 3, "789 Oak St", 3, 92, "emma_williams.jpg", "Emma Williams" },
                    { 4, "101 Pine St", 4, 88, "noah_brown.jpg", "Noah Brown" },
                    { 5, "111 Cedar St", 5, 91, "olivia_davis.jpg", "Olivia Davis" },
                    { 6, "222 Maple St", 6, 86, "james_miller.jpg", "James Miller" },
                    { 7, "333 Walnut St", 7, 94, "sophia_wilson.jpg", "Sophia Wilson" },
                    { 8, "444 Ash St", 8, 87, "william_garcia.jpg", "William Garcia" },
                    { 9, "555 Birch St", 9, 93, "isabella_rodriguez.jpg", "Isabella Rodriguez" },
                    { 10, "666 Pine St", 1, 89, "liam_martinez.jpg", "Liam Martinez" },
                    { 11, "777 Elm St", 2, 90, "emma_anderson.jpg", "Emma Anderson" },
                    { 12, "888 Oak St", 3, 84, "jacob_thompson.jpg", "Jacob Thompson" },
                    { 13, "999 Maple St", 4, 95, "mia_moore.jpg", "Mia Moore" },
                    { 14, "1010 Cedar St", 5, 88, "ethan_jackson.jpg", "Ethan Jackson" },
                    { 15, "1111 Pine St", 6, 92, "amelia_white.jpg", "Amelia White" },
                    { 16, "1212 Elm St", 7, 86, "logan_harris.jpg", "Logan Harris" },
                    { 17, "1313 Oak St", 8, 93, "ava_martin.jpg", "Ava Martin" },
                    { 18, "1414 Walnut St", 9, 85, "lucas_nelson.jpg", "Lucas Nelson" },
                    { 19, "1515 Ash St", 1, 94, "ella_thompson.jpg", "Ella Thompson" },
                    { 20, "1616 Birch St", 2, 89, "lily_lewis.jpg", "Lily Lewis" },
                    { 21, "1717 Maple St", 3, 91, "liam_hall.jpg", "Liam Hall" },
                    { 22, "1818 Cedar St", 4, 86, "zoe_walker.jpg", "Zoe Walker" },
                    { 23, "1919 Pine St", 5, 90, "jackson_perez.jpg", "Jackson Perez" },
                    { 24, "2020 Elm St", 6, 88, "mia_harris.jpg", "Mia Harris" },
                    { 25, "2121 Oak St", 7, 92, "jacob_clark.jpg", "Jacob Clark" },
                    { 26, "2222 Walnut St", 8, 85, "chloe_lee.jpg", "Chloe Lee" },
                    { 27, "2323 Ash St", 9, 93, "ethan_martinez.jpg", "Ethan Martinez" },
                    { 28, "2424 Birch St", 1, 87, "madison_harris.jpg", "Madison Harris" },
                    { 29, "2525 Maple St", 2, 95, "charlotte_thompson.jpg", "Charlotte Thompson" },
                    { 30, "2626 Cedar St", 3, 86, "ryan_moore.jpg", "Ryan Moore" },
                    { 31, "2727 Pine St", 4, 90, "mia_hernandez.jpg", "Mia Hernandez" },
                    { 32, "2828 Elm St", 5, 88, "ethan_brown.jpg", "Ethan Brown" },
                    { 33, "2929 Oak St", 6, 92, "sophia_lewis.jpg", "Sophia Lewis" },
                    { 34, "3030 Walnut St", 7, 87, "mason_harris.jpg", "Mason Harris" },
                    { 35, "3131 Ash St", 8, 94, "ava_gonzalez.jpg", "Ava Gonzalez" },
                    { 36, "3232 Birch St", 9, 85, "michael_perez.jpg", "Michael Perez" },
                    { 37, "3333 Maple St", 1, 93, "isabella_jackson.jpg", "Isabella Jackson" },
                    { 38, "3434 Cedar St", 2, 89, "liam_moore.jpg", "Liam Moore" },
                    { 39, "3535 Pine St", 3, 91, "charlotte_davis.jpg", "Charlotte Davis" },
                    { 40, "3636 Elm St", 4, 86, "ella_rodriguez.jpg", "Ella Rodriguez" },
                    { 41, "3737 Oak St", 5, 90, "lucas_martinez.jpg", "Lucas Martinez" },
                    { 42, "3838 Walnut St", 6, 88, "sophia_thompson.jpg", "Sophia Thompson" },
                    { 43, "3939 Ash St", 7, 92, "mason_johnson.jpg", "Mason Johnson" },
                    { 44, "4040 Birch St", 8, 87, "ava_harris.jpg", "Ava Harris" },
                    { 45, "4141 Maple St", 9, 94, "william_martinez.jpg", "William Martinez" },
                    { 46, "4242 Cedar St", 1, 85, "emma_anderson.jpg", "Emma Anderson" },
                    { 47, "4343 Pine St", 2, 93, "jacob_thompson.jpg", "Jacob Thompson" },
                    { 48, "4444 Elm St", 3, 89, "mia_moore.jpg", "Mia Moore" },
                    { 49, "4545 Oak St", 4, 91, "ethan_jackson.jpg", "Ethan Jackson" },
                    { 50, "4646 Walnut St", 5, 86, "amelia_white.jpg", "Amelia White" },
                    { 51, "4747 Ash St", 6, 90, "logan_harris.jpg", "Logan Harris" },
                    { 52, "4848 Birch St", 7, 88, "ava_martin.jpg", "Ava Martin" },
                    { 53, "4949 Maple St", 8, 92, "lucas_nelson.jpg", "Lucas Nelson" },
                    { 54, "5050 Cedar St", 9, 87, "ella_thompson.jpg", "Ella Thompson" },
                    { 55, "5151 Pine St", 1, 94, "lily_lewis.jpg", "Lily Lewis" },
                    { 56, "5252 Elm St", 2, 85, "liam_hall.jpg", "Liam Hall" },
                    { 57, "5353 Oak St", 3, 93, "zoe_walker.jpg", "Zoe Walker" },
                    { 58, "5454 Walnut St", 4, 89, "jackson_perez.jpg", "Jackson Perez" },
                    { 59, "5555 Ash St", 5, 91, "mia_harris.jpg", "Mia Harris" },
                    { 60, "5656 Birch St", 6, 86, "jacob_clark.jpg", "Jacob Clark" },
                    { 61, "5757 Maple St", 7, 90, "chloe_lee.jpg", "Chloe Lee" },
                    { 62, "5858 Cedar St", 8, 88, "ethan_martinez.jpg", "Ethan Martinez" },
                    { 63, "5959 Pine St", 9, 92, "madison_harris.jpg", "Madison Harris" },
                    { 64, "6060 Elm St", 1, 87, "charlotte_thompson.jpg", "Charlotte Thompson" },
                    { 65, "6161 Oak St", 2, 94, "ryan_moore.jpg", "Ryan Moore" },
                    { 66, "6262 Walnut St", 3, 85, "mia_hernandez.jpg", "Mia Hernandez" },
                    { 67, "6363 Ash St", 4, 93, "ethan_brown.jpg", "Ethan Brown" },
                    { 68, "6464 Birch St", 5, 89, "sophia_lewis.jpg", "Sophia Lewis" },
                    { 69, "6565 Maple St", 6, 91, "mason_harris.jpg", "Mason Harris" },
                    { 70, "6666 Cedar St", 7, 86, "ava_gonzalez.jpg", "Ava Gonzalez" },
                    { 71, "6767 Pine St", 8, 90, "michael_perez.jpg", "Michael Perez" },
                    { 72, "6868 Elm St", 9, 88, "isabella_jackson.jpg", "Isabella Jackson" },
                    { 73, "6969 Oak St", 1, 92, "liam_moore.jpg", "Liam Moore" },
                    { 74, "7070 Walnut St", 2, 87, "charlotte_davis.jpg", "Charlotte Davis" },
                    { 75, "7171 Ash St", 3, 94, "ella_rodriguez.jpg", "Ella Rodriguez" },
                    { 76, "7272 Birch St", 4, 85, "lucas_martinez.jpg", "Lucas Martinez" },
                    { 77, "7373 Maple St", 5, 93, "sophia_thompson.jpg", "Sophia Thompson" },
                    { 78, "7474 Cedar St", 6, 89, "mason_johnson.jpg", "Mason Johnson" },
                    { 79, "7575 Pine St", 7, 91, "ava_harris.jpg", "Ava Harris" },
                    { 80, "7676 Elm St", 8, 86, "william_martinez.jpg", "William Martinez" },
                    { 81, "7777 Oak St", 9, 90, "emma_anderson.jpg", "Emma Anderson" },
                    { 82, "7878 Walnut St", 1, 88, "jacob_thompson.jpg", "Jacob Thompson" },
                    { 83, "7979 Ash St", 2, 92, "mia_moore.jpg", "Mia Moore" },
                    { 84, "8080 Birch St", 3, 87, "ethan_jackson.jpg", "Ethan Jackson" },
                    { 85, "8181 Maple St", 4, 94, "amelia_white.jpg", "Amelia White" },
                    { 86, "8282 Cedar St", 5, 85, "logan_harris.jpg", "Logan Harris" },
                    { 87, "8383 Pine St", 6, 93, "ava_martin.jpg", "Ava Martin" },
                    { 88, "8484 Elm St", 7, 89, "lucas_nelson.jpg", "Lucas Nelson" },
                    { 89, "8585 Oak St", 8, 91, "ella_thompson.jpg", "Ella Thompson" },
                    { 90, "8686 Walnut St", 9, 86, "lily_lewis.jpg", "Lily Lewis" },
                    { 91, "8787 Ash St", 1, 90, "liam_hall.jpg", "Liam Hall" },
                    { 92, "8888 Birch St", 2, 88, "zoe_walker.jpg", "Zoe Walker" },
                    { 93, "8989 Maple St", 3, 92, "jackson_perez.jpg", "Jackson Perez" },
                    { 94, "9090 Cedar St", 4, 87, "mia_harris.jpg", "Mia Harris" }
                });

            migrationBuilder.InsertData(
                table: "CrsResult",
                columns: new[] { "Id", "CourseId", "Degree", "TraineeId" },
                values: new object[,]
                {
                    { 1, 1, 80, 1 },
                    { 2, 2, 82, 2 },
                    { 3, 3, 85, 3 },
                    { 4, 4, 79, 4 },
                    { 5, 5, 81, 5 },
                    { 6, 6, 83, 6 },
                    { 7, 7, 86, 7 },
                    { 8, 8, 88, 8 },
                    { 9, 9, 90, 9 },
                    { 10, 10, 88, 10 },
                    { 11, 11, 86, 11 },
                    { 12, 12, 84, 12 },
                    { 13, 13, 82, 13 },
                    { 14, 14, 80, 14 },
                    { 15, 15, 78, 15 },
                    { 16, 16, 85, 16 },
                    { 17, 17, 83, 17 },
                    { 18, 18, 81, 18 },
                    { 19, 19, 79, 19 },
                    { 20, 20, 77, 20 },
                    { 21, 1, 85, 21 },
                    { 22, 2, 78, 22 },
                    { 23, 3, 84, 23 },
                    { 24, 4, 81, 24 },
                    { 25, 5, 80, 25 },
                    { 26, 6, 82, 26 },
                    { 27, 7, 85, 27 },
                    { 28, 8, 78, 28 },
                    { 29, 9, 84, 29 },
                    { 30, 10, 81, 30 },
                    { 31, 11, 80, 31 },
                    { 32, 12, 82, 32 },
                    { 33, 13, 85, 33 },
                    { 34, 14, 78, 34 },
                    { 35, 15, 84, 35 },
                    { 36, 16, 81, 36 },
                    { 37, 17, 80, 37 },
                    { 38, 18, 82, 38 },
                    { 39, 19, 85, 39 },
                    { 40, 20, 78, 40 },
                    { 41, 1, 84, 41 },
                    { 42, 2, 81, 42 },
                    { 43, 3, 80, 43 },
                    { 44, 4, 82, 44 },
                    { 45, 5, 85, 45 },
                    { 46, 6, 78, 46 },
                    { 47, 7, 84, 47 },
                    { 48, 8, 81, 48 },
                    { 49, 9, 80, 49 },
                    { 50, 10, 82, 50 },
                    { 51, 11, 85, 51 },
                    { 52, 12, 78, 52 },
                    { 53, 13, 84, 53 },
                    { 54, 14, 81, 54 },
                    { 55, 15, 80, 55 },
                    { 56, 16, 82, 56 },
                    { 57, 17, 85, 57 },
                    { 58, 18, 78, 58 },
                    { 59, 19, 84, 59 },
                    { 60, 20, 81, 60 },
                    { 61, 1, 80, 61 },
                    { 62, 2, 82, 62 },
                    { 63, 3, 85, 63 },
                    { 64, 4, 78, 64 },
                    { 65, 5, 84, 65 },
                    { 66, 6, 81, 66 },
                    { 67, 7, 80, 67 },
                    { 68, 8, 82, 68 },
                    { 69, 9, 85, 69 },
                    { 70, 10, 78, 70 },
                    { 71, 11, 84, 71 },
                    { 72, 12, 81, 72 },
                    { 73, 13, 80, 73 },
                    { 74, 14, 82, 74 },
                    { 75, 15, 85, 75 },
                    { 76, 16, 78, 76 },
                    { 77, 17, 84, 77 },
                    { 78, 18, 81, 78 },
                    { 79, 19, 80, 79 },
                    { 80, 20, 82, 80 },
                    { 81, 1, 85, 81 },
                    { 82, 2, 78, 82 },
                    { 83, 3, 84, 83 },
                    { 84, 4, 81, 84 },
                    { 85, 5, 80, 85 },
                    { 86, 6, 82, 86 },
                    { 87, 7, 85, 87 },
                    { 88, 8, 78, 88 },
                    { 89, 9, 84, 89 },
                    { 90, 10, 81, 90 },
                    { 91, 11, 80, 91 },
                    { 92, 12, 82, 92 },
                    { 93, 13, 85, 93 },
                    { 94, 14, 78, 94 },
                    { 95, 15, 84, 81 },
                    { 96, 16, 81, 92 },
                    { 97, 17, 80, 65 },
                    { 98, 18, 82, 82 },
                    { 99, 19, 85, 63 },
                    { 100, 20, 78, 86 },
                    { 101, 1, 78, 39 },
                    { 102, 2, 84, 94 },
                    { 103, 3, 81, 76 },
                    { 104, 4, 80, 64 },
                    { 105, 5, 82, 13 },
                    { 106, 6, 85, 42 },
                    { 107, 7, 78, 53 },
                    { 108, 8, 84, 43 },
                    { 109, 9, 81, 93 },
                    { 110, 10, 80, 10 },
                    { 111, 11, 82, 11 },
                    { 112, 12, 85, 12 },
                    { 113, 13, 78, 13 },
                    { 114, 14, 84, 14 },
                    { 115, 15, 81, 15 },
                    { 116, 16, 80, 16 },
                    { 117, 17, 82, 17 },
                    { 118, 18, 85, 18 },
                    { 119, 19, 78, 19 },
                    { 120, 20, 84, 20 },
                    { 121, 1, 81, 11 },
                    { 122, 2, 80, 12 },
                    { 123, 3, 82, 13 },
                    { 124, 4, 85, 14 },
                    { 125, 5, 78, 15 },
                    { 126, 6, 84, 16 },
                    { 127, 7, 81, 17 },
                    { 128, 8, 80, 18 },
                    { 129, 9, 82, 19 },
                    { 130, 10, 85, 10 },
                    { 131, 11, 78, 11 },
                    { 132, 12, 84, 12 },
                    { 133, 13, 81, 13 },
                    { 134, 14, 80, 14 },
                    { 135, 15, 82, 15 },
                    { 136, 16, 85, 16 },
                    { 137, 17, 78, 17 },
                    { 138, 18, 84, 18 },
                    { 139, 19, 81, 19 },
                    { 140, 20, 80, 10 }
                });

            migrationBuilder.InsertData(
                table: "Instructor",
                columns: new[] { "Id", "Address", "CourseId", "DepartmentId", "Image", "Name", "Salary" },
                values: new object[,]
                {
                    { 1, "123 Main St", 1, 1, "john.jpg", "John Doe", 50000.0 },
                    { 2, "456 Elm St", 2, 2, "jane.jpg", "Jane Smith", 60000.0 },
                    { 3, "789 Oak St", 3, 3, "michael.jpg", "Michael Johnson", 55000.0 },
                    { 4, "101 Pine St", 4, 4, "emily.jpg", "Emily Brown", 52000.0 },
                    { 5, "202 Cedar St", 5, 5, "david.jpg", "David Wilson", 58000.0 },
                    { 6, "303 Maple St", 6, 6, "jessica.jpg", "Jessica Lee", 53000.0 },
                    { 7, "404 Birch St", 7, 7, "chris.jpg", "Christopher Taylor", 56000.0 },
                    { 8, "505 Walnut St", 8, 8, "sarah.jpg", "Sarah Martinez", 59000.0 },
                    { 9, "606 Pineapple St", 9, 9, "daniel.jpg", "Daniel Garcia", 54000.0 },
                    { 10, "707 Banana St", 10, 1, "lisa.jpg", "Lisa Rodriguez", 57000.0 },
                    { 11, "808 Orange St", 11, 2, "matthew.jpg", "Matthew Hernandez", 60000.0 },
                    { 12, "909 Grape St", 12, 3, "ashley.jpg", "Ashley King", 55000.0 },
                    { 13, "111 Lemon St", 13, 4, "andrew.jpg", "Andrew Lopez", 52000.0 },
                    { 14, "222 Lime St", 14, 5, "megan.jpg", "Megan Young", 58000.0 },
                    { 15, "333 Cherry St", 15, 6, "kevin.jpg", "Kevin Hill", 53000.0 },
                    { 16, "444 Coconut St", 16, 7, "rachel.jpg", "Rachel Scott", 56000.0 },
                    { 17, "555 Pine St", 17, 8, "justin.jpg", "Justin Green", 59000.0 },
                    { 18, "666 Apple St", 18, 9, "amanda.jpg", "Amanda Adams", 54000.0 },
                    { 19, "777 Peach St", 19, 1, "brandon.jpg", "Brandon Baker", 57000.0 },
                    { 20, "888 Plum St", 20, 2, "stephanie.jpg", "Stephanie Carter", 60000.0 },
                    { 21, "999 Berry St", 21, 3, "mark.jpg", "Mark Flores", 55000.0 },
                    { 22, "121 Cherry St", 22, 4, "laura.jpg", "Laura White", 52000.0 },
                    { 23, "232 Grape St", 23, 5, "jason.jpg", "Jason Allen", 58000.0 },
                    { 24, "343 Lemon St", 24, 6, "catherine.jpg", "Catherine Martinez", 53000.0 },
                    { 25, "454 Lime St", 25, 7, "ryan.jpg", "Ryan Adams", 56000.0 },
                    { 26, "565 Cherry St", 26, 8, "rebecca.jpg", "Rebecca Hill", 59000.0 },
                    { 27, "676 Coconut St", 27, 9, "tyler.jpg", "Tyler Lewis", 54000.0 },
                    { 28, "787 Pine St", 28, 1, "hannah.jpg", "Hannah Green", 57000.0 },
                    { 29, "898 Apple St", 29, 2, "jacob.jpg", "Jacob Baker", 60000.0 },
                    { 30, "909 Peach St", 30, 3, "olivia.jpg", "Olivia Taylor", 55000.0 },
                    { 31, "123 Main St", 1, 1, "john_smith.jpg", "John Smith", 60000.0 },
                    { 32, "456 Elm St", 2, 2, "emily_johnson.jpg", "Emily Johnson", 55000.0 },
                    { 33, "789 Oak St", 3, 3, "michael_williams.jpg", "Michael Williams", 62000.0 },
                    { 34, "101 Pine St", 4, 4, "sophia_brown.jpg", "Sophia Brown", 58000.0 },
                    { 35, "111 Cedar St", 5, 5, "william_johnson.jpg", "William Johnson", 63000.0 },
                    { 36, "222 Maple St", 6, 6, "emma_garcia.jpg", "Emma Garcia", 59000.0 },
                    { 37, "333 Walnut St", 7, 7, "matthew_martinez.jpg", "Matthew Martinez", 61000.0 },
                    { 38, "444 Ash St", 8, 8, "olivia_robinson.jpg", "Olivia Robinson", 60000.0 },
                    { 39, "555 Birch St", 9, 9, "daniel_clark.jpg", "Daniel Clark", 64000.0 },
                    { 40, "666 Pine St", 10, 1, "isabella_rodriguez.jpg", "Isabella Rodriguez", 58000.0 },
                    { 41, "777 Elm St", 11, 2, "alexander_lee.jpg", "Alexander Lee", 63000.0 },
                    { 42, "888 Oak St", 12, 3, "mia_hall.jpg", "Mia Hall", 59000.0 },
                    { 43, "999 Maple St", 13, 4, "ethan_young.jpg", "Ethan Young", 62000.0 },
                    { 44, "1010 Cedar St", 14, 5, "charlotte_hernandez.jpg", "Charlotte Hernandez", 57000.0 },
                    { 45, "1111 Pine St", 15, 6, "james_lopez.jpg", "James Lopez", 61000.0 },
                    { 46, "1212 Elm St", 16, 7, "amelia_king.jpg", "Amelia King", 60000.0 },
                    { 47, "1313 Oak St", 17, 8, "benjamin_adams.jpg", "Benjamin Adams", 64000.0 },
                    { 48, "1414 Walnut St", 18, 9, "sophia_clark.jpg", "Sophia Clark", 59000.0 },
                    { 49, "1515 Ash St", 19, 1, "jacob_baker.jpg", "Jacob Baker", 63000.0 },
                    { 50, "1616 Birch St", 20, 2, "olivia_foster.jpg", "Olivia Foster", 57000.0 },
                    { 51, "1717 Maple St", 1, 3, "liam_gonzales.jpg", "Liam Gonzales", 61000.0 },
                    { 52, "1818 Cedar St", 2, 4, "charlotte_hill.jpg", "Charlotte Hill", 60000.0 },
                    { 53, "1919 Pine St", 3, 5, "noah_hughes.jpg", "Noah Hughes", 64000.0 },
                    { 54, "2020 Elm St", 4, 6, "ava_jenkins.jpg", "Ava Jenkins", 58000.0 },
                    { 55, "2121 Oak St", 5, 7, "michael_kelly.jpg", "Michael Kelly", 62000.0 },
                    { 56, "2222 Walnut St", 6, 8, "emma_long.jpg", "Emma Long", 59000.0 },
                    { 57, "2323 Ash St", 7, 9, "mason_mitchell.jpg", "Mason Mitchell", 63000.0 },
                    { 58, "2424 Birch St", 8, 1, "sophia_murphy.jpg", "Sophia Murphy", 57000.0 },
                    { 59, "2525 Maple St", 9, 2, "william_nguyen.jpg", "William Nguyen", 61000.0 },
                    { 60, "2626 Cedar St", 10, 3, "amelia_patel.jpg", "Amelia Patel", 60000.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Instructor",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Instructor",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Instructor",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Instructor",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Instructor",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Instructor",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Instructor",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Instructor",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Instructor",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Instructor",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Instructor",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Instructor",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Instructor",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Instructor",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Instructor",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Instructor",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Instructor",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Instructor",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Instructor",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Instructor",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Instructor",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Instructor",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Instructor",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Instructor",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Instructor",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Instructor",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Instructor",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Instructor",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Instructor",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Instructor",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Instructor",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Instructor",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Instructor",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Instructor",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Instructor",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Instructor",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Instructor",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Instructor",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Instructor",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Instructor",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Instructor",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Instructor",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Instructor",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Instructor",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Instructor",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Instructor",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Instructor",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Instructor",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Instructor",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Instructor",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Instructor",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Instructor",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Instructor",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Instructor",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Instructor",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Instructor",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Instructor",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Instructor",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Instructor",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Instructor",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.AddColumn<int>(
                name: "Crs_Id",
                table: "CrsResult",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Trianee_Id",
                table: "CrsResult",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
