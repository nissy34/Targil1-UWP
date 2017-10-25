using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.System.Profile;
using BE;
using DAL;

namespace BL
{
   public class BL_imp:IBl
    {
        IDal dal = Factory_Dal.GetInstance_List();

        public IEnumerable<Flower> GetAllFLowersByName(string name)
        {
           IEnumerable<Flower> flowers = dal.GetFlowerEnumerator();
       if (!String.IsNullOrWhiteSpace(name))
                return flowers.Where(flower => flower.Name.ToUpper().Contains(name.ToUpper()));         
            return flowers;

        }//
    }
}
