using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using FootballerMonkeyMod.Display;
using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Models.TowerSets;

namespace FootballerMonkeyMod
{
    internal class FootballerMonkey : ModTower
    {
        public override TowerSet TowerSet => TowerSet.Primary;

        public override string BaseTower => TowerType.DartMonkey; // You can replace TowerType.SuperMonkey with "SuperMonkey" or "SuperMonkey-005"

        public override int Cost => 500;

        public override string Description => "Play the ball";

        public override string DisplayName => "Footballer Monkey"; // This is by default Example Monkey as the Mod Helper automatically puts spaces in-between the uppercase letters in the class name, it is this way for Towers, Heroes, Upgrades, and Paragons

        public override void ModifyBaseTowerModel(TowerModel towerModel)
        {
            var attackModel = towerModel.GetAttackModel();
            var weaponModel = towerModel.GetWeapon(); // You can change this is towerModel.GetAttackModel().weapons[0];
            var projectileModel = weaponModel.projectile;

            // range
            towerModel.range += 25;
            attackModel.range += 25;

            // attack speed
            weaponModel.rate *= 3;

            // damage + pierce
            projectileModel.pierce = 10;
            projectileModel.GetDamageModel().damage = 4;

            towerModel.ApplyDisplay<FootballerMonkeyDisplay>();
            projectileModel.ApplyDisplay<ExampleProjectileDisplay>();
        }
    }
}
