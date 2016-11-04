using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleServer
{
    [Serializable()]
    public class LastTrans
    {
        private int LastDeposit;
        private int LastWithdraw;
        public LastTrans()
        {
            LastDeposit = 68800;
            LastWithdraw = 12000;
        }

        public int GetLastDeposit()
        {
            Console.WriteLine("Last Deposit Queried");
            return LastDeposit;
        }

        public int GetLastWithdraw()
        {
            Console.WriteLine("Last Withdraw Queried");
            return LastWithdraw;
        }
    }
   
}
