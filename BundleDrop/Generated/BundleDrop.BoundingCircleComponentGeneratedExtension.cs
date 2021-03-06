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

        public BundleDrop.BoundingCircleComponent boundingCircle { get { return (BundleDrop.BoundingCircleComponent)GetComponent(CoreComponentIds.BoundingCircle); } }
        public bool hasBoundingCircle { get { return HasComponent(CoreComponentIds.BoundingCircle); } }

        public Entity AddBoundingCircle(float newRadius) {
            var component = CreateComponent<BundleDrop.BoundingCircleComponent>(CoreComponentIds.BoundingCircle);
            component.radius = newRadius;
            return AddComponent(CoreComponentIds.BoundingCircle, component);
        }

        public Entity ReplaceBoundingCircle(float newRadius) {
            var component = CreateComponent<BundleDrop.BoundingCircleComponent>(CoreComponentIds.BoundingCircle);
            component.radius = newRadius;
            ReplaceComponent(CoreComponentIds.BoundingCircle, component);
            return this;
        }

        public Entity RemoveBoundingCircle() {
            return RemoveComponent(CoreComponentIds.BoundingCircle);
        }
    }
}

    public partial class CoreMatcher {

        static IMatcher _matcherBoundingCircle;

        public static IMatcher BoundingCircle {
            get {
                if(_matcherBoundingCircle == null) {
                    var matcher = (Matcher)Matcher.AllOf(CoreComponentIds.BoundingCircle);
                    matcher.componentNames = CoreComponentIds.componentNames;
                    _matcherBoundingCircle = matcher;
                }

                return _matcherBoundingCircle;
            }
        }
    }
