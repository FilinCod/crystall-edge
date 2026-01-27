using Content.Shared._CE.Farming.Components;
using Robust.Server.GameObjects;

namespace Content.Server._CE.Farming;


public sealed class CEPlantLightSystem : EntitySystem
{
    [Dependency] private readonly PointLightSystem _light = default!;

    public override void Initialize()
    {
        base.Initialize();
        SubscribeLocalEvent<CEPlantLightComponent, CEAfterPlantUpdateEvent>(OnGrowth);
    }

    private void OnGrowth(EntityUid uid, CEPlantLightComponent comp, ref CEAfterPlantUpdateEvent args)
    {
        var lightcomp = EnsureComp<PointLightComponent>(uid);
        EnsureComp<PointLightComponent>(uid);
        _light.SetColor(uid, comp.Color, lightcomp);
        _light.SetRadius(uid, comp.Radius * args.Plant.Comp.GrowthLevel, lightcomp);
        _light.SetEnergy(uid, comp.Energy * args.Plant.Comp.GrowthLevel, lightcomp);
    }


}
