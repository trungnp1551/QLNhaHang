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
    public class BUS_Category
    {
        DAL_Category dal_category = new DAL_Category();

        public DataSet loadData()
        {
            return dal_category.loadData();
        }

        public bool addData(DTO_Category category)
        {
            return dal_category.addData(category);
        }

        public bool updateData(DTO_Category category)
        {
            return dal_category.updateData(category);
        }

        public bool deleteData(string madm)
        {
            return dal_category.deleteData(madm);
        }

    }
}
