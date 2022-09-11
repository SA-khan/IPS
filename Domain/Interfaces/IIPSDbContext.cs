using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

using IPS.Domain.Models;

namespace IPS.Domain.Interfaces;

public interface IIPSDbContext  {
    public DbSet<OrderNotification> OrderNotifications { get; set; }
    public  DbSet<PmsAdjustedSchedule> PmsAdjustedSchedules { get; set; }
    public  DbSet<PmsAmortProcessLog> PmsAmortProcessLogs { get; set; }
    public  DbSet<PmsAmortSchedule> PmsAmortSchedules { get; set; }
    public  DbSet<PmsAmortScheduleArchieve> PmsAmortScheduleArchieves { get; set; }
    public  DbSet<PmsAmortScheduleQuarterly> PmsAmortScheduleQuarterlies { get; set; }
    public  DbSet<PmsApproveTradingBroker> PmsApproveTradingBrokers { get; set; }
        public  DbSet<PmsApproveTradingLimit> PmsApproveTradingLimits { get; set; }
        public  DbSet<PmsApprovedBroker> PmsApprovedBrokers { get; set; }
        public  DbSet<PmsApprovedScrip> PmsApprovedScrips { get; set; }
        public  DbSet<PmsAssetAllocation> PmsAssetAllocations { get; set; }
        public  DbSet<PmsAssetModuleRelation> PmsAssetModuleRelations { get; set; }
        public  DbSet<PmsAssetType> PmsAssetTypes { get; set; }
        public  DbSet<PmsBankMrpDetail> PmsBankMrpDetails { get; set; }
        public  DbSet<PmsBankMrpRatesDetail> PmsBankMrpRatesDetails { get; set; }
        public  DbSet<PmsBankMrpTemplate> PmsBankMrpTemplates { get; set; }
        public  DbSet<PmsBopProductMaster> PmsBopProductMasters { get; set; }
        public  DbSet<PmsBorrowProduct> PmsBorrowProducts { get; set; }
        public  DbSet<PmsBorrowProductSetup> PmsBorrowProductSetups { get; set; }
        public  DbSet<PmsBrkTfcmrkPrice> PmsBrkTfcmrkPrices { get; set; }
        public  DbSet<PmsBroker> PmsBrokers { get; set; }
        public  DbSet<PmsBrokerageRate> PmsBrokerageRates { get; set; }
        public  DbSet<PmsCalPeriod> PmsCalPeriods { get; set; }
        public  DbSet<PmsCalYear> PmsCalYears { get; set; }
        public  DbSet<PmsCalendar> PmsCalendars { get; set; }
        public  DbSet<PmsCallAndPutOption> PmsCallAndPutOptions { get; set; }
        public  DbSet<PmsCapCreditRisk> PmsCapCreditRisks { get; set; }
        public  DbSet<PmsCapMarketRisk> PmsCapMarketRisks { get; set; }
        public  DbSet<PmsCashFlow> PmsCashFlows { get; set; }
        public  DbSet<PmsCashType> PmsCashTypes { get; set; }
        public  DbSet<PmsCashflowdetail> PmsCashflowdetails { get; set; }
        public  DbSet<PmsCategory> PmsCategories { get; set; }
        public  DbSet<PmsCategoryLimit> PmsCategoryLimits { get; set; }
        public  DbSet<PmsCategoryLimitConfig> PmsCategoryLimitConfigs { get; set; }
        public  DbSet<PmsCdrHead> PmsCdrHeads { get; set; }
        public  DbSet<PmsCdsholding> PmsCdsholdings { get; set; }
        public  DbSet<PmsCertificate> PmsCertificates { get; set; }
        public  DbSet<PmsCfstradeLog> PmsCfstradeLogs { get; set; }
        public  DbSet<PmsCgtconfig> PmsCgtconfigs { get; set; }
        public  DbSet<PmsCity> PmsCities { get; set; }
        public  DbSet<PmsClearingCompany> PmsClearingCompanies { get; set; }
        public  DbSet<PmsClrCompanyRate> PmsClrCompanyRates { get; set; }
        public  DbSet<PmsCoi> PmsCois { get; set; }
        public  DbSet<PmsCompFinanceDatum> PmsCompFinanceData { get; set; }
        public  DbSet<PmsCompFundControl> PmsCompFundControls { get; set; }
        public  DbSet<PmsCountry> PmsCountries { get; set; }
        public  DbSet<PmsCoupon> PmsCoupons { get; set; }
        public  DbSet<PmsCouponDetail> PmsCouponDetails { get; set; }
        public  DbSet<PmsCouponRealisedDetail> PmsCouponRealisedDetails { get; set; }
        public  DbSet<PmsCouponTaxApplied> PmsCouponTaxApplieds { get; set; }
        public  DbSet<PmsCouponToleranceRate> PmsCouponToleranceRates { get; set; }
        public  DbSet<PmsCrFinstFinStatTemp> PmsCrFinstFinStatTemps { get; set; }
        public  DbSet<PmsCrFinstFinStatTmpDtl> PmsCrFinstFinStatTmpDtls { get; set; }
        public  DbSet<PmsCreditRating> PmsCreditRatings { get; set; }
        public  DbSet<PmsCreditRatingCompany> PmsCreditRatingCompanies { get; set; }
        public  DbSet<PmsCreditRatingEntity> PmsCreditRatingEntities { get; set; }
        public  DbSet<PmsCrrslr> PmsCrrslrs { get; set; }
        public  DbSet<PmsCurrency> PmsCurrencies { get; set; }
        public  DbSet<PmsCustodian> PmsCustodians { get; set; }
        public  DbSet<PmsCustomersAccount> PmsCustomersAccounts { get; set; }
        public  DbSet<PmsDailyCurrency> PmsDailyCurrencies { get; set; }
        public  DbSet<PmsDailyFmrdatum> PmsDailyFmrdata { get; set; }
        public  DbSet<PmsDailyFundPosition> PmsDailyFundPositions { get; set; }
        public  DbSet<PmsDailyIndex> PmsDailyIndices { get; set; }
        public  DbSet<PmsDailyNav> PmsDailyNavs { get; set; }
        public  DbSet<PmsDailyRate> PmsDailyRates { get; set; }
        public  DbSet<PmsDailySevar> PmsDailySevars { get; set; }
        public  DbSet<PmsDailyTranLog> PmsDailyTranLogs { get; set; }
        public  DbSet<PmsDailyVarBetum> PmsDailyVarBeta { get; set; }
        public  DbSet<PmsDealRate> PmsDealRates { get; set; }
        public  DbSet<PmsDealTrack> PmsDealTracks { get; set; }
        public  DbSet<PmsDealerLimit> PmsDealerLimits { get; set; }
        public  DbSet<PmsDtschema> PmsDtschemas { get; set; }
        public  DbSet<PmsEmailconfig> PmsEmailconfigs { get; set; }
        public  DbSet<PmsEmpInvestment> PmsEmpInvestments { get; set; }
        public  DbSet<PmsEmployee> PmsEmployees { get; set; }
        public  DbSet<PmsEodLog> PmsEodLogs { get; set; }
        public  DbSet<PmsEquityKatLog> PmsEquityKatLogs { get; set; }
        public  DbSet<PmsEquityTradeLog> PmsEquityTradeLogs { get; set; }
        public  DbSet<PmsExecptTranLog> PmsExecptTranLogs { get; set; }
        public  DbSet<PmsExpLimit> PmsExpLimits { get; set; }
        public  DbSet<PmsFInstBranch> PmsFInstBranches { get; set; }
        public  DbSet<PmsFInstStakeHolder> PmsFInstStakeHolders { get; set; }
        public  DbSet<PmsFInstTran> PmsFInstTrans { get; set; }
        public  DbSet<PmsFInstType> PmsFInstTypes { get; set; }
        public  DbSet<PmsFInstituion> PmsFInstituions { get; set; }
        public  DbSet<PmsFee> PmsFees { get; set; }
        public  DbSet<PmsFmglintegration> PmsFmglintegrations { get; set; }
        public  DbSet<PmsFminvOtherBond> PmsFminvOtherBonds { get; set; }
        public  DbSet<PmsFoOrder> PmsFoOrders { get; set; }
        public  DbSet<PmsFund> PmsFunds { get; set; }
        public  DbSet<PmsFundLimit> PmsFundLimits { get; set; }
        public  DbSet<PmsFundMaster> PmsFundMasters { get; set; }
        public  DbSet<PmsFundMasterNote> PmsFundMasterNotes { get; set; }
        public  DbSet<PmsFundMasterUser> PmsFundMasterUsers { get; set; }
        public  DbSet<PmsFundTransfer> PmsFundTransfers { get; set; }
        public  DbSet<PmsFundcapital> PmsFundcapitals { get; set; }
        public  DbSet<PmsFundsNav> PmsFundsNavs { get; set; }
        public  DbSet<PmsFutureTradeLog> PmsFutureTradeLogs { get; set; }
        public  DbSet<PmsGlAccountDetail> PmsGlAccountDetails { get; set; }
        public  DbSet<PmsGlAccountHead> PmsGlAccountHeads { get; set; }
        public  DbSet<PmsGlInterfaceHbl> PmsGlInterfaceHbls { get; set; }
        public  DbSet<PmsGlParam> PmsGlParams { get; set; }
        public  DbSet<PmsGlReversalVchrdetail> PmsGlReversalVchrdetails { get; set; }
        public  DbSet<PmsGlReversalVchrmaster> PmsGlReversalVchrmasters { get; set; }
        public  DbSet<PmsGlVchrdetail> PmsGlVchrdetails { get; set; }
        public  DbSet<PmsGlVchrmaster> PmsGlVchrmasters { get; set; }
        public  DbSet<PmsGlmode> PmsGlmodes { get; set; }
        public  DbSet<PmsGroupOfCompany> PmsGroupOfCompanies { get; set; }
        public  DbSet<PmsGrpExpLimit> PmsGrpExpLimits { get; set; }
        public  DbSet<PmsIndicator> PmsIndicators { get; set; }
        public  DbSet<PmsInvBond> PmsInvBonds { get; set; }
        public  DbSet<PmsInvCommOrdApp> PmsInvCommOrdApps { get; set; }
        public  DbSet<PmsIssuance> PmsIssuances { get; set; }
        public  DbSet<PmsLegalConstraintsSetup> PmsLegalConstraintsSetups { get; set; }
        public  DbSet<PmsLimitBreach> PmsLimitBreaches { get; set; }
        public  DbSet<PmsLimitFundConfig> PmsLimitFundConfigs { get; set; }
        public  DbSet<PmsLoanDatum> PmsLoanData { get; set; }
        public  DbSet<PmsMarket> PmsMarkets { get; set; }
        public  DbSet<PmsMarketTiming> PmsMarketTimings { get; set; }
        public  DbSet<PmsMarketToleranceRate> PmsMarketToleranceRates { get; set; }
        public  DbSet<PmsMmiannouncement> PmsMmiannouncements { get; set; }
        public  DbSet<PmsMngFeeBenchMark> PmsMngFeeBenchMarks { get; set; }
        public  DbSet<PmsMngFeeCustBenchMark> PmsMngFeeCustBenchMarks { get; set; }
        public  DbSet<PmsModule> PmsModules { get; set; }
        public  DbSet<PmsMovingAvg> PmsMovingAvgs { get; set; }
        public  DbSet<PmsNature> PmsNatures { get; set; }
        public  DbSet<PmsNavdetail> PmsNavdetails { get; set; }
        public  DbSet<PmsOrder> PmsOrders { get; set; }
        public  DbSet<PmsOrderExec> PmsOrderExecs { get; set; }
        public  DbSet<PmsOutstandingposition> PmsOutstandingpositions { get; set; }
        public  DbSet<PmsParam> PmsParams { get; set; }
        public  DbSet<PmsParamConfig> PmsParamConfigs { get; set; }
        public  DbSet<PmsPkrv> PmsPkrvs { get; set; }
        public  DbSet<PmsPkrvtemplate> PmsPkrvtemplates { get; set; }
        public  DbSet<PmsPolicyAndRegulation> PmsPolicyAndRegulations { get; set; }
        public  DbSet<PmsPorfoliGrpWiseLmt> PmsPorfoliGrpWiseLmts { get; set; }
        public  DbSet<PmsPortfolioLimit> PmsPortfolioLimits { get; set; }
        public  DbSet<PmsPortfoliolog> PmsPortfoliologs { get; set; }
        public  DbSet<PmsProcessCashflow> PmsProcessCashflows { get; set; }
        public  DbSet<PmsProcessImpairmentTesting> PmsProcessImpairmentTestings { get; set; }
        public  DbSet<PmsProcessPortfolio> PmsProcessPortfolios { get; set; }
        public  DbSet<PmsProposhare> PmsProposhares { get; set; }
        public  DbSet<PmsPurSalRef> PmsPurSalRefs { get; set; }
        public  DbSet<PmsRateTempl> PmsRateTempls { get; set; }
        public  DbSet<PmsRating> PmsRatings { get; set; }
        public  DbSet<PmsRecurrFeeType> PmsRecurrFeeTypes { get; set; }
        public  DbSet<PmsRiskAppetite> PmsRiskAppetites { get; set; }
        public  DbSet<PmsRiskAppetiteProcess> PmsRiskAppetiteProcesses { get; set; }
        public  DbSet<PmsRiskLimitConfig> PmsRiskLimitConfigs { get; set; }
        public  DbSet<PmsRptSlab> PmsRptSlabs { get; set; }
        public  DbSet<PmsRptportfolio> PmsRptportfolios { get; set; }
        public  DbSet<PmsScoreRating> PmsScoreRatings { get; set; }
        public  DbSet<PmsScripInOutDef> PmsScripInOutDefs { get; set; }
        public  DbSet<PmsScriptExecutor> PmsScriptExecutors { get; set; }
        public  DbSet<PmsScriptIndex> PmsScriptIndices { get; set; }
        public  DbSet<PmsScriptIndicator> PmsScriptIndicators { get; set; }
        public  DbSet<PmsSector> PmsSectors { get; set; }
        public  DbSet<PmsSectorExposure> PmsSectorExposures { get; set; }
        public  DbSet<PmsSecurityDetail> PmsSecurityDetails { get; set; }
        public  DbSet<PmsSecurityDmprice> PmsSecurityDmprices { get; set; }
        public  DbSet<PmsSecurityRelease> PmsSecurityReleases { get; set; }
        public  DbSet<PmsSecurityRtprice> PmsSecurityRtprices { get; set; }
        public  DbSet<PmsSecurityValuation> PmsSecurityValuations { get; set; }
        public  DbSet<PmsSetLendMargin> PmsSetLendMargins { get; set; }
        public  DbSet<PmsSettBankInvMov> PmsSettBankInvMovs { get; set; }
        public  DbSet<PmsSettCal> PmsSettCals { get; set; }
        public  DbSet<PmsSettlementDate> PmsSettlementDates { get; set; }
        public  DbSet<PmsSettlementMode> PmsSettlementModes { get; set; }
        public  DbSet<PmsShare> PmsShares { get; set; }
        public  DbSet<PmsShareFinancing> PmsShareFinancings { get; set; }
        public  DbSet<PmsSharesAnnouncement> PmsSharesAnnouncements { get; set; }
        public  DbSet<PmsSignatory> PmsSignatories { get; set; }
        public  DbSet<PmsSiletterNumber> PmsSiletterNumbers { get; set; }
        public  DbSet<PmsTax> PmsTaxes { get; set; }
        public  DbSet<PmsTaxType> PmsTaxTypes { get; set; }
        public  DbSet<PmsTbill> PmsTbills { get; set; }
        public  DbSet<PmsTblTmp> PmsTblTmps { get; set; }
        public  DbSet<PmsTfc> PmsTfcs { get; set; }
        public  DbSet<PmsTrDealerLimit> PmsTrDealerLimits { get; set; }
        public  DbSet<PmsTrDealerLimitConfig> PmsTrDealerLimitConfigs { get; set; }
        public  DbSet<PmsTradingInstrumentType> PmsTradingInstrumentTypes { get; set; }
        public  DbSet<PmsTranDetail> PmsTranDetails { get; set; }
        public  DbSet<PmsTranMaster> PmsTranMasters { get; set; }
        public  DbSet<PmsTranTrustee> PmsTranTrustees { get; set; }
        public  DbSet<PmsTreasuryExpConfig> PmsTreasuryExpConfigs { get; set; }
        public  DbSet<PmsTreasuryExpLimit> PmsTreasuryExpLimits { get; set; }
        public  DbSet<PmsTreasuryLimitDetail> PmsTreasuryLimitDetails { get; set; }
        public  DbSet<PmsTreasurytype> PmsTreasurytypes { get; set; }
        public  DbSet<PmsTrstBankDetail> PmsTrstBankDetails { get; set; }
        public  DbSet<PmsTrstFee> PmsTrstFees { get; set; }
        public  DbSet<PmsTrustee> PmsTrustees { get; set; }
        public  DbSet<PmsUnderlyingSec> PmsUnderlyingSecs { get; set; }
        public  DbSet<PmsUnrealisedgainloss> PmsUnrealisedgainlosses { get; set; }
        public  DbSet<PmsUserDefProduct> PmsUserDefProducts { get; set; }
        public  DbSet<PmsVchrAmountType> PmsVchrAmountTypes { get; set; }
        public  DbSet<PmsVchrFmtDetail> PmsVchrFmtDetails { get; set; }
        public  DbSet<PmsVchrFmtMaster> PmsVchrFmtMasters { get; set; }
        public  DbSet<PmsWfactivity> PmsWfactivities { get; set; }
        public  DbSet<PmsWorkFlow> PmsWorkFlows { get; set; }
        public  DbSet<PmsWorkFlowAction> PmsWorkFlowActions { get; set; }
        public  DbSet<PmsWorkFlowEntity> PmsWorkFlowEntities { get; set; }
        public  DbSet<PmsWorkFlowLog> PmsWorkFlowLogs { get; set; }
        public  DbSet<PmsWorkFlowReport> PmsWorkFlowReports { get; set; }
        public  DbSet<PmsWorkFlowTempReport> PmsWorkFlowTempReports { get; set; }
        public  DbSet<PmsWorkFlowTemplate> PmsWorkFlowTemplates { get; set; }
        public  DbSet<PmsWorkFlowTemplateLog> PmsWorkFlowTemplateLogs { get; set; }
        public  DbSet<PmsZone> PmsZones { get; set; }
        public  DbSet<Update7> Update7s { get; set; }


    public DatabaseFacade Database { get; set; }
    public int SaveChanges();
}