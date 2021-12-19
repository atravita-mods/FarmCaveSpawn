Farm Cave Spawns More Tree Fruit
=======

Modded farm caves don't really play well with how the fruit cave spawns its fruits. In vanilla, each tile has an equal chance to be picked for a spawn, and for modded caves that have large amounts of void in order to implement separate "rooms", it's quite likely that the tile picked is a void tile and nothing will be spawned. This is an attempt to help adjust for that by spawning in more fruit - either the four common vanilla forage fruit, or any item that is produced by a fruit tree. Inspired by but very different from Better FarmCave Forage, which uses FTM to spawn in a selection of various fruits.

Any fruit tree's products can be spawned. Mod trees, as long as they're registered with Data/fruitTrees, will be used as well. (Tested with RSV and PPJA More Trees). Fruit not associated with a tree will not be produced.

#### Configuration:

1. `MaxDailySpawns`: the maximum number of fruit that will spawn.
2. `SpawnChance`: the percent chance any empty square will spawn a fruit, capped by MaxDailySpawns. (Range: 0-100, where 100 means every unoccupied square will have a fruit)
3. `TreeFruitChance`: the percent chance any particular spawn will be fruit tree fruit and not common forage. (Range: 0-100, where 100 means every spawn will be a tree fruit)
4. `IgnoreFarmCaveType`: if true, will spawn fruit in any farm cave (as long as you've seen the cutscene). If false, requires that the fruit cave be selected.
5. `EarlyFarmCave`: if true, will spawn even before the cutscene is seen.
6. `UseMineCave`: if true, will spawn fruit in the mine cave entrances as well (if MaxDailySpawns is not hit.)
7. `SeasonalOnly`: limits to just the fruits that are in-season. After all, those bats have to be getting the fruit from somewhere, right?
8. `AllowAnyTreeProduct`: if true, allows any product found for any fruit tree to be spawned. If false, will only spawn items that are categorized as fruit in the game.
9. `EdiblesOnly`: If true, will only spawn items with a positive value for edibility. Do note that this field is not always perfect; some items that do not seem like they should be edible have positive values for edibility.
10 `NoBananasBeforeShrine`: there's an objective in vanilla that requires getting a hold of a banana, which is typically quite hard to do. To avoid trivializing that objective, this setting will prevent bananas from spawning until that objective is complete.
11. `PriceCap`: Caps the value of the fruit that can be spawned. (upcoming in 1.0.4)

The console command `list_fruits` will tell you which tree fruits are available for spawning.

**Installation**: unzip into your mods folder. **Uninstallation**: simply delete from mods folder.

**Multiplayer**: host should install mod. Mod does not do anything for farmhands.

**SVE**: will also spawn in the MinecartCave and the DeepCave. It goes room by room, so if you don't see spawns in MinecartCave and Deepcave try setting the spawn chance lower and the max daily spawns higher.
