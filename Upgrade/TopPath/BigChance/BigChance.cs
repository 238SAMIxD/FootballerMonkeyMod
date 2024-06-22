using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Abilities.Behaviors;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Abilities;
using Il2CppAssets.Scripts.Unity;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using static FootballerMonkeyMod.FootballerMonkeyMod;
using Il2CppAssets.Scripts.Models.Towers.Projectiles.Behaviors;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Emissions;

namespace FootballerMonkeyMod.Upgrade.TopPath.BigChance
{
    internal class BigChance : ModUpgrade<FootballerMonkey>
    {
        public override int Path => TOP;

        public override int Tier => 4;

        public override int Cost => 4000;

        public override string Description => "Adds damage and bounce.";

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            var attackModel = towerModel.GetAttackModel();
            var weaponModel = towerModel.GetWeapon();
            var projectileModel = weaponModel.projectile;
            ProjectileBlockerCollisionReboundModel projectileBlockerCollisionReboundModel = Game.instance.model.GetTowerFromId("DartMonkey-400").GetDescendant<ProjectileBlockerCollisionReboundModel>().Duplicate();

            weaponModel.projectile.AddBehavior(projectileBlockerCollisionReboundModel);
            projectileModel.GetDamageModel().damage += 5;
            attackModel.range += 5;
            towerModel.range += 5;
            weaponModel.rate /= 2;
        }
    }
}
