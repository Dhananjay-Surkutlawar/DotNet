namespace OPPS
{
    internal class Box
    {
        int height;
        int width;
        int depth;

        public Box() { }   // default ctor
        public Box(int height, int width, int depth)  // parameterized ctor 
        {
            this.height = height;
            this.width = width;
            this.depth = depth;

        }
        public Box(Box b1) // copy ctor 
        {
            this.height = b1.height;
            this.width = b1.width;
            this.depth = b1.depth;
        }
        public void showVolume()
        {
            Console.WriteLine(height * width * height);

        }
    }
}
