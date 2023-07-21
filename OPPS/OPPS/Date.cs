namespace OPPS
{
    internal class Date
    {
        int dd;
        int mm;
        int yy;
        public Date()
        {
        }
        public Date(int dd, int mm, int yy)
        {
            this.dd = dd;
            this.mm = mm;
            this.yy = yy;
        }
        public void showDate()
        {
            Console.WriteLine(this.dd + "/" + this.mm + "/" + this.yy);
        }

        public int Mm
        {
            get
            {
                return mm;
            }
            set
            {

                mm = value;
            }
        }
        public int Dd { get; set; }

        public int Yy { get; set; }

    }
}
