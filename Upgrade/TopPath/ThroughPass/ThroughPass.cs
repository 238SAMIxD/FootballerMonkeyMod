using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Abilities.Behaviors;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Abilities;
using Il2CppAssets.Scripts.Unity;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using static FootballerMonkeyMod.FootballerMonkeyMod;

namespace FootballerMonkeyMod.Upgrade.TopPath.ThroughPass
{
    internal class ThroughPass : ModUpgrade<FootballerMonkey>
    {
        public override int Path => TOP;

        public override int Tier => 3;

        public override int Cost => 500;

        public override string Description => "Gives much pierce and some damage.";

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            var attackModel = towerModel.GetAttackModel();
            var weaponModel = towerModel.GetWeapon();
            var projectileModel = weaponModel.projectile;

            projectileModel.GetDamageModel().damage += 1;
            projectileModel.pierce += 6;
        }
    }
}
