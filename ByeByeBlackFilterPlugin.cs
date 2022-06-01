using UnityEngine;
using BepInEx;
using BepInEx.Configuration;

namespace r1ft.ByeByeBlackFilter
{
    [BepInPlugin("com.r1ft.ByeByeBlackFilter", "r1ft.ByeByeBlackFilter", "1.0.0")]
    public class ByeByeBlackFilter : BaseUnityPlugin
    {
        public static GameObject Hook;

        private void Awake()
        {
            Logger.LogInfo("Loading: r1fT-ByeByeBlackFilter");
            Hook = new GameObject("ByeByeBlackFilter");
            Hook.AddComponent<ByeByeBlackFilterController>();
            DontDestroyOnLoad(Hook);
        }
    }
}
