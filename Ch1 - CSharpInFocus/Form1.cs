using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpInFocus
{
    public partial class Form1 : Form
    {
        public enum InstrumentType { guitar, cello, violin }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region Tuples
            /*
            TestTuple();
            InstanceTupleVariables();
            ComparingTuples(); 
            */
            #endregion

            #region Pattern matching
            /*
                PatternMatchingExample pme = new PatternMatchingExample();

                ExchangeStudent exchStudent = new ExchangeStudent(("John", "Doe", 21), UniversityCourses.Maths, DateTime.Now.AddMonths(6));
                Student student = new Student(("Mark", "Bates", 23), 12345, UniversityCourses.Chemistry);
                Lecturer lecturer = new Lecturer(("Allan", "Johnson", 35), 54321, UniversityCourses.Anatomy, DateTime.Now.AddYears(-3));
                Alumnus alumnus = new Alumnus(("Gabby", "Salinger", 26), 2017, UniversityDegree.BSc);
                Alumnus senalumnus = new Alumnus(("Frank", "Greer", 74), 1970, UniversityDegree.BSc);

                var output = "";
                output = pme.GetPersonCourse(exchStudent);
                Debug.WriteLine(output);
                output = pme.GetPersonCourse(student);
                Debug.WriteLine(output);
                output = pme.GetPersonCourse(lecturer);
                Debug.WriteLine(output);
                output = pme.GetPersonCourse(alumnus);
                Debug.WriteLine(output);
                output = pme.GetPersonCourse(senalumnus);
                Debug.WriteLine(output);

                Student nullStudent = null;
                output = pme.GetPersonCourse(nullStudent);
                Debug.WriteLine(output);
                */
            #endregion

            #region Out parameters
            //// Old code
            //string num = "123";
            //int numParsed;
            //if (int.TryParse(num, out numParsed))
            //{
            //    Debug.WriteLine($"{num} is a valid integer");
            //}
            //else
            //{
            //    Debug.WriteLine($"{num} is not a valid integer");
            //}

            // New code
            //string num = "123";            
            //if (int.TryParse(num, out int numParsed))
            //{
            //    Debug.WriteLine($"{num} is a valid integer");
            //}
            //else
            //{
            //    Debug.WriteLine($"{num} is not a valid integer");
            //}

            //// As a var
            //string num = "123";
            //if (int.TryParse(num, out var numParsed))
            //{
            //    Debug.WriteLine($"{num} is a valid integer");
            //}
            //else
            //{
            //    Debug.WriteLine($"{num} is not a valid integer");
            //}

            //// Using discards
            //string num = "123";
            //if (int.TryParse(num, out _))
            //{
            //    Debug.WriteLine($"{num} is a valid integer");
            //}
            //else
            //{
            //    Debug.WriteLine($"{num} is not a valid integer");
            //} 
            #endregion

            #region Local Functions
            /*
            Cube cube = new Cube(5);
            Pyramid pyramid = new Pyramid(5, 5, 5);
            Sphere sphere = new Sphere(5);
            Student student = new Student(("john", "doe", 22), 12345, UniversityCourses.Anatomy);

            DisplayMessage(cube);
            DisplayMessage(pyramid);
            DisplayMessage(sphere);
            DisplayMessage(student); 
            */
            #endregion

            try
            {
                Debug.WriteLine(DoSomeWork(null));
                Debug.WriteLine(DoSomeWork("wash car"));
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }

            
        }

        #region Local Functions
        public void DisplayMessage(object thing)
        {
            LocalFunctionExample lfe = new LocalFunctionExample(thing);
            Debug.WriteLine($"This is a {lfe.ObjectType} with a volume of {lfe.ObjectVolume}");
        } 
        #endregion

        #region Tuple Examples
        private void TestTuple()
        {
            TupleExample te = new TupleExample();
            //(string BrandType, int GuitarStringCount) = te.GetGuitarType();
            //var (BrandType, GuitarStringCount) = te.GetGuitarType();
            (string BrandType, var GuitarStringCount) = te.GetGuitarType();

            Debug.WriteLine(BrandType);
            Debug.WriteLine(GuitarStringCount);


        }

        private void InstanceTupleVariables()
        {
            string instrumentType = nameof(InstrumentType.guitar);
            int strings = 12;
            (string TypeOfInstrument, int NumberOfStrings) instrument = (instrumentType, strings);
            PlayInstrument(instrument);
        }

        private void PlayInstrument((string instrument, int strings) instrumentToPlay)
        {
            Debug.WriteLine($"I am playing a {instrumentToPlay.instrument} with {instrumentToPlay.strings} strings");
        }

        private void ComparingTuples()
        {
            string instrumentType1 = nameof(InstrumentType.guitar);
            int stringsCount1 = 6;
            (string TypeOfInstrument, int NumberOfStrings) instrument1 = (instrumentType1, stringsCount1);

            string instrumentType2 = nameof(InstrumentType.violin);
            int stringsCount2 = 4;
            (string TypeOfInstrument, int NumberOfStrings) instrument2 = (instrumentType2, stringsCount2);

            if (instrument1.NumberOfStrings != instrument2.NumberOfStrings)
            {
                Debug.WriteLine($"A {instrument2.TypeOfInstrument} does not have the same number of strings as a {instrument1.TypeOfInstrument}");
            }

            if (!instrument1.Equals(instrument2))
            {
                Debug.WriteLine("We are dealing with different instruments here.");
            }


            if (instrument1 != instrument2)
            {

            }

        }

        private void InferredTupleElementNames()
        {
            string instrumentType = nameof(InstrumentType.guitar);
            int stringsCount = 6;
            var instrument = (instrumentType, stringsCount);
        }
        #endregion


        public string DoSomeWork(string workItem)
        {
            string workToDo = workItem ?? throw new ArgumentNullException(workItem, "The workItem parameter is null");
            return $"Work item {workToDo} assigned";
        }

    }


}
