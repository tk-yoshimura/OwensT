using MultiPrecision;

namespace OwensT {
    public static class OneMinusErfErf<N, M> where N : struct, IConstant where M : struct, IConstant {
        public static MultiPrecision<N> Value(MultiPrecision<N> a, MultiPrecision<N> b) {
            MultiPrecision<M> a_erf = MultiPrecision<M>.Erf(a.Convert<M>());
            MultiPrecision<M> b_erf = MultiPrecision<M>.Erf(b.Convert<M>());

            MultiPrecision<M> y = 1 - a_erf * b_erf;

            return y.Convert<N>();
        }
    }
}
