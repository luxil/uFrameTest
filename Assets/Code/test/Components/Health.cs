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
    using uFrame.ECS;
    using uFrame.ECS.Components;
    using uFrame.Json;
    using UniRx;
    using UnityEngine;
    
    
    [uFrame.Attributes.ComponentId(1)]
    [uFrame.Attributes.uFrameIdentifier("3cf05187-6e63-4e34-8442-dd3d3740e2a7")]
    public partial class Health : uFrame.ECS.Components.EcsComponent {
        
        [UnityEngine.SerializeField()]
        private Int32 _health;
        
        private Subject<PropertyChangedEvent<Int32>> _healthObservable;
        
        private PropertyChangedEvent<Int32> _healthEvent;
        
        public override int ComponentId {
            get {
                return 1;
            }
        }
        
        public IObservable<PropertyChangedEvent<Int32>> healthObservable {
            get {
                return _healthObservable ?? (_healthObservable = new Subject<PropertyChangedEvent<Int32>>());
            }
        }
        
        public Int32 health {
            get {
                return _health;
            }
            set {
                Sethealth(value);
            }
        }
        
        public virtual void Sethealth(Int32 value) {
            SetProperty(ref _health, value, ref _healthEvent, _healthObservable);
        }
    }
}
