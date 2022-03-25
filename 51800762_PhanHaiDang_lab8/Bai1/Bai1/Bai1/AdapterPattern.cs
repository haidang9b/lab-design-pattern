using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    interface ISimpleFTP
    {
        void sendAMsg(string msg);
        void connectServer();
    }

    class MyFTP : ISimpleFTP
    {
        public void connectServer()
        {
            Console.WriteLine("MyFTP Connect Server");
        }

        public void sendAMsg(string msg)
        {
            Console.WriteLine("MyFTP Send a message : " + msg);
        }
    }

    class MyApp
    {
        ISimpleFTP ftp;
        public void setFTP(ISimpleFTP simpleFTP)
        {
            this.ftp = simpleFTP;
        }
        public void doSomething()
        {
            ftp.connectServer();
            ftp.sendAMsg("abc");
        }
    }

    interface IComplexFTP
    {
        void sendMsgs(String[] msgs);
        void connect();
        string[] getDirs();
    }

    public class ComplexFTP : IComplexFTP
    {
        public void connect()
        {
            Console.WriteLine("ComplexFTP connect server");
        }

        public string[] getDirs()
        {
            throw new NotImplementedException();
        }

        public void sendMsgs(string[] msgs)
        {
            string tmp = "";
            for(int i = 0; i < msgs.Length; i++)
            {
                tmp += msgs[i];
            }
            Console.WriteLine("ComplexFTP send Messages : " + tmp);
        }
    }

    class FTPAdapter : ISimpleFTP
    {
        private IComplexFTP complexFTP;
        public FTPAdapter()
        {
            complexFTP = new ComplexFTP();
        }
        public void connectServer()
        {
            complexFTP.connect();
        }

        public void sendAMsg(string msg)
        {
            string[] msgs = new string[] { msg };
            complexFTP.sendMsgs(msgs);
        }

    }
}
