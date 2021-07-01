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
    public class BUS_Bill
    {
        DAL_Bill dal_bill = new DAL_Bill();

        public DataSet loadData()
        {
            return dal_bill.loadData();
        }

        public bool addData(DTO_Bill bill)
        {
            return dal_bill.addData(bill);
        }

        public int countingBills()
        {
            return dal_bill.countingBills();
        }
        public DataSet query(string ngay, string manv, string giatrihd = "0")
        {
            return dal_bill.query(ngay, manv, giatrihd);
        }
        public DataSet query(string ngay, string giatrihd = "0")
        {
            return dal_bill.query(ngay, giatrihd);
        }
        public DataSet query(int fixbug, string manv, string giatrihd = "0")
        {
            return dal_bill.query(fixbug, manv, giatrihd);
        }
        public DataSet query(int fixbug, int fixbug1, string giatrihd)
        {
            return dal_bill.query(fixbug, fixbug1, giatrihd);
        }
    }
}
