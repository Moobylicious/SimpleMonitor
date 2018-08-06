//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SimpleMonitor.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class vwIISLog
    {
        public int Id { get; set; }
        public string LogFilename { get; set; }
        public Nullable<int> LogRow { get; set; }
        public string date { get; set; }
        public Nullable<System.DateTime> time { get; set; }
        public string cIp { get; set; }
        public string csUsername { get; set; }
        public string sSitename { get; set; }
        public string sComputername { get; set; }
        public string sIp { get; set; }
        public int sPort { get; set; }
        public string csMethod { get; set; }
        public string csUriStem { get; set; }
        public string csUriQuery { get; set; }
        public int scStatus { get; set; }
        public Nullable<int> scSubstatus { get; set; }
        public Nullable<int> scWin32Status { get; set; }
        public Nullable<int> scBytes { get; set; }
        public Nullable<int> csBytes { get; set; }
        public Nullable<int> timeTaken { get; set; }
        public string csVersion { get; set; }
        public string csHost { get; set; }
        public string csUserAgent { get; set; }
        public string csCookie { get; set; }
        public string csReferer { get; set; }
        public string sEvent { get; set; }
        public string sProcessType { get; set; }
        public Nullable<float> sUserTime { get; set; }
        public Nullable<float> sKernelTime { get; set; }
        public Nullable<int> sPageFaults { get; set; }
        public Nullable<int> sTotalProcs { get; set; }
        public Nullable<int> sActiveProcs { get; set; }
        public Nullable<int> sStoppedProcs { get; set; }
        public string IsBlocked { get; set; }
        public int BlockHit { get; set; }
        public string ApplicationName { get; set; }
    }
}