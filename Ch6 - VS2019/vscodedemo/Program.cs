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
            //string FullName = $"My name is {FirstName} {LastName}";

            //NotSuchNiceCode();


            //var logger = new LoggerClass(
            //    "start"
            //    , 10
            //    , "verbose");

            //logger.AddLogEntry();

                       
            
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

    internal class LoggerClass
    {
        public string Flag { get; }
        public int Priority { get; }
        public string LogLevel { get; }

        public LoggerClass(string flag,
                           int priority,
                           string logLevel)
        {
            Flag = flag;
            Priority = priority;
            LogLevel = logLevel;
        }

        public void AddLogEntry()
        {

            int iLogLevel = DetermineLogLevelPriority();
            Log(iLogLevel, Priority, Flag);
        }

        private int DetermineLogLevelPriority()
        {
            return LogLevel.ToLower() switch
            {
                "verbose"   => 10,
                "info"      => 5,
                "minimal"   => 1,
                _           => 0
            };
        }

        public override bool Equals(object obj)
        {
            return obj is LoggerClass other &&
                   Flag == other.Flag &&
                   Priority == other.Priority &&
                   LogLevel == other.LogLevel;
        }

        public override int GetHashCode()
        {
            var hashCode = -1332235279;
            hashCode = hashCode * -1521134295 + System.Collections.Generic.EqualityComparer<string>.Default.GetHashCode(Flag);
            hashCode = hashCode * -1521134295 + Priority.GetHashCode();
            hashCode = hashCode * -1521134295 + System.Collections.Generic.EqualityComparer<string>.Default.GetHashCode(LogLevel);
            return hashCode;
        }

        internal void Log(int logLevel, int priority, string flag)
        {
            WriteLine($"LogLevel = {logLevel} \nPriority = {priority} \nFlag = {flag}");
        }
    }
}
