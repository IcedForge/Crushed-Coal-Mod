﻿// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// <auto-generated />

namespace Eco.Mods.TechTree
{
    using System;
    using System.Collections.Generic;
    using Eco.Gameplay.Components;
    using Eco.Gameplay.DynamicValues;
    using Eco.Gameplay.Items;
    using Eco.Gameplay.Players;
    using Eco.Gameplay.Skills;
    using Eco.Shared.Utils;
    using Eco.World;
    using Eco.World.Blocks;
    using Gameplay.Systems.TextLinks;
    using Eco.Shared.Localization;
    using Eco.Core.Controller;

    /// <summary>Auto-generated class. Don't modify it! All your changes will be wiped with next update! Use Mods* partial methods instead for customization.</summary>

    [RequiresSkill(typeof(MiningSkill), 6)]
    [ForceCreateView]
    public partial class CrushedCoalLv3Recipe : RecipeFamily
    {
        public CrushedCoalLv3Recipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                "CrushedCoalLv3",  //noloc
                Localizer.DoStr("Crushed Coal Lv3"),
                new List<IngredientElement>
                {
                    new IngredientElement(typeof(CoalItem), 20, true),
                },
                new List<CraftingElement>
                {
                    new CraftingElement<CrushedCoalItem>(5),
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 0.5f;
            this.LaborInCalories = CreateLaborInCaloriesValue(300, typeof(MiningSkill));
            this.CraftMinutes = CreateCraftTimeValue(typeof(CrushedCoalLv3Recipe), 0.5f, typeof(MiningSkill));
            this.ModsPreInitialize();
            this.Initialize(Localizer.DoStr("Crushed Coal Lv3"), typeof(CrushedCoalLv3Recipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(typeof(JawCrusherObject), this);
        }

        /// <summary>Hook for mods to customize RecipeFamily before initialization. You can change recipes, xp, labor, time here.</summary>
        partial void ModsPreInitialize();
        /// <summary>Hook for mods to customize RecipeFamily after initialization, but before registration. You can change skill requirements here.</summary>
        partial void ModsPostInitialize();
    }
}
