using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;

namespace BUS
{
    public class BUS_Employee
    {
        DAL_Employee dal_employee = new DAL_Employee();

        public DataSet loadData()
        {
            return dal_employee.loadData();
        }

        public bool addData(DTO_Employee employee)
        {
            return dal_employee.addData(employee);
        }

        public bool updateData(DTO_Employee employee)
        {
            return dal_employee.updateData(employee);
        }

        public bool deleteData(string manv)
        {
            return dal_employee.deleteData(manv);
        }

        public bool login(string username, string password)
        {
            return dal_employee.login(username, password);
        }

        public string getIdUser(string username)
        {
            return dal_employee.getIdUser(username);
        }

    }
}
