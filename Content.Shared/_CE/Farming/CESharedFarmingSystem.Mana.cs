using Content.Shared._CE.Farming.Components;
using Content.Shared.Power.Components;
namespace Content.Shared._CE.Farming;

public abstract partial class CESharedFarmingSystem
{
    private void InitializeManaGrow()
    {
        SubscribeLocalEvent<CEPlantManaGrowingComponent, MapInitEvent>(OnMapInit);
    }

    private void OnMapInit(Entity<CEPlantManaGrowingComponent> ent, ref MapInitEvent args)
    {
        if (!TryComp<BatteryComponent>(ent.Owner, out var battery))
            return;
    }
}
