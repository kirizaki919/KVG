using Terraria;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;

namespace KVG.Items
{
	public class Zangetsu : ModItem
	{
		
        public static short glowMask;
	
		public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Zangetsu");
			Tooltip.SetDefault("Sugei Na");
            glowMask = GlowMaskAPI.Tools.instance.AddGlowMask(mod.GetTexture("Items/Zangetsu_Glow"));
        }

        public override void SetDefaults()
        {
			item.melee = true;
			item.width = 20;
			item.height = 20;
			item.useStyle = 1;
			item.knockBack = 100;
			item.value = 10000;
			item.rare = 10;
			item.autoReuse = true;
			item.glowMask = glowMask;
        }

		public override bool AltFunctionUse(Player player)
		{
		return true;
		}

		public override bool CanUseItem(Player player)
		{

		if (player.altFunctionUse == 2)
		{
			item.damage = 200000;
			item.melee = true;
			item.width = 20;
			item.height = 20;
			item.mana = 5;
			item.useTime = 80;
			item.useAnimation = 80;
			item.useStyle = 1;
			item.knockBack = 100;
			item.autoReuse = true;
            item.shoot = mod.ProjectileType("GetsugaTenshou");
            item.shootSpeed = 3f;
			item.UseSound = mod.GetLegacySoundSlot(SoundType.Item, "Sounds/Item/GetsugaSound");
			item.healMana = 10;
			item.healLife = 10;
		}

		else
		{
			item.damage = 200;
			item.melee = true;
			item.width = 20;
			item.height = 20;
			item.mana = 0;
			item.useTime = 10;
			item.useAnimation = 10;
			item.useStyle = 1;
			item.knockBack = 100;
			item.autoReuse = true;
			item.shoot = 0;
			item.UseSound = SoundID.Item1;
		}
		return true;
		}

        public override Vector2? HoldoutOffset() {
        return Vector2.Zero;
        }

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}


    }
}