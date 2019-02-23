using static System.Console;

namespace vscodedemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //var lstWidgets = 
            //    new List<string>()
            //    { "widget1", "widget2", "widget3" };

            //foreach (var widget in lstWidgets
            //    .Where(widget => widget.EndsWith("2"))
            //    .Select(widget => widget))
            //{
            //    WriteLine($"{widget} exists in the list");
            //}


            //// Example of using let
            //var lstStockCode =
            //    new List<string>()
            //    { "A100-341", "B101-754", "A100-197", "C201-341", "B102-774", "C101-111", "A100-774", "C105-191" };

            //var classAStockCodes =
            //    from aclass in lstStockCode
            //    let a = (aclass.StartsWith("A100") ? (aclass.Replace("A100-", "")) : "0")
            //    where Convert.ToInt32(a) > 200 
            //    && Convert.ToInt32(a) > 0
            //    select aclass;

            //foreach(var cl in classAStockCodes)
            //{
            //    WriteLine($"{cl} is a class A stock code in the 200 plus range");
            //}

            //string FirstName = "Dirk";
            //string LastName = "Strauss";
            //string FullName = string.Format("My name is {0} {1}", FirstName, LastName);

            NotSuchNiceCode();
            ReadLine();
        }

        public static void NotSuchNiceCode()
        {            
            ZeroValue(out int iValue);
            WriteLine($"The variable changed to: {iValue}");
        }

        public static void ZeroValue(out int iValue)
        {
            iValue = 0;
        }
    }
}
