using MultiPrecision;
using System;

namespace OwensT {
    internal class Program {
        static void Main() {
            MultiPrecision<Pow2.N4> h = 16;
            MultiPrecision<Pow2.N4> phi = 1 + MultiPrecision<Pow2.N4>.Erf(h / MultiPrecision<Pow2.N4>.Sqrt2);
            MultiPrecision<Pow2.N4> phic = MultiPrecision<Pow2.N4>.Erfc(h / MultiPrecision<Pow2.N4>.Sqrt2);
            
            MultiPrecision<Pow2.N4> expected = phi * phic / 8;
            MultiPrecision<Pow2.N4> org = GaussQuadrature<Pow2.N4>.T5(h, 1);
            MultiPrecision<Pow2.N4> r2 = GaussQuadrature<Pow2.N4>.T5r2(h, 1);
            MultiPrecision<Pow2.N4> r3 = GaussQuadrature<Pow2.N4>.T5r3(h, 1);
            MultiPrecision<Pow2.N4> r4 = GaussQuadrature<Pow2.N4>.T5r4(h, 1);
            MultiPrecision<Pow2.N4> r5 = GaussQuadrature<Pow2.N4>.T5r5(h, 1);
            
            Console.WriteLine(expected);
            Console.WriteLine(org);
            Console.WriteLine(r2);
            Console.WriteLine(r3);
            Console.WriteLine(r4);
            Console.WriteLine(r5);

            Console.WriteLine("END");
            Console.Read();
        }

        static void Check() { 
            MultiPrecision<Pow2.N4> n4_t1_1 = OwenTPatefieldTandyAlgo<Pow2.N4>.T1(0.0625, 0.25);
            MultiPrecision<Pow2.N4> n4_t5_1 = OwenTPatefieldTandyAlgo<Pow2.N4>.T5(0.0625, 0.25);
            MultiPrecision<Pow2.N4> n4_t2_2 = OwenTPatefieldTandyAlgo<Pow2.N4>.T2(6.5, 0.4375);
            MultiPrecision<Pow2.N4> n4_t5_2 = OwenTPatefieldTandyAlgo<Pow2.N4>.T5(6.5, 0.4375);
            MultiPrecision<Pow2.N4> n4_t4_3 = OwenTPatefieldTandyAlgo<Pow2.N4>.T4(7, 0.96875);
            MultiPrecision<Pow2.N4> n4_t5_3 = OwenTPatefieldTandyAlgo<Pow2.N4>.T5(7, 0.96875);
            MultiPrecision<Pow2.N4> n4_t2_4 = OwenTPatefieldTandyAlgo<Pow2.N4>.T2(4.78125, 0.0625);
            MultiPrecision<Pow2.N4> n4_t4_4 = OwenTPatefieldTandyAlgo<Pow2.N4>.T4(4.78125, 0.0625);
            MultiPrecision<Pow2.N4> n4_t5_4 = OwenTPatefieldTandyAlgo<Pow2.N4>.T5(4.78125, 0.0625);
            MultiPrecision<Pow2.N4> n4_t4_5 = OwenTPatefieldTandyAlgo<Pow2.N4>.T4(2, 0.5);
            MultiPrecision<Pow2.N4> n4_t5_5 = OwenTPatefieldTandyAlgo<Pow2.N4>.T5(2, 0.5);
            MultiPrecision<Pow2.N4> n4_t5_6 = OwenTPatefieldTandyAlgo<Pow2.N4>.T5(1, 0.9999975m);

            MultiPrecision<Pow2.N8> n8_t1_1 = OwenTPatefieldTandyAlgo<Pow2.N8>.T1(0.0625, 0.25);
            MultiPrecision<Pow2.N8> n8_t5_1 = OwenTPatefieldTandyAlgo<Pow2.N8>.T5(0.0625, 0.25);
            MultiPrecision<Pow2.N8> n8_t2_2 = OwenTPatefieldTandyAlgo<Pow2.N8>.T2(6.5, 0.4375);
            MultiPrecision<Pow2.N8> n8_t5_2 = OwenTPatefieldTandyAlgo<Pow2.N8>.T5(6.5, 0.4375);
            MultiPrecision<Pow2.N8> n8_t4_3 = OwenTPatefieldTandyAlgo<Pow2.N8>.T4(7, 0.96875);
            MultiPrecision<Pow2.N8> n8_t5_3 = OwenTPatefieldTandyAlgo<Pow2.N8>.T5(7, 0.96875);
            MultiPrecision<Pow2.N8> n8_t2_4 = OwenTPatefieldTandyAlgo<Pow2.N8>.T2(4.78125, 0.0625);
            MultiPrecision<Pow2.N8> n8_t4_4 = OwenTPatefieldTandyAlgo<Pow2.N8>.T4(4.78125, 0.0625);
            MultiPrecision<Pow2.N8> n8_t5_4 = OwenTPatefieldTandyAlgo<Pow2.N8>.T5(4.78125, 0.0625);
            MultiPrecision<Pow2.N8> n8_t4_5 = OwenTPatefieldTandyAlgo<Pow2.N8>.T4(2, 0.5);
            MultiPrecision<Pow2.N8> n8_t5_5 = OwenTPatefieldTandyAlgo<Pow2.N8>.T5(2, 0.5);
            MultiPrecision<Pow2.N8> n8_t5_6 = OwenTPatefieldTandyAlgo<Pow2.N8>.T5(1, 0.9999975m);

            MultiPrecision<Pow2.N16> n16_t1_1 = OwenTPatefieldTandyAlgo<Pow2.N16>.T1(0.0625, 0.25);
            MultiPrecision<Pow2.N16> n16_t5_1 = OwenTPatefieldTandyAlgo<Pow2.N16>.T5(0.0625, 0.25);
            MultiPrecision<Pow2.N16> n16_t2_2 = OwenTPatefieldTandyAlgo<Pow2.N16>.T2(6.5, 0.4375);
            MultiPrecision<Pow2.N16> n16_t5_2 = OwenTPatefieldTandyAlgo<Pow2.N16>.T5(6.5, 0.4375);
            MultiPrecision<Pow2.N16> n16_t4_3 = OwenTPatefieldTandyAlgo<Pow2.N16>.T4(7, 0.96875);
            MultiPrecision<Pow2.N16> n16_t5_3 = OwenTPatefieldTandyAlgo<Pow2.N16>.T5(7, 0.96875);
            MultiPrecision<Pow2.N16> n16_t2_4 = OwenTPatefieldTandyAlgo<Pow2.N16>.T2(4.78125, 0.0625);
            MultiPrecision<Pow2.N16> n16_t4_4 = OwenTPatefieldTandyAlgo<Pow2.N16>.T4(4.78125, 0.0625);
            MultiPrecision<Pow2.N16> n16_t5_4 = OwenTPatefieldTandyAlgo<Pow2.N16>.T5(4.78125, 0.0625);
            MultiPrecision<Pow2.N16> n16_t4_5 = OwenTPatefieldTandyAlgo<Pow2.N16>.T4(2, 0.5);
            MultiPrecision<Pow2.N16> n16_t5_5 = OwenTPatefieldTandyAlgo<Pow2.N16>.T5(2, 0.5);
            MultiPrecision<Pow2.N16> n16_t5_6 = OwenTPatefieldTandyAlgo<Pow2.N16>.T5(1, 0.9999975m);

            Console.WriteLine("T1(0.0625, 0.25)");
            Console.WriteLine(n4_t1_1);
            Console.WriteLine(n8_t1_1);
            Console.WriteLine(n16_t1_1);
            Console.WriteLine("T5(0.0625, 0.25)");
            Console.WriteLine(n4_t5_1);
            Console.WriteLine(n8_t5_1);
            Console.WriteLine(n16_t5_1);
                        
            Console.WriteLine("T2(6.5, 0.4375)");
            Console.WriteLine(n4_t2_2);
            Console.WriteLine(n8_t2_2);
            Console.WriteLine(n16_t2_2);
            Console.WriteLine("T5(6.5, 0.4375)");
            Console.WriteLine(n4_t5_2);
            Console.WriteLine(n8_t5_2);
            Console.WriteLine(n16_t5_2);

            Console.WriteLine("T4(7, 0.96875)");
            Console.WriteLine(n4_t4_3);
            Console.WriteLine(n8_t4_3);
            Console.WriteLine(n16_t4_3);
            Console.WriteLine("T5(7, 0.96875)");
            Console.WriteLine(n4_t5_3);
            Console.WriteLine(n8_t5_3);
            Console.WriteLine(n16_t5_3);

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

            Console.WriteLine("T4(2, 0.5)");
            Console.WriteLine(n4_t4_5);
            Console.WriteLine(n8_t4_5);
            Console.WriteLine(n16_t4_5);
            Console.WriteLine("T5(2, 0.5)");
            Console.WriteLine(n4_t5_5);
            Console.WriteLine(n8_t5_5);
            Console.WriteLine(n16_t5_5);

            Console.WriteLine("T5(1, 0.9999975)");
            Console.WriteLine(n4_t5_6);
            Console.WriteLine(n8_t5_6);
            Console.WriteLine(n16_t5_6);
        }
    }
}
