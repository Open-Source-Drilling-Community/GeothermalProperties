namespace NORCE.Drilling.GeothermalProperties.ModelShared
{
	public class PseudoConstructors
	{
		public static MetaInfo ConstructMetaInfo()
			{
				return new MetaInfo 
				{
					ID = Guid.NewGuid(),
					HttpHostName = "https://dev.digiwells.no/",
					HttpHostBasePath = "GeothermalProperties/api/",
					HttpEndPoint = "GeothermalPropertiesCompletionOrder/",
				};
			}

		public static MetaInfo ConstructMetaInfo(Guid id)
			{
				return new MetaInfo 
				{
					ID = id,
					HttpHostName = "https://dev.digiwells.no/",
					HttpHostBasePath = "GeothermalProperties/api/",
					HttpEndPoint = "GeothermalPropertiesCompletionOrder/",
				};
			}
		public static GeothermalData ConstructGeothermalData()
		{
			return new GeothermalData
			{
				RegionType = (GeothermalPropertiesType)0,
				VerticalDepth = null, 
				Temperature = null, 
				TemperatureGradient = null, 
			};
		}
		public static GeothermalProperties ConstructGeothermalProperties()
		{	
			return new GeothermalProperties
			{
				MetaInfo = ConstructMetaInfo(),
				Name = "Default Name",
				Description = "Default Description",
				CreationDate = DateTimeOffset.UtcNow,
				LastModificationDate = DateTimeOffset.UtcNow,
				TableType = (TableType)0,
				GeothermalDataList = new List<GeothermalData>
					{
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
						}
					}					
			};
		}
		public static GeothermalPropertiesCompletionOrder ConstructGeothermalPropertiesCompletionOrder()
		{
			return new GeothermalPropertiesCompletionOrder
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
	}
}