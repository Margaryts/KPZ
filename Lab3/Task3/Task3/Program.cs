using static Task3.Figure;
using Task3;

class Program
{
    static void Main()
    {
        IRenderer vector = new VectorRenderer();
        IRenderer raster = new RasterRenderer();

        Shape triangle = new Triangle(raster);
        triangle.Draw();

        Shape square = new Square(vector);
        square.Draw();

        Shape circle = new Circle(raster);
        circle.Draw();
    }

}