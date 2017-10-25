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
                //FloweraList.Add(new Flower(i.ToString(), i.ToString(), i.ToString(), i.ToString(), i.ToString()));
                FloweraList.Add(new Flower("Common Almond","WHITE", "Assets\\Common Almond.jpg", "Carmel, Samarian mountains, Judean mountains, Shefela", "Common Almond is a winter-deciduous tree that reaches a height of 3-8 meters."));
                FloweraList.Add(new Flower("Grandiflora Rose", "pink", "Assets\\Grandiflora Rose.jpg", "USA", "Grandiflora roses blend the best traits of hybrid teas and floribundas."));
                FloweraList.Add(new Flower("Hybrid Tea Rose", "pink", "Assets\\Grandiflora Rose.jpg", "Hybrid Tea Rose", "Hybrid tea roses are the standard for cut flower roses."));
        
                FloweraList.Add(new Flower("Trifolium clypeatum", "WHITE-pink", "Assets\\Trifolium clypeatum.jpg", "Golan, Hermon, Gallile", "not so pretty."));
                FloweraList.Add(new Flower("King Uzziae Iris", "Blue", "Assets\\King Uzziae Iris.jpg", "Northern Negev, Negev hills and Eilat, Aravah", "Iris is the rainbow goddess in Greek mythology."));

            }
        }//
        public IEnumerable<Flower> GetFlowerEnumerator()
        {
            return FloweraList.AsEnumerable();
        }
    }
}
