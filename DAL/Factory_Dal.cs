using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Factory_Dal
    {
        private Factory_Dal()
        {
        }


        private static Dal_imp instance_list = null;

        public static Dal_imp GetInstance_List()
        {
            if (instance_list == null)
                instance_list = new Dal_imp();

            return instance_list;
        }

        //
        //private static DAL_XML_imp instance_Xml = null;
        //public static DAL_XML_imp GetInstance_Xml()
        //{
        //    if (instance_Xml == null)
        //        instance_Xml = new DAL_XML_imp();
        //    return instance_Xml;
        //}
    }
}
