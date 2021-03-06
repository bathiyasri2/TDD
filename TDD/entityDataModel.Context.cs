﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TDD
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class SanaStore91Entities : DbContext
    {
        public SanaStore91Entities()
            : base("name=SanaStore91Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AdminRole> AdminRoles { get; set; }
        public virtual DbSet<AdminUser> AdminUsers { get; set; }
        public virtual DbSet<ASPStateTempApplication> ASPStateTempApplications { get; set; }
        public virtual DbSet<ASPStateTempSession> ASPStateTempSessions { get; set; }
        public virtual DbSet<BasketLine> BasketLines { get; set; }
        public virtual DbSet<Basket> Baskets { get; set; }
        public virtual DbSet<CharacterReplacementRule> CharacterReplacementRules { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<CountryState> CountryStates { get; set; }
        public virtual DbSet<Currency> Currencies { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<CustomerSearchIndex> CustomerSearchIndexes { get; set; }
        public virtual DbSet<CustomerSegment> CustomerSegments { get; set; }
        public virtual DbSet<CustomerStatistic> CustomerStatistics { get; set; }
        public virtual DbSet<EntityProperty> EntityProperties { get; set; }
        public virtual DbSet<ExternalShippingMethod> ExternalShippingMethods { get; set; }
        public virtual DbSet<FaqPage> FaqPages { get; set; }
        public virtual DbSet<FlexiPage> FlexiPages { get; set; }
        public virtual DbSet<HealthCheckState> HealthCheckStates { get; set; }
        public virtual DbSet<ItemTranslation> ItemTranslations { get; set; }
        public virtual DbSet<Language> Languages { get; set; }
        public virtual DbSet<MailTemplate> MailTemplates { get; set; }
        public virtual DbSet<MiniProfilerClientTiming> MiniProfilerClientTimings { get; set; }
        public virtual DbSet<MiniProfiler> MiniProfilers { get; set; }
        public virtual DbSet<MiniProfilerSqlTimingParameter> MiniProfilerSqlTimingParameters { get; set; }
        public virtual DbSet<MiniProfilerSqlTiming> MiniProfilerSqlTimings { get; set; }
        public virtual DbSet<MiniProfilerTiming> MiniProfilerTimings { get; set; }
        public virtual DbSet<MobileDevice> MobileDevices { get; set; }
        public virtual DbSet<MobileNavigationItem> MobileNavigationItems { get; set; }
        public virtual DbSet<NavigationItem> NavigationItems { get; set; }
        public virtual DbSet<NewsItem> NewsItems { get; set; }
        public virtual DbSet<NewsletterSubscription> NewsletterSubscriptions { get; set; }
        public virtual DbSet<Numbering> Numberings { get; set; }
        public virtual DbSet<OfflineDataItem> OfflineDataItems { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<PaymentMethod> PaymentMethods { get; set; }
        public virtual DbSet<PaymentTransactionInfo> PaymentTransactionInfos { get; set; }
        public virtual DbSet<ProductEnrichment> ProductEnrichments { get; set; }
        public virtual DbSet<ProductImage> ProductImages { get; set; }
        public virtual DbSet<ProductListPage> ProductListPages { get; set; }
        public virtual DbSet<ProductReview> ProductReviews { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductSearchIndex> ProductSearchIndexes { get; set; }
        public virtual DbSet<ProductSet> ProductSets { get; set; }
        public virtual DbSet<PromotionCoupon> PromotionCoupons { get; set; }
        public virtual DbSet<SanaText> SanaTexts { get; set; }
        public virtual DbSet<ServerCommand> ServerCommands { get; set; }
        public virtual DbSet<Server> Servers { get; set; }
        public virtual DbSet<Setting> Settings { get; set; }
        public virtual DbSet<SharedInfo> SharedInfoes { get; set; }
        public virtual DbSet<ShippingMethod> ShippingMethods { get; set; }
        public virtual DbSet<ShopAccount> ShopAccounts { get; set; }
        public virtual DbSet<StockRanx> StockRanges { get; set; }
        public virtual DbSet<TaskConfiguration> TaskConfigurations { get; set; }
        public virtual DbSet<TasksInfo> TasksInfoes { get; set; }
        public virtual DbSet<Theme> Themes { get; set; }
        public virtual DbSet<VersionInfo> VersionInfoes { get; set; }
        public virtual DbSet<WebsiteCountry> WebsiteCountries { get; set; }
        public virtual DbSet<WebsiteDomain> WebsiteDomains { get; set; }
        public virtual DbSet<WebsiteErpStatus> WebsiteErpStatuses { get; set; }
        public virtual DbSet<WebsiteRedirect> WebsiteRedirects { get; set; }
        public virtual DbSet<Website> Websites { get; set; }
    
        public virtual int CleanUpBaskets(Nullable<int> months, Nullable<int> days)
        {
            var monthsParameter = months.HasValue ?
                new ObjectParameter("months", months) :
                new ObjectParameter("months", typeof(int));
    
            var daysParameter = days.HasValue ?
                new ObjectParameter("days", days) :
                new ObjectParameter("days", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CleanUpBaskets", monthsParameter, daysParameter);
        }
    
        public virtual ObjectResult<GenerateNumber_Result> GenerateNumber(string id)
        {
            var idParameter = id != null ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GenerateNumber_Result>("GenerateNumber", idParameter);
        }
    
        public virtual int GetHashCode(string input, ObjectParameter hash)
        {
            var inputParameter = input != null ?
                new ObjectParameter("input", input) :
                new ObjectParameter("input", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("GetHashCode", inputParameter, hash);
        }
    
        public virtual int GetMajorVersion(ObjectParameter p_ver)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("GetMajorVersion", p_ver);
        }
    
        public virtual int TempGetAppID(string appName, ObjectParameter appId)
        {
            var appNameParameter = appName != null ?
                new ObjectParameter("appName", appName) :
                new ObjectParameter("appName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("TempGetAppID", appNameParameter, appId);
        }
    
        public virtual ObjectResult<byte[]> TempGetStateItem(string id, ObjectParameter itemShort, ObjectParameter locked, ObjectParameter lockDate, ObjectParameter lockCookie)
        {
            var idParameter = id != null ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<byte[]>("TempGetStateItem", idParameter, itemShort, locked, lockDate, lockCookie);
        }
    
        public virtual ObjectResult<byte[]> TempGetStateItem2(string id, ObjectParameter itemShort, ObjectParameter locked, ObjectParameter lockAge, ObjectParameter lockCookie)
        {
            var idParameter = id != null ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<byte[]>("TempGetStateItem2", idParameter, itemShort, locked, lockAge, lockCookie);
        }
    
        public virtual ObjectResult<byte[]> TempGetStateItem3(string id, ObjectParameter itemShort, ObjectParameter locked, ObjectParameter lockAge, ObjectParameter lockCookie, ObjectParameter actionFlags)
        {
            var idParameter = id != null ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<byte[]>("TempGetStateItem3", idParameter, itemShort, locked, lockAge, lockCookie, actionFlags);
        }
    
        public virtual ObjectResult<byte[]> TempGetStateItemExclusive(string id, ObjectParameter itemShort, ObjectParameter locked, ObjectParameter lockDate, ObjectParameter lockCookie)
        {
            var idParameter = id != null ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<byte[]>("TempGetStateItemExclusive", idParameter, itemShort, locked, lockDate, lockCookie);
        }
    
        public virtual ObjectResult<byte[]> TempGetStateItemExclusive2(string id, ObjectParameter itemShort, ObjectParameter locked, ObjectParameter lockAge, ObjectParameter lockCookie)
        {
            var idParameter = id != null ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<byte[]>("TempGetStateItemExclusive2", idParameter, itemShort, locked, lockAge, lockCookie);
        }
    
        public virtual ObjectResult<byte[]> TempGetStateItemExclusive3(string id, ObjectParameter itemShort, ObjectParameter locked, ObjectParameter lockAge, ObjectParameter lockCookie, ObjectParameter actionFlags)
        {
            var idParameter = id != null ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<byte[]>("TempGetStateItemExclusive3", idParameter, itemShort, locked, lockAge, lockCookie, actionFlags);
        }
    
        public virtual int TempGetVersion(ObjectParameter ver)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("TempGetVersion", ver);
        }
    
        public virtual int TempInsertStateItemLong(string id, byte[] itemLong, Nullable<int> timeout)
        {
            var idParameter = id != null ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(string));
    
            var itemLongParameter = itemLong != null ?
                new ObjectParameter("itemLong", itemLong) :
                new ObjectParameter("itemLong", typeof(byte[]));
    
            var timeoutParameter = timeout.HasValue ?
                new ObjectParameter("timeout", timeout) :
                new ObjectParameter("timeout", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("TempInsertStateItemLong", idParameter, itemLongParameter, timeoutParameter);
        }
    
        public virtual int TempInsertStateItemShort(string id, byte[] itemShort, Nullable<int> timeout)
        {
            var idParameter = id != null ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(string));
    
            var itemShortParameter = itemShort != null ?
                new ObjectParameter("itemShort", itemShort) :
                new ObjectParameter("itemShort", typeof(byte[]));
    
            var timeoutParameter = timeout.HasValue ?
                new ObjectParameter("timeout", timeout) :
                new ObjectParameter("timeout", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("TempInsertStateItemShort", idParameter, itemShortParameter, timeoutParameter);
        }
    
        public virtual int TempInsertUninitializedItem(string id, byte[] itemShort, Nullable<int> timeout)
        {
            var idParameter = id != null ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(string));
    
            var itemShortParameter = itemShort != null ?
                new ObjectParameter("itemShort", itemShort) :
                new ObjectParameter("itemShort", typeof(byte[]));
    
            var timeoutParameter = timeout.HasValue ?
                new ObjectParameter("timeout", timeout) :
                new ObjectParameter("timeout", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("TempInsertUninitializedItem", idParameter, itemShortParameter, timeoutParameter);
        }
    
        public virtual int TempReleaseStateItemExclusive(string id, Nullable<int> lockCookie)
        {
            var idParameter = id != null ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(string));
    
            var lockCookieParameter = lockCookie.HasValue ?
                new ObjectParameter("lockCookie", lockCookie) :
                new ObjectParameter("lockCookie", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("TempReleaseStateItemExclusive", idParameter, lockCookieParameter);
        }
    
        public virtual int TempRemoveStateItem(string id, Nullable<int> lockCookie)
        {
            var idParameter = id != null ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(string));
    
            var lockCookieParameter = lockCookie.HasValue ?
                new ObjectParameter("lockCookie", lockCookie) :
                new ObjectParameter("lockCookie", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("TempRemoveStateItem", idParameter, lockCookieParameter);
        }
    
        public virtual int TempResetTimeout(string id)
        {
            var idParameter = id != null ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("TempResetTimeout", idParameter);
        }
    
        public virtual int TempUpdateStateItemLong(string id, byte[] itemLong, Nullable<int> timeout, Nullable<int> lockCookie)
        {
            var idParameter = id != null ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(string));
    
            var itemLongParameter = itemLong != null ?
                new ObjectParameter("itemLong", itemLong) :
                new ObjectParameter("itemLong", typeof(byte[]));
    
            var timeoutParameter = timeout.HasValue ?
                new ObjectParameter("timeout", timeout) :
                new ObjectParameter("timeout", typeof(int));
    
            var lockCookieParameter = lockCookie.HasValue ?
                new ObjectParameter("lockCookie", lockCookie) :
                new ObjectParameter("lockCookie", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("TempUpdateStateItemLong", idParameter, itemLongParameter, timeoutParameter, lockCookieParameter);
        }
    
        public virtual int TempUpdateStateItemLongNullShort(string id, byte[] itemLong, Nullable<int> timeout, Nullable<int> lockCookie)
        {
            var idParameter = id != null ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(string));
    
            var itemLongParameter = itemLong != null ?
                new ObjectParameter("itemLong", itemLong) :
                new ObjectParameter("itemLong", typeof(byte[]));
    
            var timeoutParameter = timeout.HasValue ?
                new ObjectParameter("timeout", timeout) :
                new ObjectParameter("timeout", typeof(int));
    
            var lockCookieParameter = lockCookie.HasValue ?
                new ObjectParameter("lockCookie", lockCookie) :
                new ObjectParameter("lockCookie", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("TempUpdateStateItemLongNullShort", idParameter, itemLongParameter, timeoutParameter, lockCookieParameter);
        }
    
        public virtual int TempUpdateStateItemShort(string id, byte[] itemShort, Nullable<int> timeout, Nullable<int> lockCookie)
        {
            var idParameter = id != null ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(string));
    
            var itemShortParameter = itemShort != null ?
                new ObjectParameter("itemShort", itemShort) :
                new ObjectParameter("itemShort", typeof(byte[]));
    
            var timeoutParameter = timeout.HasValue ?
                new ObjectParameter("timeout", timeout) :
                new ObjectParameter("timeout", typeof(int));
    
            var lockCookieParameter = lockCookie.HasValue ?
                new ObjectParameter("lockCookie", lockCookie) :
                new ObjectParameter("lockCookie", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("TempUpdateStateItemShort", idParameter, itemShortParameter, timeoutParameter, lockCookieParameter);
        }
    
        public virtual int TempUpdateStateItemShortNullLong(string id, byte[] itemShort, Nullable<int> timeout, Nullable<int> lockCookie)
        {
            var idParameter = id != null ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(string));
    
            var itemShortParameter = itemShort != null ?
                new ObjectParameter("itemShort", itemShort) :
                new ObjectParameter("itemShort", typeof(byte[]));
    
            var timeoutParameter = timeout.HasValue ?
                new ObjectParameter("timeout", timeout) :
                new ObjectParameter("timeout", typeof(int));
    
            var lockCookieParameter = lockCookie.HasValue ?
                new ObjectParameter("lockCookie", lockCookie) :
                new ObjectParameter("lockCookie", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("TempUpdateStateItemShortNullLong", idParameter, itemShortParameter, timeoutParameter, lockCookieParameter);
        }
    }
}
