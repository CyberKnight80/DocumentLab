using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentLibrary
{
    public class DocumentAbstractFactory
    {

    }

    public interface IOwner
    {
        public void SayHello();
    }

    public interface ISeal
    {
        public void MakePureSeal();
    }

    public class Person : IOwner
    {
        public void SayHello()
        {
            Console.WriteLine("I am human");
        }
    }

    public class Organization : IOwner
    {
        public void SayHello()
        {
            Console.WriteLine("I am not human");
        }
    }

    public class SquareSeal : ISeal
    {
        public void MakePureSeal()
        {
            Console.WriteLine("I am square pure seal");
        }
    }

    public class CircleSeal : ISeal
    {
        public void MakePureSeal()
        {
            Console.WriteLine("I am circle pure seal");
        }
    }
}
