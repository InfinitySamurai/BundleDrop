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

        static readonly BundleDrop.FollowMouseComponent followMouseComponent = new BundleDrop.FollowMouseComponent();

        public bool isFollowMouse {
            get { return HasComponent(CoreComponentIds.FollowMouse); }
            set {
                if(value != isFollowMouse) {
                    if(value) {
                        AddComponent(CoreComponentIds.FollowMouse, followMouseComponent);
                    } else {
                        RemoveComponent(CoreComponentIds.FollowMouse);
                    }
                }
            }
        }

        public Entity IsFollowMouse(bool value) {
            isFollowMouse = value;
            return this;
        }
    }
}

    public partial class CoreMatcher {

        static IMatcher _matcherFollowMouse;

        public static IMatcher FollowMouse {
            get {
                if(_matcherFollowMouse == null) {
                    var matcher = (Matcher)Matcher.AllOf(CoreComponentIds.FollowMouse);
                    matcher.componentNames = CoreComponentIds.componentNames;
                    _matcherFollowMouse = matcher;
                }

                return _matcherFollowMouse;
            }
        }
    }
