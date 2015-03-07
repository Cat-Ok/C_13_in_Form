using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace C_13_in_Form
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}

//Our main class called Transport
namespace Classes
{
    //Base class Transport from what we would especially derive the other classes
    public class Base_Transport
    {
        //Our 2 properties - methods of Base class
        protected string Name_Transp { get; set; }
        protected int ID_Transp { get; set; }

        //Our methods to input/output files, that we will override in derived classes
        virtual protected void Input()
        {
            Console.WriteLine("Please input Name = ");
            Name_Transp = Console.ReadLine();
            Console.WriteLine("Please input ID = ");
            ID_Transp = Int32.Parse(Console.ReadLine());
        }

        virtual protected void Output()
        {
            Console.WriteLine("Here is name of transport = {0}", this.Name_Transp);
            Console.WriteLine("ID of car = {0}", this.ID_Transp);
        }
    
        //Our constructors
        public Base_Transport()
        {
            Name_Transp = "No Name";
            ID_Transp = 0;
        }

        public Base_Transport(string Name,int id)
        {
            Name_Transp = Name;
            ID_Transp = id;
        }
         
        public void Sort(ref Base_Transport[] base_cls)
        {
            bool ckeck = false;
            int n = base_cls.Length;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < base_cls[i].Name_Transp.Length; j++)
                {
                    if (base_cls[i].Name_Transp[j] > base_cls[i + 1].Name_Transp[j])
                    {
                        Base_Transport temp = base_cls[i];
                        base_cls[i] = base_cls[i + 1];
                        base_cls[i + 1] = temp;
                        ckeck = true;
                    }
                    else if (base_cls[i].Name_Transp[j] == base_cls[i + 1].Name_Transp[j])
                    {
                        ckeck = false;
                    }
                    if (ckeck)
                    {
                        break;
                    }
                }
            }

        }
    }


    //Derived class called Shipping
    public class Shipping : Base_Transport
    {
        //2 methods - properties of Shipping class derived by Base_Transport
        protected int Capacity { get; set; }
        protected double Speed { get; set; }

        //2 override methods from derived class Base_Transport
        protected override void Input()
        {
            base.Input();
            Console.WriteLine("Input Capacity of Shipping car = ");
            Capacity = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Input the maximal speed on water, divedid with coma = ");
            Speed = Double.Parse(Console.ReadLine());
        }

        protected override void Output()
        {
            base.Output();
            Console.WriteLine("Capacity of Shipping car = {0}", this.Capacity);
            Console.WriteLine("Maximal speed = {0}", this.Speed);
        }

        //Our constructors
        public Shipping(): base()
        {
            Capacity = 1;
            Speed = 10;
        }

        public Shipping(string name,int id,int capacity,double speed): base(name,id)
        {
            Capacity = capacity;
            Speed = speed;
        }
    }
 

    public class Ground: Base_Transport
    {
        protected int Capacity { get; set; }
        protected double Speed { get; set; }    

        //constructors
        public Ground():base()
        {
            Capacity = 0;
            Speed = .0;
        }

        public Ground(string name, int id, int capacity, double speed)
            : base(name, id)
        {
            Capacity = capacity;
            Speed = speed;
        }

        protected override void Input()
        {
            base.Input();
            Console.WriteLine("Ground Transport input");

            Console.WriteLine("Input the capacuty of car");
            Capacity = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Input the maximal speed of car");
            Speed = Double.Parse(Console.ReadLine());
        }

        protected override void Output()
        {
            base.Output();

            Console.WriteLine("Ground Transport output");
            Console.WriteLine("Capacity = {0}", this.Capacity);
            Console.WriteLine("Speed = {0}", this.Speed);
        }

    }
}
