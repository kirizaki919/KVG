using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace KVG.Projectiles
{

      public class GetsugaTenshou : ModProjectile
  {
      public override void SetDefaults()
    {

     projectile.width = 500; //projectile width
     projectile.height = 500; //projectile height
     projectile.friendly = true; //make that the projectile will not damage you
     projectile.melee = true; //
     projectile.tileCollide = false; //make that the projectile will be destroed if it hits the terrain
     projectile.penetrate = 9999; //how many npc will penetrate
     projectile.timeLeft = 300; //how many time this projectile has before disepire
     projectile.light = 10f; // projectile light
     projectile.extraUpdates = 1;
     projectile.ignoreWater = true;
     projectile.soundDelay = 1;
     projectile.alpha = 255;
 
     }



     public override void AI() //this make that the projectile will face the corect way
     { projectile.rotation = (float)Math.Atan2((double)projectile.velocity.Y, (double)projectile.velocity.X) + 0.3f;
			// Speed up
			projectile.ai[0] += 0.5f;
            if (projectile.ai[0] > 1f){
               projectile.alpha -= 3;     
			}


			projectile.velocity *= 0.95f;
			// Speed up after 60 frame = 1 seconds
			if (++projectile.frameCounter >= 120) {
				projectile.velocity *=1.5f;
			}
     }
   }
}