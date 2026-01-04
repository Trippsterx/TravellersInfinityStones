using System;
using System.Collections.Generic;
using System.Text;
using UnboundLib.Cards;
using UnityEngine;

namespace infinityStones.Cards
{
    class MindStoneCard : InfinityStone
    {
        public override void OnAddCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
        {
            addInfCard(player);

            gun.unblockable = true;
        }

        public override void OnRemoveCard()
        {
        }

        protected override GameObject GetCardArt()
        {
            return null;
        }

        protected override string GetDescription()
        {
            return "The Mind Stone is the fourth of the Infinity Stones to show up in the last few years. That's not a coincidence.";
        }

        protected override CardInfo.Rarity GetRarity()
        {
            return CardInfo.Rarity.Cosmic;
        }

        protected override CardInfoStat[] GetStats()
        {
            return new CardInfoStat[]
            {
                new CardInfoStat
                {
                    positive = true,
                    stat = "Unblockable bullets",
                    amount = "100%",
                    simepleAmount = CardInfoStat.SimpleAmount.notAssigned
                }
            };
        }

        protected override CardThemeColor.CardThemeColorType GetTheme()
        {
            return CardThemeColor.CardThemeColorType.DefensiveBlue;
        }

        protected override string GetTitle()
        {
            return "Mind Stone";
        }

        public override string GetModName()
        {
            return "TTKCards";
        }
    }
}