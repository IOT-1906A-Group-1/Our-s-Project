using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Context.Migrations
{
    public partial class v8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {



            migrationBuilder.CreateTable(
                name: "Reception",
                columns: table => new
                {
                    reception_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaskId = table.Column<int>(type: "int", nullable: false),
                    reception_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    reception_Bu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    reception_Stime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    reception_Laifang = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    reception_Zhuyao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    reception_Ttime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    reception_Ttimeplus = table.Column<DateTime>(type: "datetime2", nullable: false),
                    reception_Jie = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    reception_Rnum = table.Column<int>(type: "int", nullable: false),
                    reception_Zi = table.Column<bool>(type: "bit", nullable: false),
                    reception_Lai = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    reception_Wu = table.Column<bool>(type: "bit", nullable: false),
                    reception_Shi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    reception_Yao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    reception_Bei = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reception", x => x.reception_Id);
                });

            migrationBuilder.CreateTable(
                name: "Receptionplus",
                columns: table => new
                {
                    receptionplus_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    receptionplus_Stime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    receptionplus_Etime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    receptionplus_Xing = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    receptionplus_Pei = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    receptionplus_Yong = table.Column<bool>(type: "bit", nullable: false),
                    receptionplus_Hui = table.Column<bool>(type: "bit", nullable: false),
                    receptionplus_Jiu = table.Column<bool>(type: "bit", nullable: false),
                    receptionplus_Zhan = table.Column<bool>(type: "bit", nullable: false),
                    receptionplus_Can = table.Column<bool>(type: "bit", nullable: false),
                    receptionplus_Bu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    receptionplus_Bei = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Receptionplus", x => x.receptionplus_Id);
                });

            migrationBuilder.CreateTable(
                name: "Receptions",
                columns: table => new
                {
                    receptions_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    receptions_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    receptions_Ben = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    receptions_Qin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    receptions_Knum = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    receptions_Snum = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    receptions_Bei = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Receptions", x => x.receptions_Id);
                });
        }

           
          

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            


            migrationBuilder.DropTable(
                name: "Reception");

            migrationBuilder.DropTable(
                name: "Receptionplus");

            migrationBuilder.DropTable(
                name: "Receptions");

           
        }
    }
}
