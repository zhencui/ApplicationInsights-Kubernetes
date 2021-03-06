namespace Microsoft.ApplicationInsights.Kubernetes.Entities
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    internal class K8sObjectList<T> : K8sObject
    {
        [JsonProperty("items")]
        public IEnumerable<T> Items { get; set; }
    }
}
