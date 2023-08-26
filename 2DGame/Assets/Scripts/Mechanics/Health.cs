using System;
using Platformer.Gameplay;
using UnityEngine;
using static Platformer.Core.Simulation;

namespace Platformer.Mechanics
{
   
    /// Represebts the current vital statistics of some game entity.
 
    public class Health : MonoBehaviour
    {
        
        /// The maximum hit points for the entity.
     
        public int maxHP = 1;

     
        /// Indicates if the entity should be considered 'alive'.
       
        public bool IsAlive => currentHP > 0;

        int currentHP;

    
        /// Increment the HP of the entity.
    
        public void Increment()
        {
            currentHP = Mathf.Clamp(currentHP + 1, 0, maxHP);
        }

   
        /// Decrement the HP of the entity. Will trigger a HealthIsZero event when
        /// current HP reaches 0.
        
        public void Decrement()
        {
            currentHP = Mathf.Clamp(currentHP - 1, 0, maxHP);
            if (currentHP == 0)
            {
                var ev = Schedule<HealthIsZero>();
                ev.health = this;
            }
        }

     
        /// Decrement the HP of the entitiy until HP reaches 0.
        
        public void Die()
        {
            while (currentHP > 0) Decrement();
        }

        void Awake()
        {
            currentHP = maxHP;
        }
    }
}
