using KVG.Projectiles;
using Terraria;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace KVG.Items
{
	public class ExampleLastPrism : ModItem
	{
		public override string Texture => "Terraria/Item_" + ItemID.LastPrism;
		public static Color OverrideColor = new Color(122, 173, 255);

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Example Last Prism");
			Tooltip.SetDefault(@"A slightly different laser-firing Prism
Ignores NPC immunity frames and fires 10 beams at once instead of 6.");
		}

		public override void SetDefaults()
		{
			item.CloneDefaults(ItemID.LastPrism);
			item.mana = 0;
			item.damage = 42;
			item.shoot = ProjectileType<ExampleLastPrismHoldout>();
			item.shootSpeed = 30f;

			// Change the item's draw color so that it is visually distinct from the vanilla Last Prism.
			item.color = OverrideColor;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

		// Because this weapon fires a holdout projectile, it needs to block usage if its projectile already exists.
		public override bool CanUseItem(Player player) => player.ownedProjectileCounts[ProjectileType<ExampleLastPrismHoldout>()] <= 0;
	}
}