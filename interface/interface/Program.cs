using System;

namespace interfaces
{
    class Program
{
    static void Main(string[] args)
    {
            TS tss = new TS();
            IAzad ts = new TS();
            ISunnat ts1 = ts as TS;
            ts.Age = 25;
            ts.Azad = "Ozodbek";
            ts1.Sunnat = "Sunnat";
            //tss.Display();
        }
}
    interface ISunnat
    {
        string Sunnat { get; set; }
    }
    interface IAzad
    {
        string Azad { get; set; }
        int Age { get; set; }
    }
    class TS : ISunnat, IAzad
    {
        public string Sunnat { get; set; }
        public string Azad { get ; set; }
        public int Age { get ; set; }
        public void Display() {
            Console.WriteLine(Sunnat+"  "+Azad + "  " + Age);
        }
    }

}
