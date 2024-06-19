using Il2CppAssets.Scripts.Models.Towers;
using PathsPlusPlus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballerMonkeyMod.Upgrade
{
    internal class ExamplePathExtension : PathPlusPlus
    {
        public override string Tower => TowerType.DartMonkey; // TowerID<FootballerMonkey>();

        public override int ExtendVanillaPath => Top;
    }
}
