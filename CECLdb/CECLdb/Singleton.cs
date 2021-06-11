using System;
using System.Collections.Generic;
using System.Text;

namespace CECLdb
{
    class Singleton
    {
        private Singleton() { }
        private static Singleton _instance;
        public static Singleton GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Singleton();
            }
            return _instance;
        }

        public static int action;
        public static void someBusinessLogic()
        {
            action = 0;
        }
    }
}
