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

        static readonly BundleDrop.ClickableComponent clickableComponent = new BundleDrop.ClickableComponent();

        public bool isClickable {
            get { return HasComponent(CoreComponentIds.Clickable); }
            set {
                if(value != isClickable) {
                    if(value) {
                        AddComponent(CoreComponentIds.Clickable, clickableComponent);
                    } else {
                        RemoveComponent(CoreComponentIds.Clickable);
                    }
                }
            }
        }

        public Entity IsClickable(bool value) {
            isClickable = value;
            return this;
        }
    }
}

    public partial class CoreMatcher {

        static IMatcher _matcherClickable;

        public static IMatcher Clickable {
            get {
                if(_matcherClickable == null) {
                    var matcher = (Matcher)Matcher.AllOf(CoreComponentIds.Clickable);
                    matcher.componentNames = CoreComponentIds.componentNames;
                    _matcherClickable = matcher;
                }

                return _matcherClickable;
            }
        }
    }
