﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Layer___Applications;


namespace Logic_Layer___Applications
{
    public class clsApplicationsTypes
    {

        public static DataTable GetAllApplicationsTypes()
        {

            return clsAppDataLayer.GetAllApplicationsTypes();

        }

      

    }
}
