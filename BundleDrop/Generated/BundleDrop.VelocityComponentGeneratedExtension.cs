//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.ComponentExtensionsGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Entitas;

namespace Entitas {

    public partial class Entity {

        public BundleDrop.VelocityComponent velocity { get { return (BundleDrop.VelocityComponent)GetComponent(CoreComponentIds.Velocity); } }
        public bool hasVelocity { get { return HasComponent(CoreComponentIds.Velocity); } }

        public Entity AddVelocity(float newX, float newY) {
            var component = CreateComponent<BundleDrop.VelocityComponent>(CoreComponentIds.Velocity);
            component.x = newX;
            component.y = newY;
            return AddComponent(CoreComponentIds.Velocity, component);
        }

        public Entity ReplaceVelocity(float newX, float newY) {
            var component = CreateComponent<BundleDrop.VelocityComponent>(CoreComponentIds.Velocity);
            component.x = newX;
            component.y = newY;
            ReplaceComponent(CoreComponentIds.Velocity, component);
            return this;
        }

        public Entity RemoveVelocity() {
            return RemoveComponent(CoreComponentIds.Velocity);
        }
    }
}

    public partial class CoreMatcher {

        static IMatcher _matcherVelocity;

        public static IMatcher Velocity {
            get {
                if(_matcherVelocity == null) {
                    var matcher = (Matcher)Matcher.AllOf(CoreComponentIds.Velocity);
                    matcher.componentNames = CoreComponentIds.componentNames;
                    _matcherVelocity = matcher;
                }

                return _matcherVelocity;
            }
        }
    }
