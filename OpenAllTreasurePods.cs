using Il2Cpp;
using MelonLoader;
using UnityEngine;

namespace OpenAllTreasurePods
{
    internal class Entry : MelonMod
    {
        public override void OnSceneWasLoaded(int buildIndex, string sceneName)
        {
            if (sceneName == "zoneCore" || !sceneName.Contains("zone"))
                return;

            foreach (var item in Resources.FindObjectsOfTypeAll<TreasurePod>())
            {
                if (item.CurrState == TreasurePod.State.LOCKED)
                    item.Activate();
            }
        }
    }
}
