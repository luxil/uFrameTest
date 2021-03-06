// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace test {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using test;
    using uFrame.ECS.APIs;
    using uFrame.ECS.Components;
    using uFrame.ECS.Systems;
    using uFrame.Kernel;
    using UniRx;
    using UnityEngine;
    
    
    public partial class MenuSystemBase : uFrame.ECS.Systems.EcsSystem {
        
        private IEcsComponentManagerOf<MenuComponent> _MenuComponentManager;
        
        private IEcsComponentManagerOf<Health> _HealthManager;
        
        private MenuSystemMenuToggleEventHandler MenuSystemMenuToggleEventHandlerInstance = new MenuSystemMenuToggleEventHandler();
        
        public IEcsComponentManagerOf<MenuComponent> MenuComponentManager {
            get {
                return _MenuComponentManager;
            }
            set {
                _MenuComponentManager = value;
            }
        }
        
        public IEcsComponentManagerOf<Health> HealthManager {
            get {
                return _HealthManager;
            }
            set {
                _HealthManager = value;
            }
        }
        
        public override void Setup() {
            base.Setup();
            MenuComponentManager = ComponentSystem.RegisterComponent<MenuComponent>(3);
            HealthManager = ComponentSystem.RegisterComponent<Health>(1);
            this.OnEvent<test.MenuToggleEvent>().Subscribe(_=>{ MenuSystemMenuToggleEventFilter(_); }).DisposeWith(this);
        }
        
        protected virtual void MenuSystemMenuToggleEventHandler(test.MenuToggleEvent data, MenuComponent group) {
            var handler = MenuSystemMenuToggleEventHandlerInstance;
            handler.System = this;
            handler.Event = data;
            handler.Group = group;
            handler.Execute();
        }
        
        protected void MenuSystemMenuToggleEventFilter(test.MenuToggleEvent data) {
            var MenuComponentItems = MenuComponentManager.Components;
            for (var MenuComponentIndex = 0
            ; MenuComponentIndex < MenuComponentItems.Count; MenuComponentIndex++
            ) {
                if (!MenuComponentItems[MenuComponentIndex].Enabled) {
                    continue;
                }
                this.MenuSystemMenuToggleEventHandler(data, MenuComponentItems[MenuComponentIndex]);
            }
        }
    }
    
    [uFrame.Attributes.uFrameIdentifier("3ff0f0bc-275d-4647-a67e-612fb86b6b7f")]
    public partial class MenuSystem : MenuSystemBase {
        
        private static MenuSystem _Instance;
        
        public MenuSystem() {
            Instance = this;
        }
        
        public static MenuSystem Instance {
            get {
                return _Instance;
            }
            set {
                _Instance = value;
            }
        }
    }
}
