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
            TestTuple();
            InstanceTupleVariables();
            ComparingTuples(); 
            #endregion
        }

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
    }
}
