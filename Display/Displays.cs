﻿using BTD_Mod_Helper.Api.Display;
using BTD_Mod_Helper.Api.Enums;
using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using FootballerMonkeyMod.Bloons;
using Il2CppAssets.Scripts.Unity;
using Il2CppAssets.Scripts.Unity.Display;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace FootballerMonkeyMod.Display {
    internal class FootballerMonkeyDisplay : ModDisplay {
        public override string BaseDisplay => GetDisplay("DartMonkey");

        public override void ModifyDisplayNode(UnityDisplayNode node) {
            // Set2DTexture(node, "FootballerMonkey2dDisplay");

            for(int i = 0; i < node.GetMeshRenderers().Count; i++) {
                // node.SaveMeshTexture(i); // Saves the mesh texture to %APPDATA%\..\LocalLow\NinjaKiwi\BloonsTD6\
                SetMeshTexture(node, "FootballerMonkeyDisplay" + i, i);
            }
        }
    }

    internal class BallProjectileDisplay : ModDisplay {
        public override string BaseDisplay => Generic2dDisplay;

        public override void ModifyDisplayNode(UnityDisplayNode node) {
            Set2DTexture(node, "BallProjectileDisplay");
        }
    }
    internal class HotBallProjectileDisplay : ModDisplay {
        public override string BaseDisplay => Generic2dDisplay;

        public override void ModifyDisplayNode(UnityDisplayNode node) {
            Set2DTexture(node, "HotBallProjectileDisplay");
        }
    }

    internal class ExampleBloonDisplay : ModBloonDisplay<ExampleBloon> {
        public override string BaseDisplay => GetBloonDisplay(BloonType.Lead);

        public override float Scale => 2;
    }

    internal class ExampleBloonDamage1Display : ModBloonDisplay<ExampleBloon> {
        public override string BaseDisplay => GetBloonDisplay(BloonType.Lead);

        public override float Scale => 1.75f;

        public override int Damage => 1;
    }

    internal class ExampleBloonDamage2Display : ModBloonDisplay<ExampleBloon> {
        public override string BaseDisplay => GetBloonDisplay(BloonType.Lead);

        public override float Scale => 1.5f;

        public override int Damage => 2;
    }

    internal class ExampleBloonDamage3Display : ModBloonDisplay<ExampleBloon> {
        public override string BaseDisplay => GetBloonDisplay(BloonType.Lead);

        public override float Scale => 1.25f;

        public override int Damage => 3;
    }

    internal class MegaJuggernautDisplay : ModDisplay {
        public override string BaseDisplay => Game.instance.model.GetTowerFromId("DartMonkey-500").GetWeapon().projectile.display.GUID;

        public override void ModifyDisplayNode(UnityDisplayNode node) {
            for(int i = 0; i < node.GetMeshRenderers().Count; i++) {
                node.SaveMeshTexture(i); // Saves the mesh texture to %APPDATA%\..\LocalLow\NinjaKiwi\BloonsTD6\
                SetMeshTexture(node, "MegaJuggernautDiffuse", i);
                SetMeshOutlineColor(node, Color.blue);
            }
        }
    }
}
