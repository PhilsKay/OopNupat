using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopNupat;
public class Dog : Animal
{
    public int num { get; set; }
    public Dog(string Color, int NumberOfLegs, string Name,int num) :base(Color,NumberOfLegs,Name)
    {
        this.num = num;
    }

}
