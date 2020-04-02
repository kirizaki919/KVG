using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace KVG.Projectiles
{

public class GetsugaTenshou : ModProjectile
{
public override void SetDefaults()
{

projectile.width = 100; //projectile width
projectile.height = 100; //projectile height
projectile.friendly = true; //make that the projectile will not damage you
projectile.melee = true; //
projectile.tileCollide = false; //make that the projectile will be destroed if it hits the terrain
projectile.penetrate = 30; //how many npc will penetrate
projectile.timeLeft = 9999; //how many time this projectile has before disepire
projectile.light = 1.00f; // projectile light
projectile.extraUpdates = 1;
projectile.ignoreWater = true;
}
public override void AI() //this make that the projectile will face the corect way
{ // |
projectile.rotation = (float)Math.Atan2((double)projectile.velocity.Y, (double)projectile.velocity.X) + 0.3f;
}
}
}