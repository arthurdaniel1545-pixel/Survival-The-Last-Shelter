using System;
using System.Collections.Generic;
using UnityEngine;
using SurvivalTheLastShelter.Player;
using SurvivalTheLastShelter.Inventory;

namespace SurvivalTheLastShelter.Persistence
{
    [Serializable]
    public sealed class PlayerStateSaveData
    {
        public int Version = 1;
        public Vector3 Position;
        public Quaternion Rotation;
        public PlayerSurvivalStats Survival = new PlayerSurvivalStats();
        public List<InventoryEntry> Inventory = new List<InventoryEntry>();
    }
}
