namespace DapperConsoleApplication
{
    internal class Product
    {
        public string Name { get; set; }
        public object Color { get; internal set; }
       
        public static int ProductID { get; internal set; }
    }
}