using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using IPS.Domain.Models;

namespace IPS.Infra.Data.Context
{
    public partial class IPSContext : DbContext
    {
        public IPSContext()
        {
        }

        public IPSContext(DbContextOptions<IPSContext> options)
            : base(options)
        {
        }

        public virtual DbSet<OrderNotification> OrderNotifications { get; set; }
        public virtual DbSet<PmsAdjustedSchedule> PmsAdjustedSchedules { get; set; }
        public virtual DbSet<PmsAmortProcessLog> PmsAmortProcessLogs { get; set; }
        public virtual DbSet<PmsAmortSchedule> PmsAmortSchedules { get; set; }
        public virtual DbSet<PmsAmortScheduleArchieve> PmsAmortScheduleArchieves { get; set; }
        public virtual DbSet<PmsAmortScheduleQuarterly> PmsAmortScheduleQuarterlies { get; set; }
        public virtual DbSet<PmsApproveTradingBroker> PmsApproveTradingBrokers { get; set; }
        public virtual DbSet<PmsApproveTradingLimit> PmsApproveTradingLimits { get; set; }
        public virtual DbSet<PmsApprovedBroker> PmsApprovedBrokers { get; set; }
        public virtual DbSet<PmsApprovedScrip> PmsApprovedScrips { get; set; }
        public virtual DbSet<PmsAssetAllocation> PmsAssetAllocations { get; set; }
        public virtual DbSet<PmsAssetModuleRelation> PmsAssetModuleRelations { get; set; }
        public virtual DbSet<PmsAssetType> PmsAssetTypes { get; set; }
        public virtual DbSet<PmsBankMrpDetail> PmsBankMrpDetails { get; set; }
        public virtual DbSet<PmsBankMrpRatesDetail> PmsBankMrpRatesDetails { get; set; }
        public virtual DbSet<PmsBankMrpTemplate> PmsBankMrpTemplates { get; set; }
        public virtual DbSet<PmsBopProductMaster> PmsBopProductMasters { get; set; }
        public virtual DbSet<PmsBorrowProduct> PmsBorrowProducts { get; set; }
        public virtual DbSet<PmsBorrowProductSetup> PmsBorrowProductSetups { get; set; }
        public virtual DbSet<PmsBrkTfcmrkPrice> PmsBrkTfcmrkPrices { get; set; }
        public virtual DbSet<PmsBroker> PmsBrokers { get; set; }
        public virtual DbSet<PmsBrokerageRate> PmsBrokerageRates { get; set; }
        public virtual DbSet<PmsCalPeriod> PmsCalPeriods { get; set; }
        public virtual DbSet<PmsCalYear> PmsCalYears { get; set; }
        public virtual DbSet<PmsCalendar> PmsCalendars { get; set; }
        public virtual DbSet<PmsCallAndPutOption> PmsCallAndPutOptions { get; set; }
        public virtual DbSet<PmsCapCreditRisk> PmsCapCreditRisks { get; set; }
        public virtual DbSet<PmsCapMarketRisk> PmsCapMarketRisks { get; set; }
        public virtual DbSet<PmsCashFlow> PmsCashFlows { get; set; }
        public virtual DbSet<PmsCashType> PmsCashTypes { get; set; }
        public virtual DbSet<PmsCashflowdetail> PmsCashflowdetails { get; set; }
        public virtual DbSet<PmsCategory> PmsCategories { get; set; }
        public virtual DbSet<PmsCategoryLimit> PmsCategoryLimits { get; set; }
        public virtual DbSet<PmsCategoryLimitConfig> PmsCategoryLimitConfigs { get; set; }
        public virtual DbSet<PmsCdrHead> PmsCdrHeads { get; set; }
        public virtual DbSet<PmsCdsholding> PmsCdsholdings { get; set; }
        public virtual DbSet<PmsCertificate> PmsCertificates { get; set; }
        public virtual DbSet<PmsCfstradeLog> PmsCfstradeLogs { get; set; }
        public virtual DbSet<PmsCgtconfig> PmsCgtconfigs { get; set; }
        public virtual DbSet<PmsCity> PmsCities { get; set; }
        public virtual DbSet<PmsClearingCompany> PmsClearingCompanies { get; set; }
        public virtual DbSet<PmsClrCompanyRate> PmsClrCompanyRates { get; set; }
        public virtual DbSet<PmsCoi> PmsCois { get; set; }
        public virtual DbSet<PmsCompFinanceDatum> PmsCompFinanceData { get; set; }
        public virtual DbSet<PmsCompFundControl> PmsCompFundControls { get; set; }
        public virtual DbSet<PmsCountry> PmsCountries { get; set; }
        public virtual DbSet<PmsCoupon> PmsCoupons { get; set; }
        public virtual DbSet<PmsCouponDetail> PmsCouponDetails { get; set; }
        public virtual DbSet<PmsCouponRealisedDetail> PmsCouponRealisedDetails { get; set; }
        public virtual DbSet<PmsCouponTaxApplied> PmsCouponTaxApplieds { get; set; }
        public virtual DbSet<PmsCouponToleranceRate> PmsCouponToleranceRates { get; set; }
        public virtual DbSet<PmsCrFinstFinStatTemp> PmsCrFinstFinStatTemps { get; set; }
        public virtual DbSet<PmsCrFinstFinStatTmpDtl> PmsCrFinstFinStatTmpDtls { get; set; }
        public virtual DbSet<PmsCreditRating> PmsCreditRatings { get; set; }
        public virtual DbSet<PmsCreditRatingCompany> PmsCreditRatingCompanies { get; set; }
        public virtual DbSet<PmsCreditRatingEntity> PmsCreditRatingEntities { get; set; }
        public virtual DbSet<PmsCrrslr> PmsCrrslrs { get; set; }
        public virtual DbSet<PmsCurrency> PmsCurrencies { get; set; }
        public virtual DbSet<PmsCustodian> PmsCustodians { get; set; }
        public virtual DbSet<PmsCustomersAccount> PmsCustomersAccounts { get; set; }
        public virtual DbSet<PmsDailyCurrency> PmsDailyCurrencies { get; set; }
        public virtual DbSet<PmsDailyFmrdatum> PmsDailyFmrdata { get; set; }
        public virtual DbSet<PmsDailyFundPosition> PmsDailyFundPositions { get; set; }
        public virtual DbSet<PmsDailyIndex> PmsDailyIndices { get; set; }
        public virtual DbSet<PmsDailyNav> PmsDailyNavs { get; set; }
        public virtual DbSet<PmsDailyRate> PmsDailyRates { get; set; }
        public virtual DbSet<PmsDailySevar> PmsDailySevars { get; set; }
        public virtual DbSet<PmsDailyTranLog> PmsDailyTranLogs { get; set; }
        public virtual DbSet<PmsDailyVarBetum> PmsDailyVarBeta { get; set; }
        public virtual DbSet<PmsDealRate> PmsDealRates { get; set; }
        public virtual DbSet<PmsDealTrack> PmsDealTracks { get; set; }
        public virtual DbSet<PmsDealerLimit> PmsDealerLimits { get; set; }
        public virtual DbSet<PmsDtschema> PmsDtschemas { get; set; }
        public virtual DbSet<PmsEmailconfig> PmsEmailconfigs { get; set; }
        public virtual DbSet<PmsEmpInvestment> PmsEmpInvestments { get; set; }
        public virtual DbSet<PmsEmployee> PmsEmployees { get; set; }
        public virtual DbSet<PmsEodLog> PmsEodLogs { get; set; }
        public virtual DbSet<PmsEquityKatLog> PmsEquityKatLogs { get; set; }
        public virtual DbSet<PmsEquityTradeLog> PmsEquityTradeLogs { get; set; }
        public virtual DbSet<PmsExecptTranLog> PmsExecptTranLogs { get; set; }
        public virtual DbSet<PmsExpLimit> PmsExpLimits { get; set; }
        public virtual DbSet<PmsFInstBranch> PmsFInstBranches { get; set; }
        public virtual DbSet<PmsFInstStakeHolder> PmsFInstStakeHolders { get; set; }
        public virtual DbSet<PmsFInstTran> PmsFInstTrans { get; set; }
        public virtual DbSet<PmsFInstType> PmsFInstTypes { get; set; }
        public virtual DbSet<PmsFInstituion> PmsFInstituions { get; set; }
        public virtual DbSet<PmsFee> PmsFees { get; set; }
        public virtual DbSet<PmsFmglintegration> PmsFmglintegrations { get; set; }
        public virtual DbSet<PmsFminvOtherBond> PmsFminvOtherBonds { get; set; }
        public virtual DbSet<PmsFoOrder> PmsFoOrders { get; set; }
        public virtual DbSet<PmsFund> PmsFunds { get; set; }
        public virtual DbSet<PmsFundLimit> PmsFundLimits { get; set; }
        public virtual DbSet<PmsFundMaster> PmsFundMasters { get; set; }
        public virtual DbSet<PmsFundMasterNote> PmsFundMasterNotes { get; set; }
        public virtual DbSet<PmsFundMasterUser> PmsFundMasterUsers { get; set; }
        public virtual DbSet<PmsFundTransfer> PmsFundTransfers { get; set; }
        public virtual DbSet<PmsFundcapital> PmsFundcapitals { get; set; }
        public virtual DbSet<PmsFundsNav> PmsFundsNavs { get; set; }
        public virtual DbSet<PmsFutureTradeLog> PmsFutureTradeLogs { get; set; }
        public virtual DbSet<PmsGlAccountDetail> PmsGlAccountDetails { get; set; }
        public virtual DbSet<PmsGlAccountHead> PmsGlAccountHeads { get; set; }
        public virtual DbSet<PmsGlInterfaceHbl> PmsGlInterfaceHbls { get; set; }
        public virtual DbSet<PmsGlParam> PmsGlParams { get; set; }
        public virtual DbSet<PmsGlReversalVchrdetail> PmsGlReversalVchrdetails { get; set; }
        public virtual DbSet<PmsGlReversalVchrmaster> PmsGlReversalVchrmasters { get; set; }
        public virtual DbSet<PmsGlVchrdetail> PmsGlVchrdetails { get; set; }
        public virtual DbSet<PmsGlVchrmaster> PmsGlVchrmasters { get; set; }
        public virtual DbSet<PmsGlmode> PmsGlmodes { get; set; }
        public virtual DbSet<PmsGroupOfCompany> PmsGroupOfCompanies { get; set; }
        public virtual DbSet<PmsGrpExpLimit> PmsGrpExpLimits { get; set; }
        public virtual DbSet<PmsIndicator> PmsIndicators { get; set; }
        public virtual DbSet<PmsInvBond> PmsInvBonds { get; set; }
        public virtual DbSet<PmsInvCommOrdApp> PmsInvCommOrdApps { get; set; }
        public virtual DbSet<PmsIssuance> PmsIssuances { get; set; }
        public virtual DbSet<PmsLegalConstraintsSetup> PmsLegalConstraintsSetups { get; set; }
        public virtual DbSet<PmsLimitBreach> PmsLimitBreaches { get; set; }
        public virtual DbSet<PmsLimitFundConfig> PmsLimitFundConfigs { get; set; }
        public virtual DbSet<PmsLoanDatum> PmsLoanData { get; set; }
        public virtual DbSet<PmsMarket> PmsMarkets { get; set; }
        public virtual DbSet<PmsMarketTiming> PmsMarketTimings { get; set; }
        public virtual DbSet<PmsMarketToleranceRate> PmsMarketToleranceRates { get; set; }
        public virtual DbSet<PmsMmiannouncement> PmsMmiannouncements { get; set; }
        public virtual DbSet<PmsMngFeeBenchMark> PmsMngFeeBenchMarks { get; set; }
        public virtual DbSet<PmsMngFeeCustBenchMark> PmsMngFeeCustBenchMarks { get; set; }
        public virtual DbSet<PmsModule> PmsModules { get; set; }
        public virtual DbSet<PmsMovingAvg> PmsMovingAvgs { get; set; }
        public virtual DbSet<PmsNature> PmsNatures { get; set; }
        public virtual DbSet<PmsNavdetail> PmsNavdetails { get; set; }
        public virtual DbSet<PmsOrder> PmsOrders { get; set; }
        public virtual DbSet<PmsOrderExec> PmsOrderExecs { get; set; }
        public virtual DbSet<PmsOutstandingposition> PmsOutstandingpositions { get; set; }
        public virtual DbSet<PmsParam> PmsParams { get; set; }
        public virtual DbSet<PmsParamConfig> PmsParamConfigs { get; set; }
        public virtual DbSet<PmsPkrv> PmsPkrvs { get; set; }
        public virtual DbSet<PmsPkrvtemplate> PmsPkrvtemplates { get; set; }
        public virtual DbSet<PmsPolicyAndRegulation> PmsPolicyAndRegulations { get; set; }
        public virtual DbSet<PmsPorfoliGrpWiseLmt> PmsPorfoliGrpWiseLmts { get; set; }
        public virtual DbSet<PmsPortfolioLimit> PmsPortfolioLimits { get; set; }
        public virtual DbSet<PmsPortfoliolog> PmsPortfoliologs { get; set; }
        public virtual DbSet<PmsProcessCashflow> PmsProcessCashflows { get; set; }
        public virtual DbSet<PmsProcessImpairmentTesting> PmsProcessImpairmentTestings { get; set; }
        public virtual DbSet<PmsProcessPortfolio> PmsProcessPortfolios { get; set; }
        public virtual DbSet<PmsProposhare> PmsProposhares { get; set; }
        public virtual DbSet<PmsPurSalRef> PmsPurSalRefs { get; set; }
        public virtual DbSet<PmsRateTempl> PmsRateTempls { get; set; }
        public virtual DbSet<PmsRating> PmsRatings { get; set; }
        public virtual DbSet<PmsRecurrFeeType> PmsRecurrFeeTypes { get; set; }
        public virtual DbSet<PmsRiskAppetite> PmsRiskAppetites { get; set; }
        public virtual DbSet<PmsRiskAppetiteProcess> PmsRiskAppetiteProcesses { get; set; }
        public virtual DbSet<PmsRiskLimitConfig> PmsRiskLimitConfigs { get; set; }
        public virtual DbSet<PmsRptSlab> PmsRptSlabs { get; set; }
        public virtual DbSet<PmsRptportfolio> PmsRptportfolios { get; set; }
        public virtual DbSet<PmsScoreRating> PmsScoreRatings { get; set; }
        public virtual DbSet<PmsScripInOutDef> PmsScripInOutDefs { get; set; }
        public virtual DbSet<PmsScriptExecutor> PmsScriptExecutors { get; set; }
        public virtual DbSet<PmsScriptIndex> PmsScriptIndices { get; set; }
        public virtual DbSet<PmsScriptIndicator> PmsScriptIndicators { get; set; }
        public virtual DbSet<PmsSector> PmsSectors { get; set; }
        public virtual DbSet<PmsSectorExposure> PmsSectorExposures { get; set; }
        public virtual DbSet<PmsSecurityDetail> PmsSecurityDetails { get; set; }
        public virtual DbSet<PmsSecurityDmprice> PmsSecurityDmprices { get; set; }
        public virtual DbSet<PmsSecurityRelease> PmsSecurityReleases { get; set; }
        public virtual DbSet<PmsSecurityRtprice> PmsSecurityRtprices { get; set; }
        public virtual DbSet<PmsSecurityValuation> PmsSecurityValuations { get; set; }
        public virtual DbSet<PmsSetLendMargin> PmsSetLendMargins { get; set; }
        public virtual DbSet<PmsSettBankInvMov> PmsSettBankInvMovs { get; set; }
        public virtual DbSet<PmsSettCal> PmsSettCals { get; set; }
        public virtual DbSet<PmsSettlementDate> PmsSettlementDates { get; set; }
        public virtual DbSet<PmsSettlementMode> PmsSettlementModes { get; set; }
        public virtual DbSet<PmsShare> PmsShares { get; set; }
        public virtual DbSet<PmsShareFinancing> PmsShareFinancings { get; set; }
        public virtual DbSet<PmsSharesAnnouncement> PmsSharesAnnouncements { get; set; }
        public virtual DbSet<PmsSignatory> PmsSignatories { get; set; }
        public virtual DbSet<PmsSiletterNumber> PmsSiletterNumbers { get; set; }
        public virtual DbSet<PmsTax> PmsTaxes { get; set; }
        public virtual DbSet<PmsTaxType> PmsTaxTypes { get; set; }
        public virtual DbSet<PmsTbill> PmsTbills { get; set; }
        public virtual DbSet<PmsTblTmp> PmsTblTmps { get; set; }
        public virtual DbSet<PmsTfc> PmsTfcs { get; set; }
        public virtual DbSet<PmsTrDealerLimit> PmsTrDealerLimits { get; set; }
        public virtual DbSet<PmsTrDealerLimitConfig> PmsTrDealerLimitConfigs { get; set; }
        public virtual DbSet<PmsTradingInstrumentType> PmsTradingInstrumentTypes { get; set; }
        public virtual DbSet<PmsTranDetail> PmsTranDetails { get; set; }
        public virtual DbSet<PmsTranMaster> PmsTranMasters { get; set; }
        public virtual DbSet<PmsTranTrustee> PmsTranTrustees { get; set; }
        public virtual DbSet<PmsTreasuryExpConfig> PmsTreasuryExpConfigs { get; set; }
        public virtual DbSet<PmsTreasuryExpLimit> PmsTreasuryExpLimits { get; set; }
        public virtual DbSet<PmsTreasuryLimitDetail> PmsTreasuryLimitDetails { get; set; }
        public virtual DbSet<PmsTreasurytype> PmsTreasurytypes { get; set; }
        public virtual DbSet<PmsTrstBankDetail> PmsTrstBankDetails { get; set; }
        public virtual DbSet<PmsTrstFee> PmsTrstFees { get; set; }
        public virtual DbSet<PmsTrustee> PmsTrustees { get; set; }
        public virtual DbSet<PmsUnderlyingSec> PmsUnderlyingSecs { get; set; }
        public virtual DbSet<PmsUnrealisedgainloss> PmsUnrealisedgainlosses { get; set; }
        public virtual DbSet<PmsUserDefProduct> PmsUserDefProducts { get; set; }
        public virtual DbSet<PmsVchrAmountType> PmsVchrAmountTypes { get; set; }
        public virtual DbSet<PmsVchrFmtDetail> PmsVchrFmtDetails { get; set; }
        public virtual DbSet<PmsVchrFmtMaster> PmsVchrFmtMasters { get; set; }
        public virtual DbSet<PmsWfactivity> PmsWfactivities { get; set; }
        public virtual DbSet<PmsWorkFlow> PmsWorkFlows { get; set; }
        public virtual DbSet<PmsWorkFlowAction> PmsWorkFlowActions { get; set; }
        public virtual DbSet<PmsWorkFlowEntity> PmsWorkFlowEntities { get; set; }
        public virtual DbSet<PmsWorkFlowLog> PmsWorkFlowLogs { get; set; }
        public virtual DbSet<PmsWorkFlowReport> PmsWorkFlowReports { get; set; }
        public virtual DbSet<PmsWorkFlowTempReport> PmsWorkFlowTempReports { get; set; }
        public virtual DbSet<PmsWorkFlowTemplate> PmsWorkFlowTemplates { get; set; }
        public virtual DbSet<PmsWorkFlowTemplateLog> PmsWorkFlowTemplateLogs { get; set; }
        public virtual DbSet<PmsZone> PmsZones { get; set; }
        public virtual DbSet<Update7> Update7s { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.;Database=AAK_IPAMS_Faysal;user id=sa;password=sa;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderNotification>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OrderNotification");

                entity.Property(e => e.ChangeId).HasColumnName("changeId");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.TableName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PmsAdjustedSchedule>(entity =>
            {
                entity.HasKey(e => new { e.TradInstCode, e.TradInstTypeCode, e.CouponCode, e.OrdExecDate, e.AmortUpdateDate, e.FundCode, e.TransactionType });

                entity.ToTable("pms_AdjustedSchedule");

                entity.Property(e => e.TradInstCode).HasColumnName("tradInst_code");

                entity.Property(e => e.TradInstTypeCode).HasColumnName("tradInstType_code");

                entity.Property(e => e.CouponCode).HasColumnName("coupon_code");

                entity.Property(e => e.OrdExecDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ordExec_Date");

                entity.Property(e => e.AmortUpdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("amort_updateDate");

                entity.Property(e => e.FundCode).HasColumnName("fund_code");

                entity.Property(e => e.TransactionType).HasColumnName("transaction_Type");

                entity.Property(e => e.AmortAccruedProfit)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("amort_accruedProfit");

                entity.Property(e => e.AmortAmortPerDay)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("amort_amortPerDay");

                entity.Property(e => e.AmortCost)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("amort_cost");

                entity.Property(e => e.AmortCouponAmort)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("amort_couponAmort");

                entity.Property(e => e.AmortCouponAmortPerDay)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("amort_couponAmortPerDay");

                entity.Property(e => e.AmortCouponDays)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("amort_couponDays");

                entity.Property(e => e.AmortCpnMatAmt)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("amort_cpnMatAmt");

                entity.Property(e => e.AmortDaysTillCertMat).HasColumnName("amort_daysTillCertMat");

                entity.Property(e => e.AmortIrr)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("amort_IRR");

                entity.Property(e => e.AmortPrincipalPrem)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("amort_principalPrem");

                entity.Property(e => e.AmortRepayment)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("amort_Repayment");

                entity.Property(e => e.AmortUnamortPremPerUnit)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("amort_unamortPremPerUnit");

                entity.Property(e => e.AmortUrp)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("amort_URP");

                entity.Property(e => e.AutoIncrement).HasColumnName("auto_increment");

                entity.Property(e => e.CouponDate)
                    .HasColumnType("datetime")
                    .HasColumnName("coupon_date");

                entity.Property(e => e.FundMasterName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FundMaster_name");

                entity.Property(e => e.FundName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Fund_name");

                entity.Property(e => e.InvBondsCouponRatePerAnnum)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("invBonds_couponRatePerAnnum");

                entity.Property(e => e.InvBondsIssueDate)
                    .HasColumnType("datetime")
                    .HasColumnName("invBonds_issueDate");

                entity.Property(e => e.InvBondsMaturityDate)
                    .HasColumnType("datetime")
                    .HasColumnName("invBonds_maturityDate");

                entity.Property(e => e.InvBondsName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("invBonds_name");

                entity.Property(e => e.InvBondsRedemptionTenor).HasColumnName("invBonds_redemptionTenor");

                entity.Property(e => e.MovAvgQty)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("movAvg_qty");

                entity.Property(e => e.OrdExecAmount)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("ordExec_amount");

                entity.Property(e => e.OrdExecCode).HasColumnName("ordExec_code");

                entity.Property(e => e.OrdExecContractNo)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ordExec_contractNo");

                entity.Property(e => e.OrdExecDealTickNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ordExec_dealTickNo");

                entity.Property(e => e.OrdExecPrice)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("ordExec_price");

                entity.Property(e => e.OrdExecQuantity)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("ordExec_quantity");

                entity.Property(e => e.OrdExecTradeYield)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("ordExec_TradeYield");

                entity.Property(e => e.OrderCode).HasColumnName("order_Code");

                entity.Property(e => e.OrderExecYield)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("orderExec_Yield");

                entity.Property(e => e.SettDateAccruedInterest)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("settDate_AccruedInterest");

                entity.Property(e => e.SettDateAmount)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("settDate_amount");

                entity.Property(e => e.SettDateBrokerCommission)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("settDate_BrokerCommission");

                entity.Property(e => e.SettDateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("settDate_date");

                entity.Property(e => e.SettDateNetAmount)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("settDate_netAmount");

                entity.Property(e => e.SettDateQuantity)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("settDate_quantity");

                entity.Property(e => e.SettDateRate)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("settDate_rate");

                entity.Property(e => e.TransactionDate)
                    .HasColumnType("datetime")
                    .HasColumnName("transaction_Date");
            });

            modelBuilder.Entity<PmsAmortProcessLog>(entity =>
            {
                entity.HasKey(e => new { e.OrdExecDealTickNo, e.AmortProcessDate });

                entity.ToTable("pms_amortProcessLog");

                entity.Property(e => e.OrdExecDealTickNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ordExec_dealTickNo");

                entity.Property(e => e.AmortProcessDate)
                    .HasColumnType("datetime")
                    .HasColumnName("amort_processDate");

                entity.Property(e => e.AmortCreatedBy).HasColumnName("amort_createdBy");

                entity.Property(e => e.AmortCreatedWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("amort_createdWhen");

                entity.Property(e => e.AmortModifyBy).HasColumnName("amort_modifyBy");

                entity.Property(e => e.AmortModifyWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("amort_modifyWhen");
            });

            modelBuilder.Entity<PmsAmortSchedule>(entity =>
            {
                entity.HasKey(e => new { e.TradInstCode, e.TradInstTypeCode, e.CouponCode, e.OrdExecDate, e.AmortUpdateDate, e.FundCode });

                entity.ToTable("pms_amortSchedule");

                entity.Property(e => e.TradInstCode).HasColumnName("tradInst_code");

                entity.Property(e => e.TradInstTypeCode).HasColumnName("tradInstType_code");

                entity.Property(e => e.CouponCode).HasColumnName("coupon_code");

                entity.Property(e => e.OrdExecDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ordExec_Date");

                entity.Property(e => e.AmortUpdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("amort_updateDate");

                entity.Property(e => e.FundCode).HasColumnName("fund_code");

                entity.Property(e => e.AmortAccruedProfit)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("amort_accruedProfit");

                entity.Property(e => e.AmortAmortPerDay)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("amort_amortPerDay");

                entity.Property(e => e.AmortCost)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("amort_cost");

                entity.Property(e => e.AmortCouponAmort)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("amort_couponAmort");

                entity.Property(e => e.AmortCouponAmortPerDay)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("amort_couponAmortPerDay");

                entity.Property(e => e.AmortCouponDays).HasColumnName("amort_couponDays");

                entity.Property(e => e.AmortCpnMatAmt)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("amort_cpnMatAmt");

                entity.Property(e => e.AmortDaysTillCertMat).HasColumnName("amort_daysTillCertMat");

                entity.Property(e => e.AmortIrr)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("amort_IRR");

                entity.Property(e => e.AmortOrderCode).HasColumnName("amort_orderCode");

                entity.Property(e => e.AmortPrincipalPrem)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("amort_principalPrem");

                entity.Property(e => e.AmortRepayment)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("amort_Repayment");

                entity.Property(e => e.AmortUnamortPremPerUnit)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("amort_unamortPremPerUnit");

                entity.Property(e => e.AmortUrp)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("amort_URP");

                entity.Property(e => e.AutoIncrement)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("auto_increment");

                entity.Property(e => e.CouponDate)
                    .HasColumnType("datetime")
                    .HasColumnName("coupon_date");

                entity.Property(e => e.OrdExecCode)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("ordExec_code");

                entity.Property(e => e.OrdExecDealTickNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ordExec_dealTickNo");

                entity.Property(e => e.OrdExecQuantity)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("ordExec_quantity");

                entity.Property(e => e.OrderCode)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("order_code");
            });

            modelBuilder.Entity<PmsAmortScheduleArchieve>(entity =>
            {
                entity.HasKey(e => new { e.TradInstCode, e.TradInstTypeCode, e.CouponCode, e.OrdExecDate, e.AmortUpdateDate, e.FundCode, e.AutoIncrement });

                entity.ToTable("pms_amortScheduleArchieve");

                entity.Property(e => e.TradInstCode).HasColumnName("tradInst_code");

                entity.Property(e => e.TradInstTypeCode).HasColumnName("tradInstType_code");

                entity.Property(e => e.CouponCode).HasColumnName("coupon_code");

                entity.Property(e => e.OrdExecDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ordExec_Date");

                entity.Property(e => e.AmortUpdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("amort_updateDate");

                entity.Property(e => e.FundCode).HasColumnName("fund_code");

                entity.Property(e => e.AutoIncrement).HasColumnName("auto_increment");

                entity.Property(e => e.AmortAccruedProfit)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("amort_accruedProfit");

                entity.Property(e => e.AmortAmortPerDay)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("amort_amortPerDay");

                entity.Property(e => e.AmortCost)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("amort_cost");

                entity.Property(e => e.AmortCouponAmort)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("amort_couponAmort");

                entity.Property(e => e.AmortCouponAmortPerDay)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("amort_couponAmortPerDay");

                entity.Property(e => e.AmortCouponDays).HasColumnName("amort_couponDays");

                entity.Property(e => e.AmortCpnMatAmt)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("amort_cpnMatAmt");

                entity.Property(e => e.AmortDaysTillCertMat).HasColumnName("amort_daysTillCertMat");

                entity.Property(e => e.AmortIrr)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("amort_IRR");

                entity.Property(e => e.AmortOrderCode).HasColumnName("amort_orderCode");

                entity.Property(e => e.AmortPrincipalPrem)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("amort_principalPrem");

                entity.Property(e => e.AmortRepayment)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("amort_Repayment");

                entity.Property(e => e.AmortUnamortPremPerUnit)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("amort_unamortPremPerUnit");

                entity.Property(e => e.AmortUrp)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("amort_URP");

                entity.Property(e => e.CouponDate)
                    .HasColumnType("datetime")
                    .HasColumnName("coupon_date");

                entity.Property(e => e.OrdExecCode)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("ordExec_code");

                entity.Property(e => e.OrdExecDealTickNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ordExec_dealTickNo");

                entity.Property(e => e.OrdExecQuantity)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("ordExec_quantity");

                entity.Property(e => e.OrderCode)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("order_code");
            });

            modelBuilder.Entity<PmsAmortScheduleQuarterly>(entity =>
            {
                entity.HasKey(e => new { e.TradInstCode, e.TradInstTypeCode, e.CouponDate, e.OrdExecDate, e.AmortUpdateDate, e.CouponCode, e.FundCode });

                entity.ToTable("pms_amortScheduleQuarterly");

                entity.Property(e => e.TradInstCode).HasColumnName("tradInst_code");

                entity.Property(e => e.TradInstTypeCode).HasColumnName("tradInstType_code");

                entity.Property(e => e.CouponDate)
                    .HasColumnType("datetime")
                    .HasColumnName("coupon_date");

                entity.Property(e => e.OrdExecDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ordExec_Date");

                entity.Property(e => e.AmortUpdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("amort_updateDate");

                entity.Property(e => e.CouponCode).HasColumnName("coupon_code");

                entity.Property(e => e.FundCode).HasColumnName("fund_code");

                entity.Property(e => e.AmortAccruedProfit)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("amort_accruedProfit");

                entity.Property(e => e.AmortAmortPerDay)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("amort_amortPerDay");

                entity.Property(e => e.AmortCost)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("amort_cost");

                entity.Property(e => e.AmortCouponAmort)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("amort_couponAmort");

                entity.Property(e => e.AmortCouponAmortPerDay)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("amort_couponAmortPerDay");

                entity.Property(e => e.AmortCouponDays).HasColumnName("amort_couponDays");

                entity.Property(e => e.AmortCpnMatAmt)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("amort_cpnMatAmt");

                entity.Property(e => e.AmortDaysTillCertMat).HasColumnName("amort_daysTillCertMat");

                entity.Property(e => e.AmortIrr)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("amort_IRR");

                entity.Property(e => e.AmortPrincipalPrem)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("amort_principalPrem");

                entity.Property(e => e.AmortRepayment)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("amort_Repayment");

                entity.Property(e => e.AmortUnamortPremPerUnit)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("amort_unamortPremPerUnit");

                entity.Property(e => e.AmortUrp)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("amort_URP");

                entity.Property(e => e.AutoIncrement).HasColumnName("auto_increment");

                entity.Property(e => e.OrdExecCode)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("ordExec_code");

                entity.Property(e => e.OrdExecQuantity)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("ordExec_quantity");

                entity.Property(e => e.OrderCode)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("order_code");
            });

            modelBuilder.Entity<PmsApproveTradingBroker>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pms_ApproveTradingBroker");

                entity.Property(e => e.AppBrokerCreatedBy).HasColumnName("appBroker_createdBy");

                entity.Property(e => e.AppBrokerCreatedWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("appBroker_createdWhen");

                entity.Property(e => e.AppBrokerDate)
                    .HasColumnType("datetime")
                    .HasColumnName("appBroker_date");

                entity.Property(e => e.AppBrokerModifiedBy).HasColumnName("appBroker_modifiedBy");

                entity.Property(e => e.AppBrokerModifiedWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("appBroker_modifiedWhen");

                entity.Property(e => e.AppBrokerStatus).HasColumnName("appBroker_status");

                entity.Property(e => e.BrokerCode).HasColumnName("broker_Code");

                entity.Property(e => e.FundMasterCode).HasColumnName("fundMaster_code");

                entity.Property(e => e.TradInstTypeCode).HasColumnName("tradInstType_code");
            });

            modelBuilder.Entity<PmsApproveTradingLimit>(entity =>
            {
                entity.HasKey(e => new { e.FundMasterCode, e.AppTradLimitDate });

                entity.ToTable("pms_ApproveTradingLimit");

                entity.Property(e => e.FundMasterCode).HasColumnName("fundMaster_code");

                entity.Property(e => e.AppTradLimitDate)
                    .HasColumnType("datetime")
                    .HasColumnName("appTradLimit_date");

                entity.Property(e => e.AppTradLimitCreatedBy).HasColumnName("appTradLimit_createdBy");

                entity.Property(e => e.AppTradLimitCreatedWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("appTradLimit_createdWhen");

                entity.Property(e => e.AppTradLimitExpDate)
                    .HasColumnType("datetime")
                    .HasColumnName("appTradLimit_expDate");

                entity.Property(e => e.AppTradLimitLimit)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("appTradLimit_limit");

                entity.Property(e => e.AppTradLimitModifiedBy).HasColumnName("appTradLimit_modifiedBy");

                entity.Property(e => e.AppTradLimitModifiedWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("appTradLimit_modifiedWhen");

                entity.Property(e => e.AppTradLimitStatus).HasColumnName("appTradLimit_status");
            });

            modelBuilder.Entity<PmsApprovedBroker>(entity =>
            {
                entity.HasKey(e => new { e.FundMasterCode, e.BrokerCode, e.AppBrokerDate })
                    .HasName("PK_pms_approvedBroker_1");

                entity.ToTable("pms_approvedBroker");

                entity.Property(e => e.FundMasterCode).HasColumnName("fundMaster_code");

                entity.Property(e => e.BrokerCode).HasColumnName("broker_code");

                entity.Property(e => e.AppBrokerDate)
                    .HasColumnType("datetime")
                    .HasColumnName("appBroker_date");

                entity.Property(e => e.AppBrokerAmtType).HasColumnName("appBroker_amtType");

                entity.Property(e => e.AppBrokerCreatedBy).HasColumnName("appBroker_createdBy");

                entity.Property(e => e.AppBrokerCreatedWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("appBroker_createdWhen");

                entity.Property(e => e.AppBrokerExdate)
                    .HasColumnType("datetime")
                    .HasColumnName("appBroker_exdate");

                entity.Property(e => e.AppBrokerFrequency).HasColumnName("appBroker_frequency");

                entity.Property(e => e.AppBrokerLimit)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("appBroker_limit");

                entity.Property(e => e.AppBrokerModifiedBy).HasColumnName("appBroker_modifiedBy");

                entity.Property(e => e.AppBrokerModifiedWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("appBroker_modifiedWhen");

                entity.Property(e => e.AppBrokerStatus).HasColumnName("appBroker_status");

                entity.Property(e => e.AppBrokerType).HasColumnName("appBroker_Type");
            });

            modelBuilder.Entity<PmsApprovedScrip>(entity =>
            {
                entity.HasKey(e => new { e.FundMasterCode, e.TradInstCode, e.TradInstTypeCode, e.AppScripDate });

                entity.ToTable("pms_approvedScrip");

                entity.Property(e => e.FundMasterCode).HasColumnName("fundMaster_code");

                entity.Property(e => e.TradInstCode).HasColumnName("tradInst_code");

                entity.Property(e => e.TradInstTypeCode).HasColumnName("tradInstType_code");

                entity.Property(e => e.AppScripDate)
                    .HasColumnType("datetime")
                    .HasColumnName("appScrip_date");

                entity.Property(e => e.AppScripCreatedBy).HasColumnName("appScrip_createdBy");

                entity.Property(e => e.AppScripCreatedWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("appScrip_createdWhen");

                entity.Property(e => e.AppScripModifiedBy).HasColumnName("appScrip_modifiedBy");

                entity.Property(e => e.AppScripModifiedWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("appScrip_modifiedWhen");

                entity.Property(e => e.AppScripStatus).HasColumnName("appScrip_status");
            });

            modelBuilder.Entity<PmsAssetAllocation>(entity =>
            {
                entity.HasKey(e => new { e.AssetallocCode, e.AssetmoduleSno, e.AssetTypeCode, e.AssetmoduleCode, e.FundMasterCode, e.AssetallocDate });

                entity.ToTable("pms_assetAllocation");

                entity.Property(e => e.AssetallocCode).HasColumnName("assetalloc_code");

                entity.Property(e => e.AssetmoduleSno).HasColumnName("assetmodule_sno");

                entity.Property(e => e.AssetTypeCode).HasColumnName("assetType_code");

                entity.Property(e => e.AssetmoduleCode).HasColumnName("assetmodule_code");

                entity.Property(e => e.FundMasterCode).HasColumnName("fundMaster_code");

                entity.Property(e => e.AssetallocDate)
                    .HasColumnType("datetime")
                    .HasColumnName("assetalloc_Date");

                entity.Property(e => e.AssetallocAmountLimit)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("assetalloc_amountLimit");

                entity.Property(e => e.AssetallocCreatedWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("assetalloc_createdWhen");

                entity.Property(e => e.AssetallocCreatedby).HasColumnName("assetalloc_createdby");

                entity.Property(e => e.AssetallocIsAlco).HasColumnName("assetalloc_IsAlco");

                entity.Property(e => e.AssetallocLimitPercentage)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("assetalloc_limitPercentage");

                entity.Property(e => e.AssetallocModifyWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("assetalloc_modifyWhen");

                entity.Property(e => e.AssetallocModifyby).HasColumnName("assetalloc_modifyby");

                entity.Property(e => e.AssetallocSno).HasColumnName("assetalloc_sno");

                entity.Property(e => e.FundCode).HasColumnName("fund_code");
            });

            modelBuilder.Entity<PmsAssetModuleRelation>(entity =>
            {
                entity.HasKey(e => new { e.AssetTypeCode, e.AssetmoduleCode, e.AssetmoduleSno })
                    .HasName("PK_pms_AssetModuleRelation");

                entity.ToTable("pms_assetModuleRelation");

                entity.Property(e => e.AssetTypeCode).HasColumnName("assetType_code");

                entity.Property(e => e.AssetmoduleCode).HasColumnName("assetmodule_code");

                entity.Property(e => e.AssetmoduleSno).HasColumnName("assetmodule_sno");

                entity.Property(e => e.AssetmoduleCreatedWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("assetmodule_createdWhen");

                entity.Property(e => e.AssetmoduleCreatedby).HasColumnName("assetmodule_createdby");

                entity.Property(e => e.AssetmoduleGroupby)
                    .HasMaxLength(100)
                    .HasColumnName("assetmodule_groupby");

                entity.Property(e => e.AssetmoduleModifyWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("assetmodule_modifyWhen");

                entity.Property(e => e.AssetmoduleModifyby).HasColumnName("assetmodule_modifyby");

                entity.Property(e => e.AssetmoduleName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("assetmodule_name");
            });

            modelBuilder.Entity<PmsAssetType>(entity =>
            {
                entity.HasKey(e => new { e.AssetCode, e.AssetDate })
                    .HasName("PK_pms_assetTypes_1");

                entity.ToTable("pms_assetTypes");

                entity.Property(e => e.AssetCode).HasColumnName("asset_code");

                entity.Property(e => e.AssetDate)
                    .HasColumnType("datetime")
                    .HasColumnName("asset_Date");

                entity.Property(e => e.AssetDesc)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("asset_Desc");

                entity.Property(e => e.AssetState).HasColumnName("asset_state");

                entity.Property(e => e.AssetType).HasColumnName("asset_type");

                entity.Property(e => e.CostOfInvestment)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("costOfInvestment");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.CreatedWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("createdWhen");

                entity.Property(e => e.FundMasterCode).HasColumnName("fundMaster_code");

                entity.Property(e => e.MarketValue)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("marketValue");

                entity.Property(e => e.ModifiedBy).HasColumnName("modifiedBy");

                entity.Property(e => e.ModifiedWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("modifiedWhen");
            });

            modelBuilder.Entity<PmsBankMrpDetail>(entity =>
            {
                entity.HasKey(e => new { e.FInstBranchCode, e.BankMrpDetailDate, e.FundMasterCode })
                    .HasName("PK_pms_bankMrpDetail_1");

                entity.ToTable("pms_bankMrpDetail");

                entity.Property(e => e.FInstBranchCode).HasColumnName("fInstBranch_code");

                entity.Property(e => e.BankMrpDetailDate)
                    .HasColumnType("datetime")
                    .HasColumnName("bankMrpDetail_date");

                entity.Property(e => e.FundMasterCode).HasColumnName("fundMaster_code");

                entity.Property(e => e.BankFundAccrualBasis).HasColumnName("bankFund_accrualBasis");

                entity.Property(e => e.BankFundCapital)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("bankFund_capital");

                entity.Property(e => e.BankFundMarkUp)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("bankFund_markUp");

                entity.Property(e => e.BankFundRate)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("bankFund_rate");

                entity.Property(e => e.BankFundRateType).HasColumnName("bankFund_rateType");

                entity.Property(e => e.BankMrpDetailModifyBy).HasColumnName("bankMrpDetail_modifyBy");

                entity.Property(e => e.BankMrpDetailModifyWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("bankMrpDetail_modifyWhen");

                entity.Property(e => e.BankMrpDetailSno).HasColumnName("bankMrpDetail_sno");

                entity.Property(e => e.VmSno)
                    .HasColumnType("decimal(25, 0)")
                    .HasColumnName("VM_SNO");
            });

            modelBuilder.Entity<PmsBankMrpRatesDetail>(entity =>
            {
                entity.HasKey(e => e.BankMrpRateCode);

                entity.ToTable("pms_bankMrpRatesDetail");

                entity.Property(e => e.BankMrpRateCode)
                    .ValueGeneratedNever()
                    .HasColumnName("bankMrpRate_code");

                entity.Property(e => e.BankMrpRateAccrualBasis).HasColumnName("bankMrpRate_accrualBasis");

                entity.Property(e => e.BankMrpRateBaseRate)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("bankMrpRate_baseRate");

                entity.Property(e => e.BankMrpRateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("bankMrpRate_date");

                entity.Property(e => e.BankMrpRateModifyBy).HasColumnName("bankMrpRate_modifyBy");

                entity.Property(e => e.BankMrpRateModifyWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("bankMrpRate_modifyWhen");

                entity.Property(e => e.BankMrpRateRateType).HasColumnName("bankMrpRate_rateType");

                entity.Property(e => e.BankMrpTemplCode).HasColumnName("bankMrpTempl_code");

                entity.Property(e => e.FInstBranchCode).HasColumnName("fInstBranch_code");

                entity.Property(e => e.FundMasterCode).HasColumnName("fundMaster_code");

                entity.Property(e => e.RateTemplCode).HasColumnName("rateTempl_code");
            });

            modelBuilder.Entity<PmsBankMrpTemplate>(entity =>
            {
                entity.HasKey(e => new { e.BankMrpTemplCode, e.BankMrpTemplFromValue, e.BankMrpTemplToValue });

                entity.ToTable("pms_bankMrpTemplate");

                entity.Property(e => e.BankMrpTemplCode).HasColumnName("bankMrpTempl_code");

                entity.Property(e => e.BankMrpTemplFromValue)
                    .HasColumnType("decimal(25, 4)")
                    .HasColumnName("bankMrpTempl_fromValue");

                entity.Property(e => e.BankMrpTemplToValue)
                    .HasColumnType("decimal(25, 4)")
                    .HasColumnName("bankMrpTempl_toValue");

                entity.Property(e => e.BankMrpTemplFlatRate)
                    .HasColumnType("decimal(25, 4)")
                    .HasColumnName("bankMrpTempl_flatRate");

                entity.Property(e => e.BankMrpTemplModifyBy).HasColumnName("bankMrpTempl_modifyBy");

                entity.Property(e => e.BankMrpTemplModifyWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("bankMrpTempl_modifyWhen");
            });

            modelBuilder.Entity<PmsBopProductMaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PMS_BOP_PRODUCT_MASTER");

                entity.Property(e => e.ProductDescription)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("PRODUCT_DESCRIPTION");

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("PRODUCT_NAME");

                entity.Property(e => e.ProductSno).HasColumnName("PRODUCT_SNO");
            });

            modelBuilder.Entity<PmsBorrowProduct>(entity =>
            {
                entity.HasKey(e => new { e.BrprodCode, e.FInstTypeCode, e.FInstCode, e.FInstBranchCode });

                entity.ToTable("pms_borrowProducts");

                entity.Property(e => e.BrprodCode).HasColumnName("brprod_code");

                entity.Property(e => e.FInstTypeCode).HasColumnName("fInstType_code");

                entity.Property(e => e.FInstCode).HasColumnName("fInst_code");

                entity.Property(e => e.FInstBranchCode).HasColumnName("fInstBranch_code");

                entity.Property(e => e.BrProdShutPeriod)
                    .HasColumnType("datetime")
                    .HasColumnName("brProd_shutPeriod");

                entity.Property(e => e.BrprodAccBasis).HasColumnName("brprod_accBasis");

                entity.Property(e => e.BrprodAmount)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("brprod_amount");

                entity.Property(e => e.BrprodBaseRate)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("brprod_baseRate");

                entity.Property(e => e.BrprodIssueDate)
                    .HasColumnType("datetime")
                    .HasColumnName("brprod_issueDate");

                entity.Property(e => e.BrprodMaturityDate)
                    .HasColumnType("datetime")
                    .HasColumnName("brprod_maturityDate");

                entity.Property(e => e.BrprodName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("brprod_name");

                entity.Property(e => e.RateTemplCode).HasColumnName("rateTempl_code");

                entity.Property(e => e.RateTemplType).HasColumnName("rateTempl_type");
            });

            modelBuilder.Entity<PmsBorrowProductSetup>(entity =>
            {
                entity.HasKey(e => e.BrprodCode);

                entity.ToTable("pms_borrowProductSetup");

                entity.Property(e => e.BrprodCode)
                    .ValueGeneratedNever()
                    .HasColumnName("brprod_code");

                entity.Property(e => e.BrprodDesc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("brprod_desc");

                entity.Property(e => e.BrprodName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("brprod_name");
            });

            modelBuilder.Entity<PmsBrkTfcmrkPrice>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pms_BrkTFCMrkPrice");

                entity.Property(e => e.BrokerCode).HasColumnName("broker_Code");

                entity.Property(e => e.Datetime)
                    .HasColumnType("datetime")
                    .HasColumnName("datetime");

                entity.Property(e => e.MrkBid)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("mrkBid");

                entity.Property(e => e.MrkBrkSymbol)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("mrkBrkSymbol")
                    .IsFixedLength();

                entity.Property(e => e.MrkDate)
                    .HasColumnType("datetime")
                    .HasColumnName("mrkDate");

                entity.Property(e => e.MrkOffer)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("mrkOffer");

                entity.Property(e => e.MrkSymbol)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("mrkSymbol")
                    .IsFixedLength();

                entity.Property(e => e.MrkVolume)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("mrkVolume");

                entity.Property(e => e.TfcCode).HasColumnName("tfc_Code");

                entity.Property(e => e.TradInstTypeCode).HasColumnName("tradInstType_code");

                entity.Property(e => e.UserId).HasColumnName("userId");
            });

            modelBuilder.Entity<PmsBroker>(entity =>
            {
                entity.HasKey(e => e.BrokerCode)
                    .HasName("PK__pms_brokers__48CFD27E");

                entity.ToTable("pms_brokers");

                entity.HasIndex(e => e.BrokerName, "IX_pms_brokers")
                    .IsUnique();

                entity.Property(e => e.BrokerCode)
                    .ValueGeneratedNever()
                    .HasColumnName("broker_Code");

                entity.Property(e => e.BrokerAccNo)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("broker_accNo");

                entity.Property(e => e.BrokerAddress)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("broker_address");

                entity.Property(e => e.BrokerAuthorizedBy).HasColumnName("BROKER_authorizedBy");

                entity.Property(e => e.BrokerAuthorizedWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("BROKER_authorizedWhen");

                entity.Property(e => e.BrokerBrokerCommTax)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("broker_BrokerCommTax");

                entity.Property(e => e.BrokerCfsdefTradeId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("broker_CFSDefTradeId");

                entity.Property(e => e.BrokerCotlimit)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("broker_COTLimit");

                entity.Property(e => e.BrokerCreatedBy).HasColumnName("BROKER_createdBy");

                entity.Property(e => e.BrokerCreatedWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("BROKER_createdWhen");

                entity.Property(e => e.BrokerDesc)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("broker_desc");

                entity.Property(e => e.BrokerEmail)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("broker_email");

                entity.Property(e => e.BrokerFax)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("broker_fax");

                entity.Property(e => e.BrokerForPkrv).HasColumnName("broker_forPKRV");

                entity.Property(e => e.BrokerFundCode).HasColumnName("BROKER_FUND_CODE");

                entity.Property(e => e.BrokerFundmasterCode).HasColumnName("BROKER_FUNDMASTER_CODE");

                entity.Property(e => e.BrokerIsActive).HasColumnName("broker_isActive");

                entity.Property(e => e.BrokerIsAssosiated).HasColumnName("broker_isAssosiated");

                entity.Property(e => e.BrokerIsAuthorized).HasColumnName("BROKER_isAuthorized");

                entity.Property(e => e.BrokerIsPrimaryDealer).HasColumnName("broker_isPrimaryDealer");

                entity.Property(e => e.BrokerIsTfclisted).HasColumnName("broker_isTFCListed");

                entity.Property(e => e.BrokerIssalecomm).HasColumnName("BROKER_ISSALECOMM");

                entity.Property(e => e.BrokerMnemonic)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("broker_mnemonic");

                entity.Property(e => e.BrokerModifiedBy).HasColumnName("BROKER_modifiedBy");

                entity.Property(e => e.BrokerModifiedWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("BROKER_modifiedWhen");

                entity.Property(e => e.BrokerName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("broker_name");

                entity.Property(e => e.BrokerOldCode).HasColumnName("broker_oldCode");

                entity.Property(e => e.BrokerPhone)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("broker_phone");

                entity.Property(e => e.BrokerReason)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("BROKER_reason");

                entity.Property(e => e.BrokerSetFor).HasColumnName("broker_SetFor");

                entity.Property(e => e.BrokerSubLedgerAc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BROKER_SubLedgerAC");

                entity.Property(e => e.BrokerSubLedgerType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BROKER_SubLedgerType");
            });

            modelBuilder.Entity<PmsBrokerageRate>(entity =>
            {
                entity.HasKey(e => new { e.BrokerCode, e.BrkRateType, e.BrkRateTradeMode, e.TradInstTypeCode, e.BrkRateCode });

                entity.ToTable("pms_brokerageRates");

                entity.Property(e => e.BrokerCode).HasColumnName("broker_Code");

                entity.Property(e => e.BrkRateType).HasColumnName("brkRate_Type");

                entity.Property(e => e.BrkRateTradeMode).HasColumnName("brkRate_tradeMode");

                entity.Property(e => e.TradInstTypeCode).HasColumnName("tradInstType_code");

                entity.Property(e => e.BrkRateCode).HasColumnName("brkRate_code");

                entity.Property(e => e.BrkRateCapCommission)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("brkRate_CapCommission");

                entity.Property(e => e.BrkRateFloorCommission)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("brkRate_FloorCommission");

                entity.Property(e => e.BrkRateMaxPrice)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("brkRate_maxPrice");

                entity.Property(e => e.BrkRateMinPrice)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("brkRate_minPrice");

                entity.Property(e => e.BrkRateRateInAmount)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("brkRate_rateInAmount");

                entity.Property(e => e.BrkRateRateInPercent)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("brkRate_rateInPercent");

                entity.Property(e => e.BrkRateSlabType).HasColumnName("brkRate_slabType");

                entity.Property(e => e.BrkrateAuthorizedBy).HasColumnName("BRKRATE_authorizedBy");

                entity.Property(e => e.BrkrateAuthorizedWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("BRKRATE_authorizedWhen");

                entity.Property(e => e.BrkrateCreatedBy).HasColumnName("BRKRATE_createdBy");

                entity.Property(e => e.BrkrateCreatedWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("BRKRATE_createdWhen");

                entity.Property(e => e.BrkrateIsAuthorized).HasColumnName("BRKRATE_isAuthorized");

                entity.Property(e => e.BrkrateModifiedBy).HasColumnName("BRKRATE_modifiedBy");

                entity.Property(e => e.BrkrateModifiedWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("BRKRATE_modifiedWhen");

                entity.Property(e => e.BrkrateReason)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("BRKRATE_reason");

                entity.Property(e => e.OrderSubtype).HasColumnName("order_subtype");

                entity.HasOne(d => d.BrokerCodeNavigation)
                    .WithMany(p => p.PmsBrokerageRates)
                    .HasForeignKey(d => d.BrokerCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__pms_broke__broke__4D94879B");

                entity.HasOne(d => d.TradInstTypeCodeNavigation)
                    .WithMany(p => p.PmsBrokerageRates)
                    .HasForeignKey(d => d.TradInstTypeCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__pms_broke__tradI__4E88ABD4");
            });

            modelBuilder.Entity<PmsCalPeriod>(entity =>
            {
                entity.HasKey(e => new { e.CalYearCode, e.CalPeriodCode })
                    .HasName("PK__pms_calPeriod__4DE98D56");

                entity.ToTable("pms_calPeriod");

                entity.Property(e => e.CalYearCode).HasColumnName("calYear_code");

                entity.Property(e => e.CalPeriodCode).HasColumnName("calPeriod_code");

                entity.Property(e => e.CalPeriodEndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("calPeriod_endDate");

                entity.Property(e => e.CalPeriodName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("calPeriod_name");

                entity.Property(e => e.CalPeriodStartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("calPeriod_startDate");

                entity.HasOne(d => d.CalYearCodeNavigation)
                    .WithMany(p => p.PmsCalPeriods)
                    .HasForeignKey(d => d.CalYearCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__pms_calPe__calYe__79C80F94");
            });

            modelBuilder.Entity<PmsCalYear>(entity =>
            {
                entity.HasKey(e => e.CalYearCode)
                    .HasName("PK__pms_calYear__3CBF0154");

                entity.ToTable("pms_calYear");

                entity.Property(e => e.CalYearCode)
                    .ValueGeneratedNever()
                    .HasColumnName("calYear_code");

                entity.Property(e => e.CalYearDesc)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("calYear_desc");

                entity.Property(e => e.CalYearName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("calYear_name");
            });

            modelBuilder.Entity<PmsCalendar>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pms_calendar");

                entity.Property(e => e.CalDate)
                    .HasColumnType("datetime")
                    .HasColumnName("calDate");

                entity.Property(e => e.CalDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("cal_Description");

                entity.Property(e => e.CalHoliday).HasColumnName("cal_Holiday");

                entity.Property(e => e.CalPeriodCode).HasColumnName("calPeriod_code");

                entity.Property(e => e.CalYearCode).HasColumnName("calYear_code");
            });

            modelBuilder.Entity<PmsCallAndPutOption>(entity =>
            {
                entity.HasKey(e => new { e.CpoptionCode, e.TradInstTypeCode, e.TradInstCode, e.CpoptionType })
                    .HasName("PK__pms_callAndPutOp__4CF5691D");

                entity.ToTable("pms_callAndPutOptions");

                entity.Property(e => e.CpoptionCode).HasColumnName("CPoption_code");

                entity.Property(e => e.TradInstTypeCode).HasColumnName("tradInstType_code");

                entity.Property(e => e.TradInstCode).HasColumnName("tradInst_code");

                entity.Property(e => e.CpoptionType).HasColumnName("CPoption_type");

                entity.Property(e => e.CpoptionMonths).HasColumnName("CPoption_months");

                entity.Property(e => e.CpoptionRateInAmount)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("CPoption_rateInAmount");

                entity.Property(e => e.CpoptionTimeSpan).HasColumnName("CPoptionTimeSpan");

                entity.HasOne(d => d.TradInstTypeCodeNavigation)
                    .WithMany(p => p.PmsCallAndPutOptions)
                    .HasForeignKey(d => d.TradInstTypeCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__pms_callA__tradI__77DFC722");
            });

            modelBuilder.Entity<PmsCapCreditRisk>(entity =>
            {
                entity.HasKey(e => new { e.FundMasterCode, e.FundCode, e.TradInstTypeCode, e.CapCreditRiskDate, e.RatingCode });

                entity.ToTable("pms_capCreditRisk");

                entity.Property(e => e.FundMasterCode).HasColumnName("fundMaster_code");

                entity.Property(e => e.FundCode).HasColumnName("fund_code");

                entity.Property(e => e.TradInstTypeCode).HasColumnName("tradInstType_code");

                entity.Property(e => e.CapCreditRiskDate)
                    .HasColumnType("datetime")
                    .HasColumnName("capCreditRisk_date");

                entity.Property(e => e.RatingCode).HasColumnName("rating_code");

                entity.Property(e => e.CapCreditRiskBaselRate)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("capCreditRisk_baselRate");

                entity.Property(e => e.CapCreditRiskCreatedBy).HasColumnName("capCreditRisk_createdBy");

                entity.Property(e => e.CapCreditRiskCreatedWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("capCreditRisk_createdWhen");
            });

            modelBuilder.Entity<PmsCapMarketRisk>(entity =>
            {
                entity.HasKey(e => new { e.FundMasterCode, e.FundCode, e.TradInstTypeCode, e.CapMarketRiskDate, e.MarketCode });

                entity.ToTable("pms_capMarketRisk");

                entity.Property(e => e.FundMasterCode).HasColumnName("fundMaster_code");

                entity.Property(e => e.FundCode).HasColumnName("fund_code");

                entity.Property(e => e.TradInstTypeCode).HasColumnName("tradInstType_code");

                entity.Property(e => e.CapMarketRiskDate)
                    .HasColumnType("datetime")
                    .HasColumnName("capMarketRisk_date");

                entity.Property(e => e.MarketCode).HasColumnName("market_code");

                entity.Property(e => e.CapMarketRiskCreatedBy).HasColumnName("capMarketRisk_createdBy");

                entity.Property(e => e.CapMarketRiskCreatedWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("capMarketRisk_createdWhen");

                entity.Property(e => e.MarketLongPosition)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("market_longPosition");

                entity.Property(e => e.MarketShortPosition)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("market_shortPosition");
            });

            modelBuilder.Entity<PmsCashFlow>(entity =>
            {
                entity.HasKey(e => new { e.CfCode, e.FInstTranType, e.FinstTranCode });

                entity.ToTable("pms_cashFlows");

                entity.Property(e => e.CfCode).HasColumnName("cf_code");

                entity.Property(e => e.FInstTranType).HasColumnName("fInstTran_type");

                entity.Property(e => e.FinstTranCode)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("finstTran_code");

                entity.Property(e => e.CfActMaturityDate)
                    .HasColumnType("datetime")
                    .HasColumnName("cf_ActMaturityDate");

                entity.Property(e => e.CfActReleaseDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CF_actReleaseDate");

                entity.Property(e => e.CfAmount)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("cf_amount");

                entity.Property(e => e.CfAmtExtendDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Cf_AmtExtendDate");

                entity.Property(e => e.CfAvgPkrvRate)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("cf_avgPkrvRate");

                entity.Property(e => e.CfAvgYield)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("cf_avgYield");

                entity.Property(e => e.CfBrokerCommission)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("cf_brokerCommission");

                entity.Property(e => e.CfCouponMaturity).HasColumnName("CF_couponMaturity");

                entity.Property(e => e.CfCouponNature).HasColumnName("CF_couponNature");

                entity.Property(e => e.CfCreatedWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("CF_CreatedWhen");

                entity.Property(e => e.CfCreatedby).HasColumnName("CF_Createdby");

                entity.Property(e => e.CfDateDelivery)
                    .HasColumnType("datetime")
                    .HasColumnName("cf_dateDelivery");

                entity.Property(e => e.CfDateSettlement)
                    .HasColumnType("datetime")
                    .HasColumnName("cf_dateSettlement");

                entity.Property(e => e.CfEditCounter).HasColumnName("CF_EditCounter");

                entity.Property(e => e.CfFixedAmt)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("cf_FixedAmt");

                entity.Property(e => e.CfFixedMrkup)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("cf_FixedMrkup");

                entity.Property(e => e.CfFlag).HasColumnName("cf_flag");

                entity.Property(e => e.CfFloatAmt)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("cf_FloatAmt");

                entity.Property(e => e.CfFloatMrkup)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("cf_FloatMrkup");

                entity.Property(e => e.CfIsExtendMaturity).HasColumnName("Cf_IsExtendMaturity");

                entity.Property(e => e.CfModifiedBy).HasColumnName("cf_modifiedBy");

                entity.Property(e => e.CfModifiedWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("cf_modifiedWhen");

                entity.Property(e => e.CfNetAmount)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("cf_netAmount");

                entity.Property(e => e.CfOutFixed)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("cf_OutFixed");

                entity.Property(e => e.CfOutFloat)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("cf_OutFloat");

                entity.Property(e => e.CfOutStandAmount)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("CF_OutStandAmount");

                entity.Property(e => e.CfPenaltyRate)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("CF_penaltyRate");

                entity.Property(e => e.CfPrincipalRedeem)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("cf_principalRedeem");

                entity.Property(e => e.CfPrincipalRedeemFloat)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("cf_principalRedeemFloat");

                entity.Property(e => e.CfRate)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("cf_rate");

                entity.Property(e => e.CfRefNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cf_refNo");

                entity.Property(e => e.CfRoInstCode).HasColumnName("CF_roInstCode");

                entity.Property(e => e.CfSettbank).HasColumnName("CF_SETTBANK");

                entity.Property(e => e.CfState).HasColumnName("cf_state");

                entity.Property(e => e.CfTerm).HasColumnName("cf_term");

                entity.Property(e => e.CfTotalFixedMrkup)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("cf_TotalFixedMrkup");

                entity.Property(e => e.CfTotalFloatMrkup)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("cf_TotalFloatMrkup");

                entity.Property(e => e.CfVchrState).HasColumnName("cf_vchrState");

                entity.Property(e => e.CfWhtaxAmount)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("cf_WHTaxAmount");

                entity.Property(e => e.CfWhtaxBcom)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("cf_WHTaxBCom");

                entity.Property(e => e.CfZakatamount)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("CF_ZAKATAMOUNT");

                entity.Property(e => e.CfZakatenable).HasColumnName("CF_ZAKATENABLE");

                entity.Property(e => e.TransactionType).HasColumnName("transaction_type");

                entity.Property(e => e.VmSno)
                    .HasColumnType("decimal(25, 0)")
                    .HasColumnName("VM_SNO");
            });

            modelBuilder.Entity<PmsCashType>(entity =>
            {
                entity.HasKey(e => new { e.CashTypeCode, e.CashType });

                entity.ToTable("pms_cashType");

                entity.Property(e => e.CashTypeCode).HasColumnName("cashTypeCode");

                entity.Property(e => e.CashType).HasColumnName("cashType");

                entity.Property(e => e.CashFlag).HasColumnName("cashFlag");

                entity.Property(e => e.CashTag)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("cashTag");

                entity.Property(e => e.CashTypeQuantity).HasColumnName("cashType_quantity");

                entity.Property(e => e.CashTypeValidityDate).HasColumnName("cashType_validityDate");
            });

            modelBuilder.Entity<PmsCashflowdetail>(entity =>
            {
                entity.HasKey(e => new { e.CfCode, e.FinsttranType, e.FinsttranCode });

                entity.ToTable("PMS_CASHFLOWDETAIL");

                entity.Property(e => e.CfCode).HasColumnName("CF_CODE");

                entity.Property(e => e.FinsttranType).HasColumnName("FINSTTRAN_TYPE");

                entity.Property(e => e.FinsttranCode).HasColumnName("FINSTTRAN_CODE");

                entity.Property(e => e.CfAmount)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("CF_AMOUNT");

                entity.Property(e => e.CfDatesettlement)
                    .HasColumnType("datetime")
                    .HasColumnName("CF_DATESETTLEMENT");

                entity.Property(e => e.CfMarkup)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("CF_Markup");

                entity.Property(e => e.CfPrincipalredeem)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("CF_PRINCIPALREDEEM");

                entity.Property(e => e.CfRate)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("CF_RATE");
            });

            modelBuilder.Entity<PmsCategory>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pms_category");

                entity.Property(e => e.CatCode).HasColumnName("cat_code");

                entity.Property(e => e.CatName)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("cat_name");

                entity.Property(e => e.CatType).HasColumnName("cat_type");
            });

            modelBuilder.Entity<PmsCategoryLimit>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pms_categoryLimit");

                entity.Property(e => e.CatCode).HasColumnName("cat_code");

                entity.Property(e => e.CatLimitCode).HasColumnName("catLimit_code");

                entity.Property(e => e.CatLimitCreatedBy).HasColumnName("catLimit_createdBy");

                entity.Property(e => e.CatLimitCreatedWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("catLimit_createdWhen");

                entity.Property(e => e.CatLimitIsActive).HasColumnName("catLimit_isActive");

                entity.Property(e => e.CatLimitValue)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("catLimit_value");

                entity.Property(e => e.CatLimitValueType).HasColumnName("catLimit_valueType");

                entity.Property(e => e.CatType).HasColumnName("cat_type");
            });

            modelBuilder.Entity<PmsCategoryLimitConfig>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pms_categoryLimitConfig");

                entity.Property(e => e.CatCode).HasColumnName("cat_code");

                entity.Property(e => e.CatLimitConfigCode).HasColumnName("catLimitConfig_code");

                entity.Property(e => e.CatLimitConfigCreatedBy).HasColumnName("catLimitConfig_createdBy");

                entity.Property(e => e.CatLimitConfigCreatedWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("catLimitConfig_createdWhen");

                entity.Property(e => e.CatLimitConfigIsActive).HasColumnName("catLimitConfig_isActive");

                entity.Property(e => e.CatType).HasColumnName("cat_type");

                entity.Property(e => e.EntityCode).HasColumnName("entity_code");
            });

            modelBuilder.Entity<PmsCdrHead>(entity =>
            {
                entity.HasKey(e => new { e.CdrHeadCode, e.FundMasterCode, e.GlAccCode });

                entity.ToTable("pms_cdrHeads");

                entity.Property(e => e.CdrHeadCode).HasColumnName("cdrHead_Code");

                entity.Property(e => e.FundMasterCode).HasColumnName("FundMaster_code");

                entity.Property(e => e.GlAccCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("GL_ACC_CODE");

                entity.Property(e => e.FundMasterCostCenter)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("fundMaster_costCenter");

                entity.Property(e => e.GlAccTitle)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("GL_ACC_TITLE");
            });

            modelBuilder.Entity<PmsCdsholding>(entity =>
            {
                entity.HasKey(e => new { e.FundMasterCode, e.CdsDate, e.TradInstTypeCode, e.TradInstCode });

                entity.ToTable("pms_CDSHolding");

                entity.Property(e => e.FundMasterCode).HasColumnName("fundMaster_code");

                entity.Property(e => e.CdsDate)
                    .HasColumnType("datetime")
                    .HasColumnName("cds_date");

                entity.Property(e => e.TradInstTypeCode).HasColumnName("tradInstType_code");

                entity.Property(e => e.TradInstCode).HasColumnName("tradInst_code");

                entity.Property(e => e.CdsAccountNo).HasColumnName("cds_accountNo");

                entity.Property(e => e.CdsAvailable)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("cds_available");

                entity.Property(e => e.CdsBlocked)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("cds_blocked");

                entity.Property(e => e.CdsParticipantId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cds_participantID");

                entity.Property(e => e.CdsPledged)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("cds_pledged");

                entity.Property(e => e.CdsPledgedIn)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("cds_pledgedIn");

                entity.Property(e => e.CdsPledgedOut)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("cds_pledgedOut");

                entity.Property(e => e.CdsPositionOwned)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("cds_positionOwned");

                entity.HasOne(d => d.FundMasterCodeNavigation)
                    .WithMany(p => p.PmsCdsholdings)
                    .HasForeignKey(d => d.FundMasterCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_pms_CDSHolding_pms_fundMaster");
            });

            modelBuilder.Entity<PmsCertificate>(entity =>
            {
                entity.HasKey(e => new { e.CertCode, e.TradInstTypeCode });

                entity.ToTable("pms_certificates");

                entity.Property(e => e.CertCode).HasColumnName("cert_code");

                entity.Property(e => e.TradInstTypeCode).HasColumnName("tradInstType_code");

                entity.Property(e => e.CertAmount)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("cert_amount");

                entity.Property(e => e.CertBranchCode).HasColumnName("cert_branchCode");

                entity.Property(e => e.CertIssuance).HasColumnName("cert_issuance");

                entity.Property(e => e.CertIssueDate)
                    .HasColumnType("datetime")
                    .HasColumnName("cert_issueDate");

                entity.Property(e => e.CertMaturityDate)
                    .HasColumnType("datetime")
                    .HasColumnName("cert_maturityDate");

                entity.Property(e => e.CertName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cert_name");

                entity.Property(e => e.CertNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cert_no");

                entity.Property(e => e.CertRollOver).HasColumnName("cert_rollOver");

                entity.Property(e => e.CertYears).HasColumnName("CERT_YEARS");

                entity.HasOne(d => d.TradInstTypeCodeNavigation)
                    .WithMany(p => p.PmsCertificates)
                    .HasForeignKey(d => d.TradInstTypeCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_pms_tradingInstrumentTypes");
            });

            modelBuilder.Entity<PmsCfstradeLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pms_CFSTradeLogs");

                entity.Property(e => e.CfsBrokerCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CFS_brokerCode");

                entity.Property(e => e.CfsClient)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CFS_client");

                entity.Property(e => e.CfsCode).HasColumnName("CFS_code");

                entity.Property(e => e.CfsDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CFS_Date");

                entity.Property(e => e.CfsDays).HasColumnName("CFS_days");

                entity.Property(e => e.CfsEffectiveDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CFS_effectiveDate");

                entity.Property(e => e.CfsExposureRate)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("CFS_exposureRate");

                entity.Property(e => e.CfsFileType).HasColumnName("CFS_fileType");

                entity.Property(e => e.CfsGainRate)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("CFS_gainRate");

                entity.Property(e => e.CfsKatsTicketNo)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("CFS_katsTicketNo");

                entity.Property(e => e.CfsModfyidate)
                    .HasColumnType("datetime")
                    .HasColumnName("CFS_modfyidate");

                entity.Property(e => e.CfsModifyBy).HasColumnName("CFS_modifyBy");

                entity.Property(e => e.CfsOrderNo)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("CFS_orderNo");

                entity.Property(e => e.CfsOrderType)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CFS_orderType");

                entity.Property(e => e.CfsPremiumPer)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("CFS_premiumPer");

                entity.Property(e => e.CfsPremiumRate)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("CFS_premiumRate");

                entity.Property(e => e.CfsProcessState).HasColumnName("CFS_processState");

                entity.Property(e => e.CfsPurPrice)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("CFS_purPrice");

                entity.Property(e => e.CfsRelCode).HasColumnName("CFS_relCode");

                entity.Property(e => e.CfsSymbol)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CFS_symbol");

                entity.Property(e => e.CfsSystemId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CFS_systemId");

                entity.Property(e => e.CfsTradeEntryDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CFS_tradeEntryDate");

                entity.Property(e => e.CfsTradeNo)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("CFS_tradeNo");

                entity.Property(e => e.CfsTradeQty)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("CFS_tradeQty");

                entity.Property(e => e.FundMasterCode).HasColumnName("fundMaster_code");
            });

            modelBuilder.Entity<PmsCgtconfig>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pms_CGTConfig");

                entity.Property(e => e.CalYearCode).HasColumnName("calYear_code");

                entity.Property(e => e.CgtAdvRate)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("CGT_advRate");

                entity.Property(e => e.CgtCode).HasColumnName("CGT_code");

                entity.Property(e => e.CgtCreatedBy).HasColumnName("CGT_createdBy");

                entity.Property(e => e.CgtCreatedWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("CGT_createdWhen");

                entity.Property(e => e.CgtFromDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CGT_FromDate");

                entity.Property(e => e.CgtFundType).HasColumnName("CGT_fundType");

                entity.Property(e => e.CgtModifiedBy).HasColumnName("CGT_modifiedBy");

                entity.Property(e => e.CgtModifiedWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("CGT_modifiedWhen");

                entity.Property(e => e.CgtModuleType).HasColumnName("CGT_moduleType");

                entity.Property(e => e.CgtSlabFrom).HasColumnName("CGT_slabFrom");

                entity.Property(e => e.CgtSlabTo).HasColumnName("CGT_slabTo");

                entity.Property(e => e.CgtTaxRate)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("CGT_taxRate");

                entity.Property(e => e.CgtToDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CGT_ToDate");

                entity.Property(e => e.CgtYear).HasColumnName("CGT_year");
            });

            modelBuilder.Entity<PmsCity>(entity =>
            {
                entity.HasKey(e => e.CityCode);

                entity.ToTable("pms_city");

                entity.Property(e => e.CityCode)
                    .ValueGeneratedNever()
                    .HasColumnName("city_code");

                entity.Property(e => e.CityName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("city_name");

                entity.Property(e => e.CounCode).HasColumnName("coun_code");
            });

            modelBuilder.Entity<PmsClearingCompany>(entity =>
            {
                entity.HasKey(e => e.ClearingCompCode);

                entity.ToTable("pms_clearingCompanies");

                entity.Property(e => e.ClearingCompCode)
                    .ValueGeneratedNever()
                    .HasColumnName("clearingComp_code");

                entity.Property(e => e.ClearingCompAddress)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("clearingComp_address");

                entity.Property(e => e.ClearingCompDesc)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("clearingComp_desc");

                entity.Property(e => e.ClearingCompEmail)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("clearingComp_email");

                entity.Property(e => e.ClearingCompFax)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("clearingComp_fax");

                entity.Property(e => e.ClearingCompIsActive).HasColumnName("clearingComp_isActive");

                entity.Property(e => e.ClearingCompMnemonic)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("clearingComp_mnemonic");

                entity.Property(e => e.ClearingCompName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("clearingComp_name");

                entity.Property(e => e.ClearingCompPhone)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("clearingComp_phone");

                entity.Property(e => e.FInstBranchCode).HasColumnName("fInstBranch_code");
            });

            modelBuilder.Entity<PmsClrCompanyRate>(entity =>
            {
                entity.HasKey(e => new { e.ClearingCompCode, e.ClrCompRateTradeMode, e.TradInstTypeCode, e.ClrCompRateCode });

                entity.ToTable("pms_clrCompanyRates");

                entity.Property(e => e.ClearingCompCode).HasColumnName("clearingComp_Code");

                entity.Property(e => e.ClrCompRateTradeMode).HasColumnName("clrCompRate_tradeMode");

                entity.Property(e => e.TradInstTypeCode).HasColumnName("tradInstType_code");

                entity.Property(e => e.ClrCompRateCode).HasColumnName("clrCompRate_code");

                entity.Property(e => e.ClrCompRateRateInAmount)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("clrCompRate_rateInAmount");

                entity.Property(e => e.ClrCompRateRateInPercent)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("clrCompRate_rateInPercent");

                entity.HasOne(d => d.ClearingCompCodeNavigation)
                    .WithMany(p => p.PmsClrCompanyRates)
                    .HasForeignKey(d => d.ClearingCompCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_pms_clrCompanyRates_pms_clearingCompanies");

                entity.HasOne(d => d.TradInstTypeCodeNavigation)
                    .WithMany(p => p.PmsClrCompanyRates)
                    .HasForeignKey(d => d.TradInstTypeCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_pms_clrCompanyRates_pms_tradingInstrumentTypes");
            });

            modelBuilder.Entity<PmsCoi>(entity =>
            {
                entity.HasKey(e => e.CoiCode)
                    .HasName("PK__pms_COI__1F63A897");

                entity.ToTable("pms_COI");

                entity.Property(e => e.CoiCode)
                    .ValueGeneratedNever()
                    .HasColumnName("coi_code");

                entity.Property(e => e.BrokerCode).HasColumnName("broker_code");

                entity.Property(e => e.CoiAccrualBasis).HasColumnName("coi_accrualBasis");

                entity.Property(e => e.CoiBrokerRate)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("coi_brokerRate");

                entity.Property(e => e.CoiBrokerRateMode).HasColumnName("coi_brokerRateMode");

                entity.Property(e => e.CoiBrokerage)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("coi_brokerage");

                entity.Property(e => e.CoiChkDeliveryDate)
                    .HasColumnType("datetime")
                    .HasColumnName("coi_chkDeliveryDate");

                entity.Property(e => e.CoiCounterParty)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("coi_counterParty");

                entity.Property(e => e.CoiCouponRatePerAnnum)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("coi_couponRatePerAnnum");

                entity.Property(e => e.CoiCouponsQty).HasColumnName("coi_couponsQty");

                entity.Property(e => e.CoiDaysType)
                    .HasColumnName("coi_daysType")
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.CoiFaceValue)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("coi_faceValue");

                entity.Property(e => e.CoiIssueDate)
                    .HasColumnType("datetime")
                    .HasColumnName("coi_issueDate");

                entity.Property(e => e.CoiListed).HasColumnName("coi_listed");

                entity.Property(e => e.CoiMaturityDate)
                    .HasColumnType("datetime")
                    .HasColumnName("coi_maturityDate");

                entity.Property(e => e.CoiMaturityPeriod).HasColumnName("coi_maturityPeriod");

                entity.Property(e => e.CoiName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("coi_name");

                entity.Property(e => e.CoiPlacedate)
                    .HasColumnType("datetime")
                    .HasColumnName("coi_placedate");

                entity.Property(e => e.CoiTransactionType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("coi_transactionType");

                entity.Property(e => e.CoiTrustee)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("coi_trustee");

                entity.Property(e => e.FInstBranchCode).HasColumnName("fInstBranch_code");

                entity.Property(e => e.FInstCode).HasColumnName("fInst_code");

                entity.Property(e => e.FInstTypeCode).HasColumnName("fInstType_code");

                entity.Property(e => e.FundCode).HasColumnName("fund_code");

                entity.Property(e => e.ShareCode).HasColumnName("share_Code");

                entity.Property(e => e.TradInstTypeCode).HasColumnName("tradInstType_code");

                entity.HasOne(d => d.BrokerCodeNavigation)
                    .WithMany(p => p.PmsCois)
                    .HasForeignKey(d => d.BrokerCode)
                    .HasConstraintName("FK_pms_COI_pms_brokers");

                entity.HasOne(d => d.FundCodeNavigation)
                    .WithMany(p => p.PmsCois)
                    .HasForeignKey(d => d.FundCode)
                    .HasConstraintName("FK_pms_COI_pms_funds");

                entity.HasOne(d => d.ShareCodeNavigation)
                    .WithMany(p => p.PmsCois)
                    .HasForeignKey(d => d.ShareCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__pms_COI__share_C__214BF109");

                entity.HasOne(d => d.TradInstTypeCodeNavigation)
                    .WithMany(p => p.PmsCois)
                    .HasForeignKey(d => d.TradInstTypeCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__pms_COI__tradIns__22401542");
            });

            modelBuilder.Entity<PmsCompFinanceDatum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pms_compFinanceData");

                entity.Property(e => e.CompFinCode).HasColumnName("compFin_code");

                entity.Property(e => e.CompFinDesc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("compFin_desc");

                entity.Property(e => e.CompFinDps)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("compFin_Dps");

                entity.Property(e => e.CompFinDpsDate)
                    .HasColumnType("datetime")
                    .HasColumnName("compFinDps_date");

                entity.Property(e => e.CompFinEps)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("compFin_eps");

                entity.Property(e => e.CompFinEpsDate)
                    .HasColumnType("datetime")
                    .HasColumnName("compFinEps_date");

                entity.Property(e => e.CompFinEquity)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("compFin_Equity");

                entity.Property(e => e.CompFinEquityDate)
                    .HasColumnType("datetime")
                    .HasColumnName("compFinEquity_date");

                entity.Property(e => e.CompFinNav)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("compFin_nav");

                entity.Property(e => e.CompFinNavDate)
                    .HasColumnType("datetime")
                    .HasColumnName("compFinNav_date");

                entity.Property(e => e.CompFinPe)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("compFin_pe");

                entity.Property(e => e.CompFinPeDate)
                    .HasColumnType("datetime")
                    .HasColumnName("compFinPe_date");

                entity.Property(e => e.CompFinRating)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("compFin_rating");

                entity.Property(e => e.CompFinRatingDate)
                    .HasColumnType("datetime")
                    .HasColumnName("compFinRating_date");

                entity.Property(e => e.CompFinVaR)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("compFin_VaR");

                entity.Property(e => e.CompFinVaRDate)
                    .HasColumnType("datetime")
                    .HasColumnName("compFinVaR_date");

                entity.Property(e => e.CrRatCompCode).HasColumnName("crRatComp_code");

                entity.Property(e => e.CrRatCompDate)
                    .HasColumnType("datetime")
                    .HasColumnName("crRatComp_date");

                entity.Property(e => e.CrRatCompRating)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("crRatComp_rating");

                entity.Property(e => e.TradInstCode).HasColumnName("tradInst_code");

                entity.Property(e => e.TradInstTypeCode).HasColumnName("tradInstType_code");
            });

            modelBuilder.Entity<PmsCompFundControl>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pms_compFundControls");

                entity.Property(e => e.CompFundCode).HasColumnName("compFund_code");

                entity.Property(e => e.CompFundDate)
                    .HasColumnType("datetime")
                    .HasColumnName("compFund_date");

                entity.Property(e => e.CompFundDesc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("compFund_desc");

                entity.Property(e => e.CompFundEntryPrice)
                    .HasColumnType("decimal(25, 2)")
                    .HasColumnName("compFund_entryPrice");

                entity.Property(e => e.CompFundExitPrice)
                    .HasColumnType("decimal(25, 2)")
                    .HasColumnName("compFund_exitPrice");

                entity.Property(e => e.CompFundNature).HasColumnName("compFund_nature");

                entity.Property(e => e.CompFundYield)
                    .HasColumnType("decimal(25, 2)")
                    .HasColumnName("compFund_yield");

                entity.Property(e => e.FundMasterCode).HasColumnName("fundMaster_code");

                entity.Property(e => e.TradInstCode).HasColumnName("tradInst_code");

                entity.Property(e => e.TradInstTypeCode).HasColumnName("tradInstType_code");
            });

            modelBuilder.Entity<PmsCountry>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pms_country");

                entity.Property(e => e.CounCode).HasColumnName("coun_code");

                entity.Property(e => e.CounName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("coun_name");

                entity.Property(e => e.CounSymbol)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("coun_symbol");

                entity.Property(e => e.CurrCode).HasColumnName("curr_code");
            });

            modelBuilder.Entity<PmsCoupon>(entity =>
            {
                entity.HasKey(e => new { e.CouponCode, e.TradInstTypeCode, e.TradInstCode })
                    .HasName("PK__pms_Coupons__540C7B00");

                entity.ToTable("pms_Coupons");

                entity.Property(e => e.CouponCode).HasColumnName("coupon_code");

                entity.Property(e => e.TradInstTypeCode).HasColumnName("tradInstType_code");

                entity.Property(e => e.TradInstCode).HasColumnName("tradInst_code");

                entity.Property(e => e.CouponCreatedBy).HasColumnName("Coupon_CreatedBy");

                entity.Property(e => e.CouponCreatedWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("Coupon_CreatedWhen");

                entity.Property(e => e.CouponDate)
                    .HasColumnType("datetime")
                    .HasColumnName("coupon_date");

                entity.Property(e => e.CouponIsLinked).HasColumnName("coupon_isLinked");

                entity.Property(e => e.CouponMatfundMaster)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("coupon_matfundMaster");

                entity.Property(e => e.CouponMatpayrealised)
                    .HasColumnType("datetime")
                    .HasColumnName("coupon_matpayrealised");

                entity.Property(e => e.CouponMatpayrealisedType).HasColumnName("coupon_matpayrealisedType");

                entity.Property(e => e.CouponMatsettBank)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("coupon_matsettBank");

                entity.Property(e => e.CouponModifiedBy).HasColumnName("Coupon_ModifiedBy");

                entity.Property(e => e.CouponModifiedWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("Coupon_ModifiedWhen");

                entity.Property(e => e.CouponPrincipalRedeem)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("coupon_principalRedeem");

                entity.Property(e => e.CouponRateType).HasColumnName("coupon_rateType");

                entity.Property(e => e.CouponRates)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("coupon_rates");

                entity.Property(e => e.CouponSpreadRate)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("coupon_spreadRate");

                entity.Property(e => e.CouponState).HasColumnName("coupon_state");

                entity.Property(e => e.CouponSuspended).HasColumnName("coupon_suspended");

                entity.Property(e => e.CouponUpdate)
                    .HasColumnName("coupon_update")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CouponZakat)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("coupon_zakat");

                entity.HasOne(d => d.TradInstTypeCodeNavigation)
                    .WithMany(p => p.PmsCoupons)
                    .HasForeignKey(d => d.TradInstTypeCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__pms_Coupo__tradI__57DD0BE4");
            });

            modelBuilder.Entity<PmsCouponDetail>(entity =>
            {
                entity.HasKey(e => new { e.CouponCode, e.TradInstTypeCode, e.TradInstCode, e.CouponDate, e.CouponSuspendeddate });

                entity.ToTable("pms_CouponDetail");

                entity.Property(e => e.CouponCode).HasColumnName("coupon_code");

                entity.Property(e => e.TradInstTypeCode).HasColumnName("tradInstType_code");

                entity.Property(e => e.TradInstCode).HasColumnName("tradInst_code");

                entity.Property(e => e.CouponDate)
                    .HasColumnType("datetime")
                    .HasColumnName("coupon_date");

                entity.Property(e => e.CouponSuspendeddate)
                    .HasColumnType("datetime")
                    .HasColumnName("coupon_suspendeddate");

                entity.Property(e => e.CouponSuspended).HasColumnName("coupon_suspended");

                entity.Property(e => e.CpndetailModifyWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("cpndetail_modifyWhen");

                entity.Property(e => e.CpndetailModifyby).HasColumnName("cpndetail_modifyby");
            });

            modelBuilder.Entity<PmsCouponRealisedDetail>(entity =>
            {
                entity.HasKey(e => new { e.CouponCode, e.TradinstTypeCode, e.TradInstCode, e.FundMasterCode });

                entity.ToTable("pms_couponRealisedDetail");

                entity.Property(e => e.CouponCode).HasColumnName("coupon_code");

                entity.Property(e => e.TradinstTypeCode).HasColumnName("tradinstType_code");

                entity.Property(e => e.TradInstCode).HasColumnName("tradInst_code");

                entity.Property(e => e.FundMasterCode).HasColumnName("fundMaster_code");

                entity.Property(e => e.CrCreatedBy).HasColumnName("CR_createdBy");

                entity.Property(e => e.CrCreatedWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("CR_createdWhen");

                entity.Property(e => e.CrDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CR_date");

                entity.Property(e => e.CrModifiedBy).HasColumnName("CR_modifiedBy");

                entity.Property(e => e.CrModifiedWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("CR_modifiedWhen");

                entity.Property(e => e.FInstBranchCode).HasColumnName("fInstBranch_code");
            });

            modelBuilder.Entity<PmsCouponTaxApplied>(entity =>
            {
                entity.HasKey(e => new { e.CouponCode, e.TradInstTypeCode, e.TradInstCode, e.OrdExecDealTickNo });

                entity.ToTable("pms_couponTaxApplied");

                entity.Property(e => e.CouponCode).HasColumnName("coupon_code");

                entity.Property(e => e.TradInstTypeCode).HasColumnName("tradInstType_code");

                entity.Property(e => e.TradInstCode).HasColumnName("tradInst_code");

                entity.Property(e => e.OrdExecDealTickNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ordExec_DealTickNo");

                entity.Property(e => e.CtaAmount)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("CTA_amount");

                entity.Property(e => e.CtaCreatedBy).HasColumnName("CTA_createdBy");

                entity.Property(e => e.CtaCreatedWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("CTA_createdWhen");

                entity.Property(e => e.CtaIsApplied).HasColumnName("CTA_IsApplied");

                entity.Property(e => e.CtaModifiedBy).HasColumnName("CTA_modifiedBy");

                entity.Property(e => e.CtaModifiedWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("CTA_modifiedWhen");
            });

            modelBuilder.Entity<PmsCouponToleranceRate>(entity =>
            {
                entity.HasKey(e => new { e.CouponToleranceRateSno, e.CouponToleranceRateDate, e.TradinstTypeCode, e.TradinstCode })
                    .HasName("pms_couponToleranceRate_pk");

                entity.ToTable("pms_couponToleranceRate");

                entity.Property(e => e.CouponToleranceRateSno).HasColumnName("couponToleranceRate_sno");

                entity.Property(e => e.CouponToleranceRateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("couponToleranceRate_date");

                entity.Property(e => e.TradinstTypeCode).HasColumnName("tradinstType_code");

                entity.Property(e => e.TradinstCode).HasColumnName("Tradinst_code");

                entity.Property(e => e.CouponTolRateCreatedBy).HasColumnName("couponTolRate_createdBy");

                entity.Property(e => e.CouponTolRateCreatedWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("couponTolRate_createdWhen");

                entity.Property(e => e.CouponTolRateModifiedBy).HasColumnName("couponTolRate_modifiedBy");

                entity.Property(e => e.CouponTolRateModifiedWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("couponTolRate_modifiedWhen");

                entity.Property(e => e.CouponTolRateRate)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("couponTolRate_rate");

                entity.Property(e => e.CouponToleranceRateIsActive).HasColumnName("couponToleranceRate_isActive");

                entity.Property(e => e.ProductCode).HasColumnName("Product_code");
            });

            modelBuilder.Entity<PmsCrFinstFinStatTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pmsCR_finstFinStatTemp");

                entity.Property(e => e.FinstFinStatTempDec)
                    .IsUnicode(false)
                    .HasColumnName("finstFinStatTemp_dec");

                entity.Property(e => e.FinstFinStatTempEnum)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("finstFinStatTemp_Enum");

                entity.Property(e => e.FinstFinStatTempHeadType).HasColumnName("finstFinStatTemp_HeadType");

                entity.Property(e => e.FinstFinStatTempSno).HasColumnName("finstFinStatTemp_sno");
            });

            modelBuilder.Entity<PmsCrFinstFinStatTmpDtl>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pmsCR_finstFinStatTmpDtl");

                entity.Property(e => e.CalYearCode).HasColumnName("calYear_code");

                entity.Property(e => e.FInstCode).HasColumnName("fInst_code");

                entity.Property(e => e.FInstTypeCode).HasColumnName("fInstType_code");

                entity.Property(e => e.FinstFinStatTempEnum)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("finstFinStatTemp_Enum");

                entity.Property(e => e.FinstFinStatTempHeadType).HasColumnName("finstFinStatTemp_HeadType");

                entity.Property(e => e.FinstFinStatTmpDtlCreatedBy).HasColumnName("finstFinStatTmpDtl_createdBy");

                entity.Property(e => e.FinstFinStatTmpDtlCreatedWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("finstFinStatTmpDtl_createdWhen");

                entity.Property(e => e.FinstFinStatTmpDtlDate)
                    .HasColumnType("datetime")
                    .HasColumnName("finstFinStatTmpDtl_Date");

                entity.Property(e => e.FinstFinStatTmpDtlModifyBy).HasColumnName("finstFinStatTmpDtl_modifyBy");

                entity.Property(e => e.FinstFinStatTmpDtlModifyWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("finstFinStatTmpDtl_modifyWhen");

                entity.Property(e => e.FinstFinStatTmpDtlValue)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("finstFinStatTmpDtl_Value");
            });

            modelBuilder.Entity<PmsCreditRating>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pms_creditRating");

                entity.Property(e => e.CrRatCompCode).HasColumnName("crRatComp_code");

                entity.Property(e => e.CrRatingCode).HasColumnName("crRating_code");

                entity.Property(e => e.CrRatingDate)
                    .HasColumnType("datetime")
                    .HasColumnName("crRating_date");

                entity.Property(e => e.CrRatingEntityCode).HasColumnName("crRating_entityCode");

                entity.Property(e => e.CrRatingModifyWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("crRating_ModifyWhen");

                entity.Property(e => e.CrRatingModifyby)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("crRating_Modifyby");

                entity.Property(e => e.CrRatingRating)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("crRating_rating");

                entity.Property(e => e.CrRatingScore)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("crRating_score");

                entity.Property(e => e.CrRatingType).HasColumnName("crRating_type");

                entity.Property(e => e.FinstTypeCode).HasColumnName("finstType_code");

                entity.Property(e => e.TradInstTypeCode).HasColumnName("tradInstType_code");
            });

            modelBuilder.Entity<PmsCreditRatingCompany>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pms_creditRatingCompanies");

                entity.Property(e => e.CrRatCompCode).HasColumnName("crRatComp_code");

                entity.Property(e => e.CrRatCompDesc)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("crRatComp_desc");

                entity.Property(e => e.CrRatCompName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("crRatComp_name");

                entity.Property(e => e.CrRatCompRating)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("crRatComp_rating");
            });

            modelBuilder.Entity<PmsCreditRatingEntity>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pms_creditRatingEntity");

                entity.Property(e => e.CrRatCompCode).HasColumnName("crRatComp_code");

                entity.Property(e => e.CrRatingCode).HasColumnName("crRating_code");

                entity.Property(e => e.CrRatingType).HasColumnName("crRating_type");

                entity.Property(e => e.CreditRatingEntityDesc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("creditRatingEntity_desc");

                entity.Property(e => e.CreditRatingEntityEntityCode).HasColumnName("creditRatingEntity_entityCode");

                entity.Property(e => e.CreditRatingEntityEntityType).HasColumnName("creditRatingEntity_entityType");

                entity.Property(e => e.CreditRatingEntitySno).HasColumnName("creditRatingEntity_SNO");

                entity.Property(e => e.RatingCode).HasColumnName("rating_code");
            });

            modelBuilder.Entity<PmsCrrslr>(entity =>
            {
                entity.HasKey(e => new { e.FundMasterCode, e.CrrslrDate, e.CrrslrSno });

                entity.ToTable("pms_CRRSLR");

                entity.Property(e => e.FundMasterCode).HasColumnName("fundMaster_code");

                entity.Property(e => e.CrrslrDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CRRSLR_date");

                entity.Property(e => e.CrrslrSno).HasColumnName("CRRSLR_SNO");

                entity.Property(e => e.AbCostOfInv)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("AB_CostOfInv");

                entity.Property(e => e.AbFaceValue)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("AB_faceValue");

                entity.Property(e => e.AbMktValue)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("AB_MktValue");

                entity.Property(e => e.AbPibvalue)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("AB_PIBValue");

                entity.Property(e => e.AbSlrvalue)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("AB_SLRValue");

                entity.Property(e => e.BankFundCapital)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("bankFund_capital");

                entity.Property(e => e.Crramount)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("CRRAmount");

                entity.Property(e => e.CrrslrCreatedBy).HasColumnName("CRRSLR_createdBy");

                entity.Property(e => e.CrrslrCreatedWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("CRRSLR_createdWhen");

                entity.Property(e => e.CrrslrMaintainDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CRRSLR_maintainDate");

                entity.Property(e => e.FInstCode).HasColumnName("fInst_code");

                entity.Property(e => e.FInstTranRefNo)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("fInstTran_RefNo");

                entity.Property(e => e.FInstTranType).HasColumnName("fInstTran_type");

                entity.Property(e => e.FInstTypeCode).HasColumnName("fInstType_code");

                entity.Property(e => e.FaceValue)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("faceValue");

                entity.Property(e => e.FinstTranMode).HasColumnName("finstTran_mode");

                entity.Property(e => e.GlDetailAccCode)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("glDetail_accCode");

                entity.Property(e => e.GlDetailEntityCode).HasColumnName("glDetail_entityCode");

                entity.Property(e => e.GlHeadAccTitle)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("glHead_accTitle");

                entity.Property(e => e.GlHeadAccType).HasColumnName("glHead_accType");

                entity.Property(e => e.GlHeadEntityType).HasColumnName("glHead_entityType");

                entity.Property(e => e.IsVerifySbp).HasColumnName("isVerifySBP");

                entity.Property(e => e.MktValue).HasColumnType("decimal(25, 6)");

                entity.Property(e => e.OrdExecDealTickNo)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ordExec_dealTickNo");

                entity.Property(e => e.PerCrr)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("Per_CRR");

                entity.Property(e => e.PerPib)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("Per_PIB");

                entity.Property(e => e.PerPibamount)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("Per_PIBAmount");

                entity.Property(e => e.PerSlr)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("Per_SLR");

                entity.Property(e => e.ProductName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("product_name");

                entity.Property(e => e.Slramount)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("SLRAmount");

                entity.Property(e => e.Tdlamount)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("TDLAmount");

                entity.Property(e => e.TotalCapital).HasColumnType("decimal(25, 6)");

                entity.Property(e => e.TradInstTypeCode).HasColumnName("tradInstType_code");
            });

            modelBuilder.Entity<PmsCurrency>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pms_currencies");

                entity.Property(e => e.CurrBaseCurrency).HasColumnName("curr_baseCurrency");

                entity.Property(e => e.CurrCode).HasColumnName("curr_code");

                entity.Property(e => e.CurrCountry)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("curr_country");

                entity.Property(e => e.CurrName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("curr_Name");

                entity.Property(e => e.CurrSign)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("curr_sign");

                entity.Property(e => e.CurrSymbol)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("curr_symbol");
            });

            modelBuilder.Entity<PmsCustodian>(entity =>
            {
                entity.HasKey(e => e.CustodianCode);

                entity.ToTable("pms_custodians");

                entity.HasIndex(e => e.CustodianName, "IX_pms_custodians")
                    .IsUnique();

                entity.Property(e => e.CustodianCode)
                    .ValueGeneratedNever()
                    .HasColumnName("custodian_code");

                entity.Property(e => e.CityCode).HasColumnName("city_code");

                entity.Property(e => e.CounCode).HasColumnName("coun_code");

                entity.Property(e => e.CustodianAccNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("custodian_AccNo");

                entity.Property(e => e.CustodianAddress)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("custodian_address");

                entity.Property(e => e.CustodianCdsaccNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("custodian_CDSAccNo");

                entity.Property(e => e.CustodianConPerson)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("custodian_conPerson");

                entity.Property(e => e.CustodianDescription)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("custodian_description");

                entity.Property(e => e.CustodianName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("custodian_name");

                entity.Property(e => e.CustodianPartAccNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("custodian_partAccNo");
            });

            modelBuilder.Entity<PmsCustomersAccount>(entity =>
            {
                entity.HasKey(e => new { e.CustomerCode, e.FundMasterCode, e.BrokerCode });

                entity.ToTable("pms_CustomersAccounts");

                entity.Property(e => e.CustomerCode).HasColumnName("Customer_Code");

                entity.Property(e => e.FundMasterCode).HasColumnName("FundMaster_code");

                entity.Property(e => e.BrokerCode).HasColumnName("Broker_code");

                entity.Property(e => e.CityName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("city_name");

                entity.Property(e => e.CountryName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("country_name");

                entity.Property(e => e.CustomerAddress1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Customer_address1");

                entity.Property(e => e.CustomerAddress2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Customer_address2");

                entity.Property(e => e.CustomerCardNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Customer_cardNo");

                entity.Property(e => e.CustomerCreationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Customer_creationDate");

                entity.Property(e => e.CustomerEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Customer_email");

                entity.Property(e => e.CustomerFaxes)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Customer_faxes");

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Customer_name");

                entity.Property(e => e.CustomerNationality)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Customer_nationality");

                entity.Property(e => e.CustomerPhone1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Customer_phone1");

                entity.Property(e => e.CustomerPhone2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Customer_phone2");

                entity.Property(e => e.CustomerPinCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Customer_pinCode");

                entity.Property(e => e.CustomerPostCode).HasColumnName("Customer_postCode");

                entity.HasOne(d => d.BrokerCodeNavigation)
                    .WithMany(p => p.PmsCustomersAccounts)
                    .HasForeignKey(d => d.BrokerCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_pms_CustomersAccounts_pms_brokers");

                entity.HasOne(d => d.FundMasterCodeNavigation)
                    .WithMany(p => p.PmsCustomersAccounts)
                    .HasForeignKey(d => d.FundMasterCode)
                    .HasConstraintName("FK_pms_CustomersAccounts_pms_fundMaster");
            });

            modelBuilder.Entity<PmsDailyCurrency>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pms_dailyCurrency");

                entity.Property(e => e.CurrCode).HasColumnName("curr_code");

                entity.Property(e => e.DcurrBaseCurrency).HasColumnName("dcurr_baseCurrency");

                entity.Property(e => e.DcurrBuying)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("dcurr_buying");

                entity.Property(e => e.DcurrDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dcurr_date");

                entity.Property(e => e.DcurrSelling)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("dcurr_selling");
            });

            modelBuilder.Entity<PmsDailyFmrdatum>(entity =>
            {
                entity.HasKey(e => new { e.FundMasterCode, e.TradInstTypeCode, e.InstrumentCode, e.FundCode, e.ProductCode, e.DailyFmrReportDate })
                    .HasName("PK_pms_dailyFMRDate");

                entity.ToTable("pms_dailyFMRData");

                entity.Property(e => e.FundMasterCode).HasColumnName("fundMaster_code");

                entity.Property(e => e.TradInstTypeCode).HasColumnName("tradInstType_Code");

                entity.Property(e => e.InstrumentCode).HasColumnName("Instrument_code");

                entity.Property(e => e.FundCode).HasColumnName("fund_code");

                entity.Property(e => e.ProductCode).HasColumnName("Product_code");

                entity.Property(e => e.DailyFmrReportDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dailyFMR_ReportDate");

                entity.Property(e => e.Accrual).HasColumnType("numeric(25, 6)");

                entity.Property(e => e.AverageCost100).HasColumnType("numeric(25, 6)");

                entity.Property(e => e.CreditRating)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("credit_rating");

                entity.Property(e => e.DailyFmrCreatedBy).HasColumnName("dailyFMR_createdBy");

                entity.Property(e => e.DailyFmrCreatedWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("dailyFMR_createdWhen");

                entity.Property(e => e.DailyFmrIsVerified).HasColumnName("dailyFMR_IsVerified");

                entity.Property(e => e.DailyFmrModifyBy).HasColumnName("dailyFMR_ModifyBy");

                entity.Property(e => e.DailyFmrModifyWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("dailyFMR_ModifyWhen");

                entity.Property(e => e.FInstName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("fInst_name");

                entity.Property(e => e.FaceValue).HasColumnType("numeric(25, 6)");

                entity.Property(e => e.FundMasterName)
                    .IsRequired()
                    .HasMaxLength(225)
                    .IsUnicode(false)
                    .HasColumnName("fundMaster_name");

                entity.Property(e => e.FundMnemonic)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fund_mnemonic");

                entity.Property(e => e.FundName)
                    .IsRequired()
                    .HasMaxLength(225)
                    .IsUnicode(false)
                    .HasColumnName("fund_name");

                entity.Property(e => e.GroupRating)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InstYield).HasColumnType("numeric(25, 6)");

                entity.Property(e => e.InstrumentCouponRate)
                    .HasColumnType("numeric(25, 6)")
                    .HasColumnName("Instrument_CouponRate");

                entity.Property(e => e.InstrumentIssueDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Instrument_IssueDate");

                entity.Property(e => e.InstrumentMaturityDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Instrument_MaturityDate");

                entity.Property(e => e.InstrumentName)
                    .IsRequired()
                    .HasMaxLength(225)
                    .IsUnicode(false)
                    .HasColumnName("Instrument_Name");

                entity.Property(e => e.InstrumentTenor).HasColumnName("Instrument_Tenor");

                entity.Property(e => e.LastCpnDate).HasColumnType("datetime");

                entity.Property(e => e.MarketAvgAmt)
                    .HasColumnType("numeric(25, 6)")
                    .HasColumnName("Market_AvgAmt");

                entity.Property(e => e.MarketDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Market_Date");

                entity.Property(e => e.MarketRate)
                    .HasColumnType("numeric(25, 6)")
                    .HasColumnName("Market_Rate");

                entity.Property(e => e.MovAvgAmtMov)
                    .HasColumnType("numeric(25, 6)")
                    .HasColumnName("movAvg_amtMov");

                entity.Property(e => e.MovAvgAverage)
                    .HasColumnType("numeric(25, 6)")
                    .HasColumnName("movAvg_average");

                entity.Property(e => e.MovAvgTranDate)
                    .HasColumnType("datetime")
                    .HasColumnName("movAvg_tranDate");

                entity.Property(e => e.MufapPrice100).HasColumnType("numeric(25, 6)");

                entity.Property(e => e.Nav).HasColumnType("numeric(25, 6)");

                entity.Property(e => e.NavAmount)
                    .HasColumnType("numeric(25, 6)")
                    .HasColumnName("NAV_amount");

                entity.Property(e => e.NavDate)
                    .HasColumnType("datetime")
                    .HasColumnName("NAV_Date");

                entity.Property(e => e.NextCpnDate).HasColumnType("datetime");

                entity.Property(e => e.NumberofUnits).HasColumnType("numeric(25, 6)");

                entity.Property(e => e.Pkrv)
                    .HasColumnType("numeric(25, 6)")
                    .HasColumnName("PKRV");

                entity.Property(e => e.PkrvAvgYield)
                    .HasColumnType("numeric(25, 6)")
                    .HasColumnName("Pkrv_avgYield");

                entity.Property(e => e.ProductName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Product_Name");

                entity.Property(e => e.ProtfolioRating)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Quantity).HasColumnType("numeric(25, 6)");

                entity.Property(e => e.Redeem).HasColumnType("numeric(25, 6)");

                entity.Property(e => e.TotalDays).HasColumnType("numeric(25, 6)");

                entity.Property(e => e.TranTypeName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("tranType_name");

                entity.Property(e => e.WeightAverage).HasColumnType("numeric(25, 6)");

                entity.Property(e => e.Yield).HasColumnType("numeric(25, 6)");
            });

            modelBuilder.Entity<PmsDailyFundPosition>(entity =>
            {
                entity.HasKey(e => new { e.FundMasterCode, e.DailyFundPositionDate, e.DailyFundPositionSno });

                entity.ToTable("pms_dailyFundPosition");

                entity.Property(e => e.FundMasterCode).HasColumnName("fundMaster_code");

                entity.Property(e => e.DailyFundPositionDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dailyFundPosition_date");

                entity.Property(e => e.DailyFundPositionSno)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("dailyFundPosition_SNo");

                entity.Property(e => e.BankFundAccrualBasis)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("bankFund_accrualBasis");

                entity.Property(e => e.BankFundCapital)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("bankFund_capital");

                entity.Property(e => e.BankFundMarkUp)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("bankFund_markUp");

                entity.Property(e => e.BankFundRate)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("bankFund_rate");

                entity.Property(e => e.BankMrpRateBaseRate)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("bankMrpRate_baseRate");

                entity.Property(e => e.BrokerCode).HasColumnName("broker_code");

                entity.Property(e => e.BrokerName)
                    .HasMaxLength(225)
                    .IsUnicode(false)
                    .HasColumnName("broker_name");

                entity.Property(e => e.DailyFundPositionCreatedBy).HasColumnName("dailyFundPosition_createdBy");

                entity.Property(e => e.DailyFundPositionCreatedWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("dailyFundPosition_createdWhen");

                entity.Property(e => e.DailyFundPositionIsVerified).HasColumnName("dailyFundPosition_IsVerified");

                entity.Property(e => e.DailyFundPositionModifyBy).HasColumnName("dailyFundPosition_ModifyBy");

                entity.Property(e => e.DailyFundPositionModifyWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("dailyFundPosition_ModifyWhen");

                entity.Property(e => e.DailyFundPositionProcessNo).HasColumnName("dailyFundPosition_processNo");

                entity.Property(e => e.DailyFundPositionSbptype).HasColumnName("dailyFundPosition_SBPType");

                entity.Property(e => e.FInstBranchCode).HasColumnName("fInstBranch_code");

                entity.Property(e => e.FInstBranchName)
                    .HasMaxLength(225)
                    .IsUnicode(false)
                    .HasColumnName("fInstBranch_name");

                entity.Property(e => e.GlDetailAccCode)
                    .HasMaxLength(225)
                    .IsUnicode(false)
                    .HasColumnName("glDetail_accCode");

                entity.Property(e => e.InstrumentName)
                    .HasMaxLength(225)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentAmount).HasColumnType("decimal(25, 6)");

                entity.Property(e => e.PaymentMode)
                    .HasMaxLength(225)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiptAmount).HasColumnType("decimal(25, 6)");

                entity.Property(e => e.Sno).HasColumnName("SNO");

                entity.Property(e => e.Symbol)
                    .HasMaxLength(225)
                    .IsUnicode(false);

                entity.Property(e => e.TotalOtherBankPayment).HasColumnType("decimal(25, 6)");

                entity.Property(e => e.TotalOtherBankReceipt).HasColumnType("decimal(25, 6)");

                entity.Property(e => e.TotalPayment).HasColumnType("decimal(25, 6)");

                entity.Property(e => e.TotalReceipt).HasColumnType("decimal(25, 6)");

                entity.Property(e => e.VmSno)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("VM_SNO");
            });

            modelBuilder.Entity<PmsDailyIndex>(entity =>
            {
                entity.HasKey(e => new { e.IndicatorDate, e.IndicatorName });

                entity.ToTable("pms_dailyIndex");

                entity.Property(e => e.IndicatorDate)
                    .HasColumnType("datetime")
                    .HasColumnName("indicator_date");

                entity.Property(e => e.IndicatorName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("indicator_name");

                entity.Property(e => e.IndexCreatedBy).HasColumnName("index_createdBy");

                entity.Property(e => e.IndexCreatedWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("index_createdWhen");

                entity.Property(e => e.IndexModifiedBy).HasColumnName("index_modifiedBy");

                entity.Property(e => e.IndexModifiedWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("index_modifiedWhen");

                entity.Property(e => e.IndicatorChangePersent)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("indicator_changePersent");

                entity.Property(e => e.IndicatorChangePoint)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("indicator_changePoint");

                entity.Property(e => e.IndicatorCode).HasColumnName("indicator_code");

                entity.Property(e => e.IndicatorCurrentIndex)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("indicator_currentIndex");

                entity.Property(e => e.IndicatorPreviousIndex)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("indicator_previousIndex");
            });

            modelBuilder.Entity<PmsDailyNav>(entity =>
            {
                entity.HasKey(e => new { e.NavDate, e.FundMasterCode })
                    .HasName("PK_pms_dailyNAV_1");

                entity.ToTable("pms_dailyNAV");

                entity.Property(e => e.NavDate)
                    .HasColumnType("datetime")
                    .HasColumnName("NAV_date");

                entity.Property(e => e.FundMasterCode).HasColumnName("fundMaster_code");

                entity.Property(e => e.FundNavState).HasColumnName("fundNAV_state");

                entity.Property(e => e.NavAmount)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("NAV_amount");

                entity.Property(e => e.NavCreatedWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("NAV_createdWhen");

                entity.Property(e => e.NavCustFee)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("NAV_custFee");

                entity.Property(e => e.NavIndexkse)
                    .HasColumnType("decimal(25, 0)")
                    .HasColumnName("nav_indexkse");

                entity.Property(e => e.NavIsPosted).HasColumnName("NAV_IsPosted");

                entity.Property(e => e.NavNavPercent)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("NAV_NavPercent");

                entity.Property(e => e.NavOutstandingUnit)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("NAV_OutstandingUnit");

                entity.Property(e => e.NavTotalOutstandingUnits)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("NAV_TotalOutstandingUnits");

                entity.Property(e => e.NavUnitFetchingDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Nav_unitFetchingDate");

                entity.Property(e => e.NavUnitsRedeemed)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("NAV_UnitsREdeemed");

                entity.Property(e => e.NavUnitsSold)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("NAV_UnitsSold");

                entity.Property(e => e.NavVerify).HasColumnName("NAV_Verify");
            });

            modelBuilder.Entity<PmsDailyRate>(entity =>
            {
                entity.HasKey(e => new { e.DRateDate, e.RateTemplCode });

                entity.ToTable("pms_dailyRates");

                entity.Property(e => e.DRateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dRate_date");

                entity.Property(e => e.RateTemplCode).HasColumnName("rateTempl_code");

                entity.Property(e => e.DRateBid)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("dRate_bid");

                entity.Property(e => e.DRateCode).HasColumnName("dRate_code");

                entity.Property(e => e.DRateOffer)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("dRate_offer");

                entity.Property(e => e.FInstBranchCode).HasColumnName("fInstBranch_code");

                entity.Property(e => e.RateTemplSlabName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("rateTempl_slabName");

                entity.Property(e => e.RateTemplType).HasColumnName("rateTempl_type");
            });

            modelBuilder.Entity<PmsDailySevar>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pms_dailySEVar");

                entity.Property(e => e.TradInstCode).HasColumnName("tradInst_code");

                entity.Property(e => e.TradInstTypeCode).HasColumnName("tradInstType_code");

                entity.Property(e => e.VarAccQty)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("var_accQty");

                entity.Property(e => e.VarDate)
                    .HasColumnType("datetime")
                    .HasColumnName("var_date");

                entity.Property(e => e.VarFreefloat)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("var_Freefloat");

                entity.Property(e => e.VarHairCut)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("var_hairCut");

                entity.Property(e => e.VarHourAvgRate)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("var_hourAvgRate");

                entity.Property(e => e.VarSymbol)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("var_symbol");

                entity.Property(e => e.VarValue)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("var_Value");

                entity.Property(e => e.VarWeekAvg)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("var_weekAvg");
            });

            modelBuilder.Entity<PmsDailyTranLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pms_dailyTranLog");

                entity.Property(e => e.ActLogMasNo).HasColumnName("actLogMas_no");

                entity.Property(e => e.BrokerCode).HasColumnName("broker_code");

                entity.Property(e => e.CalPeriodCode).HasColumnName("calPeriod_code");

                entity.Property(e => e.CalYearCode).HasColumnName("calYear_code");

                entity.Property(e => e.FInstTranAmount)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("fInstTran_amount");

                entity.Property(e => e.FInstTranBrokerRate)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("fInstTran_brokerRate");

                entity.Property(e => e.FInstTranCode).HasColumnName("fInstTran_code");

                entity.Property(e => e.FInstTranInterest)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("fInstTran_interest");

                entity.Property(e => e.FInstTranType).HasColumnName("fInstTran_type");

                entity.Property(e => e.FinstTranMode).HasColumnName("finstTran_mode");

                entity.Property(e => e.FinstTranPrice1)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("finstTran_Price1");

                entity.Property(e => e.FinstTranPrice2)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("finstTran_Price2");

                entity.Property(e => e.FundCode).HasColumnName("fund_code");

                entity.Property(e => e.FundmasterCode).HasColumnName("fundmaster_code");

                entity.Property(e => e.MarketCode).HasColumnName("market_code");

                entity.Property(e => e.OrdDealerLimitFlag)
                    .HasColumnName("OrdDealerLimit_Flag")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OrdExecAmount)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("ordExec_amount");

                entity.Property(e => e.OrdExecDealTickNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ordExec_dealTickNo");

                entity.Property(e => e.OrdExecPrice)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("ordExec_price");

                entity.Property(e => e.OrdExecQuantity)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("ordExec_quantity");

                entity.Property(e => e.OrdExecTradeYield)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("ordExec_TradeYield");

                entity.Property(e => e.OrderBrokerRate)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("order_brokerRate");

                entity.Property(e => e.OrderBrokerRateMode).HasColumnName("order_brokerRateMode");

                entity.Property(e => e.OrderCode).HasColumnName("order_code");

                entity.Property(e => e.OrderDateValidityMode).HasColumnName("order_dateValidityMode");

                entity.Property(e => e.OrderOnClearingSys).HasColumnName("order_onClearingSys");

                entity.Property(e => e.OrderSubType).HasColumnName("order_subType");

                entity.Property(e => e.ProductCode).HasColumnName("product_code");

                entity.Property(e => e.PsrefAmount)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("PSRef_amount");

                entity.Property(e => e.PsrefPurDealTickNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PSRef_purDealTickNo");

                entity.Property(e => e.PsrefPurPrice)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("PSRef_purPrice");

                entity.Property(e => e.PsrefQuantity)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("PSRef_quantity");

                entity.Property(e => e.SettDateAccruedInterest)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("settDate_AccruedInterest");

                entity.Property(e => e.SettDateBrokerCommission)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("settDate_BrokerCommission");

                entity.Property(e => e.SettDateNetAmount)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("settDate_netAmount");

                entity.Property(e => e.SettModeCode).HasColumnName("settMode_code");

                entity.Property(e => e.ShareType).HasColumnName("share_type");

                entity.Property(e => e.TradInstCode).HasColumnName("tradInst_code");

                entity.Property(e => e.TradInstTypeCode).HasColumnName("tradInstType_code");

                entity.Property(e => e.TranLogCntrParty).HasColumnName("tranLog_cntrParty");

                entity.Property(e => e.TranLogCode).HasColumnName("tranLog_code");

                entity.Property(e => e.TranLogDate)
                    .HasColumnType("datetime")
                    .HasColumnName("tranLog_Date");

                entity.Property(e => e.TranLogDealDate)
                    .HasColumnType("datetime")
                    .HasColumnName("tranLog_DealDate");

                entity.Property(e => e.TranLogDealTickNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tranLog_DealTickNo");

                entity.Property(e => e.TranLogInitialDate)
                    .HasColumnType("datetime")
                    .HasColumnName("tranLog_InitialDate");

                entity.Property(e => e.TranLogMarkup)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("tranLog_markup");

                entity.Property(e => e.TranLogMatAmount)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("tranLog_matAmount");

                entity.Property(e => e.TranLogModifiedBy).HasColumnName("tranLog_modifiedBy");

                entity.Property(e => e.TranLogModifiedWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("tranLog_modifiedWhen");

                entity.Property(e => e.TranLogModule).HasColumnName("tranLog_module");

                entity.Property(e => e.TranLogSettBank).HasColumnName("tranLog_settBank");

                entity.Property(e => e.TranLogSettlementDate)
                    .HasColumnType("datetime")
                    .HasColumnName("tranLog_SettlementDate");

                entity.Property(e => e.TranLogSno).HasColumnName("tranLog_Sno");

                entity.Property(e => e.TranLogState).HasColumnName("tranLog_state");

                entity.Property(e => e.TrusteeCode)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("trustee_code");

                entity.Property(e => e.UndSecAmount)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("undSec_amount");

                entity.Property(e => e.WorkFlowActionCode).HasColumnName("workFlowAction_code");
            });

            modelBuilder.Entity<PmsDailyVarBetum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pms_dailyVarBeta");

                entity.Property(e => e.DailyVarBetaBeta)
                    .HasColumnType("decimal(30, 25)")
                    .HasColumnName("dailyVarBeta_BETA");

                entity.Property(e => e.DailyVarBetaCreatedBy).HasColumnName("dailyVarBeta_createdBy");

                entity.Property(e => e.DailyVarBetaCreatedWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("dailyVarBeta_createdWhen");

                entity.Property(e => e.DailyVarBetaDmpLnvalue)
                    .HasColumnType("decimal(30, 25)")
                    .HasColumnName("dailyVarBeta_DMP_LNValue");

                entity.Property(e => e.DailyVarBetaIndicatorLnvalue)
                    .HasColumnType("decimal(30, 25)")
                    .HasColumnName("dailyVarBeta_indicator_LNValue");

                entity.Property(e => e.DailyVarBetaIsVerified).HasColumnName("dailyVarBeta_IsVerified");

                entity.Property(e => e.DailyVarBetaProcessDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dailyVarBeta_processDate");

                entity.Property(e => e.DailyVarBetaSno).HasColumnName("dailyVarBeta_SNO");

                entity.Property(e => e.DailyVarBetaStdDev)
                    .HasColumnType("decimal(30, 25)")
                    .HasColumnName("dailyVarBeta_StdDev");

                entity.Property(e => e.DailyVarBetaType).HasColumnName("dailyVarBeta_type");

                entity.Property(e => e.DailyVarBetaVar)
                    .HasColumnType("decimal(30, 25)")
                    .HasColumnName("dailyVarBeta_VAR");

                entity.Property(e => e.DailyVarBetaVerifiedBy).HasColumnName("dailyVarBeta_verifiedBy");

                entity.Property(e => e.DailyVarBetaVerifiedWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("dailyVarBeta_verifiedWhen");

                entity.Property(e => e.DmpPrice)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("DMP_price");

                entity.Property(e => e.IndicatorChangePoint)
                    .HasColumnType("decimal(30, 20)")
                    .HasColumnName("indicator_changePoint");

                entity.Property(e => e.IndicatorCode).HasColumnName("indicator_code");

                entity.Property(e => e.IndicatorDate)
                    .HasColumnType("datetime")
                    .HasColumnName("indicator_date");

                entity.Property(e => e.TradInstTypeCode).HasColumnName("tradInstType_code");

                entity.Property(e => e.TradinstCode).HasColumnName("tradinst_code");
            });

            modelBuilder.Entity<PmsDealRate>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pms_dealRates");

                entity.Property(e => e.DealRatesAccBasis).HasColumnName("dealRates_accBasis");

                entity.Property(e => e.DealRatesAccDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dealRates_accDate");

                entity.Property(e => e.DealRatesAccRate)
                    .HasColumnType("decimal(25, 0)")
                    .HasColumnName("dealRates_accRate");

                entity.Property(e => e.DealRatesApplDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dealRates_applDate");

                entity.Property(e => e.DealRatesBaseRate)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("dealRates_baseRate");

                entity.Property(e => e.DealRatesCode).HasColumnName("dealRates_code");

                entity.Property(e => e.DealRatesFixedRate)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("dealRates_fixedRate");

                entity.Property(e => e.DealRatesRecursiveRate).HasColumnName("dealRates_recursiveRate");

                entity.Property(e => e.DealRatesState).HasColumnName("dealRates_state");

                entity.Property(e => e.DealRatesVchrState).HasColumnName("dealRates_vchrState");

                entity.Property(e => e.FinstTranCode)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("finstTran_code");

                entity.Property(e => e.FinstTranType).HasColumnName("finstTran_type");

                entity.Property(e => e.RateTemplCode).HasColumnName("rateTempl_code");

                entity.Property(e => e.RateTemplType).HasColumnName("rateTempl_type");

                entity.Property(e => e.TransactionType).HasColumnName("transaction_type");

                entity.Property(e => e.VmSno)
                    .HasColumnType("decimal(25, 1)")
                    .HasColumnName("VM_SNO");
            });

            modelBuilder.Entity<PmsDealTrack>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pms_dealTrack");

                entity.Property(e => e.DealTrackCreatedBy).HasColumnName("dealTrack_createdBy");

                entity.Property(e => e.DealTrackCreatedWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("dealTrack_createdWhen");

                entity.Property(e => e.DealTrackSNo).HasColumnName("dealTrack_sNo");

                entity.Property(e => e.DealTrackStatus).HasColumnName("dealTrack_status");

                entity.Property(e => e.FInstTranRefNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fInstTran_RefNo");

                entity.Property(e => e.FundCode).HasColumnName("fund_code");

                entity.Property(e => e.FundMasterCode).HasColumnName("fundMaster_code");

                entity.Property(e => e.TradInstTypeCode).HasColumnName("tradInstType_code");

                entity.Property(e => e.TranLogModule).HasColumnName("tranLog_module");
            });

            modelBuilder.Entity<PmsDealerLimit>(entity =>
            {
                entity.HasKey(e => new { e.DealerCode, e.DealerLmoCode });

                entity.ToTable("pms_dealerLimit");

                entity.Property(e => e.DealerCode).HasColumnName("dealer_code");

                entity.Property(e => e.DealerLmoCode).HasColumnName("dealer_lmoCode");

                entity.Property(e => e.DealerAmtLimit)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("dealer_AmtLimit");

                entity.Property(e => e.DealerCreatedBy).HasColumnName("dealer_createdBy");

                entity.Property(e => e.DealerCreatedWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("dealer_createdWhen");

                entity.Property(e => e.DealerDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dealer_date");

                entity.Property(e => e.DealerIsActive).HasColumnName("dealer_IsActive");

                entity.Property(e => e.DealerLmoName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dealer_lmoName");

                entity.Property(e => e.DealerModifiedBy).HasColumnName("dealer_modifiedBy");

                entity.Property(e => e.DealerModifiedWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("dealer_modifiedWhen");

                entity.Property(e => e.FundMasterCode).HasColumnName("fundMaster_code");

                entity.Property(e => e.TradInstCode).HasColumnName("tradInst_code");

                entity.Property(e => e.TradInstTypeCode).HasColumnName("tradInstType_code");
            });

            modelBuilder.Entity<PmsDtschema>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pms_DTSchema");

                entity.Property(e => e.DtschemaCode)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("DTSchema_code");

                entity.Property(e => e.DtschemaCreatedBy).HasColumnName("DTSchema_createdBy");

                entity.Property(e => e.DtschemaCreatedWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("DTSchema_createdWhen");

                entity.Property(e => e.DtschemaDate)
                    .HasColumnType("datetime")
                    .HasColumnName("DTSchema_Date");

                entity.Property(e => e.DtschemaModifiedBy).HasColumnName("DTSchema_modifiedBy");

                entity.Property(e => e.DtschemaModifiedWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("DTSchema_modifiedWhen");

                entity.Property(e => e.DtschemaState).HasColumnName("Dtschema_state");

                entity.Property(e => e.DtschemaType).HasColumnName("DTSchema_Type");

                entity.Property(e => e.FInstTranRefNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fInstTran_RefNo");

                entity.Property(e => e.FundCode).HasColumnName("fund_code");
            });

            modelBuilder.Entity<PmsEmailconfig>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pms_EMAILCONFIG");

                entity.Property(e => e.CcemailconfigId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CCEMAILCONFIG_ID");

                entity.Property(e => e.EmailconfigDisplayname)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("EMAILCONFIG_DISPLAYNAME");

                entity.Property(e => e.EmailconfigDomain)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("EMAILCONFIG_DOMAIN");

                entity.Property(e => e.EmailconfigId)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("EMAILCONFIG_ID");

                entity.Property(e => e.EmailconfigPassword)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EMAILCONFIG_PASSWORD");

                entity.Property(e => e.EmailconfigPort).HasColumnName("EMAILCONFIG_PORT");

                entity.Property(e => e.EmailconfigSmtpserver)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("EMAILCONFIG_SMTPSERVER");

                entity.Property(e => e.EmailconfigSno).HasColumnName("EMAILCONFIG_SNO");

                entity.Property(e => e.EmailconfigSsl).HasColumnName("EMAILCONFIG_SSL");
            });

            modelBuilder.Entity<PmsEmpInvestment>(entity =>
            {
                entity.HasKey(e => new { e.EmpCode, e.TradInstCode, e.TradInstTypeCode })
                    .HasName("PK__pms_empInvestmen__24E777C3");

                entity.ToTable("pms_empInvestment");

                entity.Property(e => e.EmpCode).HasColumnName("emp_code");

                entity.Property(e => e.TradInstCode).HasColumnName("trad_InstCode");

                entity.Property(e => e.TradInstTypeCode).HasColumnName("tradInstType_code");

                entity.Property(e => e.EmpInvAmount)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("empInv_amount");

                entity.Property(e => e.EmpInvQuantity)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("empInv_quantity");

                entity.HasOne(d => d.EmpCodeNavigation)
                    .WithMany(p => p.PmsEmpInvestments)
                    .HasForeignKey(d => d.EmpCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__pms_empIn__emp_c__26CFC035");

                entity.HasOne(d => d.TradInstTypeCodeNavigation)
                    .WithMany(p => p.PmsEmpInvestments)
                    .HasForeignKey(d => d.TradInstTypeCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__pms_empIn__tradI__25DB9BFC");
            });

            modelBuilder.Entity<PmsEmployee>(entity =>
            {
                entity.HasKey(e => e.EmpCode)
                    .HasName("PK__pms_employees__22FF2F51");

                entity.ToTable("pms_employees");

                entity.Property(e => e.EmpCode)
                    .ValueGeneratedNever()
                    .HasColumnName("emp_code");

                entity.Property(e => e.EmpActive).HasColumnName("emp_active");

                entity.Property(e => e.EmpAddress)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("emp_address");

                entity.Property(e => e.EmpDept)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("emp_dept");

                entity.Property(e => e.EmpDesignation)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("emp_designation");

                entity.Property(e => e.EmpEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("emp_email");

                entity.Property(e => e.EmpFax)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("emp_fax");

                entity.Property(e => e.EmpName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("emp_name");

                entity.Property(e => e.EmpNationality)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("emp_nationality");

                entity.Property(e => e.EmpPhone)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("emp_phone");

                entity.Property(e => e.EmpStaffCode)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("emp_staffCode");
            });

            modelBuilder.Entity<PmsEodLog>(entity =>
            {
                entity.HasKey(e => new { e.EodLogCode, e.UserCode, e.EodDetailSno, e.EodLogDate })
                    .HasName("PK_pms_EODLog_1");

                entity.ToTable("pms_eodLog");

                entity.Property(e => e.EodLogCode).HasColumnName("eodLog_code");

                entity.Property(e => e.UserCode).HasColumnName("user_code");

                entity.Property(e => e.EodDetailSno).HasColumnName("eodDetail_SNo");

                entity.Property(e => e.EodLogDate)
                    .HasColumnType("datetime")
                    .HasColumnName("eodLog_Date");

                entity.Property(e => e.EodLogCreatedBy).HasColumnName("eodLog_createdBy");

                entity.Property(e => e.EodLogCreatedWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("eodLog_createdWhen");

                entity.Property(e => e.EodLogDuration)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("eodLog_duration");

                entity.Property(e => e.EodLogManhours)
                    .HasColumnType("datetime")
                    .HasColumnName("eodLog_Manhours");

                entity.Property(e => e.EodLogModifyBy).HasColumnName("eodLog_modifyBy");

                entity.Property(e => e.EodLogModifyWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("eodLog_modifyWhen");
            });

            modelBuilder.Entity<PmsEquityKatLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pms_equityKatLogs");

                entity.Property(e => e.BrokerCode).HasColumnName("broker_Code");

                entity.Property(e => e.FundMasterCode).HasColumnName("fundMaster_code");

                entity.Property(e => e.KatBuyAmount)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("kat_buyAmount");

                entity.Property(e => e.KatBuyQty)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("kat_buyQty");

                entity.Property(e => e.KatBuyRate)
                    .HasColumnType("decimal(28, 6)")
                    .HasColumnName("kat_buyRate");

                entity.Property(e => e.KatClientCode).HasColumnName("kat_clientCode");

                entity.Property(e => e.KatCode).HasColumnName("kat_code");

                entity.Property(e => e.KatCounterTrader)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("kat_counterTrader");

                entity.Property(e => e.KatCreatedBy).HasColumnName("kat_createdBy");

                entity.Property(e => e.KatCreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("kat_createdDate");

                entity.Property(e => e.KatDate)
                    .HasColumnType("datetime")
                    .HasColumnName("kat_date");

                entity.Property(e => e.KatExecutedQty)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("kat_executedQty");

                entity.Property(e => e.KatGrossAmount)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("kat_grossAmount");

                entity.Property(e => e.KatIniSysId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("kat_iniSysID");

                entity.Property(e => e.KatMarket)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("kat_market");

                entity.Property(e => e.KatModfyiDate)
                    .HasColumnType("datetime")
                    .HasColumnName("kat_modfyiDate");

                entity.Property(e => e.KatModifyBy).HasColumnName("kat_modifyBy");

                entity.Property(e => e.KatModule)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("kat_module");

                entity.Property(e => e.KatOrderQty)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("kat_orderQty");

                entity.Property(e => e.KatOutstandingQty)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("kat_outstandingQty");

                entity.Property(e => e.KatProcessState).HasColumnName("kat_processState");

                entity.Property(e => e.KatSecName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("kat_secName");

                entity.Property(e => e.KatSecSysmol)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("kat_secSysmol");

                entity.Property(e => e.KatSellAmount)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("kat_sellAmount");

                entity.Property(e => e.KatSellQty)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("kat_sellQty");

                entity.Property(e => e.KatSellRate)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("kat_sellRate");

                entity.Property(e => e.KatSetteMode).HasColumnName("kat_setteMode");

                entity.Property(e => e.KatStatus)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("kat_status");

                entity.Property(e => e.KatTicketNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("kat_ticketNo");

                entity.Property(e => e.KatTrader).HasColumnName("kat_trader");

                entity.Property(e => e.KatTranDate)
                    .HasColumnType("datetime")
                    .HasColumnName("kat_tranDate");

                entity.Property(e => e.KatTranId)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("kat_tranID");
            });

            modelBuilder.Entity<PmsEquityTradeLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pms_equityTradeLogs");

                entity.Property(e => e.CfsBrokerCode).HasColumnName("CFS_brokerCode");

                entity.Property(e => e.FundMasterCode).HasColumnName("fundMaster_code");

                entity.Property(e => e.NccBuyAmount)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("ncc_buyAmount");

                entity.Property(e => e.NccBuyQty)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("ncc_buyQty");

                entity.Property(e => e.NccBuyRate)
                    .HasColumnType("decimal(28, 6)")
                    .HasColumnName("ncc_buyRate");

                entity.Property(e => e.NccCfsdate)
                    .HasColumnType("datetime")
                    .HasColumnName("ncc_CFSDate");

                entity.Property(e => e.NccCfsticketNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ncc_CFSTicketNo");

                entity.Property(e => e.NccClientCode).HasColumnName("ncc_clientCode");

                entity.Property(e => e.NccCode).HasColumnName("ncc_code");

                entity.Property(e => e.NccConfId)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ncc_confID");

                entity.Property(e => e.NccCounterId)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("ncc_counterID");

                entity.Property(e => e.NccCounterTrader)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ncc_counterTrader");

                entity.Property(e => e.NccDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ncc_date");

                entity.Property(e => e.NccIniCmid).HasColumnName("ncc_iniCMID");

                entity.Property(e => e.NccIniSysId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ncc_iniSysID");

                entity.Property(e => e.NccMarket)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ncc_market");

                entity.Property(e => e.NccModfyidate)
                    .HasColumnType("datetime")
                    .HasColumnName("ncc_modfyidate");

                entity.Property(e => e.NccModifyBy).HasColumnName("ncc_modifyBy");

                entity.Property(e => e.NccModule)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ncc_module");

                entity.Property(e => e.NccOpenDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ncc_openDate");

                entity.Property(e => e.NccProcessState).HasColumnName("ncc_processState");

                entity.Property(e => e.NccSecName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ncc_secName");

                entity.Property(e => e.NccSecSysmol)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ncc_secSysmol");

                entity.Property(e => e.NccSellAmount)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("ncc_sellAmount");

                entity.Property(e => e.NccSellQty)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("ncc_sellQty");

                entity.Property(e => e.NccSellRate)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("ncc_sellRate");

                entity.Property(e => e.NccSetteMode).HasColumnName("ncc_setteMode");

                entity.Property(e => e.NccStatus)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ncc_status");

                entity.Property(e => e.NccTicketNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ncc_ticketNo");

                entity.Property(e => e.NccTrader).HasColumnName("ncc_trader");

                entity.Property(e => e.NccTranDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ncc_tranDate");

                entity.Property(e => e.NccTranId)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("ncc_tranID");
            });

            modelBuilder.Entity<PmsExecptTranLog>(entity =>
            {
                entity.HasKey(e => new { e.ExecptTransLogCode, e.UserCode, e.ExecptTransLogDate })
                    .HasName("PK_pms_execpTranLog");

                entity.ToTable("pms_execptTranLog");

                entity.Property(e => e.ExecptTransLogCode).HasColumnName("execptTransLog_code");

                entity.Property(e => e.UserCode).HasColumnName("user_code");

                entity.Property(e => e.ExecptTransLogDate)
                    .HasColumnType("datetime")
                    .HasColumnName("execptTransLog_Date");

                entity.Property(e => e.EodDetailSno).HasColumnName("eodDetail_SNo");

                entity.Property(e => e.EodLogCode).HasColumnName("eodLog_code");

                entity.Property(e => e.ExecptTransLogCreatedBy).HasColumnName("execptTransLog_createdBy");

                entity.Property(e => e.ExecptTransLogCreatedWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("execptTransLog_createdWhen");

                entity.Property(e => e.ExecptTransLogMode).HasColumnName("execptTransLog_mode");

                entity.Property(e => e.ExecptTransLogModifyBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("execptTransLog_modifyBy");

                entity.Property(e => e.ExecptTransLogModifyWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("execptTransLog_modifyWhen");

                entity.Property(e => e.ExecptTransLogSource).HasColumnName("execptTransLog_source");

                entity.Property(e => e.FInstTranRefNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fInstTran_RefNo");

                entity.Property(e => e.OrdExecDealTickNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ordExec_dealTickNo");

                entity.Property(e => e.OrderRefNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("order_refNo");
            });

            modelBuilder.Entity<PmsExpLimit>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pms_expLimit");

                entity.Property(e => e.ExpLimitCode).HasColumnName("expLimit_code");

                entity.Property(e => e.ExpLimitDate)
                    .HasColumnType("datetime")
                    .HasColumnName("expLimit_Date");

                entity.Property(e => e.ExpLimitEntitycode).HasColumnName("expLimit_entitycode");

                entity.Property(e => e.ExpLimitIsActive).HasColumnName("expLimit_isActive");

                entity.Property(e => e.ExpLimitModifiedBy).HasColumnName("expLimit_modifiedBy");

                entity.Property(e => e.ExpLimitModifiedWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("expLimit_modifiedWhen");

                entity.Property(e => e.ExpLimitType).HasColumnName("expLimit_type");

                entity.Property(e => e.ExpLimitValue)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("expLimit_value");

                entity.Property(e => e.ExpLimitValueType).HasColumnName("expLimit_valueType");

                entity.Property(e => e.ExpLimtCreatedBy).HasColumnName("expLimt_createdBy");

                entity.Property(e => e.ExpLimtCreatedWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("expLimt_createdWhen");
            });

            modelBuilder.Entity<PmsFInstBranch>(entity =>
            {
                entity.HasKey(e => new { e.FInstBranchCode, e.FInstCode, e.FInstTypeCode })
                    .HasName("PK__pms_fInstBranche__7A672E12");

                entity.ToTable("pms_fInstBranches");

                entity.HasIndex(e => e.FInstBranchName, "IX_pms_fInstBranches")
                    .IsUnique();

                entity.Property(e => e.FInstBranchCode).HasColumnName("fInstBranch_code");

                entity.Property(e => e.FInstCode).HasColumnName("fInst_code");

                entity.Property(e => e.FInstTypeCode).HasColumnName("fInstType_code");

                entity.Property(e => e.FInstBranchAccountNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fInstBranch_Account_No");

                entity.Property(e => e.FInstBranchAddress)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("fInstBranch_address");

                entity.Property(e => e.FInstBranchBankIpsaccNo)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("fInstBranch_bankIPSAccNo");

                entity.Property(e => e.FInstBranchCntrParty).HasColumnName("fInstBranch_cntrParty");

                entity.Property(e => e.FInstBranchContactPerson)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fInstBranch_contactPerson");

                entity.Property(e => e.FInstBranchDepBank).HasColumnName("fInstBranch_depBank");

                entity.Property(e => e.FInstBranchDesc)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("fInstBranch_desc");

                entity.Property(e => e.FInstBranchEmail)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fInstBranch_email");

                entity.Property(e => e.FInstBranchFax)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fInstBranch_fax");

                entity.Property(e => e.FInstBranchName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fInstBranch_name");

                entity.Property(e => e.FInstBranchPhones)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fInstBranch_phones");

                entity.Property(e => e.FInstBranchPrDealer).HasColumnName("fInstBranch_prDealer");

                entity.Property(e => e.FInstBranchSettBank).HasColumnName("fInstBranch_settBank");

                entity.Property(e => e.FinstbranchAuthorizedBy).HasColumnName("FINSTBRANCH_authorizedBy");

                entity.Property(e => e.FinstbranchAuthorizedWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("FINSTBRANCH_authorizedWhen");

                entity.Property(e => e.FinstbranchBiccode)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("FINSTBRANCH_BICcode");

                entity.Property(e => e.FinstbranchCreatedBy).HasColumnName("FINSTBRANCH_createdBy");

                entity.Property(e => e.FinstbranchCreatedWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("FINSTBRANCH_createdWhen");

                entity.Property(e => e.FinstbranchCustomerId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("finstbranch_customerID");

                entity.Property(e => e.FinstbranchInvestor).HasColumnName("FINSTBRANCH_INVESTOR");

                entity.Property(e => e.FinstbranchIsAuthorized).HasColumnName("FINSTBRANCH_isAuthorized");

                entity.Property(e => e.FinstbranchModifiedBy).HasColumnName("FINSTBRANCH_modifiedBy");

                entity.Property(e => e.FinstbranchModifiedWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("FINSTBRANCH_modifiedWhen");

                entity.Property(e => e.FinstbranchReason)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("FINSTBRANCH_reason");

                entity.Property(e => e.FinstbranchSglaccNo)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("finstbranch_SGLAccNo");

                entity.HasOne(d => d.FInst)
                    .WithMany(p => p.PmsFInstBranches)
                    .HasForeignKey(d => new { d.FInstCode, d.FInstTypeCode })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__pms_fInstBranche__00200768");
            });

            modelBuilder.Entity<PmsFInstStakeHolder>(entity =>
            {
                entity.HasKey(e => new { e.FInstStakeCode, e.FInstTypeCode, e.FInstCode })
                    .HasName("PK_pms_finstSignatory");

                entity.ToTable("pms_fInstStakeHolder");

                entity.Property(e => e.FInstStakeCode).HasColumnName("fInstStake_code");

                entity.Property(e => e.FInstTypeCode).HasColumnName("fInstType_code");

                entity.Property(e => e.FInstCode).HasColumnName("fInst_code");

                entity.Property(e => e.FinstStakeActiveDate)
                    .HasColumnType("datetime")
                    .HasColumnName("finstStake_ActiveDate");

                entity.Property(e => e.FinstStakeAuthorizedBy).HasColumnName("finstStake_authorizedBy");

                entity.Property(e => e.FinstStakeAuthorizedWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("finstStake_authorizedWhen");

                entity.Property(e => e.FinstStakeCnic)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("finstStake_CNIC");

                entity.Property(e => e.FinstStakeCnicexpire)
                    .HasColumnType("datetime")
                    .HasColumnName("finstStake_CNICExpire");

                entity.Property(e => e.FinstStakeCnicissue)
                    .HasColumnType("datetime")
                    .HasColumnName("finstStake_CNICIssue");

                entity.Property(e => e.FinstStakeCreatedBy).HasColumnName("finstStake_CreatedBy");

                entity.Property(e => e.FinstStakeCreatedWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("finstStake_CreatedWhen");

                entity.Property(e => e.FinstStakeGroup).HasColumnName("finstStake_Group");

                entity.Property(e => e.FinstStakeIsActive).HasColumnName("finstStake_IsActive");

                entity.Property(e => e.FinstStakeIsAuthorized).HasColumnName("finstStake_isAuthorized");

                entity.Property(e => e.FinstStakeModifyBy).HasColumnName("finstStake_modifyBy");

                entity.Property(e => e.FinstStakeModifyWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("finstStake_modifyWhen");

                entity.Property(e => e.FinstStakeName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("finstStake_name");

                entity.Property(e => e.FinstStakeNature).HasColumnName("finstStake_Nature");

                entity.Property(e => e.FinstStakePasport)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("finstStake_Pasport");

                entity.Property(e => e.FinstStakePasportExpire)
                    .HasColumnType("datetime")
                    .HasColumnName("finstStake_PasportExpire");

                entity.Property(e => e.FinstStakePasportIssue)
                    .HasColumnType("datetime")
                    .HasColumnName("finstStake_PasportIssue");

                entity.Property(e => e.FinstStakeReason)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("finstStake_reason");
            });

            modelBuilder.Entity<PmsFInstTran>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pms_fInstTrans");

                entity.Property(e => e.BrokerCode).HasColumnName("broker_code");

                entity.Property(e => e.CrRatCompName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("crRatComp_name");

                entity.Property(e => e.FInstBranchCode).HasColumnName("fInstBranch_code");

                entity.Property(e => e.FInstCode).HasColumnName("fInst_code");

                entity.Property(e => e.FInstPartyBranchCode).HasColumnName("fInstPartyBranch_code");

                entity.Property(e => e.FInstPartyCode).HasColumnName("fInstParty_code");

                entity.Property(e => e.FInstPartyTypeCode).HasColumnName("fInstPartyType_code");

                entity.Property(e => e.FInstTranAccrualBasis).HasColumnName("fInstTran_accrualBasis");

                entity.Property(e => e.FInstTranAmount)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("fInstTran_amount");

                entity.Property(e => e.FInstTranBrokerRate)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("fInstTran_brokerRate");

                entity.Property(e => e.FInstTranBrokerRateMode).HasColumnName("fInstTran_brokerRateMode");

                entity.Property(e => e.FInstTranCode)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("fInstTran_code");

                entity.Property(e => e.FInstTranCrossRefNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fInstTran_crossRefNo");

                entity.Property(e => e.FInstTranDate)
                    .HasColumnType("datetime")
                    .HasColumnName("fInstTran_date");

                entity.Property(e => e.FInstTranInterest)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("fInstTran_interest");

                entity.Property(e => e.FInstTranPkrvdate)
                    .HasColumnType("datetime")
                    .HasColumnName("fInstTran_PKRVDate");

                entity.Property(e => e.FInstTranPreIpoName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("fInstTran_preIpoName");

                entity.Property(e => e.FInstTranRefNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fInstTran_RefNo");

                entity.Property(e => e.FInstTranState).HasColumnName("fInstTran_state");

                entity.Property(e => e.FInstTranType).HasColumnName("fInstTran_type");

                entity.Property(e => e.FInstTypeCode).HasColumnName("fInstType_code");

                entity.Property(e => e.FinstTranDealTerm).HasColumnName("finstTran_dealTerm");

                entity.Property(e => e.FinstTranDealTermPro).HasColumnName("finstTran_dealTermPro");

                entity.Property(e => e.FinstTranDesc)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("finstTran_desc");

                entity.Property(e => e.FinstTranIsManualPkrv).HasColumnName("finstTran_IsManualPKRV");

                entity.Property(e => e.FinstTranMode).HasColumnName("finstTran_mode");

                entity.Property(e => e.FinstTranTerm).HasColumnName("finstTran_term");

                entity.Property(e => e.FinstTranTermInterest).HasColumnName("finstTran_termInterest");

                entity.Property(e => e.FinstTranTermPayment).HasColumnName("finstTran_termPayment");

                entity.Property(e => e.FinstTranTotalExposure)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("finstTran_totalExposure");

                entity.Property(e => e.FinsttranCreatedWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("FINSTTRAN_CreatedWhen");

                entity.Property(e => e.FinsttranCreatedby).HasColumnName("FINSTTRAN_Createdby");

                entity.Property(e => e.FinsttranEditCounter).HasColumnName("FINSTTRAN_EditCounter");

                entity.Property(e => e.FinsttranModifyWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("FINSTTRAN_modifyWhen");

                entity.Property(e => e.FinsttranModifyby).HasColumnName("FINSTTRAN_modifyby");

                entity.Property(e => e.FinsttranSettBank).HasColumnName("finsttran_settBank");

                entity.Property(e => e.FinsttranSettThru).HasColumnName("FINSTTRAN_SettThru");

                entity.Property(e => e.FundCode).HasColumnName("fund_code");

                entity.Property(e => e.FundMasterCode).HasColumnName("FundMaster_code");

                entity.Property(e => e.InvCommAppDate)
                    .HasColumnType("datetime")
                    .HasColumnName("invCommApp_date");

                entity.Property(e => e.OrdDealerLimitFlag)
                    .HasColumnName("OrdDealerLimit_Flag")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OrdExecStatus).HasColumnName("ordExec_status");

                entity.Property(e => e.TradInstTypeCode).HasColumnName("tradInstType_code");
            });

            modelBuilder.Entity<PmsFInstType>(entity =>
            {
                entity.HasKey(e => e.FInstTypeCode)
                    .HasName("PK__pms_fInstTypes__408F9238");

                entity.ToTable("pms_fInstTypes");

                entity.HasIndex(e => e.FInstTypeName, "IX_pms_fInstTypes")
                    .IsUnique();

                entity.Property(e => e.FInstTypeCode)
                    .ValueGeneratedNever()
                    .HasColumnName("fInstType_code");

                entity.Property(e => e.FInstTypeAuthorizedBy).HasColumnName("fInstType_authorizedBy");

                entity.Property(e => e.FInstTypeAuthorizedWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("fInstType_authorizedWhen");

                entity.Property(e => e.FInstTypeCreatedBy).HasColumnName("fInstType_createdBy");

                entity.Property(e => e.FInstTypeCreatedWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("fInstType_createdWhen");

                entity.Property(e => e.FInstTypeDesc)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("fInstType_desc");

                entity.Property(e => e.FInstTypeIsAuthorized).HasColumnName("fInstType_isAuthorized");

                entity.Property(e => e.FInstTypeModifiedBy).HasColumnName("fInstType_modifiedBy");

                entity.Property(e => e.FInstTypeModifiedWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("fInstType_modifiedWhen");

                entity.Property(e => e.FInstTypeName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fInstType_name");

                entity.Property(e => e.FInstTypeReason)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("fInstType_reason");
            });

            modelBuilder.Entity<PmsFInstituion>(entity =>
            {
                entity.HasKey(e => new { e.FInstCode, e.FInstTypeCode })
                    .HasName("PK__pms_fInstituions__787EE5A0");

                entity.ToTable("pms_fInstituions");

                entity.HasIndex(e => e.FInstName, "IX_pms_fInstituions")
                    .IsUnique();

                entity.Property(e => e.FInstCode).HasColumnName("fInst_code");

                entity.Property(e => e.FInstTypeCode).HasColumnName("fInstType_code");

                entity.Property(e => e.FInstBankAccNo)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("fInst_bankAccNo");

                entity.Property(e => e.FInstDepositLimit)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("fInst_depositLimit");

                entity.Property(e => e.FInstDesc)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("fInst_desc");

                entity.Property(e => e.FInstMra).HasColumnName("fInst_MRA");

                entity.Property(e => e.FInstName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fInst_name");

                entity.Property(e => e.FInstRating)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("fInst_rating");

                entity.Property(e => e.FInstRepoLimit)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("fInst_repoLimit");

                entity.Property(e => e.FInstSglorBank).HasColumnName("fInst_SGLorBank");

                entity.Property(e => e.FInstZakatImplication).HasColumnName("fInst_zakatImplication");

                entity.Property(e => e.FinstAuthorizedBy).HasColumnName("FINST_authorizedBy");

                entity.Property(e => e.FinstAuthorizedWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("FINST_authorizedWhen");

                entity.Property(e => e.FinstCreatedBy).HasColumnName("FINST_createdBy");

                entity.Property(e => e.FinstCreatedWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("FINST_createdWhen");

                entity.Property(e => e.FinstIsAuthorized).HasColumnName("FINST_isAuthorized");

                entity.Property(e => e.FinstIsRelatedParty).HasColumnName("FINST_isRelatedParty");

                entity.Property(e => e.FinstModifiedBy).HasColumnName("FINST_modifiedBy");

                entity.Property(e => e.FinstModifiedWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("FINST_modifiedWhen");

                entity.Property(e => e.FinstReason)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("FINST_reason");

                entity.Property(e => e.ShareCode).HasColumnName("share_Code");

                entity.HasOne(d => d.FInstTypeCodeNavigation)
                    .WithMany(p => p.PmsFInstituions)
                    .HasForeignKey(d => d.FInstTypeCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__pms_fInst__fInst__7B5B524B");
            });

            modelBuilder.Entity<PmsFee>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pms_fees");

                entity.Property(e => e.FeeAmount)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("fee_amount");

                entity.Property(e => e.FeeName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fee_name");

                entity.Property(e => e.FeePercent)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("fee_percent");

                entity.Property(e => e.FeeUpdated)
                    .HasColumnType("datetime")
                    .HasColumnName("fee_updated");

                entity.Property(e => e.FundMasterCode).HasColumnName("fundMaster_code");

                entity.HasOne(d => d.FundMasterCodeNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.FundMasterCode)
                    .HasConstraintName("FK_pms_fees_pms_fundMaster");
            });

            modelBuilder.Entity<PmsFmglintegration>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pms_FMGLIntegration");

                entity.Property(e => e.FmglMnemonic)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("FMGL_Mnemonic");

                entity.Property(e => e.FmglintegDbpassword)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FMGLInteg_DBPassword");

                entity.Property(e => e.FmglintegDbserver)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FMGLInteg_DBServer");

                entity.Property(e => e.FmglintegDbtype).HasColumnName("FMGLInteg_DBType");

                entity.Property(e => e.FmglintegDbuser)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FMGLInteg_DBUser");

                entity.Property(e => e.FundMasterCode).HasColumnName("FundMaster_code");

                entity.Property(e => e.FundMasterCostCenter)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fundMaster_costCenter");

                entity.Property(e => e.FundMasterGlcompCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fundMaster_GLCompCode");

                entity.Property(e => e.FundMasterGldbname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fundMaster_GLDBName");

                entity.Property(e => e.FundMasterSiteCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fundMaster_siteCode");

                entity.Property(e => e.GlmodeCode).HasColumnName("GLMode_code");

                entity.Property(e => e.LedgerId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("ledger_ID");
            });

            modelBuilder.Entity<PmsFminvOtherBond>(entity =>
            {
                entity.HasKey(e => new { e.FminvOtherBondsCode, e.FminvOtherBondsSno, e.FundMasterCode, e.FminvOtherBondsDate });

                entity.ToTable("pms_FMInvOtherBonds");

                entity.Property(e => e.FminvOtherBondsCode).HasColumnName("FMInvOtherBonds_Code");

                entity.Property(e => e.FminvOtherBondsSno).HasColumnName("FMInvOtherBonds_Sno");

                entity.Property(e => e.FundMasterCode).HasColumnName("FundMaster_code");

                entity.Property(e => e.FminvOtherBondsDate)
                    .HasColumnType("datetime")
                    .HasColumnName("FMInvOtherBonds_date");

                entity.Property(e => e.FminvOtherBondsActive).HasColumnName("FMInvOtherBonds_Active");

                entity.Property(e => e.FminvOtherBondsAmount)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("FMInvOtherBonds_Amount");

                entity.Property(e => e.FminvOtherBondsCreatedBy).HasColumnName("FMInvOtherBonds_createdBy");

                entity.Property(e => e.FminvOtherBondsCreatedWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("FMInvOtherBonds_createdWhen");

                entity.Property(e => e.FminvOtherBondsModifiedBy).HasColumnName("FMInvOtherBonds_modifiedBy");

                entity.Property(e => e.FminvOtherBondsModifiedWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("FMInvOtherBonds_modifiedWhen");

                entity.Property(e => e.FminvOtherBondsName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FMInvOtherBonds_Name");

                entity.Property(e => e.FminvOtherBondsRemarks)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("FMInvOtherBonds_Remarks");
            });

            modelBuilder.Entity<PmsFoOrder>(entity =>
            {
                entity.HasKey(e => new { e.OrderCode, e.TradInstCode, e.TradInstTypeCode })
                    .HasName("PK__pms_FoOrder__2B0A656D");

                entity.ToTable("pms_FoOrder");

                entity.HasIndex(e => e.OrderRefNo, "IX_pms_FoOrder")
                    .IsUnique();

                entity.Property(e => e.OrderCode)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("order_code");

                entity.Property(e => e.TradInstCode).HasColumnName("tradInst_code");

                entity.Property(e => e.TradInstTypeCode).HasColumnName("tradInstType_code");

                entity.Property(e => e.BrokerCode).HasColumnName("broker_Code");

                entity.Property(e => e.CalPeriodCode).HasColumnName("calPeriod_code");

                entity.Property(e => e.CalYearCode).HasColumnName("calYear_code");

                entity.Property(e => e.CfsTradeNo)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("CFS_tradeNo");

                entity.Property(e => e.FInstBranchCode).HasColumnName("fInstBranch_code");

                entity.Property(e => e.FInstBranchCode1).HasColumnName("fInstBranch_code1");

                entity.Property(e => e.FundCode).HasColumnName("fund_code");

                entity.Property(e => e.InvCommAppDate)
                    .HasColumnType("datetime")
                    .HasColumnName("invCommApp_date");

                entity.Property(e => e.MarketCode).HasColumnName("market_code");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("modified_date");

                entity.Property(e => e.OrderActualAmt)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("order_actualAmt");

                entity.Property(e => e.OrderActualQty)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("order_actualQty");

                entity.Property(e => e.OrderAmount)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("order_amount");

                entity.Property(e => e.OrderBrokerRate)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("order_brokerRate");

                entity.Property(e => e.OrderBrokerRateMode).HasColumnName("order_brokerRateMode");

                entity.Property(e => e.OrderCancelled).HasColumnName("order_cancelled");

                entity.Property(e => e.OrderCancelledDate)
                    .HasColumnType("datetime")
                    .HasColumnName("order_cancelledDate");

                entity.Property(e => e.OrderContraRefNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("order_contraRefNo");

                entity.Property(e => e.OrderCotratePer)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("order_COTRatePer");

                entity.Property(e => e.OrderCvtfut)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("order_CVTfut");

                entity.Property(e => e.OrderDate)
                    .HasColumnType("datetime")
                    .HasColumnName("order_date");

                entity.Property(e => e.OrderDateValidity)
                    .HasColumnType("datetime")
                    .HasColumnName("order_dateValidity");

                entity.Property(e => e.OrderDateValidityMode).HasColumnName("order_dateValidityMode");

                entity.Property(e => e.OrderFBrokerRate)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("order_fBrokerRate");

                entity.Property(e => e.OrderFFundCode).HasColumnName("order_fFundCode");

                entity.Property(e => e.OrderFSalePrice)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("order_fSalePrice");

                entity.Property(e => e.OrderFScriptCode)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("order_fScriptCode");

                entity.Property(e => e.OrderFState).HasColumnName("order_fState");

                entity.Property(e => e.OrderFedfut)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("order_FEDfut");

                entity.Property(e => e.OrderMode).HasColumnName("order_mode");

                entity.Property(e => e.OrderOnClearingSys).HasColumnName("order_onClearingSys");

                entity.Property(e => e.OrderOpenCloseFlag).HasColumnName("Order_openCloseFlag");

                entity.Property(e => e.OrderPriceLimit)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("order_priceLimit");

                entity.Property(e => e.OrderQuantity)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("order_quantity");

                entity.Property(e => e.OrderRefNo)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("order_refNo");

                entity.Property(e => e.OrderReferenceOrder)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("order_referenceOrder");

                entity.Property(e => e.OrderRemarks)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("order_remarks");

                entity.Property(e => e.OrderState).HasColumnName("order_state");

                entity.Property(e => e.OrderSubtype).HasColumnName("order_subtype");

                entity.Property(e => e.OrderUnExecAmount)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("order_UnExecAmount");

                entity.Property(e => e.OrderUnExecQuantity)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("order_UnExecQuantity");

                entity.Property(e => e.OrderUserDefNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("order_userDefNo");

                entity.Property(e => e.OrderYield)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("Order_Yield");

                entity.Property(e => e.ProductCode).HasColumnName("product_code");

                entity.Property(e => e.SettDateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("settDate_date");

                entity.Property(e => e.SettModeCode).HasColumnName("settMode_code");

                entity.Property(e => e.ShareAnnDate)
                    .HasColumnType("datetime")
                    .HasColumnName("shareAnn_date");

                entity.Property(e => e.UserCode).HasColumnName("user_code");

                entity.HasOne(d => d.BrokerCodeNavigation)
                    .WithMany(p => p.PmsFoOrders)
                    .HasForeignKey(d => d.BrokerCode)
                    .HasConstraintName("FK__pms_FoOrder__broke__395884C4");

                entity.HasOne(d => d.MarketCodeNavigation)
                    .WithMany(p => p.PmsFoOrders)
                    .HasForeignKey(d => d.MarketCode)
                    .HasConstraintName("FK__pms_FoOrder__marke__3864608B");

                entity.HasOne(d => d.TradInstTypeCodeNavigation)
                    .WithMany(p => p.PmsFoOrders)
                    .HasForeignKey(d => d.TradInstTypeCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__pms_FoOrder__tradI__3B40CD36");

                entity.HasOne(d => d.Cal)
                    .WithMany(p => p.PmsFoOrders)
                    .HasForeignKey(d => new { d.CalYearCode, d.CalPeriodCode })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__pms_FoOrder__37703C52");
            });

            modelBuilder.Entity<PmsFund>(entity =>
            {
                entity.HasKey(e => e.FundCode)
                    .HasName("PK__Funds__76CBA758");

                entity.ToTable("pms_funds");

                entity.HasIndex(e => e.FundName, "IX_Funds")
                    .IsUnique();

                entity.Property(e => e.FundCode)
                    .ValueGeneratedNever()
                    .HasColumnName("fund_code");

                entity.Property(e => e.FundBrkasCost).HasColumnName("fund_BrkasCost");

                entity.Property(e => e.FundBrkasCostFut).HasColumnName("fund_BrkasCostFut");

                entity.Property(e => e.FundBrkasCostPib).HasColumnName("fund_BrkasCostPIB");

                entity.Property(e => e.FundBrkasCostTbill).HasColumnName("fund_BrkasCostTBill");

                entity.Property(e => e.FundBrkasCostTfc).HasColumnName("fund_BrkasCostTFC");

                entity.Property(e => e.FundCdcasCost).HasColumnName("fund_CDCasCost");

                entity.Property(e => e.FundCostCenter)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("fund_costCenter");

                entity.Property(e => e.FundCreationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("fund_creationDate");

                entity.Property(e => e.FundCvtasCost).HasColumnName("fund_CVTasCost");

                entity.Property(e => e.FundCvtasCostFut).HasColumnName("fund_CVTasCostFut");

                entity.Property(e => e.FundCvtasCostPib).HasColumnName("fund_CVTasCostPIB");

                entity.Property(e => e.FundCvtasCostTbill).HasColumnName("fund_CVTasCostTBill");

                entity.Property(e => e.FundCvtasCostTfc).HasColumnName("fund_CVTasCostTFC");

                entity.Property(e => e.FundDesc)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("fund_desc");

                entity.Property(e => e.FundFedasCost).HasColumnName("fund_FEDasCost");

                entity.Property(e => e.FundFedasCostFut).HasColumnName("fund_FEDasCostFut");

                entity.Property(e => e.FundFutMovPer)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("fund_futMovPer")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.FundIsAccIrrtbill).HasColumnName("fund_IsAccIRRTbill");

                entity.Property(e => e.FundIsFrozen).HasColumnName("fund_IsFrozen");

                entity.Property(e => e.FundIsMmiaccrued)
                    .HasColumnName("fund_IsMMIAccrued")
                    .HasDefaultValueSql("(1)")
                    .HasComment("Accrued interest impact in first coupon or not");

                entity.Property(e => e.FundIsMmiaccruedPib).HasColumnName("fund_IsMMIAccruedPIB");

                entity.Property(e => e.FundIsMmiamort)
                    .HasColumnName("fund_IsMMIAmort")
                    .HasDefaultValueSql("(1)")
                    .HasComment("Amortization required or not");

                entity.Property(e => e.FundIsMmiamortPib).HasColumnName("fund_IsMMIAmortPIB");

                entity.Property(e => e.FundMasterCode).HasColumnName("fundMaster_code");

                entity.Property(e => e.FundMnemonic)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("fund_mnemonic");

                entity.Property(e => e.FundName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fund_name");

                entity.Property(e => e.FundNature).HasColumnName("Fund_Nature");

                entity.Property(e => e.FundPibpriceBasisMap).HasColumnName("fund_PIBPriceBasisMAP");

                entity.Property(e => e.FundPibyieldBasisMap).HasColumnName("fund_PIBYieldBasisMAP");

                entity.Property(e => e.FundUnRealGainLoss).HasColumnName("fund_unRealGainLoss");

                entity.Property(e => e.FundUseCarryCost).HasColumnName("fund_useCarryCost");

                entity.Property(e => e.FundYearEnd)
                    .HasColumnName("fund_YearEnd")
                    .HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<PmsFundLimit>(entity =>
            {
                entity.HasKey(e => new { e.FundLmtEntityCode, e.FundLmtEntityType, e.FundMasterCode });

                entity.ToTable("pms_fundLimits");

                entity.Property(e => e.FundLmtEntityCode).HasColumnName("fundLmt_entityCode");

                entity.Property(e => e.FundLmtEntityType).HasColumnName("fundLmt_entityType");

                entity.Property(e => e.FundMasterCode).HasColumnName("fundMaster_code");

                entity.Property(e => e.FundLmtAmount)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("fundLmt_amount");

                entity.Property(e => e.FundLmtModifiedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("fundLmt_modifiedDate");

                entity.Property(e => e.FundLmtPercentage)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("fundLmt_percentage");

                entity.Property(e => e.FundlmtAuthorizedBy).HasColumnName("FUNDLMT_authorizedBy");

                entity.Property(e => e.FundlmtAuthorizedWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("FUNDLMT_authorizedWhen");

                entity.Property(e => e.FundlmtCreatedBy).HasColumnName("FUNDLMT_createdBy");

                entity.Property(e => e.FundlmtCreatedWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("FUNDLMT_createdWhen");

                entity.Property(e => e.FundlmtIsAuthorized).HasColumnName("FUNDLMT_isAuthorized");

                entity.Property(e => e.FundlmtModifiedBy).HasColumnName("FUNDLMT_modifiedBy");

                entity.Property(e => e.FundlmtModifiedWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("FUNDLMT_modifiedWhen");

                entity.Property(e => e.FundlmtReason)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("FUNDLMT_reason");
            });

            modelBuilder.Entity<PmsFundMaster>(entity =>
            {
                entity.HasKey(e => e.FundMasterCode);

                entity.ToTable("pms_fundMaster");

                entity.HasIndex(e => e.FundMasterName, "IX_pms_fundMaster")
                    .IsUnique();

                entity.Property(e => e.FundMasterCode)
                    .ValueGeneratedNever()
                    .HasColumnName("fundMaster_code");

                entity.Property(e => e.FInstBranchCode).HasColumnName("fInstBranch_code");

                entity.Property(e => e.FInstCode).HasColumnName("fInst_code");

                entity.Property(e => e.FInstTypeCode).HasColumnName("fInstType_code");

                entity.Property(e => e.FundMasterAccNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fundMaster_accNo");

                entity.Property(e => e.FundMasterBankName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("fundMaster_bankName");

                entity.Property(e => e.FundMasterCapital)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("fundMaster_capital");

                entity.Property(e => e.FundMasterCostCenter)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("fundMaster_costCenter");

                entity.Property(e => e.FundMasterDesc)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("fundMaster_desc");

                entity.Property(e => e.FundMasterEodstatus).HasColumnName("fundMaster_EODStatus");

                entity.Property(e => e.FundMasterGlcompCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("fundMaster_GLCompCode");

                entity.Property(e => e.FundMasterGldbname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fundMaster_GLDBName");

                entity.Property(e => e.FundMasterMfeePer)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("fundMaster_MFeePer");

                entity.Property(e => e.FundMasterMnemonic)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("fundMaster_mnemonic");

                entity.Property(e => e.FundMasterModifiDate)
                    .HasColumnType("datetime")
                    .HasColumnName("fundMaster_modifiDate");

                entity.Property(e => e.FundMasterName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fundMaster_name");

                entity.Property(e => e.FundMasterNavBalance).HasColumnName("fundMaster_NavBalance");

                entity.Property(e => e.FundMasterNavCalcType).HasColumnName("fundMaster_NavCalcType");

                entity.Property(e => e.FundMasterNavRptCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("fundMaster_NavRptCode");

                entity.Property(e => e.FundMasterSaleLoad)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("fundMaster_saleLoad");

                entity.Property(e => e.FundMasterSiteCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("fundMaster_siteCode");

                entity.Property(e => e.FundmasterNcssid)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("fundmaster_NCSSID");

                entity.Property(e => e.FundmasterType)
                    .HasColumnName("fundmaster_type")
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.FundmasterUin)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("fundmaster_UIN");

                entity.Property(e => e.UhaFundMastercode).HasColumnName("uha_fundMastercode");
            });

            modelBuilder.Entity<PmsFundMasterNote>(entity =>
            {
                entity.HasKey(e => new { e.FmnCode, e.FundMasterCode, e.FmnDate });

                entity.ToTable("pms_FundMasterNotes");

                entity.Property(e => e.FmnCode).HasColumnName("FMN_Code");

                entity.Property(e => e.FundMasterCode).HasColumnName("FundMaster_code");

                entity.Property(e => e.FmnDate)
                    .HasColumnType("datetime")
                    .HasColumnName("FMN_Date");

                entity.Property(e => e.FmnCreatedBy).HasColumnName("FMN_CreatedBy");

                entity.Property(e => e.FmnCreatedWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("FMN_CreatedWhen");

                entity.Property(e => e.FmnIsActive).HasColumnName("FMN_IsActive");

                entity.Property(e => e.FmnModifiedBy).HasColumnName("FMN_ModifiedBy");

                entity.Property(e => e.FmnModifiedWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("FMN_ModifiedWhen");

                entity.Property(e => e.FmnNotes)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FMN_Notes");

                entity.Property(e => e.FmnSno).HasColumnName("FMN_Sno");
            });

            modelBuilder.Entity<PmsFundMasterUser>(entity =>
            {
                entity.HasKey(e => new { e.FuSno, e.FundMasterCode, e.UserCode })
                    .HasName("PK_PMS_FUNDMASTERUSER");

                entity.ToTable("pms_FundMasterUser");

                entity.Property(e => e.FuSno).HasColumnName("FU_sno");

                entity.Property(e => e.FundMasterCode).HasColumnName("fundMaster_code");

                entity.Property(e => e.UserCode).HasColumnName("user_code");

                entity.Property(e => e.FuCreatedBy).HasColumnName("FU_createdBy");

                entity.Property(e => e.FuCreatedWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("FU_createdWhen");

                entity.Property(e => e.FuIsLinked).HasColumnName("FU_isLinked");

                entity.Property(e => e.FuLinkingDate)
                    .HasColumnType("datetime")
                    .HasColumnName("FU_linkingDate");

                entity.Property(e => e.FuModifiedBy).HasColumnName("FU_modifiedBy");

                entity.Property(e => e.FuModifiedWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("FU_modifiedWhen");

                entity.Property(e => e.UserName)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("user_name");
            });

            modelBuilder.Entity<PmsFundTransfer>(entity =>
            {
                entity.HasKey(e => new { e.FundMasterCode, e.FundtransferIssueDate })
                    .HasName("PK_pms_fundBankTransfer");

                entity.ToTable("pms_fundTransfer");

                entity.Property(e => e.FundMasterCode).HasColumnName("fundMaster_code");

                entity.Property(e => e.FundtransferIssueDate)
                    .HasColumnType("datetime")
                    .HasColumnName("fundtransfer_issueDate");

                entity.Property(e => e.FundTransferCode).HasColumnName("fundTransfer_code");

                entity.Property(e => e.FundtransferClearingeDate)
                    .HasColumnType("datetime")
                    .HasColumnName("fundtransfer_clearingeDate");

                entity.Property(e => e.FundtransferCreatedBy).HasColumnName("fundtransfer_createdBy");

                entity.Property(e => e.FundtransferCreatedWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("fundtransfer_createdWhen");

                entity.Property(e => e.FundtransferFromBank)
                    .HasMaxLength(50)
                    .HasColumnName("fundtransfer_fromBank");

                entity.Property(e => e.FundtransferFromBankDesc)
                    .HasMaxLength(50)
                    .HasColumnName("fundtransfer_fromBankDesc");

                entity.Property(e => e.FundtransferMode).HasColumnName("fundtransfer_Mode");

                entity.Property(e => e.FundtransferModifiedBy).HasColumnName("fundtransfer_modifiedBy");

                entity.Property(e => e.FundtransferModifiedWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("fundtransfer_modifiedWhen");

                entity.Property(e => e.FundtransferSerialNo)
                    .HasMaxLength(50)
                    .HasColumnName("fundtransfer_serialNo");

                entity.Property(e => e.FundtransferStatus).HasColumnName("fundtransfer_Status");

                entity.Property(e => e.FundtransferToBank)
                    .HasMaxLength(50)
                    .HasColumnName("fundtransfer_toBank");

                entity.Property(e => e.FundtransferToBankDesc)
                    .HasMaxLength(50)
                    .HasColumnName("fundtransfer_toBankDesc");

                entity.Property(e => e.FundtransferTransferAmt)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("fundtransfer_transferAmt");

                entity.Property(e => e.FundtransferType).HasColumnName("fundtransfer_Type");

                entity.Property(e => e.VmSno).HasColumnName("VM_SNo");
            });

            modelBuilder.Entity<PmsFundcapital>(entity =>
            {
                entity.HasKey(e => new { e.FundCapCode, e.FundCapDate, e.FundMasterCode });

                entity.ToTable("pms_fundcapital");

                entity.Property(e => e.FundCapCode)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("fundCap_code");

                entity.Property(e => e.FundCapDate)
                    .HasColumnType("datetime")
                    .HasColumnName("fundCap_date");

                entity.Property(e => e.FundMasterCode).HasColumnName("fundMaster_code");

                entity.Property(e => e.CashTypeCode).HasColumnName("cashTypeCode");

                entity.Property(e => e.FInstBranchCode).HasColumnName("fInstBranch_code");

                entity.Property(e => e.FInstCode).HasColumnName("fInst_code");

                entity.Property(e => e.FInstTypeCode).HasColumnName("fInstType_code");

                entity.Property(e => e.FundCapAccuralMethod).HasColumnName("fundCap_AccuralMethod");

                entity.Property(e => e.FundCapAmount)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("fundCap_amount");

                entity.Property(e => e.FundCapDesc)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("fundCap_desc");

                entity.Property(e => e.FundCapMaturityDate)
                    .HasColumnType("datetime")
                    .HasColumnName("fundCap_MaturityDate");

                entity.Property(e => e.FundCapQuantity)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("fundCap_quantity");

                entity.Property(e => e.FundCapReportType).HasColumnName("fundCap_ReportType");

                entity.Property(e => e.FundCapState)
                    .HasColumnName("fundCap_state")
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.FundCapType).HasColumnName("fundCap_type");
            });

            modelBuilder.Entity<PmsFundsNav>(entity =>
            {
                entity.HasKey(e => new { e.FundNavDate, e.FundMasterCode });

                entity.ToTable("pms_FundsNAV");

                entity.Property(e => e.FundNavDate)
                    .HasColumnType("datetime")
                    .HasColumnName("fundNAV_date");

                entity.Property(e => e.FundMasterCode).HasColumnName("fundMaster_code");

                entity.Property(e => e.FundNavAdvances)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("fundNav_Advances");

                entity.Property(e => e.FundNavAppDim)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("fundNAV_AppDim");

                entity.Property(e => e.FundNavCapital)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("fundNAV_capital");

                entity.Property(e => e.FundNavComKpi1)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("fundNAV_comKPI1");

                entity.Property(e => e.FundNavDesc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fundNAV_desc");

                entity.Property(e => e.FundNavFundingCost)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("fundNav_FundingCost");

                entity.Property(e => e.FundNavIndexKse)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("fundNav_index_kse");

                entity.Property(e => e.FundNavInvSec)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("fundNav_invSec");

                entity.Property(e => e.FundNavNav)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("fundNAV_NAV");

                entity.Property(e => e.FundNavOffPrice)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("fundNav_offPrice");

                entity.Property(e => e.FundNavRedmpPrice)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("fundNav_redmpPrice");

                entity.Property(e => e.FundNavState).HasColumnName("fundNAV_state");

                entity.Property(e => e.FundNavTotalAssets)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("fundNAV_totalAssets");

                entity.Property(e => e.FundNavTotalCapital)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("fundNav_totalCapital");

                entity.Property(e => e.FundNavTotalLiabilities)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("fundNAV_totalLiabilities");

                entity.Property(e => e.FundNavUnits)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("fundNAV_units");

                entity.Property(e => e.FundNavUserCode).HasColumnName("fundNAV_userCode");

                entity.Property(e => e.FundNavUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fundNAV_userName");

                entity.HasOne(d => d.FundMasterCodeNavigation)
                    .WithMany(p => p.PmsFundsNavs)
                    .HasForeignKey(d => d.FundMasterCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_pms_FundsNAV_pms_fundMaster");
            });

            modelBuilder.Entity<PmsFutureTradeLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pms_FutureTradeLogs");

                entity.Property(e => e.CfsBrokerCode).HasColumnName("CFS_brokerCode");

                entity.Property(e => e.FundMasterCode).HasColumnName("fundMaster_code");

                entity.Property(e => e.NccBuyAmount)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("ncc_buyAmount");

                entity.Property(e => e.NccBuyQty)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("ncc_buyQty");

                entity.Property(e => e.NccBuyRate)
                    .HasColumnType("decimal(28, 6)")
                    .HasColumnName("ncc_buyRate");

                entity.Property(e => e.NccCfsdate)
                    .HasColumnType("datetime")
                    .HasColumnName("ncc_CFSDate");

                entity.Property(e => e.NccCfsticketNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ncc_CFSTicketNo");

                entity.Property(e => e.NccClientCode).HasColumnName("ncc_clientCode");

                entity.Property(e => e.NccCode).HasColumnName("ncc_code");

                entity.Property(e => e.NccConfId)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ncc_confID");

                entity.Property(e => e.NccCounterId)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("ncc_counterID");

                entity.Property(e => e.NccCounterTrader)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ncc_counterTrader");

                entity.Property(e => e.NccDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ncc_date");

                entity.Property(e => e.NccIniCmid).HasColumnName("ncc_iniCMID");

                entity.Property(e => e.NccIniSysId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ncc_iniSysID");

                entity.Property(e => e.NccMarket)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ncc_market");

                entity.Property(e => e.NccModfyidate)
                    .HasColumnType("datetime")
                    .HasColumnName("ncc_modfyidate");

                entity.Property(e => e.NccModifyBy).HasColumnName("ncc_modifyBy");

                entity.Property(e => e.NccModule)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ncc_module");

                entity.Property(e => e.NccOpenDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ncc_openDate");

                entity.Property(e => e.NccProcessState).HasColumnName("ncc_processState");

                entity.Property(e => e.NccSecName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ncc_secName");

                entity.Property(e => e.NccSecSysmol)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ncc_secSysmol");

                entity.Property(e => e.NccSellAmount)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("ncc_sellAmount");

                entity.Property(e => e.NccSellQty)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("ncc_sellQty");

                entity.Property(e => e.NccSellRate)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("ncc_sellRate");

                entity.Property(e => e.NccSetteMode).HasColumnName("ncc_setteMode");

                entity.Property(e => e.NccStatus)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ncc_status");

                entity.Property(e => e.NccTicketNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ncc_ticketNo");

                entity.Property(e => e.NccTrader).HasColumnName("ncc_trader");

                entity.Property(e => e.NccTranDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ncc_tranDate");

                entity.Property(e => e.NccTranId)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("ncc_tranID");
            });

            modelBuilder.Entity<PmsGlAccountDetail>(entity =>
            {
                entity.HasKey(e => new { e.GlHeadEntityType, e.GlHeadAccType, e.GlDetailEntityCode, e.FundCode })
                    .HasName("PK_pms_glAccountDetail");

                entity.ToTable("pms_glAccountDetails");

                entity.Property(e => e.GlHeadEntityType).HasColumnName("glHead_entityType");

                entity.Property(e => e.GlHeadAccType).HasColumnName("glHead_accType");

                entity.Property(e => e.GlDetailEntityCode).HasColumnName("glDetail_entityCode");

                entity.Property(e => e.FundCode).HasColumnName("fund_code");

                entity.Property(e => e.FundMasterCode).HasColumnName("FundMaster_code");

                entity.Property(e => e.GlAccountDetailCode).HasColumnName("glAccountDetail_code");

                entity.Property(e => e.GlAccountDetailModule).HasColumnName("glAccountDetail_module");

                entity.Property(e => e.GlDetailAccCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("glDetail_accCode");

                entity.Property(e => e.GlDetailAccTitle)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("glDetail_accTitle");

                entity.Property(e => e.GlDetailColtrlSubType).HasColumnName("glDetail_coltrlSubType");

                entity.Property(e => e.GlDetailColtrlType).HasColumnName("glDetail_coltrlType");

                entity.Property(e => e.GlDetailDesc)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("glDetail_desc");

                entity.Property(e => e.SubLedger)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("SUB_LEDGER");
            });

            modelBuilder.Entity<PmsGlAccountHead>(entity =>
            {
                entity.HasKey(e => new { e.GlHeadEntityType, e.GlHeadAccType });

                entity.ToTable("pms_glAccountHeads");

                entity.Property(e => e.GlHeadEntityType).HasColumnName("glHead_entityType");

                entity.Property(e => e.GlHeadAccType).HasColumnName("glHead_accType");

                entity.Property(e => e.GlHeadAccTitle)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("glHead_accTitle");
            });

            modelBuilder.Entity<PmsGlInterfaceHbl>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PMS_GL_INTERFACE_HBL");

                entity.Property(e => e.AccountingDate)
                    .HasColumnType("date")
                    .HasColumnName("ACCOUNTING_DATE");

                entity.Property(e => e.Cby).HasColumnName("CBY");

                entity.Property(e => e.Cdate)
                    .HasColumnType("date")
                    .HasColumnName("CDATE");

                entity.Property(e => e.CrAmount)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("CR_AMOUNT");

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CURRENCY_CODE");

                entity.Property(e => e.DrAmount)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("DR_AMOUNT");

                entity.Property(e => e.ExternalReference)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("EXTERNAL_REFERENCE");

                entity.Property(e => e.FundCode).HasColumnName("FUND_CODE");

                entity.Property(e => e.FundmasterCode).HasColumnName("FUNDMASTER_CODE");

                entity.Property(e => e.GroupId).HasColumnName("GROUP_ID");

                entity.Property(e => e.JeCategory)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("JE_CATEGORY");

                entity.Property(e => e.JeSource)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("JE_SOURCE");

                entity.Property(e => e.LedgerId).HasColumnName("LEDGER_ID");

                entity.Property(e => e.LineDescription)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("LINE_DESCRIPTION");

                entity.Property(e => e.LineRef1)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("LINE_REF1");

                entity.Property(e => e.LineRef2)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("LINE_REF2");

                entity.Property(e => e.OutMsg)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("OUT_MSG");

                entity.Property(e => e.RefJournalName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("REF_JOURNAL_NAME");

                entity.Property(e => e.Segment1)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SEGMENT1");

                entity.Property(e => e.Segment2)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SEGMENT2");

                entity.Property(e => e.Segment3)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SEGMENT3");

                entity.Property(e => e.Segment4)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SEGMENT4");

                entity.Property(e => e.Segment5)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SEGMENT5");

                entity.Property(e => e.Segment6)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SEGMENT6");

                entity.Property(e => e.Segment7)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SEGMENT7");

                entity.Property(e => e.Segment8)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SEGMENT8");

                entity.Property(e => e.Segment9)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SEGMENT9");

                entity.Property(e => e.Status)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("STATUS");
            });

            modelBuilder.Entity<PmsGlParam>(entity =>
            {
                entity.HasKey(e => e.GlParamCode);

                entity.ToTable("pms_glParams");

                entity.Property(e => e.GlParamCode).HasColumnName("glParam_code");

                entity.Property(e => e.GlParamAccrualEdays).HasColumnName("glParam_accrualEDays");

                entity.Property(e => e.GlParamAccrualPolicy).HasColumnName("glParam_accrualPolicy");

                entity.Property(e => e.GlParamAccrualSdays).HasColumnName("glParam_accrualSDays");

                entity.Property(e => e.GlParamChangeTransfer).HasColumnName("glParam_changeTransfer");

                entity.Property(e => e.GlParamCostCntrBasis).HasColumnName("glParam_costCntrBasis");

                entity.Property(e => e.GlParamDateBasis).HasColumnName("glParam_dateBasis");

                entity.Property(e => e.GlParamIntegMode).HasColumnName("glParam_integMode");

                entity.Property(e => e.GlParamVchrTransferState).HasColumnName("glParam_vchrTransferState");
            });

            modelBuilder.Entity<PmsGlReversalVchrdetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pms_GL_REVERSAL_VCHRDETAIL");

                entity.Property(e => e.GlDetailEntityCode).HasColumnName("glDetail_entityCode");

                entity.Property(e => e.GlHeadAccType).HasColumnName("glHead_accType");

                entity.Property(e => e.GlHeadEntityType).HasColumnName("glHead_entityType");

                entity.Property(e => e.TransactionType).HasColumnName("transaction_type");

                entity.Property(e => e.VdAccCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("VD_ACC_CODE");

                entity.Property(e => e.VdAmtSetoff)
                    .HasColumnType("numeric(20, 6)")
                    .HasColumnName("VD_AMT_SETOFF");

                entity.Property(e => e.VdBankStno)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("VD_BANK_STNO");

                entity.Property(e => e.VdCoCode)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("VD_CO_CODE");

                entity.Property(e => e.VdColtrlSubType).HasColumnName("VD_coltrlSubType");

                entity.Property(e => e.VdColtrlType).HasColumnName("VD_coltrlType");

                entity.Property(e => e.VdCostcntrCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("VD_COSTCNTR_CODE");

                entity.Property(e => e.VdCrAmt)
                    .HasColumnType("numeric(25, 6)")
                    .HasColumnName("VD_CR_AMT");

                entity.Property(e => e.VdCrRepcurr1)
                    .HasColumnType("numeric(20, 6)")
                    .HasColumnName("VD_CR_REPCURR1");

                entity.Property(e => e.VdCrRepcurr2)
                    .HasColumnType("numeric(20, 6)")
                    .HasColumnName("VD_CR_REPCURR2");

                entity.Property(e => e.VdCrRepcurr3)
                    .HasColumnType("numeric(20, 6)")
                    .HasColumnName("VD_CR_REPCURR3");

                entity.Property(e => e.VdCrRepcurr4)
                    .HasColumnType("numeric(20, 6)")
                    .HasColumnName("VD_CR_REPCURR4");

                entity.Property(e => e.VdCrRepcurr5)
                    .HasColumnType("numeric(20, 6)")
                    .HasColumnName("VD_CR_REPCURR5");

                entity.Property(e => e.VdCreatedby)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("VD_CREATEDBY");

                entity.Property(e => e.VdCreatedwhen)
                    .HasColumnType("datetime")
                    .HasColumnName("VD_CREATEDWHEN");

                entity.Property(e => e.VdCurrCode)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("VD_CURR_CODE");

                entity.Property(e => e.VdDesc)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("VD_DESC");

                entity.Property(e => e.VdDescArb)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("VD_DESC_ARB");

                entity.Property(e => e.VdDrAmt)
                    .HasColumnType("numeric(25, 6)")
                    .HasColumnName("VD_DR_AMT");

                entity.Property(e => e.VdDrRepcurr1)
                    .HasColumnType("numeric(20, 6)")
                    .HasColumnName("VD_DR_REPCURR1");

                entity.Property(e => e.VdDrRepcurr2)
                    .HasColumnType("numeric(20, 6)")
                    .HasColumnName("VD_DR_REPCURR2");

                entity.Property(e => e.VdDrRepcurr3)
                    .HasColumnType("numeric(20, 6)")
                    .HasColumnName("VD_DR_REPCURR3");

                entity.Property(e => e.VdDrRepcurr4)
                    .HasColumnType("numeric(20, 6)")
                    .HasColumnName("VD_DR_REPCURR4");

                entity.Property(e => e.VdDrRepcurr5)
                    .HasColumnType("numeric(20, 6)")
                    .HasColumnName("VD_DR_REPCURR5");

                entity.Property(e => e.VdDt)
                    .HasColumnType("datetime")
                    .HasColumnName("VD_DT");

                entity.Property(e => e.VdDtHij)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("VD_DT_HIJ");

                entity.Property(e => e.VdExchRate)
                    .HasColumnType("numeric(20, 6)")
                    .HasColumnName("VD_EXCH_RATE");

                entity.Property(e => e.VdFctransTag)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("VD_FCTRANS_TAG");

                entity.Property(e => e.VdModifiedby)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("VD_MODIFIEDBY");

                entity.Property(e => e.VdModifiedwhen)
                    .HasColumnType("datetime")
                    .HasColumnName("VD_MODIFIEDWHEN");

                entity.Property(e => e.VdPacketRecvd)
                    .HasColumnType("numeric(20, 6)")
                    .HasColumnName("VD_PACKET_RECVD");

                entity.Property(e => e.VdPacketSent)
                    .HasColumnType("numeric(20, 6)")
                    .HasColumnName("VD_PACKET_SENT");

                entity.Property(e => e.VdPartyCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("VD_PARTY_CODE");

                entity.Property(e => e.VdPstTag)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("VD_PST_TAG");

                entity.Property(e => e.VdQuantity)
                    .HasColumnType("numeric(20, 6)")
                    .HasColumnName("VD_QUANTITY");

                entity.Property(e => e.VdReconDt)
                    .HasColumnType("datetime")
                    .HasColumnName("VD_RECON_DT");

                entity.Property(e => e.VdReconDtHij)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("VD_RECON_DT_HIJ");

                entity.Property(e => e.VdReconTag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("VD_RECON_TAG");

                entity.Property(e => e.VdRef)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("VD_REF");

                entity.Property(e => e.VdRef1)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("VD_REF1");

                entity.Property(e => e.VdRef2)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("VD_REF2");

                entity.Property(e => e.VdRef3)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("VD_REF3");

                entity.Property(e => e.VdSiteCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("VD_SITE_CODE");

                entity.Property(e => e.VdTransNo)
                    .HasColumnType("numeric(20, 6)")
                    .HasColumnName("VD_TRANS_NO");

                entity.Property(e => e.VdVchrNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("VD_VCHR_NO");

                entity.Property(e => e.VdVchrPer)
                    .HasColumnType("numeric(20, 6)")
                    .HasColumnName("VD_VCHR_PER");

                entity.Property(e => e.VdVchrType)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("VD_VCHR_TYPE");

                entity.Property(e => e.VdVerified)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("VD_VERIFIED");

                entity.Property(e => e.VdYear)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("VD_YEAR");

                entity.Property(e => e.VmSno)
                    .HasColumnType("decimal(25, 1)")
                    .HasColumnName("vm_Sno");
            });

            modelBuilder.Entity<PmsGlReversalVchrmaster>(entity =>
            {
                entity.HasKey(e => new { e.VmSno, e.TransactionType, e.VmCreatedwhen })
                    .HasName("PK_pms_GL_REVERSE_VCHRMASTER");

                entity.ToTable("pms_GL_REVERSAL_VCHRMASTER");

                entity.Property(e => e.VmSno)
                    .HasColumnType("decimal(25, 1)")
                    .HasColumnName("VM_SNO");

                entity.Property(e => e.TransactionType).HasColumnName("transaction_type");

                entity.Property(e => e.VmCreatedwhen)
                    .HasColumnType("datetime")
                    .HasColumnName("VM_CREATEDWHEN");

                entity.Property(e => e.BrokerCode).HasColumnName("broker_code");

                entity.Property(e => e.ClearingCompCode).HasColumnName("clearingComp_Code");

                entity.Property(e => e.CouponCode).HasColumnName("coupon_code");

                entity.Property(e => e.CpoptionCode).HasColumnName("CPoption_code");

                entity.Property(e => e.CpoptionType).HasColumnName("CPoption_type");

                entity.Property(e => e.FInstBranchCode).HasColumnName("fInstBranch_code");

                entity.Property(e => e.FInstTranCode)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("fInstTran_code");

                entity.Property(e => e.FInstTranType).HasColumnName("fInstTran_type");

                entity.Property(e => e.FeeCode).HasColumnName("fee_code");

                entity.Property(e => e.FundCode).HasColumnName("fund_code");

                entity.Property(e => e.FundMasterCode).HasColumnName("fundMaster_code");

                entity.Property(e => e.OrdExecCode)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("ordExec_code");

                entity.Property(e => e.OrdExecDealTickNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ordExec_dealTickNo");

                entity.Property(e => e.OrderCode)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("order_code");

                entity.Property(e => e.OrderOnClearingSys).HasColumnName("order_onClearingSys");

                entity.Property(e => e.ProductCode).HasColumnName("product_code");

                entity.Property(e => e.SettDateCode)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("settDate_code");

                entity.Property(e => e.SettDateType).HasColumnName("settDate_type");

                entity.Property(e => e.ShareAnnDate)
                    .HasColumnType("datetime")
                    .HasColumnName("shareAnn_date");

                entity.Property(e => e.TradInstCode).HasColumnName("tradInst_code");

                entity.Property(e => e.TradInstTypeCode).HasColumnName("tradInstType_code");

                entity.Property(e => e.TranMasterDate)
                    .HasColumnType("datetime")
                    .HasColumnName("tranMaster_date");

                entity.Property(e => e.ValuationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("valuation_date");

                entity.Property(e => e.VmAccruTag)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("VM_ACCRU_TAG");

                entity.Property(e => e.VmClearingParty).HasColumnName("VM_clearingParty");

                entity.Property(e => e.VmCoCode)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("VM_CO_CODE");

                entity.Property(e => e.VmColtrlSubType).HasColumnName("VM_coltrlSubType");

                entity.Property(e => e.VmColtrlType).HasColumnName("VM_coltrlType");

                entity.Property(e => e.VmCreatedby)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("VM_CREATEDBY");

                entity.Property(e => e.VmDeleted)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("VM_DELETED");

                entity.Property(e => e.VmDesc)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("VM_DESC");

                entity.Property(e => e.VmDescArb)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("VM_DESC_ARB");

                entity.Property(e => e.VmDt)
                    .HasColumnType("datetime")
                    .HasColumnName("VM_DT");

                entity.Property(e => e.VmDtHij)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("VM_DT_HIJ");

                entity.Property(e => e.VmDualcurrTag)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("VM_DUALCURR_TAG");

                entity.Property(e => e.VmGlPosted).HasColumnName("VM_glPosted");

                entity.Property(e => e.VmModifiedby)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("VM_MODIFIEDBY");

                entity.Property(e => e.VmModifiedwhen)
                    .HasColumnType("datetime")
                    .HasColumnName("VM_MODIFIEDWHEN");

                entity.Property(e => e.VmNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("VM_NO");

                entity.Property(e => e.VmPacketRecvd)
                    .HasColumnType("numeric(20, 6)")
                    .HasColumnName("VM_PACKET_RECVD");

                entity.Property(e => e.VmPacketSent)
                    .HasColumnType("numeric(20, 6)")
                    .HasColumnName("VM_PACKET_SENT");

                entity.Property(e => e.VmPer)
                    .HasColumnType("numeric(20, 6)")
                    .HasColumnName("VM_PER");

                entity.Property(e => e.VmPstTag)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("VM_PST_TAG");

                entity.Property(e => e.VmSiteCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("VM_SITE_CODE");

                entity.Property(e => e.VmStatus).HasColumnName("VM_status");

                entity.Property(e => e.VmToBeReverse).HasColumnName("VM_toBeReverse");

                entity.Property(e => e.VmTransfer).HasColumnName("VM_TRANSFER");

                entity.Property(e => e.VmTransfertag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("VM_TRANSFERTAG");

                entity.Property(e => e.VmVchrType)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("VM_VCHR_TYPE");

                entity.Property(e => e.VmVerified)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("VM_VERIFIED");

                entity.Property(e => e.VmYear)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("VM_YEAR");
            });

            modelBuilder.Entity<PmsGlVchrdetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pms_GL_VCHRDETAIL");

                entity.Property(e => e.GlDetailEntityCode).HasColumnName("glDetail_entityCode");

                entity.Property(e => e.GlHeadAccType).HasColumnName("glHead_accType");

                entity.Property(e => e.GlHeadEntityType).HasColumnName("glHead_entityType");

                entity.Property(e => e.TransactionType).HasColumnName("transaction_type");

                entity.Property(e => e.VdAccCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("VD_ACC_CODE");

                entity.Property(e => e.VdAmtSetoff)
                    .HasColumnType("numeric(20, 6)")
                    .HasColumnName("VD_AMT_SETOFF");

                entity.Property(e => e.VdBankStno)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("VD_BANK_STNO");

                entity.Property(e => e.VdCoCode)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("VD_CO_CODE");

                entity.Property(e => e.VdColtrlSubType).HasColumnName("VD_coltrlSubType");

                entity.Property(e => e.VdColtrlType).HasColumnName("VD_coltrlType");

                entity.Property(e => e.VdCostcntrCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("VD_COSTCNTR_CODE");

                entity.Property(e => e.VdCrAmt)
                    .HasColumnType("numeric(25, 6)")
                    .HasColumnName("VD_CR_AMT");

                entity.Property(e => e.VdCrRepcurr1)
                    .HasColumnType("numeric(20, 6)")
                    .HasColumnName("VD_CR_REPCURR1");

                entity.Property(e => e.VdCrRepcurr2)
                    .HasColumnType("numeric(20, 6)")
                    .HasColumnName("VD_CR_REPCURR2");

                entity.Property(e => e.VdCrRepcurr3)
                    .HasColumnType("numeric(20, 6)")
                    .HasColumnName("VD_CR_REPCURR3");

                entity.Property(e => e.VdCrRepcurr4)
                    .HasColumnType("numeric(20, 6)")
                    .HasColumnName("VD_CR_REPCURR4");

                entity.Property(e => e.VdCrRepcurr5)
                    .HasColumnType("numeric(20, 6)")
                    .HasColumnName("VD_CR_REPCURR5");

                entity.Property(e => e.VdCreatedby)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("VD_CREATEDBY");

                entity.Property(e => e.VdCreatedwhen)
                    .HasColumnType("datetime")
                    .HasColumnName("VD_CREATEDWHEN");

                entity.Property(e => e.VdCurrCode)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("VD_CURR_CODE");

                entity.Property(e => e.VdDesc)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("VD_DESC");

                entity.Property(e => e.VdDescArb)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("VD_DESC_ARB");

                entity.Property(e => e.VdDrAmt)
                    .HasColumnType("numeric(25, 6)")
                    .HasColumnName("VD_DR_AMT");

                entity.Property(e => e.VdDrRepcurr1)
                    .HasColumnType("numeric(20, 6)")
                    .HasColumnName("VD_DR_REPCURR1");

                entity.Property(e => e.VdDrRepcurr2)
                    .HasColumnType("numeric(20, 6)")
                    .HasColumnName("VD_DR_REPCURR2");

                entity.Property(e => e.VdDrRepcurr3)
                    .HasColumnType("numeric(20, 6)")
                    .HasColumnName("VD_DR_REPCURR3");

                entity.Property(e => e.VdDrRepcurr4)
                    .HasColumnType("numeric(20, 6)")
                    .HasColumnName("VD_DR_REPCURR4");

                entity.Property(e => e.VdDrRepcurr5)
                    .HasColumnType("numeric(20, 6)")
                    .HasColumnName("VD_DR_REPCURR5");

                entity.Property(e => e.VdDt)
                    .HasColumnType("datetime")
                    .HasColumnName("VD_DT");

                entity.Property(e => e.VdDtHij)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("VD_DT_HIJ");

                entity.Property(e => e.VdExchRate)
                    .HasColumnType("numeric(20, 6)")
                    .HasColumnName("VD_EXCH_RATE");

                entity.Property(e => e.VdFctransTag)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("VD_FCTRANS_TAG");

                entity.Property(e => e.VdModifiedby)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("VD_MODIFIEDBY");

                entity.Property(e => e.VdModifiedwhen)
                    .HasColumnType("datetime")
                    .HasColumnName("VD_MODIFIEDWHEN");

                entity.Property(e => e.VdPacketRecvd)
                    .HasColumnType("numeric(20, 6)")
                    .HasColumnName("VD_PACKET_RECVD");

                entity.Property(e => e.VdPacketSent)
                    .HasColumnType("numeric(20, 6)")
                    .HasColumnName("VD_PACKET_SENT");

                entity.Property(e => e.VdPartyCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("VD_PARTY_CODE");

                entity.Property(e => e.VdPstTag)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("VD_PST_TAG");

                entity.Property(e => e.VdQuantity)
                    .HasColumnType("numeric(20, 6)")
                    .HasColumnName("VD_QUANTITY");

                entity.Property(e => e.VdReconDt)
                    .HasColumnType("datetime")
                    .HasColumnName("VD_RECON_DT");

                entity.Property(e => e.VdReconDtHij)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("VD_RECON_DT_HIJ");

                entity.Property(e => e.VdReconTag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("VD_RECON_TAG");

                entity.Property(e => e.VdRef)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("VD_REF");

                entity.Property(e => e.VdRef1)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("VD_REF1");

                entity.Property(e => e.VdRef2)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("VD_REF2");

                entity.Property(e => e.VdRef3)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("VD_REF3");

                entity.Property(e => e.VdSiteCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("VD_SITE_CODE");

                entity.Property(e => e.VdTransNo)
                    .HasColumnType("numeric(20, 6)")
                    .HasColumnName("VD_TRANS_NO");

                entity.Property(e => e.VdVchrNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("VD_VCHR_NO");

                entity.Property(e => e.VdVchrPer)
                    .HasColumnType("numeric(20, 6)")
                    .HasColumnName("VD_VCHR_PER");

                entity.Property(e => e.VdVchrType)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("VD_VCHR_TYPE");

                entity.Property(e => e.VdVerified)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("VD_VERIFIED");

                entity.Property(e => e.VdYear)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("VD_YEAR");

                entity.Property(e => e.VmSno)
                    .HasColumnType("decimal(25, 1)")
                    .HasColumnName("vm_Sno");
            });

            modelBuilder.Entity<PmsGlVchrmaster>(entity =>
            {
                entity.HasKey(e => new { e.VmSno, e.TransactionType });

                entity.ToTable("pms_GL_VCHRMASTER");

                entity.Property(e => e.VmSno)
                    .HasColumnType("decimal(25, 1)")
                    .HasColumnName("VM_SNO");

                entity.Property(e => e.TransactionType).HasColumnName("transaction_type");

                entity.Property(e => e.BrokerCode).HasColumnName("broker_code");

                entity.Property(e => e.ClearingCompCode).HasColumnName("clearingComp_Code");

                entity.Property(e => e.CouponCode).HasColumnName("coupon_code");

                entity.Property(e => e.CpoptionCode).HasColumnName("CPoption_code");

                entity.Property(e => e.CpoptionType).HasColumnName("CPoption_type");

                entity.Property(e => e.FInstBranchCode).HasColumnName("fInstBranch_code");

                entity.Property(e => e.FInstTranCode)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("fInstTran_code");

                entity.Property(e => e.FInstTranType).HasColumnName("fInstTran_type");

                entity.Property(e => e.FeeCode).HasColumnName("fee_code");

                entity.Property(e => e.FundCode).HasColumnName("fund_code");

                entity.Property(e => e.FundMasterCode).HasColumnName("fundMaster_code");

                entity.Property(e => e.OrdExecCode)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("ordExec_code");

                entity.Property(e => e.OrdExecDealTickNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ordExec_dealTickNo");

                entity.Property(e => e.OrderCode)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("order_code");

                entity.Property(e => e.OrderOnClearingSys)
                    .HasColumnName("order_onClearingSys")
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.ProductCode).HasColumnName("product_code");

                entity.Property(e => e.SettDateCode)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("settDate_code");

                entity.Property(e => e.SettDateType).HasColumnName("settDate_type");

                entity.Property(e => e.ShareAnnDate)
                    .HasColumnType("datetime")
                    .HasColumnName("shareAnn_date");

                entity.Property(e => e.TradInstCode).HasColumnName("tradInst_code");

                entity.Property(e => e.TradInstTypeCode).HasColumnName("tradInstType_code");

                entity.Property(e => e.TranMasterDate)
                    .HasColumnType("datetime")
                    .HasColumnName("tranMaster_date");

                entity.Property(e => e.ValuationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("valuation_date");

                entity.Property(e => e.VmAccruTag)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("VM_ACCRU_TAG");

                entity.Property(e => e.VmClearingParty).HasColumnName("VM_clearingParty");

                entity.Property(e => e.VmCoCode)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("VM_CO_CODE");

                entity.Property(e => e.VmColtrlSubType).HasColumnName("VM_coltrlSubType");

                entity.Property(e => e.VmColtrlType).HasColumnName("VM_coltrlType");

                entity.Property(e => e.VmCreatedby)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("VM_CREATEDBY");

                entity.Property(e => e.VmCreatedwhen)
                    .HasColumnType("datetime")
                    .HasColumnName("VM_CREATEDWHEN");

                entity.Property(e => e.VmDeleted)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("VM_DELETED");

                entity.Property(e => e.VmDesc)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("VM_DESC");

                entity.Property(e => e.VmDescArb)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("VM_DESC_ARB");

                entity.Property(e => e.VmDt)
                    .HasColumnType("datetime")
                    .HasColumnName("VM_DT");

                entity.Property(e => e.VmDtHij)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("VM_DT_HIJ");

                entity.Property(e => e.VmDualcurrTag)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("VM_DUALCURR_TAG");

                entity.Property(e => e.VmGlPosted).HasColumnName("VM_glPosted");

                entity.Property(e => e.VmModifiedby)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("VM_MODIFIEDBY");

                entity.Property(e => e.VmModifiedwhen)
                    .HasColumnType("datetime")
                    .HasColumnName("VM_MODIFIEDWHEN");

                entity.Property(e => e.VmNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("VM_NO");

                entity.Property(e => e.VmPacketRecvd)
                    .HasColumnType("numeric(20, 6)")
                    .HasColumnName("VM_PACKET_RECVD");

                entity.Property(e => e.VmPacketSent)
                    .HasColumnType("numeric(20, 6)")
                    .HasColumnName("VM_PACKET_SENT");

                entity.Property(e => e.VmPer)
                    .HasColumnType("numeric(20, 6)")
                    .HasColumnName("VM_PER");

                entity.Property(e => e.VmPstTag)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("VM_PST_TAG");

                entity.Property(e => e.VmSiteCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("VM_SITE_CODE");

                entity.Property(e => e.VmToBeReverse).HasColumnName("VM_toBeReverse");

                entity.Property(e => e.VmTransfer).HasColumnName("VM_TRANSFER");

                entity.Property(e => e.VmTransfertag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("VM_TRANSFERTAG");

                entity.Property(e => e.VmVchrType)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("VM_VCHR_TYPE");

                entity.Property(e => e.VmVerified)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("VM_VERIFIED");

                entity.Property(e => e.VmYear)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("VM_YEAR");
            });

            modelBuilder.Entity<PmsGlmode>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pms_GLMode");

                entity.Property(e => e.GlmodeCode).HasColumnName("GLMode_code");

                entity.Property(e => e.GlmodeName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GLMode_Name");
            });

            modelBuilder.Entity<PmsGroupOfCompany>(entity =>
            {
                entity.HasKey(e => e.GcompanyCode)
                    .HasName("PK__pms_groupOfCompa__436BFEE3");

                entity.ToTable("pms_groupOfCompanies");

                entity.HasIndex(e => e.GcompanyName, "IX_pms_groupOfCompanies")
                    .IsUnique();

                entity.Property(e => e.GcompanyCode)
                    .ValueGeneratedNever()
                    .HasColumnName("gcompany_code");

                entity.Property(e => e.GcompanyDesc)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("gcompany_desc");

                entity.Property(e => e.GcompanyMnemonic)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("gcompany_mnemonic");

                entity.Property(e => e.GcompanyName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("gcompany_name");
            });

            modelBuilder.Entity<PmsGrpExpLimit>(entity =>
            {
                entity.HasKey(e => new { e.GrpExpLimitCode, e.FundmasterCode, e.GrpExpLimitDate });

                entity.ToTable("pms_grpExpLimit");

                entity.Property(e => e.GrpExpLimitCode).HasColumnName("grpExpLimit_code");

                entity.Property(e => e.FundmasterCode).HasColumnName("fundmaster_code");

                entity.Property(e => e.GrpExpLimitDate)
                    .HasColumnType("datetime")
                    .HasColumnName("grpExpLimit_date");

                entity.Property(e => e.GrpExpLimitAmountLimit)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("grpExpLimit_amountLimit");

                entity.Property(e => e.GrpExpLimitAmountPercentage)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("grpExpLimit_amountPercentage");

                entity.Property(e => e.GrpExpLimitBasis).HasColumnName("grpExpLimit_basis");

                entity.Property(e => e.GrpExpLimitCreatedBy).HasColumnName("grpExpLimit_createdBy");

                entity.Property(e => e.GrpExpLimitCreatedWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("grpExpLimit_createdWhen");

                entity.Property(e => e.GrpExpLimitIsConfiguraion).HasColumnName("grpExpLimit_isConfiguraion");

                entity.Property(e => e.GrpExpLimitModifiedBy).HasColumnName("grpExpLimit_modifiedBy");

                entity.Property(e => e.GrpExpLimitModifiedWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("grpExpLimit_modifiedWhen");

                entity.Property(e => e.GrpExpLimitProduct).HasColumnName("grpExpLimit_product");
            });

            modelBuilder.Entity<PmsIndicator>(entity =>
            {
                entity.HasKey(e => e.IndicatorCode);

                entity.ToTable("pms_indicator");

                entity.Property(e => e.IndicatorCode)
                    .ValueGeneratedNever()
                    .HasColumnName("indicator_code");

                entity.Property(e => e.IndicatorDesc)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("indicator_desc");

                entity.Property(e => e.IndicatorModifiedBy).HasColumnName("indicator_modifiedBy");

                entity.Property(e => e.IndicatorModifiedWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("indicator_modifiedWhen");

                entity.Property(e => e.IndicatorName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("indicator_name");

                entity.Property(e => e.MarketCode).HasColumnName("market_code");

                entity.Property(e => e.TradInstTypeCode).HasColumnName("tradInstType_code");
            });

            modelBuilder.Entity<PmsInvBond>(entity =>
            {
                entity.HasKey(e => e.InvBondsCode)
                    .HasName("PK__pms_investmentBo__73852659");

                entity.ToTable("pms_invBonds");

                entity.HasIndex(e => e.InvBondsName, "IX_pms_investmentBonds")
                    .IsUnique();

                entity.Property(e => e.InvBondsCode)
                    .ValueGeneratedNever()
                    .HasColumnName("invBonds_code");

                entity.Property(e => e.InvBondAcceptAmount)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("invBond_acceptAmount");

                entity.Property(e => e.InvBondAucDate)
                    .HasColumnType("datetime")
                    .HasColumnName("invBond_aucDate");

                entity.Property(e => e.InvBondAucNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("invBond_aucNo");

                entity.Property(e => e.InvBondAuctionYield)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("invBond_auctionYield");

                entity.Property(e => e.InvBondParticiAmount)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("invBond_particiAmount");

                entity.Property(e => e.InvBondsAccrualBasis).HasColumnName("invBonds_accrualBasis");

                entity.Property(e => e.InvBondsAmortMethod).HasColumnName("invBonds_amortMethod");

                entity.Property(e => e.InvBondsAmortStartBasis).HasColumnName("invBonds_amortStartBasis");

                entity.Property(e => e.InvBondsBaseRate)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("invBonds_BaseRate");

                entity.Property(e => e.InvBondsCouponCapRate)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("invBonds_couponCapRate");

                entity.Property(e => e.InvBondsCouponFloorRate)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("invBonds_couponFloorRate");

                entity.Property(e => e.InvBondsCouponMaxRate)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("invBonds_couponMaxRate");

                entity.Property(e => e.InvBondsCouponMinRate)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("invBonds_couponMinRate");

                entity.Property(e => e.InvBondsCouponRatePerAnnum)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("invBonds_couponRatePerAnnum");

                entity.Property(e => e.InvBondsCouponsQty).HasColumnName("invBonds_couponsQty");

                entity.Property(e => e.InvBondsDesc)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("invBonds_desc");

                entity.Property(e => e.InvBondsFaceValue)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("invBonds_faceValue");

                entity.Property(e => e.InvBondsIsMatured).HasColumnName("invBonds_IsMatured");

                entity.Property(e => e.InvBondsIssueDate)
                    .HasColumnType("datetime")
                    .HasColumnName("invBonds_issueDate");

                entity.Property(e => e.InvBondsListed).HasColumnName("invBonds_listed");

                entity.Property(e => e.InvBondsLotBasisSale).HasColumnName("invBonds_LotBasisSale");

                entity.Property(e => e.InvBondsMaturityDate)
                    .HasColumnType("datetime")
                    .HasColumnName("invBonds_maturityDate");

                entity.Property(e => e.InvBondsMaturityPeriod).HasColumnName("invBonds_maturityPeriod");

                entity.Property(e => e.InvBondsName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("invBonds_name");

                entity.Property(e => e.InvBondsRedemptionTenor).HasColumnName("invBonds_redemptionTenor");

                entity.Property(e => e.InvBondsRedemptionType).HasColumnName("invBonds_redemptionType");

                entity.Property(e => e.InvBondsShutPeriod).HasColumnName("invBonds_shutPeriod");

                entity.Property(e => e.InvBondsYears).HasColumnName("invBonds_years");

                entity.Property(e => e.Invbonds1stCpnAccrBasis).HasColumnName("invbonds_1stCpnAccrBasis");

                entity.Property(e => e.InvbondsAmortbasis).HasColumnName("INVBONDS_AMORTBASIS");

                entity.Property(e => e.InvbondsAuthorizedby).HasColumnName("INVBONDS_AUTHORIZEDBY");

                entity.Property(e => e.InvbondsAuthorizedwhen)
                    .HasColumnType("datetime")
                    .HasColumnName("INVBONDS_AUTHORIZEDWHEN");

                entity.Property(e => e.InvbondsCreatedby).HasColumnName("INVBONDS_CREATEDBY");

                entity.Property(e => e.InvbondsCreatedwhen)
                    .HasColumnType("datetime")
                    .HasColumnName("INVBONDS_CREATEDWHEN");

                entity.Property(e => e.InvbondsIsauthorized).HasColumnName("INVBONDS_ISAUTHORIZED");

                entity.Property(e => e.InvbondsModifiedby).HasColumnName("INVBONDS_MODIFIEDBY");

                entity.Property(e => e.InvbondsModifiedwhen)
                    .HasColumnType("datetime")
                    .HasColumnName("INVBONDS_MODIFIEDWHEN");

                entity.Property(e => e.InvbondsReason)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("INVBONDS_reason");

                entity.Property(e => e.InvbondsSecCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("invbonds_SecCode");

                entity.Property(e => e.ProductCode)
                    .HasColumnName("product_code")
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.RateTemplSlabName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("rateTempl_slabName");

                entity.Property(e => e.RateTemplType).HasColumnName("rateTempl_type");

                entity.Property(e => e.ShareCode).HasColumnName("share_Code");

                entity.Property(e => e.TradInstTypeCode).HasColumnName("tradInstType_code");

                entity.HasOne(d => d.TradInstTypeCodeNavigation)
                    .WithMany(p => p.PmsInvBonds)
                    .HasForeignKey(d => d.TradInstTypeCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__pms_inves__tradI__74794A92");

                entity.HasOne(d => d.PmsUserDefProduct)
                    .WithMany(p => p.PmsInvBonds)
                    .HasForeignKey(d => new { d.TradInstTypeCode, d.ProductCode })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_pms_invBonds_pms_UserDefProducts");
            });

            modelBuilder.Entity<PmsInvCommOrdApp>(entity =>
            {
                entity.HasKey(e => new { e.InvCommAppCode, e.InvCommAppType, e.InvCommAppDate })
                    .HasName("PK__pms_invCommOrdAp__77DFC722");

                entity.ToTable("pms_invCommOrdApp");

                entity.Property(e => e.InvCommAppCode).HasColumnName("invCommApp_code");

                entity.Property(e => e.InvCommAppType).HasColumnName("invCommApp_type");

                entity.Property(e => e.InvCommAppDate)
                    .HasColumnType("datetime")
                    .HasColumnName("invCommApp_date");

                entity.Property(e => e.CalPeriodCode).HasColumnName("calPeriod_code");

                entity.Property(e => e.CalYearCode).HasColumnName("calYear_code");

                entity.Property(e => e.FInstBranchCode).HasColumnName("fInstBranch_code");

                entity.Property(e => e.FInstCode).HasColumnName("fInst_code");

                entity.Property(e => e.FInstTypeCode).HasColumnName("fInstType_code");

                entity.Property(e => e.FundCode).HasColumnName("fund_code");

                entity.Property(e => e.InvCommAppAmount)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("invCommApp_amount");

                entity.Property(e => e.InvCommAppCancelState).HasColumnName("invCommApp_cancelState");

                entity.Property(e => e.InvCommAppDateCancel)
                    .HasColumnType("datetime")
                    .HasColumnName("invCommApp_dateCancel");

                entity.Property(e => e.InvCommAppDateValidity)
                    .HasColumnType("datetime")
                    .HasColumnName("invCommApp_dateValidity");

                entity.Property(e => e.InvCommAppDealDays).HasColumnName("invCommApp_dealDays");

                entity.Property(e => e.InvCommAppQuantity)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("invCommApp_quantity");

                entity.Property(e => e.InvCommAppRate)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("invCommApp_rate");

                entity.Property(e => e.InvCommAppRateTo)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("invCommApp_rateTo");

                entity.Property(e => e.InvCommAppYieldFrom)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("invCommApp_yieldFrom");

                entity.Property(e => e.InvCommAppYieldTo)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("invCommApp_yieldTo");

                entity.Property(e => e.TradInstCode).HasColumnName("tradInst_code");

                entity.Property(e => e.TradInstTypeCode).HasColumnName("tradInstType_code");

                entity.HasOne(d => d.FundCodeNavigation)
                    .WithMany(p => p.PmsInvCommOrdApps)
                    .HasForeignKey(d => d.FundCode)
                    .HasConstraintName("FK_pms_invCommOrdApp_pms_funds");

                entity.HasOne(d => d.TradInstTypeCodeNavigation)
                    .WithMany(p => p.PmsInvCommOrdApps)
                    .HasForeignKey(d => d.TradInstTypeCode)
                    .HasConstraintName("FK__pms_invCo__tradI__79C80F94");

                entity.HasOne(d => d.Cal)
                    .WithMany(p => p.PmsInvCommOrdApps)
                    .HasForeignKey(d => new { d.CalYearCode, d.CalPeriodCode })
                    .HasConstraintName("FK__pms_invCommOrdAp__78D3EB5B");
            });

            modelBuilder.Entity<PmsIssuance>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pms_Issuance");

                entity.Property(e => e.FInstCode).HasColumnName("fInst_code");

                entity.Property(e => e.FInstTypeCode).HasColumnName("fInstType_code");

                entity.Property(e => e.ProductCode).HasColumnName("product_code");

                entity.Property(e => e.RateTemplSlabName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("rateTempl_slabName");

                entity.Property(e => e.RateTemplType).HasColumnName("rateTempl_type");

                entity.Property(e => e.ShareCode).HasColumnName("share_Code");

                entity.Property(e => e.Tfc1stCpnAccrBasis).HasColumnName("tfc_1stCpnAccrBasis");

                entity.Property(e => e.TfcAccrualBasis).HasColumnName("tfc_accrualBasis");

                entity.Property(e => e.TfcAmortBasis).HasColumnName("tfc_amortBasis");

                entity.Property(e => e.TfcAmortMethod).HasColumnName("tfc_amortMethod");

                entity.Property(e => e.TfcAmortStartBasis).HasColumnName("tfc_amortStartBasis");

                entity.Property(e => e.TfcAuthorizedby).HasColumnName("TFC_AUTHORIZEDBY");

                entity.Property(e => e.TfcAuthorizedwhen)
                    .HasColumnType("datetime")
                    .HasColumnName("TFC_AUTHORIZEDWHEN");

                entity.Property(e => e.TfcBaseRate)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("tfc_BaseRate");

                entity.Property(e => e.TfcCode).HasColumnName("tfc_Code");

                entity.Property(e => e.TfcConvFixedDay)
                    .HasColumnType("datetime")
                    .HasColumnName("tfc_convFixedDay");

                entity.Property(e => e.TfcConvPeriod).HasColumnName("tfc_convPeriod");

                entity.Property(e => e.TfcConversionPrice)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("tfc_conversionPrice");

                entity.Property(e => e.TfcConversionQuantity)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("tfc_conversionQuantity");

                entity.Property(e => e.TfcCouponCapRate)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("tfc_couponCapRate");

                entity.Property(e => e.TfcCouponFloorRate)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("tfc_couponFloorRate");

                entity.Property(e => e.TfcCouponMaxRate)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("tfc_couponMaxRate");

                entity.Property(e => e.TfcCouponMinRate)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("tfc_couponMinRate");

                entity.Property(e => e.TfcCouponRatePerAnnum)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("tfc_couponRatePerAnnum");

                entity.Property(e => e.TfcCouponsQty).HasColumnName("tfc_couponsQty");

                entity.Property(e => e.TfcCreatedby).HasColumnName("TFC_CREATEDBY");

                entity.Property(e => e.TfcCreatedwhen)
                    .HasColumnType("datetime")
                    .HasColumnName("TFC_CREATEDWHEN");

                entity.Property(e => e.TfcCreditRating)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("tfc_creditRating");

                entity.Property(e => e.TfcDesc)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("tfc_desc");

                entity.Property(e => e.TfcFaceValue)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("tfc_faceValue");

                entity.Property(e => e.TfcIsConvertible).HasColumnName("tfc_IsConvertible");

                entity.Property(e => e.TfcIsauthorized).HasColumnName("TFC_ISAUTHORIZED");

                entity.Property(e => e.TfcIsino)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tfc_ISINO");

                entity.Property(e => e.TfcIssuance).HasColumnName("tfc_issuance");

                entity.Property(e => e.TfcIssueDate)
                    .HasColumnType("datetime")
                    .HasColumnName("tfc_issueDate");

                entity.Property(e => e.TfcIssuerName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tfc_issuerName");

                entity.Property(e => e.TfcListed).HasColumnName("tfc_listed");

                entity.Property(e => e.TfcMaturityDate)
                    .HasColumnType("datetime")
                    .HasColumnName("tfc_maturityDate");

                entity.Property(e => e.TfcModifiedby).HasColumnName("TFC_MODIFIEDBY");

                entity.Property(e => e.TfcModifiedwhen)
                    .HasColumnType("datetime")
                    .HasColumnName("TFC_MODIFIEDWHEN");

                entity.Property(e => e.TfcName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tfc_name");

                entity.Property(e => e.TfcNature).HasColumnName("tfc_Nature");

                entity.Property(e => e.TfcRatesDay).HasColumnName("tfc_RatesDay");

                entity.Property(e => e.TfcReason)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("TFC_reason");

                entity.Property(e => e.TfcRedemptionTenor).HasColumnName("tfc_redemptionTenor");

                entity.Property(e => e.TfcRedemptionType).HasColumnName("tfc_redemptionType");

                entity.Property(e => e.TfcSettThrough).HasColumnName("tfc_SettThrough");

                entity.Property(e => e.TfcSize)
                    .HasColumnType("decimal(26, 0)")
                    .HasColumnName("tfc_Size");

                entity.Property(e => e.TfcSymbol)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tfc_symbol");

                entity.Property(e => e.TfcYears).HasColumnName("tfc_years");

                entity.Property(e => e.TradInstTypeCode).HasColumnName("tradInstType_code");
            });

            modelBuilder.Entity<PmsLegalConstraintsSetup>(entity =>
            {
                entity.HasKey(e => new { e.LegalConstCode, e.FundMasterCode });

                entity.ToTable("pms_legalConstraintsSetup");

                entity.Property(e => e.LegalConstCode).HasColumnName("legalConst_code");

                entity.Property(e => e.FundMasterCode).HasColumnName("fundMaster_code");

                entity.Property(e => e.LegalConstBorrowLmt)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("legalConst_BorrowLmt");

                entity.Property(e => e.LegalConstBrokerComm)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("legalConst_BrokerComm");

                entity.Property(e => e.LegalConstBrokerCommTax)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("legalConst_BrokerCommTax");

                entity.Property(e => e.LegalConstCalcBrkComm).HasColumnName("legalConst_CalcBrkComm");

                entity.Property(e => e.LegalConstCheckBorrowLmt).HasColumnName("legalConst_CheckBorrowLmt");

                entity.Property(e => e.LegalConstCheckBrokerComm).HasColumnName("legalConst_CheckBrokerComm");

                entity.Property(e => e.LegalConstCheckCloseEndFund).HasColumnName("legalConst_CheckCloseEndFund");

                entity.Property(e => e.LegalConstCheckFreeFloatLmt).HasColumnName("legalConst_CheckFreeFloatLmt");

                entity.Property(e => e.LegalConstCheckGroupInvLmt).HasColumnName("legalConst_CheckGroupInvLmt");

                entity.Property(e => e.LegalConstCheckGroupInvLmtSec).HasColumnName("legalConst_CheckGroupInvLmtSec");

                entity.Property(e => e.LegalConstCheckIndivInvLmt).HasColumnName("legalConst_CheckIndivInvLmt");

                entity.Property(e => e.LegalConstCheckListSecInvLmt).HasColumnName("legalConst_CheckListSecInvLmt");

                entity.Property(e => e.LegalConstCheckOutStanding).HasColumnName("legalConst_CheckOutStanding");

                entity.Property(e => e.LegalConstCheckPaidupCapLmt).HasColumnName("legalConst_CheckPaidupCapLmt");

                entity.Property(e => e.LegalConstCheckPortfolioLmt).HasColumnName("legalConst_CheckPortfolioLmt");

                entity.Property(e => e.LegalConstCheckRequireCvt).HasColumnName("legalConst_CheckRequireCVT");

                entity.Property(e => e.LegalConstCheckSbpalert).HasColumnName("legalConst_CheckSBPAlert");

                entity.Property(e => e.LegalConstCheckSectorInvLmt).HasColumnName("legalConst_CheckSectorInvLmt");

                entity.Property(e => e.LegalConstCheckShareMpvar).HasColumnName("legalConst_CheckShareMPVar");

                entity.Property(e => e.LegalConstCloseEndFund)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("legalConst_CloseEndFund");

                entity.Property(e => e.LegalConstDesc)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("legalConst_desc");

                entity.Property(e => e.LegalConstFreeFloatLmt)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("legalConst_FreeFloatLmt");

                entity.Property(e => e.LegalConstGroupInvLmt)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("legalConst_groupInvLmt");

                entity.Property(e => e.LegalConstGroupInvLmtSec)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("legalConst_groupInvLmtSec");

                entity.Property(e => e.LegalConstIndivInvLmt)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("legalConst_indivInvLmt");

                entity.Property(e => e.LegalConstListedSecInvLmt)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("legalConst_listedSecInvLmt");

                entity.Property(e => e.LegalConstOutStanding)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("legalConst_OutStanding");

                entity.Property(e => e.LegalConstPaidupCapLmt)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("legalConst_paidupCapLmt");

                entity.Property(e => e.LegalConstPortfolioLmt)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("legalConst_portfolioLmt");

                entity.Property(e => e.LegalConstSbpinvLmt)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("legalConst_SBPInvLmt");

                entity.Property(e => e.LegalConstSectorInvLmt)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("legalConst_sectorInvLmt");

                entity.Property(e => e.LegalConstShareCostBasis).HasColumnName("legalConst_ShareCostBasis");

                entity.Property(e => e.LegalConstShareMpvar)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("legalConst_shareMPVar");
            });

            modelBuilder.Entity<PmsLimitBreach>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pms_limitBreach");

                entity.Property(e => e.FundMasterCode).HasColumnName("fundMaster_code");

                entity.Property(e => e.FundMasterName)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("fundMaster_name");

                entity.Property(e => e.FundMnemonic)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("fund_mnemonic");

                entity.Property(e => e.FundName)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("fund_name");

                entity.Property(e => e.InvCommAppAmount)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("invCommApp_amount");

                entity.Property(e => e.InvCommAppDate)
                    .HasColumnType("datetime")
                    .HasColumnName("invCommApp_date");

                entity.Property(e => e.LbApprovalBy).HasColumnName("lb_ApprovalBy");

                entity.Property(e => e.LbCode).HasColumnName("lb_code");

                entity.Property(e => e.LbCreatedBy).HasColumnName("lb_createdBy");

                entity.Property(e => e.LbCreatedWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("lb_createdWhen");

                entity.Property(e => e.LbMarketDate)
                    .HasColumnType("datetime")
                    .HasColumnName("lb_marketDate");

                entity.Property(e => e.LbMarketRate)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("lb_marketRate");

                entity.Property(e => e.LbModifyBy).HasColumnName("lb_modifyBy");

                entity.Property(e => e.LbModifyWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("lb_modifyWhen");

                entity.Property(e => e.LbProDate)
                    .HasColumnType("datetime")
                    .HasColumnName("lb_proDate");

                entity.Property(e => e.LbRptStatus)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("lb_RptSTATUS");

                entity.Property(e => e.MovAvgAmtMov)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("movAvg_amtMov");

                entity.Property(e => e.MovavgQty)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("movavg_Qty");

                entity.Property(e => e.ShareName)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("share_name");

                entity.Property(e => e.TradeDate)
                    .HasColumnType("datetime")
                    .HasColumnName("tradeDate");
            });

            modelBuilder.Entity<PmsLimitFundConfig>(entity =>
            {
                entity.HasKey(e => new { e.LmtFundDate, e.FundMasterCode, e.FundCode });

                entity.ToTable("pms_limitFundConfig");

                entity.Property(e => e.LmtFundDate)
                    .HasColumnType("datetime")
                    .HasColumnName("lmtFund_date");

                entity.Property(e => e.FundMasterCode).HasColumnName("fundMaster_code");

                entity.Property(e => e.FundCode).HasColumnName("fund_code");

                entity.Property(e => e.LmtFundDateBasis).HasColumnName("lmtFund_dateBasis");

                entity.Property(e => e.LmtFundDaysLmt).HasColumnName("lmtFund_daysLmt");

                entity.Property(e => e.LmtFundModifiedBy).HasColumnName("lmtFund_modifiedBy");

                entity.Property(e => e.LmtFundModifiedWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("lmtFund_modifiedWhen");

                entity.Property(e => e.LmtFundStopLossLmt)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("lmtFund_stopLossLmt");

                entity.Property(e => e.TradInstTypeCode).HasColumnName("tradInstType_code");
            });

            modelBuilder.Entity<PmsLoanDatum>(entity =>
            {
                entity.HasKey(e => new { e.LoanCode, e.FundmasterCode, e.LoanDate, e.BorrowerCode });

                entity.ToTable("pms_loanData");

                entity.Property(e => e.LoanCode).HasColumnName("loan_code");

                entity.Property(e => e.FundmasterCode).HasColumnName("fundmaster_code");

                entity.Property(e => e.LoanDate)
                    .HasColumnType("datetime")
                    .HasColumnName("loan_Date");

                entity.Property(e => e.BorrowerCode).HasColumnName("borrower_code");

                entity.Property(e => e.BorrowerName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("borrower_name");

                entity.Property(e => e.LoanCreatedby).HasColumnName("loan_createdby");

                entity.Property(e => e.LoanCreatedwhen)
                    .HasColumnType("datetime")
                    .HasColumnName("loan_createdwhen");

                entity.Property(e => e.LoanCycle).HasColumnName("loan_cycle");

                entity.Property(e => e.LoanFacilityCode)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("loan_facilityCode");

                entity.Property(e => e.LoanFacilityDescription)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("loan_facilityDescription");

                entity.Property(e => e.LoanGroupCode)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("loan_groupCode");

                entity.Property(e => e.LoanGroupDescription)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("loan_groupDescription");

                entity.Property(e => e.LoanIsFunded).HasColumnName("loan_isFunded");

                entity.Property(e => e.LoanIsLocked).HasColumnName("loan_IsLocked");

                entity.Property(e => e.LoanModifyby).HasColumnName("loan_modifyby");

                entity.Property(e => e.LoanModifywhen)
                    .HasColumnType("datetime")
                    .HasColumnName("loan_modifywhen");

                entity.Property(e => e.LoanPrincipal)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("loan_principal");
            });

            modelBuilder.Entity<PmsMarket>(entity =>
            {
                entity.HasKey(e => e.MarketCode)
                    .HasName("PK__pms_Market__45544755");

                entity.ToTable("pms_Market");

                entity.Property(e => e.MarketCode)
                    .ValueGeneratedNever()
                    .HasColumnName("market_code");

                entity.Property(e => e.CounCode).HasColumnName("coun_code");

                entity.Property(e => e.MarketDesc)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("market_desc");

                entity.Property(e => e.MarketName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("market_name");

                entity.Property(e => e.MarketPriceReadUtility).HasColumnName("market_priceReadUtility");

                entity.Property(e => e.MarketType).HasColumnName("market_type");
            });

            modelBuilder.Entity<PmsMarketTiming>(entity =>
            {
                entity.HasKey(e => new { e.MarketTimingSno, e.MarketCode })
                    .HasName("PK_pms_ marketTiming");

                entity.ToTable("pms_marketTiming");

                entity.Property(e => e.MarketTimingSno).HasColumnName("marketTiming_sno");

                entity.Property(e => e.MarketCode).HasColumnName("market_code");

                entity.Property(e => e.MarketTimingAppliedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("marketTiming_appliedDate");

                entity.Property(e => e.MarketTimingClose)
                    .HasColumnType("datetime")
                    .HasColumnName("marketTiming_close");

                entity.Property(e => e.MarketTimingCreatedWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("marketTiming_createdWhen");

                entity.Property(e => e.MarketTimingCreatedby).HasColumnName("marketTiming_createdby");

                entity.Property(e => e.MarketTimingModifiedBy).HasColumnName("marketTiming_modifiedBy");

                entity.Property(e => e.MarketTimingModifiedWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("marketTiming_modifiedWhen");

                entity.Property(e => e.MarketTimingOpen)
                    .HasColumnType("datetime")
                    .HasColumnName("marketTiming_open");

                entity.Property(e => e.MarketTimingRemarks)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("marketTiming_remarks");
            });

            modelBuilder.Entity<PmsMarketToleranceRate>(entity =>
            {
                entity.HasKey(e => new { e.FundMasterCode, e.MktToleranceRateDate, e.TradinstTypeCode, e.TradinstCode });

                entity.ToTable("pms_marketToleranceRate");

                entity.Property(e => e.FundMasterCode).HasColumnName("fundMaster_code");

                entity.Property(e => e.MktToleranceRateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("mktToleranceRate_date");

                entity.Property(e => e.TradinstTypeCode).HasColumnName("tradinstType_code");

                entity.Property(e => e.TradinstCode).HasColumnName("Tradinst_code");

                entity.Property(e => e.MktToleranceRateCreatedBy).HasColumnName("mktToleranceRate_createdBy");

                entity.Property(e => e.MktToleranceRateCreateddWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("mktToleranceRate_createddWhen");

                entity.Property(e => e.MktToleranceRateModifiedBy).HasColumnName("mktToleranceRate_modifiedBy");

                entity.Property(e => e.MktToleranceRateModifiedWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("mktToleranceRate_modifiedWhen");

                entity.Property(e => e.MktToleranceRateRate)
                    .HasColumnType("numeric(25, 6)")
                    .HasColumnName("mktToleranceRate_rate");

                entity.Property(e => e.ProductCode).HasColumnName("Product_code");
            });

            modelBuilder.Entity<PmsMmiannouncement>(entity =>
            {
                entity.HasKey(e => new { e.TradInstTypeCode, e.TradInstCode, e.MmiAnnDate })
                    .HasName("PK__pms_MMIAnnouncem__53A266AC");

                entity.ToTable("pms_MMIAnnouncement");

                entity.Property(e => e.TradInstTypeCode).HasColumnName("tradInstType_code");

                entity.Property(e => e.TradInstCode).HasColumnName("tradInst_code");

                entity.Property(e => e.MmiAnnDate)
                    .HasColumnType("datetime")
                    .HasColumnName("mmiAnn_date");

                entity.Property(e => e.MmiAnnCreditRating)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("mmiAnn_creditRating");

                entity.Property(e => e.MmiAnnNewCouponCode).HasColumnName("mmiAnn_newCouponCode");

                entity.Property(e => e.MmiAnnOldCouponCode).HasColumnName("mmiAnn_OldCouponCode");

                entity.Property(e => e.MmiAnnRatingAgency)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("mmiAnn_ratingAgency");

                entity.HasOne(d => d.TradInstTypeCodeNavigation)
                    .WithMany(p => p.PmsMmiannouncements)
                    .HasForeignKey(d => d.TradInstTypeCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__pms_MMIAn__tradI__035179CE");
            });

            modelBuilder.Entity<PmsMngFeeBenchMark>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pms_mngFeeBenchMark");

                entity.Property(e => e.BnchMarkCode)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("bnchMark_code");

                entity.Property(e => e.BnchMarkTypeName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("bnchMark_typeName");

                entity.Property(e => e.BnchMarkTypecode).HasColumnName("bnchMark_Typecode");
            });

            modelBuilder.Entity<PmsMngFeeCustBenchMark>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pms_mngFeeCustBenchMark");

                entity.Property(e => e.BnchMarkCode).HasColumnName("bnchMark_code");

                entity.Property(e => e.CustBnchmrkDateCommence)
                    .HasColumnType("datetime")
                    .HasColumnName("custBnchmrk_dateCommence");

                entity.Property(e => e.CustBnchmrkDateValidity)
                    .HasColumnType("datetime")
                    .HasColumnName("custBnchmrk_dateValidity");

                entity.Property(e => e.CustBnchmrkMFee)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("custBnchmrk_mFee");

                entity.Property(e => e.CustBnchmrkRate)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("custBnchmrk_Rate");

                entity.Property(e => e.FundMasterCode).HasColumnName("FundMaster_code");
            });

            modelBuilder.Entity<PmsModule>(entity =>
            {
                entity.HasKey(e => e.ModuleType);

                entity.ToTable("pms_modules");

                entity.Property(e => e.ModuleType)
                    .ValueGeneratedNever()
                    .HasColumnName("module_type");

                entity.Property(e => e.ModuleName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("module_name");
            });

            modelBuilder.Entity<PmsMovingAvg>(entity =>
            {
                entity.HasKey(e => new { e.MovAvgCode, e.FundCode, e.TradInstTypeCode, e.TradInstCode });

                entity.ToTable("pms_movingAvg");

                entity.Property(e => e.MovAvgCode).HasColumnName("movAvg_Code");

                entity.Property(e => e.FundCode).HasColumnName("fund_code");

                entity.Property(e => e.TradInstTypeCode).HasColumnName("tradInstType_code");

                entity.Property(e => e.TradInstCode).HasColumnName("tradInst_code");

                entity.Property(e => e.BrokerCode).HasColumnName("broker_code");

                entity.Property(e => e.DmpDate)
                    .HasColumnType("datetime")
                    .HasColumnName("DMP_date");

                entity.Property(e => e.MovAvgAmtCarr)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("movAvg_amtCarr");

                entity.Property(e => e.MovAvgAmtMov)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("movAvg_amtMov");

                entity.Property(e => e.MovAvgAverage)
                    .HasColumnType("decimal(25, 13)")
                    .HasColumnName("movAvg_average");

                entity.Property(e => e.MovAvgCarrCapGainlLoss)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("movAvg_CarrCapGainlLoss");

                entity.Property(e => e.MovAvgCarryCost)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("movAvg_carryCost");

                entity.Property(e => e.MovAvgExFamt)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("movAvg_exFamt");

                entity.Property(e => e.MovAvgExFamtCarr)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("movAvg_exFamtCarr");

                entity.Property(e => e.MovAvgExFaverage)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("movAvg_exFaverage");

                entity.Property(e => e.MovAvgExFcarryCost)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("movAvg_exFcarryCost");

                entity.Property(e => e.MovAvgExFqty)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("movAvg_exFqty");

                entity.Property(e => e.MovAvgModifiedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("movAvg_modifiedDate");

                entity.Property(e => e.MovAvgMovCapGainlLoss)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("movAvg_MovCapGainlLoss");

                entity.Property(e => e.MovAvgPrice)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("movAvg_price");

                entity.Property(e => e.MovAvgProcDate)
                    .HasColumnType("datetime")
                    .HasColumnName("movAvg_ProcDate");

                entity.Property(e => e.MovAvgQty)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("movAvg_qty");

                entity.Property(e => e.MovAvgSettDate)
                    .HasColumnType("datetime")
                    .HasColumnName("movAvg_settDate");

                entity.Property(e => e.MovAvgTranDate)
                    .HasColumnType("datetime")
                    .HasColumnName("movAvg_tranDate");

                entity.Property(e => e.OrdExecCode).HasColumnName("ordExec_code");

                entity.Property(e => e.OrdExecDealTickNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ordExec_dealTickNo");

                entity.Property(e => e.OrderCode).HasColumnName("order_code");

                entity.Property(e => e.OrderMode).HasColumnName("order_mode");

                entity.Property(e => e.OrderOpenCloseFlag).HasColumnName("order_openCloseFlag");

                entity.Property(e => e.OrderSubtype).HasColumnName("order_subtype");

                entity.Property(e => e.SettDateMovBrokerCommission)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("settDate_MovBrokerCommission");

                entity.Property(e => e.SettDateMovFedtax)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("settDate_MovFEDTax");

                entity.Property(e => e.SettModeCode).HasColumnName("settMode_code");

                entity.Property(e => e.SettdateMovWhtaxtrade)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("SETTDATE_MovWHTAXTRADE");

                entity.Property(e => e.SubProductType).HasColumnName("subProduct_Type");

                entity.Property(e => e.TranMasterType).HasColumnName("tranMaster_type");
            });

            modelBuilder.Entity<PmsNature>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pms_nature");

                entity.Property(e => e.NatureCode).HasColumnName("nature_code");

                entity.Property(e => e.NatureDesc)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nature_desc");

                entity.Property(e => e.NatureName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nature_name");
            });

            modelBuilder.Entity<PmsNavdetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pms_NAVdetails");

                entity.Property(e => e.FundMasterCode).HasColumnName("fundMaster_code");

                entity.Property(e => e.NavDate)
                    .HasColumnType("datetime")
                    .HasColumnName("NAV_date");

                entity.Property(e => e.NavdetAccCode).HasColumnName("NAVdet_accCode");

                entity.Property(e => e.NavdetAccNature).HasColumnName("NAVdet_accNature");

                entity.Property(e => e.NavdetAccTitle)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("NAVdet_accTitle");

                entity.Property(e => e.NavdetAmount)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("NAVdet_amount");
            });

            modelBuilder.Entity<PmsOrder>(entity =>
            {
                entity.HasKey(e => new { e.OrderCode, e.TradInstCode, e.TradInstTypeCode })
                    .HasName("PK__pms_Order__2B0A656D");

                entity.ToTable("pms_Order");

                entity.HasIndex(e => e.OrderRefNo, "IX_pms_Order")
                    .IsUnique();

                entity.Property(e => e.OrderCode)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("order_code");

                entity.Property(e => e.TradInstCode).HasColumnName("tradInst_code");

                entity.Property(e => e.TradInstTypeCode).HasColumnName("tradInstType_code");

                entity.Property(e => e.BrokerCode).HasColumnName("broker_Code");

                entity.Property(e => e.CalPeriodCode).HasColumnName("calPeriod_code");

                entity.Property(e => e.CalYearCode).HasColumnName("calYear_code");

                entity.Property(e => e.CfsTradeNo)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("CFS_tradeNo");

                entity.Property(e => e.FInstBranchCode).HasColumnName("fInstBranch_code");

                entity.Property(e => e.FundCode).HasColumnName("fund_code");

                entity.Property(e => e.InvCommAppDate)
                    .HasColumnType("datetime")
                    .HasColumnName("invCommApp_date");

                entity.Property(e => e.MarketCode).HasColumnName("market_code");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("modified_date");

                entity.Property(e => e.NccTicketno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NCC_TICKETNO");

                entity.Property(e => e.OrdDealerLimitFlag)
                    .HasColumnName("OrdDealerLimit_Flag")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OrderActualAmt)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("order_actualAmt");

                entity.Property(e => e.OrderActualQty)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("order_actualQty");

                entity.Property(e => e.OrderAmount)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("order_amount");

                entity.Property(e => e.OrderBrokerCommission)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("order_BrokerCommission");

                entity.Property(e => e.OrderBrokerRate)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("order_brokerRate");

                entity.Property(e => e.OrderBrokerRateMode).HasColumnName("order_brokerRateMode");

                entity.Property(e => e.OrderCancelled).HasColumnName("order_cancelled");

                entity.Property(e => e.OrderCancelledDate)
                    .HasColumnType("datetime")
                    .HasColumnName("order_cancelledDate");

                entity.Property(e => e.OrderCdccharges)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("order_CDCCharges");

                entity.Property(e => e.OrderContraRefNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("order_contraRefNo");

                entity.Property(e => e.OrderCotratePer)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("order_COTRatePer");

                entity.Property(e => e.OrderCreatedWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("Order_CreatedWhen");

                entity.Property(e => e.OrderCreatedby).HasColumnName("Order_Createdby");

                entity.Property(e => e.OrderCvtfut)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("order_CVTfut");

                entity.Property(e => e.OrderCvttax)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("order_CVTTax");

                entity.Property(e => e.OrderDate)
                    .HasColumnType("datetime")
                    .HasColumnName("order_date");

                entity.Property(e => e.OrderDateValidity)
                    .HasColumnType("datetime")
                    .HasColumnName("order_dateValidity");

                entity.Property(e => e.OrderDateValidityMode).HasColumnName("order_dateValidityMode");

                entity.Property(e => e.OrderEditCounter).HasColumnName("Order_EditCounter");

                entity.Property(e => e.OrderFBrokerRate)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("order_fBrokerRate");

                entity.Property(e => e.OrderFFundCode)
                    .HasColumnName("order_fFundCode")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.OrderFSalePrice)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("order_fSalePrice");

                entity.Property(e => e.OrderFScriptCode)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("order_fScriptCode");

                entity.Property(e => e.OrderFState).HasColumnName("order_fState");

                entity.Property(e => e.OrderFedfut)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("order_FEDfut");

                entity.Property(e => e.OrderFedtax)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("order_FEDTax");

                entity.Property(e => e.OrderMode).HasColumnName("order_mode");

                entity.Property(e => e.OrderModifyWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("Order_modifyWhen");

                entity.Property(e => e.OrderModifyby).HasColumnName("Order_modifyby");

                entity.Property(e => e.OrderOnClearingSys).HasColumnName("order_onClearingSys");

                entity.Property(e => e.OrderOpenCloseFlag).HasColumnName("order_openCloseFlag");

                entity.Property(e => e.OrderPriceLimit)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("order_priceLimit");

                entity.Property(e => e.OrderQuantity)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("order_quantity");

                entity.Property(e => e.OrderRefNo)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("order_refNo");

                entity.Property(e => e.OrderReferenceOrder)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("order_referenceOrder");

                entity.Property(e => e.OrderRemarks)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("order_remarks");

                entity.Property(e => e.OrderState).HasColumnName("order_state");

                entity.Property(e => e.OrderSubtype).HasColumnName("order_subtype");

                entity.Property(e => e.OrderUnExecAmount)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("order_UnExecAmount");

                entity.Property(e => e.OrderUnExecQuantity)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("order_UnExecQuantity");

                entity.Property(e => e.OrderUserDefNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("order_userDefNo");

                entity.Property(e => e.OrderYield)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("Order_Yield");

                entity.Property(e => e.ProductCode).HasColumnName("product_code");

                entity.Property(e => e.SettDateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("settDate_date");

                entity.Property(e => e.SettModeCode).HasColumnName("settMode_code");

                entity.Property(e => e.SettlementDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Settlement_date");

                entity.Property(e => e.SettlementMode).HasColumnName("Settlement_mode");

                entity.Property(e => e.ShareAnnDate)
                    .HasColumnType("datetime")
                    .HasColumnName("shareAnn_date");

                entity.Property(e => e.UserCode).HasColumnName("user_code");

                entity.HasOne(d => d.BrokerCodeNavigation)
                    .WithMany(p => p.PmsOrders)
                    .HasForeignKey(d => d.BrokerCode)
                    .HasConstraintName("FK__pms_Order__broke__395884C4");

                entity.HasOne(d => d.FundCodeNavigation)
                    .WithMany(p => p.PmsOrders)
                    .HasForeignKey(d => d.FundCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ptest");

                entity.HasOne(d => d.MarketCodeNavigation)
                    .WithMany(p => p.PmsOrders)
                    .HasForeignKey(d => d.MarketCode)
                    .HasConstraintName("FK__pms_Order__marke__3864608B");

                entity.HasOne(d => d.TradInstTypeCodeNavigation)
                    .WithMany(p => p.PmsOrders)
                    .HasForeignKey(d => d.TradInstTypeCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__pms_Order__tradI__3B40CD36");

                entity.HasOne(d => d.Cal)
                    .WithMany(p => p.PmsOrders)
                    .HasForeignKey(d => new { d.CalYearCode, d.CalPeriodCode })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__pms_Order__37703C52");
            });

            modelBuilder.Entity<PmsOrderExec>(entity =>
            {
                entity.HasKey(e => new { e.OrdExecCode, e.OrderCode, e.TradInstTypeCode, e.TradInstCode })
                    .HasName("PK__pms_OrderExec__2CF2ADDF");

                entity.ToTable("pms_OrderExec");

                entity.Property(e => e.OrdExecCode)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("ordExec_code");

                entity.Property(e => e.OrderCode)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("order_code");

                entity.Property(e => e.TradInstTypeCode).HasColumnName("tradInstType_code");

                entity.Property(e => e.TradInstCode).HasColumnName("tradInst_code");

                entity.Property(e => e.CalPeriodCode).HasColumnName("calPeriod_code");

                entity.Property(e => e.CalYearCode).HasColumnName("calYear_code");

                entity.Property(e => e.CfsTradeNo)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("CFS_tradeNo");

                entity.Property(e => e.CustodianCode).HasColumnName("custodian_code");

                entity.Property(e => e.FInstBranchCode).HasColumnName("fInstBranch_code");

                entity.Property(e => e.FundCode).HasColumnName("fund_code");

                entity.Property(e => e.OrdExecAccNo)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ordExec_accNo");

                entity.Property(e => e.OrdExecAmount)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("ordExec_amount");

                entity.Property(e => e.OrdExecAmountCvt)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("ordExec_amountCVT");

                entity.Property(e => e.OrdExecBrokerRate)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("ordExec_BrokerRate");

                entity.Property(e => e.OrdExecBrokerRateMode).HasColumnName("ordExec_BrokerRateMode");

                entity.Property(e => e.OrdExecBrokerYield)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("ordExec_BrokerYield");

                entity.Property(e => e.OrdExecCntPartyName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ordExec_CntPartyName");

                entity.Property(e => e.OrdExecContractNo)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ordExec_contractNo");

                entity.Property(e => e.OrdExecDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ordExec_date");

                entity.Property(e => e.OrdExecDealTickNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ordExec_dealTickNo");

                entity.Property(e => e.OrdExecDividendRec)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("ordExec_dividendRec");

                entity.Property(e => e.OrdExecDocumentNo)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ordExec_documentNo");

                entity.Property(e => e.OrdExecGlPosted).HasColumnName("ordExec_glPosted");

                entity.Property(e => e.OrdExecInceptionPrice)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("ordExec_inceptionPrice");

                entity.Property(e => e.OrdExecInterestOutStanding)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("ordExec_InterestOutStanding");

                entity.Property(e => e.OrdExecOtherCotcharges)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("ordExec_otherCOTCharges");

                entity.Property(e => e.OrdExecPrice)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("ordExec_price");

                entity.Property(e => e.OrdExecPriceSbp)
                    .HasColumnType("decimal(25, 0)")
                    .HasColumnName("ordExec_priceSBP")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.OrdExecPrimDealer)
                    .HasColumnName("ordExec_primDealer")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.OrdExecQuantity)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("ordExec_quantity");

                entity.Property(e => e.OrdExecRateCot)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("ordExec_rateCOT");

                entity.Property(e => e.OrdExecReferenceNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ordExec_ReferenceNo");

                entity.Property(e => e.OrdExecReqAmortSch).HasColumnName("ordExec_reqAmortSch");

                entity.Property(e => e.OrdExecRptActualQty)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("ordExec_rptActualQty");

                entity.Property(e => e.OrdExecSettBank)
                    .HasColumnName("ordExec_settBank")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.OrdExecSettThru).HasColumnName("ordExec_SettThru");

                entity.Property(e => e.OrdExecSglaccountNo)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ordExec_SGLaccountNo");

                entity.Property(e => e.OrdExecState).HasColumnName("ordExec_state");

                entity.Property(e => e.OrdExecStateVoucher).HasColumnName("ordExec_stateVoucher");

                entity.Property(e => e.OrdExecStatus).HasColumnName("ordExec_status");

                entity.Property(e => e.OrdExecThirdParty).HasColumnName("ordExec_thirdParty");

                entity.Property(e => e.OrdExecTmpDealTicNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ordExec_tmpDealTicNo");

                entity.Property(e => e.OrdExecTradeYield)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("ordExec_TradeYield");

                entity.Property(e => e.OrdExecVchrCreated).HasColumnName("ordExec_vchrCreated");

                entity.Property(e => e.OrderExecIsAccrued).HasColumnName("orderExec_isAccrued");

                entity.Property(e => e.OrderExecYield)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("orderExec_Yield");

                entity.Property(e => e.OrderIpsbnkCode).HasColumnName("order_IPSBnkCode");

                entity.Property(e => e.OrderOnClearingSys).HasColumnName("order_onClearingSys");

                entity.Property(e => e.OrderSubtype).HasColumnName("order_subtype");

                entity.Property(e => e.OrdexecCreatedWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("ORDEXEC_CreatedWhen");

                entity.Property(e => e.OrdexecCreatedby).HasColumnName("ORDEXEC_Createdby");

                entity.Property(e => e.OrdexecEditCounter).HasColumnName("ORDEXEC_EditCounter");

                entity.Property(e => e.OrdexecModifyWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("ORDEXEC_modifyWhen");

                entity.Property(e => e.OrdexecModifyby).HasColumnName("ORDEXEC_modifyby");

                entity.Property(e => e.SettModeCode).HasColumnName("settMode_code");

                entity.Property(e => e.TrusteeCode).HasColumnName("trustee_code");

                entity.HasOne(d => d.CustodianCodeNavigation)
                    .WithMany(p => p.PmsOrderExecs)
                    .HasForeignKey(d => d.CustodianCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__pms_Order__custo__3D2915A8");

                entity.HasOne(d => d.SettModeCodeNavigation)
                    .WithMany(p => p.PmsOrderExecs)
                    .HasForeignKey(d => d.SettModeCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__pms_Order__settM__3E1D39E1");

                entity.HasOne(d => d.TrusteeCodeNavigation)
                    .WithMany(p => p.PmsOrderExecs)
                    .HasForeignKey(d => d.TrusteeCode)
                    .HasConstraintName("FK_pms_OrderExec_pms_Trustee");

                entity.HasOne(d => d.Cal)
                    .WithMany(p => p.PmsOrderExecs)
                    .HasForeignKey(d => new { d.CalYearCode, d.CalPeriodCode })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__pms_OrderExec__3C34F16F");

                entity.HasOne(d => d.PmsOrder)
                    .WithMany(p => p.PmsOrderExecs)
                    .HasForeignKey(d => new { d.OrderCode, d.TradInstCode, d.TradInstTypeCode })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__pms_OrderExec__3F115E1A");
            });

            modelBuilder.Entity<PmsOutstandingposition>(entity =>
            {
                entity.HasKey(e => new { e.OutstandingposSerialno, e.OutstandingposProcessdatetime, e.FundmasterCode });

                entity.ToTable("PMS_OUTSTANDINGPOSITION");

                entity.Property(e => e.OutstandingposSerialno).HasColumnName("OUTSTANDINGPOS_SERIALNO");

                entity.Property(e => e.OutstandingposProcessdatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("OUTSTANDINGPOS_PROCESSDATETIME");

                entity.Property(e => e.FundmasterCode).HasColumnName("FUNDMASTER_CODE");

                entity.Property(e => e.FinsttranMode).HasColumnName("FINSTTRAN_MODE");

                entity.Property(e => e.FinsttranType).HasColumnName("FINSTTRAN_TYPE");

                entity.Property(e => e.FundmasterName)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("FUNDMASTER_NAME");

                entity.Property(e => e.OutstandingposAverageperday)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("OUTSTANDINGPOS_AVERAGEPERDAY");

                entity.Property(e => e.OutstandingposAvgperdaytotal)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("OUTSTANDINGPOS_AVGPERDAYTOTAL");

                entity.Property(e => e.OutstandingposCommproduct)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("OUTSTANDINGPOS_COMMPRODUCT");

                entity.Property(e => e.OutstandingposCommproducttot)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("OUTSTANDINGPOS_COMMPRODUCTTOT");

                entity.Property(e => e.OutstandingposCommvalue)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("OUTSTANDINGPOS_COMMVALUE");

                entity.Property(e => e.OutstandingposCommvaluetot)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("OUTSTANDINGPOS_COMMVALUETOT");

                entity.Property(e => e.OutstandingposCommwar)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("OUTSTANDINGPOS_COMMWAR");

                entity.Property(e => e.OutstandingposCommwartot)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("OUTSTANDINGPOS_COMMWARTOT");

                entity.Property(e => e.OutstandingposCreatedby).HasColumnName("OUTSTANDINGPOS_CREATEDBY");

                entity.Property(e => e.OutstandingposCreatedwhen)
                    .HasColumnType("datetime")
                    .HasColumnName("OUTSTANDINGPOS_CREATEDWHEN");

                entity.Property(e => e.OutstandingposDaysinyear).HasColumnName("OUTSTANDINGPOS_DAYSINYEAR");

                entity.Property(e => e.OutstandingposFacevalue)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("OUTSTANDINGPOS_FACEVALUE");

                entity.Property(e => e.OutstandingposGainlossdatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("OUTSTANDINGPOS_GAINLOSSDATETIME");

                entity.Property(e => e.OutstandingposIncome)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("OUTSTANDINGPOS_INCOME");

                entity.Property(e => e.OutstandingposIncometotal)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("OUTSTANDINGPOS_INCOMETOTAL");

                entity.Property(e => e.OutstandingposIsverify).HasColumnName("OUTSTANDINGPOS_ISVERIFY");

                entity.Property(e => e.OutstandingposModifyby).HasColumnName("OUTSTANDINGPOS_MODIFYBY");

                entity.Property(e => e.OutstandingposModifywhen)
                    .HasColumnType("datetime")
                    .HasColumnName("OUTSTANDINGPOS_MODIFYWHEN");

                entity.Property(e => e.OutstandingposName)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("OUTSTANDINGPOS_NAME");

                entity.Property(e => e.OutstandingposNoofdays).HasColumnName("OUTSTANDINGPOS_NOOFDAYS");

                entity.Property(e => e.OutstandingposOutstandingvalu)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("OUTSTANDINGPOS_OUTSTANDINGVALU");

                entity.Property(e => e.OutstandingposOutstandtot)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("OUTSTANDINGPOS_OUTSTANDTOT");

                entity.Property(e => e.OutstandingposProducttot)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("OUTSTANDINGPOS_PRODUCTTOT");

                entity.Property(e => e.OutstandingposProductvalue)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("OUTSTANDINGPOS_PRODUCTVALUE");

                entity.Property(e => e.OutstandingposRptsection).HasColumnName("OUTSTANDINGPOS_RPTSECTION");

                entity.Property(e => e.OutstandingposRpttype).HasColumnName("OUTSTANDINGPOS_RPTTYPE");

                entity.Property(e => e.OutstandingposTotal).HasColumnName("OUTSTANDINGPOS_TOTAL");

                entity.Property(e => e.OutstandingposTradinmonth).HasColumnName("OUTSTANDINGPOS_TRADINMONTH");

                entity.Property(e => e.OutstandingposWar)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("OUTSTANDINGPOS_WAR");

                entity.Property(e => e.OutstandingposWartot)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("OUTSTANDINGPOS_WARTOT");

                entity.Property(e => e.ProductCode).HasColumnName("PRODUCT_CODE");

                entity.Property(e => e.Rptcategory).HasColumnName("RPTCATEGORY");

                entity.Property(e => e.TradinsttypeCode).HasColumnName("TRADINSTTYPE_CODE");
            });

            modelBuilder.Entity<PmsParam>(entity =>
            {
                entity.HasKey(e => e.ParamCode);

                entity.ToTable("pms_params");

                entity.Property(e => e.ParamCode)
                    .ValueGeneratedNever()
                    .HasColumnName("param_code");

                entity.Property(e => e.FundCode).HasColumnName("fund_code");

                entity.Property(e => e.FundMasterCode).HasColumnName("fundMaster_code");

                entity.Property(e => e.ParamCgtdate)
                    .HasColumnType("datetime")
                    .HasColumnName("PARAM_CGTDATE");

                entity.Property(e => e.ParamCreatedBy).HasColumnName("param_createdBy");

                entity.Property(e => e.ParamCreatedWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("param_createdWhen");

                entity.Property(e => e.ParamCutoffDate)
                    .HasColumnType("datetime")
                    .HasColumnName("param_CutoffDate");

                entity.Property(e => e.ParamDesc)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("param_desc");

                entity.Property(e => e.ParamDtOfCommence)
                    .HasColumnType("datetime")
                    .HasColumnName("param_dtOfCommence");

                entity.Property(e => e.ParamDtOfExpiry)
                    .HasColumnType("datetime")
                    .HasColumnName("param_dtOfExpiry");

                entity.Property(e => e.ParamFlag).HasColumnName("param_flag");

                entity.Property(e => e.ParamInterestCalc).HasColumnName("param_interestCalc");

                entity.Property(e => e.ParamInvMovement).HasColumnName("param_InvMovement");

                entity.Property(e => e.ParamIsExposure).HasColumnName("PARAM_IsExposure");

                entity.Property(e => e.ParamIsOnetimeMvgAvg).HasColumnName("param_isOnetimeMvgAvg");

                entity.Property(e => e.ParamModifiedBy).HasColumnName("param_modifiedBy");

                entity.Property(e => e.ParamModifiedWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("param_modifiedWhen");

                entity.Property(e => e.ParamPkrv).HasColumnName("param_PKRV");

                entity.Property(e => e.ParamRepoPkrv).HasColumnName("param_repoPkrv");

                entity.Property(e => e.ParamRepoPkrvpremCalc).HasColumnName("param_RepoPKRVPremCalc");

                entity.Property(e => e.ParamSalKnOfType).HasColumnName("param_salKnOfType");

                entity.Property(e => e.ParamTradeDate).HasColumnName("param_TradeDate");

                entity.Property(e => e.ParamType).HasColumnName("param_type");

                entity.Property(e => e.ParamValue)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("param_Value");

                entity.Property(e => e.ProductCode).HasColumnName("product_code");

                entity.Property(e => e.TradInstTypeCode).HasColumnName("tradInstType_code");
            });

            modelBuilder.Entity<PmsParamConfig>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pms_ParamConfig");

                entity.Property(e => e.ParamCnfgDescription)
                    .IsUnicode(false)
                    .HasColumnName("paramCnfg_Description");

                entity.Property(e => e.ParamCnfgPhysicalName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("paramCnfg_PhysicalName");

                entity.Property(e => e.ParamCnfgType).HasColumnName("paramCnfg_type");

                entity.Property(e => e.ParamType).HasColumnName("param_type");
            });

            modelBuilder.Entity<PmsPkrv>(entity =>
            {
                entity.HasKey(e => new { e.PkrvCode, e.PkrvTempCode, e.PkrvDate });

                entity.ToTable("pms_PKRV");

                entity.Property(e => e.PkrvCode)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("Pkrv_code");

                entity.Property(e => e.PkrvTempCode).HasColumnName("PkrvTemp_code");

                entity.Property(e => e.PkrvDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Pkrv_date");

                entity.Property(e => e.BrokerCode).HasColumnName("broker_Code");

                entity.Property(e => e.PkrvAvgYield)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("Pkrv_avgYield");

                entity.Property(e => e.PkrvBrokerYield)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("Pkrv_brokerYield");
            });

            modelBuilder.Entity<PmsPkrvtemplate>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pms_PKRVTemplate");

                entity.Property(e => e.PkrvTempActive).HasColumnName("PkrvTemp_active");

                entity.Property(e => e.PkrvTempCode).HasColumnName("PkrvTemp_code");

                entity.Property(e => e.PkrvTempType).HasColumnName("PkrvTemp_type");

                entity.Property(e => e.PkrvTempUpperBond).HasColumnName("PkrvTemp_upperBond");
            });

            modelBuilder.Entity<PmsPolicyAndRegulation>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pms_policyAndRegulation");

                entity.Property(e => e.FInstCode).HasColumnName("fInst_code");

                entity.Property(e => e.FInstTypeCode).HasColumnName("fInstType_code");

                entity.Property(e => e.PolicyAcquirePercentage)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("policy_acquirePercentage");

                entity.Property(e => e.PolicyCheckAcquirePercentage).HasColumnName("policy_CheckAcquirePercentage");

                entity.Property(e => e.PolicyCode).HasColumnName("policy_Code");

                entity.Property(e => e.PolicyModfyidate)
                    .HasColumnType("datetime")
                    .HasColumnName("policy_modfyidate");

                entity.Property(e => e.PolicyModifyBy).HasColumnName("Policy_modifyBy");
            });

            modelBuilder.Entity<PmsPorfoliGrpWiseLmt>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pms_porfoliGrpWiseLmt");

                entity.Property(e => e.FundmasterCode).HasColumnName("Fundmaster_code");

                entity.Property(e => e.PorfoliGrpWiseLmtCode).HasColumnName("porfoliGrpWiseLmt_code");

                entity.Property(e => e.PorfoliGrpWiseLmtCreatedBy).HasColumnName("porfoliGrpWiseLmt_CreatedBy");

                entity.Property(e => e.PorfoliGrpWiseLmtCreatedWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("porfoliGrpWiseLmt_CreatedWhen");

                entity.Property(e => e.PorfoliGrpWiseLmtDate)
                    .HasColumnType("datetime")
                    .HasColumnName("porfoliGrpWiseLmt_date");

                entity.Property(e => e.PorfoliGrpWiseLmtFFlag)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("porfoliGrpWiseLmt_fFlag");

                entity.Property(e => e.PorfoliGrpWiseLmtFundMemonics)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("porfoliGrpWiseLmt_fundMemonics");

                entity.Property(e => e.PorfoliGrpWiseLmtIsActive).HasColumnName("porfoliGrpWiseLmt_isActive");

                entity.Property(e => e.PorfoliGrpWiseLmtLimit)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("porfoliGrpWiseLmt_Limit");

                entity.Property(e => e.PorfoliGrpWiseLmtSno).HasColumnName("porfoliGrpWiseLmt_Sno");
            });

            modelBuilder.Entity<PmsPortfolioLimit>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pms_portfolioLimit");

                entity.Property(e => e.AssetTypeCode).HasColumnName("assetType_code");

                entity.Property(e => e.AssetValue).HasColumnType("decimal(25, 6)");

                entity.Property(e => e.AssetallocAmountLimit)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("assetalloc_amountLimit");

                entity.Property(e => e.AssetallocCode).HasColumnName("assetalloc_code");

                entity.Property(e => e.AssetallocDate)
                    .HasColumnType("datetime")
                    .HasColumnName("assetalloc_Date");

                entity.Property(e => e.AssetallocLimitPercentage)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("assetalloc_limitPercentage");

                entity.Property(e => e.AssetmoduleCode).HasColumnName("assetmodule_code");

                entity.Property(e => e.AssetmoduleGroupby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("assetmodule_groupby");

                entity.Property(e => e.AssetmoduleName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("assetmodule_name");

                entity.Property(e => e.AssetmoduleSno).HasColumnName("assetmodule_sno");

                entity.Property(e => e.ExpCreatedBy).HasColumnName("expCreatedBy");

                entity.Property(e => e.ExpCreatedWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("expCreatedWhen");

                entity.Property(e => e.ExpDate)
                    .HasColumnType("datetime")
                    .HasColumnName("expDate");

                entity.Property(e => e.ExpModifiedBy).HasColumnName("expModifiedBy");

                entity.Property(e => e.ExpModifiedWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("expModifiedWhen");

                entity.Property(e => e.Flag).HasColumnName("flag");

                entity.Property(e => e.FundNavNav)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("fundNAV_NAV");
            });

            modelBuilder.Entity<PmsPortfoliolog>(entity =>
            {
                entity.HasKey(e => new { e.PortfoliologSno, e.FundmasterCode })
                    .HasName("PK_PMS_PORTFOLIOLOG");

                entity.ToTable("pms_portfoliolog");

                entity.Property(e => e.PortfoliologSno).HasColumnName("PORTFOLIOLOG_SNO");

                entity.Property(e => e.FundmasterCode).HasColumnName("FUNDMASTER_CODE");

                entity.Property(e => e.Accperday).HasColumnName("ACCPERDAY");

                entity.Property(e => e.Acdinterstonpur)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("ACDINTERSTONPUR");

                entity.Property(e => e.Balanceirr)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("BALANCEIRR");

                entity.Property(e => e.BrokerCode).HasColumnName("BROKER_CODE");

                entity.Property(e => e.Closingirr)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("CLOSINGIRR");

                entity.Property(e => e.Commtax)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("COMMTAX");

                entity.Property(e => e.CouponDate)
                    .HasColumnType("datetime")
                    .HasColumnName("COUPON_DATE");

                entity.Property(e => e.CouponEnddate)
                    .HasColumnType("datetime")
                    .HasColumnName("COUPON_ENDDATE");

                entity.Property(e => e.CouponProjecteddate)
                    .HasColumnType("datetime")
                    .HasColumnName("COUPON_PROJECTEDDATE");

                entity.Property(e => e.Coupondays).HasColumnName("COUPONDAYS");

                entity.Property(e => e.CpoupnNextdate)
                    .HasColumnType("datetime")
                    .HasColumnName("CPOUPN_NEXTDATE");

                entity.Property(e => e.Dbltotalaccruedamt)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("DBLTOTALACCRUEDAMT");

                entity.Property(e => e.FundCode).HasColumnName("FUND_CODE");

                entity.Property(e => e.FundName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FUND_NAME");

                entity.Property(e => e.FundmasterName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FUNDMASTER_NAME");

                entity.Property(e => e.Interestaccrued)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("INTERESTACCRUED");

                entity.Property(e => e.Interestoutdays).HasColumnName("INTERESTOUTDAYS");

                entity.Property(e => e.Interestoutstanding)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("INTERESTOUTSTANDING");

                entity.Property(e => e.Interestrecdays).HasColumnName("INTERESTRECDAYS");

                entity.Property(e => e.Interestreceived)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("INTERESTRECEIVED");

                entity.Property(e => e.Intersttotos)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("INTERSTTOTOS");

                entity.Property(e => e.InvbondsAccrualbasis).HasColumnName("INVBONDS_ACCRUALBASIS");

                entity.Property(e => e.InvbondsCouponrateperannum)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("INVBONDS_COUPONRATEPERANNUM");

                entity.Property(e => e.InvbondsFacevalue)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("INVBONDS_FACEVALUE");

                entity.Property(e => e.InvbondsIssuedate)
                    .HasColumnType("datetime")
                    .HasColumnName("INVBONDS_ISSUEDATE");

                entity.Property(e => e.InvbondsMaturitydate)
                    .HasColumnType("datetime")
                    .HasColumnName("INVBONDS_MATURITYDATE");

                entity.Property(e => e.InvbondsMaturityperiod).HasColumnName("INVBONDS_MATURITYPERIOD");

                entity.Property(e => e.InvbondsName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("INVBONDS_NAME");

                entity.Property(e => e.InvbondsRedemptiontenor).HasColumnName("INVBONDS_REDEMPTIONTENOR");

                entity.Property(e => e.InvbondsYears).HasColumnName("INVBONDS_YEARS");

                entity.Property(e => e.Latestcoupon)
                    .HasColumnType("datetime")
                    .HasColumnName("LATESTCOUPON");

                entity.Property(e => e.Marketprice)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("MARKETPRICE");

                entity.Property(e => e.Matdays).HasColumnName("MATDAYS");

                entity.Property(e => e.Noofcoupons).HasColumnName("NOOFCOUPONS");

                entity.Property(e => e.Openingirr)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("OPENINGIRR");

                entity.Property(e => e.OrderAmount)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("ORDER_AMOUNT");

                entity.Property(e => e.OrderBrokerrate)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("ORDER_BROKERRATE");

                entity.Property(e => e.OrderBrokerratemode).HasColumnName("ORDER_BROKERRATEMODE");

                entity.Property(e => e.OrderCode).HasColumnName("ORDER_CODE");

                entity.Property(e => e.OrderDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ORDER_DATE");

                entity.Property(e => e.OrderMode).HasColumnName("ORDER_MODE");

                entity.Property(e => e.OrderQuantity)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("ORDER_QUANTITY");

                entity.Property(e => e.OrderRefno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ORDER_REFNO");

                entity.Property(e => e.OrdexecAmount)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("ORDEXEC_AMOUNT");

                entity.Property(e => e.OrdexecCfsTradeno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ORDEXEC_CFS_TRADENO");

                entity.Property(e => e.OrdexecCntpartyname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ORDEXEC_CNTPARTYNAME");

                entity.Property(e => e.OrdexecDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ORDEXEC_DATE");

                entity.Property(e => e.OrdexecDealtickno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ORDEXEC_DEALTICKNO");

                entity.Property(e => e.OrdexecInceptionprice)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("ORDEXEC_INCEPTIONPRICE");

                entity.Property(e => e.OrdexecInterestoutstanding)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("ORDEXEC_INTERESTOUTSTANDING");

                entity.Property(e => e.OrdexecPrice)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("ORDEXEC_PRICE");

                entity.Property(e => e.OrdexecReferenceno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ORDEXEC_REFERENCENO");

                entity.Property(e => e.OrdexecTradeyield)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("ORDEXEC_TRADEYIELD");

                entity.Property(e => e.Outstandingirr)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("OUTSTANDINGIRR");

                entity.Property(e => e.Paramflag).HasColumnName("PARAMFLAG");

                entity.Property(e => e.PortfoliologCreatedby).HasColumnName("PORTFOLIOLOG_CREATEDBY");

                entity.Property(e => e.PortfoliologCreatedwhen)
                    .HasColumnType("datetime")
                    .HasColumnName("PORTFOLIOLOG_CREATEDWHEN");

                entity.Property(e => e.PortfoliologIsverified).HasColumnName("PORTFOLIOLOG_ISVERIFIED");

                entity.Property(e => e.PortfoliologProcenddate)
                    .HasColumnType("datetime")
                    .HasColumnName("PORTFOLIOLOG_PROCENDDATE");

                entity.Property(e => e.Premdiscount)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("PREMDISCOUNT");

                entity.Property(e => e.Previouscoupon)
                    .HasColumnType("datetime")
                    .HasColumnName("PREVIOUSCOUPON");

                entity.Property(e => e.Primarydealer)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PRIMARYDEALER");

                entity.Property(e => e.ProductCode).HasColumnName("PRODUCT_CODE");

                entity.Property(e => e.QuarterEnddate)
                    .HasColumnType("datetime")
                    .HasColumnName("QUARTER_ENDDATE");

                entity.Property(e => e.QuarterStartdate)
                    .HasColumnType("datetime")
                    .HasColumnName("QUARTER_STARTDATE");

                entity.Property(e => e.Remainingcoupondays).HasColumnName("REMAININGCOUPONDAYS");

                entity.Property(e => e.SettdateAccruedinterest)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("SETTDATE_ACCRUEDINTEREST");

                entity.Property(e => e.SettdateAmount)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("SETTDATE_AMOUNT");

                entity.Property(e => e.SettdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("SETTDATE_DATE");

                entity.Property(e => e.SettdateNetamount)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("SETTDATE_NETAMOUNT");

                entity.Property(e => e.SettdateQuantity)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("SETTDATE_QUANTITY");

                entity.Property(e => e.SettdateRate)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("SETTDATE_RATE");

                entity.Property(e => e.Totalamortquarter)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("TOTALAMORTQUARTER");

                entity.Property(e => e.Totalbeforequartervalue)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("TOTALBEFOREQUARTERVALUE");

                entity.Property(e => e.Totalinterst)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("TOTALINTERST");

                entity.Property(e => e.Totalirrincome)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("TOTALIRRINCOME");

                entity.Property(e => e.TradinstCode).HasColumnName("TRADINST_CODE");

                entity.Property(e => e.TradinsttypeCode).HasColumnName("TRADINSTTYPE_CODE");
            });

            modelBuilder.Entity<PmsProcessCashflow>(entity =>
            {
                entity.HasKey(e => new { e.ProcessCfCode, e.CashTypeCode, e.FundMasterCode, e.FInstTranDate });

                entity.ToTable("pms_processCashflow");

                entity.Property(e => e.ProcessCfCode).HasColumnName("processCF_code");

                entity.Property(e => e.CashTypeCode).HasColumnName("cashTypeCode");

                entity.Property(e => e.FundMasterCode).HasColumnName("fundMaster_code");

                entity.Property(e => e.FInstTranDate)
                    .HasColumnType("datetime")
                    .HasColumnName("fInstTran_date");

                entity.Property(e => e.BrokerName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("broker_name");

                entity.Property(e => e.CashTypeValidityDate).HasColumnName("cashType_validityDate");

                entity.Property(e => e.CfDateDelivery)
                    .HasColumnType("datetime")
                    .HasColumnName("cf_dateDelivery");

                entity.Property(e => e.CfDateSettlement)
                    .HasColumnType("datetime")
                    .HasColumnName("cf_dateSettlement");

                entity.Property(e => e.FInstName)
                    .IsUnicode(false)
                    .HasColumnName("fInst_name");

                entity.Property(e => e.FInstTranCode).HasColumnName("fInstTran_code");

                entity.Property(e => e.FInstTranRefNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fInstTran_RefNo");

                entity.Property(e => e.FInstTranSettBank).HasColumnName("fInstTran_settBank");

                entity.Property(e => e.FInstTranType).HasColumnName("fInstTran_type");

                entity.Property(e => e.FInstTypeName)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("fInstType_name");

                entity.Property(e => e.FinstTranMode).HasColumnName("finstTran_mode");

                entity.Property(e => e.FundCapAccuralMethod).HasColumnName("fundCap_AccuralMethod");

                entity.Property(e => e.FundCapMaturityDate)
                    .HasColumnType("datetime")
                    .HasColumnName("fundCap_MaturityDate");

                entity.Property(e => e.FundCapReportType).HasColumnName("fundCap_ReportType");

                entity.Property(e => e.ProcessCfAmount)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("processCF_amount");

                entity.Property(e => e.ProcessCfCreatedBy).HasColumnName("processCF_createdBy");

                entity.Property(e => e.ProcessCfCreatedWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("processCF_createdWhen");

                entity.Property(e => e.ProcessCfEndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("processCF_endDate");

                entity.Property(e => e.ProcessCfIsActive).HasColumnName("processCF_IsActive");

                entity.Property(e => e.ProcessCfIsAllfund)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("processCF_isAllfund");

                entity.Property(e => e.ProcessCfMode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("processCF_mode");

                entity.Property(e => e.ProcessCfModifyBy).HasColumnName("processCF_modifyBy");

                entity.Property(e => e.ProcessCfModifyWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("processCF_modifyWhen");

                entity.Property(e => e.ProcessCfQuantity)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("processCF_quantity");

                entity.Property(e => e.ProcessCfRate)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("processCF_rate");

                entity.Property(e => e.ProcessCfStartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("processCF_startDate");

                entity.Property(e => e.ProcessCfSymbol)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("processCF_symbol");

                entity.Property(e => e.ProductCode).HasColumnName("product_code");

                entity.Property(e => e.TradInstTypeCode).HasColumnName("tradInstType_code");
            });

            modelBuilder.Entity<PmsProcessImpairmentTesting>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pms_processImpairmentTesting");

                entity.Property(e => e.DmpPrice)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("DMP_price");

                entity.Property(e => e.FundCode).HasColumnName("fund_code");

                entity.Property(e => e.FundMasterCode).HasColumnName("fundMaster_code");

                entity.Property(e => e.MarketValue)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("Market_Value");

                entity.Property(e => e.MovAvgAmtCarr)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("movAvg_amtCarr");

                entity.Property(e => e.MovAvgAmtMov)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("movAvg_amtMov");

                entity.Property(e => e.MovAvgAverage)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("movAvg_average");

                entity.Property(e => e.MovAvgQty)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("movAvg_qty");

                entity.Property(e => e.MovAvgTranDate)
                    .HasColumnType("datetime")
                    .HasColumnName("movAvg_tranDate");

                entity.Property(e => e.ProcessImpTestingCreatedBy).HasColumnName("processImpTesting_createdBy");

                entity.Property(e => e.ProcessImpTestingCreatedWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("processImpTesting_createdWhen");

                entity.Property(e => e.ProcessImpTestingFromDate)
                    .HasColumnType("datetime")
                    .HasColumnName("processImpTesting_fromDate");

                entity.Property(e => e.ProcessImpTestingIsVerified).HasColumnName("processImpTesting_IsVerified");

                entity.Property(e => e.ProcessImpTestingProcessDate)
                    .HasColumnType("datetime")
                    .HasColumnName("processImpTesting_processDate");

                entity.Property(e => e.ProcessImpTestingSno).HasColumnName("processImpTesting_SNO");

                entity.Property(e => e.ProcessImpTestingToDate)
                    .HasColumnType("datetime")
                    .HasColumnName("processImpTesting_toDate");

                entity.Property(e => e.ProcessImpTestingVerifiedBy).HasColumnName("processImpTesting_verifiedBy");

                entity.Property(e => e.ProcessImpTestingVerifiedWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("processImpTesting_verifiedWhen");

                entity.Property(e => e.TradInstTypeCode).HasColumnName("tradInstType_code");

                entity.Property(e => e.TradinstCode).HasColumnName("tradinst_code");

                entity.Property(e => e.UnrealisedGainLoss)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("unrealised_GainLoss");

                entity.Property(e => e.UnrealisedGainLossMaxPer)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("unrealised_GainLoss_MAX_Per");

                entity.Property(e => e.UnrealisedGainLossMinPer)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("unrealised_GainLoss_MIN_Per");

                entity.Property(e => e.UnrealisedGainLossPer)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("unrealised_GainLoss_Per");
            });

            modelBuilder.Entity<PmsProcessPortfolio>(entity =>
            {
                entity.HasKey(e => new { e.Sno, e.FundMasterCode, e.DateMonth });

                entity.ToTable("pms_ProcessPortfolio");

                entity.Property(e => e.Sno).HasColumnName("SNo");

                entity.Property(e => e.FundMasterCode).HasColumnName("fundMaster_code");

                entity.Property(e => e.DateMonth).HasColumnType("datetime");

                entity.Property(e => e.Beginning).HasColumnType("decimal(25, 6)");

                entity.Property(e => e.Cash).HasColumnType("decimal(25, 6)");

                entity.Property(e => e.ChangeInNav)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("ChangeInNAV");

                entity.Property(e => e.Closing).HasColumnType("decimal(25, 6)");

                entity.Property(e => e.Contribution).HasColumnType("decimal(25, 6)");

                entity.Property(e => e.CreatedWhen).HasColumnType("datetime");

                entity.Property(e => e.FundIsActive).HasColumnName("fundIsActive");

                entity.Property(e => e.FundMasterName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fundMaster_name");

                entity.Property(e => e.Ltbs).HasColumnType("decimal(25, 6)");

                entity.Property(e => e.ModifiedWhen).HasColumnType("datetime");

                entity.Property(e => e.Mtbs)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("MTbs");

                entity.Property(e => e.OpenEnd).HasColumnType("decimal(25, 6)");

                entity.Property(e => e.PortfolioIsLocked).HasColumnName("Portfolio_IsLocked");

                entity.Property(e => e.PortfolioYear)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Stock).HasColumnType("decimal(25, 6)");

                entity.Property(e => e.Withdrawls).HasColumnType("decimal(25, 6)");
            });

            modelBuilder.Entity<PmsProposhare>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pms_proposhare");

                entity.Property(e => e.FInstBranchCode).HasColumnName("fInstBranch_code");

                entity.Property(e => e.FInstCode).HasColumnName("fInst_code");

                entity.Property(e => e.FInstTypeCode).HasColumnName("fInstType_code");

                entity.Property(e => e.FundCode).HasColumnName("fund_code");

                entity.Property(e => e.InstCode).HasColumnName("Inst_code");

                entity.Property(e => e.InstTypeCode).HasColumnName("InstType_code");

                entity.Property(e => e.ProposhareDate)
                    .HasColumnType("datetime")
                    .HasColumnName("proposhare_date");

                entity.Property(e => e.ProposhareDesc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("proposhare_desc");

                entity.Property(e => e.ProposhareHolding)
                    .HasColumnType("decimal(25, 0)")
                    .HasColumnName("proposhare_holding");

                entity.Property(e => e.ProposhareQuantity)
                    .HasColumnType("decimal(25, 0)")
                    .HasColumnName("proposhare_quantity");

                entity.Property(e => e.ProposhareType).HasColumnName("proposhare_type");
            });

            modelBuilder.Entity<PmsPurSalRef>(entity =>
            {
                entity.HasKey(e => new { e.PsrefPurDealTickNo, e.PsrefSalDealTickNo })
                    .HasName("PK_pms_purSellRef");

                entity.ToTable("pms_purSalRef");

                entity.Property(e => e.PsrefPurDealTickNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PSRef_purDealTickNo");

                entity.Property(e => e.PsrefSalDealTickNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PSRef_salDealTickNo");

                entity.Property(e => e.FundCode).HasColumnName("fund_code");

                entity.Property(e => e.PsrefAmount)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("PSRef_amount");

                entity.Property(e => e.PsrefBalQty)
                    .HasColumnType("decimal(25, 0)")
                    .HasColumnName("PSRef_balQty");

                entity.Property(e => e.PsrefKnoffType).HasColumnName("PSRef_knoffType");

                entity.Property(e => e.PsrefModifiedBy).HasColumnName("PSRef_modifiedBy");

                entity.Property(e => e.PsrefModifiedWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("PSRef_modifiedWhen");

                entity.Property(e => e.PsrefPurDate)
                    .HasColumnType("datetime")
                    .HasColumnName("PSRef_purDate");

                entity.Property(e => e.PsrefPurPrice)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("PSRef_purPrice");

                entity.Property(e => e.PsrefQuantity)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("PSRef_quantity");

                entity.Property(e => e.PsrefSalPrice)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("PSRef_salPrice");

                entity.Property(e => e.TradInstCode).HasColumnName("tradInst_code");

                entity.Property(e => e.TradInstTypeCode).HasColumnName("tradInstType_code");
            });

            modelBuilder.Entity<PmsRateTempl>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pms_rateTempl");

                entity.Property(e => e.RateTemplCode).HasColumnName("rateTempl_code");

                entity.Property(e => e.RateTemplNoofDays)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("rateTempl_NoofDays");

                entity.Property(e => e.RateTemplSlabName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("rateTempl_slabName");

                entity.Property(e => e.RateTemplType).HasColumnName("rateTempl_type");

                entity.Property(e => e.RateTemplTypeName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("rateTempl_typeName");

                entity.Property(e => e.RatetemplPeriodDays).HasColumnName("ratetempl_periodDays");
            });

            modelBuilder.Entity<PmsRating>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pms_rating");

                entity.Property(e => e.RatingCode).HasColumnName("rating_code");

                entity.Property(e => e.RatingDesc)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("rating_desc");

                entity.Property(e => e.RatingModifiedBy).HasColumnName("rating_modifiedBy");

                entity.Property(e => e.RatingModifiedWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("rating_modifiedWhen");

                entity.Property(e => e.RatingName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("rating_name");
            });

            modelBuilder.Entity<PmsRecurrFeeType>(entity =>
            {
                entity.HasKey(e => e.RecurrFeeTypeCode);

                entity.ToTable("pms_recurrFeeType");

                entity.Property(e => e.RecurrFeeTypeCode)
                    .ValueGeneratedNever()
                    .HasColumnName("recurrFeeType_code");

                entity.Property(e => e.RecurrFeeTypeDesc)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("recurrFeeType_desc");

                entity.Property(e => e.RecurrFeeTypeName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("recurrFeeType_name");

                entity.Property(e => e.TransactionType).HasColumnName("transaction_type");

                entity.Property(e => e.VfmtMstrFmtCode).HasColumnName("vfmtMstr_fmtCode");
            });

            modelBuilder.Entity<PmsRiskAppetite>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pms_riskAppetite");

                entity.Property(e => e.FundMasterCode).HasColumnName("fundMaster_code");

                entity.Property(e => e.RiskAppetiteCreatedBy).HasColumnName("riskAppetite_createdBy");

                entity.Property(e => e.RiskAppetiteCreatedWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("riskAppetite_createdWhen");

                entity.Property(e => e.RiskAppetiteDate)
                    .HasColumnType("datetime")
                    .HasColumnName("riskAppetite_Date");

                entity.Property(e => e.RiskAppetiteFundFlag)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("riskAppetite_fundFlag");

                entity.Property(e => e.RiskAppetiteIsActive).HasColumnName("riskAppetite_isActive");

                entity.Property(e => e.RiskAppetiteLoss)
                    .HasColumnType("decimal(25, 2)")
                    .HasColumnName("riskAppetite_Loss");

                entity.Property(e => e.RiskAppetiteSno).HasColumnName("riskAppetite_Sno");
            });

            modelBuilder.Entity<PmsRiskAppetiteProcess>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pms_riskAppetiteProcess");

                entity.Property(e => e.FundMasterCode).HasColumnName("fundMaster_code");

                entity.Property(e => e.RaProcessAvgInvestment)
                    .HasColumnType("decimal(25, 2)")
                    .HasColumnName("raProcess_AvgInvestment");

                entity.Property(e => e.RaProcessCapitalGain)
                    .HasColumnType("decimal(25, 2)")
                    .HasColumnName("raProcess_capitalGain");

                entity.Property(e => e.RaProcessCreatedBy).HasColumnName("raProcess_CreatedBy");

                entity.Property(e => e.RaProcessCreatedWhen)
                    .HasColumnType("date")
                    .HasColumnName("raProcess_CreatedWhen");

                entity.Property(e => e.RaProcessDate)
                    .HasColumnType("date")
                    .HasColumnName("raProcess_Date");

                entity.Property(e => e.RaProcessDateFrom)
                    .HasColumnType("date")
                    .HasColumnName("raProcess_DateFrom");

                entity.Property(e => e.RaProcessDateTo)
                    .HasColumnType("date")
                    .HasColumnName("raProcess_DateTo");

                entity.Property(e => e.RaProcessDividend)
                    .HasColumnType("decimal(25, 2)")
                    .HasColumnName("raProcess_Dividend");

                entity.Property(e => e.RaProcessLock).HasColumnName("raProcess_Lock");

                entity.Property(e => e.RaProcessSurplusValuation)
                    .HasColumnType("decimal(25, 2)")
                    .HasColumnName("raProcess_SurplusValuation");

                entity.Property(e => e.RiskAppititeLoss)
                    .HasColumnType("decimal(25, 2)")
                    .HasColumnName("riskAppitite_loss");
            });

            modelBuilder.Entity<PmsRiskLimitConfig>(entity =>
            {
                entity.HasKey(e => new { e.RiskLimitConfigCode, e.FundmasterCode, e.RiskLimitConfigDate });

                entity.ToTable("PMS_RiskLimitConfig");

                entity.Property(e => e.RiskLimitConfigCode).HasColumnName("RiskLimitConfig_CODE");

                entity.Property(e => e.FundmasterCode).HasColumnName("FUNDMASTER_CODE");

                entity.Property(e => e.RiskLimitConfigDate)
                    .HasColumnType("datetime")
                    .HasColumnName("RiskLimitConfig_DATE");

                entity.Property(e => e.RiskLimitConfigActive).HasColumnName("RiskLimitConfig_active");

                entity.Property(e => e.RiskLimitConfigAmountType).HasColumnName("RiskLimitConfig_amountType");

                entity.Property(e => e.RiskLimitConfigCreatedby).HasColumnName("RiskLimitConfig_CREATEDBY");

                entity.Property(e => e.RiskLimitConfigCreatedwhen)
                    .HasColumnType("datetime")
                    .HasColumnName("RiskLimitConfig_CREATEDWHEN");

                entity.Property(e => e.RiskLimitConfigIsconfiguraion).HasColumnName("RiskLimitConfig_ISCONFIGURAION");

                entity.Property(e => e.RiskLimitConfigMaxAmountlimit)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("RiskLimitConfig_MaxAMOUNTLIMIT");

                entity.Property(e => e.RiskLimitConfigMinAmountlimit)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("RiskLimitConfig_MinAMOUNTLIMIT");

                entity.Property(e => e.RiskLimitConfigModifiedby).HasColumnName("RiskLimitConfig_MODIFIEDBY");

                entity.Property(e => e.RiskLimitConfigModifiedwhen)
                    .HasColumnType("datetime")
                    .HasColumnName("RiskLimitConfig_MODIFIEDWHEN");

                entity.Property(e => e.RiskLimitConfigProduct).HasColumnName("RiskLimitConfig_product");
            });

            modelBuilder.Entity<PmsRptSlab>(entity =>
            {
                entity.HasKey(e => e.RptslabId);

                entity.ToTable("pms_rptSlab");

                entity.Property(e => e.RptslabId)
                    .ValueGeneratedNever()
                    .HasColumnName("RPTSLAB_ID");

                entity.Property(e => e.RptslabCreatedby).HasColumnName("RPTSLAB_CREATEDBY");

                entity.Property(e => e.RptslabCreatedwhen)
                    .HasColumnType("datetime")
                    .HasColumnName("RPTSLAB_CREATEDWHEN");

                entity.Property(e => e.RptslabDays).HasColumnName("RPTSLAB_DAYS");

                entity.Property(e => e.RptslabFormattype).HasColumnName("RPTSLAB_FORMATTYPE");

                entity.Property(e => e.RptslabModifyby).HasColumnName("RPTSLAB_MODIFYBY");

                entity.Property(e => e.RptslabModifywhen)
                    .HasColumnType("datetime")
                    .HasColumnName("RPTSLAB_MODIFYWHEN");

                entity.Property(e => e.RptslabTitle)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RPTSLAB_TITLE");

                entity.Property(e => e.RptslabType).HasColumnName("RPTSLAB_TYPE");
            });

            modelBuilder.Entity<PmsRptportfolio>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PMS_RPTPORTFOLIO");

                entity.Property(e => e.Facevaluebclean)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("FACEVALUEBCLEAN");

                entity.Property(e => e.Facevaluebcoi)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("FACEVALUEBCOI");

                entity.Property(e => e.Facevaluebpptfc)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("FACEVALUEBPPTFC");

                entity.Property(e => e.Facevaluecoi)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("FACEVALUECOI");

                entity.Property(e => e.Facevaluelistedtfc)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("FACEVALUELISTEDTFC");

                entity.Property(e => e.Facevaluelop)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("FACEVALUELOP");

                entity.Property(e => e.Facevaluemarketfund)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("FACEVALUEMARKETFUND");

                entity.Property(e => e.Facevaluemarksec)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("FACEVALUEMARKSEC");

                entity.Property(e => e.Facevaluenpalistedtfc)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("FACEVALUENPALISTEDTFC");

                entity.Property(e => e.Facevaluenpapptfc)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("FACEVALUENPAPPTFC");

                entity.Property(e => e.Facevaluenpasukuk)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("FACEVALUENPASUKUK");

                entity.Property(e => e.Facevaluepib)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("FACEVALUEPIB");

                entity.Property(e => e.Facevaluepptfc)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("FACEVALUEPPTFC");

                entity.Property(e => e.Facevaluerf)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("FACEVALUERF");

                entity.Property(e => e.Facevaluerpib)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("FACEVALUERPIB");

                entity.Property(e => e.Facevaluerrother)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("FACEVALUERROTHER");

                entity.Property(e => e.Facevaluerrpib)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("FACEVALUERRPIB");

                entity.Property(e => e.Facevaluerrtbill)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("FACEVALUERRTBILL");

                entity.Property(e => e.Facevaluertbill)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("FACEVALUERTBILL");

                entity.Property(e => e.Facevaluertfc)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("FACEVALUERTFC");

                entity.Property(e => e.Facevaluesecbor)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("FACEVALUESECBOR");

                entity.Property(e => e.Facevaluesukuk)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("FACEVALUESUKUK");

                entity.Property(e => e.Facevaluetbill)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("FACEVALUETBILL");

                entity.Property(e => e.FundmasterCode).HasColumnName("FUNDMASTER_CODE");

                entity.Property(e => e.FundmasterName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("FUNDMASTER_NAME");

                entity.Property(e => e.ProcessDate)
                    .HasColumnType("datetime")
                    .HasColumnName("PROCESS_date");

                entity.Property(e => e.Productvaluebclean)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("PRODUCTVALUEBCLEAN");

                entity.Property(e => e.Productvaluebcoi)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("PRODUCTVALUEBCOI");

                entity.Property(e => e.Productvaluebpptfc)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("PRODUCTVALUEBPPTFC");

                entity.Property(e => e.Productvaluecoi)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("PRODUCTVALUECOI");

                entity.Property(e => e.Productvaluelistedtfc)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("PRODUCTVALUELISTEDTFC");

                entity.Property(e => e.Productvaluelop)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("PRODUCTVALUELOP");

                entity.Property(e => e.Productvaluemarketfund)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("PRODUCTVALUEMARKETFUND");

                entity.Property(e => e.Productvaluemarksec)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("PRODUCTVALUEMARKSEC");

                entity.Property(e => e.Productvaluenpalistedtfc)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("PRODUCTVALUENPALISTEDTFC");

                entity.Property(e => e.Productvaluenpapptfc)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("PRODUCTVALUENPAPPTFC");

                entity.Property(e => e.Productvaluenpasukuk)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("PRODUCTVALUENPASUKUK");

                entity.Property(e => e.Productvaluepib)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("PRODUCTVALUEPIB");

                entity.Property(e => e.Productvaluepptfc)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("PRODUCTVALUEPPTFC");

                entity.Property(e => e.Productvaluerf)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("PRODUCTVALUERF");

                entity.Property(e => e.Productvaluerpib)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("PRODUCTVALUERPIB");

                entity.Property(e => e.Productvaluerrother)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("PRODUCTVALUERROTHER");

                entity.Property(e => e.Productvaluerrpib)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("PRODUCTVALUERRPIB");

                entity.Property(e => e.Productvaluerrtbill)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("PRODUCTVALUERRTBILL");

                entity.Property(e => e.Productvaluertbill)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("PRODUCTVALUERTBILL");

                entity.Property(e => e.Productvaluertfc)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("PRODUCTVALUERTFC");

                entity.Property(e => e.Productvaluesecbor)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("PRODUCTVALUESECBOR");

                entity.Property(e => e.Productvaluesukuk)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("PRODUCTVALUESUKUK");

                entity.Property(e => e.Productvaluetbill)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("PRODUCTVALUETBILL");

                entity.Property(e => e.RptportfolioCreatedby).HasColumnName("RPTPORTFOLIO_CREATEDBY");

                entity.Property(e => e.RptportfolioCreatedwhen)
                    .HasColumnType("datetime")
                    .HasColumnName("RPTPORTFOLIO_CREATEDWHEN");

                entity.Property(e => e.RptportfolioIsverify).HasColumnName("RPTPORTFOLIO_ISVERIFY");

                entity.Property(e => e.RptportfolioModifyby).HasColumnName("RPTPORTFOLIO_MODIFYBY");

                entity.Property(e => e.RptportfolioModifywhen)
                    .HasColumnType("datetime")
                    .HasColumnName("RPTPORTFOLIO_MODIFYWHEN");

                entity.Property(e => e.Weightedavgbclean)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("WEIGHTEDAVGBCLEAN");

                entity.Property(e => e.Weightedavgbcoi)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("WEIGHTEDAVGBCOI");

                entity.Property(e => e.Weightedavgbpptfc)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("WEIGHTEDAVGBPPTFC");

                entity.Property(e => e.Weightedavgcoi)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("WEIGHTEDAVGCOI");

                entity.Property(e => e.Weightedavglistedtfc)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("WEIGHTEDAVGLISTEDTFC");

                entity.Property(e => e.Weightedavglop)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("WEIGHTEDAVGLOP");

                entity.Property(e => e.Weightedavgmarketfund)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("WEIGHTEDAVGMARKETFUND");

                entity.Property(e => e.Weightedavgmarksec)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("WEIGHTEDAVGMARKSEC");

                entity.Property(e => e.Weightedavgnpalistedtfc)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("WEIGHTEDAVGNPALISTEDTFC");

                entity.Property(e => e.Weightedavgnpapptfc)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("WEIGHTEDAVGNPAPPTFC");

                entity.Property(e => e.Weightedavgnpasukuk)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("WEIGHTEDAVGNPASUKUK");

                entity.Property(e => e.Weightedavgpib)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("WEIGHTEDAVGPIB");

                entity.Property(e => e.Weightedavgpptfc)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("WEIGHTEDAVGPPTFC");

                entity.Property(e => e.Weightedavgrf)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("WEIGHTEDAVGRF");

                entity.Property(e => e.Weightedavgrpib)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("WEIGHTEDAVGRPIB");

                entity.Property(e => e.Weightedavgrrother)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("WEIGHTEDAVGRROTHER");

                entity.Property(e => e.Weightedavgrrpib)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("WEIGHTEDAVGRRPIB");

                entity.Property(e => e.Weightedavgrrtbill)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("WEIGHTEDAVGRRTBILL");

                entity.Property(e => e.Weightedavgrtbill)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("WEIGHTEDAVGRTBILL");

                entity.Property(e => e.Weightedavgrtfc)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("WEIGHTEDAVGRTFC");

                entity.Property(e => e.Weightedavgsecbor)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("WEIGHTEDAVGSECBOR");

                entity.Property(e => e.Weightedavgsukuk)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("WEIGHTEDAVGSUKUK");

                entity.Property(e => e.Weightedavgtbill)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("WEIGHTEDAVGTBILL");
            });

            modelBuilder.Entity<PmsScoreRating>(entity =>
            {
                entity.HasKey(e => new { e.ScoreRatingRating, e.ScoreRatingEntityType, e.ScoreRatingDate });

                entity.ToTable("pms_scoreRating");

                entity.Property(e => e.ScoreRatingRating).HasColumnName("scoreRating_rating");

                entity.Property(e => e.ScoreRatingEntityType).HasColumnName("scoreRating_entityType");

                entity.Property(e => e.ScoreRatingDate)
                    .HasColumnType("datetime")
                    .HasColumnName("scoreRating_date");

                entity.Property(e => e.ScoreRatingCreatedBy).HasColumnName("scoreRating_createdBy");

                entity.Property(e => e.ScoreRatingCreatedWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("scoreRating_createdWhen");

                entity.Property(e => e.ScoreRatingModifyBy).HasColumnName("scoreRating_modifyBy");

                entity.Property(e => e.ScoreRatingModifyWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("scoreRating_modifyWhen");

                entity.Property(e => e.ScoreRatingScore)
                    .HasColumnType("numeric(18, 6)")
                    .HasColumnName("scoreRating_score");

                entity.Property(e => e.ScoreRatingSubProduct).HasColumnName("scoreRating_subProduct");
            });

            modelBuilder.Entity<PmsScripInOutDef>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pms_scripInOutDef");

                entity.Property(e => e.PorfoliGrpWiseLmtCode).HasColumnName("porfoliGrpWiseLmt_code");

                entity.Property(e => e.ScripInOutDefInFundFlag)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("scripInOutDef_InFundFlag");

                entity.Property(e => e.ScripInOutDefOutFundFlag)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("scripInOutDef_outFundFlag");

                entity.Property(e => e.TradinstCode).HasColumnName("tradinst_code");

                entity.Property(e => e.TradinstTypeCode).HasColumnName("tradinstType_code");
            });

            modelBuilder.Entity<PmsScriptExecutor>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pms_scriptExecutor");

                entity.Property(e => e.ScrpExecComments)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("scrpExec_comments");

                entity.Property(e => e.ScrpExecCreatedBy).HasColumnName("scrpExec_createdBy");

                entity.Property(e => e.ScrpExecCreatedWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("scrpExec_createdWhen");

                entity.Property(e => e.ScrpExecCurrentScriptNo).HasColumnName("scrpExec_currentScriptNo");

                entity.Property(e => e.ScrpExecLastScripNo).HasColumnName("scrpExec_LastScripNo");

                entity.Property(e => e.ScrpExecSno).HasColumnName("scrpExec_Sno");

                entity.Property(e => e.ScrpExecType).HasColumnName("scrpExec_Type");
            });

            modelBuilder.Entity<PmsScriptIndex>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pms_scriptIndex");

                entity.Property(e => e.IndexCode).HasColumnName("index_code");

                entity.Property(e => e.ScrptIndexDate)
                    .HasColumnType("datetime")
                    .HasColumnName("scrptIndex_date");

                entity.Property(e => e.ScrptIndexModifiedBy).HasColumnName("scrptIndex_modifiedBy");

                entity.Property(e => e.ScrptIndexModifiedWhen)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("scrptIndex_modifiedWhen");

                entity.Property(e => e.ScrptIndexStatus).HasColumnName("scrptIndex_status");

                entity.Property(e => e.TradInstCode).HasColumnName("tradInst_code");

                entity.Property(e => e.TradInstTypeCode).HasColumnName("tradInstType_code");
            });

            modelBuilder.Entity<PmsScriptIndicator>(entity =>
            {
                entity.HasKey(e => new { e.IndicatorCode, e.TradInstCode, e.TradInstTypeCode, e.ScrptIndDate });

                entity.ToTable("pms_scriptIndicator");

                entity.Property(e => e.IndicatorCode).HasColumnName("indicator_code");

                entity.Property(e => e.TradInstCode).HasColumnName("tradInst_code");

                entity.Property(e => e.TradInstTypeCode).HasColumnName("tradInstType_code");

                entity.Property(e => e.ScrptIndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("scrptInd_date");

                entity.Property(e => e.ScrptIndCreatedBy).HasColumnName("scrptInd_createdBy");

                entity.Property(e => e.ScrptIndCreatedWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("scrptInd_createdWhen");

                entity.Property(e => e.ScrptIndModifiedBy).HasColumnName("scrptInd_modifiedBy");

                entity.Property(e => e.ScrptIndModifiedWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("scrptInd_modifiedWhen");

                entity.Property(e => e.ScrptIndStatus).HasColumnName("scrptInd_status");
            });

            modelBuilder.Entity<PmsSector>(entity =>
            {
                entity.HasKey(e => e.SectorCode)
                    .HasName("PK__pms_sectors__46486B8E");

                entity.ToTable("pms_sectors");

                entity.HasIndex(e => e.SectorName, "IX_pms_sectors")
                    .IsUnique();

                entity.Property(e => e.SectorCode)
                    .ValueGeneratedNever()
                    .HasColumnName("sector_code");

                entity.Property(e => e.SectorCreatedBy).HasColumnName("Sector_CreatedBy");

                entity.Property(e => e.SectorCreatedWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("Sector_CreatedWhen");

                entity.Property(e => e.SectorDesc)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("sector_desc");

                entity.Property(e => e.SectorIndexSe).HasColumnName("sector_indexSE");

                entity.Property(e => e.SectorMnemonic)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("sector_mnemonic");

                entity.Property(e => e.SectorModifiedBy).HasColumnName("Sector_ModifiedBy");

                entity.Property(e => e.SectorModifiedWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("Sector_ModifiedWhen");

                entity.Property(e => e.SectorName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("sector_name");
            });

            modelBuilder.Entity<PmsSectorExposure>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pms_sectorExposure");

                entity.Property(e => e.AllocPijiclAsf)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("AllocPIJICL_ASF");

                entity.Property(e => e.AllocPijiclHft)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("AllocPIJICL_HFT");

                entity.Property(e => e.FundCapital)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("fundCapital");

                entity.Property(e => e.FundMasterName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("fundMaster_name");

                entity.Property(e => e.FundName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("fund_name");

                entity.Property(e => e.FundTotInvest)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("fundTotInvest");

                entity.Property(e => e.LimitStatus)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LimitUtiliz)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("limitUtiliz");

                entity.Property(e => e.PijiclAsfinvest)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("PIJICL_ASFInvest");

                entity.Property(e => e.PijiclHftinvest)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("PIJICL_HFTInvest");

                entity.Property(e => e.SectorCode).HasColumnName("sector_code");

                entity.Property(e => e.SectorExpCreatedBy).HasColumnName("sector_expCreatedBy");

                entity.Property(e => e.SectorExpCreatedWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("sector_expCreatedWhen");

                entity.Property(e => e.SectorExpDate)
                    .HasColumnType("datetime")
                    .HasColumnName("sector_expDate");

                entity.Property(e => e.SectorExpModifiedBy)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("sector_expModifiedBy");

                entity.Property(e => e.SectorExpModifiedWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("sector_expModifiedWhen");

                entity.Property(e => e.SectorName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("sector_name");

                entity.Property(e => e.ShareSold)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("shareSold");
            });

            modelBuilder.Entity<PmsSecurityDetail>(entity =>
            {
                entity.HasKey(e => new { e.SecurityDetailSno, e.TradinstTypeCode, e.TradInstCode });

                entity.ToTable("pms_securityDetail");

                entity.Property(e => e.SecurityDetailSno).HasColumnName("securityDetail_sno");

                entity.Property(e => e.TradinstTypeCode).HasColumnName("tradinstType_code");

                entity.Property(e => e.TradInstCode).HasColumnName("tradInst_code");

                entity.Property(e => e.SecurityDetailAccrualBasis).HasColumnName("securityDetail_accrualBasis");

                entity.Property(e => e.SecurityDetailCreatedBy).HasColumnName("securityDetail_createdBy");

                entity.Property(e => e.SecurityDetailCreatedWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("securityDetail_createdWhen");

                entity.Property(e => e.SecurityDetailEffDate)
                    .HasColumnType("datetime")
                    .HasColumnName("securityDetail_effDate");

                entity.Property(e => e.SecurityDetailModifiedBy).HasColumnName("securityDetail_modifiedBy");

                entity.Property(e => e.SecurityDetailModifiedWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("securityDetail_modifiedWhen");
            });

            modelBuilder.Entity<PmsSecurityDmprice>(entity =>
            {
                entity.HasKey(e => new { e.DmpDate, e.TradInstTypeCode, e.TradInstCode })
                    .HasName("PK__pms_securityDMPr__25518C17");

                entity.ToTable("pms_securityDMPrice");

                entity.Property(e => e.DmpDate)
                    .HasColumnType("datetime")
                    .HasColumnName("DMP_date");

                entity.Property(e => e.TradInstTypeCode).HasColumnName("tradInstType_code");

                entity.Property(e => e.TradInstCode).HasColumnName("tradInst_code");

                entity.Property(e => e.BpsPrice)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("bps_price");

                entity.Property(e => e.DmpDuration)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("DMP_Duration");

                entity.Property(e => e.DmpHigh)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("DMP_high");

                entity.Property(e => e.DmpIndex)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("DMP_index");

                entity.Property(e => e.DmpKmi30Index)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("DMP_Kmi30Index");

                entity.Property(e => e.DmpKse100Index)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("DMP_Kse100Index");

                entity.Property(e => e.DmpLow)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("DMP_low");

                entity.Property(e => e.DmpMarket).HasColumnName("DMP_market");

                entity.Property(e => e.DmpPrevious)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("DMP_previous");

                entity.Property(e => e.DmpPrice)
                    .HasColumnType("decimal(25, 10)")
                    .HasColumnName("DMP_price");

                entity.Property(e => e.DmpProvisioning)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DMP_Provisioning");

                entity.Property(e => e.DmpProvisioningPrice)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("DMP_ProvisioningPrice");

                entity.Property(e => e.DmpScripType).HasColumnName("DMP_ScripType");

                entity.Property(e => e.DmpSecName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("DMP_secName");

                entity.Property(e => e.DmpState).HasColumnName("DMP_state");

                entity.Property(e => e.DmpTrade)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DMP_Trade");

                entity.Property(e => e.DmpTradedPrice)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("DMP_TradedPrice");

                entity.Property(e => e.DmpValuation)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("DMP_valuation");

                entity.Property(e => e.DmpVolume)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("DMP_volume");

                entity.Property(e => e.ModDuration)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("mod_duration");

                entity.Property(e => e.PkrvDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Pkrv_date");

                entity.HasOne(d => d.TradInstTypeCodeNavigation)
                    .WithMany(p => p.PmsSecurityDmprices)
                    .HasForeignKey(d => d.TradInstTypeCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__pms_secur__tradI__2645B050");
            });

            modelBuilder.Entity<PmsSecurityRelease>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pms_securityRelease");

                entity.Property(e => e.FInstTranCode)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("fInstTran_code");

                entity.Property(e => e.FInstTranType).HasColumnName("fInstTran_type");

                entity.Property(e => e.InstCode).HasColumnName("Inst_code");

                entity.Property(e => e.InstTypeCode).HasColumnName("InstType_code");

                entity.Property(e => e.RelCode).HasColumnName("rel_code");

                entity.Property(e => e.RelDate)
                    .HasColumnType("datetime")
                    .HasColumnName("rel_date");

                entity.Property(e => e.RelModifiedBy)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("rel_modifiedBy");

                entity.Property(e => e.RelModifiedWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("rel_modifiedWhen");

                entity.Property(e => e.RelQuantity)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("rel_quantity");

                entity.Property(e => e.UndSecCode)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("undSec_code");
            });

            modelBuilder.Entity<PmsSecurityRtprice>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pms_securityRTPrice");

                entity.Property(e => e.DmpLowRate)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("DMP_lowRate");

                entity.Property(e => e.RtCurrentRate)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("RT_currentRate");

                entity.Property(e => e.RtDate)
                    .HasColumnType("datetime")
                    .HasColumnName("RT_Date");

                entity.Property(e => e.RtHighRate)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("RT_highRate");

                entity.Property(e => e.RtIndexPoint)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("RT_indexPoint");

                entity.Property(e => e.RtIndexWtage)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("RT_indexWtage");

                entity.Property(e => e.RtMktCapital)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("RT_mktCapital");

                entity.Property(e => e.RtMrkStats)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RT_MrkStats");

                entity.Property(e => e.RtNoOfShare)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("RT_noOfShare");

                entity.Property(e => e.RtOpenRate)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("RT_openRate");

                entity.Property(e => e.RtPercntChange)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("RT_percntChange");

                entity.Property(e => e.RtPriceChange)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("RT_priceChange");

                entity.Property(e => e.RtSecName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("RT_secName");

                entity.Property(e => e.RtSno).HasColumnName("RT_Sno");

                entity.Property(e => e.RtVolume)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("RT_volume");
            });

            modelBuilder.Entity<PmsSecurityValuation>(entity =>
            {
                entity.HasKey(e => new { e.ValDate, e.TradInstTypeCode, e.TradInstCode, e.FundCode });

                entity.ToTable("pms_securityValuation");

                entity.Property(e => e.ValDate)
                    .HasColumnType("datetime")
                    .HasColumnName("val_date");

                entity.Property(e => e.TradInstTypeCode).HasColumnName("tradInstType_code");

                entity.Property(e => e.TradInstCode).HasColumnName("tradInst_code");

                entity.Property(e => e.FundCode).HasColumnName("fund_code");

                entity.Property(e => e.ValDescription)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("val_description");

                entity.Property(e => e.ValHolding)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("val_holding");

                entity.Property(e => e.ValPrice)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("val_price");

                entity.Property(e => e.ValValuation)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("val_valuation");
            });

            modelBuilder.Entity<PmsSetLendMargin>(entity =>
            {
                entity.HasKey(e => new { e.LenMarCode, e.LenMarTranType, e.FInstTypeCode, e.FInstCode, e.FundCode });

                entity.ToTable("pms_setLendMargins");

                entity.Property(e => e.LenMarCode).HasColumnName("lenMar_code");

                entity.Property(e => e.LenMarTranType).HasColumnName("lenMar_tranType");

                entity.Property(e => e.FInstTypeCode).HasColumnName("fInstType_code");

                entity.Property(e => e.FInstCode).HasColumnName("fInst_code");

                entity.Property(e => e.FundCode).HasColumnName("fund_code");

                entity.Property(e => e.FundMasterCode).HasColumnName("FundMaster_code");

                entity.Property(e => e.LenMarAmount)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("lenMar_amount");

                entity.Property(e => e.LenMarCancelDate)
                    .HasColumnType("datetime")
                    .HasColumnName("lenMar_cancelDate");

                entity.Property(e => e.LenMarCancelState).HasColumnName("lenMar_cancelState");

                entity.Property(e => e.LenMarDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("lenMar_description");

                entity.Property(e => e.LenMarEntityType).HasColumnName("lenMar_entityType");

                entity.Property(e => e.LenMarPercent)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("lenMar_percent");

                entity.Property(e => e.LenMarValidityDate)
                    .HasColumnType("datetime")
                    .HasColumnName("lenMar_validityDate");

                entity.Property(e => e.LenmarIssueDate)
                    .HasColumnType("datetime")
                    .HasColumnName("lenmar_issueDate");
            });

            modelBuilder.Entity<PmsSettBankInvMov>(entity =>
            {
                entity.HasKey(e => new { e.SettBnkCode, e.SettBnkDate, e.OrdExecDealTickNo });

                entity.ToTable("pms_settBankInvMov");

                entity.Property(e => e.SettBnkCode).HasColumnName("settBnk_code");

                entity.Property(e => e.SettBnkDate)
                    .HasColumnType("datetime")
                    .HasColumnName("settBnk_date");

                entity.Property(e => e.OrdExecDealTickNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ordExec_dealTickNo");

                entity.Property(e => e.FundCode).HasColumnName("fund_code");

                entity.Property(e => e.OrderMode).HasColumnName("order_mode");

                entity.Property(e => e.ProductCode).HasColumnName("product_code");

                entity.Property(e => e.SettBnkAmount)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("settBnk_amount");

                entity.Property(e => e.SettBnkCreatedBy).HasColumnName("settBnk_createdBy");

                entity.Property(e => e.SettBnkCreatedWhen)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("settBnk_createdWhen");

                entity.Property(e => e.SettBnkCurrBank).HasColumnName("settBnk_currBank");

                entity.Property(e => e.SettBnkModifiedBy).HasColumnName("settBnk_modifiedBy");

                entity.Property(e => e.SettBnkModifiedWhen)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("settBnk_modifiedWhen");

                entity.Property(e => e.SettBnkOldBank).HasColumnName("settBnk_oldBank");

                entity.Property(e => e.SettBnkOrdInvMov).HasColumnName("settBnk_ordInvMov");

                entity.Property(e => e.SettBnkPurDealTickNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("settBnk_purDealTickNo");

                entity.Property(e => e.SettBnkQuantity)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("settBnk_quantity");

                entity.Property(e => e.SettBnkTimeStamp)
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("settBnk_timeStamp");

                entity.Property(e => e.TradInstCode).HasColumnName("tradInst_code");

                entity.Property(e => e.TradInstTypeCode).HasColumnName("tradInstType_code");
            });

            modelBuilder.Entity<PmsSettCal>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pms_settCal");

                entity.Property(e => e.CalPeriodCode).HasColumnName("calPeriod_code");

                entity.Property(e => e.CalYearCode).HasColumnName("calYear_code");

                entity.Property(e => e.MarketCode).HasColumnName("market_code");

                entity.Property(e => e.SettCalDesc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("settCal_Desc");

                entity.Property(e => e.SettCalSettDate)
                    .HasColumnType("datetime")
                    .HasColumnName("settCal_SettDate");

                entity.Property(e => e.SettModeCode).HasColumnName("settMode_code");

                entity.Property(e => e.TradeDate)
                    .HasColumnType("datetime")
                    .HasColumnName("trade_Date");
            });

            modelBuilder.Entity<PmsSettlementDate>(entity =>
            {
                entity.HasKey(e => new { e.SettDateCode, e.SettDateType })
                    .HasName("PK__pms_settlementDa__2EDAF651");

                entity.ToTable("pms_settlementDates");

                entity.Property(e => e.SettDateCode)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("settDate_code");

                entity.Property(e => e.SettDateType).HasColumnName("settDate_type");

                entity.Property(e => e.CalPeriodCode).HasColumnName("calPeriod_code");

                entity.Property(e => e.CalYearCode).HasColumnName("calYear_code");

                entity.Property(e => e.FInstTranCode)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("fInstTran_code");

                entity.Property(e => e.FInstTranType).HasColumnName("fInstTran_type");

                entity.Property(e => e.OrdExecCode)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("ordExec_code");

                entity.Property(e => e.OrderCode)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("order_code");

                entity.Property(e => e.SettDateAccruedInterest)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("settDate_AccruedInterest");

                entity.Property(e => e.SettDateAmount)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("settDate_amount");

                entity.Property(e => e.SettDateBrkOtherCharges)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("settDate_BrkOtherCharges");

                entity.Property(e => e.SettDateBrokerCommission)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("settDate_BrokerCommission");

                entity.Property(e => e.SettDateCdccharges)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("settDate_CDCCharges");

                entity.Property(e => e.SettDateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("settDate_date");

                entity.Property(e => e.SettDateFedtax)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("settDate_FEDTax");

                entity.Property(e => e.SettDateFpramount)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("settDate_FPRAmount");

                entity.Property(e => e.SettDateFprratio)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("settDate_FPRRatio");

                entity.Property(e => e.SettDateMtsreleaseAmt)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("settDate_MTSReleaseAmt");

                entity.Property(e => e.SettDateNetAmount)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("settDate_netAmount");

                entity.Property(e => e.SettDateQuantity)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("settDate_quantity");

                entity.Property(e => e.SettDateRate)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("settDate_rate");

                entity.Property(e => e.SettDateState).HasColumnName("settDate_state");

                entity.Property(e => e.SettDateStatus).HasColumnName("settDate_status");

                entity.Property(e => e.SettDateWhtaxBcom)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("settDate_WHTaxBCom");

                entity.Property(e => e.SettdateWhtaxmode).HasColumnName("SETTDATE_WHTAXMODE");

                entity.Property(e => e.SettdateWhtaxtrade)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("SETTDATE_WHTAXTRADE");

                entity.Property(e => e.TaxTypeCode).HasColumnName("TaxType_code");

                entity.Property(e => e.TradInstCode).HasColumnName("tradInst_code");

                entity.Property(e => e.TradInstTypeCode).HasColumnName("tradInstType_code");

                entity.HasOne(d => d.Cal)
                    .WithMany(p => p.PmsSettlementDates)
                    .HasForeignKey(d => new { d.CalYearCode, d.CalPeriodCode })
                    .HasConstraintName("FK__pms_settlementDa__40F9A68C");

                entity.HasOne(d => d.PmsOrderExec)
                    .WithMany(p => p.PmsSettlementDates)
                    .HasForeignKey(d => new { d.OrdExecCode, d.OrderCode, d.TradInstTypeCode, d.TradInstCode })
                    .HasConstraintName("FK__pms_settlementDa__41EDCAC5");
            });

            modelBuilder.Entity<PmsSettlementMode>(entity =>
            {
                entity.HasKey(e => e.SettModeCode)
                    .HasName("PK__SettlementModes__78B3EFCA");

                entity.ToTable("pms_settlementModes");

                entity.HasIndex(e => e.SettModeName, "IX_SettlementModes")
                    .IsUnique();

                entity.HasIndex(e => e.SettModeDays, "IX_pms_settlementModes")
                    .IsUnique();

                entity.Property(e => e.SettModeCode)
                    .ValueGeneratedNever()
                    .HasColumnName("settMode_code");

                entity.Property(e => e.SettModeDays).HasColumnName("settMode_days");

                entity.Property(e => e.SettModeDescription)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("settMode_description");

                entity.Property(e => e.SettModeName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("settMode_name");
            });

            modelBuilder.Entity<PmsShare>(entity =>
            {
                entity.HasKey(e => e.ShareCode)
                    .HasName("PK__pms_shares__3D5E1FD2");

                entity.ToTable("pms_shares");

                entity.HasIndex(e => e.ShareName, "IX_pms_shares")
                    .IsUnique();

                entity.Property(e => e.ShareCode)
                    .ValueGeneratedNever()
                    .HasColumnName("share_Code");

                entity.Property(e => e.CalperiodCode).HasColumnName("calperiod_code");

                entity.Property(e => e.CalyearCode).HasColumnName("calyear_code");

                entity.Property(e => e.FundMasterCode).HasColumnName("fundMaster_code");

                entity.Property(e => e.GcompanyCode).HasColumnName("gcompany_code");

                entity.Property(e => e.RiskLimitConfigCode).HasColumnName("RiskLimitConfig_CODE");

                entity.Property(e => e.SectorCode)
                    .HasColumnName("sector_code")
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.ShareAmcfInstCode).HasColumnName("share_AMCfInstCode");

                entity.Property(e => e.ShareBorrowerCode).HasColumnName("share_borrowerCode");

                entity.Property(e => e.ShareCompCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("share_compCode");

                entity.Property(e => e.ShareDelisted)
                    .HasColumnName("share_delisted")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ShareDelistedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("share_delistedDate");

                entity.Property(e => e.ShareDesc)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("share_desc");

                entity.Property(e => e.ShareFaceValue)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("share_faceValue")
                    .HasDefaultValueSql("(10)");

                entity.Property(e => e.ShareFascomCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("share_fascomCode");

                entity.Property(e => e.ShareFundType).HasColumnName("share_FundType");

                entity.Property(e => e.ShareFutEndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("share_futEndDate");

                entity.Property(e => e.ShareFutPcode).HasColumnName("share_futPCode");

                entity.Property(e => e.ShareFutSettDate)
                    .HasColumnType("datetime")
                    .HasColumnName("share_futSettDate");

                entity.Property(e => e.ShareFutStartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("share_futStartDate");

                entity.Property(e => e.ShareFutState).HasColumnName("share_futState");

                entity.Property(e => e.ShareIsCdceligible)
                    .IsRequired()
                    .HasColumnName("share_IsCDCEligible")
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.ShareIsCfseligible).HasColumnName("share_isCFSEligible");

                entity.Property(e => e.ShareIsMerged)
                    .HasColumnName("share_isMerged")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ShareIsMtseligible)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("share_isMTSEligible");

                entity.Property(e => e.ShareListed)
                    .HasColumnName("share_listed")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ShareName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("share_name");

                entity.Property(e => e.ShareNature).HasColumnName("share_Nature");

                entity.Property(e => e.ShareNoOfSharesIssued)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("share_noOfSharesIssued")
                    .HasDefaultValueSql("(10)");

                entity.Property(e => e.SharePaidupCapital)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("share_paidupCapital")
                    .HasDefaultValueSql("(10)");

                entity.Property(e => e.ShareRalsymbol)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("share_RALsymbol");

                entity.Property(e => e.ShareRelatedParty).HasColumnName("share_RelatedParty");

                entity.Property(e => e.ShareSeccode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("share_seccode");

                entity.Property(e => e.ShareSecid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("share_secid");

                entity.Property(e => e.ShareSymbol)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("share_symbol")
                    .HasDefaultValueSql("('A')");

                entity.Property(e => e.ShareTradeInFuture)
                    .IsRequired()
                    .HasColumnName("share_tradeInFuture")
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.ShareTranReporting)
                    .HasColumnName("share_tranReporting")
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.ShareType).HasColumnName("share_type");

                entity.Property(e => e.TradInstTypeCode)
                    .HasColumnName("tradInstType_code")
                    .HasDefaultValueSql("(1)");

                entity.HasOne(d => d.SectorCodeNavigation)
                    .WithMany(p => p.PmsShares)
                    .HasForeignKey(d => d.SectorCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_pms_shares_pms_sectors");
            });

            modelBuilder.Entity<PmsShareFinancing>(entity =>
            {
                entity.HasKey(e => new { e.FundMasterCode, e.TradInstCode, e.TradInstTypeCode, e.FinancingDate });

                entity.ToTable("pms_shareFinancing");

                entity.Property(e => e.FundMasterCode).HasColumnName("fundMaster_code");

                entity.Property(e => e.TradInstCode).HasColumnName("tradInst_code");

                entity.Property(e => e.TradInstTypeCode).HasColumnName("tradInstType_code");

                entity.Property(e => e.FinancingDate)
                    .HasColumnType("datetime")
                    .HasColumnName("financing_date");

                entity.Property(e => e.FinancingAmount)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("financing_amount");

                entity.Property(e => e.FinancingCreatedBy).HasColumnName("financing_createdBy");

                entity.Property(e => e.FinancingCreatedWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("financing_createdWhen");

                entity.Property(e => e.FinancingExpDate)
                    .HasColumnType("datetime")
                    .HasColumnName("financing_expDate");

                entity.Property(e => e.FinancingModifiedBy).HasColumnName("financing_modifiedBy");

                entity.Property(e => e.FinancingModifiedWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("financing_modifiedWhen");

                entity.Property(e => e.FinancingStatus).HasColumnName("financing_status");
            });

            modelBuilder.Entity<PmsSharesAnnouncement>(entity =>
            {
                entity.HasKey(e => new { e.ShareAnnDate, e.ShareCode })
                    .HasName("PK__pms_sharesAnnoun__72C60C4A");

                entity.ToTable("pms_sharesAnnouncement");

                entity.Property(e => e.ShareAnnDate)
                    .HasColumnType("datetime")
                    .HasColumnName("shareAnn_date");

                entity.Property(e => e.ShareCode).HasColumnName("share_Code");

                entity.Property(e => e.ShareAnnActualBonBkCls)
                    .HasColumnType("datetime")
                    .HasColumnName("shareAnn_ActualBonBkCls");

                entity.Property(e => e.ShareAnnActualDvdBkCls)
                    .HasColumnType("datetime")
                    .HasColumnName("shareAnn_ActualDvdBkCls");

                entity.Property(e => e.ShareAnnBonEprCode).HasColumnName("shareAnn_bonEprCode");

                entity.Property(e => e.ShareAnnBonEyrCode).HasColumnName("shareAnn_bonEyrCode");

                entity.Property(e => e.ShareAnnBonNature).HasColumnName("shareAnn_bonNature");

                entity.Property(e => e.ShareAnnBonusRate)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("shareAnn_bonusRate");

                entity.Property(e => e.ShareAnnDateAgm)
                    .HasColumnType("datetime")
                    .HasColumnName("shareAnn_dateAGM");

                entity.Property(e => e.ShareAnnDateBonBkClos)
                    .HasColumnType("datetime")
                    .HasColumnName("shareAnn_dateBonBkClos");

                entity.Property(e => e.ShareAnnDateDivBkClos)
                    .HasColumnType("datetime")
                    .HasColumnName("shareAnn_dateDivBkClos");

                entity.Property(e => e.ShareAnnDateIssue)
                    .HasColumnType("datetime")
                    .HasColumnName("shareAnn_dateIssue");

                entity.Property(e => e.ShareAnnDateRightBkClos)
                    .HasColumnType("datetime")
                    .HasColumnName("shareAnn_dateRightBkClos");

                entity.Property(e => e.ShareAnnDivEprCode).HasColumnName("shareAnn_divEprCode");

                entity.Property(e => e.ShareAnnDivEyrCode).HasColumnName("shareAnn_divEyrCode");

                entity.Property(e => e.ShareAnnDivNature).HasColumnName("shareAnn_divNature");

                entity.Property(e => e.ShareAnnDivRate)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("shareAnn_divRate");

                entity.Property(e => e.ShareAnnNonRightShares).HasColumnName("shareAnn_nonRightShares");

                entity.Property(e => e.ShareAnnPaidupCap)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("shareAnn_paidupCap");

                entity.Property(e => e.ShareAnnQuotRefNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("shareAnn_QuotRefNo");

                entity.Property(e => e.ShareAnnRenunciationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("shareAnn_renunciationDate");

                entity.Property(e => e.ShareAnnRightSubPrice)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("shareAnn_rightSubPrice");

                entity.Property(e => e.ShareAnnRightsRateInAmount)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("shareAnn_rightsRateInAmount");

                entity.Property(e => e.ShareAnnRightsRateInPercent)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("shareAnn_rightsRateInPercent");

                entity.Property(e => e.ShareAnnSplitBonQtyInPercent)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("shareAnn_splitBonQtyInPercent");

                entity.Property(e => e.ShareAnnTaxRate)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("ShareAnn_TaxRate");

                entity.HasOne(d => d.ShareCodeNavigation)
                    .WithMany(p => p.PmsSharesAnnouncements)
                    .HasForeignKey(d => d.ShareCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__pms_share__share__73BA3083");
            });

            modelBuilder.Entity<PmsSignatory>(entity =>
            {
                entity.HasKey(e => new { e.SignatoryCode, e.FundMasterCode, e.TradInstTypeCode });

                entity.ToTable("pms_signatory");

                entity.Property(e => e.SignatoryCode).HasColumnName("signatory_code");

                entity.Property(e => e.FundMasterCode).HasColumnName("fundMaster_code");

                entity.Property(e => e.TradInstTypeCode).HasColumnName("tradInstType_code");

                entity.Property(e => e.SignatoryActive1).HasColumnName("signatory_Active1");

                entity.Property(e => e.SignatoryActive2).HasColumnName("signatory_Active2");

                entity.Property(e => e.SignatoryActive3).HasColumnName("signatory_Active3");

                entity.Property(e => e.SignatoryActive4).HasColumnName("signatory_Active4");

                entity.Property(e => e.SignatoryActive5).HasColumnName("signatory_Active5");

                entity.Property(e => e.SignatoryCreatedBy).HasColumnName("signatory_createdBy");

                entity.Property(e => e.SignatoryCreatedWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("signatory_createdWhen");

                entity.Property(e => e.SignatoryModifiedBy).HasColumnName("signatory_modifiedBy");

                entity.Property(e => e.SignatoryModifiedWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("signatory_modifiedWhen");

                entity.Property(e => e.SignatoryName1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("signatory_name1");

                entity.Property(e => e.SignatoryName2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("signatory_name2");

                entity.Property(e => e.SignatoryName3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("signatory_name3");

                entity.Property(e => e.SignatoryName4)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("signatory_name4");

                entity.Property(e => e.SignatoryName5)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("signatory_name5");

                entity.Property(e => e.SignatoryPhone1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Signatory_phone1");

                entity.Property(e => e.SignatoryPhone2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("signatory_phone2");

                entity.Property(e => e.SignatoryPhone3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("signatory_phone3");

                entity.Property(e => e.SignatoryPhone4)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("signatory_phone4");

                entity.Property(e => e.SignatoryPhone5)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("signatory_phone5");

                entity.Property(e => e.SignatoryPosition1).HasColumnName("signatory_position1");

                entity.Property(e => e.SignatoryPosition2).HasColumnName("signatory_position2");

                entity.Property(e => e.SignatoryPosition3).HasColumnName("signatory_position3");

                entity.Property(e => e.SignatoryPosition4).HasColumnName("signatory_position4");

                entity.Property(e => e.SignatoryPosition5).HasColumnName("signatory_position5");
            });

            modelBuilder.Entity<PmsSiletterNumber>(entity =>
            {
                entity.HasKey(e => new { e.SilSerialNo, e.YearCode, e.FundCode });

                entity.ToTable("pms_SILetterNumber");

                entity.HasIndex(e => e.SilLetterNo, "IX_pms_SILetterNumber")
                    .IsUnique();

                entity.Property(e => e.SilSerialNo)
                    .HasColumnType("decimal(38, 0)")
                    .HasColumnName("SIL_serialNo");

                entity.Property(e => e.YearCode).HasColumnName("year_code");

                entity.Property(e => e.FundCode).HasColumnName("fund_code");

                entity.Property(e => e.BrokerCode).HasColumnName("broker_code");

                entity.Property(e => e.OrderMode).HasColumnName("order_mode");

                entity.Property(e => e.SilDate)
                    .HasColumnType("datetime")
                    .HasColumnName("SIL_Date");

                entity.Property(e => e.SilLetterNo)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SIL_LetterNo");

                entity.Property(e => e.TimeStamp).HasColumnType("datetime");

                entity.Property(e => e.TradInstCode).HasColumnName("tradInst_code");

                entity.Property(e => e.TradInstTypeCode).HasColumnName("tradInstType_code");
            });

            modelBuilder.Entity<PmsTax>(entity =>
            {
                entity.HasKey(e => new { e.TaxCode, e.TaxTypeCode })
                    .HasName("PK_Tax");

                entity.ToTable("pms_Tax");

                entity.Property(e => e.TaxCode).HasColumnName("Tax_code");

                entity.Property(e => e.TaxTypeCode).HasColumnName("TaxType_code");

                entity.Property(e => e.BrokerCode).HasColumnName("Broker_code");

                entity.Property(e => e.EntityCode).HasColumnName("Entity_code");

                entity.Property(e => e.FInstBranchCode).HasColumnName("fInstBranch_code");

                entity.Property(e => e.FInstCode).HasColumnName("fInst_code");

                entity.Property(e => e.FInstTypeCode).HasColumnName("fInstType_code");

                entity.Property(e => e.FundCode).HasColumnName("fund_code");

                entity.Property(e => e.FundMasterCode).HasColumnName("FundMaster_code");

                entity.Property(e => e.OrderMode).HasColumnName("Order_Mode");

                entity.Property(e => e.TaxDateCommence)
                    .HasColumnType("datetime")
                    .HasColumnName("Tax_dateCommence");

                entity.Property(e => e.TaxDateExpiry)
                    .HasColumnType("datetime")
                    .HasColumnName("Tax_dateExpiry");

                entity.Property(e => e.TaxDateModified)
                    .HasColumnType("datetime")
                    .HasColumnName("Tax_dateModified")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TaxInAmount)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("Tax_inAmount");

                entity.Property(e => e.TaxInPercent)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("Tax_inPercent");

                entity.Property(e => e.TaxIsApplicable).HasColumnName("Tax_isApplicable");

                entity.Property(e => e.TradInstTypeCode).HasColumnName("TradInstType_code");
            });

            modelBuilder.Entity<PmsTaxType>(entity =>
            {
                entity.HasKey(e => e.TaxTypeCode)
                    .HasName("PK_Table1");

                entity.ToTable("pms_TaxType");

                entity.Property(e => e.TaxTypeCode)
                    .ValueGeneratedNever()
                    .HasColumnName("TaxType_code");

                entity.Property(e => e.TaxTypeDesc)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("TaxType_desc");

                entity.Property(e => e.TaxTypeMnemonic)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("TaxType_mnemonic");

                entity.Property(e => e.TaxTypeName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TaxType_name");
            });

            modelBuilder.Entity<PmsTbill>(entity =>
            {
                entity.HasKey(e => e.TbillCode)
                    .HasName("PK__pms_TBills__2DE6D218");

                entity.ToTable("pms_TBills");

                entity.HasIndex(e => e.TbillName, "IX_pms_TBills")
                    .IsUnique();

                entity.Property(e => e.TbillCode)
                    .ValueGeneratedNever()
                    .HasColumnName("tbill_code");

                entity.Property(e => e.ProductCode)
                    .HasColumnName("product_code")
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.ShareCode).HasColumnName("share_Code");

                entity.Property(e => e.TbillAcceptAmount)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("tbill_acceptAmount");

                entity.Property(e => e.TbillAcutionprice)
                    .HasColumnType("decimal(25, 8)")
                    .HasColumnName("TBILL_ACUTIONPRICE");

                entity.Property(e => e.TbillAmortMethod).HasColumnName("tbill_amortMethod");

                entity.Property(e => e.TbillAmount)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("tbill_amount");

                entity.Property(e => e.TbillAucDate)
                    .HasColumnType("datetime")
                    .HasColumnName("tbill_aucDate");

                entity.Property(e => e.TbillAucNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tbill_aucNo");

                entity.Property(e => e.TbillAuctionYield)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("tbill_auctionYield");

                entity.Property(e => e.TbillAuthorizedby).HasColumnName("TBILL_AUTHORIZEDBY");

                entity.Property(e => e.TbillAuthorizedwhen)
                    .HasColumnType("datetime")
                    .HasColumnName("TBILL_AUTHORIZEDWHEN");

                entity.Property(e => e.TbillCreatedby).HasColumnName("TBILL_CREATEDBY");

                entity.Property(e => e.TbillCreatedwhen)
                    .HasColumnType("datetime")
                    .HasColumnName("TBILL_CREATEDWHEN");

                entity.Property(e => e.TbillDesc)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("tbill_desc");

                entity.Property(e => e.TbillIsMatured).HasColumnName("tbill_isMatured");

                entity.Property(e => e.TbillIsauthorized).HasColumnName("TBILL_ISAUTHORIZED");

                entity.Property(e => e.TbillIssueDate)
                    .HasColumnType("datetime")
                    .HasColumnName("tbill_issueDate");

                entity.Property(e => e.TbillListed).HasColumnName("tbill_listed");

                entity.Property(e => e.TbillMatfundMaster)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("tbill_matfundMaster");

                entity.Property(e => e.TbillMatpayRealised)
                    .HasColumnType("datetime")
                    .HasColumnName("tbill_matpayRealised");

                entity.Property(e => e.TbillMatsettBank)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("tbill_matsettBank");

                entity.Property(e => e.TbillMaturityDate)
                    .HasColumnType("datetime")
                    .HasColumnName("tbill_maturityDate");

                entity.Property(e => e.TbillMaturityPeriod).HasColumnName("tbill_maturityPeriod");

                entity.Property(e => e.TbillMaturityType).HasColumnName("tbill_maturityType");

                entity.Property(e => e.TbillModifiedby).HasColumnName("TBILL_MODIFIEDBY");

                entity.Property(e => e.TbillModifiedwhen)
                    .HasColumnType("datetime")
                    .HasColumnName("TBILL_MODIFIEDWHEN");

                entity.Property(e => e.TbillName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tbill_name");

                entity.Property(e => e.TbillParticiAmount)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("tbill_particiAmount");

                entity.Property(e => e.TbillReason)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("TBILL_reason");

                entity.Property(e => e.TbillSecCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tbill_SecCode");

                entity.Property(e => e.TbillYears).HasColumnName("tbill_years");

                entity.Property(e => e.TradInstTypeCode).HasColumnName("tradInstType_code");

                entity.HasOne(d => d.PmsUserDefProduct)
                    .WithMany(p => p.PmsTbills)
                    .HasForeignKey(d => new { d.TradInstTypeCode, d.ProductCode })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_pms_TBills_pms_UserDefProducts");
            });

            modelBuilder.Entity<PmsTblTmp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pms_tblTmp");

                entity.Property(e => e.DmpPrice)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("DMP_Price");

                entity.Property(e => e.MovAvgCarryCost)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("movAvg_carryCost");

                entity.Property(e => e.OrderPriceLimit)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("order_priceLimit");

                entity.Property(e => e.OrderQuantity)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("order_quantity");

                entity.Property(e => e.PurchasePrice)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("purchase_price");

                entity.Property(e => e.SalePrice)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("sale_price");

                entity.Property(e => e.ShareCode).HasColumnName("share_code");

                entity.Property(e => e.ShareName)
                    .HasMaxLength(50)
                    .HasColumnName("share_name");

                entity.Property(e => e.TblTmpCode)
                    .HasMaxLength(50)
                    .HasColumnName("tblTmp_code");
            });

            modelBuilder.Entity<PmsTfc>(entity =>
            {
                entity.HasKey(e => e.TfcCode)
                    .HasName("PK__pms_TFCs__503BEA1C");

                entity.ToTable("pms_TFCs");

                entity.HasIndex(e => e.TfcName, "IX_pms_TFCs")
                    .IsUnique();

                entity.HasIndex(e => e.TfcSymbol, "IX_pms_TFCs_1")
                    .IsUnique();

                entity.Property(e => e.TfcCode)
                    .ValueGeneratedNever()
                    .HasColumnName("tfc_Code");

                entity.Property(e => e.FInstCode).HasColumnName("fInst_code");

                entity.Property(e => e.FInstTypeCode).HasColumnName("fInstType_code");

                entity.Property(e => e.ProductCode)
                    .HasColumnName("product_code")
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.RateTemplSlabName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("rateTempl_slabName");

                entity.Property(e => e.RateTemplType).HasColumnName("rateTempl_type");

                entity.Property(e => e.ShareCode).HasColumnName("share_Code");

                entity.Property(e => e.Tfc1stCpnAccrBasis).HasColumnName("tfc_1stCpnAccrBasis");

                entity.Property(e => e.TfcAccrualBasis).HasColumnName("tfc_accrualBasis");

                entity.Property(e => e.TfcAmortBasis).HasColumnName("tfc_amortBasis");

                entity.Property(e => e.TfcAmortMethod).HasColumnName("tfc_amortMethod");

                entity.Property(e => e.TfcAmortStartBasis).HasColumnName("tfc_amortStartBasis");

                entity.Property(e => e.TfcAuthorizedby).HasColumnName("TFC_AUTHORIZEDBY");

                entity.Property(e => e.TfcAuthorizedwhen)
                    .HasColumnType("datetime")
                    .HasColumnName("TFC_AUTHORIZEDWHEN");

                entity.Property(e => e.TfcBaseRate)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("tfc_BaseRate");

                entity.Property(e => e.TfcConvFixedDay)
                    .HasColumnType("datetime")
                    .HasColumnName("tfc_convFixedDay");

                entity.Property(e => e.TfcConvPeriod).HasColumnName("tfc_convPeriod");

                entity.Property(e => e.TfcConversionPrice)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("tfc_conversionPrice");

                entity.Property(e => e.TfcConversionQuantity)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("tfc_conversionQuantity");

                entity.Property(e => e.TfcCouponCapRate)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("tfc_couponCapRate");

                entity.Property(e => e.TfcCouponFloorRate)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("tfc_couponFloorRate");

                entity.Property(e => e.TfcCouponMaxRate)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("tfc_couponMaxRate");

                entity.Property(e => e.TfcCouponMinRate)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("tfc_couponMinRate");

                entity.Property(e => e.TfcCouponRatePerAnnum)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("tfc_couponRatePerAnnum");

                entity.Property(e => e.TfcCouponsQty).HasColumnName("tfc_couponsQty");

                entity.Property(e => e.TfcCreatedby).HasColumnName("TFC_CREATEDBY");

                entity.Property(e => e.TfcCreatedwhen)
                    .HasColumnType("datetime")
                    .HasColumnName("TFC_CREATEDWHEN");

                entity.Property(e => e.TfcCreditRating)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("tfc_creditRating");

                entity.Property(e => e.TfcDesc)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("tfc_desc");

                entity.Property(e => e.TfcFaceValue)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("tfc_faceValue");

                entity.Property(e => e.TfcIsConvertible).HasColumnName("tfc_IsConvertible");

                entity.Property(e => e.TfcIsauthorized).HasColumnName("TFC_ISAUTHORIZED");

                entity.Property(e => e.TfcIsino)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tfc_ISINO");

                entity.Property(e => e.TfcIssuance).HasColumnName("tfc_issuance");

                entity.Property(e => e.TfcIssueDate)
                    .HasColumnType("datetime")
                    .HasColumnName("tfc_issueDate");

                entity.Property(e => e.TfcIssuerName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tfc_issuerName");

                entity.Property(e => e.TfcListed).HasColumnName("tfc_listed");

                entity.Property(e => e.TfcMaturityDate)
                    .HasColumnType("datetime")
                    .HasColumnName("tfc_maturityDate");

                entity.Property(e => e.TfcModifiedby).HasColumnName("TFC_MODIFIEDBY");

                entity.Property(e => e.TfcModifiedwhen)
                    .HasColumnType("datetime")
                    .HasColumnName("TFC_MODIFIEDWHEN");

                entity.Property(e => e.TfcName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tfc_name");

                entity.Property(e => e.TfcNature).HasColumnName("tfc_Nature");

                entity.Property(e => e.TfcRatesDay).HasColumnName("tfc_RatesDay");

                entity.Property(e => e.TfcReason)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("TFC_reason");

                entity.Property(e => e.TfcRedemptionTenor).HasColumnName("tfc_redemptionTenor");

                entity.Property(e => e.TfcRedemptionType).HasColumnName("tfc_redemptionType");

                entity.Property(e => e.TfcSettThrough).HasColumnName("tfc_SettThrough");

                entity.Property(e => e.TfcSize)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("tfc_Size")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.TfcSymbol)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tfc_symbol");

                entity.Property(e => e.TfcYears).HasColumnName("tfc_years");

                entity.Property(e => e.TradInstTypeCode).HasColumnName("tradInstType_code");

                entity.HasOne(d => d.ShareCodeNavigation)
                    .WithMany(p => p.PmsTfcs)
                    .HasForeignKey(d => d.ShareCode)
                    .HasConstraintName("FK__pms_TFCs__share___55009F39");

                entity.HasOne(d => d.TradInstTypeCodeNavigation)
                    .WithMany(p => p.PmsTfcs)
                    .HasForeignKey(d => d.TradInstTypeCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__pms_TFCs__tradIn__55F4C372");

                entity.HasOne(d => d.PmsUserDefProduct)
                    .WithMany(p => p.PmsTfcs)
                    .HasForeignKey(d => new { d.TradInstTypeCode, d.ProductCode })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_pms_TFCs_pms_UserDefProducts");
            });

            modelBuilder.Entity<PmsTrDealerLimit>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pms_TrDealerLimit");

                entity.Property(e => e.DealerLimitCombination).HasColumnName("dealerLimit_combination");

                entity.Property(e => e.DealerLimitType)
                    .HasColumnName("dealerLimit_type")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UdlAmount)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("UDL_amount");

                entity.Property(e => e.UdlCreatedBy).HasColumnName("UDL_createdBy");

                entity.Property(e => e.UdlCreatedWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("UDL_createdWhen");

                entity.Property(e => e.UdlExpDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UDL_expDate");

                entity.Property(e => e.UdlIsActive).HasColumnName("UDL_isActive");

                entity.Property(e => e.UdlIssueDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UDL_issueDate");

                entity.Property(e => e.UdlModifiedBy).HasColumnName("UDL_modifiedBy");

                entity.Property(e => e.UdlModifiedWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("UDL_modifiedWhen");

                entity.Property(e => e.UdlSno).HasColumnName("UDL_sno");

                entity.Property(e => e.UdlUserLevel).HasColumnName("UDL_userLevel");

                entity.Property(e => e.UserCode).HasColumnName("user_code");
            });

            modelBuilder.Entity<PmsTrDealerLimitConfig>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pms_TrDealerLimitConfig");

                entity.Property(e => e.DealerLimitCombination).HasColumnName("dealerLimit_combination");

                entity.Property(e => e.DealerLimitEnd).HasColumnName("dealerLimit_end");

                entity.Property(e => e.DealerLimitIsDayMonYear).HasColumnName("dealerLimit_isDayMonYear");

                entity.Property(e => e.DealerLimitSno).HasColumnName("dealerLimit_sno");

                entity.Property(e => e.DealerLimitStart).HasColumnName("dealerLimit_start");

                entity.Property(e => e.DelearLimtDescription)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("delearLimt_description");

                entity.Property(e => e.FinstTranMode).HasColumnName("finstTran_mode");

                entity.Property(e => e.ModuleType).HasColumnName("module_type");

                entity.Property(e => e.ProductCode).HasColumnName("product_code");

                entity.Property(e => e.TradinstTypeCode).HasColumnName("tradinstType_code");
            });

            modelBuilder.Entity<PmsTradingInstrumentType>(entity =>
            {
                entity.HasKey(e => e.TradInstTypeCode)
                    .HasName("PK__pms_tradingInstr__4A18FC72");

                entity.ToTable("pms_tradingInstrumentTypes");

                entity.HasIndex(e => e.TradInstTypeName, "IX_pms_tradingInstrumentTypes")
                    .IsUnique();

                entity.Property(e => e.TradInstTypeCode)
                    .ValueGeneratedNever()
                    .HasColumnName("tradInstType_code");

                entity.Property(e => e.TradInstTypeCostCenter)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("tradInstType_costCenter");

                entity.Property(e => e.TradInstTypeDesc)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("tradInstType_desc");

                entity.Property(e => e.TradInstTypeForPkrv).HasColumnName("tradInstType_forPKRV");

                entity.Property(e => e.TradInstTypeName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tradInstType_name");
            });

            modelBuilder.Entity<PmsTranDetail>(entity =>
            {
                entity.HasKey(e => new { e.TranDetailCode, e.TranMasterCode, e.TranMasterType })
                    .HasName("PK__pms_tranDetail__22FF2F51");

                entity.ToTable("pms_tranDetail");

                entity.Property(e => e.TranDetailCode)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("tranDetail_code");

                entity.Property(e => e.TranMasterCode)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("tranMaster_code");

                entity.Property(e => e.TranMasterType).HasColumnName("tranMaster_Type");

                entity.Property(e => e.FInstBranchCode).HasColumnName("fInstBranch_code");

                entity.Property(e => e.FundCode).HasColumnName("fund_code");

                entity.Property(e => e.TranDetailAmount)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("tranDetail_amount");

                entity.Property(e => e.TranDetailCarryingPrice)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("tranDetail_CarryingPrice");

                entity.Property(e => e.TranDetailDate)
                    .HasColumnType("datetime")
                    .HasColumnName("tranDetail_date");

                entity.Property(e => e.TranDetailPrice)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("tranDetail_Price");

                entity.Property(e => e.TranDetailQuantity)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("tranDetail_quantity");

                entity.Property(e => e.TranDetailState).HasColumnName("tranDetail_State");

                entity.Property(e => e.TranDetailTranQuantity)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("tranDetail_tranQuantity");

                entity.Property(e => e.TranDetailType).HasColumnName("tranDetail_type");

                entity.Property(e => e.TranMasterDelProcDate)
                    .HasColumnType("datetime")
                    .HasColumnName("tranMaster_delProcDate");

                entity.Property(e => e.TranMasterEntProcDate)
                    .HasColumnType("datetime")
                    .HasColumnName("tranMaster_entProcDate");

                entity.HasOne(d => d.TranMaster)
                    .WithMany(p => p.PmsTranDetails)
                    .HasForeignKey(d => new { d.TranMasterCode, d.TranMasterType })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__pms_tranDetail__26CFC035");
            });

            modelBuilder.Entity<PmsTranMaster>(entity =>
            {
                entity.HasKey(e => new { e.TranMasterCode, e.TranMasterType })
                    .HasName("PK__pms_tranMaster__3429BB53");

                entity.ToTable("pms_tranMaster");

                entity.Property(e => e.TranMasterCode)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("tranMaster_code");

                entity.Property(e => e.TranMasterType).HasColumnName("tranMaster_Type");

                entity.Property(e => e.CalPeriodCode).HasColumnName("calPeriod_code");

                entity.Property(e => e.CalYearCode).HasColumnName("calYear_code");

                entity.Property(e => e.CouponCode).HasColumnName("coupon_code");

                entity.Property(e => e.CpoptionCode).HasColumnName("CPoption_code");

                entity.Property(e => e.CpoptionType).HasColumnName("CPoption_type");

                entity.Property(e => e.FInstTranCode)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("fInstTran_code");

                entity.Property(e => e.FInstTranType).HasColumnName("fInstTran_type");

                entity.Property(e => e.OrdExecCode)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("ordExec_code");

                entity.Property(e => e.OrderCode)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("order_code");

                entity.Property(e => e.SettDateCode)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("settDate_code");

                entity.Property(e => e.SettDateType).HasColumnName("settDate_type");

                entity.Property(e => e.ShareAnnDate)
                    .HasColumnType("datetime")
                    .HasColumnName("shareAnn_date");

                entity.Property(e => e.TradInstCode).HasColumnName("tradInst_code");

                entity.Property(e => e.TradInstTypeCode).HasColumnName("tradInstType_code");

                entity.Property(e => e.TranMasterAnnProcState).HasColumnName("tranMaster_annProcState");

                entity.Property(e => e.TranMasterDate)
                    .HasColumnType("datetime")
                    .HasColumnName("tranMaster_date");

                entity.Property(e => e.TranMasterDelProcDate)
                    .HasColumnType("datetime")
                    .HasColumnName("tranMaster_delProcDate");

                entity.Property(e => e.TranMasterEntProcDate)
                    .HasColumnType("datetime")
                    .HasColumnName("tranMaster_entProcDate");

                entity.Property(e => e.TranMasterRemark)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("tranMaster_Remark");

                entity.Property(e => e.TranMasterRolloverDate)
                    .HasColumnType("datetime")
                    .HasColumnName("tranMaster_rolloverDate");

                entity.Property(e => e.TranMasterState).HasColumnName("tranMaster_state");

                entity.Property(e => e.UserId).HasColumnName("User_ID");

                entity.HasOne(d => d.Cal)
                    .WithMany(p => p.PmsTranMasters)
                    .HasForeignKey(d => new { d.CalYearCode, d.CalPeriodCode })
                    .HasConstraintName("FK__pms_tranMaster__370627FE");

                entity.HasOne(d => d.SettDate)
                    .WithMany(p => p.PmsTranMasters)
                    .HasForeignKey(d => new { d.SettDateCode, d.SettDateType })
                    .HasConstraintName("FK__pms_tranMaster__37FA4C37");
            });

            modelBuilder.Entity<PmsTranTrustee>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pms_tranTrustee");

                entity.Property(e => e.DtschemaType).HasColumnName("DTSchema_Type");

                entity.Property(e => e.FInstTranRefNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fInstTran_RefNo");

                entity.Property(e => e.FundCode).HasColumnName("fund_code");

                entity.Property(e => e.FundMasterCode).HasColumnName("fundMaster_code");

                entity.Property(e => e.TranTrusteeCreatedBy).HasColumnName("tranTrustee_createdBy");

                entity.Property(e => e.TranTrusteeCreatedWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("tranTrustee_createdWhen");

                entity.Property(e => e.TranTrusteeSno).HasColumnName("tranTrustee_SNo");

                entity.Property(e => e.TrusteeCode).HasColumnName("trustee_code");
            });

            modelBuilder.Entity<PmsTreasuryExpConfig>(entity =>
            {
                entity.HasKey(e => new { e.TreasuryExpSno, e.TreasuryExpProduct, e.TreasuryExpMode });

                entity.ToTable("pms_TreasuryExpConfig");

                entity.Property(e => e.TreasuryExpSno).HasColumnName("treasuryExp_Sno");

                entity.Property(e => e.TreasuryExpProduct).HasColumnName("treasuryExp_Product");

                entity.Property(e => e.TreasuryExpMode).HasColumnName("treasuryExp_Mode");

                entity.Property(e => e.SubProductCode).HasColumnName("subProduct_code");

                entity.Property(e => e.TradInstTypeCode).HasColumnName("tradInstType_code");

                entity.Property(e => e.TreasuryExpCreatedBy).HasColumnName("treasuryExp_createdBy");

                entity.Property(e => e.TreasuryExpCreatedWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("treasuryExp_createdWhen");

                entity.Property(e => e.TreasuryExpGroupName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("treasuryExp_GroupName");

                entity.Property(e => e.TreasuryExpGroupby)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("treasuryExp_Groupby");

                entity.Property(e => e.TreasuryExpIsActive).HasColumnName("treasuryExp_IsActive");

                entity.Property(e => e.TreasuryExpModifyBy).HasColumnName("treasuryExp_modifyBy");

                entity.Property(e => e.TreasuryExpModifyWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("treasuryExp_modifyWhen");

                entity.Property(e => e.TreasuryExpProductName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("treasuryExp_ProductName");
            });

            modelBuilder.Entity<PmsTreasuryExpLimit>(entity =>
            {
                entity.HasKey(e => new { e.TrExpLimitsCode, e.TreasuryExpSno, e.TreasuryExpProduct, e.TreasuryExpMode, e.FInstBranchCode, e.FundMasterCode, e.TrExpLimitsDate });

                entity.ToTable("pms_treasuryExpLimit");

                entity.Property(e => e.TrExpLimitsCode).HasColumnName("TrExpLimits_code");

                entity.Property(e => e.TreasuryExpSno).HasColumnName("treasuryExp_Sno");

                entity.Property(e => e.TreasuryExpProduct).HasColumnName("treasuryExp_Product");

                entity.Property(e => e.TreasuryExpMode).HasColumnName("treasuryExp_Mode");

                entity.Property(e => e.FInstBranchCode).HasColumnName("fInstBranch_code");

                entity.Property(e => e.FundMasterCode).HasColumnName("fundMaster_code");

                entity.Property(e => e.TrExpLimitsDate)
                    .HasColumnType("datetime")
                    .HasColumnName("TrExpLimits_Date");

                entity.Property(e => e.FInstCode).HasColumnName("fInst_code");

                entity.Property(e => e.SubProductCode).HasColumnName("subProduct_code");

                entity.Property(e => e.TrExpLimitsAlcoDate)
                    .HasColumnType("datetime")
                    .HasColumnName("TrExpLimits_AlcoDate");

                entity.Property(e => e.TrExpLimitsAmountLimit)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("TrExpLimits_AmountLimit");

                entity.Property(e => e.TrExpLimitsAmountPercentage)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("TrExpLimits_AmountPercentage");

                entity.Property(e => e.TrExpLimitsCreatedBy).HasColumnName("TrExpLimits_createdBy");

                entity.Property(e => e.TrExpLimitsCreatedWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("TrExpLimits_createdWhen");

                entity.Property(e => e.TrExpLimitsExpiryDate)
                    .HasColumnType("datetime")
                    .HasColumnName("TrExpLimits_ExpiryDate");

                entity.Property(e => e.TrExpLimitsIsAlco).HasColumnName("TrExpLimits_IsAlco");

                entity.Property(e => e.TrExpLimitsModifyBy).HasColumnName("TrExpLimits_modifyBy");

                entity.Property(e => e.TrExpLimitsModifyWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("TrExpLimits_modifyWhen");

                entity.Property(e => e.TrExpLimitsType).HasColumnName("TrExpLimits_Type");

                entity.Property(e => e.TradInstTypeCode).HasColumnName("tradInstType_code");
            });

            modelBuilder.Entity<PmsTreasuryLimitDetail>(entity =>
            {
                entity.HasKey(e => new { e.TrLimitDetailCode, e.FInstTranCode });

                entity.ToTable("pms_treasuryLimitDetail");

                entity.Property(e => e.TrLimitDetailCode).HasColumnName("trLimitDetail_code");

                entity.Property(e => e.FInstTranCode).HasColumnName("fInstTran_code");

                entity.Property(e => e.FInstTranMode).HasColumnName("fInstTran_mode");

                entity.Property(e => e.FInstTranType).HasColumnName("fInstTran_type");

                entity.Property(e => e.FinstBranchCode).HasColumnName("FInstBranch_code");

                entity.Property(e => e.FinstCode).HasColumnName("FInst_code");

                entity.Property(e => e.FinstTypeCode).HasColumnName("FInstType_code");

                entity.Property(e => e.FundCode).HasColumnName("Fund_code");

                entity.Property(e => e.ProductLimitAmt)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("product_limitAmt");

                entity.Property(e => e.ProductUtilizedLimit)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("productUtilized_limit");

                entity.Property(e => e.TotalUtilizedLimit)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("totalUtilized_limit");

                entity.Property(e => e.TreasuryExpGroupby)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("treasuryExp_Groupby");
            });

            modelBuilder.Entity<PmsTreasurytype>(entity =>
            {
                entity.HasKey(e => new { e.FinsttranType, e.FinsttranMode })
                    .HasName("PKPMS_Treasurytype");

                entity.ToTable("PMS_Treasurytype");

                entity.Property(e => e.FinsttranType).HasColumnName("FINSTTRAN_TYPE");

                entity.Property(e => e.FinsttranMode).HasColumnName("FINSTTRAN_MODE");

                entity.Property(e => e.FinsttranModename)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FINSTTRAN_MODEName");

                entity.Property(e => e.FinsttranTypename)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FINSTTRAN_TYPEName");

                entity.Property(e => e.TreasurytypeCreatedby).HasColumnName("Treasurytype_CREATEDBY");

                entity.Property(e => e.TreasurytypeCreatedwhen)
                    .HasColumnType("datetime")
                    .HasColumnName("Treasurytype_CREATEDWHEN");

                entity.Property(e => e.TreasurytypeModifyby).HasColumnName("Treasurytype_MODIFYBY");

                entity.Property(e => e.TreasurytypeModifywhen)
                    .HasColumnType("datetime")
                    .HasColumnName("Treasurytype_MODIFYWHEN");
            });

            modelBuilder.Entity<PmsTrstBankDetail>(entity =>
            {
                entity.HasKey(e => new { e.FundMasterCode, e.EntityType, e.EntityCode })
                    .HasName("PK_pms_trstBankDetail_1");

                entity.ToTable("pms_trstBankDetail");

                entity.Property(e => e.FundMasterCode).HasColumnName("fundMaster_code");

                entity.Property(e => e.EntityType).HasColumnName("entity_type");

                entity.Property(e => e.EntityCode).HasColumnName("entity_code");

                entity.Property(e => e.BranchAccountNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("branch_Account_No");

                entity.Property(e => e.FInstCode).HasColumnName("fInst_code");

                entity.Property(e => e.FInstTypeCode).HasColumnName("fInstType_code");

                entity.Property(e => e.TrstBankDetailCreatedBy)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("trstBankDetail_createdBy");

                entity.Property(e => e.TrstBankDetailCreatedWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("trstBankDetail_createdWhen");

                entity.Property(e => e.TrstBankDetailEquitycdsAct)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("trstBankDetail_equitycdsAct");

                entity.Property(e => e.TrstBankDetailGovtSecAccount)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("trstBankDetail_govtSecAccount");

                entity.Property(e => e.TrstBankDetailModifyBy)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("trstBankDetail_modifyBy");

                entity.Property(e => e.TrstBankDetailModifyWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("trstBankDetail_modifyWhen");

                entity.Property(e => e.TrstBankDetailTfcCdsAccount)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("trstBankDetail_tfcCdsAccount");
            });

            modelBuilder.Entity<PmsTrstFee>(entity =>
            {
                entity.HasKey(e => new { e.TrstFeeCode, e.TrusteeCode });

                entity.ToTable("pms_trstFee");

                entity.Property(e => e.TrstFeeCode).HasColumnName("trstFee_code");

                entity.Property(e => e.TrusteeCode).HasColumnName("trustee_code");

                entity.Property(e => e.TrstFeeCapPercent)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("trstFee_capPercent");

                entity.Property(e => e.TrstFeeFeeType).HasColumnName("trstFee_feeType");

                entity.Property(e => e.TrstFeeFloorPercent)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("trstFee_floorPercent");

                entity.Property(e => e.TrstFeeHighLow).HasColumnName("trstFee_highLow");

                entity.Property(e => e.TrstFeeIsExceeded).HasColumnName("trstFee_isExceeded");

                entity.Property(e => e.TrstFeeIsHighLow).HasColumnName("trstFee_isHighLow");

                entity.Property(e => e.TrstFeeMax)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("trstFee_max");

                entity.Property(e => e.TrstFeeMin)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("trstFee_min");

                entity.Property(e => e.TrstFeePercent)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("trstFee_percent");

                entity.Property(e => e.TrstFeePlusAmount)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("trstFee_plusAmount");

                entity.HasOne(d => d.TrusteeCodeNavigation)
                    .WithMany(p => p.PmsTrstFees)
                    .HasForeignKey(d => d.TrusteeCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_pms_trstFee_pms_Trustee");
            });

            modelBuilder.Entity<PmsTrustee>(entity =>
            {
                entity.HasKey(e => e.TrusteeCode)
                    .HasName("PK__pms_Trustee__5EBF139D");

                entity.ToTable("pms_Trustee");

                entity.HasIndex(e => e.TrusteeTitle, "IX_pms_Trustee")
                    .IsUnique();

                entity.Property(e => e.TrusteeCode)
                    .ValueGeneratedNever()
                    .HasColumnName("trustee_code");

                entity.Property(e => e.TrusteeAccNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("trustee_accNO");

                entity.Property(e => e.TrusteeAddress)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("trustee_address");

                entity.Property(e => e.TrusteeBank)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("trustee_bank");

                entity.Property(e => e.TrusteeBranch)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("trustee_branch");

                entity.Property(e => e.TrusteeContactPerson)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("trustee_contactPerson");

                entity.Property(e => e.TrusteeFaxes)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("trustee_faxes");

                entity.Property(e => e.TrusteeIsActive).HasColumnName("trustee_isActive");

                entity.Property(e => e.TrusteePhones)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("trustee_phones");

                entity.Property(e => e.TrusteePostCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("trustee_postCode");

                entity.Property(e => e.TrusteeTitle)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("trustee_title");
            });

            modelBuilder.Entity<PmsUnderlyingSec>(entity =>
            {
                entity.HasKey(e => new { e.UndSecCode, e.InstTypeCode, e.InstCode })
                    .HasName("PK__pms_UnderlyingSe__047AA831");

                entity.ToTable("pms_UnderlyingSec");

                entity.Property(e => e.UndSecCode)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("undSec_code");

                entity.Property(e => e.InstTypeCode).HasColumnName("InstType_code");

                entity.Property(e => e.InstCode).HasColumnName("Inst_code");

                entity.Property(e => e.FInstTranCode)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("fInstTran_code");

                entity.Property(e => e.FInstTranType).HasColumnName("fInstTran_type");

                entity.Property(e => e.FundCode).HasColumnName("fund_code");

                entity.Property(e => e.OrdExecCode)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("ordExec_code");

                entity.Property(e => e.OrdExecDealTickNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ordExec_dealTickNo");

                entity.Property(e => e.OrderCode)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("order_code");

                entity.Property(e => e.ProductCode).HasColumnName("product_code");

                entity.Property(e => e.ShareAnnDate)
                    .HasColumnType("datetime")
                    .HasColumnName("shareAnn_date");

                entity.Property(e => e.TradInstCode).HasColumnName("tradInst_code");

                entity.Property(e => e.TradInstTypeCode).HasColumnName("tradInstType_code");

                entity.Property(e => e.UndSecAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("undSec_amount");

                entity.Property(e => e.UndSecBaseRate)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("undSec_baseRate");

                entity.Property(e => e.UndSecDmpdate)
                    .HasColumnType("datetime")
                    .HasColumnName("undSec_DMPdate");

                entity.Property(e => e.UndSecInstType).HasColumnName("undSec_instType");

                entity.Property(e => e.UndSecMarginPercent)
                    .HasColumnType("decimal(25, 0)")
                    .HasColumnName("undSec_marginPercent");

                entity.Property(e => e.UndSecMarketPrice)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("undSec_marketPrice");

                entity.Property(e => e.UndSecPledgedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("undSec_PledgedDate");

                entity.Property(e => e.UndSecQuantity)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("undSec_quantity");

                entity.Property(e => e.UndSecRelQuantity)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("undSec_relQuantity");

                entity.Property(e => e.UndSecReleasedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("undSec_releasedDate");

                entity.Property(e => e.UndSecState).HasColumnName("undSec_state");

                entity.Property(e => e.UndSecUnownedSecurity).HasColumnName("undSec_unownedSecurity");
            });

            modelBuilder.Entity<PmsUnrealisedgainloss>(entity =>
            {
                entity.HasKey(e => new { e.FundmasterCode, e.FundCode, e.TradinsttypeCode, e.TradinstCode, e.UnrealisedglDate, e.UnrealisedglSno, e.UnrealisedglType });

                entity.ToTable("PMS_UNREALISEDGAINLOSS");

                entity.Property(e => e.FundmasterCode).HasColumnName("FUNDMASTER_CODE");

                entity.Property(e => e.FundCode).HasColumnName("FUND_CODE");

                entity.Property(e => e.TradinsttypeCode).HasColumnName("TRADINSTTYPE_CODE");

                entity.Property(e => e.TradinstCode).HasColumnName("TRADINST_CODE");

                entity.Property(e => e.UnrealisedglDate)
                    .HasColumnType("date")
                    .HasColumnName("UNREALISEDGL_DATE");

                entity.Property(e => e.UnrealisedglSno).HasColumnName("UNREALISEDGL_SNO");

                entity.Property(e => e.UnrealisedglType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UNREALISEDGL_TYPE");

                entity.Property(e => e.PsrefPurdealtickno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PSREF_PURDEALTICKNO");

                entity.Property(e => e.PsrefSaldealtickno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PSREF_SALDEALTICKNO");

                entity.Property(e => e.UnrealisedglCreatedby).HasColumnName("UNREALISEDGL_CREATEDBY");

                entity.Property(e => e.UnrealisedglCreatedwhen)
                    .HasColumnType("date")
                    .HasColumnName("UNREALISEDGL_CREATEDWHEN");

                entity.Property(e => e.UnrealisedglNetvalue)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("UNREALISEDGL_NETVALUE");

                entity.Property(e => e.UnrealisedglValue)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UNREALISEDGL_VALUE");
            });

            modelBuilder.Entity<PmsUserDefProduct>(entity =>
            {
                entity.HasKey(e => new { e.TradInstTypeCode, e.ProductCode })
                    .HasName("PK_Table2");

                entity.ToTable("pms_UserDefProducts");

                entity.HasIndex(e => e.ProductName, "IX_pms_UserDefProducts")
                    .IsUnique();

                entity.Property(e => e.TradInstTypeCode).HasColumnName("tradInstType_code");

                entity.Property(e => e.ProductCode).HasColumnName("product_code");

                entity.Property(e => e.IsGovtBond).HasColumnName("isGovtBond");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Modified_date");

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("product_name");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("user_name");
            });

            modelBuilder.Entity<PmsVchrAmountType>(entity =>
            {
                entity.HasKey(e => e.VAmtTypeCode);

                entity.ToTable("pms_vchrAmountTypes");

                entity.Property(e => e.VAmtTypeCode)
                    .ValueGeneratedNever()
                    .HasColumnName("vAmtType_code");

                entity.Property(e => e.VAmtTypeMnemonic)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("vAmtType_mnemonic");

                entity.Property(e => e.VAmtTypeName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("vAmtType_name");
            });

            modelBuilder.Entity<PmsVchrFmtDetail>(entity =>
            {
                entity.HasKey(e => new { e.VfmtDtlCode, e.VfmtMstrSno, e.VfmtMstrFmtCode, e.VfmtMstrCode });

                entity.ToTable("pms_vchrFmtDetail");

                entity.Property(e => e.VfmtDtlCode).HasColumnName("vfmtDtl_code");

                entity.Property(e => e.VfmtMstrSno).HasColumnName("vfmtMstr_sno");

                entity.Property(e => e.VfmtMstrFmtCode).HasColumnName("vfmtMstr_fmtCode");

                entity.Property(e => e.VfmtMstrCode).HasColumnName("vfmtMstr_code");

                entity.Property(e => e.GlHeadAccType).HasColumnName("glHead_accType");

                entity.Property(e => e.GlHeadEntityType).HasColumnName("glHead_entityType");

                entity.Property(e => e.VAmtTypeCode).HasColumnName("vAmtType_code");

                entity.Property(e => e.VfmtDtlAmountType).HasColumnName("vfmtDtl_amountType");

                entity.Property(e => e.VfmtDtlDesc)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("vfmtDtl_desc");

                entity.HasOne(d => d.VAmtTypeCodeNavigation)
                    .WithMany(p => p.PmsVchrFmtDetails)
                    .HasForeignKey(d => d.VAmtTypeCode)
                    .HasConstraintName("FK_pms_vchrFmtDetail_pms_vchrAmountTypes");
            });

            modelBuilder.Entity<PmsVchrFmtMaster>(entity =>
            {
                entity.HasKey(e => new { e.VfmtMstrSno, e.VfmtMstrFmtCode, e.VfmtMstrCode });

                entity.ToTable("pms_vchrFmtMaster");

                entity.Property(e => e.VfmtMstrSno).HasColumnName("vfmtMstr_sno");

                entity.Property(e => e.VfmtMstrFmtCode).HasColumnName("vfmtMstr_fmtCode");

                entity.Property(e => e.VfmtMstrCode).HasColumnName("vfmtMstr_code");

                entity.Property(e => e.FinsttranMode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FINSTTRAN_MODE");

                entity.Property(e => e.OrderOnClearingSys)
                    .HasColumnName("order_onClearingSys")
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.ProductCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("product_code")
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.VfmtMstrColtrlSubType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("vfmtMstr_coltrlSubType");

                entity.Property(e => e.VfmtMstrColtrlType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("vfmtMstr_coltrlType");

                entity.Property(e => e.VfmtMstrDateBasis).HasColumnName("vfmtMstr_dateBasis");

                entity.Property(e => e.VfmtMstrDesc)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("vfmtMstr_desc");

                entity.Property(e => e.VfmtMstrGenBasis).HasColumnName("vfmtMstr_genBasis");

                entity.Property(e => e.VfmtMstrIsActive).HasColumnName("vfmtMstr_isActive");

                entity.Property(e => e.VfmtMstrMnemonic)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("vfmtMstr_mnemonic");

                entity.Property(e => e.VfmtMstrName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("vfmtMstr_name");

                entity.Property(e => e.VfmtMstrSubCode).HasColumnName("vfmtMstr_subCode");

                entity.Property(e => e.VfmtVchrFlag)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("vfmt_vchr_flag");

                entity.Property(e => e.VfmtVchrType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("vfmt_vchr_type");

                entity.Property(e => e.VmftVchrTranType).HasColumnName("vmft_vchr_tranType");
            });

            modelBuilder.Entity<PmsWfactivity>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pms_WFActivity");

                entity.Property(e => e.EntityCode).HasColumnName("entity_code");

                entity.Property(e => e.EntityType).HasColumnName("entity_type");

                entity.Property(e => e.FundCode).HasColumnName("fund_code");

                entity.Property(e => e.FundmasterCode).HasColumnName("fundmaster_code");

                entity.Property(e => e.ModuleCode).HasColumnName("module_code");

                entity.Property(e => e.ScreenCode).HasColumnName("screen_code");

                entity.Property(e => e.UserCode).HasColumnName("user_code");

                entity.Property(e => e.WfActivityBy).HasColumnName("wfActivity_By");

                entity.Property(e => e.WfActivityDate)
                    .HasColumnType("datetime")
                    .HasColumnName("wfActivity_date");

                entity.Property(e => e.WfActivityReason)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("wfActivity_reason");

                entity.Property(e => e.WfActivityReferenceNo)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("wfActivity_referenceNo");

                entity.Property(e => e.WfActivitySno).HasColumnName("wfActivity_Sno");

                entity.Property(e => e.WfActivityWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("wfActivity_When");

                entity.Property(e => e.WorkFlowAction).HasColumnName("workFlow_action");

                entity.Property(e => e.WorkFlowCode).HasColumnName("workFlow_code");

                entity.Property(e => e.WorkFlowTemplateSeq).HasColumnName("workFlowTemplate_seq");
            });

            modelBuilder.Entity<PmsWorkFlow>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pms_workFlow");

                entity.Property(e => e.WorkFlowCode).HasColumnName("workFlow_code");

                entity.Property(e => e.WorkFlowCreatedBy).HasColumnName("workFlow_createdBy");

                entity.Property(e => e.WorkFlowCreatedWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("workFlow_createdWhen");

                entity.Property(e => e.WorkFlowDate)
                    .HasColumnType("datetime")
                    .HasColumnName("workFlow_date");

                entity.Property(e => e.WorkFlowDesc)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("workFlow_desc");

                entity.Property(e => e.WorkFlowEntityCode).HasColumnName("workFlowEntity_code");

                entity.Property(e => e.WorkFlowIsActive).HasColumnName("workFlow_isActive");

                entity.Property(e => e.WorkFlowModifiedBy).HasColumnName("workFlow_modifiedBy");

                entity.Property(e => e.WorkFlowModifiedWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("workFlow_modifiedWhen");

                entity.Property(e => e.WorkFlowName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("workFlow_name");

                entity.Property(e => e.WorkFlowStages).HasColumnName("workFlow_stages");
            });

            modelBuilder.Entity<PmsWorkFlowAction>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pms_workFlowAction");

                entity.Property(e => e.WorkFlowActionCode).HasColumnName("workFlowAction_code");

                entity.Property(e => e.WorkFlowActionDesc)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("workFlowAction_desc");

                entity.Property(e => e.WorkFlowActionName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("workFlowAction_name");
            });

            modelBuilder.Entity<PmsWorkFlowEntity>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pms_workFlowEntity");

                entity.Property(e => e.WorkFlowEntityCode).HasColumnName("workFlowEntity_code");

                entity.Property(e => e.WorkFlowEntityDesc)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("workFlowEntity_desc");

                entity.Property(e => e.WorkFlowEntityName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("workFlowEntity_name");
            });

            modelBuilder.Entity<PmsWorkFlowLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pms_workFlowLog");

                entity.Property(e => e.WorkFlowCode).HasColumnName("workFlow_code");

                entity.Property(e => e.WorkFlowCreatedBy).HasColumnName("workFlow_createdBy");

                entity.Property(e => e.WorkFlowCreatedWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("workFlow_createdWhen");

                entity.Property(e => e.WorkFlowDate)
                    .HasColumnType("datetime")
                    .HasColumnName("workFlow_date");

                entity.Property(e => e.WorkFlowDesc)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("workFlow_desc");

                entity.Property(e => e.WorkFlowEntityCode).HasColumnName("workFlowEntity_code");

                entity.Property(e => e.WorkFlowIsActive).HasColumnName("workFlow_isActive");

                entity.Property(e => e.WorkFlowModifiedBy).HasColumnName("workFlow_modifiedBy");

                entity.Property(e => e.WorkFlowModifiedWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("workFlow_modifiedWhen");

                entity.Property(e => e.WorkFlowName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("workFlow_name");

                entity.Property(e => e.WorkFlowSno).HasColumnName("workFlow_sno");

                entity.Property(e => e.WorkFlowStages).HasColumnName("workFlow_stages");
            });

            modelBuilder.Entity<PmsWorkFlowReport>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pms_workFlowReports");

                entity.Property(e => e.WorkFlowReportCode).HasColumnName("workFlowReport_code");

                entity.Property(e => e.WorkFlowReportDesc)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("workFlowReport_desc");

                entity.Property(e => e.WorkFlowReportName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("workFlowReport_name");
            });

            modelBuilder.Entity<PmsWorkFlowTempReport>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pms_workFlowTempReports");

                entity.Property(e => e.ActorCode).HasColumnName("actor_code");

                entity.Property(e => e.ActorType).HasColumnName("actor_type");

                entity.Property(e => e.WorkFlowActionCode).HasColumnName("workFlowAction_code");

                entity.Property(e => e.WorkFlowCode).HasColumnName("workFlow_code");

                entity.Property(e => e.WorkFlowDate)
                    .HasColumnType("datetime")
                    .HasColumnName("workFlow_date");

                entity.Property(e => e.WorkFlowReportCode).HasColumnName("workFlowReport_code");

                entity.Property(e => e.WorkFlowTemReportCode).HasColumnName("workFlowTemReport_code");

                entity.Property(e => e.WorkFlowTemplateSeq).HasColumnName("workFlowTemplate_seq");
            });

            modelBuilder.Entity<PmsWorkFlowTemplate>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pms_workFlowTemplate");

                entity.Property(e => e.ActorCode).HasColumnName("actor_code");

                entity.Property(e => e.ActorType).HasColumnName("actor_type");

                entity.Property(e => e.WorkFlowActionCode).HasColumnName("workFlowAction_code");

                entity.Property(e => e.WorkFlowCode).HasColumnName("workFlow_code");

                entity.Property(e => e.WorkFlowDate)
                    .HasColumnType("datetime")
                    .HasColumnName("workFlow_date");

                entity.Property(e => e.WorkFlowSequenceSkipIsAllowed).HasColumnName("WorkFlowSequenceSkip_IsAllowed");

                entity.Property(e => e.WorkFlowTemplateCreatedBy).HasColumnName("workFlowTemplate_createdBy");

                entity.Property(e => e.WorkFlowTemplateCreatedWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("workFlowTemplate_createdWhen");

                entity.Property(e => e.WorkFlowTemplateDesc)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("workFlowTemplate_desc");

                entity.Property(e => e.WorkFlowTemplateModifiedBy).HasColumnName("workFlowTemplate_modifiedBy");

                entity.Property(e => e.WorkFlowTemplateModifiedWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("workFlowTemplate_modifiedWhen");

                entity.Property(e => e.WorkFlowTemplateName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("workFlowTemplate_name");

                entity.Property(e => e.WorkFlowTemplateSeq).HasColumnName("workFlowTemplate_seq");
            });

            modelBuilder.Entity<PmsWorkFlowTemplateLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pms_workFlowTemplateLog");

                entity.Property(e => e.ActorCode).HasColumnName("actor_code");

                entity.Property(e => e.ActorType).HasColumnName("actor_type");

                entity.Property(e => e.WorkFlowActionCode).HasColumnName("workFlowAction_code");

                entity.Property(e => e.WorkFlowCode).HasColumnName("workFlow_code");

                entity.Property(e => e.WorkFlowSequenceSkipIsAllowed).HasColumnName("WorkFlowSequenceSkip_IsAllowed");

                entity.Property(e => e.WorkFlowTemplateCreatedBy).HasColumnName("workFlowTemplate_createdBy");

                entity.Property(e => e.WorkFlowTemplateCreatedWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("workFlowTemplate_createdWhen");

                entity.Property(e => e.WorkFlowTemplateDesc)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("workFlowTemplate_desc");

                entity.Property(e => e.WorkFlowTemplateModifiedBy).HasColumnName("workFlowTemplate_modifiedBy");

                entity.Property(e => e.WorkFlowTemplateModifiedWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("workFlowTemplate_modifiedWhen");

                entity.Property(e => e.WorkFlowTemplateName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("workFlowTemplate_name");

                entity.Property(e => e.WorkFlowTemplateSeq).HasColumnName("workFlowTemplate_seq");

                entity.Property(e => e.WorkFlowTemplateSno).HasColumnName("workFlowTemplate_sno");
            });

            modelBuilder.Entity<PmsZone>(entity =>
            {
                entity.HasKey(e => e.ZoneCode);

                entity.ToTable("pms_zone");

                entity.Property(e => e.ZoneCode)
                    .ValueGeneratedNever()
                    .HasColumnName("zone_code");

                entity.Property(e => e.ZoneCreatedBy).HasColumnName("zone_createdBy");

                entity.Property(e => e.ZoneCreatedWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("zone_createdWhen");

                entity.Property(e => e.ZoneDesc)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("zone_desc");

                entity.Property(e => e.ZoneModifiedBy).HasColumnName("zone_modifiedBy");

                entity.Property(e => e.ZoneModifiedWhen)
                    .HasColumnType("datetime")
                    .HasColumnName("zone_modifiedWhen");

                entity.Property(e => e.ZoneName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("zone_name");
            });

            modelBuilder.Entity<Update7>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Update7");

                entity.Property(e => e.Col002)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Col003)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Col004).HasColumnType("decimal(13, 3)");

                entity.Property(e => e.Col005).HasColumnType("decimal(13, 3)");

                entity.Property(e => e.Col006).HasColumnType("decimal(13, 3)");

                entity.Property(e => e.Col007)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Col008)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Col009)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Col010)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
