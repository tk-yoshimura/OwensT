using MultiPrecision;
using System;

namespace OwensT {
    internal class Program {
        static void Main() {
            //Check();

            for (double h = 1d / 65536; h <= 65536; h *= 2) {
                double a = 1;

                MultiPrecision<Pow2.N16> phi = 1 + MultiPrecision<Pow2.N16>.Erf(h / MultiPrecision<Pow2.N16>.Sqrt2);
                MultiPrecision<Pow2.N16> phic = MultiPrecision<Pow2.N16>.Erfc(h / MultiPrecision<Pow2.N16>.Sqrt2);
            
                MultiPrecision<Pow2.N16> expected = phi * phic / 8;
            
                MultiPrecision<Pow2.N4> actual4 = ExpectedN4.Value(h, a);
                MultiPrecision<Pow2.N8> actual8 = ExpectedN8.Value(h, a);
                MultiPrecision<Pow2.N16> actual16 = ExpectedN16.Value(h, a);
            
                Console.WriteLine(h);
                Console.WriteLine(actual4);
                Console.WriteLine(actual8);
                Console.WriteLine(actual16);
                Console.WriteLine(expected);
            }

            for (double h = 1d / 65536; h <= 65536; h *= 2) {
                string a = "1e+10000";

                MultiPrecision<Pow2.N16> phic = MultiPrecision<Pow2.N16>.Erfc(h / MultiPrecision<Pow2.N16>.Sqrt2);
            
                MultiPrecision<Pow2.N16> expected = phic / 4;
            
                MultiPrecision<Pow2.N4> actual4 = ExpectedN4.Value(h, a);
                MultiPrecision<Pow2.N8> actual8 = ExpectedN8.Value(h, a);
                MultiPrecision<Pow2.N16> actual16 = ExpectedN16.Value(h, a);
            
                Console.WriteLine(h);
                Console.WriteLine(actual4);
                Console.WriteLine(actual8);
                Console.WriteLine(actual16);
                Console.WriteLine(expected);
            }

            Console.WriteLine("END");
            Console.Read();
        }

        static void Check() {
            MultiPrecision<Pow2.N4> n4_t1_1 = OwenTPatefieldTandyAlgo<Pow2.N4>.T1(0.0625, 0.25);
            MultiPrecision<Pow2.N4> n4_t5_1 = OwenTPatefieldTandyAlgo<Pow2.N4>.T5(0.0625, 0.25);
            MultiPrecision<Pow2.N4> n4_r7_1 = ExpectedN4.Value(0.0625, 0.25);
            MultiPrecision<Pow2.N4> n4_t2_2 = OwenTPatefieldTandyAlgo<Pow2.N4>.T2(6.5, 0.4375);
            MultiPrecision<Pow2.N4> n4_t5_2 = OwenTPatefieldTandyAlgo<Pow2.N4>.T5(6.5, 0.4375);
            MultiPrecision<Pow2.N4> n4_r7_2 = ExpectedN4.Value(6.5, 0.4375);
            MultiPrecision<Pow2.N4> n4_t4_3 = OwenTPatefieldTandyAlgo<Pow2.N4>.T4(7, 0.96875);
            MultiPrecision<Pow2.N4> n4_t5_3 = OwenTPatefieldTandyAlgo<Pow2.N4>.T5(7, 0.96875);
            MultiPrecision<Pow2.N4> n4_r7_3 = ExpectedN4.Value(7, 0.96875);
            MultiPrecision<Pow2.N4> n4_t2_4 = OwenTPatefieldTandyAlgo<Pow2.N4>.T2(4.78125, 0.0625);
            MultiPrecision<Pow2.N4> n4_t4_4 = OwenTPatefieldTandyAlgo<Pow2.N4>.T4(4.78125, 0.0625);
            MultiPrecision<Pow2.N4> n4_t5_4 = OwenTPatefieldTandyAlgo<Pow2.N4>.T5(4.78125, 0.0625);
            MultiPrecision<Pow2.N4> n4_r7_4 = ExpectedN4.Value(4.78125, 0.0625);
            MultiPrecision<Pow2.N4> n4_t4_5 = OwenTPatefieldTandyAlgo<Pow2.N4>.T4(2, 0.5);
            MultiPrecision<Pow2.N4> n4_t5_5 = OwenTPatefieldTandyAlgo<Pow2.N4>.T5(2, 0.5);
            MultiPrecision<Pow2.N4> n4_r7_5 = ExpectedN4.Value(2, 0.5);
            MultiPrecision<Pow2.N4> n4_t5_6 = OwenTPatefieldTandyAlgo<Pow2.N4>.T5(1, 0.9999975m);
            MultiPrecision<Pow2.N4> n4_r7_6 = ExpectedN4.Value(1, 0.9999975m);

            MultiPrecision<Pow2.N8> n8_t1_1 = OwenTPatefieldTandyAlgo<Pow2.N8>.T1(0.0625, 0.25);
            MultiPrecision<Pow2.N8> n8_t5_1 = OwenTPatefieldTandyAlgo<Pow2.N8>.T5(0.0625, 0.25);
            MultiPrecision<Pow2.N8> n8_r7_1 = ExpectedN8.Value(0.0625, 0.25);
            MultiPrecision<Pow2.N8> n8_t2_2 = OwenTPatefieldTandyAlgo<Pow2.N8>.T2(6.5, 0.4375);
            MultiPrecision<Pow2.N8> n8_t5_2 = OwenTPatefieldTandyAlgo<Pow2.N8>.T5(6.5, 0.4375);
            MultiPrecision<Pow2.N8> n8_r7_2 = ExpectedN8.Value(6.5, 0.4375);
            MultiPrecision<Pow2.N8> n8_t4_3 = OwenTPatefieldTandyAlgo<Pow2.N8>.T4(7, 0.96875);
            MultiPrecision<Pow2.N8> n8_t5_3 = OwenTPatefieldTandyAlgo<Pow2.N8>.T5(7, 0.96875);
            MultiPrecision<Pow2.N8> n8_r7_3 = ExpectedN8.Value(7, 0.96875);
            MultiPrecision<Pow2.N8> n8_t2_4 = OwenTPatefieldTandyAlgo<Pow2.N8>.T2(4.78125, 0.0625);
            MultiPrecision<Pow2.N8> n8_t4_4 = OwenTPatefieldTandyAlgo<Pow2.N8>.T4(4.78125, 0.0625);
            MultiPrecision<Pow2.N8> n8_t5_4 = OwenTPatefieldTandyAlgo<Pow2.N8>.T5(4.78125, 0.0625);
            MultiPrecision<Pow2.N8> n8_r7_4 = ExpectedN8.Value(4.78125, 0.0625);
            MultiPrecision<Pow2.N8> n8_t4_5 = OwenTPatefieldTandyAlgo<Pow2.N8>.T4(2, 0.5);
            MultiPrecision<Pow2.N8> n8_t5_5 = OwenTPatefieldTandyAlgo<Pow2.N8>.T5(2, 0.5);
            MultiPrecision<Pow2.N8> n8_r7_5 = ExpectedN8.Value(2, 0.5);
            MultiPrecision<Pow2.N8> n8_t5_6 = OwenTPatefieldTandyAlgo<Pow2.N8>.T5(1, 0.9999975m);
            MultiPrecision<Pow2.N8> n8_r7_6 = ExpectedN8.Value(1, 0.9999975m);

            MultiPrecision<Pow2.N16> n16_t1_1 = OwenTPatefieldTandyAlgo<Pow2.N16>.T1(0.0625, 0.25);
            MultiPrecision<Pow2.N16> n16_t5_1 = OwenTPatefieldTandyAlgo<Pow2.N16>.T5(0.0625, 0.25);
            MultiPrecision<Pow2.N16> n16_r7_1 = ExpectedN16.Value(0.0625, 0.25);
            MultiPrecision<Pow2.N16> n16_t2_2 = OwenTPatefieldTandyAlgo<Pow2.N16>.T2(6.5, 0.4375);
            MultiPrecision<Pow2.N16> n16_t5_2 = OwenTPatefieldTandyAlgo<Pow2.N16>.T5(6.5, 0.4375);
            MultiPrecision<Pow2.N16> n16_r7_2 = ExpectedN16.Value(6.5, 0.4375);
            MultiPrecision<Pow2.N16> n16_t4_3 = OwenTPatefieldTandyAlgo<Pow2.N16>.T4(7, 0.96875);
            MultiPrecision<Pow2.N16> n16_t5_3 = OwenTPatefieldTandyAlgo<Pow2.N16>.T5(7, 0.96875);
            MultiPrecision<Pow2.N16> n16_r7_3 = ExpectedN16.Value(7, 0.96875);
            MultiPrecision<Pow2.N16> n16_t2_4 = OwenTPatefieldTandyAlgo<Pow2.N16>.T2(4.78125, 0.0625);
            MultiPrecision<Pow2.N16> n16_t4_4 = OwenTPatefieldTandyAlgo<Pow2.N16>.T4(4.78125, 0.0625);
            MultiPrecision<Pow2.N16> n16_t5_4 = OwenTPatefieldTandyAlgo<Pow2.N16>.T5(4.78125, 0.0625);
            MultiPrecision<Pow2.N16> n16_r7_4 = ExpectedN16.Value(4.78125, 0.0625);
            MultiPrecision<Pow2.N16> n16_t4_5 = OwenTPatefieldTandyAlgo<Pow2.N16>.T4(2, 0.5);
            MultiPrecision<Pow2.N16> n16_t5_5 = OwenTPatefieldTandyAlgo<Pow2.N16>.T5(2, 0.5);
            MultiPrecision<Pow2.N16> n16_r7_5 = ExpectedN16.Value(2, 0.5);
            MultiPrecision<Pow2.N16> n16_t5_6 = OwenTPatefieldTandyAlgo<Pow2.N16>.T5(1, 0.9999975m);
            MultiPrecision<Pow2.N16> n16_r7_6 = ExpectedN16.Value(1, 0.9999975m);

            Console.WriteLine("T1(0.0625, 0.25)");
            Console.WriteLine(n4_t1_1);
            Console.WriteLine(n8_t1_1);
            Console.WriteLine(n16_t1_1);
            Console.WriteLine("T5(0.0625, 0.25)");
            Console.WriteLine(n4_t5_1);
            Console.WriteLine(n8_t5_1);
            Console.WriteLine(n16_t5_1);
            Console.WriteLine("T5mod(0.0625, 0.25)");
            Console.WriteLine(n4_r7_1);
            Console.WriteLine(n8_r7_1);
            Console.WriteLine(n16_r7_1);

            Console.WriteLine("T2(6.5, 0.4375)");
            Console.WriteLine(n4_t2_2);
            Console.WriteLine(n8_t2_2);
            Console.WriteLine(n16_t2_2);
            Console.WriteLine("T5(6.5, 0.4375)");
            Console.WriteLine(n4_t5_2);
            Console.WriteLine(n8_t5_2);
            Console.WriteLine(n16_t5_2);
            Console.WriteLine("T5mod(6.5, 0.4375)");
            Console.WriteLine(n4_r7_2);
            Console.WriteLine(n8_r7_2);
            Console.WriteLine(n16_r7_2);

            Console.WriteLine("T4(7, 0.96875)");
            Console.WriteLine(n4_t4_3);
            Console.WriteLine(n8_t4_3);
            Console.WriteLine(n16_t4_3);
            Console.WriteLine("T5(7, 0.96875)");
            Console.WriteLine(n4_t5_3);
            Console.WriteLine(n8_t5_3);
            Console.WriteLine(n16_t5_3);
            Console.WriteLine("T5mod(7, 0.96875)");
            Console.WriteLine(n4_r7_3);
            Console.WriteLine(n8_r7_3);
            Console.WriteLine(n16_r7_3);

            Console.WriteLine("T2(6.5, 0.4375)");
            Console.WriteLine(n4_t2_4);
            Console.WriteLine(n8_t2_4);
            Console.WriteLine(n16_t2_4);
            Console.WriteLine("T4(4.78125, 0.0625)");
            Console.WriteLine(n4_t4_4);
            Console.WriteLine(n8_t4_4);
            Console.WriteLine(n16_t4_4);
            Console.WriteLine("T5(4.78125, 0.0625)");
            Console.WriteLine(n4_t5_4);
            Console.WriteLine(n8_t5_4);
            Console.WriteLine(n16_t5_4);
            Console.WriteLine("T5mod(4.78125, 0.0625)");
            Console.WriteLine(n4_r7_4);
            Console.WriteLine(n8_r7_4);
            Console.WriteLine(n16_r7_4);

            Console.WriteLine("T4(2, 0.5)");
            Console.WriteLine(n4_t4_5);
            Console.WriteLine(n8_t4_5);
            Console.WriteLine(n16_t4_5);
            Console.WriteLine("T5(2, 0.5)");
            Console.WriteLine(n4_t5_5);
            Console.WriteLine(n8_t5_5);
            Console.WriteLine(n16_t5_5);
            Console.WriteLine("T5mod(2, 0.5)");
            Console.WriteLine(n4_r7_5);
            Console.WriteLine(n8_r7_5);
            Console.WriteLine(n16_r7_5);

            Console.WriteLine("T5(1, 0.9999975)");
            Console.WriteLine(n4_t5_6);
            Console.WriteLine(n8_t5_6);
            Console.WriteLine(n16_t5_6);
            Console.WriteLine("T5mod(1, 0.9999975)");
            Console.WriteLine(n4_r7_6);
            Console.WriteLine(n8_r7_6);
            Console.WriteLine(n16_r7_6);
        }
    }
}
