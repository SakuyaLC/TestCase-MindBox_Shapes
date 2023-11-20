using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBox_Shapes.DAL.Interfaces
{
    public interface IShape
    {
        double CalculateArea();
        bool IsValid();
    }
}
