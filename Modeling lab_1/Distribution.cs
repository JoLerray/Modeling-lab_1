using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet;
using MathNet.Numerics;

namespace Modeling_lab_1
{
    class Distribution
    {

        static Random random = new Random();
        static double r;
        private static double getX(double c, double b)
        {
            r = random.NextDouble();

            return b * Math.Pow(-Math.Log(r), 1 / c);
        }
        private static double getFx(double x,double c,double b)
        {
            return c * Math.Pow(x, c - 1) / Math.Pow(b,c) *  Math.Exp(-Math.Pow(x/b,c));
        
        }
        public static double getMx(double c, double b) {
            return Math.Round(b / c * SpecialFunctions.Gamma(1 / c),4);
        }
        public static double getDx(double c, double b)
        {
            return Math.Round(Math.Pow(b, 2) / c * (2 * SpecialFunctions.Gamma(2 / c) - 1 / c * Math.Pow(SpecialFunctions.Gamma(1 / c),2)),4);
        }
        public static double[] Weibull(double c,double b){
            var x = getX(c, b);
            var fx = getFx(x, c, b);
            double[] values = { Math.Round(x, 4), Math.Round(fx, 4)};
            return values;
        }
    }
}
