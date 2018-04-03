using System;
using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace designpatterns
{
    class CurrentValutaRate : Valuta
    {
        public string getBase()
        {
            return "";
        }

        public partial class Currency
        {
            [Json("success")]
            public bool Success { get; set; }
            [Json("timestamp")]
            public long Timestamp { get; set; }
            [Json("base")]
            public string Base { get; set; }
            [Json("date")]
            public System.DateTimeOffset Date { get; set; }
            [Json("rates")]
            public Rates Rates { get; set; }
        }

        public partial class Rates
        {
            [Json("AED")]
            public double Aed { get; set; }
            [Json("AFN")]
            public double Afn { get; set; }
            [Json("ALL")]
            public double All { get; set; }
            [Json("AMD")]
            public double Amd { get; set; }
            [Json("ANG")]
            public double Ang { get; set; }
            [Json("AOA")]
            public double Aoa { get; set; }
            [Json("ARS")]
            public double Ars { get; set; }
            [Json("AUD")]
            public double Aud { get; set; }
            [Json("AWG")]
            public double Awg { get; set; }
            [Json("AZN")]
            public double Azn { get; set; }
            [Json("BAM")]
            public double Bam { get; set; }
            [Json("BBD")]
            public double Bbd { get; set; }
            [Json("BDT")]
            public double Bdt { get; set; }
            [Json("BGN")]
            public double Bgn { get; set; }
            [Json("BHD")]
            public double Bhd { get; set; }
            [Json("BIF")]
            public double Bif { get; set; }
            [Json("BMD")]
            public double Bmd { get; set; }
            [Json("BND")]
            public double Bnd { get; set; }
            [Json("BOB")]
            public double Bob { get; set; }
            [Json("BRL")]
            public double Brl { get; set; }
            [Json("BSD")]
            public double Bsd { get; set; }
            [Json("BTC")]
            public double Btc { get; set; }
            [Json("BTN")]
            public double Btn { get; set; }
            [Json("BWP")]
            public double Bwp { get; set; }
            [Json("BYN")]
            public double Byn { get; set; }
            [Json("BYR")]
            public double Byr { get; set; }
            [Json("BZD")]
            public double Bzd { get; set; }
            [Json("CAD")]
            public double Cad { get; set; }
            [Json("CDF")]
            public double Cdf { get; set; }
            [Json("CHF")]
            public double Chf { get; set; }
            [Json("CLF")]
            public double Clf { get; set; }
            [Json("CLP")]
            public double Clp { get; set; }
            [Json("CNY")]
            public double Cny { get; set; }
            [Json("COP")]
            public double Cop { get; set; }
            [Json("CRC")]
            public double Crc { get; set; }
            [Json("CUC")]
            public double Cuc { get; set; }
            [Json("CUP")]
            public double Cup { get; set; }
            [Json("CVE")]
            public double Cve { get; set; }
            [Json("CZK")]
            public double Czk { get; set; }
            [Json("DJF")]
            public double Djf { get; set; }
            [Json("DKK")]
            public double Dkk { get; set; }
            [Json("DOP")]
            public double Dop { get; set; }
            [Json("DZD")]
            public double Dzd { get; set; }
            [Json("EGP")]
            public double Egp { get; set; }
            [Json("ERN")]
            public double Ern { get; set; }
            [Json("ETB")]
            public double Etb { get; set; }
            [Json("EUR")]
            public long Eur { get; set; }
            [Json("FJD")]
            public double Fjd { get; set; }
            [Json("FKP")]
            public double Fkp { get; set; }
            [Json("GBP")]
            public double Gbp { get; set; }
            [Json("GEL")]
            public double Gel { get; set; }
            [Json("GGP")]
            public double Ggp { get; set; }
            [Json("GHS")]
            public double Ghs { get; set; }
            [Json("GIP")]
            public double Gip { get; set; }
            [Json("GMD")]
            public double Gmd { get; set; }
            [Json("GNF")]
            public double Gnf { get; set; }
            [Json("GTQ")]
            public double Gtq { get; set; }
            [Json("GYD")]
            public double Gyd { get; set; }
            [Json("HKD")]
            public double Hkd { get; set; }
            [Json("HNL")]
            public double Hnl { get; set; }
            [Json("HRK")]
            public double Hrk { get; set; }
            [Json("HTG")]
            public double Htg { get; set; }
            [Json("HUF")]
            public double Huf { get; set; }
            [Json("IDR")]
            public double Idr { get; set; }
            [Json("ILS")]
            public double Ils { get; set; }
            [Json("IMP")]
            public double Imp { get; set; }
            [Json("INR")]
            public double Inr { get; set; }
            [Json("IQD")]
            public double Iqd { get; set; }
            [Json("IRR")]
            public double Irr { get; set; }
            [Json("ISK")]
            public double Isk { get; set; }
            [Json("JEP")]
            public double Jep { get; set; }
            [Json("JMD")]
            public double Jmd { get; set; }
            [Json("JOD")]
            public double Jod { get; set; }
            [Json("JPY")]
            public double Jpy { get; set; }
            [Json("KES")]
            public double Kes { get; set; }
            [Json("KGS")]
            public double Kgs { get; set; }
            [Json("KHR")]
            public double Khr { get; set; }
            [Json("KMF")]
            public double Kmf { get; set; }
            [Json("KPW")]
            public double Kpw { get; set; }
            [Json("KRW")]
            public double Krw { get; set; }
            [Json("KWD")]
            public double Kwd { get; set; }
            [Json("KYD")]
            public double Kyd { get; set; }
            [Json("KZT")]
            public double Kzt { get; set; }
            [Json("LAK")]
            public double Lak { get; set; }
            [Json("LBP")]
            public double Lbp { get; set; }
            [Json("LKR")]
            public double Lkr { get; set; }
            [Json("LRD")]
            public double Lrd { get; set; }
            [Json("LSL")]
            public double Lsl { get; set; }
            [Json("LTL")]
            public double Ltl { get; set; }
            [Json("LVL")]
            public double Lvl { get; set; }
            [Json("LYD")]
            public double Lyd { get; set; }
            [Json("MAD")]
            public double Mad { get; set; }
            [Json("MDL")]
            public double Mdl { get; set; }
            [Json("MGA")]
            public double Mga { get; set; }
            [Json("MKD")]
            public double Mkd { get; set; }
            [Json("MMK")]
            public double Mmk { get; set; }
            [Json("MNT")]
            public double Mnt { get; set; }
            [Json("MOP")]
            public double Mop { get; set; }
            [Json("MRO")]
            public double Mro { get; set; }
            [Json("MUR")]
            public double Mur { get; set; }
            [Json("MVR")]
            public double Mvr { get; set; }
            [Json("MWK")]
            public double Mwk { get; set; }
            [Json("MXN")]
            public double Mxn { get; set; }
            [Json("MYR")]
            public double Myr { get; set; }
            [Json("MZN")]
            public double Mzn { get; set; }
            [Json("NAD")]
            public double Nad { get; set; }
            [Json("NGN")]
            public double Ngn { get; set; }
            [Json("NIO")]
            public double Nio { get; set; }
            [Json("NOK")]
            public double Nok { get; set; }
            [Json("NPR")]
            public double Npr { get; set; }
            [Json("NZD")]
            public double Nzd { get; set; }
            [Json("OMR")]
            public double Omr { get; set; }
            [Json("PAB")]
            public double Pab { get; set; }
            [Json("PEN")]
            public double Pen { get; set; }
            [Json("PGK")]
            public double Pgk { get; set; }
            [Json("PHP")]
            public double Php { get; set; }
            [Json("PKR")]
            public double Pkr { get; set; }
            [Json("PLN")]
            public double Pln { get; set; }
            [Json("PYG")]
            public double Pyg { get; set; }
            [Json("QAR")]
            public double Qar { get; set; }
            [Json("RON")]
            public double Ron { get; set; }
            [Json("RSD")]
            public double Rsd { get; set; }
            [Json("RUB")]
            public double Rub { get; set; }
            [Json("RWF")]
            public double Rwf { get; set; }
            [Json("SAR")]
            public double Sar { get; set; }
            [Json("SBD")]
            public double Sbd { get; set; }
            [Json("SCR")]
            public double Scr { get; set; }
            [Json("SDG")]
            public double Sdg { get; set; }
            [Json("SEK")]
            public double Sek { get; set; }
            [Json("SGD")]
            public double Sgd { get; set; }
            [Json("SHP")]
            public double Shp { get; set; }
            [Json("SLL")]
            public double Sll { get; set; }
            [Json("SOS")]
            public double Sos { get; set; }
            [Json("SRD")]
            public double Srd { get; set; }
            [Json("STD")]
            public double Std { get; set; }
            [Json("SVC")]
            public double Svc { get; set; }
            [Json("SYP")]
            public double Syp { get; set; }
            [Json("SZL")]
            public double Szl { get; set; }
            [Json("THB")]
            public double Thb { get; set; }
            [Json("TJS")]
            public double Tjs { get; set; }
            [Json("TMT")]
            public double Tmt { get; set; }
            [Json("TND")]
            public double Tnd { get; set; }
            [Json("TOP")]
            public double Top { get; set; }
            [Json("TRY")]
            public double Try { get; set; }
            [Json("TTD")]
            public double Ttd { get; set; }
            [Json("TWD")]
            public double Twd { get; set; }
            [Json("TZS")]
            public double Tzs { get; set; }
            [Json("UAH")]
            public double Uah { get; set; }
            [Json("UGX")]
            public double Ugx { get; set; }
            [Json("USD")]
            public double Usd { get; set; }
            [Json("UYU")]
            public double Uyu { get; set; }
            [Json("UZS")]
            public double Uzs { get; set; }
            [Json("VEF")]
            public double Vef { get; set; }
            [Json("VND")]
            public double Vnd { get; set; }
            [Json("VUV")]
            public double Vuv { get; set; }
            [Json("WST")]
            public double Wst { get; set; }
            [Json("XAF")]
            public double Xaf { get; set; }
            [Json("XAG")]
            public double Xag { get; set; }
            [Json("XAU")]
            public double Xau { get; set; }
            [Json("XCD")]
            public double Xcd { get; set; }
            [Json("XDR")]
            public double Xdr { get; set; }
            [Json("XOF")]
            public double Xof { get; set; }
            [Json("XPF")]
            public double Xpf { get; set; }
            [Json("YER")]
            public double Yer { get; set; }
            [Json("ZAR")]
            public double Zar { get; set; }
            [Json("ZMK")]
            public double Zmk { get; set; }
            [Json("ZMW")]
            public double Zmw { get; set; }
            [Json("ZWL")]
            public double Zwl { get; set; }
        }
    }
}
