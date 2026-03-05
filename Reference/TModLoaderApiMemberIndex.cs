// =============================================================================
// tModLoader API 成员名索引（纯字符串，用于工程内搜索）
// 不参与类型解析，仅便于按成员名/类型名搜索。智能提示以 TModLoaderApiTypes + TModLoaderApiMembers 为准。
// =============================================================================

namespace simpleMod.Reference
{
	/// <summary>按类型分组的成员名常量，便于全文搜索定位到“哪个类型有哪些成员”。</summary>
	internal static class TModLoaderApiMemberIndex
	{
		public static class ModMembers
		{
			public const string AddRecipes = "AddRecipes";
			public const string AddRecipeGroups = "AddRecipeGroups";
			public const string GetPacket = "GetPacket";
			public const string Assets = "Assets";
			public const string AddContent = "AddContent";
			public const string PostSetupContent = "PostSetupContent";
			public const string Load = "Load";
			public const string Unload = "Unload";
			public const string AddNPCHeadTexture = "AddNPCHeadTexture";
			public const string AddBossHeadTexture = "AddBossHeadTexture";
			public const string Name = "Name";
			public const string Version = "Version";
			public const string DisplayName = "DisplayName";
		}

		public static class ModItemMembers
		{
			public const string SetDefaults = "SetDefaults";
			public const string SetStaticDefaults = "SetStaticDefaults";
			public const string AddRecipes = "AddRecipes";
			public const string AllowPrefix = "AllowPrefix";
			public const string AltFunctionUse = "AltFunctionUse";
			public const string UseItem = "UseItem";
			public const string UseStyle = "UseStyle";
			public const string HoldStyle = "HoldStyle";
			public const string ModifyWeaponDamage = "ModifyWeaponDamage";
			public const string ModifyWeaponCrit = "ModifyWeaponCrit";
			public const string ModifyWeaponKnockback = "ModifyWeaponKnockback";
			public const string Shoot = "Shoot";
			public const string CanUseItem = "CanUseItem";
			public const string CanRightClick = "CanRightClick";
			public const string ModifyTooltips = "ModifyTooltips";
			public const string ModifyItemLoot = "ModifyItemLoot";
			public const string SaveData = "SaveData";
			public const string LoadData = "LoadData";
			public const string Texture = "Texture";
			public const string Type = "Type";
		}

		public static class ModNPCMembers
		{
			public const string SetDefaults = "SetDefaults";
			public const string SetStaticDefaults = "SetStaticDefaults";
			public const string AI = "AI";
			public const string OnKill = "OnKill";
			public const string ModifyNPCLoot = "ModifyNPCLoot";
			public const string CanHitPlayer = "CanHitPlayer";
			public const string ModifyHitByProjectile = "ModifyHitByProjectile";
			public const string OnHitByProjectile = "OnHitByProjectile";
			public const string FindFrame = "FindFrame";
			public const string PreDraw = "PreDraw";
			public const string PostDraw = "PostDraw";
			public const string Banner = "Banner";
			public const string BannerItem = "BannerItem";
			public const string AddShops = "AddShops";
			public const string Type = "Type";
		}

		public static class ModProjectileMembers
		{
			public const string SetDefaults = "SetDefaults";
			public const string SetStaticDefaults = "SetStaticDefaults";
			public const string AI = "AI";
			public const string OnHitNPC = "OnHitNPC";
			public const string OnHitPlayer = "OnHitPlayer";
			public const string ModifyDamageHitbox = "ModifyDamageHitbox";
			public const string CanHitNPC = "CanHitNPC";
			public const string CanHitPvp = "CanHitPvp";
			public const string PreDraw = "PreDraw";
			public const string PostDraw = "PostDraw";
			public const string Kill = "Kill";
			public const string Type = "Type";
		}

		public static class ModPlayerMembers
		{
			public const string SetStaticDefaults = "SetStaticDefaults";
			public const string Initialize = "Initialize";
			public const string OnEnterWorld = "OnEnterWorld";
			public const string ProcessTriggers = "ProcessTriggers";
			public const string PreUpdate = "PreUpdate";
			public const string PostUpdate = "PostUpdate";
			public const string ModifyHitByNPC = "ModifyHitByNPC";
			public const string OnHitByNPC = "OnHitByNPC";
			public const string ModifyHitByProjectile = "ModifyHitByProjectile";
			public const string OnHitByProjectile = "OnHitByProjectile";
			public const string ModifyWeaponDamage = "ModifyWeaponDamage";
			public const string ModifyWeaponCrit = "ModifyWeaponCrit";
			public const string ModifyWeaponKnockback = "ModifyWeaponKnockback";
			public const string CanConsumeAmmo = "CanConsumeAmmo";
			public const string ModifyManaCost = "ModifyManaCost";
			public const string SaveData = "SaveData";
			public const string LoadData = "LoadData";
		}

		public static class ModSystemMembers
		{
			public const string AddRecipes = "AddRecipes";
			public const string PostAddRecipes = "PostAddRecipes";
			public const string AddRecipeGroups = "AddRecipeGroups";
			public const string Load = "Load";
			public const string Unload = "Unload";
			public const string PostSetupContent = "PostSetupContent";
			public const string SetupContent = "SetupContent";
			public const string ModifyScreenPosition = "ModifyScreenPosition";
			public const string PreUpdateWorld = "PreUpdateWorld";
			public const string PostUpdateWorld = "PostUpdateWorld";
			public const string ResizeArrays = "ResizeArrays";
		}

		public static class RecipeMembers
		{
			public const string Create = "Create";
			public const string AddIngredient = "AddIngredient";
			public const string AddTile = "AddTile";
			public const string AddRecipeGroup = "AddRecipeGroup";
			public const string Register = "Register";
			public const string AddCondition = "AddCondition";
			public const string AddConsumeItemCallback = "AddConsumeItemCallback";
			public const string AddOnCraftCallback = "AddOnCraftCallback";
			public const string AddDecraftCondition = "AddDecraftCondition";
		}

		public static class ItemMembers
		{
			public const string type = "type";
			public const string damage = "damage";
			public const string useStyle = "useStyle";
			public const string useTime = "useTime";
			public const string useAnimation = "useAnimation";
			public const string useAmmo = "useAmmo";
			public const string ammo = "ammo";
			public const string shoot = "shoot";
			public const string shootSpeed = "shootSpeed";
			public const string knockBack = "knockBack";
			public const string rare = "rare";
			public const string autoReuse = "autoReuse";
			public const string maxStack = "maxStack";
			public const string consumable = "consumable";
			public const string DamageType = "DamageType";
			public const string CloneDefaults = "CloneDefaults";
			public const string SetDefaults = "SetDefaults";
		}

		public static class PlayerMembers
		{
			public const string AddBuff = "AddBuff";
			public const string GetItem = "GetItem";
			public const string QuickSpawnItem = "QuickSpawnItem";
			public const string statLife = "statLife";
			public const string statLifeMax = "statLifeMax";
			public const string statMana = "statMana";
			public const string statManaMax = "statManaMax";
			public const string inventory = "inventory";
			public const string whoAmI = "whoAmI";
			public const string InModBiome = "InModBiome";
		}

		public static class NPCMembers
		{
			public const string type = "type";
			public const string life = "life";
			public const string lifeMax = "lifeMax";
			public const string damage = "damage";
			public const string defense = "defense";
			public const string knockBackResist = "knockBackResist";
			public const string position = "position";
			public const string width = "width";
			public const string height = "height";
			public const string AddBuff = "AddBuff";
			public const string GivenName = "GivenName";
		}

		public static class ProjectileMembers
		{
			public const string type = "type";
			public const string damage = "damage";
			public const string knockBack = "knockBack";
			public const string owner = "owner";
			public const string position = "position";
			public const string velocity = "velocity";
			public const string width = "width";
			public const string height = "height";
			public const string ai = "ai";
			public const string friendly = "friendly";
			public const string hostile = "hostile";
			public const string ApplyStatsFromSource = "ApplyStatsFromSource";
		}

		public static class GlobalItemMembers
		{
			public const string SetDefaults = "SetDefaults";
			public const string AddRecipes = "AddRecipes";
			public const string ModifyWeaponDamage = "ModifyWeaponDamage";
			public const string ModifyWeaponCrit = "ModifyWeaponCrit";
			public const string ModifyTooltips = "ModifyTooltips";
			public const string CanUseItem = "CanUseItem";
			public const string UseItem = "UseItem";
			public const string Shoot = "Shoot";
			public const string ApplyPrefix = "ApplyPrefix";
			public const string AllowPrefix = "AllowPrefix";
			public const string ModifyItemLoot = "ModifyItemLoot";
		}

		public static class GlobalNPCMembers
		{
			public const string SetDefaults = "SetDefaults";
			public const string OnKill = "OnKill";
			public const string ModifyNPCLoot = "ModifyNPCLoot";
			public const string EditSpawnPool = "EditSpawnPool";
			public const string CanHitPlayer = "CanHitPlayer";
			public const string ModifyHitByProjectile = "ModifyHitByProjectile";
			public const string OnHitByProjectile = "OnHitByProjectile";
			public const string AI = "AI";
			public const string PreDraw = "PreDraw";
			public const string PostDraw = "PostDraw";
		}

		public static class TagCompoundMembers
		{
			public const string Add = "Add";
			public const string Get = "Get";
			public const string GetInt = "GetInt";
			public const string GetFloat = "GetFloat";
			public const string GetBool = "GetBool";
			public const string GetCompound = "GetCompound";
			public const string ContainsKey = "ContainsKey";
			public const string Remove = "Remove";
		}

		public static class ModContentMembers
		{
			public const string ItemType = "ItemType";
			public const string NPCType = "NPCType";
			public const string ProjectileType = "ProjectileType";
			public const string TileType = "TileType";
			public const string WallType = "WallType";
			public const string BuffType = "BuffType";
			public const string MountType = "MountType";
			public const string Find = "Find";
		}

		public static class MainMembers
		{
			public const string LocalPlayer = "LocalPlayer";
			public const string CurrentPlayer = "CurrentPlayer";
			public const string netMode = "netMode";
			public const string rand = "rand";
			public const string item = "item";
			public const string npc = "npc";
			public const string projectile = "projectile";
			public const string ActivePlayers = "ActivePlayers";
			public const string ActiveNPCs = "ActiveNPCs";
			public const string ActiveProjectiles = "ActiveProjectiles";
		}

		public static class LanguageMembers
		{
			public const string GetText = "GetText";
			public const string ActiveCulture = "ActiveCulture";
			public const string Exists = "Exists";
		}
	}
}
