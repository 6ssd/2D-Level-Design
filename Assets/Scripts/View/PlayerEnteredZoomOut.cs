using Platformer.Core;
using Platformer.Mechanics;
using Platformer.Model;
using UnityEngine;

namespace Platformer.Gameplay
{
    /// <summary>
    /// Fired when a player enters a trigger with a ZoomOut component.
    /// </summary>
    /// <typeparam name="PlayerEnteredZoomOut"></typeparam>
    public class PlayerEnteredZoomOut : Simulation.Event<PlayerEnteredZoomOut>
    {
        public ZoomOut zoomOut;

        PlatformerModel model = Simulation.GetModel<PlatformerModel>();

        public override void Execute()
        {
            model.virtualCamera.m_Lens.OrthographicSize = 7.5f;
        }
    }
}