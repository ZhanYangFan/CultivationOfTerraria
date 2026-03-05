// =============================================================================
// tModLoader API 类型参考 - 便于代码提示与类型查找
// 本文件列出常用 API 类型名；实际类型来自对 tModLoader 程序集的引用。
// 若 C# 无智能提示，请确认 tModLoader.targets 指向的 tModLoader 安装路径正确。
// =============================================================================

using System;
using Terraria;
using Terraria.ModLoader;
using Terraria.ModLoader.Config;
using Terraria.ModLoader.IO;
using Terraria.ID;
using Terraria.DataStructures;
using Terraria.GameContent;
using Terraria.Localization;

namespace simpleMod.Reference
{
	/// <summary>
	/// 仅用于引用 tModLoader 常用类型，以触发 IDE 解析并提升智能提示。
	/// 不要在其他业务代码中引用本类。
	/// </summary>
	internal static class TModLoaderApiTypes
	{
		/// <summary>强制引用核心类型，确保工程能解析 tModLoader 程序集并产生智能提示。</summary>
		private static void _EnsureReferences()
		{
			_ = typeof(Mod);
			_ = typeof(ModItem);
			_ = typeof(ModNPC);
			_ = typeof(ModProjectile);
			_ = typeof(ModTile);
			_ = typeof(ModWall);
			_ = typeof(ModBuff);
			_ = typeof(ModPlayer);
			_ = typeof(ModSystem);
			_ = typeof(ModConfig);
			_ = typeof(ModBiome);
			_ = typeof(ModCommand);
			_ = typeof(Item);
			_ = typeof(NPC);
			_ = typeof(Projectile);
			_ = typeof(Player);
			_ = typeof(Recipe);
			_ = typeof(ItemLoader);
			_ = typeof(NPCLoader);
			_ = typeof(ProjectileLoader);
			_ = typeof(TileLoader);
			_ = typeof(WallLoader);
			_ = typeof(ModLoader);
			_ = typeof(ModContent);
			_ = typeof(GlobalItem);
			_ = typeof(GlobalNPC);
			_ = typeof(GlobalProjectile);
			_ = typeof(GlobalTile);
			_ = typeof(GlobalWall);
			_ = typeof(IEntitySource);
			_ = typeof(EntitySource_Parent);
			_ = typeof(TagCompound);
			_ = typeof(ContentSamples);
			_ = typeof(ItemID);
			_ = typeof(NPCID);
			_ = typeof(ProjectileID);
			_ = typeof(TileID);
			_ = typeof(WallID);
			_ = typeof(BuffID);
			_ = typeof(Main);
			_ = typeof(Language);
		}

		/// <summary>常用 Mod 内容类型名（用于搜索/对照）。</summary>
		public static class ModContentTypeNames
		{
			public const string Mod = "Terraria.ModLoader.Mod";
			public const string ModItem = "Terraria.ModLoader.ModItem";
			public const string ModNPC = "Terraria.ModLoader.ModNPC";
			public const string ModProjectile = "Terraria.ModLoader.ModProjectile";
			public const string ModTile = "Terraria.ModLoader.ModTile";
			public const string ModWall = "Terraria.ModLoader.ModWall";
			public const string ModBuff = "Terraria.ModLoader.ModBuff";
			public const string ModDust = "Terraria.ModLoader.ModDust";
			public const string ModGore = "Terraria.ModLoader.ModGore";
			public const string ModMount = "Terraria.ModLoader.ModMount";
			public const string ModPlayer = "Terraria.ModLoader.ModPlayer";
			public const string ModSystem = "Terraria.ModLoader.ModSystem";
			public const string ModConfig = "Terraria.ModLoader.Config.ModConfig";
			public const string ModCommand = "Terraria.ModLoader.ModCommand";
			public const string ModBiome = "Terraria.ModLoader.ModBiome";
			public const string ModSceneEffect = "Terraria.ModLoader.ModSceneEffect";
			public const string ModBossBar = "Terraria.ModLoader.ModBossBar";
			public const string ModMenu = "Terraria.ModLoader.ModMenu";
			public const string ModKeybind = "Terraria.ModLoader.ModKeybind";
			public const string ModPrefix = "Terraria.ModLoader.ModPrefix";
			public const string ModContent = "Terraria.ModLoader.ModContent";
			public const string ModType = "Terraria.ModLoader.ModType";
			public const string ModTileEntity = "Terraria.ModLoader.ModTileEntity";
			public const string ModPacket = "Terraria.ModLoader.ModPacket";
			public const string ModNet = "Terraria.ModLoader.ModNet";
		}

		/// <summary>Loader 类型名。</summary>
		public static class LoaderTypeNames
		{
			public const string ItemLoader = "Terraria.ModLoader.ItemLoader";
			public const string NPCLoader = "Terraria.ModLoader.NPCLoader";
			public const string ProjectileLoader = "Terraria.ModLoader.ProjectileLoader";
			public const string TileLoader = "Terraria.ModLoader.TileLoader";
			public const string WallLoader = "Terraria.ModLoader.WallLoader";
			public const string BuffLoader = "Terraria.ModLoader.BuffLoader";
			public const string DustLoader = "Terraria.ModLoader.DustLoader";
			public const string GoreLoader = "Terraria.ModLoader.GoreLoader";
			public const string MountLoader = "Terraria.ModLoader.MountLoader";
			public const string PrefixLoader = "Terraria.ModLoader.PrefixLoader";
			public const string RecipeLoader = "Terraria.ModLoader.RecipeLoader";
			public const string CommandLoader = "Terraria.ModLoader.CommandLoader";
			public const string KeybindLoader = "Terraria.ModLoader.KeybindLoader";
			public const string BossBarLoader = "Terraria.ModLoader.BossBarLoader";
			public const string SystemLoader = "Terraria.ModLoader.SystemLoader";
			public const string PlayerLoader = "Terraria.ModLoader.PlayerLoader";
			public const string BiomeLoader = "Terraria.ModLoader.BiomeLoader";
			public const string EquipLoader = "Terraria.ModLoader.EquipLoader";
		}

		/// <summary>Global 类型名。</summary>
		public static class GlobalTypeNames
		{
			public const string GlobalItem = "Terraria.ModLoader.GlobalItem";
			public const string GlobalNPC = "Terraria.ModLoader.GlobalNPC";
			public const string GlobalProjectile = "Terraria.ModLoader.GlobalProjectile";
			public const string GlobalTile = "Terraria.ModLoader.GlobalTile";
			public const string GlobalWall = "Terraria.ModLoader.GlobalWall";
			public const string GlobalBuff = "Terraria.ModLoader.GlobalBuff";
			public const string GlobalBossBar = "Terraria.ModLoader.GlobalBossBar";
			public const string GlobalRecipe = "Terraria.ModLoader.GlobalRecipe";
		}

		/// <summary>游戏核心类型名。</summary>
		public static class GameTypeNames
		{
			public const string Item = "Terraria.Item";
			public const string NPC = "Terraria.NPC";
			public const string Projectile = "Terraria.Projectile";
			public const string Player = "Terraria.Player";
			public const string Recipe = "Terraria.Recipe";
			public const string Chest = "Terraria.Chest";
			public const string Main = "Terraria.Main";
			public const string Dust = "Terraria.Dust";
		}

		/// <summary>ID 类类型名。</summary>
		public static class IdTypeNames
		{
			public const string ItemID = "Terraria.ID.ItemID";
			public const string NPCID = "Terraria.ID.NPCID";
			public const string ProjectileID = "Terraria.ID.ProjectileID";
			public const string TileID = "Terraria.ID.TileID";
			public const string WallID = "Terraria.ID.WallID";
			public const string BuffID = "Terraria.ID.BuffID";
			public const string MountID = "Terraria.ID.MountID";
			public const string PrefixID = "Terraria.ID.PrefixID";
			public const string AmmoID = "Terraria.ID.AmmoID";
			public const string DamageClass = "Terraria.ModLoader.DamageClass";
		}

		/// <summary>实体来源等常用类型名。</summary>
		public static class EntitySourceTypeNames
		{
			public const string IEntitySource = "Terraria.DataStructures.IEntitySource";
			public const string EntitySource_Parent = "Terraria.DataStructures.EntitySource_Parent";
			public const string EntitySource_ItemUse = "Terraria.DataStructures.EntitySource_ItemUse";
			public const string EntitySource_Loot = "Terraria.DataStructures.EntitySource_Loot";
			public const string EntitySource_Death = "Terraria.DataStructures.EntitySource_Death";
		}

		/// <summary>其它常用类型名。</summary>
		public static class OtherTypeNames
		{
			public const string TagCompound = "Terraria.ModLoader.IO.TagCompound";
			public const string ContentSamples = "Terraria.ModLoader.ContentSamples";
			public const string ModLoader = "Terraria.ModLoader.ModLoader";
			public const string Language = "Terraria.Localization.Language";
			public const string NetworkText = "Terraria.Localization.NetworkText";
			public const string ChatHelper = "Terraria.Chat.ChatHelper";
			public const string PlayerDrawLayer = "Terraria.ModLoader.PlayerDrawLayer";
			public const string Recipe = "Terraria.Recipe";
		}
	}
}
