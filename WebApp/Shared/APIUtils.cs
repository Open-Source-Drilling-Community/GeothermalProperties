public static class APIUtils
{
    // API parameters
    public static readonly string HostNameGeothermalProperties = NORCE.Drilling.GeothermalProperties.WebApp.Configuration.GeothermalPropertiesHostURL!;
    public static readonly string HostBasePathGeothermalProperties = "GeothermalProperties/api/";
    public static readonly HttpClient HttpClientGeothermalProperties = APIUtils.SetHttpClient(HostNameGeothermalProperties, HostBasePathGeothermalProperties);
    public static readonly NORCE.Drilling.GeothermalProperties.ModelShared.Client ClientGeothermalProperties = new NORCE.Drilling.GeothermalProperties.ModelShared.Client(APIUtils.HttpClientGeothermalProperties.BaseAddress!.ToString(), APIUtils.HttpClientGeothermalProperties);

    public static readonly string HostNameUnitConversion = NORCE.Drilling.GeothermalProperties.WebApp.Configuration.UnitConversionHostURL!;
    public static readonly string HostBasePathUnitConversion = "UnitConversion/api/";

    // API utility methods
    public static HttpClient SetHttpClient(string host, string microServiceUri)
    {
        var handler = new HttpClientHandler();
        handler.ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => { return true; }; // temporary workaround for testing purposes: bypass certificate validation (not recommended for production environments due to security risks)
        HttpClient httpClient = new(handler)
        {
            BaseAddress = new Uri(host + microServiceUri)
        };
        httpClient.DefaultRequestHeaders.Accept.Clear();
        httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        return httpClient;
    }
}