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
            double X = x;
            for (int i = 0; i < n; i++)
            {
                X = X * x;
                answer += Math.Sin((i + 1) * x) / X * x * x;
            }
            // end

            return answer;
        }
        public double Task2(int n)
        {
            double answer = 0;

            // code here
            double chisl = 1;
            for (int i = 1; i <= n; i++)
            {
                chisl *= -5.0 / i;
                answer += chisl;
            }
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here
            long pred = 0;
            long now = 1;
            for (int i = 0; i < n; i++)
            {
                answer += pred;
                (pred, now) = (now, pred + now);

            }
            // end

            return answer;
        }
        public int Task4(int a, int h, int L)
        {
            int answer = 0;

            // code here
            int s = 0;
            for (int i = 0; s <= L; i++)
            {
                s += a;
                a += h;
                answer = i;
            }
            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            double ch = 0; double zn = 1; double elem = ch / zn; int i = 1;
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
            while (S <= L)
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
            double s = S;
            double x = S;
            for (int i = 0; i < 7; i++)
            {
                a += S;
                S += (I / 100) * S;
            }
            double stokm = 100;
            while (stokm > 0)
            {
                stokm -= s;
                s += (I / 100) * s;
                b += 1;
            }
            while (x <= 42)
            {
                x += (I / 100) * x;
                c += 1;
            }
            // end

            return (a, b, c);
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            // code here
            double x = 0;
            double sc = Math.Floor((b - a) / h);
            for (int j = 0; j <= sc; j++)
            {
                x = a + j * h;
                double fact = 1;
                double sx = 1;
                double s = 1;
                double se = 1;
                for (int i = 1; Math.Abs(se) > 0.0001; i++)
                {
                    sx *= x * x;
                    fact *= i;
                    se = ((2 * i + 1) * sx) / fact;
                    s += se;
                }
                SS += s;
                SY += (1 + 2 * x * x) * Math.Exp(x * x);
            }
            // end

            return (SS, SY);
        }
    }
}