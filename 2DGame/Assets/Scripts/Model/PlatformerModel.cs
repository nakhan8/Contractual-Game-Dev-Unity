using Platformer.Mechanics;
using UnityEngine;

namespace Platformer.Model
{
    /// The main model containing needed data to implement a platformer style 
    /// It is initialised with data in the GameController class.
 
    [System.Serializable]
    public class PlatformerModel
    {
  
        /// The virtual camera in the scene.
       
        public Cinemachine.CinemachineVirtualCamera virtualCamera;

       
        /// The main component which controls the player sprite, controlled 
        /// by the user.
       
        public PlayerController player;

 
        /// The spawn point in the scene.
        public Transform spawnPoint;

        /// A global jump modifier applied to all initial jump velocities.
  
        public float jumpModifier = 1.5f;
  
        public float jumpDeceleration = 0.5f;

    }
}