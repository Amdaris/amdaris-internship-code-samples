using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace NullablesDemo
{
    public class Patient
    {
        private string _name;
        private float? _measuredTemperature;
        private int? _measuredPulse;

        public Patient(string name)
        {
            _name = name;
        }

        public float? MeasuredTemperature
        {
            get { return _measuredTemperature; }
            set { _measuredTemperature = value; }
        }

        public int? MeasuredPulse
        {
            get { return _measuredPulse; }
            set { _measuredPulse = value; }
        }

        public void Breathe()
        {
            Console.WriteLine(_name + " breathing...");
        }
    }

    public class NullablesDemo
    {
        public static void Main(string[] args)
        {
            Patient patientA = new Patient("PatientA");
            Patient patientB = new Patient("PatientB");
            Patient patientC = null;

            //if (!patientA.MeasuredTemperature.HasValue)
            //{
            //    Console.WriteLine("Measuring temperature for patient A");
            //    patientA.MeasuredTemperature = MeasureTemperature();
            //}

            //if (patientB.MeasuredTemperature == null)
            //{
            //    Console.WriteLine("Measuring temperature for patient B");
            //    patientB.MeasuredTemperature = MeasureTemperature();
            //}

            //if (patientA.MeasuredPulse > 50) // Nullable type comparsions
            //{
            //    Console.WriteLine("PatientA temperature is greater than 50");
            //}
            //else if (patientA.MeasuredPulse < 50)
            //{
            //    Console.WriteLine("PatientA temperature is less than 50");
            //}
            //else if (patientA.MeasuredPulse == 50)
            //{
            //    Console.WriteLine("PatientA temperature is equal to 50");
            //}
            //else
            //{
            //    Console.WriteLine("PatientA temperature is undefined");
            //}

            //if ((patientB.MeasuredPulse ?? 100) > 50)
            //{
            //    Console.WriteLine("PatientsB or default pulse is greater than 50");
            //}

            patientA?.Breathe();
            patientB?.Breathe();
            patientC?.Breathe();
        }

        private static int? MeasurePulse()
        {
            Random random = new Random();
            return random.Next(50, 200);
        }

        private static float? MeasureTemperature()
        {
            Random random = new Random();
            return 35f + 5 * random.NextSingle();
        }
    }
}