using Pathfinding;
using UnityEngine;

namespace Raketa420
{
    [RequireComponent(typeof(Seeker))]
    [RequireComponent(typeof(AIPath))]

    public class PathfindingMovement : MonoBehaviour
    {
        private AIPath aiPath;

        public AIPath AiPath => aiPath;

        public void Initialize()
        {
            aiPath = GetComponent<AIPath>();
        }

        public void MoveTo(Vector3 point)
        {
            aiPath.destination = point;
        }
    }
}