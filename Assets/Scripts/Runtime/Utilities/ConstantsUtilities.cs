using UnityEngine;

namespace Runtime.Utilities
{
    public static class ConstantsUtilities
    {
        #region Tags

        public static readonly string ItemTag= "Item";

        #endregion

        #region Layers

        public static readonly int ItemLayer = LayerMask.GetMask("Item");
        public static readonly int TriggerBlockLayer = LayerMask.GetMask("TriggerBlock");
        public static readonly int ObstacleLayer = LayerMask.GetMask("Obstacle");

        #endregion

        #region Layer Masks
        
        public static readonly LayerMask ItemLayerMask = LayerMask.GetMask("Item");
        public static readonly LayerMask TriggerBlockLayerMask = LayerMask.GetMask("TriggerBlock");
        public static readonly LayerMask ObstacleLayerMask = LayerMask.GetMask("Obstacle");

        #endregion

        #region Animator Hashes

        #endregion
    }
}