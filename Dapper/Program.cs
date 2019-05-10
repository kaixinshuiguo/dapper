using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dapper
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new crud().GetemployeeListFirst().FirstOrDefault().displayname);
            List<t_department> list = new crud().GetPCEntity().ToList();

            // added by ifirebird 2019-05-10
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i].departmentid + " " + list[i].departmentname + " " + list[i].ListEmployees.Count());
            }

            Console.Read();
        }
    }
}
