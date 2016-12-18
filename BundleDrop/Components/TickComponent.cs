using Entitas;
using Entitas.CodeGenerator;

namespace BundleDrop {

    [Core, SingleEntity]
    public sealed class TickComponent : IComponent {
        public ulong value;
    }
}
