using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace StoreLib.Models
{
    public class PackageInstance
    {
        public string PackageMoniker;
        public Uri PackageUri;
        public PackageType PackageType;
        public ApplicabilityBlob ApplicabilityBlob;
        public String UpdateId;

        public PackageInstance(string PackageMoniker, Uri PackageUri, PackageType PackageType, ApplicabilityBlob ApplicabilityBlob, String UpdateId)
        {
            this.PackageMoniker = PackageMoniker;
            this.PackageUri = PackageUri;
            this.PackageType = PackageType;
            this.ApplicabilityBlob = ApplicabilityBlob;
            this.UpdateId = UpdateId;
        }
    }

    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class ContentTargetPlatform
    {
        [JsonPropertyName("platform.maxVersionTested")]
        public long PlatformMaxVersionTested { get; set; }

        [JsonPropertyName("platform.minVersion")]
        public long PlatformMinVersion { get; set; }

        [JsonPropertyName("platform.target")]
        public int PlatformTarget { get; set; }
    }

    public class Policy
    {
        [JsonPropertyName("category.first")]
        public string CategoryFirst { get; set; }

        [JsonPropertyName("category.second")]
        public string CategorySecond { get; set; }

        [JsonPropertyName("category.third")]
        public string CategoryThird { get; set; }

        [JsonPropertyName("optOut.backupRestore")]
        public bool OptOutBackupRestore { get; set; }

        [JsonPropertyName("optOut.removeableMedia")]
        public bool OptOutRemoveableMedia { get; set; }
    }

    public class ThirdPartyAppRating
    {
        [JsonPropertyName("level")]
        public int Level { get; set; }

        [JsonPropertyName("systemId")]
        public int SystemId { get; set; }
    }

    public class Policy2
    {
        [JsonPropertyName("ageRating")]
        public int AgeRating { get; set; }

        [JsonPropertyName("optOut.DVR")]
        public bool OptOutDVR { get; set; }

        [JsonPropertyName("thirdPartyAppRatings")]
        public List<ThirdPartyAppRating> ThirdPartyAppRatings { get; set; }
    }

    public class ApplicabilityBlob
    {
        [JsonPropertyName("blob.version")]
        public long BlobVersion { get; set; }

        [JsonPropertyName("content.isMain")]
        public bool ContentIsMain { get; set; }

        [JsonPropertyName("content.packageId")]
        public string ContentPackageId { get; set; }

        [JsonPropertyName("content.productId")]
        public string ContentProductId { get; set; }

        [JsonPropertyName("content.targetPlatforms")]
        public List<ContentTargetPlatform> ContentTargetPlatforms { get; set; }

        [JsonPropertyName("content.type")]
        public int ContentType { get; set; }

        [JsonPropertyName("policy")]
        public Policy Policy { get; set; }

        [JsonPropertyName("policy2")]
        public Policy2 Policy2 { get; set; }
    }
}
