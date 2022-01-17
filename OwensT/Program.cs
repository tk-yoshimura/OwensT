using MultiPrecision;
using System;

namespace OwensT {
    internal class Program {
        static void Main() {
            //MultiPrecision<Pow2.N4> n4_r7 = GaussQuadrature2<Pow2.N4>.T5r8(32, 32);
            
            for (double a = 1; a <= 64; a += 1d / 16) {
                MultiPrecision<Pow2.N4> n4_r7 = GaussQuadrature2<Pow2.N4>.T5r8(1, a);
            
                Console.WriteLine($"{a},{n4_r7}");
            }

            //double a = 1;
            //
            //for (double h = 1; h <= 65536; h *= 2) {
            //    MultiPrecision<Pow2.N16> phi = 1 + MultiPrecision<Pow2.N16>.Erf(h / MultiPrecision<Pow2.N16>.Sqrt2);
            //    MultiPrecision<Pow2.N16> phic = MultiPrecision<Pow2.N16>.Erfc(h / MultiPrecision<Pow2.N16>.Sqrt2);
            //
            //    MultiPrecision<Pow2.N16> expected = phi * phic / 8;
            //
            //    MultiPrecision<Pow2.N4> n4_r7 = GaussQuadrature2<Pow2.N4>.T5r8(h, a);
            //
            //    Console.WriteLine(h);
            //    Console.WriteLine(expected);
            //    
            //    Console.WriteLine(n4_r7);
            //}

            Check();

            Console.WriteLine("END");
            Console.Read();
        }

        static void Check() {
            MultiPrecision<Pow2.N4> n4_t1_1 = OwenTPatefieldTandyAlgo<Pow2.N4>.T1(0.0625, 0.25);
            MultiPrecision<Pow2.N4> n4_t5_1 = OwenTPatefieldTandyAlgo<Pow2.N4>.T5(0.0625, 0.25);
            MultiPrecision<Pow2.N4> n4_r6_1 = GaussQuadrature<Pow2.N4>.T5r6(0.0625, 0.25);
            MultiPrecision<Pow2.N4> n4_r7_1 = GaussQuadrature2<Pow2.N4>.T5r7(0.0625, 0.25);
            MultiPrecision<Pow2.N4> n4_t2_2 = OwenTPatefieldTandyAlgo<Pow2.N4>.T2(6.5, 0.4375);
            MultiPrecision<Pow2.N4> n4_t5_2 = OwenTPatefieldTandyAlgo<Pow2.N4>.T5(6.5, 0.4375);
            MultiPrecision<Pow2.N4> n4_r6_2 = GaussQuadrature<Pow2.N4>.T5r6(6.5, 0.4375);
            MultiPrecision<Pow2.N4> n4_r7_2 = GaussQuadrature2<Pow2.N4>.T5r7(6.5, 0.4375);
            MultiPrecision<Pow2.N4> n4_t4_3 = OwenTPatefieldTandyAlgo<Pow2.N4>.T4(7, 0.96875);
            MultiPrecision<Pow2.N4> n4_t5_3 = OwenTPatefieldTandyAlgo<Pow2.N4>.T5(7, 0.96875);
            MultiPrecision<Pow2.N4> n4_r6_3 = GaussQuadrature<Pow2.N4>.T5r6(7, 0.96875);
            MultiPrecision<Pow2.N4> n4_r7_3 = GaussQuadrature2<Pow2.N4>.T5r7(7, 0.96875);
            MultiPrecision<Pow2.N4> n4_t2_4 = OwenTPatefieldTandyAlgo<Pow2.N4>.T2(4.78125, 0.0625);
            MultiPrecision<Pow2.N4> n4_t4_4 = OwenTPatefieldTandyAlgo<Pow2.N4>.T4(4.78125, 0.0625);
            MultiPrecision<Pow2.N4> n4_t5_4 = OwenTPatefieldTandyAlgo<Pow2.N4>.T5(4.78125, 0.0625);
            MultiPrecision<Pow2.N4> n4_r6_4 = GaussQuadrature<Pow2.N4>.T5r6(4.78125, 0.0625);
            MultiPrecision<Pow2.N4> n4_r7_4 = GaussQuadrature2<Pow2.N4>.T5r7(4.78125, 0.0625);
            MultiPrecision<Pow2.N4> n4_t4_5 = OwenTPatefieldTandyAlgo<Pow2.N4>.T4(2, 0.5);
            MultiPrecision<Pow2.N4> n4_t5_5 = OwenTPatefieldTandyAlgo<Pow2.N4>.T5(2, 0.5);
            MultiPrecision<Pow2.N4> n4_r6_5 = GaussQuadrature<Pow2.N4>.T5r6(2, 0.5);
            MultiPrecision<Pow2.N4> n4_r7_5 = GaussQuadrature2<Pow2.N4>.T5r7(2, 0.5);
            MultiPrecision<Pow2.N4> n4_t5_6 = OwenTPatefieldTandyAlgo<Pow2.N4>.T5(1, 0.9999975m);
            MultiPrecision<Pow2.N4> n4_r6_6 = GaussQuadrature<Pow2.N4>.T5r6(1, 0.9999975m);
            MultiPrecision<Pow2.N4> n4_r7_6 = GaussQuadrature2<Pow2.N4>.T5r7(1, 0.9999975m);

            MultiPrecision<Pow2.N8> n8_t1_1 = OwenTPatefieldTandyAlgo<Pow2.N8>.T1(0.0625, 0.25);
            MultiPrecision<Pow2.N8> n8_t5_1 = OwenTPatefieldTandyAlgo<Pow2.N8>.T5(0.0625, 0.25);
            MultiPrecision<Pow2.N8> n8_r6_1 = GaussQuadrature<Pow2.N8>.T5r6(0.0625, 0.25);
            MultiPrecision<Pow2.N8> n8_r7_1 = GaussQuadrature2<Pow2.N8>.T5r7(0.0625, 0.25);
            MultiPrecision<Pow2.N8> n8_t2_2 = OwenTPatefieldTandyAlgo<Pow2.N8>.T2(6.5, 0.4375);
            MultiPrecision<Pow2.N8> n8_t5_2 = OwenTPatefieldTandyAlgo<Pow2.N8>.T5(6.5, 0.4375);
            MultiPrecision<Pow2.N8> n8_r6_2 = GaussQuadrature<Pow2.N8>.T5r6(6.5, 0.4375);
            MultiPrecision<Pow2.N8> n8_r7_2 = GaussQuadrature2<Pow2.N8>.T5r7(6.5, 0.4375);
            MultiPrecision<Pow2.N8> n8_t4_3 = OwenTPatefieldTandyAlgo<Pow2.N8>.T4(7, 0.96875);
            MultiPrecision<Pow2.N8> n8_t5_3 = OwenTPatefieldTandyAlgo<Pow2.N8>.T5(7, 0.96875);
            MultiPrecision<Pow2.N8> n8_r6_3 = GaussQuadrature<Pow2.N8>.T5r6(7, 0.96875);
            MultiPrecision<Pow2.N8> n8_r7_3 = GaussQuadrature2<Pow2.N8>.T5r7(7, 0.96875);
            MultiPrecision<Pow2.N8> n8_t2_4 = OwenTPatefieldTandyAlgo<Pow2.N8>.T2(4.78125, 0.0625);
            MultiPrecision<Pow2.N8> n8_t4_4 = OwenTPatefieldTandyAlgo<Pow2.N8>.T4(4.78125, 0.0625);
            MultiPrecision<Pow2.N8> n8_t5_4 = OwenTPatefieldTandyAlgo<Pow2.N8>.T5(4.78125, 0.0625);
            MultiPrecision<Pow2.N8> n8_r6_4 = GaussQuadrature<Pow2.N8>.T5r6(4.78125, 0.0625);
            MultiPrecision<Pow2.N8> n8_r7_4 = GaussQuadrature2<Pow2.N8>.T5r7(4.78125, 0.0625);
            MultiPrecision<Pow2.N8> n8_t4_5 = OwenTPatefieldTandyAlgo<Pow2.N8>.T4(2, 0.5);
            MultiPrecision<Pow2.N8> n8_t5_5 = OwenTPatefieldTandyAlgo<Pow2.N8>.T5(2, 0.5);
            MultiPrecision<Pow2.N8> n8_r6_5 = GaussQuadrature<Pow2.N8>.T5r6(2, 0.5);
            MultiPrecision<Pow2.N8> n8_r7_5 = GaussQuadrature2<Pow2.N8>.T5r7(2, 0.5);
            MultiPrecision<Pow2.N8> n8_t5_6 = OwenTPatefieldTandyAlgo<Pow2.N8>.T5(1, 0.9999975m);
            MultiPrecision<Pow2.N8> n8_r6_6 = GaussQuadrature<Pow2.N8>.T5r6(1, 0.9999975m);
            MultiPrecision<Pow2.N8> n8_r7_6 = GaussQuadrature2<Pow2.N8>.T5r7(1, 0.9999975m);

            MultiPrecision<Pow2.N16> n16_t1_1 = OwenTPatefieldTandyAlgo<Pow2.N16>.T1(0.0625, 0.25);
            MultiPrecision<Pow2.N16> n16_t5_1 = OwenTPatefieldTandyAlgo<Pow2.N16>.T5(0.0625, 0.25);
            MultiPrecision<Pow2.N16> n16_r6_1 = GaussQuadrature<Pow2.N16>.T5r6(0.0625, 0.25);
            MultiPrecision<Pow2.N16> n16_r7_1 = GaussQuadrature2<Pow2.N16>.T5r7(0.0625, 0.25);
            MultiPrecision<Pow2.N16> n16_t2_2 = OwenTPatefieldTandyAlgo<Pow2.N16>.T2(6.5, 0.4375);
            MultiPrecision<Pow2.N16> n16_t5_2 = OwenTPatefieldTandyAlgo<Pow2.N16>.T5(6.5, 0.4375);
            MultiPrecision<Pow2.N16> n16_r6_2 = GaussQuadrature<Pow2.N16>.T5r6(6.5, 0.4375);
            MultiPrecision<Pow2.N16> n16_r7_2 = GaussQuadrature2<Pow2.N16>.T5r7(6.5, 0.4375);
            MultiPrecision<Pow2.N16> n16_t4_3 = OwenTPatefieldTandyAlgo<Pow2.N16>.T4(7, 0.96875);
            MultiPrecision<Pow2.N16> n16_t5_3 = OwenTPatefieldTandyAlgo<Pow2.N16>.T5(7, 0.96875);
            MultiPrecision<Pow2.N16> n16_r6_3 = GaussQuadrature<Pow2.N16>.T5r6(7, 0.96875);
            MultiPrecision<Pow2.N16> n16_r7_3 = GaussQuadrature2<Pow2.N16>.T5r7(7, 0.96875);
            MultiPrecision<Pow2.N16> n16_t2_4 = OwenTPatefieldTandyAlgo<Pow2.N16>.T2(4.78125, 0.0625);
            MultiPrecision<Pow2.N16> n16_t4_4 = OwenTPatefieldTandyAlgo<Pow2.N16>.T4(4.78125, 0.0625);
            MultiPrecision<Pow2.N16> n16_t5_4 = OwenTPatefieldTandyAlgo<Pow2.N16>.T5(4.78125, 0.0625);
            MultiPrecision<Pow2.N16> n16_r6_4 = GaussQuadrature<Pow2.N16>.T5r6(4.78125, 0.0625);
            MultiPrecision<Pow2.N16> n16_r7_4 = GaussQuadrature2<Pow2.N16>.T5r7(4.78125, 0.0625);
            MultiPrecision<Pow2.N16> n16_t4_5 = OwenTPatefieldTandyAlgo<Pow2.N16>.T4(2, 0.5);
            MultiPrecision<Pow2.N16> n16_t5_5 = OwenTPatefieldTandyAlgo<Pow2.N16>.T5(2, 0.5);
            MultiPrecision<Pow2.N16> n16_r6_5 = GaussQuadrature<Pow2.N16>.T5r6(2, 0.5);
            MultiPrecision<Pow2.N16> n16_r7_5 = GaussQuadrature2<Pow2.N16>.T5r7(2, 0.5);
            MultiPrecision<Pow2.N16> n16_t5_6 = OwenTPatefieldTandyAlgo<Pow2.N16>.T5(1, 0.9999975m);
            MultiPrecision<Pow2.N16> n16_r6_6 = GaussQuadrature<Pow2.N16>.T5r6(1, 0.9999975m);
            MultiPrecision<Pow2.N16> n16_r7_6 = GaussQuadrature2<Pow2.N16>.T5r7(1, 0.9999975m);

            Console.WriteLine("T1(0.0625, 0.25)");
            Console.WriteLine(n4_t1_1);
            Console.WriteLine(n8_t1_1);
            Console.WriteLine(n16_t1_1);
            Console.WriteLine("T5(0.0625, 0.25)");
            Console.WriteLine(n4_t5_1);
            Console.WriteLine(n8_t5_1);
            Console.WriteLine(n16_t5_1);
            Console.WriteLine("T5r6(0.0625, 0.25)");
            Console.WriteLine(n4_r6_1);
            Console.WriteLine(n8_r6_1);
            Console.WriteLine(n16_r6_1);
            Console.WriteLine("T5r7(0.0625, 0.25)");
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
            Console.WriteLine("T5r6(6.5, 0.4375)");
            Console.WriteLine(n4_r6_2);
            Console.WriteLine(n8_r6_2);
            Console.WriteLine(n16_r6_2);
            Console.WriteLine("T5r7(6.5, 0.4375)");
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
            Console.WriteLine("T5r6(7, 0.96875)");
            Console.WriteLine(n4_r6_3);
            Console.WriteLine(n8_r6_3);
            Console.WriteLine(n16_r6_3);
            Console.WriteLine("T5r7(7, 0.96875)");
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
            Console.WriteLine("T5r6(4.78125, 0.0625)");
            Console.WriteLine(n4_r6_4);
            Console.WriteLine(n8_r6_4);
            Console.WriteLine(n16_r6_4);
            Console.WriteLine("T5r7(4.78125, 0.0625)");
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
            Console.WriteLine("T5r6(2, 0.5)");
            Console.WriteLine(n4_r6_5);
            Console.WriteLine(n8_r6_5);
            Console.WriteLine(n16_r6_5);
            Console.WriteLine("T5r7(2, 0.5)");
            Console.WriteLine(n4_r7_5);
            Console.WriteLine(n8_r7_5);
            Console.WriteLine(n16_r7_5);

            Console.WriteLine("T5(1, 0.9999975)");
            Console.WriteLine(n4_t5_6);
            Console.WriteLine(n8_t5_6);
            Console.WriteLine(n16_t5_6);
            Console.WriteLine("T5r6(1, 0.9999975)");
            Console.WriteLine(n4_r6_6);
            Console.WriteLine(n8_r6_6);
            Console.WriteLine(n16_r6_6);
            Console.WriteLine("T5r7(1, 0.9999975)");
            Console.WriteLine(n4_r7_6);
            Console.WriteLine(n8_r7_6);
            Console.WriteLine(n16_r7_6);
        }
    }
}
