using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Abilities.Behaviors;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Abilities;
using Il2CppAssets.Scripts.Unity;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using static FootballerMonkeyMod.FootballerMonkeyMod;
using FootballerMonkeyMod.Display;
using Il2CppAssets.Scripts.Models.Towers.Projectiles.Behaviors;
using Il2Cpp;

namespace FootballerMonkeyMod.Upgrade.TopPath.HotBall
{
    internal class HotBall : ModUpgrade<FootballerMonkey>
    {
        public override int Path => TOP;

        public override int Tier => 2;

        public override int Cost => 400;

        public override string Description => "Can pop lead bloons. Adds damage and pierce.";

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            var attackModel = towerModel.GetAttackModel();
            var weaponModel = towerModel.GetWeapon();
            var projectileModel = weaponModel.projectile;

            projectileModel.GetDamageModel().damage += 1;
            projectileModel.pierce += 1;
            projectileModel.GetDamageModel().immuneBloonProperties &= ~BloonProperties.Lead;
            projectileModel.ApplyDisplay<HotBallProjectileDisplay>();
        }
    }
}
