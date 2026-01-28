namespace Content.Server._CE.Farming;

[RegisterComponent]
public sealed partial class CEPlantLightComponent : Component
{
    [DataField]
    public float Maxradius = 5f;
    [DataField]
    public float Maxenergy = 5f;
    [DataField]
    public Color Color { get; set; } = Color.White;
}
