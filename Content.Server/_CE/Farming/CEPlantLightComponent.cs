namespace Content.Server._CE.Farming;

[RegisterComponent]
public sealed partial class CEPlantLightComponent : Component
{
    [DataField]
    public float Radius = 5f;
    [DataField]
    public float Energy = 5f;
    [DataField]
    public Color Color { get; set; } = Color.White;
}
