using System.Text.Json.Serialization;
using System.Text.Json;
using System;
using System.Collections.Generic;
using System.Text;


namespace StoreLib.Models
{
    public partial class DisplayCatalogModel
    {
        [JsonPropertyName(nameof(Product))]
        public Product Product { get; set; }
        [JsonPropertyName(nameof(BigIds))]
        public List<string> BigIds { get; set; }
        [JsonPropertyName(nameof(HasMorePages))]
        public bool HasMorePages { get; set; }
        [JsonPropertyName(nameof(Products))]
        public List<Product> Products { get; set; }
        [JsonPropertyName(nameof(TotalResultCount))]
        public int TotalResultCount { get; set; }
    }

    public partial class Product
    {
        [JsonPropertyName(nameof(LastModifiedDate))]
        public string LastModifiedDate { get; set; }

        [JsonPropertyName(nameof(LocalizedProperties))]
        public List<ProductLocalizedProperty> LocalizedProperties { get; set; }

        [JsonPropertyName(nameof(MarketProperties))]
        public List<ProductMarketProperty> MarketProperties { get; set; }

        [JsonPropertyName(nameof(ProductASchema))]
        public string ProductASchema { get; set; }

        [JsonPropertyName(nameof(ProductBSchema))]
        public string ProductBSchema { get; set; }

        [JsonPropertyName(nameof(Properties))]
        public ProductProperties Properties { get; set; }

        [JsonPropertyName(nameof(AlternateIds))]
        public List<AlternateId> AlternateIds { get; set; }

        [JsonPropertyName(nameof(DomainDataVersion))]
        public object DomainDataVersion { get; set; }

        [JsonPropertyName(nameof(IngestionSource))]
        public string IngestionSource { get; set; }

        [JsonPropertyName(nameof(IsMicrosoftProduct))]
        public bool IsMicrosoftProduct { get; set; }

        [JsonPropertyName(nameof(PreferredSkuId))]
        public string PreferredSkuId { get; set; }

        [JsonPropertyName(nameof(ProductType))]
        public string ProductType { get; set; }

        [JsonPropertyName(nameof(ValidationData))]
        public ValidationData ValidationData { get; set; }

        [JsonPropertyName("SandboxId")]
        public string SandboxID { get; set; }

        [JsonPropertyName(nameof(IsSandboxedProduct))]
        public bool IsSandboxedProduct { get; set; }

        [JsonPropertyName(nameof(MerchandizingTags))]
        public List<object> MerchandizingTags { get; set; }

        [JsonPropertyName(nameof(PartD))]
        public string PartD { get; set; }

        [JsonPropertyName(nameof(ProductFamily))]
        public string ProductFamily { get; set; }

        [JsonPropertyName(nameof(SchemaVersion))]
        public string SchemaVersion { get; set; }

        [JsonPropertyName(nameof(ProductKind))]
        public string ProductKind { get; set; }

        [JsonPropertyName(nameof(DisplaySkuAvailabilities))]
        public List<DisplaySkuAvailability> DisplaySkuAvailabilities { get; set; }
    }

    public partial class ValidationData
    {
        [JsonPropertyName(nameof(PassedValidation))]
        public bool PassedValidation { get; set; }

        [JsonPropertyName(nameof(RevisionId))]
        public string RevisionId { get; set; }

        [JsonPropertyName(nameof(ValidationResultUri))]
        public string ValidationResultUri { get; set; }
    }

    public partial class ProductProperties
    {
        [JsonPropertyName(nameof(Attributes))]
        public List<object> Attributes { get; set; }

        [JsonPropertyName("CanInstallToSDCard")]
        public bool CanInstallToSdCard { get; set; }

        [JsonPropertyName(nameof(Category))]
        public string Category { get; set; }

        [JsonPropertyName(nameof(SubCategory))]
        public string SubCategory { get; set; }

        [JsonPropertyName(nameof(Categories))]
        public object Categories { get; set; }

        [JsonPropertyName(nameof(Extensions))]
        public object Extensions { get; set; }

        [JsonPropertyName(nameof(IsAccessible))]
        public bool IsAccessible { get; set; }

        [JsonPropertyName(nameof(IsLineOfBusinessApp))]
        public bool IsLineOfBusinessApp { get; set; }

        [JsonPropertyName(nameof(IsPublishedToLegacyWindowsPhoneStore))]
        public bool IsPublishedToLegacyWindowsPhoneStore { get; set; }

        [JsonPropertyName(nameof(IsPublishedToLegacyWindowsStore))]
        public bool IsPublishedToLegacyWindowsStore { get; set; }

        [JsonPropertyName(nameof(IsSettingsApp))]
        public bool IsSettingsApp { get; set; }

        [JsonPropertyName(nameof(PackageFamilyName))]
        public string PackageFamilyName { get; set; }

        [JsonPropertyName(nameof(PackageIdentityName))]
        public string PackageIdentityName { get; set; }

        [JsonPropertyName(nameof(PublisherCertificateName))]
        public string PublisherCertificateName { get; set; }

        [JsonPropertyName(nameof(PublisherId))]
        public string PublisherId { get; set; }

        [JsonPropertyName(nameof(XboxLiveTier))]
        public object XboxLiveTier { get; set; }

        [JsonPropertyName("XboxXPA")]
        public object XboxXpa { get; set; }

        [JsonPropertyName(nameof(OwnershipType))]
        public object OwnershipType { get; set; }

        [JsonPropertyName(nameof(PdpBackgroundColor))]
        public string PdpBackgroundColor { get; set; }

        [JsonPropertyName(nameof(HasAddOns))]
        public bool? HasAddOns { get; set; }

        [JsonPropertyName(nameof(RevisionId))]
        public string RevisionId { get; set; }

        [JsonPropertyName(nameof(ProductGroupId))]
        public string ProductGroupId { get; set; }

        [JsonPropertyName(nameof(ProductGroupName))]
        public string ProductGroupName { get; set; }
    }

    public partial class ProductMarketProperty
    {
        [JsonPropertyName(nameof(OriginalReleaseDate))]
        public DateTime OriginalReleaseDate { get; set; }

        [JsonPropertyName(nameof(OriginalReleaseDateFriendlyName))]
        public string OriginalReleaseDateFriendlyName { get; set; }

        [JsonPropertyName(nameof(MinimumUserAge))]
        public long MinimumUserAge { get; set; }

        [JsonPropertyName(nameof(ContentRatings))]
        public List<ContentRating> ContentRatings { get; set; }

        [JsonPropertyName(nameof(RelatedProducts))]
        public List<object> RelatedProducts { get; set; }

        [JsonPropertyName(nameof(UsageData))]
        public List<UsageDatum> UsageData { get; set; }

        [JsonPropertyName(nameof(BundleConfig))]
        public object BundleConfig { get; set; }

        [JsonPropertyName(nameof(Markets))]
        public List<string> Markets { get; set; }
    }

    public partial class UsageDatum
    {
        [JsonPropertyName(nameof(AverageRating))]
        public double AverageRating { get; set; }

        [JsonPropertyName(nameof(AggregateTimeSpan))]
        public string AggregateTimeSpan { get; set; }

        [JsonPropertyName(nameof(RatingCount))]
        public long RatingCount { get; set; }

        [JsonConverter(typeof(StringToLongConverter))]
        [JsonPropertyName(nameof(PurchaseCount))]
        public long PurchaseCount { get; set; }

        [JsonConverter(typeof(StringToLongConverter))]
        [JsonPropertyName(nameof(TrialCount))]
        public long? TrialCount { get; set; }

        [JsonConverter(typeof(StringToLongConverter))]
        [JsonPropertyName(nameof(RentalCount))]
        public long RentalCount { get; set; }

        [JsonPropertyName(nameof(PlayCount))]
        public long PlayCount { get; set; }
    }

    public partial class ContentRating
    {
        [JsonPropertyName(nameof(RatingSystem))]
        public string RatingSystem { get; set; }

        [JsonPropertyName(nameof(RatingId))]
        public string RatingId { get; set; }

        [JsonPropertyName(nameof(RatingDescriptors))]
        public List<string> RatingDescriptors { get; set; }

        [JsonPropertyName(nameof(RatingDisclaimers))]
        public List<object> RatingDisclaimers { get; set; }

        [JsonPropertyName(nameof(InteractiveElements))]
        public List<string> InteractiveElements { get; set; }
    }

    public partial class ProductLocalizedProperty
    {
        [JsonPropertyName(nameof(DeveloperName))]
        public string DeveloperName { get; set; }

        [JsonPropertyName(nameof(DisplayPlatformProperties))]
        public object DisplayPlatformProperties { get; set; }

        [JsonPropertyName(nameof(PublisherName))]
        public string PublisherName { get; set; }

        [JsonPropertyName(nameof(PublisherWebsiteUri))]
        public string PublisherWebsiteUri { get; set; }

        [JsonPropertyName(nameof(SupportUri))]
        public string SupportUri { get; set; }

        [JsonPropertyName(nameof(EligibilityProperties))]
        public object EligibilityProperties { get; set; }

        [JsonPropertyName(nameof(Franchises))]
        public List<object> Franchises { get; set; }

        [JsonPropertyName(nameof(Images))]
        public List<Image> Images { get; set; }

        [JsonPropertyName(nameof(Videos))]
        public List<object> Videos { get; set; }

        [JsonPropertyName(nameof(ProductDescription))]
        public string ProductDescription { get; set; }

        [JsonPropertyName(nameof(ProductTitle))]
        public string ProductTitle { get; set; }

        [JsonPropertyName(nameof(ShortTitle))]
        public string ShortTitle { get; set; }

        [JsonPropertyName(nameof(SortTitle))]
        public string SortTitle { get; set; }

        [JsonPropertyName(nameof(ShortDescription))]
        public string ShortDescription { get; set; }

        [JsonPropertyName(nameof(SearchTitles))]
        public List<SearchTitle> SearchTitles { get; set; }

        [JsonPropertyName(nameof(VoiceTitle))]
        public string VoiceTitle { get; set; }

        [JsonPropertyName(nameof(RenderGroupDetails))]
        public object RenderGroupDetails { get; set; }

        [JsonPropertyName(nameof(ProductDisplayRanks))]
        public List<object> ProductDisplayRanks { get; set; }

        [JsonPropertyName(nameof(Language))]
        public string Language { get; set; }

        [JsonPropertyName(nameof(Markets))]
        public List<string> Markets { get; set; }
    }

    public partial class SearchTitle
    {
        [JsonPropertyName(nameof(SearchTitleString))]
        public string SearchTitleString { get; set; }

        [JsonPropertyName(nameof(SearchTitleType))]
        public string SearchTitleType { get; set; }
    }

    public partial class Image
    {
        [JsonPropertyName(nameof(BackgroundColor))]
        public string BackgroundColor { get; set; }

        [JsonPropertyName(nameof(Caption))]
        public string Caption { get; set; }

        [JsonPropertyName(nameof(FileSizeInBytes))]
        public long FileSizeInBytes { get; set; }

        [JsonPropertyName(nameof(ForegroundColor))]
        public string ForegroundColor { get; set; }

        [JsonPropertyName(nameof(Height))]
        public long Height { get; set; }

        [JsonPropertyName(nameof(ImagePositionInfo))]
        public string ImagePositionInfo { get; set; }

        [JsonPropertyName(nameof(ImagePurpose))]
        public string ImagePurpose { get; set; }

        [JsonPropertyName("UnscaledImageSHA256Hash")]
        public string UnscaledImageSha256Hash { get; set; }

        [JsonPropertyName(nameof(Uri))]
        public string Uri { get; set; }

        [JsonPropertyName(nameof(Width))]
        public long Width { get; set; }
    }

    public partial class DisplaySkuAvailability
    {
        [JsonPropertyName(nameof(Sku))]
        public Sku Sku { get; set; }

        [JsonPropertyName(nameof(Availabilities))]
        public List<Availability> Availabilities { get; set; }
    }

    public partial class Sku
    {
        [JsonPropertyName(nameof(LastModifiedDate))]
        public DateTime LastModifiedDate { get; set; }

        [JsonPropertyName(nameof(LocalizedProperties))]
        public List<SkuLocalizedProperty> LocalizedProperties { get; set; }

        [JsonPropertyName(nameof(MarketProperties))]
        public List<SkuMarketProperty> MarketProperties { get; set; }

        [JsonPropertyName(nameof(Properties))]
        public SkuProperties Properties { get; set; }

        [JsonPropertyName(nameof(SkuASchema))]
        public string SkuASchema { get; set; }

        [JsonPropertyName(nameof(SkuBSchema))]
        public string SkuBSchema { get; set; }

        [JsonPropertyName(nameof(SkuId))]
        public string SkuId { get; set; }

        [JsonPropertyName(nameof(SkuType))]
        public string SkuType { get; set; }

        [JsonPropertyName(nameof(RecurrencePolicy))]
        public object RecurrencePolicy { get; set; }

        [JsonPropertyName(nameof(SubscriptionPolicyId))]
        public object SubscriptionPolicyId { get; set; }
    }

    public partial class SkuProperties
    {
        [JsonPropertyName(nameof(EarlyAdopterEnrollmentUrl))]
        public object EarlyAdopterEnrollmentUrl { get; set; }

        [JsonPropertyName(nameof(FulfillmentData))]
        public FulfillmentData FulfillmentData { get; set; }

        [JsonPropertyName(nameof(FulfillmentType))]
        public string FulfillmentType { get; set; }

        [JsonPropertyName("HasThirdPartyIAPs")]
        public bool HasThirdPartyIaPs { get; set; }

        [JsonPropertyName(nameof(LastUpdateDate))]
        public string LastUpdateDate { get; set; }

        [JsonPropertyName(nameof(HardwareProperties))]
        public HardwareProperties HardwareProperties { get; set; }

        [JsonPropertyName(nameof(HardwareRequirements))]
        public List<object> HardwareRequirements { get; set; }

        [JsonPropertyName(nameof(HardwareWarningList))]
        public List<object> HardwareWarningList { get; set; }

        [JsonPropertyName(nameof(InstallationTerms))]
        public string InstallationTerms { get; set; }

        [JsonPropertyName(nameof(Packages))]
        public List<Package> Packages { get; set; }

        [JsonPropertyName(nameof(VersionString))]
        public string VersionString { get; set; }

        [JsonPropertyName(nameof(VisibleToB2BServiceIds))]
        public List<object> VisibleToB2BServiceIds { get; set; }

        [JsonPropertyName("XboxXPA")]
        public bool XboxXpa { get; set; }

        [JsonPropertyName(nameof(BundledSkus))]
        public List<object> BundledSkus { get; set; }

        [JsonPropertyName(nameof(IsRepurchasable))]
        public bool? IsRepurchasable { get; set; }

        [JsonPropertyName(nameof(SkuDisplayRank))]
        public long SkuDisplayRank { get; set; }

        [JsonPropertyName(nameof(DisplayPhysicalStoreInventory))]
        public object DisplayPhysicalStoreInventory { get; set; }

        [JsonPropertyName(nameof(AdditionalIdentifiers))]
        public List<object> AdditionalIdentifiers { get; set; }

        [JsonPropertyName(nameof(IsTrial))]
        public bool IsTrial { get; set; }

        [JsonPropertyName(nameof(IsPreOrder))]
        public bool IsPreOrder { get; set; }

        [JsonPropertyName(nameof(IsBundle))]
        public bool IsBundle { get; set; }
    }

    public partial class Package
    {
        [JsonPropertyName(nameof(Applications))]
        public List<Application> Applications { get; set; }

        [JsonPropertyName(nameof(Architectures))]
        public List<string> Architectures { get; set; }

        [JsonPropertyName(nameof(Capabilities))]
        public List<string> Capabilities { get; set; }

        [JsonPropertyName(nameof(DeviceCapabilities))]
        public List<object> DeviceCapabilities { get; set; }

        [JsonPropertyName(nameof(ExperienceIds))]
        public List<object> ExperienceIds { get; set; }

        [JsonPropertyName(nameof(FrameworkDependencies))]
        public List<object> FrameworkDependencies { get; set; }

        [JsonPropertyName(nameof(HardwareDependencies))]
        public List<object> HardwareDependencies { get; set; }

        [JsonPropertyName(nameof(HardwareRequirements))]
        public List<object> HardwareRequirements { get; set; }

        [JsonPropertyName(nameof(Hash))]
        public string Hash { get; set; }

        [JsonPropertyName(nameof(HashAlgorithm))]
        public string HashAlgorithm { get; set; }

        [JsonPropertyName(nameof(IsStreamingApp))]
        public bool IsStreamingApp { get; set; }

        [JsonPropertyName(nameof(Languages))]
        public List<string> Languages { get; set; }

        [JsonPropertyName(nameof(MaxDownloadSizeInBytes))]
        public long MaxDownloadSizeInBytes { get; set; }

        // TODO: Revisit whether this type should be numeric.
        [JsonConverter(typeof(NumberToStringConverter))]
        [JsonPropertyName(nameof(MaxInstallSizeInBytes))]
        public string MaxInstallSizeInBytes { get; set; }

        [JsonPropertyName(nameof(PackageFormat))]
        public string PackageFormat { get; set; }

        [JsonPropertyName(nameof(PackageFamilyName))]
        public string PackageFamilyName { get; set; }

        [JsonPropertyName(nameof(MainPackageFamilyNameForDlc))]
        public object MainPackageFamilyNameForDlc { get; set; }

        [JsonPropertyName(nameof(PackageFullName))]
        public string PackageFullName { get; set; }

        [JsonPropertyName(nameof(PackageId))]
        public string PackageId { get; set; }

        [JsonPropertyName(nameof(ContentId))]
        public string ContentId { get; set; }

        [JsonPropertyName(nameof(KeyId))]
        public string KeyId { get; set; }

        [JsonPropertyName(nameof(PackageRank))]
        public long PackageRank { get; set; }

        [JsonPropertyName(nameof(PackageUri))]
        public string PackageUri { get; set; }

        [JsonPropertyName(nameof(PlatformDependencies))]
        public List<PlatformDependency> PlatformDependencies { get; set; }

        [JsonPropertyName(nameof(PlatformDependencyXmlBlob))]
        public string PlatformDependencyXmlBlob { get; set; }

        [JsonPropertyName(nameof(ResourceId))]
        public string ResourceId { get; set; }

        [JsonPropertyName(nameof(Version))]
        public string Version { get; set; }

        [JsonPropertyName(nameof(PackageDownloadUris))]
        public List<PackageDownloadUris> PackageDownloadUris { get; set; }

        [JsonPropertyName(nameof(DriverDependencies))]
        public List<object> DriverDependencies { get; set; }

        [JsonPropertyName(nameof(FulfillmentData))]
        public FulfillmentData FulfillmentData { get; set; }


    }

    public partial class PackageDownloadUris
    {
        [JsonPropertyName(nameof(Uri))]
        public string Uri { get; set; }

        [JsonPropertyName(nameof(Rank))]
        public long Rank { get; set; }
    }

    public partial class PlatformDependency
    {
        [JsonPropertyName(nameof(MaxTested))]
        public long MaxTested { get; set; }

        [JsonPropertyName(nameof(MinVersion))]
        public long MinVersion { get; set; }

        [JsonPropertyName(nameof(PlatformName))]
        public string PlatformName { get; set; }
    }

    public partial class Application
    {
        [JsonPropertyName(nameof(ApplicationId))]
        public string ApplicationId { get; set; }

        [JsonPropertyName(nameof(DeclarationOrder))]
        public long DeclarationOrder { get; set; }

        [JsonPropertyName(nameof(Extensions))]
        public List<string> Extensions { get; set; }
    }

    public partial class HardwareProperties
    {
        [JsonPropertyName(nameof(MinimumHardware))]
        public List<object> MinimumHardware { get; set; }

        [JsonPropertyName(nameof(RecommendedHardware))]
        public List<string> RecommendedHardware { get; set; }

        [JsonPropertyName(nameof(MinimumProcessor))]
        public string MinimumProcessor { get; set; }

        [JsonPropertyName(nameof(RecommendedProcessor))]
        public string RecommendedProcessor { get; set; }

        [JsonPropertyName(nameof(MinimumGraphics))]
        public string MinimumGraphics { get; set; }

        [JsonPropertyName(nameof(RecommendedGraphics))]
        public string RecommendedGraphics { get; set; }
    }

    public partial class FulfillmentData
    {
        [JsonPropertyName(nameof(WuBundleId))]
        public string WuBundleId { get; set; }

        [JsonPropertyName(nameof(WuCategoryId))]
        public string WuCategoryId { get; set; }

        [JsonPropertyName(nameof(PackageFamilyName))]
        public string PackageFamilyName { get; set; }

        [JsonPropertyName(nameof(SkuId))]
        public string SkuId { get; set; }

        [JsonPropertyName(nameof(Content))]
        public object Content { get; set; }
    }

    public partial class SkuMarketProperty
    {
        [JsonPropertyName(nameof(FirstAvailableDate))]
        public string FirstAvailableDate { get; set; }

        [JsonPropertyName(nameof(SupportedLanguages))]
        public List<string> SupportedLanguages { get; set; }

        [JsonPropertyName(nameof(PackageIds))]
        public object PackageIds { get; set; }

        [JsonPropertyName(nameof(Markets))]
        public List<string> Markets { get; set; }
    }

    public partial class SkuLocalizedProperty
    {
        [JsonPropertyName(nameof(Contributors))]
        public List<object> Contributors { get; set; }

        [JsonPropertyName(nameof(Features))]
        public List<object> Features { get; set; }

        [JsonPropertyName(nameof(MinimumNotes))]
        public string MinimumNotes { get; set; }

        [JsonPropertyName(nameof(RecommendedNotes))]
        public string RecommendedNotes { get; set; }

        [JsonPropertyName(nameof(ReleaseNotes))]
        public string ReleaseNotes { get; set; }

        [JsonPropertyName(nameof(DisplayPlatformProperties))]
        public object DisplayPlatformProperties { get; set; }

        [JsonPropertyName(nameof(SkuDescription))]
        public string SkuDescription { get; set; }

        [JsonPropertyName(nameof(SkuTitle))]
        public string SkuTitle { get; set; }

        [JsonPropertyName(nameof(SkuButtonTitle))]
        public string SkuButtonTitle { get; set; }

        [JsonPropertyName(nameof(DeliveryDateOverlay))]
        public object DeliveryDateOverlay { get; set; }

        [JsonPropertyName(nameof(SkuDisplayRank))]
        public List<object> SkuDisplayRank { get; set; }

        [JsonPropertyName(nameof(TextResources))]
        public object TextResources { get; set; }

        [JsonPropertyName(nameof(Images))]
        public List<object> Images { get; set; }

        [JsonPropertyName(nameof(LegalText))]
        public LegalText LegalText { get; set; }

        [JsonPropertyName(nameof(Language))]
        public string Language { get; set; }

        [JsonPropertyName(nameof(Markets))]
        public List<string> Markets { get; set; }
    }

    public partial class LegalText
    {
        [JsonPropertyName(nameof(AdditionalLicenseTerms))]
        public string AdditionalLicenseTerms { get; set; }

        [JsonPropertyName(nameof(Copyright))]
        public string Copyright { get; set; }

        [JsonPropertyName(nameof(CopyrightUri))]
        public string CopyrightUri { get; set; }

        [JsonPropertyName(nameof(PrivacyPolicy))]
        public string PrivacyPolicy { get; set; }

        [JsonPropertyName(nameof(PrivacyPolicyUri))]
        public string PrivacyPolicyUri { get; set; }

        [JsonPropertyName(nameof(Tou))]
        public string Tou { get; set; }

        [JsonPropertyName(nameof(TouUri))]
        public string TouUri { get; set; }
    }

    public partial class Availability
    {
        [JsonPropertyName(nameof(Actions))]
        public List<string> Actions { get; set; }

        [JsonPropertyName(nameof(AvailabilityASchema))]
        public string AvailabilityASchema { get; set; }

        [JsonPropertyName(nameof(AvailabilityBSchema))]
        public string AvailabilityBSchema { get; set; }

        [JsonPropertyName(nameof(AvailabilityId))]
        public string AvailabilityId { get; set; }

        [JsonPropertyName(nameof(Conditions))]
        public Conditions Conditions { get; set; }

        [JsonPropertyName(nameof(LastModifiedDate))]
        public DateTime LastModifiedDate { get; set; }

        [JsonPropertyName(nameof(Markets))]
        public List<string> Markets { get; set; }

        [JsonPropertyName(nameof(OrderManagementData))]
        public OrderManagementData OrderManagementData { get; set; }

        [JsonPropertyName(nameof(Properties))]
        public AvailabilityProperties Properties { get; set; }

        [JsonPropertyName(nameof(SkuId))]
        public string SkuId { get; set; }

        [JsonPropertyName(nameof(DisplayRank))]
        public long DisplayRank { get; set; }

        [JsonPropertyName(nameof(RemediationRequired))]
        public bool RemediationRequired { get; set; }
    }

    public partial class AvailabilityProperties
    {
        [JsonPropertyName(nameof(OriginalReleaseDate))]
        public DateTime? OriginalReleaseDate { get; set; }
    }

    public partial class OrderManagementData
    {
        [JsonPropertyName(nameof(GrantedEntitlementKeys))]
        public List<object> GrantedEntitlementKeys { get; set; }

        [JsonPropertyName("PIFilter")]
        public PiFilter PiFilter { get; set; }

        [JsonPropertyName(nameof(Price))]
        public Price Price { get; set; }
    }

    public partial class Price
    {
        [JsonPropertyName(nameof(CurrencyCode))]
        public string CurrencyCode { get; set; }

        [JsonPropertyName("IsPIRequired")]
        public bool IsPiRequired { get; set; }

        [JsonPropertyName(nameof(ListPrice))]
        public long ListPrice { get; set; }

        [JsonPropertyName("MSRP")]
        public long Msrp { get; set; }

        [JsonPropertyName(nameof(TaxType))]
        public string TaxType { get; set; }

        [JsonPropertyName(nameof(WholesaleCurrencyCode))]
        public string WholesaleCurrencyCode { get; set; }
    }

    public partial class PiFilter
    {
        [JsonPropertyName(nameof(ExclusionProperties))]
        public List<object> ExclusionProperties { get; set; }

        [JsonPropertyName(nameof(InclusionProperties))]
        public List<object> InclusionProperties { get; set; }
    }

    public partial class Conditions
    {
        [JsonPropertyName(nameof(ClientConditions))]
        public ClientConditions ClientConditions { get; set; }

        [JsonPropertyName(nameof(EndDate))]
        public DateTime EndDate { get; set; }

        [JsonPropertyName(nameof(ResourceSetIds))]
        public List<string> ResourceSetIds { get; set; }

        [JsonPropertyName(nameof(StartDate))]
        public DateTime StartDate { get; set; }
    }

    public partial class ClientConditions
    {
        [JsonPropertyName(nameof(AllowedPlatforms))]
        public List<AllowedPlatform> AllowedPlatforms { get; set; }
    }

    public partial class AllowedPlatform
    {
        [JsonPropertyName(nameof(MaxVersion))]
        public long MaxVersion { get; set; }

        [JsonPropertyName(nameof(MinVersion))]
        public long MinVersion { get; set; }

        [JsonPropertyName(nameof(PlatformName))]
        public string PlatformName { get; set; }
    }

    public partial class AlternateId
    {
        [JsonPropertyName(nameof(IdType))]
        public string IdType { get; set; }

        [JsonPropertyName(nameof(Value))]
        public string Value { get; set; }
    }

    public partial class DisplayCatalogModel
    {
        public static DisplayCatalogModel FromJson(string json) => JsonSerializer.Deserialize<DisplayCatalogModel>(json);
    }

    public static class Serialize
    {
        public static string ToJson(this DisplayCatalogModel self) => JsonSerializer.Serialize(self, jsonSerializerOptions);

        private static readonly JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions
        {
            WriteIndented = true
        };
    }

    internal class StringToLongConverter : JsonConverter<long>
    {
        public override long Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.String)
            {
                string stringValue = reader.GetString();
                if (long.TryParse(stringValue, out long value))
                {
                    return value;
                }
            }
            throw new JsonException("Unable to convert JSON string to long.");
        }

        public override void Write(Utf8JsonWriter writer, long value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.ToString());
        }
    }

    internal class NumberToStringConverter : JsonConverter<string>
    {
        public override string Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            switch(reader.TokenType)
            {
                case JsonTokenType.Number:
                    if (reader.TryGetInt64(out long longValue))
                    {
                        return longValue.ToString();
                    }
                    break;
                case JsonTokenType.String:
                    return reader.GetString();
            }

            // Will only be reached if the conversion failed
            throw new JsonException("Expected a number or a string.");
        }

        public override void Write(Utf8JsonWriter writer, string value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value);
        }
    }


}
