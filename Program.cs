﻿using System;

using DAL1;
using model_HRMS;


namespace HRMS

{
    class DAL1
    {
        static void Main(string[] args)
        {
            DAL C = new DAL();
            C.DisplayHRMS();

            C.AddHRMS();
            C.DisplayHRMS();
            
            C.EditHRMS();
            C.DisplayHRMS();

            C.DeleteHRMS();
            C.DisplayHRMS();

            C.SearchHRMS();
            C.DisplayHRMS();
        }
    }
}
