using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using FootballerMonkeyMod.Display;
using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Models.TowerSets;

namespace FootballerMonkeyMod {
    internal class FootballerMonkey : ModTower {
        public override TowerSet TowerSet => TowerSet.Primary;

        public override string BaseTower => TowerType.DartMonkey;

        public override int Cost => 500;

        public override string Description => "Play the ball";

        public override string DisplayName => "Footballer Monkey";

        public override void ModifyBaseTowerModel(TowerModel towerModel) {
            var attackModel = towerModel.GetAttackModel();
            var weaponModel = towerModel.GetWeapon();
            var projectileModel = weaponModel.projectile;

            // range
            const float range = 50;
            towerModel.range = range;
            attackModel.range = range;

            // attack speed
            weaponModel.rate *= 3;

            // damage + pierce
            projectileModel.pierce = 3;
            projectileModel.GetDamageModel().damage = 2;

            towerModel.ApplyDisplay<FootballerMonkeyDisplay>();
            projectileModel.ApplyDisplay<BallProjectileDisplay>();
        }
    }
}
