using Platformer.Core;
using Platformer.Mechanics;
using Platformer.Model;
using UnityEngine;
using System.Collections;

namespace Platformer.Gameplay
{
    /// <summary>
    /// Fired when a player enters a trigger with a DeathZone component.
    /// </summary>
    /// <typeparam name="RespawnEnemies"></typeparam>
    public class RespawnEnemies : Simulation.Event<RespawnEnemies>
    {
        public GameObject[] respawns;

        public override void Execute()
        {
            if (respawns == null)
                respawns = GameObject.FindGameObjectsWithTag("Respawn");

            foreach (GameObject respawn in respawns)
            {
                respawn.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
                respawn.GetComponent<EnemyController>()._collider.enabled = true;
                respawn.GetComponent<EnemyController>().control.enabled = true;
                respawn.GetComponent<EnemyController>().transform.position = respawn.GetComponent<EnemyController>().respawnPos;
            }
        }
    }
}