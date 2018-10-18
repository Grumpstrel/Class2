using System;
using System.Collections.Generic;
using System.Text;

namespace CarRentalApp
{
    enum InsuranceCoverageType
    {
        FullCoverage,
        LiabilityOnly
    }
    class InsuranceInformation
    {
        #region Properties
        public string CompanyName { get; set; }
        public string InsuranceCompanyAccountNumber { get; set; }
        public InsuranceCoverageType TypeOfCoverage { get; set; }
        #endregion

        public static InsuranceInformation(string companyName, string insuranceCompanyAccountNumber, string InsuranceCoverageType)
        {
            return;
        }
    }
}
