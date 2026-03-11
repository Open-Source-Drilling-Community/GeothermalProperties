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
						ConstructGeothermalData(),
					},
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
				InterpolationStep = 0.0, 
				CompletionMethod = (CompletionMethod)0,
			};
		}
	}
}