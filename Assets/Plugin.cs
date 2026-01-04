using BepInEx;
using UnboundLib;
using UnboundLib.Cards;
using UnityEngine;

namespace infinityStones
{
    [BepInPlugin("ttkcards.infinitystones", "Infinity Stones", "1.0.0")]
    [BepInDependency("com.willis.rounds.unbound")]
    public class Plugin : BaseUnityPlugin
    {
        void Start()
        {
            Unbound.RegisterCard<MindStoneCard>();
        }
    }
}
