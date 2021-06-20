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
    public class BUS_Menu
    {
        DAL_Menu dal_menu = new DAL_Menu();

        public DataSet loadData()
        {
            return dal_menu.loadData();
        }
        public DataSet loadDataForServeForm()
        {
            return dal_menu.loadDataForServeForm();
        }
        public bool addData(DTO_Menu menu)
        {
            return dal_menu.addData(menu);
        }
        public bool updateData(DTO_Menu menu)
        {
            return dal_menu.updateData(menu);
        }
        public bool deleteData(string ma)
        {
            return dal_menu.deleteData(ma);
        }
        public bool setQuantity(string ma, string soluong)
        {
            return dal_menu.setQuantity(ma, soluong);
        }
    }
}
