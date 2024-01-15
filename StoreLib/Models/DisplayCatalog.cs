using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;


namespace StoreLib.Models
{
    public partial class DisplayCatalogModel
    {
        [JsonProperty(nameof(Product))]
        public Product Product { get; set; }
        [JsonProperty(nameof(BigIds))]
        public List<string> BigIds { get; set; }
        [JsonProperty(nameof(HasMorePages))]
        public bool HasMorePages { get; set; }
        [JsonProperty(nameof(Products))]
        public List<Product> Products { get; set; }
        [JsonProperty(nameof(TotalResultCount))]
        public int TotalResultCount { get; set; }
    }

    public partial class Product
    {
        [JsonProperty(nameof(LastModifiedDate))]
        public string LastModifiedDate { get; set; }

        [JsonProperty(nameof(LocalizedProperties))]
        public List<ProductLocalizedProperty> LocalizedProperties { get; set; }

        [JsonProperty(nameof(MarketProperties))]
        public List<ProductMarketProperty> MarketProperties { get; set; }

        [JsonProperty(nameof(ProductASchema))]
        public string ProductASchema { get; set; }

        [JsonProperty(nameof(ProductBSchema))]
        public string ProductBSchema { get; set; }

        [JsonProperty(nameof(Properties))]
        public ProductProperties Properties { get; set; }

        [JsonProperty(nameof(AlternateIds))]
        public List<AlternateId> AlternateIds { get; set; }

        [JsonProperty(nameof(DomainDataVersion))]
        public object DomainDataVersion { get; set; }

        [JsonProperty(nameof(IngestionSource))]
        public string IngestionSource { get; set; }

        [JsonProperty(nameof(IsMicrosoftProduct))]
        public bool IsMicrosoftProduct { get; set; }

        [JsonProperty(nameof(PreferredSkuId))]
        public string PreferredSkuId { get; set; }

        [JsonProperty(nameof(ProductType))]
        public string ProductType { get; set; }

        [JsonProperty(nameof(ValidationData))]
        public ValidationData ValidationData { get; set; }

        [JsonProperty("SandboxId")]
        public string SandboxID { get; set; }

        [JsonProperty(nameof(IsSandboxedProduct))]
        public bool IsSandboxedProduct { get; set; }

        [JsonProperty(nameof(MerchandizingTags))]
        public List<object> MerchandizingTags { get; set; }

        [JsonProperty(nameof(PartD))]
        public string PartD { get; set; }

        [JsonProperty(nameof(ProductFamily))]
        public string ProductFamily { get; set; }

        [JsonProperty(nameof(SchemaVersion))]
        public string SchemaVersion { get; set; }

        [JsonProperty(nameof(ProductKind))]
        public string ProductKind { get; set; }

        [JsonProperty(nameof(DisplaySkuAvailabilities))]
        public List<DisplaySkuAvailability> DisplaySkuAvailabilities { get; set; }
    }

    public partial class ValidationData
    {
        [JsonProperty(nameof(PassedValidation))]
        public bool PassedValidation { get; set; }

        [JsonProperty(nameof(RevisionId))]
        public string RevisionId { get; set; }

        [JsonProperty(nameof(ValidationResultUri))]
        public string ValidationResultUri { get; set; }
    }

    public partial class ProductProperties
    {
        [JsonProperty(nameof(Attributes))]
        public List<object> Attributes { get; set; }

        [JsonProperty("CanInstallToSDCard")]
        public bool CanInstallToSdCard { get; set; }

        [JsonProperty(nameof(Category))]
        public string Category { get; set; }

        [JsonProperty(nameof(SubCategory))]
        public string SubCategory { get; set; }

        [JsonProperty(nameof(Categories))]
        public object Categories { get; set; }

        [JsonProperty(nameof(Extensions))]
        public object Extensions { get; set; }

        [JsonProperty(nameof(IsAccessible))]
        public bool IsAccessible { get; set; }

        [JsonProperty(nameof(IsLineOfBusinessApp))]
        public bool IsLineOfBusinessApp { get; set; }

        [JsonProperty(nameof(IsPublishedToLegacyWindowsPhoneStore))]
        public bool IsPublishedToLegacyWindowsPhoneStore { get; set; }

        [JsonProperty(nameof(IsPublishedToLegacyWindowsStore))]
        public bool IsPublishedToLegacyWindowsStore { get; set; }

        [JsonProperty(nameof(IsSettingsApp))]
        public bool IsSettingsApp { get; set; }

        [JsonProperty(nameof(PackageFamilyName))]
        public string PackageFamilyName { get; set; }

        [JsonProperty(nameof(PackageIdentityName))]
        public string PackageIdentityName { get; set; }

        [JsonProperty(nameof(PublisherCertificateName))]
        public string PublisherCertificateName { get; set; }

        [JsonProperty(nameof(PublisherId))]
        public string PublisherId { get; set; }

        [JsonProperty(nameof(XboxLiveTier))]
        public object XboxLiveTier { get; set; }

        [JsonProperty("XboxXPA")]
        public object XboxXpa { get; set; }

        [JsonProperty(nameof(OwnershipType))]
        public object OwnershipType { get; set; }

        [JsonProperty(nameof(PdpBackgroundColor))]
        public string PdpBackgroundColor { get; set; }

        [JsonProperty(nameof(HasAddOns))]
        public bool? HasAddOns { get; set; }

        [JsonProperty(nameof(RevisionId))]
        public string RevisionId { get; set; }

        [JsonProperty(nameof(ProductGroupId))]
        public string ProductGroupId { get; set; }

        [JsonProperty(nameof(ProductGroupName))]
        public string ProductGroupName { get; set; }
    }

    public partial class ProductMarketProperty
    {
        [JsonProperty(nameof(OriginalReleaseDate))]
        public DateTime OriginalReleaseDate { get; set; }

        [JsonProperty(nameof(OriginalReleaseDateFriendlyName))]
        public string OriginalReleaseDateFriendlyName { get; set; }

        [JsonProperty(nameof(MinimumUserAge))]
        public long MinimumUserAge { get; set; }

        [JsonProperty(nameof(ContentRatings))]
        public List<ContentRating> ContentRatings { get; set; }

        [JsonProperty(nameof(RelatedProducts))]
        public List<object> RelatedProducts { get; set; }

        [JsonProperty(nameof(UsageData))]
        public List<UsageDatum> UsageData { get; set; }

        [JsonProperty(nameof(BundleConfig))]
        public object BundleConfig { get; set; }

        [JsonProperty(nameof(Markets))]
        public List<string> Markets { get; set; }
    }

    public partial class UsageDatum
    {
        [JsonProperty(nameof(AverageRating))]
        public double AverageRating { get; set; }

        [JsonProperty(nameof(AggregateTimeSpan))]
        public string AggregateTimeSpan { get; set; }

        [JsonProperty(nameof(RatingCount))]
        public long RatingCount { get; set; }

        [JsonProperty(nameof(PurchaseCount))]
        public long PurchaseCount { get; set; }

        [JsonProperty(nameof(TrialCount))]
        public long? TrialCount { get; set; }

        [JsonProperty(nameof(RentalCount))]
        public long RentalCount { get; set; }

        [JsonProperty(nameof(PlayCount))]
        public long PlayCount { get; set; }
    }

    public partial class ContentRating
    {
        [JsonProperty(nameof(RatingSystem))]
        public string RatingSystem { get; set; }

        [JsonProperty(nameof(RatingId))]
        public string RatingId { get; set; }

        [JsonProperty(nameof(RatingDescriptors))]
        public List<string> RatingDescriptors { get; set; }

        [JsonProperty(nameof(RatingDisclaimers))]
        public List<object> RatingDisclaimers { get; set; }

        [JsonProperty(nameof(InteractiveElements))]
        public List<string> InteractiveElements { get; set; }
    }

    public partial class ProductLocalizedProperty
    {
        [JsonProperty(nameof(DeveloperName))]
        public string DeveloperName { get; set; }

        [JsonProperty(nameof(DisplayPlatformProperties))]
        public object DisplayPlatformProperties { get; set; }

        [JsonProperty(nameof(PublisherName))]
        public string PublisherName { get; set; }

        [JsonProperty(nameof(PublisherWebsiteUri))]
        public string PublisherWebsiteUri { get; set; }

        [JsonProperty(nameof(SupportUri))]
        public string SupportUri { get; set; }

        [JsonProperty(nameof(EligibilityProperties))]
        public object EligibilityProperties { get; set; }

        [JsonProperty(nameof(Franchises))]
        public List<object> Franchises { get; set; }

        [JsonProperty(nameof(Images))]
        public List<Image> Images { get; set; }

        [JsonProperty(nameof(Videos))]
        public List<object> Videos { get; set; }

        [JsonProperty(nameof(ProductDescription))]
        public string ProductDescription { get; set; }

        [JsonProperty(nameof(ProductTitle))]
        public string ProductTitle { get; set; }

        [JsonProperty(nameof(ShortTitle))]
        public string ShortTitle { get; set; }

        [JsonProperty(nameof(SortTitle))]
        public string SortTitle { get; set; }

        [JsonProperty(nameof(ShortDescription))]
        public string ShortDescription { get; set; }

        [JsonProperty(nameof(SearchTitles))]
        public List<SearchTitle> SearchTitles { get; set; }

        [JsonProperty(nameof(VoiceTitle))]
        public string VoiceTitle { get; set; }

        [JsonProperty(nameof(RenderGroupDetails))]
        public object RenderGroupDetails { get; set; }

        [JsonProperty(nameof(ProductDisplayRanks))]
        public List<object> ProductDisplayRanks { get; set; }

        [JsonProperty(nameof(Language))]
        public string Language { get; set; }

        [JsonProperty(nameof(Markets))]
        public List<string> Markets { get; set; }
    }

    public partial class SearchTitle
    {
        [JsonProperty(nameof(SearchTitleString))]
        public string SearchTitleString { get; set; }

        [JsonProperty(nameof(SearchTitleType))]
        public string SearchTitleType { get; set; }
    }

    public partial class Image
    {
        [JsonProperty(nameof(BackgroundColor))]
        public string BackgroundColor { get; set; }

        [JsonProperty(nameof(Caption))]
        public string Caption { get; set; }

        [JsonProperty(nameof(FileSizeInBytes))]
        public long FileSizeInBytes { get; set; }

        [JsonProperty(nameof(ForegroundColor))]
        public string ForegroundColor { get; set; }

        [JsonProperty(nameof(Height))]
        public long Height { get; set; }

        [JsonProperty(nameof(ImagePositionInfo))]
        public string ImagePositionInfo { get; set; }

        [JsonProperty(nameof(ImagePurpose))]
        public string ImagePurpose { get; set; }

        [JsonProperty("UnscaledImageSHA256Hash")]
        public string UnscaledImageSha256Hash { get; set; }

        [JsonProperty(nameof(Uri))]
        public string Uri { get; set; }

        [JsonProperty(nameof(Width))]
        public long Width { get; set; }
    }

    public partial class DisplaySkuAvailability
    {
        [JsonProperty(nameof(Sku))]
        public Sku Sku { get; set; }

        [JsonProperty(nameof(Availabilities))]
        public List<Availability> Availabilities { get; set; }
    }

    public partial class Sku
    {
        [JsonProperty(nameof(LastModifiedDate))]
        public DateTime LastModifiedDate { get; set; }

        [JsonProperty(nameof(LocalizedProperties))]
        public List<SkuLocalizedProperty> LocalizedProperties { get; set; }

        [JsonProperty(nameof(MarketProperties))]
        public List<SkuMarketProperty> MarketProperties { get; set; }

        [JsonProperty(nameof(Properties))]
        public SkuProperties Properties { get; set; }

        [JsonProperty(nameof(SkuASchema))]
        public string SkuASchema { get; set; }

        [JsonProperty(nameof(SkuBSchema))]
        public string SkuBSchema { get; set; }

        [JsonProperty(nameof(SkuId))]
        public string SkuId { get; set; }

        [JsonProperty(nameof(SkuType))]
        public string SkuType { get; set; }

        [JsonProperty(nameof(RecurrencePolicy))]
        public object RecurrencePolicy { get; set; }

        [JsonProperty(nameof(SubscriptionPolicyId))]
        public object SubscriptionPolicyId { get; set; }
    }

    public partial class SkuProperties
    {
        [JsonProperty(nameof(EarlyAdopterEnrollmentUrl))]
        public object EarlyAdopterEnrollmentUrl { get; set; }

        [JsonProperty(nameof(FulfillmentData))]
        public FulfillmentData FulfillmentData { get; set; }

        [JsonProperty(nameof(FulfillmentType))]
        public string FulfillmentType { get; set; }

        [JsonProperty("HasThirdPartyIAPs")]
        public bool HasThirdPartyIaPs { get; set; }

        [JsonProperty(nameof(LastUpdateDate))]
        public string LastUpdateDate { get; set; }

        [JsonProperty(nameof(HardwareProperties))]
        public HardwareProperties HardwareProperties { get; set; }

        [JsonProperty(nameof(HardwareRequirements))]
        public List<object> HardwareRequirements { get; set; }

        [JsonProperty(nameof(HardwareWarningList))]
        public List<object> HardwareWarningList { get; set; }

        [JsonProperty(nameof(InstallationTerms))]
        public string InstallationTerms { get; set; }

        [JsonProperty(nameof(Packages))]
        public List<Package> Packages { get; set; }

        [JsonProperty(nameof(VersionString))]
        public string VersionString { get; set; }

        [JsonProperty(nameof(VisibleToB2BServiceIds))]
        public List<object> VisibleToB2BServiceIds { get; set; }

        [JsonProperty("XboxXPA")]
        public bool XboxXpa { get; set; }

        [JsonProperty(nameof(BundledSkus))]
        public List<object> BundledSkus { get; set; }

        [JsonProperty(nameof(IsRepurchasable))]
        public bool? IsRepurchasable { get; set; }

        [JsonProperty(nameof(SkuDisplayRank))]
        public long SkuDisplayRank { get; set; }

        [JsonProperty(nameof(DisplayPhysicalStoreInventory))]
        public object DisplayPhysicalStoreInventory { get; set; }

        [JsonProperty(nameof(AdditionalIdentifiers))]
        public List<object> AdditionalIdentifiers { get; set; }

        [JsonProperty(nameof(IsTrial))]
        public bool IsTrial { get; set; }

        [JsonProperty(nameof(IsPreOrder))]
        public bool IsPreOrder { get; set; }

        [JsonProperty(nameof(IsBundle))]
        public bool IsBundle { get; set; }
    }

    public partial class Package
    {
        [JsonProperty(nameof(Applications))]
        public List<Application> Applications { get; set; }

        [JsonProperty(nameof(Architectures))]
        public List<string> Architectures { get; set; }

        [JsonProperty(nameof(Capabilities))]
        public List<string> Capabilities { get; set; }

        [JsonProperty(nameof(DeviceCapabilities))]
        public List<object> DeviceCapabilities { get; set; }

        [JsonProperty(nameof(ExperienceIds))]
        public List<object> ExperienceIds { get; set; }

        [JsonProperty(nameof(FrameworkDependencies))]
        public List<object> FrameworkDependencies { get; set; }

        [JsonProperty(nameof(HardwareDependencies))]
        public List<object> HardwareDependencies { get; set; }

        [JsonProperty(nameof(HardwareRequirements))]
        public List<object> HardwareRequirements { get; set; }

        [JsonProperty(nameof(Hash))]
        public string Hash { get; set; }

        [JsonProperty(nameof(HashAlgorithm))]
        public string HashAlgorithm { get; set; }

        [JsonProperty(nameof(IsStreamingApp))]
        public bool IsStreamingApp { get; set; }

        [JsonProperty(nameof(Languages))]
        public List<string> Languages { get; set; }

        [JsonProperty(nameof(MaxDownloadSizeInBytes))]
        public long MaxDownloadSizeInBytes { get; set; }

        [JsonProperty(nameof(MaxInstallSizeInBytes))]
        public string MaxInstallSizeInBytes { get; set; }

        [JsonProperty(nameof(PackageFormat))]
        public string PackageFormat { get; set; }

        [JsonProperty(nameof(PackageFamilyName))]
        public string PackageFamilyName { get; set; }

        [JsonProperty(nameof(MainPackageFamilyNameForDlc))]
        public object MainPackageFamilyNameForDlc { get; set; }

        [JsonProperty(nameof(PackageFullName))]
        public string PackageFullName { get; set; }

        [JsonProperty(nameof(PackageId))]
        public string PackageId { get; set; }

        [JsonProperty(nameof(ContentId))]
        public string ContentId { get; set; }

        [JsonProperty(nameof(KeyId))]
        public string KeyId { get; set; }

        [JsonProperty(nameof(PackageRank))]
        public long PackageRank { get; set; }

        [JsonProperty(nameof(PackageUri))]
        public string PackageUri { get; set; }

        [JsonProperty(nameof(PlatformDependencies))]
        public List<PlatformDependency> PlatformDependencies { get; set; }

        [JsonProperty(nameof(PlatformDependencyXmlBlob))]
        public string PlatformDependencyXmlBlob { get; set; }

        [JsonProperty(nameof(ResourceId))]
        public string ResourceId { get; set; }

        [JsonProperty(nameof(Version))]
        public string Version { get; set; }

        [JsonProperty(nameof(PackageDownloadUris))]
        public List<PackageDownloadUris> PackageDownloadUris { get; set; }

        [JsonProperty(nameof(DriverDependencies))]
        public List<object> DriverDependencies { get; set; }

        [JsonProperty(nameof(FulfillmentData))]
        public FulfillmentData FulfillmentData { get; set; }


    }

    public partial class PackageDownloadUris
    {
        [JsonProperty(nameof(Uri))]
        public string Uri { get; set; }

        [JsonProperty(nameof(Rank))]
        public long Rank { get; set; }
    }

    public partial class PlatformDependency
    {
        [JsonProperty(nameof(MaxTested))]
        public long MaxTested { get; set; }

        [JsonProperty(nameof(MinVersion))]
        public long MinVersion { get; set; }

        [JsonProperty(nameof(PlatformName))]
        public string PlatformName { get; set; }
    }

    public partial class Application
    {
        [JsonProperty(nameof(ApplicationId))]
        public string ApplicationId { get; set; }

        [JsonProperty(nameof(DeclarationOrder))]
        public long DeclarationOrder { get; set; }

        [JsonProperty(nameof(Extensions))]
        public List<string> Extensions { get; set; }
    }

    public partial class HardwareProperties
    {
        [JsonProperty(nameof(MinimumHardware))]
        public List<object> MinimumHardware { get; set; }

        [JsonProperty(nameof(RecommendedHardware))]
        public List<string> RecommendedHardware { get; set; }

        [JsonProperty(nameof(MinimumProcessor))]
        public string MinimumProcessor { get; set; }

        [JsonProperty(nameof(RecommendedProcessor))]
        public string RecommendedProcessor { get; set; }

        [JsonProperty(nameof(MinimumGraphics))]
        public string MinimumGraphics { get; set; }

        [JsonProperty(nameof(RecommendedGraphics))]
        public string RecommendedGraphics { get; set; }
    }

    public partial class FulfillmentData
    {
        [JsonProperty(nameof(WuBundleId))]
        public string WuBundleId { get; set; }

        [JsonProperty(nameof(WuCategoryId))]
        public string WuCategoryId { get; set; }

        [JsonProperty(nameof(PackageFamilyName))]
        public string PackageFamilyName { get; set; }

        [JsonProperty(nameof(SkuId))]
        public string SkuId { get; set; }

        [JsonProperty(nameof(Content))]
        public object Content { get; set; }
    }

    public partial class SkuMarketProperty
    {
        [JsonProperty(nameof(FirstAvailableDate))]
        public string FirstAvailableDate { get; set; }

        [JsonProperty(nameof(SupportedLanguages))]
        public List<string> SupportedLanguages { get; set; }

        [JsonProperty(nameof(PackageIds))]
        public object PackageIds { get; set; }

        [JsonProperty(nameof(Markets))]
        public List<string> Markets { get; set; }
    }

    public partial class SkuLocalizedProperty
    {
        [JsonProperty(nameof(Contributors))]
        public List<object> Contributors { get; set; }

        [JsonProperty(nameof(Features))]
        public List<object> Features { get; set; }

        [JsonProperty(nameof(MinimumNotes))]
        public string MinimumNotes { get; set; }

        [JsonProperty(nameof(RecommendedNotes))]
        public string RecommendedNotes { get; set; }

        [JsonProperty(nameof(ReleaseNotes))]
        public string ReleaseNotes { get; set; }

        [JsonProperty(nameof(DisplayPlatformProperties))]
        public object DisplayPlatformProperties { get; set; }

        [JsonProperty(nameof(SkuDescription))]
        public string SkuDescription { get; set; }

        [JsonProperty(nameof(SkuTitle))]
        public string SkuTitle { get; set; }

        [JsonProperty(nameof(SkuButtonTitle))]
        public string SkuButtonTitle { get; set; }

        [JsonProperty(nameof(DeliveryDateOverlay))]
        public object DeliveryDateOverlay { get; set; }

        [JsonProperty(nameof(SkuDisplayRank))]
        public List<object> SkuDisplayRank { get; set; }

        [JsonProperty(nameof(TextResources))]
        public object TextResources { get; set; }

        [JsonProperty(nameof(Images))]
        public List<object> Images { get; set; }

        [JsonProperty(nameof(LegalText))]
        public LegalText LegalText { get; set; }

        [JsonProperty(nameof(Language))]
        public string Language { get; set; }

        [JsonProperty(nameof(Markets))]
        public List<string> Markets { get; set; }
    }

    public partial class LegalText
    {
        [JsonProperty(nameof(AdditionalLicenseTerms))]
        public string AdditionalLicenseTerms { get; set; }

        [JsonProperty(nameof(Copyright))]
        public string Copyright { get; set; }

        [JsonProperty(nameof(CopyrightUri))]
        public string CopyrightUri { get; set; }

        [JsonProperty(nameof(PrivacyPolicy))]
        public string PrivacyPolicy { get; set; }

        [JsonProperty(nameof(PrivacyPolicyUri))]
        public string PrivacyPolicyUri { get; set; }

        [JsonProperty(nameof(Tou))]
        public string Tou { get; set; }

        [JsonProperty(nameof(TouUri))]
        public string TouUri { get; set; }
    }

    public partial class Availability
    {
        [JsonProperty(nameof(Actions))]
        public List<string> Actions { get; set; }

        [JsonProperty(nameof(AvailabilityASchema))]
        public string AvailabilityASchema { get; set; }

        [JsonProperty(nameof(AvailabilityBSchema))]
        public string AvailabilityBSchema { get; set; }

        [JsonProperty(nameof(AvailabilityId))]
        public string AvailabilityId { get; set; }

        [JsonProperty(nameof(Conditions))]
        public Conditions Conditions { get; set; }

        [JsonProperty(nameof(LastModifiedDate))]
        public DateTime LastModifiedDate { get; set; }

        [JsonProperty(nameof(Markets))]
        public List<string> Markets { get; set; }

        [JsonProperty(nameof(OrderManagementData))]
        public OrderManagementData OrderManagementData { get; set; }

        [JsonProperty(nameof(Properties))]
        public AvailabilityProperties Properties { get; set; }

        [JsonProperty(nameof(SkuId))]
        public string SkuId { get; set; }

        [JsonProperty(nameof(DisplayRank))]
        public long DisplayRank { get; set; }

        [JsonProperty(nameof(RemediationRequired))]
        public bool RemediationRequired { get; set; }
    }

    public partial class AvailabilityProperties
    {
        [JsonProperty(nameof(OriginalReleaseDate))]
        public DateTime? OriginalReleaseDate { get; set; }
    }

    public partial class OrderManagementData
    {
        [JsonProperty(nameof(GrantedEntitlementKeys))]
        public List<object> GrantedEntitlementKeys { get; set; }

        [JsonProperty("PIFilter")]
        public PiFilter PiFilter { get; set; }

        [JsonProperty(nameof(Price))]
        public Price Price { get; set; }
    }

    public partial class Price
    {
        [JsonProperty(nameof(CurrencyCode))]
        public string CurrencyCode { get; set; }

        [JsonProperty("IsPIRequired")]
        public bool IsPiRequired { get; set; }

        [JsonProperty(nameof(ListPrice))]
        public long ListPrice { get; set; }

        [JsonProperty("MSRP")]
        public long Msrp { get; set; }

        [JsonProperty(nameof(TaxType))]
        public string TaxType { get; set; }

        [JsonProperty(nameof(WholesaleCurrencyCode))]
        public string WholesaleCurrencyCode { get; set; }
    }

    public partial class PiFilter
    {
        [JsonProperty(nameof(ExclusionProperties))]
        public List<object> ExclusionProperties { get; set; }

        [JsonProperty(nameof(InclusionProperties))]
        public List<object> InclusionProperties { get; set; }
    }

    public partial class Conditions
    {
        [JsonProperty(nameof(ClientConditions))]
        public ClientConditions ClientConditions { get; set; }

        [JsonProperty(nameof(EndDate))]
        public DateTime EndDate { get; set; }

        [JsonProperty(nameof(ResourceSetIds))]
        public List<string> ResourceSetIds { get; set; }

        [JsonProperty(nameof(StartDate))]
        public DateTime StartDate { get; set; }
    }

    public partial class ClientConditions
    {
        [JsonProperty(nameof(AllowedPlatforms))]
        public List<AllowedPlatform> AllowedPlatforms { get; set; }
    }

    public partial class AllowedPlatform
    {
        [JsonProperty(nameof(MaxVersion))]
        public long MaxVersion { get; set; }

        [JsonProperty(nameof(MinVersion))]
        public long MinVersion { get; set; }

        [JsonProperty(nameof(PlatformName))]
        public string PlatformName { get; set; }
    }

    public partial class AlternateId
    {
        [JsonProperty(nameof(IdType))]
        public string IdType { get; set; }

        [JsonProperty(nameof(Value))]
        public string Value { get; set; }
    }

    public partial class DisplayCatalogModel
    {
        public static DisplayCatalogModel FromJson(string json) => JsonConvert.DeserializeObject<DisplayCatalogModel>(json, Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this DisplayCatalogModel self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }

    public class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
        };
    }
}
