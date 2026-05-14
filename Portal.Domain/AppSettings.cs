namespace Portal.Domain
{
    public class AppSettings
    {
        public string WebStore { get; set; }
        public string AS400Prog { get; set; }
        public string PayRollApiBaseURL { get; set; }
        public string SpectrumStore { get; set; }
        public int NumCheckDays { get; set; }
        public MSSQl MSSQl { get; set; }

        public AS400 AS400 { get; set; }
        public string AuthenticationKey { get; set; }
        public Perq_Appointment perq_Appointment { get; set; }
        public USPS_Validation USPS_Validation { get; set; }
        public DataDogAppSetting DataDog { get; set; }
        public string DispatchApi { get; set; }
        public Email Email { get; set; }
        public ProductCSVs ProductCSV { get; set; }
        public InventoryCSV InventoryCSV { get; set; }

    }
    public class MSSQl
    {
        public string SqlconnectionString { get; set; }
        public string TblSchemaName { get; set; }
        public string SecurityAppConnectionString { get; set; }

        public string DocConnectionString { get; set; }
    }
    public class Perq_Appointment
    {
        public string Auth_Key { get; set; }
    }

    public class USPS_Validation
    {
        public string Client_Key { get; set; }
        public string Client_Secret { get; set; }
        public string Grant_Type { get; set; }
    }

    public class DataDogAppSetting
    {
        public DataDogConfig DataDogConfig { get; set; }
        public DDApiConfig DdApiConfig { get; set; }
    }
    public class AS400
    {
        public string AS400connectionString { get; set; }
        public string AS400LibData { get; set; }
        public string AS400LibSLIN { get; set; }
        public string AS400LibAR { get; set; }
        public string AS400LibME { get; set; }
        public string AS400LibARME { get; set; }

        public string AS400libAPGL { get; set; }
        public string AS400libAPYRL { get; set; }

    }
    public class DataDogConfig
    {
        public string ddsource { get; set; }
        public string ddtags { get; set; }
        public string hostname { get; set; }
        public string message { get; set; }
        public string service { get; set; }
        public string status { get; set; }

    }
    public class DDApiConfig
    {
        public string DDAPIKEY { get; set; }
        public string DataDogURL { get; set; }
    }

    public class Email
    {
        public string SenderEmail { get; set; }
        public string RecipientEmail { get; set; }
        public int SmtpPort { get; set; }
        public string SmtpServer { get; set; }
        public string HtmlTemplet { get; set; }
        public string SuccessTemplet { get; set; }
    }
    public class ProductCSVs
    {
        public string CsvProductFilePath { get; set; }
    }
    public class InventoryCSV
    {
        public string CsvInventoryFilePath { get; set; }
    }
    public class DispatchTrackConfig
    {
        public string DispatchApi { get; set; }
    }
}
