using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BUS
{
    public class BUS_TempInfo
    {
        DAL_TempInfo dal_tempInfo = new DAL_TempInfo();

        public DataSet loadData(string maban)
        {
            return dal_tempInfo.loadData(maban);
        }
        public bool checkEmptyTable(string maban)
        {
            return dal_tempInfo.checkEmptyTable(maban);
        }
        public bool addData(DTO_TempInfo tempInfo)
        {
            return dal_tempInfo.addData(tempInfo);
        }
        public bool deleteData(string maban)
        {
            return dal_tempInfo.deleteData(maban);
        }
        public bool deleteOne(string maban, string mamonan)
        {
            return dal_tempInfo.deleteOne(maban, mamonan);
        }
        public bool checkExist(string maban)
        {
            return dal_tempInfo.checkExist(maban);
        }
        public bool checkPaymentStatus(string maban)
        {
            return dal_tempInfo.checkPaymentStatus(maban);
        }
        public bool checkConfirm(string maban, string mamonan)
        {
            return dal_tempInfo.checkConfirm(maban, mamonan);
        }
        public bool confirmTable(string maban)
        {
            return dal_tempInfo.confirmTable(maban);
        }
        public bool confirmPayment(string maban)
        {
            return dal_tempInfo.confirmPayment(maban);
        }
    }
}
