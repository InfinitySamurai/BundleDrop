using System;
using Entitas;

namespace BundleDrop{
    public class HandleCollisionSystem : IExecuteSystem, ISetPool {

        Group group;

        public void Execute() {
            foreach(Entity e in group.GetEntities()) {
                e.RemoveCollision();
                Console.WriteLine("Things collided!");
            }
        }

        public void SetPool(Pool pool) {
            group = pool.GetGroup(Matcher.AllOf(CoreMatcher.Collision));
        }
    }
}
