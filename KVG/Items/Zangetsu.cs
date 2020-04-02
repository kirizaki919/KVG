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
                glowMask = GlowMaskAPI.Tools.instance.AddGlowMask(mod.GetTexture("Items/Zangetsu_Glow"));
        }

        public override void SetDefaults()
        {
			item.damage = 200000;
			item.melee = true;
			item.width = 20;
			item.height = 20;
			item.useTime = 10;
			item.useAnimation = 10;
			item.useStyle = 1;
			item.knockBack = 100;
			item.value = 10000;
			item.rare = 10;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
            item.glowMask=glowMask;
            item.shoot = mod.ProjectileType("GetsugaTenshou");
            item.shootSpeed = 8f;
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