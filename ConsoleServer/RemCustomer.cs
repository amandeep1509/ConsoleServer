using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime;

namespace ConsoleServer
{
    public class RemCustomer: System.MarshalByRefObject
    {
        private string CustName;
        private int CustId;
        public LastTrans trans; 
        
        public RemCustomer()
        {
            CustName = "Ramu";
            CustId = 911;
            trans = new LastTrans();
            Console.WriteLine("Instance of a last transaction created ");
        }

        public int Get_id()
        {
            Console.WriteLine("Customer Id requested...");
            return CustId;
        }

        //RemoteServer_008: Get the Customer Name
        public string Get_Name()
        {
            Console.WriteLine("Customer Name requested...");
            return CustName;
        }

        //RemoteServer_017: Instance for LastTrans declared
        public LastTrans GetLastTrans()
        {
            Console.WriteLine("Transaction object requested...");
            return trans;
        }
    }
}
