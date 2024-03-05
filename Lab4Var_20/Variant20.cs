using System;

namespace Lab4Var_20
{
    public class Variant20
    {
        public static string Task1(double[] h)
        {
            double answer = 1.0;
            double first = 0;
            for (int i = 0; i < h.Length; i++)
            {
                if (h[i] < 0)
                {
                    answer *= h[i];
                }
            }
            for (int i = 0; i < h.Length; i++)
            {
                if (h[i] < 0)
                {
                    first = h[i];
                    break;
                }
            }
            return $"{answer} : {first}";
        }

        public static double[] Task2(double[] h)
        {
            double[] result = new double[h.Length];
            for (int i = 0; i < h.Length; i++)
            {
                result[i] = 2 * h[i] + 1;
            }
            return result;
        }

        public static double Task3(double[] h)
        {
            double[] r = new double[h.Length];
            for (int i = 0; i < h.Length; i++)
            {
                r[i] = 2 * h[i] + 1;
            }

            double product = 1;
            for (int i = 0; i < r.Length; i++)
            {
                if (i % 2 != 0)
                {
                    if (r[i] > 0)
                    {
                        product *= r[i];
                    }
                }
            }

            return product;
        }
    }
}
