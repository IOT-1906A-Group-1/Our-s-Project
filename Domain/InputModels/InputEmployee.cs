using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.InputModels
{
    public class InputEmployee:BaseModels
    {
        public int employee_Id { get; set; }//主键id
        public int TaskId { get; set; }//taskid
        public string employee_Name { get; set; }//亲属姓名
        public string employee_Relation { get; set; }//与本人的关系
        public string employee_Post { get; set; }//亲属在公司的职务
    }
}
