using NLog;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nlogprac
{
    class Add
    {

        Logger logger = LogManager.GetCurrentClassLogger();
        public int Sum(int a, int b)
        {
            if (a == 0 || b == 0)
            {
                logger.Error("Debug unsuccessuccessful : Sum()");
            }
            int c = a + b;
            logger.Debug("Debug Success: " + c);
            return c;
        }


    }
}
