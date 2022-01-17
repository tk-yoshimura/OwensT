using MultiPrecision;

namespace OwensT {
    internal struct Plus8<N> : IConstant where N : struct, IConstant {
        public int Value => checked(default(N).Value + 8);
    }
}
