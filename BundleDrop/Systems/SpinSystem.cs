using System;
using Entitas;

namespace BundleDrop {
    public class SpinSystem : IExecuteSystem, ISetPool {

        Group group;

        public void Execute() {
            foreach(Entity e in group.GetEntities()) {
                float rotationSpeed = e.rotation.speed;
                float angle = e.angle.angle;

                angle += rotationSpeed;

                e.ReplaceAngle(angle);
            }
        }

        public void SetPool(Pool pool) {
            group = pool.GetGroup(Matcher.AllOf(CoreMatcher.Rotation, CoreMatcher.Angle));
        }
    }
}
