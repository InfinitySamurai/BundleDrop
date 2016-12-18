using Entitas;
namespace BundleDrop{
    [Core]
    public class CollisionComponent : IComponent{
        public Entity self;
        public Entity other;
    }
}
