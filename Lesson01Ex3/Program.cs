using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson01Ex3
{
    class MedicalRecord
    {
        public string strPatientName;
        public string strDoctorName;
        public float fltFees;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MedicalRecord objM1;
            objM1 = new MedicalRecord();
            Console.Write("Enter the parient name: ");
            objM1.strPatientName = Console.ReadLine();
            Console.Write("Enter the doctor name: " );
            objM1.strDoctorName = Console.ReadLine();
            Console.Write("Enter the fees: ");
            objM1.fltFees = float.Parse(Console.ReadLine());
            Console.WriteLine("Patient name: {0}, Doctor name: {1}, Fees: {2}", objM1.strPatientName, objM1.strDoctorName, objM1.fltFees );
            MedicalRecord objM2;
            objM2 = new MedicalRecord();
            Console.Write("Enter the parient name: ");
            objM2.strPatientName = Console.ReadLine();
            Console.Write("Enter the doctor name: ");
            objM2.strDoctorName = Console.ReadLine();
            Console.Write("Enter the fees: ");
            objM2.fltFees = float.Parse(Console.ReadLine());
            Console.WriteLine("Patient name: {0}, Doctor name: {1}, Fees: {2}", objM2.strPatientName, objM2.strDoctorName, objM2.fltFees);

        }
    }
}
