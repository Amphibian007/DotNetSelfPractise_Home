using System;
using System.Collections.Generic;
using System.Text;

namespace MethodOverriding
{
    public class Canvas
    {
        public void DrawShape(List<Shape> shapes)
        {
            foreach(var shape in shapes)
            {
                shape.Draw();
            }
        }
    }
}
