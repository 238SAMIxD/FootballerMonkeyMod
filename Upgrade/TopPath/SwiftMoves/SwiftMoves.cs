using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Abilities.Behaviors;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Abilities;
using Il2CppAssets.Scripts.Unity;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using static FootballerMonkeyMod.FootballerMonkeyMod;

namespace FootballerMonkeyMod.Upgrade.TopPath.SwiftMoves
{
    internal class SwiftMoves : ModUpgrade<FootballerMonkey>
    {
        public override int Path => TOP;

        public override int Tier => 1;

        public override int Cost => 300;

        public override string Description => "Gives attack speed";

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            var attackModel = towerModel.GetAttackModel();
            var weaponModel = towerModel.GetWeapon();
            var projectileModel = weaponModel.projectile;

            weaponModel.rate *= 0.75f;
        }
    }
}
