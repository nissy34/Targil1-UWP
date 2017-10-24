using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;

namespace BL
{
    class BL_imp:IBl
    {
        IDal dal = Factory_Dal.GetInstance_List();

        public IEnumerable<Flower> GetAllFLowersByName(string name)
        {
            IEnumerable<Flower> flowers = dal.GetFlowerEnumerator();

            return flowers.Where(flower => flower.Name.Contains(name));
            
        }//
    }
}
