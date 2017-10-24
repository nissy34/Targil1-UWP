using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Store.Preview.InstallControl;
using BE;

namespace DAL
{
    public interface IDal
    {

        IEnumerable<Flower> GetFlowerEnumerator();
    }
}
