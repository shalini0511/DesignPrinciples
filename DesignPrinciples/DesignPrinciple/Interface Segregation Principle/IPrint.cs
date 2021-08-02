using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPrinciples.DesignPrinciple.Interface_Segregation_Principle
{
    public interface IPrintContent
    {
        void PrintContent();
    }
    public interface IPhotoCopyContent
    {
        void PhotoCopyContent();
    }
    public interface IPrintDuplex
    {
        void PrintDuplexContent();
    }
}
