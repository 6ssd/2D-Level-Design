using Platformer.Core;
using Platformer.Mechanics;
using Platformer.Model;
using UnityEngine;

namespace Platformer.Gameplay
{
    /// <summary>
    /// Fired when a player enters a trigger with a SpawnPoint component.
    /// </summary>
    /// <typeparam name="PlayerEnteredSpawnPoint"></typeparam>
    public class PlayerEnteredSpawnPoint : Simulation.Event<PlayerEnteredSpawnPoint>
    {
        public SpawnPoint spawnpoint;

        PlatformerModel model = Simulation.GetModel<PlatformerModel>();

        public override void Execute()
        {
            model.spawnPoint = this.spawnpoint.transform;
            spawnpoint.GetComponent<BoxCollider2D>().enabled = false;
        }
    }
}