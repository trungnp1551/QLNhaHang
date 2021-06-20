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
    public class BUS_BillDetails
    {
        DAL_BillDetails dal_billDetails = new DAL_BillDetails();

        public DataSet loadData(string mahd)
        {
            return dal_billDetails.loadData(mahd);
        }

        public bool addData(DTO_BillDetails billDetails)
        {
            return dal_billDetails.addData(billDetails);
        }
    }
}
