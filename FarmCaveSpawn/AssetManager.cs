﻿using StardewModdingAPI.Utilities;

namespace FarmCaveSpawn;

internal class AssetManager : IAssetLoader
{
    public readonly string denylistLocation = PathUtilities.NormalizeAssetName("Mods/atravita_FarmCaveSpawn_denylist");
    public readonly string additionalLocationsLocation = PathUtilities.NormalizeAssetName("Mods/atravita_FarmCaveSpawn_additionalLocations");

    public bool CanLoad<T>(IAssetInfo asset)
    {
        return asset.AssetNameEquals(this.denylistLocation) || asset.AssetNameEquals(this.additionalLocationsLocation);
    }

    /// <summary>
    /// Load initial blank denylist for other mods to edit later,
    /// Load initial additional areas list with SVE areas included
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="asset"></param>
    /// <returns></returns>
    /// <exception cref="InvalidOperationException"></exception>
    public T Load<T>(IAssetInfo asset)
    {
        if (asset.AssetNameEquals(this.denylistLocation))
        {
            return (T)(object)new Dictionary<string, string>
            {
            };
        }
        else if (asset.AssetNameEquals(this.additionalLocationsLocation))
        {
            return (T)(object)new Dictionary<string, string>
            {
                ["FlashShifter.SVECode"] = "Custom_MinecartCave, Custom_DeepCave"
#if DEBUG
                , ["atravita.FarmCaveSpawn"] = "Town:[(4;5);(34;40)]"
#endif
            };
        }
        throw new InvalidOperationException($"Should not have tried to load '{asset.AssetName}'.");
    }
}
