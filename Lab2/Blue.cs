using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace Lab2
{
    public class Blue
    {
        const double E = 0.0001;
        public double Task1(int n, double x)
        {
            double answer = 0;

            // code here
            //double add = Math.Sin(x);
            double add;
            double d = 1;
            for (int i = 0; i < n; i++)
            {
                add = (double)Math.Sin((i + 1) * x) / d;
                answer += add;
                d *= x;
            }
            // end

            return answer;
        }
        public double Task2(int n)
        {
            double answer = 0;

            // code here
            double m = 1, ch = 1, zn = 1;
            double add;
            for (int i = 1; i <= n; i++)
            {
                m *= (-1);
                ch *= 5;
                zn *= i;
                add = m * (ch / zn);
                answer += add;
            }
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here
            int num = 0;
            int s1 = 0;
            int s2 = 1;
            int sum = 0;
            int su;
            while (num < n)
            {
                sum += s1;
                su = s1 + s2;
                s1 = s2;
                s2 = su;
                num++;
            }
            answer = sum;
            // end

            return answer;
        }
        public int Task4(int a, int h, int L)
        {
            int answer = 0;

            // code here
            int s = a;
            int add = 0;
            int i = 0;
            while (s <= L)
            {
                i++;
                add = a + (h * i);
                s += add;
            }
            answer = i;
            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            double ch = 0, zn = 1;
            double elem = ch / zn;
            int i = 1;
            do
            {
                ch += i;
                zn *= x;
                answer += elem;
                elem = ch / zn;
                i++;
            } while (elem > 0.0001);
            // end

            return answer;
        }
        public int Task6(int h, int S, int L)
        {
            int answer = 0;

            // code here
            while (S < L)
            { 
                S *= 2;
                answer += h;
            }
            // end

            return answer;
        }
        public (double a, int b, int c) Task7(double S, double I)
        {
            double a = 0;
            int b = 0;
            int c = 0;

            // code here
            double d = (1 + (I / 100));
            double a0 = S;
            a = S;
            for (int i = 2; i <= 7; i++)
            {
                a0 *= d;
                a += a0;
            }

            double sum = 0;
            double s1 = S;
            while (sum < 100)
            {
                sum += s1;
                s1 *= d;
                b++;
            }

            double s2 = S;
            while (s2 <= 42)
            {
                s2 *= d;
                c++;
            }
            // end

            return (a, b, c);
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            // code here
            for (double x = a; x <= b + 0.0001; x += h)
            {
                int i = 0;
                double sx = 0, Sx = 0, ch = 1, zn = 1, xi = 1;
                ch = (2 * i + 1) * xi;
                sx = ch / zn;
                while (Math.Abs(sx) >= E)
                {
                    SS += sx;
                    i++;
                    xi *= x * x;
                    zn *= i;
                    ch = (2 * i + 1) * xi;
                    sx = ch / zn;
                }
                SS += sx;
                SY += (1 + 2 * x * x) * Math.Exp(x * x);
            }
            // end

            return (SS, SY);
        }
    }
}
