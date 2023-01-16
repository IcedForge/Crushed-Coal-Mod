﻿// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// <auto-generated />

namespace Eco.Mods.TechTree
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using Eco.Gameplay.Blocks;
    using Eco.Gameplay.Components;
    using Eco.Gameplay.DynamicValues;
    using Eco.Gameplay.Items;
    using Eco.Gameplay.Objects;
    using Eco.Gameplay.Players;
    using Eco.Gameplay.Skills;
    using Eco.Gameplay.Systems;
    using Eco.Gameplay.Systems.TextLinks;
    using Eco.Core.Items;
    using Eco.Shared.Localization;
    using Eco.Shared.Serialization;
    using Eco.Shared.Utils;
    using Eco.World;
    using Eco.World.Blocks;
    using Eco.Gameplay.Pipes;
    using Eco.Core.Controller;

    /// <summary>Auto-generated class. Don't modify it! All your changes will be wiped with next update! Use Mods* partial methods instead for customization.</summary>

    /// <summary>
    /// <para>Server side recipe definition for "SteelBar".</para>
    /// <para>More information about RecipeFamily objects can be found at https://docs.play.eco/api/server/eco.gameplay/Eco.Gameplay.Items.RecipeFamily.html</para>
    /// </summary>
    /// <remarks>
    /// This is an auto-generated class. Don't modify it! All your changes will be wiped with next update! Use Mods* partial methods instead for customization. 
    /// If you wish to modify this class, please create a new partial class or follow the instructions in the "UserCode" folder to override the entire file.
    /// </remarks>
    [RequiresSkill(typeof(AdvancedSmeltingSkill), 1)]
    [Ecopedia("Blocks", "Metals", subPageName: "SteelBar Item")]
    public partial class SteelBarRecipe : RecipeFamily
    {
        public SteelBarRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "SteelBar",  //noloc
                displayName: Localizer.DoStr("Steel Bar"),

                // Defines the ingredients needed to craft this recipe. An ingredient items takes the following inputs
                // type of the item, the amount of the item, the skill required, and the talent used.
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(IronBarItem), 2, typeof(AdvancedSmeltingSkill), typeof(AdvancedSmeltingLavishResourcesTalent)),
                    new IngredientElement(typeof(QuicklimeItem), 1, true),
                    new IngredientElement("Coal", 1, typeof(AdvancedSmeltingSkill), typeof(AdvancedSmeltingLavishResourcesTalent)), //noloc
                },

                // Define our recipe output items.
                // For every output item there needs to be one CraftingElement entry with the type of the final item and the amount
                // to create.
                items: new List<CraftingElement>
                {
                    new CraftingElement<SteelBarItem>(),
                    new CraftingElement<SlagItem>(typeof(AdvancedSmeltingSkill), 2, typeof(AdvancedSmeltingLavishResourcesTalent)),
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 2; // Defines how much experience is gained when crafted.

            // Defines the amount of labor required and the required skill to add labor
            this.LaborInCalories = CreateLaborInCaloriesValue(60, typeof(AdvancedSmeltingSkill));

            // Defines our crafting time for the recipe
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(SteelBarRecipe), start: 1.5f, skillType: typeof(AdvancedSmeltingSkill), typeof(AdvancedSmeltingFocusedSpeedTalent), typeof(AdvancedSmeltingParallelSpeedTalent));

            // Perform pre/post initialization for user mods and initialize our recipe instance with the display name "Steel Bar"
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Steel Bar"), recipeType: typeof(SteelBarRecipe));
            this.ModsPostInitialize();

            // Register our RecipeFamily instance with the crafting system so it can be crafted.
            CraftingComponent.AddRecipe(tableType: typeof(BlastFurnaceObject), recipe: this);
        }

        /// <summary>Hook for mods to customize RecipeFamily before initialization. You can change recipes, xp, labor, time here.</summary>
        partial void ModsPreInitialize();

        /// <summary>Hook for mods to customize RecipeFamily after initialization, but before registration. You can change skill requirements here.</summary>
        partial void ModsPostInitialize();
    }

    [Serialized]
    [Solid, Wall, Constructed]
    [RequiresSkill(typeof(AdvancedSmeltingSkill), 1)]
    public partial class SteelBarBlock :
        Block
        , IRepresentsItem
    {
        public virtual Type RepresentedItemType { get { return typeof(SteelBarItem); } }
    }

    [Serialized]
    [LocDisplayName("Steel Bar")]
    [MaxStackSize(20)]
    [Weight(20000)]
    [Ecopedia("Blocks", "Metals", createAsSubPage: true)]
    [Currency]
    [Tag("Currency")]
    [Tag("Metal", 1)]
    public partial class SteelBarItem :

    BlockItem<SteelBarBlock>
    {
        public override LocString DisplayDescription { get { return Localizer.DoStr("Refined bar of steel."); } }

        public override bool CanStickToWalls { get { return false; } }

        private static Type[] blockTypes = new Type[] {
            typeof(SteelBarStacked1Block),
            typeof(SteelBarStacked2Block),
            typeof(SteelBarStacked3Block),
            typeof(SteelBarStacked4Block)
        };

        public override Type[] BlockTypes { get { return blockTypes; } }
    }

    [Serialized, Solid] public class SteelBarStacked1Block : PickupableBlock { }
    [Serialized, Solid] public class SteelBarStacked2Block : PickupableBlock { }
    [Serialized, Solid] public class SteelBarStacked3Block : PickupableBlock { }
    [Serialized, Solid, Wall] public class SteelBarStacked4Block : PickupableBlock { } //Only a wall if it's all 4 SteelBar
}
