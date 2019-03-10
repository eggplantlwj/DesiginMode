using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMode
{
    class Program
    {
        static void Main(string[] args)
        {
            Operate myOperate = OperateFactory.CreateOpareate("*");
            myOperate.NumA = 10;
            myOperate.NumB = 11;
            double result = myOperate.GetResult();

        }
    }


    public class OperateFactory
    {
        public static Operate CreateOpareate(string operate)
        {
            Operate myOperate = null;
            switch (operate)
            {
                case "+":
                    myOperate = new OperateAdd();
                    break;
                case "-":
                    myOperate = new OperateSubtraction();
                    break;
                case "*":
                    myOperate = new OperateMultiply();
                    break;
                case "/":
                    myOperate = new OperateDivide();
                    break;
            }
            return myOperate;
        }
    }

    public class Operate
    {
        public double NumA { get; set; }
        public double NumB { get; set; }

        public virtual double GetResult()
        {
            double result = 0;
            return result;
        }
    }


    public class OperateAdd:Operate
    {
        public override double GetResult()
        {
            return NumA + NumB;
        }
    }

    public class OperateMultiply:Operate
    {
        public override double GetResult()
        {
            return NumA * NumB;
        }
    }

    public class OperateSubtraction : Operate
    {
        public override double GetResult()
        {
            return NumA - NumB;   
        }
    }

    public class OperateDivide : Operate
    {
        public override double GetResult()
        {
           if(NumB == 0)
            {
                return 0;
            }
            return NumA / NumB;   
        }
    }


    
}
