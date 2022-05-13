namespace MinhaPrimeiraWebApi.Entities
{
    public class Customers
    {
        public string rate { get; set; }
    }

    public class Price
    {
        public string interval { get; set; }
        public string value { get; set; }
        public string currency { get; set; }
        public Customers customers { get; set; }
        public string monthlyFee { get; set; }
    }

    public class Minimum
    {
        public string value { get; set; }
        public string currency { get; set; }
    }

    public class Maximum
    {
        public string value { get; set; }
        public string currency { get; set; }
    }

    public class PriorityService
    {
        public string name { get; set; }
        public string code { get; set; }
        public string chargingTriggerInfo { get; set; }
        public List<Price> prices { get; set; }
        public Minimum minimum { get; set; }
        public Maximum maximum { get; set; }
    }

    public class OtherService
    {
        public string name { get; set; }
        public string code { get; set; }
        public string chargingTriggerInfo { get; set; }
        public List<Price> prices { get; set; }
        public Minimum minimum { get; set; }
        public Maximum maximum { get; set; }
    }

    public class Fees
    {
        public List<PriorityService> priorityServices { get; set; }
        public List<OtherService> otherServices { get; set; }
    }

    public class Service
    {
        public string code { get; set; }
        public string chargingTriggerInfo { get; set; }
        public string eventLimitQuantity { get; set; }
        public string freeEventQuantity { get; set; }
    }

    public class ServiceBundle
    {
        public string name { get; set; }
        public List<Service> services { get; set; }
        public List<Price> prices { get; set; }
        public Minimum minimum { get; set; }
        public Maximum maximum { get; set; }
    }

    public class MinimumBalance
    {
        public string value { get; set; }
        public string currency { get; set; }
    }

    public class TermsConditions
    {
        public MinimumBalance minimumBalance { get; set; }
        public string elegibilityCriteriaInfo { get; set; }
        public string closingProcessInfo { get; set; }
    }

    public class IncomeRate
    {
        public string savingAccount { get; set; }
        public string prepaidPaymentAccount { get; set; }
    }

    public class PersonalAccount
    {
        public string type { get; set; }
        public Fees fees { get; set; }
        public List<ServiceBundle> serviceBundles { get; set; }
        public List<string> openingClosingChannels { get; set; }
        public string additionalInfo { get; set; }
        public List<string> transactionMethods { get; set; }
        public TermsConditions termsConditions { get; set; }
        public IncomeRate incomeRate { get; set; }
    }

    public class Company
    {
        public string name { get; set; }
        public string cnpjNumber { get; set; }
        public string urlComplementaryList { get; set; }
        public List<PersonalAccount> personalAccounts { get; set; }
    }

    public class Brand
    {
        public string name { get; set; }
        public List<Company> companies { get; set; }
    }

    public class Data
    {
        public Brand brand { get; set; }
    }

    public class Links
    {
        public string self { get; set; }
        public string first { get; set; }
        public string last { get; set; }
    }

    public class Meta
    {
        public int totalRecords { get; set; }
        public int totalPages { get; set; }
    }

    public class Root
    {
        public Data data { get; set; }
        public Links links { get; set; }
        public Meta meta { get; set; }
    }
}
