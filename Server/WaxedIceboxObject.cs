// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.WaxedIceboxObject
// Assembly: BeekeepingMod, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0CFADE07-BC7B-4B9C-956D-CB3332005D4A
// Assembly location: C:\Users\khisa\Downloads\beekeepingmod1.2.1\BeekeepingMod1.2.1\BeekeepingMod1.2.1.dll

using Eco.Gameplay.Components;
using Eco.Gameplay.Components.Auth;
using Eco.Gameplay.Housing;
using Eco.Gameplay.Items;
using Eco.Gameplay.Objects;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using System;

namespace Eco.Mods.TechTree
{
  [Serialized]
  [RequireComponent(typeof (PropertyAuthComponent), null)]
  [RequireComponent(typeof (LinkComponent), null)]
  [RequireComponent(typeof (HousingComponent), null)]
  [RequireComponent(typeof (PublicStorageComponent), null)]
  [RequireComponent(typeof (SolidGroundComponent), null)]
  public class WaxedIceboxObject : WorldObject, IRepresentsItem
  {
    public override LocString DisplayName
    {
      get
      {
        return Localizer.DoStr("Waxed Icebox");
      }
    }

    public virtual TableTextureMode TableTexture
    {
      get
      {
        return (TableTextureMode) 1;
      }
    }

    public virtual Type RepresentedItemType
    {
      get
      {
        return typeof (WaxedIceboxItem);
      }
    }

    protected override void Initialize()
    {
      this.GetComponent<HousingComponent>((string) null).HomeValue = WaxedIceboxItem.HomeValue;
      PublicStorageComponent component = this.GetComponent<PublicStorageComponent>((string) null);
      component.Initialize(8);
      component.Storage.AddInvRestriction((InventoryRestriction) new NotCarriedRestriction());
    }

    public override void Destroy()
    {
      base.Destroy();
    }
  }
}
