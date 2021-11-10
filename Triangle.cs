﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Triangle_Rimitsen
{
    class Triangle
    {
        public double a;// первая сторона
        public double b;// вторая сторона
        public double c;// третья сторона
        public double h;// высота
        public double alpha;//угол альфа

        public Triangle(double A, double B, double C)// Конструктор
        {
            a = A;// создаем с заданными длинами сторон согласно заданию
            b = B;
            c = C;
            
        }
        public Triangle()
        {

        }
        public  Triangle(double A, double H)
        {
            a = A;
            h = H;
        }
        public string outputA()
        {
            return Convert.ToString(a);
        }
        public string outputB()
        {
            return Convert.ToString(b);
        }
        public string outputC()
        {
            return Convert.ToString(c);
        }
        public double Perimeter()
        {
            double p = 0;
            p = a + b + c;
            return p;
        }
        public double Surface()
        {
            double s = 0;
            double p = 0;
            p = (a + b + c) / 2;
            s = Math.Sqrt((p * (p - a) * (p - b) * (p - c)));
            return s;
        }
        public double Surface_Ploshad()
        {
            double plos = 0;
            plos = (a + h / 2);

            return plos;

        }

        public double Vesota()
        {
            double ha = 0;
            double s = 0;
            s = (a + h / 2);
            ha = (2 * s)/a;

            return ha;
        }

        public double GetSetA
        {
            get
            { return a; }
            set
            { a = value; }
        }

        public double GetSetB
        {
            get
            { return b; }
            set
            { b = value; }
        }

        public double GetSetC
        {
            get
            { return c; }
            set
            { c = value; }
        }

        public bool ExistTriange
        {
            get
            {
                if ((a > b + c) && (b > a + c) && (c > a + b))
                    return true;
                else return false;
            }
        }

        public string TriangleType
        {
            get
            {
                if (a == b && a == c && b == c)
                    return "это равносторонний";
                else if (a == b || a == c || b == c)
                    return "это равнобедренный";

                else return "это разносторонний";

            }
        }
    }
}
