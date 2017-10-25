using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Factory_Bl
    {
        private Factory_Bl()
        {
        }


        private static BL_imp instance_list = null;

        public static BL_imp GetInstance_List()
        {
            if (instance_list == null)
                instance_list = new BL_imp();

            return instance_list;
        }
    }
}
