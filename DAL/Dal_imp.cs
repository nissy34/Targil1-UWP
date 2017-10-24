using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace DAL
{
   public class Dal_imp : IDal
    {
        private readonly List<Flower> FloweraList;

        public Dal_imp()
        {

            FloweraList=new List<Flower>();
            FloweraList = new List<Flower>();
            for (int i = 0; i < 15; i++)
            {
                FloweraList.Add(new Flower(i.ToString(), i.ToString(), i.ToString(), i.ToString(), i.ToString()));
            }
        }//
        public IEnumerable<Flower> GetFlowerEnumerator()
        {
            return FloweraList.AsEnumerable();
        }
    }
}
