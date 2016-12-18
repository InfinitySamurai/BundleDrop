using Entitas;
using Entitas.CodeGenerator;

namespace BundleDrop{
    [Core, SingleEntity]
    public class ScoreComponent : IComponent{
        public int score;
    }
}
