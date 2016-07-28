using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 模拟移动硬盘_U盘_MP3
{
    public  class Computer
    {
        public Computer(MobileStorage ms)
        {
            Ms = ms;
        }
        MobileStorage _ms;
        public MobileStorage Ms
        {
            get { return _ms; }
            set { _ms = value; }
        }
        //public void CpuRead(MobileStorage ms)
        public void CpuRead()
        {
            Ms.Read();
        }
        //public void CpuWrite(MobileStorage ms)
        public void CpuWrite()
        {
            Ms.Write();
        }
    }
}
