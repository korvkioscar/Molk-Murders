﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MolkMurdersSystem {
    public abstract class GameEvent {
        // TODO: Make properties out of these
        public List<IEventCondition> Conditions;
        public int Priority;
        public EventType Type;

        public enum EventType {
            Regular,
            Death,
            ItemPickup
        }

        public GameEvent() {

        }

        public virtual EventData Execute(Character character) {
            // This is where logic would go...
            return new EventData("This is a default message.", [character]); // Often, multiple characters are involved.
        }

        public virtual bool MeetsConditions(Character character) {
            return true;
        }
    }
}
