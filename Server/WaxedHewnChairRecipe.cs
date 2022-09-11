﻿// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.WaxedHewnChairRecipe
// Assembly: BeekeepingMod, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0CFADE07-BC7B-4B9C-956D-CB3332005D4A
// Assembly location: C:\Users\khisa\Downloads\beekeepingmod1.2.1\BeekeepingMod1.2.1\BeekeepingMod1.2.1.dll

using Eco.Gameplay.Components;
using Eco.Gameplay.Items;
using Eco.Gameplay.Skills;
using Eco.Shared.Localization;
using System;
using System.Collections.Generic;

namespace Eco.Mods.TechTree
{
  [RequiresSkill(typeof (CarpentrySkill), 7)]
  public class WaxedHewnChairRecipe : RecipeFamily
  {
    public WaxedHewnChairRecipe()
    {
      
      this.Recipes = (new List<Recipe>()
      {
        new Recipe("WaxedHewnChair", Localizer.DoStr("Waxed Hewn Chair"), new IngredientElement[2]
        {
          new IngredientElement(typeof (HewnChairItem), 1f, false),
          new IngredientElement(typeof (OnduWaxItem), 1f, false)
        }, new CraftingElement[1]
        {
          (CraftingElement) new CraftingElement<WaxedHewnChairItem>(1f)
        })
      });
      this.LaborInCalories = (RecipeFamily.CreateLaborInCaloriesValue(100f, typeof (CarpentrySkill)));
      this.CraftMinutes = (RecipeFamily.CreateCraftTimeValue(typeof (WaxedHewnChairRecipe), 3f, typeof (CarpentrySkill), new Type[2]
      {
        typeof (CarpentryFocusedSpeedTalent),
        typeof (CarpentryParallelSpeedTalent)
      }));
      this.Initialize(Localizer.DoStr("Waxed Hewn Chair"), typeof (WaxedHewnChairRecipe));
      CraftingComponent.AddRecipe(typeof (CarpentryTableObject), (RecipeFamily) this);
    }
  }
}
