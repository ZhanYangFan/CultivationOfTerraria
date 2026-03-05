// =============================================================================
// tModLoader API 成员索引 - 通过 nameof() 引用类型成员，便于搜索与智能提示
// 与本工程对 tModLoader 的引用配合使用；可在此文件内按成员名搜索定位到类型。
// =============================================================================

using System;
using Terraria;
using Terraria.ModLoader;
using Terraria.ModLoader.Config;
using Terraria.ModLoader.IO;
using Terraria.ID;
using Terraria.DataStructures;
using Terraria.Localization;

namespace simpleMod.Reference
{
	/// <summary>
	/// 核心类型的成员名引用，用于索引与智能提示。不在此业务代码中引用。
	/// </summary>
	internal static class TModLoaderApiMembers
	{
		static void _RefMod()
		{
			_ = nameof(Mod.AddRecipes);
			_ = nameof(Mod.AddRecipeGroups);
			_ = nameof(Mod.GetPacket);
			_ = nameof(Mod.Assets);
			_ = nameof(Mod.AddContent);
			_ = nameof(Mod.PostSetupContent);
			_ = nameof(Mod.Load);
			_ = nameof(Mod.Unload);
			_ = nameof(Mod.AddNPCHeadTexture);
			_ = nameof(Mod.AddBossHeadTexture);
			_ = nameof(Mod.Name);
			_ = nameof(Mod.Version);
			_ = nameof(Mod.DisplayName);
		}

		static void _RefModItem()
		{
			_ = nameof(ModItem.SetDefaults);
			_ = nameof(ModItem.AddRecipes);
			_ = nameof(ModItem.SetStaticDefaults);
			_ = nameof(ModItem.AllowPrefix);
			_ = nameof(ModItem.AltFunctionUse);
			_ = nameof(ModItem.UseItem);
			_ = nameof(ModItem.UseStyle);
			_ = nameof(ModItem.HoldStyle);
			_ = nameof(ModItem.ModifyWeaponDamage);
			_ = nameof(ModItem.ModifyWeaponCrit);
			_ = nameof(ModItem.ModifyWeaponKnockback);
			_ = nameof(ModItem.Shoot);
			_ = nameof(ModItem.CanUseItem);
			_ = nameof(ModItem.CanRightClick);
			_ = nameof(ModItem.ModifyTooltips);
			_ = nameof(ModItem.ModifyItemLoot);
			_ = nameof(ModItem.SaveData);
			_ = nameof(ModItem.LoadData);
			_ = nameof(ModItem.Texture);
			_ = nameof(ModItem.Type);
		}

		static void _RefModNPC()
		{
			_ = nameof(ModNPC.SetDefaults);
			_ = nameof(ModNPC.SetStaticDefaults);
			_ = nameof(ModNPC.AI);
			_ = nameof(ModNPC.OnKill);
			_ = nameof(ModNPC.ModifyNPCLoot);
			_ = nameof(ModNPC.CanHitPlayer);
			_ = nameof(ModNPC.ModifyHitByProjectile);
			_ = nameof(ModNPC.OnHitByProjectile);
			_ = nameof(ModNPC.FindFrame);
			_ = nameof(ModNPC.PreDraw);
			_ = nameof(ModNPC.PostDraw);
			_ = nameof(ModNPC.Banner);
			_ = nameof(ModNPC.BannerItem);
			_ = nameof(ModNPC.AddShops);
			_ = nameof(ModNPC.Type);
		}

		static void _RefModProjectile()
		{
			_ = nameof(ModProjectile.SetDefaults);
			_ = nameof(ModProjectile.SetStaticDefaults);
			_ = nameof(ModProjectile.AI);
			_ = nameof(ModProjectile.OnHitNPC);
			_ = nameof(ModProjectile.OnHitPlayer);
			_ = nameof(ModProjectile.ModifyDamageHitbox);
			_ = nameof(ModProjectile.CanHitNPC);
			_ = nameof(ModProjectile.CanHitPvp);
			_ = nameof(ModProjectile.PreDraw);
			_ = nameof(ModProjectile.PostDraw);
			_ = nameof(ModProjectile.Kill);
			_ = nameof(ModProjectile.Type);
		}

		static void _RefModPlayer()
		{
			_ = nameof(ModPlayer.SetStaticDefaults);
			_ = nameof(ModPlayer.Initialize);
			_ = nameof(ModPlayer.OnEnterWorld);
			_ = nameof(ModPlayer.ProcessTriggers);
			_ = nameof(ModPlayer.PreUpdate);
			_ = nameof(ModPlayer.PostUpdate);
			_ = nameof(ModPlayer.ModifyHitByNPC);
			_ = nameof(ModPlayer.OnHitByNPC);
			_ = nameof(ModPlayer.ModifyHitByProjectile);
			_ = nameof(ModPlayer.OnHitByProjectile);
			_ = nameof(ModPlayer.ModifyWeaponDamage);
			_ = nameof(ModPlayer.ModifyWeaponCrit);
			_ = nameof(ModPlayer.ModifyWeaponKnockback);
			_ = nameof(ModPlayer.CanConsumeAmmo);
			_ = nameof(ModPlayer.ModifyManaCost);
			_ = nameof(ModPlayer.SaveData);
			_ = nameof(ModPlayer.LoadData);
		}

		static void _RefModSystem()
		{
			_ = nameof(ModSystem.AddRecipes);
			_ = nameof(ModSystem.PostAddRecipes);
			_ = nameof(ModSystem.AddRecipeGroups);
			_ = nameof(ModSystem.Load);
			_ = nameof(ModSystem.Unload);
			_ = nameof(ModSystem.PostSetupContent);
			_ = nameof(ModSystem.SetupContent);
			_ = nameof(ModSystem.ModifyScreenPosition);
			_ = nameof(ModSystem.PreUpdateWorld);
			_ = nameof(ModSystem.PostUpdateWorld);
			_ = nameof(ModSystem.ResizeArrays);
		}

		static void _RefModTile()
		{
			_ = nameof(ModTile.SetStaticDefaults);
			_ = nameof(ModTile.AddToArray);
			_ = nameof(ModTile.AdjTiles);
			_ = nameof(ModTile.AnimateTile);
			_ = nameof(ModTile.AnimateIndividualTile);
			_ = nameof(ModTile.ModifyLight);
			_ = nameof(ModTile.SetDrawPositions);
			_ = nameof(ModTile.KillTile);
			_ = nameof(ModTile.HitWire);
			_ = nameof(ModTile.AddMapEntry);
			_ = nameof(ModTile.Type);
		}

		static void _RefModWall()
		{
			_ = nameof(ModWall.SetStaticDefaults);
			_ = nameof(ModWall.AnimateWall);
			_ = nameof(ModWall.KillWall);
			_ = nameof(ModWall.AddMapEntry);
			_ = nameof(ModWall.Type);
		}

		static void _RefModBuff()
		{
			_ = nameof(ModBuff.SetStaticDefaults);
			_ = nameof(ModBuff.Update);
			_ = nameof(ModBuff.Type);
		}

		static void _RefRecipe()
		{
			_ = nameof(Recipe.Create);
			_ = nameof(Recipe.AddIngredient);
			_ = nameof(Recipe.AddTile);
			_ = nameof(Recipe.AddRecipeGroup);
			_ = nameof(Recipe.Register);
			_ = nameof(Recipe.AddCondition);
			_ = nameof(Recipe.AddConsumeItemCallback);
			_ = nameof(Recipe.AddOnCraftCallback);
			_ = nameof(Recipe.AddDecraftCondition);
		}

		static void _RefItem()
		{
			_ = nameof(Item.type);
			_ = nameof(Item.damage);
			_ = nameof(Item.useStyle);
			_ = nameof(Item.useTime);
			_ = nameof(Item.useAnimation);
			_ = nameof(Item.useAmmo);
			_ = nameof(Item.ammo);
			_ = nameof(Item.shoot);
			_ = nameof(Item.shootSpeed);
			_ = nameof(Item.knockBack);
			_ = nameof(Item.rare);
			_ = nameof(Item.autoReuse);
			_ = nameof(Item.maxStack);
			_ = nameof(Item.consumable);
			_ = nameof(Item.DamageType);
			_ = nameof(Item.CloneDefaults);
			_ = nameof(Item.SetDefaults);
		}

		static void _RefPlayer()
		{
			_ = nameof(Player.AddBuff);
			_ = nameof(Player.GetItem);
			_ = nameof(Player.QuickSpawnItem);
			_ = nameof(Player.statLife);
			_ = nameof(Player.statLifeMax);
			_ = nameof(Player.statMana);
			_ = nameof(Player.statManaMax);
			_ = nameof(Player.inventory);
			_ = nameof(Player.whoAmI);
			_ = nameof(Player.InModBiome);
		}

		static void _RefNPC()
		{
			_ = nameof(NPC.type);
			_ = nameof(NPC.life);
			_ = nameof(NPC.lifeMax);
			_ = nameof(NPC.damage);
			_ = nameof(NPC.defense);
			_ = nameof(NPC.knockBackResist);
			_ = nameof(NPC.position);
			_ = nameof(NPC.width);
			_ = nameof(NPC.height);
			_ = nameof(NPC.AddBuff);
			_ = nameof(NPC.GivenName);
		}

		static void _RefProjectile()
		{
			_ = nameof(Projectile.type);
			_ = nameof(Projectile.damage);
			_ = nameof(Projectile.knockBack);
			_ = nameof(Projectile.owner);
			_ = nameof(Projectile.position);
			_ = nameof(Projectile.velocity);
			_ = nameof(Projectile.width);
			_ = nameof(Projectile.height);
			_ = nameof(Projectile.ai);
			_ = nameof(Projectile.friendly);
			_ = nameof(Projectile.hostile);
			_ = nameof(Projectile.ApplyStatsFromSource);
		}

		static void _RefGlobalItem()
		{
			_ = nameof(GlobalItem.SetDefaults);
			_ = nameof(GlobalItem.AddRecipes);
			_ = nameof(GlobalItem.ModifyWeaponDamage);
			_ = nameof(GlobalItem.ModifyWeaponCrit);
			_ = nameof(GlobalItem.ModifyTooltips);
			_ = nameof(GlobalItem.CanUseItem);
			_ = nameof(GlobalItem.UseItem);
			_ = nameof(GlobalItem.Shoot);
			_ = nameof(GlobalItem.ApplyPrefix);
			_ = nameof(GlobalItem.AllowPrefix);
			_ = nameof(GlobalItem.ModifyItemLoot);
		}

		static void _RefGlobalNPC()
		{
			_ = nameof(GlobalNPC.SetDefaults);
			_ = nameof(GlobalNPC.OnKill);
			_ = nameof(GlobalNPC.ModifyNPCLoot);
			_ = nameof(GlobalNPC.EditSpawnPool);
			_ = nameof(GlobalNPC.CanHitPlayer);
			_ = nameof(GlobalNPC.ModifyHitByProjectile);
			_ = nameof(GlobalNPC.OnHitByProjectile);
			_ = nameof(GlobalNPC.AI);
			_ = nameof(GlobalNPC.PreDraw);
			_ = nameof(GlobalNPC.PostDraw);
		}

		static void _RefGlobalProjectile()
		{
			_ = nameof(GlobalProjectile.SetDefaults);
			_ = nameof(GlobalProjectile.OnHitNPC);
			_ = nameof(GlobalProjectile.OnHitPlayer);
			_ = nameof(GlobalProjectile.CanHitNPC);
			_ = nameof(GlobalProjectile.AI);
			_ = nameof(GlobalProjectile.PreDraw);
			_ = nameof(GlobalProjectile.PostDraw);
		}

		static void _RefGlobalTile()
		{
			_ = nameof(GlobalTile.AddToArray);
			_ = nameof(GlobalTile.AdjTiles);
			_ = nameof(GlobalTile.AnimateTile);
			_ = nameof(GlobalTile.KillTile);
			_ = nameof(GlobalTile.ModifyLight);
		}

		static void _RefGlobalWall()
		{
			_ = nameof(GlobalWall.KillWall);
		}

		static void _RefEntitySource()
		{
			_ = nameof(IEntitySource.Context);
			_ = nameof(EntitySource_Parent.Entity);
			_ = nameof(EntitySource_ItemUse.Entity);
			_ = nameof(EntitySource_Loot.Entity);
			_ = nameof(EntitySource_Death.Entity);
		}

		static void _RefTagCompound()
		{
			_ = nameof(TagCompound.Add);
			_ = nameof(TagCompound.Get);
			_ = nameof(TagCompound.GetInt);
			_ = nameof(TagCompound.GetFloat);
			_ = nameof(TagCompound.GetBool);
			_ = nameof(TagCompound.GetCompound);
			_ = nameof(TagCompound.ContainsKey);
			_ = nameof(TagCompound.Remove);
		}

		static void _RefModContent()
		{
			_ = nameof(ModContent.ItemType);
			_ = nameof(ModContent.NPCType);
			_ = nameof(ModContent.ProjectileType);
			_ = nameof(ModContent.TileType);
			_ = nameof(ModContent.WallType);
			_ = nameof(ModContent.BuffType);
			_ = nameof(ModContent.MountType);
			_ = nameof(ModContent.Find);
		}

		static void _RefMain()
		{
			_ = nameof(Main.LocalPlayer);
			_ = nameof(Main.CurrentPlayer);
			_ = nameof(Main.netMode);
			_ = nameof(Main.rand);
			_ = nameof(Main.item);
			_ = nameof(Main.npc);
			_ = nameof(Main.projectile);
			_ = nameof(Main.ActivePlayers);
			_ = nameof(Main.ActiveNPCs);
			_ = nameof(Main.ActiveProjectiles);
		}

		static void _RefLanguage()
		{
			_ = nameof(Language.GetText);
			_ = nameof(Language.ActiveCulture);
			_ = nameof(Language.Exists);
		}

		static void _RefModCommand()
		{
			_ = nameof(ModCommand.Action);
			_ = nameof(ModCommand.Command);
			_ = nameof(ModCommand.Description);
		}

		static void _RefModConfig()
		{
			_ = nameof(ModConfig.NeedsReload);
			_ = nameof(ModConfig.OnLoaded);
			_ = nameof(ModConfig.OnChanged);
			_ = nameof(ModConfig.Clone);
			_ = nameof(ModConfig.AcceptClientChanges);
		}
	}
}
