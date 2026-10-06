namespace NORCE.Drilling.GeothermalProperties.ModelShared;

/// <summary>
/// Defaults used by the reusable editor and legacy integration tests.
/// Keep this helper limited to Geothermal Properties-owned DTOs so changes in
/// transitive dependency schemas do not break the generated client.
/// </summary>
public static class PseudoConstructors
{
    public static MetaInfo ConstructMetaInfo() => ConstructMetaInfo(Guid.NewGuid());

    public static MetaInfo ConstructMetaInfo(Guid id) => new()
    {
        ID = id,
        HttpHostName = "https://dev.digiwells.no/",
        HttpHostBasePath = "GeothermalProperties/api/",
        HttpEndPoint = "GeothermalPropertiesCompletionOrder/",
    };

    public static GeothermalData ConstructGeothermalData() => new()
    {
        RegionType = (GeothermalPropertiesType)0,
    };

    public static GeothermalProperties ConstructGeothermalProperties() => new()
    {
        MetaInfo = ConstructMetaInfo(),
        Name = "Default Name",
        Description = "Default Description",
        CreationDate = DateTimeOffset.UtcNow,
        LastModificationDate = DateTimeOffset.UtcNow,
        TableType = (TableType)0,
        GeothermalDataList =
        [
            new GeothermalData
            {
                RegionType = GeothermalPropertiesType.Air,
                Temperature = 293.15,
                TemperatureGradient = -3,
                VerticalDepth = 0,
            },
            new GeothermalData
            {
                RegionType = GeothermalPropertiesType.RockFormation,
                Temperature = 303.15,
                TemperatureGradient = 4,
                VerticalDepth = 20,
            },
        ],
    };

    public static GeothermalPropertiesCompletionOrder ConstructGeothermalPropertiesCompletionOrder() => new()
    {
        MetaInfo = ConstructMetaInfo(),
        Name = "Default Name",
        Description = "Default Description",
        CreationDate = DateTimeOffset.UtcNow,
        LastModificationDate = DateTimeOffset.UtcNow,
        ReferenceGeothermalProperties = ConstructGeothermalProperties(),
        CompletedGeothermalProperties = ConstructGeothermalProperties(),
        InterpolationStep = 10.0,
        CompletionMethod = (CompletionMethod)0,
    };
}
